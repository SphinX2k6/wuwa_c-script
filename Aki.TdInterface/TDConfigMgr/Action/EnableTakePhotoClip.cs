using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017B7 RID: 6071
	public class EnableTakePhotoClip : ActionParams
	{
		// Token: 0x0600836D RID: 33645 RVA: 0x0013A750 File Offset: 0x00138950
		private EnableTakePhotoClip_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("EnableTakePhotoClip 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			EnableTakePhotoClip_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new EnableTakePhotoClip_SetValue());
			}
			return result;
		}

		// Token: 0x0600836E RID: 33646 RVA: 0x0013A788 File Offset: 0x00138988
		public static EnableTakePhotoClip Create([Nullable(2)] EnableTakePhotoClip instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EnableTakePhotoClip
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600836F RID: 33647 RVA: 0x0013A79B File Offset: 0x0013899B
		public static EnableTakePhotoClip CreateFromSetValue([Nullable(2)] EnableTakePhotoClip_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new EnableTakePhotoClip
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008370 RID: 33648 RVA: 0x0013A7AE File Offset: 0x001389AE
		public EnableTakePhotoClip_SetValue ToSetValue()
		{
			return new EnableTakePhotoClip_SetValue
			{
				Enable = this.Enable
			};
		}

		// Token: 0x17002B16 RID: 11030
		// (get) Token: 0x06008371 RID: 33649 RVA: 0x0013A7C1 File Offset: 0x001389C1
		// (set) Token: 0x06008372 RID: 33650 RVA: 0x0013A7EC File Offset: 0x001389EC
		public virtual bool Enable
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Enable;
				}
				return this.PocoInterface != null && this.PocoInterface.Enable;
			}
			set
			{
				this.GetOrCreatePoco().Enable = value;
			}
		}

		// Token: 0x0400506F RID: 20591
		[Nullable(2)]
		protected new EnableTakePhotoClip FbInstance;

		// Token: 0x04005070 RID: 20592
		[Nullable(2)]
		protected EnableTakePhotoClip_SetValue PocoInterface;
	}
}
