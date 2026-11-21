using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020001FD RID: 509
	[NullableContext(1)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public sealed class WeakReference<[Nullable(2)] T> : ISerializable where T : class
	{
		// Token: 0x0600287C RID: 10364 RVA: 0x0007D38C File Offset: 0x0007B58C
		public WeakReference(T target) : this(target, false)
		{
		}

		// Token: 0x0600287D RID: 10365 RVA: 0x0007D396 File Offset: 0x0007B596
		public WeakReference(T target, bool trackResurrection)
		{
			this.Create(target, trackResurrection);
		}

		// Token: 0x0600287E RID: 10366 RVA: 0x0007D3A8 File Offset: 0x0007B5A8
		private WeakReference(SerializationInfo info, StreamingContext context)
		{
			ArgumentNullException.ThrowIfNull(info, "info");
			T target = (T)((object)info.GetValue("TrackedObject", typeof(T)));
			bool boolean = info.GetBoolean("TrackResurrection");
			this.Create(target, boolean);
		}

		// Token: 0x0600287F RID: 10367 RVA: 0x0007D3F8 File Offset: 0x0007B5F8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool TryGetTarget([MaybeNullWhen(false)] [NotNullWhen(true)] out T target)
		{
			T target2 = this.Target;
			target = target2;
			return target2 != null;
		}

		// Token: 0x06002880 RID: 10368 RVA: 0x0007D41C File Offset: 0x0007B61C
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			ArgumentNullException.ThrowIfNull(info, "info");
			info.AddValue("TrackedObject", this.Target, typeof(T));
			info.AddValue("TrackResurrection", this.IsTrackResurrection());
		}

		// Token: 0x06002881 RID: 10369 RVA: 0x0007D45A File Offset: 0x0007B65A
		private bool IsTrackResurrection()
		{
			return (this._taggedHandle & (IntPtr)1) > (IntPtr)0;
		}

		// Token: 0x06002882 RID: 10370 RVA: 0x0007D46C File Offset: 0x0007B66C
		private void Create(T target, bool trackResurrection)
		{
			IntPtr intPtr = GCHandle.InternalAlloc(target, trackResurrection ? GCHandleType.WeakTrackResurrection : GCHandleType.Weak);
			this._taggedHandle = (trackResurrection ? (intPtr | (IntPtr)1) : intPtr);
		}

		// Token: 0x06002883 RID: 10371 RVA: 0x0007D49C File Offset: 0x0007B69C
		public void SetTarget(T target)
		{
			IntPtr intPtr = this._taggedHandle & ~(IntPtr)1;
			if (intPtr == 0)
			{
				throw new InvalidOperationException(SR.InvalidOperation_HandleIsNotInitialized);
			}
			GCHandle.InternalSet(intPtr, target);
			GC.KeepAlive(this);
		}

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x06002884 RID: 10372 RVA: 0x0007D4C8 File Offset: 0x0007B6C8
		[Nullable(2)]
		private T Target
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				IntPtr intPtr = this._taggedHandle & ~(IntPtr)1;
				if (intPtr == 0)
				{
					return default(T);
				}
				T result = Unsafe.As<T>(GCHandle.InternalGet(intPtr));
				GC.KeepAlive(this);
				return result;
			}
		}

		// Token: 0x06002885 RID: 10373 RVA: 0x0007D500 File Offset: 0x0007B700
		~WeakReference()
		{
		}

		// Token: 0x0400071C RID: 1820
		private IntPtr _taggedHandle;
	}
}
