using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.OperationRestrict;

namespace CSharpScript.Game.Module.GeneralLogicTree.BaseBehaviorTree.Express
{
	// Token: 0x020049C9 RID: 18889
	[NullableContext(1)]
	[Nullable(0)]
	public class ForceClosedRestrictionComponentHolder
	{
		// Token: 0x0602F4D0 RID: 193744 RVA: 0x00D31DDD File Offset: 0x00D2FFDD
		public ForceClosedRestrictionComponentHolder(Blackboard Blackboard)
		{
		}

		// Token: 0x17005F71 RID: 24433
		// (get) Token: 0x0602F4D1 RID: 193745 RVA: 0x00D31DEC File Offset: 0x00D2FFEC
		// (set) Token: 0x0602F4D2 RID: 193746 RVA: 0x00D31DF4 File Offset: 0x00D2FFF4
		public bool IsRestricting { get; private set; }

		// Token: 0x0602F4D3 RID: 193747 RVA: 0x00D31DFD File Offset: 0x00D2FFFD
		public void Init()
		{
			this.RefreshNode();
		}

		// Token: 0x0602F4D4 RID: 193748 RVA: 0x00D31E05 File Offset: 0x00D30005
		public void Destroy()
		{
			if (!this.IsRestricting)
			{
				return;
			}
			this.IsRestricting = false;
			this.RefreshMiniMap();
		}

		// Token: 0x0602F4D5 RID: 193749 RVA: 0x00D31E1D File Offset: 0x00D3001D
		public void RefreshNode()
		{
			this.RefreshNode(false);
		}

		// Token: 0x0602F4D6 RID: 193750 RVA: 0x00D31E28 File Offset: 0x00D30028
		private void RefreshNode(bool forceRefresh)
		{
			bool flag = this.<Blackboard>P.ContainTag(EBehaviorTreeTag.ForceClosedRestriction);
			if (!forceRefresh && this.IsRestricting == flag)
			{
				return;
			}
			this.IsRestricting = flag;
			this.RefreshMiniMap();
		}

		// Token: 0x0602F4D7 RID: 193751 RVA: 0x00D31E5D File Offset: 0x00D3005D
		public void OnSuspend()
		{
			this.RefreshNode(true);
		}

		// Token: 0x0602F4D8 RID: 193752 RVA: 0x00D31E66 File Offset: 0x00D30066
		public void OnCancelSuspend()
		{
			this.RefreshNode(true);
		}

		// Token: 0x0602F4D9 RID: 193753 RVA: 0x00D31E6F File Offset: 0x00D3006F
		private void RefreshMiniMap()
		{
			OperationRestrictUtils.Instance.SetMiniMapEnable(!this.IsRestricting);
		}

		// Token: 0x0401915A RID: 102746
		[CompilerGenerated]
		private Blackboard <Blackboard>P = Blackboard;
	}
}
