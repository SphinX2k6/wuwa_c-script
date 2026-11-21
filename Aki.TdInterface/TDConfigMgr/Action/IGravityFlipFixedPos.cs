using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C82 RID: 7298
	public class IGravityFlipFixedPos : ITeleportConfig
	{
		// Token: 0x06009B16 RID: 39702 RVA: 0x0016684C File Offset: 0x00164A4C
		private IGravityFlipFixedPos_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IGravityFlipFixedPos 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IGravityFlipFixedPos_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IGravityFlipFixedPos_SetValue());
			}
			return result;
		}

		// Token: 0x06009B17 RID: 39703 RVA: 0x00166884 File Offset: 0x00164A84
		public static IGravityFlipFixedPos Create([Nullable(2)] IGravityFlipFixedPos instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGravityFlipFixedPos
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009B18 RID: 39704 RVA: 0x00166897 File Offset: 0x00164A97
		public static IGravityFlipFixedPos CreateFromSetValue([Nullable(2)] IGravityFlipFixedPos_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IGravityFlipFixedPos
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009B19 RID: 39705 RVA: 0x001668AA File Offset: 0x00164AAA
		public new IGravityFlipFixedPos_SetValue ToSetValue()
		{
			return new IGravityFlipFixedPos_SetValue
			{
				Type = this.Type,
				GravityAndPosEntityId = this.GravityAndPosEntityId
			};
		}

		// Token: 0x170030D5 RID: 12501
		// (get) Token: 0x06009B1A RID: 39706 RVA: 0x001668C9 File Offset: 0x00164AC9
		// (set) Token: 0x06009B1B RID: 39707 RVA: 0x001668F4 File Offset: 0x00164AF4
		public override ETeleportType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETeleportType.FixedPos;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170030D6 RID: 12502
		// (get) Token: 0x06009B1C RID: 39708 RVA: 0x00166902 File Offset: 0x00164B02
		// (set) Token: 0x06009B1D RID: 39709 RVA: 0x0016692D File Offset: 0x00164B2D
		public virtual int GravityAndPosEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GravityAndPosEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.GravityAndPosEntityId;
			}
			set
			{
				this.GetOrCreatePoco().GravityAndPosEntityId = value;
			}
		}

		// Token: 0x04005F1C RID: 24348
		[Nullable(2)]
		protected new IGravityFlipFixedPos FbInstance;

		// Token: 0x04005F1D RID: 24349
		[Nullable(2)]
		protected new IGravityFlipFixedPos_SetValue PocoInterface;
	}
}
