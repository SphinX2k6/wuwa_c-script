using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Threading
{
	// Token: 0x020003C5 RID: 965
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class AbandonedMutexException : SystemException
	{
		// Token: 0x06003F64 RID: 16228 RVA: 0x000D3E7E File Offset: 0x000D207E
		public AbandonedMutexException() : base(SR.Threading_AbandonedMutexException)
		{
			base.HResult = -2146233043;
		}

		// Token: 0x06003F65 RID: 16229 RVA: 0x000D3E9D File Offset: 0x000D209D
		public AbandonedMutexException(string message) : base(message ?? SR.Threading_AbandonedMutexException)
		{
			base.HResult = -2146233043;
		}

		// Token: 0x06003F66 RID: 16230 RVA: 0x000D3EC1 File Offset: 0x000D20C1
		public AbandonedMutexException(string message, Exception inner) : base(message ?? SR.Threading_AbandonedMutexException, inner)
		{
			base.HResult = -2146233043;
		}

		// Token: 0x06003F67 RID: 16231 RVA: 0x000D3EE6 File Offset: 0x000D20E6
		public AbandonedMutexException(int location, WaitHandle handle) : base(SR.Threading_AbandonedMutexException)
		{
			base.HResult = -2146233043;
			this.SetupException(location, handle);
		}

		// Token: 0x06003F68 RID: 16232 RVA: 0x000D3F0D File Offset: 0x000D210D
		public AbandonedMutexException(string message, int location, WaitHandle handle) : base(message ?? SR.Threading_AbandonedMutexException)
		{
			base.HResult = -2146233043;
			this.SetupException(location, handle);
		}

		// Token: 0x06003F69 RID: 16233 RVA: 0x000D3F39 File Offset: 0x000D2139
		public AbandonedMutexException(string message, Exception inner, int location, WaitHandle handle) : base(message ?? SR.Threading_AbandonedMutexException, inner)
		{
			base.HResult = -2146233043;
			this.SetupException(location, handle);
		}

		// Token: 0x06003F6A RID: 16234 RVA: 0x000D3F67 File Offset: 0x000D2167
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected AbandonedMutexException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06003F6B RID: 16235 RVA: 0x000D3F78 File Offset: 0x000D2178
		private void SetupException(int location, WaitHandle handle)
		{
			this._mutexIndex = location;
			this._mutex = (handle as Mutex);
		}

		// Token: 0x17000B97 RID: 2967
		// (get) Token: 0x06003F6C RID: 16236 RVA: 0x000D3F8D File Offset: 0x000D218D
		public Mutex Mutex
		{
			get
			{
				return this._mutex;
			}
		}

		// Token: 0x17000B98 RID: 2968
		// (get) Token: 0x06003F6D RID: 16237 RVA: 0x000D3F95 File Offset: 0x000D2195
		public int MutexIndex
		{
			get
			{
				return this._mutexIndex;
			}
		}

		// Token: 0x04000D10 RID: 3344
		private int _mutexIndex = -1;

		// Token: 0x04000D11 RID: 3345
		private Mutex _mutex;
	}
}
