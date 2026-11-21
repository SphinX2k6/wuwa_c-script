using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001093 RID: 4243
	public class IFastReturnGravityEntityPos : IFastReturnPosBase
	{
		// Token: 0x06005D84 RID: 23940 RVA: 0x000E2E7C File Offset: 0x000E107C
		private IFastReturnGravityEntityPos_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFastReturnGravityEntityPos 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFastReturnGravityEntityPos_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFastReturnGravityEntityPos_SetValue());
			}
			return result;
		}

		// Token: 0x06005D85 RID: 23941 RVA: 0x000E2EB4 File Offset: 0x000E10B4
		public static IFastReturnGravityEntityPos Create([Nullable(2)] IFastReturnGravityEntityPos instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFastReturnGravityEntityPos
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005D86 RID: 23942 RVA: 0x000E2EC7 File Offset: 0x000E10C7
		public static IFastReturnGravityEntityPos CreateFromSetValue([Nullable(2)] IFastReturnGravityEntityPos_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFastReturnGravityEntityPos
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005D87 RID: 23943 RVA: 0x000E2EDA File Offset: 0x000E10DA
		public new IFastReturnGravityEntityPos_SetValue ToSetValue()
		{
			return new IFastReturnGravityEntityPos_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId,
				TransitionOption = this.TransitionOption
			};
		}

		// Token: 0x17001EE2 RID: 7906
		// (get) Token: 0x06005D88 RID: 23944 RVA: 0x000E2F05 File Offset: 0x000E1105
		// (set) Token: 0x06005D89 RID: 23945 RVA: 0x000E2F30 File Offset: 0x000E1130
		public override EFastReturnPosType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EFastReturnPosType.EntityPos;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17001EE3 RID: 7907
		// (get) Token: 0x06005D8A RID: 23946 RVA: 0x000E2F3E File Offset: 0x000E113E
		// (set) Token: 0x06005D8B RID: 23947 RVA: 0x000E2F69 File Offset: 0x000E1169
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x17001EE4 RID: 7908
		// (get) Token: 0x06005D8C RID: 23948 RVA: 0x000E2F77 File Offset: 0x000E1177
		// (set) Token: 0x06005D8D RID: 23949 RVA: 0x000E2F9E File Offset: 0x000E119E
		[Nullable(2)]
		public virtual ITeleportTransitionType TransitionOption
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TransitionOption;
				}
				IFastReturnGravityEntityPos_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TransitionOption;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().TransitionOption = value;
			}
		}

		// Token: 0x04003830 RID: 14384
		[Nullable(2)]
		protected new IFastReturnGravityEntityPos FbInstance;

		// Token: 0x04003831 RID: 14385
		[Nullable(2)]
		protected new IFastReturnGravityEntityPos_SetValue PocoInterface;
	}
}
