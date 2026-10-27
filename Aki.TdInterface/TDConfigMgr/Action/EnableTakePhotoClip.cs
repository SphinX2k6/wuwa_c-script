using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200164A RID: 5706
	[NullableContext(1)]
	[Nullable(0)]
	public class EnableTakePhotoClip : ActionParams
	{
		// Token: 0x06007C8F RID: 31887 RVA: 0x0012B6A4 File Offset: 0x001298A4
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

		// Token: 0x06007C90 RID: 31888 RVA: 0x0012B6DC File Offset: 0x001298DC
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

		// Token: 0x06007C91 RID: 31889 RVA: 0x0012B6EF File Offset: 0x001298EF
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

		// Token: 0x06007C92 RID: 31890 RVA: 0x0012B702 File Offset: 0x00129902
		public EnableTakePhotoClip_SetValue ToSetValue()
		{
			return new EnableTakePhotoClip_SetValue
			{
				Enable = this.Enable
			};
		}

		// Token: 0x1700292B RID: 10539
		// (get) Token: 0x06007C93 RID: 31891 RVA: 0x0012B715 File Offset: 0x00129915
		// (set) Token: 0x06007C94 RID: 31892 RVA: 0x0012B740 File Offset: 0x00129940
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

		// Token: 0x04004C7B RID: 19579
		[Nullable(2)]
		protected new EnableTakePhotoClip FbInstance;

		// Token: 0x04004C7C RID: 19580
		[Nullable(2)]
		protected EnableTakePhotoClip_SetValue PocoInterface;
	}
}
