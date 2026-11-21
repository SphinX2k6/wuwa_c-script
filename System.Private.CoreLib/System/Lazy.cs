using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System
{
	// Token: 0x0200015D RID: 349
	[NullableContext(1)]
	[Nullable(0)]
	[DebuggerTypeProxy(typeof(LazyDebugView<>))]
	[DebuggerDisplay("ThreadSafetyMode = {Mode}, IsValueCreated = {IsValueCreated}, IsValueFaulted = {IsValueFaulted}, Value = {ValueForDebugDisplay}")]
	public class Lazy<[Nullable(2), DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)] T>
	{
		// Token: 0x06001716 RID: 5910 RVA: 0x00046155 File Offset: 0x00044355
		private static T CreateViaDefaultConstructor()
		{
			return LazyHelper.CreateViaDefaultConstructor<T>();
		}

		// Token: 0x06001717 RID: 5911 RVA: 0x0004615C File Offset: 0x0004435C
		public Lazy() : this(null, LazyThreadSafetyMode.ExecutionAndPublication, true)
		{
		}

		// Token: 0x06001718 RID: 5912 RVA: 0x00046167 File Offset: 0x00044367
		public Lazy(T value)
		{
			this._value = value;
		}

		// Token: 0x06001719 RID: 5913 RVA: 0x00046176 File Offset: 0x00044376
		public Lazy(Func<T> valueFactory) : this(valueFactory, LazyThreadSafetyMode.ExecutionAndPublication, false)
		{
		}

		// Token: 0x0600171A RID: 5914 RVA: 0x00046181 File Offset: 0x00044381
		public Lazy(bool isThreadSafe) : this(null, LazyHelper.GetModeFromIsThreadSafe(isThreadSafe), true)
		{
		}

		// Token: 0x0600171B RID: 5915 RVA: 0x00046191 File Offset: 0x00044391
		public Lazy(LazyThreadSafetyMode mode) : this(null, mode, true)
		{
		}

		// Token: 0x0600171C RID: 5916 RVA: 0x0004619C File Offset: 0x0004439C
		public Lazy(Func<T> valueFactory, bool isThreadSafe) : this(valueFactory, LazyHelper.GetModeFromIsThreadSafe(isThreadSafe), false)
		{
		}

		// Token: 0x0600171D RID: 5917 RVA: 0x000461AC File Offset: 0x000443AC
		public Lazy(Func<T> valueFactory, LazyThreadSafetyMode mode) : this(valueFactory, mode, false)
		{
		}

		// Token: 0x0600171E RID: 5918 RVA: 0x000461B7 File Offset: 0x000443B7
		private Lazy(Func<T> valueFactory, LazyThreadSafetyMode mode, bool useDefaultConstructor)
		{
			if (!useDefaultConstructor)
			{
				ArgumentNullException.ThrowIfNull(valueFactory, "valueFactory");
			}
			this._factory = valueFactory;
			this._state = LazyHelper.Create(mode, useDefaultConstructor);
		}

		// Token: 0x0600171F RID: 5919 RVA: 0x000461E3 File Offset: 0x000443E3
		private void ViaConstructor()
		{
			this._value = Lazy<T>.CreateViaDefaultConstructor();
			this._state = null;
		}

		// Token: 0x06001720 RID: 5920 RVA: 0x000461FC File Offset: 0x000443FC
		private void ViaFactory(LazyThreadSafetyMode mode)
		{
			try
			{
				Func<T> factory = this._factory;
				if (factory == null)
				{
					throw new InvalidOperationException(SR.Lazy_Value_RecursiveCallsToValue);
				}
				Func<T> func = factory;
				this._factory = null;
				this._value = func();
				this._state = null;
			}
			catch (Exception exception)
			{
				this._state = new LazyHelper(mode, exception);
				throw;
			}
		}

		// Token: 0x06001721 RID: 5921 RVA: 0x00046260 File Offset: 0x00044460
		private void ExecutionAndPublication(LazyHelper executionAndPublication, bool useDefaultConstructor)
		{
			lock (executionAndPublication)
			{
				if (this._state == executionAndPublication)
				{
					if (useDefaultConstructor)
					{
						this.ViaConstructor();
					}
					else
					{
						this.ViaFactory(LazyThreadSafetyMode.ExecutionAndPublication);
					}
				}
			}
		}

		// Token: 0x06001722 RID: 5922 RVA: 0x000462B4 File Offset: 0x000444B4
		private void PublicationOnly(LazyHelper publicationOnly, T possibleValue)
		{
			if (Interlocked.CompareExchange<LazyHelper>(ref this._state, LazyHelper.PublicationOnlyWaitForOtherThreadToPublish, publicationOnly) == publicationOnly)
			{
				this._factory = null;
				this._value = possibleValue;
				this._state = null;
			}
		}

		// Token: 0x06001723 RID: 5923 RVA: 0x000462E1 File Offset: 0x000444E1
		private void PublicationOnlyViaConstructor(LazyHelper initializer)
		{
			this.PublicationOnly(initializer, Lazy<T>.CreateViaDefaultConstructor());
		}

		// Token: 0x06001724 RID: 5924 RVA: 0x000462F0 File Offset: 0x000444F0
		private void PublicationOnlyViaFactory(LazyHelper initializer)
		{
			Func<T> factory = this._factory;
			if (factory == null)
			{
				this.PublicationOnlyWaitForOtherThreadToPublish();
				return;
			}
			this.PublicationOnly(initializer, factory());
		}

		// Token: 0x06001725 RID: 5925 RVA: 0x0004631C File Offset: 0x0004451C
		private void PublicationOnlyWaitForOtherThreadToPublish()
		{
			SpinWait spinWait = default(SpinWait);
			while (this._state != null)
			{
				spinWait.SpinOnce();
			}
		}

		// Token: 0x06001726 RID: 5926 RVA: 0x00046344 File Offset: 0x00044544
		private T CreateValue()
		{
			LazyHelper state = this._state;
			if (state != null)
			{
				switch (state.State)
				{
				case LazyState.NoneViaConstructor:
					this.ViaConstructor();
					goto IL_84;
				case LazyState.NoneViaFactory:
					this.ViaFactory(LazyThreadSafetyMode.None);
					goto IL_84;
				case LazyState.PublicationOnlyViaConstructor:
					this.PublicationOnlyViaConstructor(state);
					goto IL_84;
				case LazyState.PublicationOnlyViaFactory:
					this.PublicationOnlyViaFactory(state);
					goto IL_84;
				case LazyState.PublicationOnlyWait:
					this.PublicationOnlyWaitForOtherThreadToPublish();
					goto IL_84;
				case LazyState.ExecutionAndPublicationViaConstructor:
					this.ExecutionAndPublication(state, true);
					goto IL_84;
				case LazyState.ExecutionAndPublicationViaFactory:
					this.ExecutionAndPublication(state, false);
					goto IL_84;
				}
				state.ThrowException();
			}
			IL_84:
			return this.Value;
		}

		// Token: 0x06001727 RID: 5927 RVA: 0x000463DC File Offset: 0x000445DC
		[NullableContext(2)]
		public override string ToString()
		{
			if (!this.IsValueCreated)
			{
				return SR.Lazy_ToString_ValueNotCreated;
			}
			T value = this.Value;
			return value.ToString();
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06001728 RID: 5928 RVA: 0x0004640C File Offset: 0x0004460C
		[Nullable(2)]
		internal T ValueForDebugDisplay
		{
			get
			{
				if (!this.IsValueCreated)
				{
					return default(T);
				}
				return this._value;
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06001729 RID: 5929 RVA: 0x00046431 File Offset: 0x00044631
		internal LazyThreadSafetyMode? Mode
		{
			get
			{
				return LazyHelper.GetMode(this._state);
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x0600172A RID: 5930 RVA: 0x00046440 File Offset: 0x00044640
		internal bool IsValueFaulted
		{
			get
			{
				return LazyHelper.GetIsValueFaulted(this._state);
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x0600172B RID: 5931 RVA: 0x0004644F File Offset: 0x0004464F
		public bool IsValueCreated
		{
			get
			{
				return this._state == null;
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x0600172C RID: 5932 RVA: 0x0004645C File Offset: 0x0004465C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public T Value
		{
			get
			{
				if (this._state != null)
				{
					return this.CreateValue();
				}
				return this._value;
			}
		}

		// Token: 0x040004DB RID: 1243
		private volatile LazyHelper _state;

		// Token: 0x040004DC RID: 1244
		private Func<T> _factory;

		// Token: 0x040004DD RID: 1245
		private T _value;
	}
}
