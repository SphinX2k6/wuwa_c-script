using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001754 RID: 5972
	[NullableContext(1)]
	[Nullable(0)]
	public class IActionConfigItem : IActionFunctionalConfigItem
	{
		// Token: 0x06007E69 RID: 32361 RVA: 0x0012EBE0 File Offset: 0x0012CDE0
		private IActionConfigItem_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IActionConfigItem 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IActionConfigItem_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IActionConfigItem_SetValue());
			}
			return result;
		}

		// Token: 0x06007E6A RID: 32362 RVA: 0x0012EC18 File Offset: 0x0012CE18
		public static IActionConfigItem Create([Nullable(2)] IActionConfigItem instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActionConfigItem
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007E6B RID: 32363 RVA: 0x0012EC2B File Offset: 0x0012CE2B
		public static IActionConfigItem CreateFromSetValue([Nullable(2)] IActionConfigItem_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IActionConfigItem
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007E6C RID: 32364 RVA: 0x0012EC40 File Offset: 0x0012CE40
		public new IActionConfigItem_SetValue ToSetValue()
		{
			return new IActionConfigItem_SetValue
			{
				OnlineParticipateRule = this.OnlineParticipateRule,
				IsDetectScreenOccupation = this.IsDetectScreenOccupation,
				IsWithResultOnly = this.IsWithResultOnly,
				IsOperatePlayer = this.IsOperatePlayer,
				CnName = this.CnName
			};
		}

		// Token: 0x1700298B RID: 10635
		// (get) Token: 0x06007E6D RID: 32365 RVA: 0x0012EC90 File Offset: 0x0012CE90
		// (set) Token: 0x06007E6E RID: 32366 RVA: 0x0012ECCA File Offset: 0x0012CECA
		public override EOnlineParticipateRule? OnlineParticipateRule
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.OnlineParticipateRule;
				}
				IActionConfigItem_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.OnlineParticipateRule;
			}
			set
			{
				this.GetOrCreatePoco().OnlineParticipateRule = value;
			}
		}

		// Token: 0x1700298C RID: 10636
		// (get) Token: 0x06007E6F RID: 32367 RVA: 0x0012ECD8 File Offset: 0x0012CED8
		// (set) Token: 0x06007E70 RID: 32368 RVA: 0x0012ED12 File Offset: 0x0012CF12
		public override bool? IsDetectScreenOccupation
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsDetectScreenOccupation;
				}
				IActionConfigItem_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsDetectScreenOccupation;
			}
			set
			{
				this.GetOrCreatePoco().IsDetectScreenOccupation = value;
			}
		}

		// Token: 0x1700298D RID: 10637
		// (get) Token: 0x06007E71 RID: 32369 RVA: 0x0012ED20 File Offset: 0x0012CF20
		// (set) Token: 0x06007E72 RID: 32370 RVA: 0x0012ED5A File Offset: 0x0012CF5A
		public override bool? IsWithResultOnly
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsWithResultOnly;
				}
				IActionConfigItem_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsWithResultOnly;
			}
			set
			{
				this.GetOrCreatePoco().IsWithResultOnly = value;
			}
		}

		// Token: 0x1700298E RID: 10638
		// (get) Token: 0x06007E73 RID: 32371 RVA: 0x0012ED68 File Offset: 0x0012CF68
		// (set) Token: 0x06007E74 RID: 32372 RVA: 0x0012EDA2 File Offset: 0x0012CFA2
		public override bool? IsOperatePlayer
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsOperatePlayer;
				}
				IActionConfigItem_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsOperatePlayer;
			}
			set
			{
				this.GetOrCreatePoco().IsOperatePlayer = value;
			}
		}

		// Token: 0x1700298F RID: 10639
		// (get) Token: 0x06007E75 RID: 32373 RVA: 0x0012EDB0 File Offset: 0x0012CFB0
		// (set) Token: 0x06007E76 RID: 32374 RVA: 0x0012EDDB File Offset: 0x0012CFDB
		public virtual string CnName
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CnName;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.CnName;
			}
			set
			{
				this.GetOrCreatePoco().CnName = value;
			}
		}

		// Token: 0x04005086 RID: 20614
		[Nullable(2)]
		protected new IActionConfigItem FbInstance;

		// Token: 0x04005087 RID: 20615
		[Nullable(2)]
		protected new IActionConfigItem_SetValue PocoInterface;
	}
}
