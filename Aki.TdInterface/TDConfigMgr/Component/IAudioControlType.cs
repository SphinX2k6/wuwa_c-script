using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001D3 RID: 467
	[NullableContext(1)]
	[Nullable(0)]
	public class IAudioControlType
	{
		// Token: 0x0600077C RID: 1916 RVA: 0x00025050 File Offset: 0x00023250
		private IAudioControlType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAudioControlType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAudioControlType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAudioControlType_SetValue());
			}
			return result;
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x00025088 File Offset: 0x00023288
		public static IAudioControlType Create([Nullable(2)] IAudioControlType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAudioControlType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x0002509B File Offset: 0x0002329B
		public static IAudioControlType CreateFromSetValue([Nullable(2)] IAudioControlType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAudioControlType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x000250AE File Offset: 0x000232AE
		public IAudioControlType_SetValue ToSetValue()
		{
			return new IAudioControlType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000780 RID: 1920 RVA: 0x000250C1 File Offset: 0x000232C1
		// (set) Token: 0x06000781 RID: 1921 RVA: 0x000250EC File Offset: 0x000232EC
		public virtual EAudioControlType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EAudioControlType.Gramophone;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040008A7 RID: 2215
		[Nullable(2)]
		protected IAudioControlType FbInstance;

		// Token: 0x040008A8 RID: 2216
		[Nullable(2)]
		protected IAudioControlType_SetValue PocoInterface;
	}
}
