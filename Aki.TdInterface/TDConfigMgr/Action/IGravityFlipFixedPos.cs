using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001ADB RID: 6875
	[NullableContext(1)]
	[Nullable(0)]
	public class IGravityFlipFixedPos : ITeleportConfig
	{
		// Token: 0x06009358 RID: 37720 RVA: 0x0015602C File Offset: 0x0015422C
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

		// Token: 0x06009359 RID: 37721 RVA: 0x00156064 File Offset: 0x00154264
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

		// Token: 0x0600935A RID: 37722 RVA: 0x00156077 File Offset: 0x00154277
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

		// Token: 0x0600935B RID: 37723 RVA: 0x0015608A File Offset: 0x0015428A
		public new IGravityFlipFixedPos_SetValue ToSetValue()
		{
			return new IGravityFlipFixedPos_SetValue
			{
				Type = this.Type,
				GravityAndPosEntityId = this.GravityAndPosEntityId
			};
		}

		// Token: 0x17002EB9 RID: 11961
		// (get) Token: 0x0600935C RID: 37724 RVA: 0x001560A9 File Offset: 0x001542A9
		// (set) Token: 0x0600935D RID: 37725 RVA: 0x001560D4 File Offset: 0x001542D4
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

		// Token: 0x17002EBA RID: 11962
		// (get) Token: 0x0600935E RID: 37726 RVA: 0x001560E2 File Offset: 0x001542E2
		// (set) Token: 0x0600935F RID: 37727 RVA: 0x0015610D File Offset: 0x0015430D
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

		// Token: 0x04005A92 RID: 23186
		[Nullable(2)]
		protected new IGravityFlipFixedPos FbInstance;

		// Token: 0x04005A93 RID: 23187
		[Nullable(2)]
		protected new IGravityFlipFixedPos_SetValue PocoInterface;
	}
}
