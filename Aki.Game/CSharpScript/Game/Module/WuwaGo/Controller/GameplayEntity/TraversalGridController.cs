using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Module.WuwaGo.Controller.GameMode;
using CSharpScript.Game.Module.WuwaGo.Model;
using CSharpScript.Game.Module.WuwaGo.Model.GameplayEntity;
using CSharpScript.Game.Module.WuwaGo.Model.Role;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo.Controller.GameplayEntity
{
	// Token: 0x02004779 RID: 18297
	[NullableContext(1)]
	[Nullable(0)]
	public class TraversalGridController : GameplayEntityControllerBase
	{
		// Token: 0x0602FD5A RID: 195930 RVA: 0x00B1574C File Offset: 0x00B1394C
		public TraversalGridController(WuWaGoGameplayEntityBase entity, WuWaGoGameData gameData, WuWaGoGameModeBase gameMode) : base(entity, gameData, gameMode)
		{
		}

		// Token: 0x0602FD5B RID: 195931 RVA: 0x00B15758 File Offset: 0x00B13958
		protected override bool OnCreate()
		{
			if (!base.OnCreate())
			{
				return false;
			}
			if (this.Entity.EntityType != EWuWaGoEntityType.StartGrid)
			{
				this.GridRef = this.GameData.GetGridById(this.Entity.StandGridId);
				WuWaGoGrid gridRef = this.GridRef;
				if (gridRef != null)
				{
					gridRef.AddOccupiedUnitChangedListener(new WuWaGoGridOccupiedUnitChangedListener(this.OnOccupiedChanged));
				}
				WuWaGoGrid gridRef2 = this.GridRef;
				int num = (gridRef2 != null) ? gridRef2.OccupiedUnitId : 0;
				if (num != 0)
				{
					this.HandleOccupiedChanged(num);
				}
			}
			return true;
		}

		// Token: 0x0602FD5C RID: 195932 RVA: 0x00B157D5 File Offset: 0x00B139D5
		protected override void OnDestroy()
		{
			WuWaGoGrid gridRef = this.GridRef;
			if (gridRef != null)
			{
				gridRef.RemoveOccupiedUnitChangedListener(new WuWaGoGridOccupiedUnitChangedListener(this.OnOccupiedChanged));
			}
			this.GridRef = null;
			base.OnDestroy();
		}

		// Token: 0x0602FD5D RID: 195933 RVA: 0x00B15804 File Offset: 0x00B13A04
		private void HandleOccupiedChanged(int unitId)
		{
			WuWaGoMainControlRole mainControlRole = this.GameData.MainControlRole;
			int? num = (mainControlRole != null) ? new int?(mainControlRole.Id) : null;
			if (num == null || unitId != num.Value)
			{
				return;
			}
			if (this.Entity.SetState(EGameplayEntityState.Activated))
			{
				WuWaGoGrid gridRef = this.GridRef;
				if (gridRef != null)
				{
					gridRef.RemoveOccupiedUnitChangedListener(new WuWaGoGridOccupiedUnitChangedListener(this.OnOccupiedChanged));
				}
				this.GridRef = null;
			}
		}

		// Token: 0x0602FD5E RID: 195934 RVA: 0x00B1587C File Offset: 0x00B13A7C
		private void OnOccupiedChanged(WuWaGoGrid grid, int prevUnitId, int currentUnitId)
		{
			this.HandleOccupiedChanged(currentUnitId);
		}

		// Token: 0x0602FD5F RID: 195935 RVA: 0x00B15888 File Offset: 0x00B13A88
		protected override UniTask OnExecuteAction()
		{
			TraversalGridController.<OnExecuteAction>d__6 <OnExecuteAction>d__;
			<OnExecuteAction>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnExecuteAction>d__.<>1__state = -1;
			<OnExecuteAction>d__.<>t__builder.Start<TraversalGridController.<OnExecuteAction>d__6>(ref <OnExecuteAction>d__);
			return <OnExecuteAction>d__.<>t__builder.Task;
		}

		// Token: 0x04019CD8 RID: 105688
		[Nullable(2)]
		private WuWaGoGrid GridRef;
	}
}
