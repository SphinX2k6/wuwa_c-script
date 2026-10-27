using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000F67 RID: 3943
	[NullableContext(2)]
	[Nullable(0)]
	public class IFastReturnEntityPos : IFastReturnPosBase
	{
		// Token: 0x060057A4 RID: 22436 RVA: 0x000D62D0 File Offset: 0x000D44D0
		[NullableContext(1)]
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

		// Token: 0x060057A5 RID: 22437 RVA: 0x000D6308 File Offset: 0x000D4508
		[NullableContext(1)]
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

		// Token: 0x060057A6 RID: 22438 RVA: 0x000D631B File Offset: 0x000D451B
		[NullableContext(1)]
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

		// Token: 0x060057A7 RID: 22439 RVA: 0x000D632E File Offset: 0x000D452E
		[NullableContext(1)]
		public new IFastReturnEntityPos_SetValue ToSetValue()
		{
			return new IFastReturnEntityPos_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId,
				TransitionOption = this.TransitionOption
			};
		}

		// Token: 0x17001D39 RID: 7481
		// (get) Token: 0x060057A8 RID: 22440 RVA: 0x000D6359 File Offset: 0x000D4559
		// (set) Token: 0x060057A9 RID: 22441 RVA: 0x000D6384 File Offset: 0x000D4584
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

		// Token: 0x17001D3A RID: 7482
		// (get) Token: 0x060057AA RID: 22442 RVA: 0x000D6392 File Offset: 0x000D4592
		// (set) Token: 0x060057AB RID: 22443 RVA: 0x000D63BD File Offset: 0x000D45BD
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

		// Token: 0x17001D3B RID: 7483
		// (get) Token: 0x060057AC RID: 22444 RVA: 0x000D63CB File Offset: 0x000D45CB
		// (set) Token: 0x060057AD RID: 22445 RVA: 0x000D63F2 File Offset: 0x000D45F2
		public virtual ITeleportTransitionType TransitionOption
		{
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
			set
			{
				this.GetOrCreatePoco().TransitionOption = value;
			}
		}

		// Token: 0x040034FA RID: 13562
		protected new IFastReturnEntityPos FbInstance;

		// Token: 0x040034FB RID: 13563
		protected new IFastReturnEntityPos_SetValue PocoInterface;
	}
}
