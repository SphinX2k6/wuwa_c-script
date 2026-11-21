using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020001FC RID: 508
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class WeakReference : ISerializable
	{
		// Token: 0x06002870 RID: 10352 RVA: 0x0007D1D8 File Offset: 0x0007B3D8
		public WeakReference(object target) : this(target, false)
		{
		}

		// Token: 0x06002871 RID: 10353 RVA: 0x0007D1E2 File Offset: 0x0007B3E2
		public WeakReference(object target, bool trackResurrection)
		{
			this.Create(target, trackResurrection);
		}

		// Token: 0x06002872 RID: 10354 RVA: 0x0007D1F4 File Offset: 0x0007B3F4
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected WeakReference(SerializationInfo info, StreamingContext context)
		{
			ArgumentNullException.ThrowIfNull(info, "info");
			object value = info.GetValue("TrackedObject", typeof(object));
			bool boolean = info.GetBoolean("TrackResurrection");
			this.Create(value, boolean);
		}

		// Token: 0x06002873 RID: 10355 RVA: 0x0007D23C File Offset: 0x0007B43C
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			ArgumentNullException.ThrowIfNull(info, "info");
			info.AddValue("TrackedObject", this.Target, typeof(object));
			info.AddValue("TrackResurrection", this.IsTrackResurrection());
		}

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x06002874 RID: 10356 RVA: 0x0007D275 File Offset: 0x0007B475
		public virtual bool TrackResurrection
		{
			get
			{
				return this.IsTrackResurrection();
			}
		}

		// Token: 0x06002875 RID: 10357 RVA: 0x0007D280 File Offset: 0x0007B480
		private void Create(object target, bool trackResurrection)
		{
			IntPtr intPtr = GCHandle.InternalAlloc(target, trackResurrection ? GCHandleType.WeakTrackResurrection : GCHandleType.Weak);
			this._taggedHandle = (trackResurrection ? (intPtr | (IntPtr)1) : intPtr);
		}

		// Token: 0x06002876 RID: 10358 RVA: 0x0007D2AB File Offset: 0x0007B4AB
		private bool IsTrackResurrection()
		{
			return (this._taggedHandle & (IntPtr)1) > (IntPtr)0;
		}

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x06002877 RID: 10359 RVA: 0x0007D2BA File Offset: 0x0007B4BA
		internal IntPtr WeakHandle
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return this._taggedHandle & ~(IntPtr)1;
			}
		}

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x06002878 RID: 10360 RVA: 0x0007D2C8 File Offset: 0x0007B4C8
		public virtual bool IsAlive
		{
			get
			{
				IntPtr weakHandle = this.WeakHandle;
				if (weakHandle == 0)
				{
					return false;
				}
				bool result = GCHandle.InternalGet(weakHandle) != null;
				GC.KeepAlive(this);
				return result;
			}
		}

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x06002879 RID: 10361 RVA: 0x0007D2F0 File Offset: 0x0007B4F0
		// (set) Token: 0x0600287A RID: 10362 RVA: 0x0007D319 File Offset: 0x0007B519
		public virtual object Target
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				IntPtr intPtr = this._taggedHandle & ~(IntPtr)1;
				if (intPtr == 0)
				{
					return null;
				}
				object result = GCHandle.InternalGet(intPtr);
				GC.KeepAlive(this);
				return result;
			}
			set
			{
				IntPtr intPtr = this._taggedHandle & ~(IntPtr)1;
				if (intPtr == 0)
				{
					throw new InvalidOperationException(SR.InvalidOperation_HandleIsNotInitialized);
				}
				GCHandle.InternalSet(intPtr, value);
				GC.KeepAlive(this);
			}
		}

		// Token: 0x0600287B RID: 10363 RVA: 0x0007D340 File Offset: 0x0007B540
		protected override void Finalize()
		{
			try
			{
				IntPtr intPtr = this._taggedHandle & ~(IntPtr)1;
				if (intPtr != 0)
				{
					GCHandle.InternalFree(intPtr);
					this._taggedHandle &= (IntPtr)1;
				}
			}
			finally
			{
				base.Finalize();
			}
		}

		// Token: 0x0400071B RID: 1819
		private IntPtr _taggedHandle;
	}
}
