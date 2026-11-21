using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200205B RID: 8283
	public class ISetMonsterMoveTarget : IExecBattleActionType
	{
		// Token: 0x0600AFC5 RID: 44997 RVA: 0x0018BC40 File Offset: 0x00189E40
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

		// Token: 0x0600AFC6 RID: 44998 RVA: 0x0018BC78 File Offset: 0x00189E78
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

		// Token: 0x0600AFC7 RID: 44999 RVA: 0x0018BC8B File Offset: 0x00189E8B
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

		// Token: 0x0600AFC8 RID: 45000 RVA: 0x0018BC9E File Offset: 0x00189E9E
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

		// Token: 0x17003568 RID: 13672
		// (get) Token: 0x0600AFC9 RID: 45001 RVA: 0x0018BCD5 File Offset: 0x00189ED5
		// (set) Token: 0x0600AFCA RID: 45002 RVA: 0x0018BD00 File Offset: 0x00189F00
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

		// Token: 0x17003569 RID: 13673
		// (get) Token: 0x0600AFCB RID: 45003 RVA: 0x0018BD0E File Offset: 0x00189F0E
		// (set) Token: 0x0600AFCC RID: 45004 RVA: 0x0018BD39 File Offset: 0x00189F39
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

		// Token: 0x1700356A RID: 13674
		// (get) Token: 0x0600AFCD RID: 45005 RVA: 0x0018BD48 File Offset: 0x00189F48
		// (set) Token: 0x0600AFCE RID: 45006 RVA: 0x0018BD82 File Offset: 0x00189F82
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

		// Token: 0x1700356B RID: 13675
		// (get) Token: 0x0600AFCF RID: 45007 RVA: 0x0018BD90 File Offset: 0x00189F90
		// (set) Token: 0x0600AFD0 RID: 45008 RVA: 0x0018BDB7 File Offset: 0x00189FB7
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

		// Token: 0x0400689B RID: 26779
		[Nullable(2)]
		protected new ISetMonsterMoveTarget FbInstance;

		// Token: 0x0400689C RID: 26780
		[Nullable(2)]
		protected new ISetMonsterMoveTarget_SetValue PocoInterface;
	}
}
