using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E28 RID: 7720
	[NullableContext(1)]
	[Nullable(0)]
	public class ISetMonsterMoveTarget : IExecBattleActionType
	{
		// Token: 0x0600A51D RID: 42269 RVA: 0x00176238 File Offset: 0x00174438
		private ISetMonsterMoveTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetMonsterMoveTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetMonsterMoveTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetMonsterMoveTarget_SetValue());
			}
			return result;
		}

		// Token: 0x0600A51E RID: 42270 RVA: 0x00176270 File Offset: 0x00174470
		public static ISetMonsterMoveTarget Create([Nullable(2)] ISetMonsterMoveTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetMonsterMoveTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A51F RID: 42271 RVA: 0x00176283 File Offset: 0x00174483
		public static ISetMonsterMoveTarget CreateFromSetValue([Nullable(2)] ISetMonsterMoveTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetMonsterMoveTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A520 RID: 42272 RVA: 0x00176296 File Offset: 0x00174496
		public new ISetMonsterMoveTarget_SetValue ToSetValue()
		{
			return new ISetMonsterMoveTarget_SetValue
			{
				Type = this.Type,
				TargetEntityId = this.TargetEntityId,
				MoveEvent = this.MoveEvent,
				MonsterEntityIds = this.MonsterEntityIds
			};
		}

		// Token: 0x170032A9 RID: 12969
		// (get) Token: 0x0600A521 RID: 42273 RVA: 0x001762CD File Offset: 0x001744CD
		// (set) Token: 0x0600A522 RID: 42274 RVA: 0x001762F8 File Offset: 0x001744F8
		public override EExecBattleActionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EExecBattleActionType.SetBattleTags;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170032AA RID: 12970
		// (get) Token: 0x0600A523 RID: 42275 RVA: 0x00176306 File Offset: 0x00174506
		// (set) Token: 0x0600A524 RID: 42276 RVA: 0x00176331 File Offset: 0x00174531
		public virtual int TargetEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TargetEntityId;
			}
			set
			{
				this.GetOrCreatePoco().TargetEntityId = value;
			}
		}

		// Token: 0x170032AB RID: 12971
		// (get) Token: 0x0600A525 RID: 42277 RVA: 0x00176340 File Offset: 0x00174540
		// (set) Token: 0x0600A526 RID: 42278 RVA: 0x0017637A File Offset: 0x0017457A
		public virtual EMoveEvent? MoveEvent
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MoveEvent;
				}
				ISetMonsterMoveTarget_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MoveEvent;
			}
			set
			{
				this.GetOrCreatePoco().MoveEvent = value;
			}
		}

		// Token: 0x170032AC RID: 12972
		// (get) Token: 0x0600A527 RID: 42279 RVA: 0x00176388 File Offset: 0x00174588
		// (set) Token: 0x0600A528 RID: 42280 RVA: 0x001763AF File Offset: 0x001745AF
		public virtual List<int> MonsterEntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MonsterEntityIds;
				}
				ISetMonsterMoveTarget_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MonsterEntityIds;
			}
			set
			{
				this.GetOrCreatePoco().MonsterEntityIds = value;
			}
		}

		// Token: 0x040062C4 RID: 25284
		[Nullable(2)]
		protected new ISetMonsterMoveTarget FbInstance;

		// Token: 0x040062C5 RID: 25285
		[Nullable(2)]
		protected new ISetMonsterMoveTarget_SetValue PocoInterface;
	}
}
