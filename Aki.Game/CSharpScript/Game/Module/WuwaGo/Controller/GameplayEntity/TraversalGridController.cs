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
	// Token: 0x020036AA RID: 13994
	[NullableContext(1)]
	[Nullable(0)]
	public class TraversalGridController : GameplayEntityControllerBase
	{
		// Token: 0x06024524 RID: 148772 RVA: 0x00A457AC File Offset: 0x00A439AC
		public TraversalGridController(WuWaGoGameplayEntityBase entity, WuWaGoGameData gameData, WuWaGoGameModeBase gameMode) : base(entity, gameData, gameMode)
		{
		}

		// Token: 0x06024525 RID: 148773 RVA: 0x00A457B8 File Offset: 0x00A439B8
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

		// Token: 0x06024526 RID: 148774 RVA: 0x00A45835 File Offset: 0x00A43A35
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

		// Token: 0x06024527 RID: 148775 RVA: 0x00A45864 File Offset: 0x00A43A64
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

		// Token: 0x06024528 RID: 148776 RVA: 0x00A458DC File Offset: 0x00A43ADC
		private void OnOccupiedChanged(WuWaGoGrid grid, int prevUnitId, int currentUnitId)
		{
			this.HandleOccupiedChanged(currentUnitId);
		}

		// Token: 0x06024529 RID: 148777 RVA: 0x00A458E8 File Offset: 0x00A43AE8
		protected override UniTask OnExecuteAction()
		{
			TraversalGridController.<OnExecuteAction>d__6 <OnExecuteAction>d__;
			<OnExecuteAction>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnExecuteAction>d__.<>1__state = -1;
			<OnExecuteAction>d__.<>t__builder.Start<TraversalGridController.<OnExecuteAction>d__6>(ref <OnExecuteAction>d__);
			return <OnExecuteAction>d__.<>t__builder.Task;
		}

		// Token: 0x04014388 RID: 82824
		[Nullable(2)]
		private WuWaGoGrid GridRef;
	}
}
