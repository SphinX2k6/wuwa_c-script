using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001091 RID: 4241
	public class IFastReturnEntityPos : IFastReturnPosBase
	{
		// Token: 0x06005D78 RID: 23928 RVA: 0x000E2D3C File Offset: 0x000E0F3C
		private IFastReturnEntityPos_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFastReturnEntityPos 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFastReturnEntityPos_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFastReturnEntityPos_SetValue());
			}
			return result;
		}

		// Token: 0x06005D79 RID: 23929 RVA: 0x000E2D74 File Offset: 0x000E0F74
		public static IFastReturnEntityPos Create([Nullable(2)] IFastReturnEntityPos instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFastReturnEntityPos
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005D7A RID: 23930 RVA: 0x000E2D87 File Offset: 0x000E0F87
		public static IFastReturnEntityPos CreateFromSetValue([Nullable(2)] IFastReturnEntityPos_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFastReturnEntityPos
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005D7B RID: 23931 RVA: 0x000E2D9A File Offset: 0x000E0F9A
		public new IFastReturnEntityPos_SetValue ToSetValue()
		{
			return new IFastReturnEntityPos_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId,
				TransitionOption = this.TransitionOption
			};
		}

		// Token: 0x17001EDF RID: 7903
		// (get) Token: 0x06005D7C RID: 23932 RVA: 0x000E2DC5 File Offset: 0x000E0FC5
		// (set) Token: 0x06005D7D RID: 23933 RVA: 0x000E2DF0 File Offset: 0x000E0FF0
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

		// Token: 0x17001EE0 RID: 7904
		// (get) Token: 0x06005D7E RID: 23934 RVA: 0x000E2DFE File Offset: 0x000E0FFE
		// (set) Token: 0x06005D7F RID: 23935 RVA: 0x000E2E29 File Offset: 0x000E1029
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

		// Token: 0x17001EE1 RID: 7905
		// (get) Token: 0x06005D80 RID: 23936 RVA: 0x000E2E37 File Offset: 0x000E1037
		// (set) Token: 0x06005D81 RID: 23937 RVA: 0x000E2E5E File Offset: 0x000E105E
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
				IFastReturnEntityPos_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x0400382B RID: 14379
		[Nullable(2)]
		protected new IFastReturnEntityPos FbInstance;

		// Token: 0x0400382C RID: 14380
		[Nullable(2)]
		protected new IFastReturnEntityPos_SetValue PocoInterface;
	}
}
