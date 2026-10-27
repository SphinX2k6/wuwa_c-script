using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E1C RID: 24092
	[NullableContext(2)]
	[Nullable(0)]
	public class SpecialEnergyBarContainer : BattleVisibleChildView
	{
		// Token: 0x0603D458 RID: 250968 RVA: 0x00EC3FAC File Offset: 0x00EC21AC
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			base.InitChildType(EBattleUiChild.Ignore);
			this.PhantomContainer = (param as UUIItem);
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			this.EntityId = ((getCurrentEntity != null) ? getCurrentEntity.Id : 0);
			this.LoadAllSpecialEnergyBar();
			this.MotorcycleSpecialEnergyBar.Init(this.RootItem, new Action(this.OnEnergyBarEnableChange));
			this.RefreshAllSpecialEnergyBarVisible();
			this.AddEvents();
		}

		// Token: 0x0603D459 RID: 250969 RVA: 0x00EC4020 File Offset: 0x00EC2220
		protected override void OnBeforeDestroy()
		{
			this.CurRoleBar = null;
			foreach (RoleSpecialEnergyBar roleSpecialEnergyBar in this.RoleBarMap.Values)
			{
				roleSpecialEnergyBar.Destroy();
			}
			this.MotorcycleSpecialEnergyBar.Destroy();
		}

		// Token: 0x0603D45A RID: 250970 RVA: 0x00EC4088 File Offset: 0x00EC2288
		public override void Reset()
		{
			this.RemoveEvents();
			base.Reset();
		}

		// Token: 0x0603D45B RID: 250971 RVA: 0x00EC4098 File Offset: 0x00EC2298
		public void Tick(float delta)
		{
			foreach (RoleSpecialEnergyBar roleSpecialEnergyBar in this.RoleBarMap.Values)
			{
				roleSpecialEnergyBar.Tick(delta);
			}
			this.MotorcycleSpecialEnergyBar.Tick(delta);
		}

		// Token: 0x0603D45C RID: 250972 RVA: 0x00EC40FC File Offset: 0x00EC22FC
		public void OnChangeRole(BattleUiRoleData roleData)
		{
			int? num;
			if (roleData == null)
			{
				num = null;
			}
			else
			{
				EntityHandle entityHandle = roleData.EntityHandle;
				num = ((entityHandle != null) ? new int?(entityHandle.Id) : null);
			}
			int? num2 = num;
			this.EntityId = num2.GetValueOrDefault();
			if (this.EntityId != 0)
			{
				RoleSpecialEnergyBar roleSpecialEnergyBar;
				if (BattleUiModel.Instance.SpecialEnergyBarData.IsSpecialEnergyBarEditorModeOpen && this.RoleBarMap.TryGetValue(this.EntityId, out roleSpecialEnergyBar))
				{
					roleSpecialEnergyBar.Destroy();
					this.RoleBarMap.Remove(this.EntityId);
				}
				this.LoadSpecialEnergyBar(roleData).Forget();
			}
			this.RefreshAllSpecialEnergyBarVisible();
		}

		// Token: 0x0603D45D RID: 250973 RVA: 0x00EC419C File Offset: 0x00EC239C
		public void OnRemoveEntity(int entityId)
		{
			RoleSpecialEnergyBar roleSpecialEnergyBar;
			if (this.RoleBarMap.Remove(entityId, out roleSpecialEnergyBar))
			{
				roleSpecialEnergyBar.Destroy();
				if (this.CurRoleBar == roleSpecialEnergyBar)
				{
					this.CurRoleBar = null;
				}
			}
		}

		// Token: 0x0603D45E RID: 250974 RVA: 0x00EC41CF File Offset: 0x00EC23CF
		private void AddEvents()
		{
			EventSystem.Instance.Add(EEventName.BattleUiAllRoleDataChanged, new Action(this.OnFormationLoaded));
			this.MotorcycleSpecialEnergyBar.AddEvents();
		}

		// Token: 0x0603D45F RID: 250975 RVA: 0x00EC41F8 File Offset: 0x00EC23F8
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.BattleUiAllRoleDataChanged, new Action(this.OnFormationLoaded));
			this.MotorcycleSpecialEnergyBar.RemoveEvents();
		}

		// Token: 0x0603D460 RID: 250976 RVA: 0x00EC4221 File Offset: 0x00EC2421
		private void OnFormationLoaded()
		{
			this.LoadAllSpecialEnergyBar();
			this.RefreshAllSpecialEnergyBarVisible();
		}

		// Token: 0x0603D461 RID: 250977 RVA: 0x00EC4230 File Offset: 0x00EC2430
		private void LoadAllSpecialEnergyBar()
		{
			foreach (SceneTeamItem sceneTeamItem in SceneTeamModel.Instance.GetTeamItems(true))
			{
				EntityHandle entityHandle = sceneTeamItem.EntityHandle;
				int? num = (entityHandle != null) ? new int?(entityHandle.Id) : null;
				if (num != null)
				{
					BattleUiRoleData roleData = BattleUiModel.Instance.GetRoleData(num.Value);
					if (roleData != null)
					{
						this.LoadSpecialEnergyBar(roleData).Forget();
					}
				}
			}
		}

		// Token: 0x0603D462 RID: 250978 RVA: 0x00EC42CC File Offset: 0x00EC24CC
		[NullableContext(1)]
		private UniTask LoadSpecialEnergyBar(BattleUiRoleData roleData)
		{
			SpecialEnergyBarContainer.<LoadSpecialEnergyBar>d__15 <LoadSpecialEnergyBar>d__;
			<LoadSpecialEnergyBar>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadSpecialEnergyBar>d__.<>4__this = this;
			<LoadSpecialEnergyBar>d__.roleData = roleData;
			<LoadSpecialEnergyBar>d__.<>1__state = -1;
			<LoadSpecialEnergyBar>d__.<>t__builder.Start<SpecialEnergyBarContainer.<LoadSpecialEnergyBar>d__15>(ref <LoadSpecialEnergyBar>d__);
			return <LoadSpecialEnergyBar>d__.<>t__builder.Task;
		}

		// Token: 0x0603D463 RID: 250979 RVA: 0x00EC4318 File Offset: 0x00EC2518
		private void RefreshAllSpecialEnergyBarVisible()
		{
			foreach (KeyValuePair<int, RoleSpecialEnergyBar> keyValuePair in this.RoleBarMap)
			{
				int num;
				RoleSpecialEnergyBar roleSpecialEnergyBar;
				keyValuePair.Deconstruct(out num, out roleSpecialEnergyBar);
				int num2 = num;
				RoleSpecialEnergyBar roleSpecialEnergyBar2 = roleSpecialEnergyBar;
				if (num2 == this.EntityId && !this.MotorcycleSpecialEnergyBar.IsEnable())
				{
					roleSpecialEnergyBar2.SetVisible(true);
					this.CurRoleBar = roleSpecialEnergyBar2;
				}
				else
				{
					roleSpecialEnergyBar2.SetVisible(false);
				}
			}
		}

		// Token: 0x0603D464 RID: 250980 RVA: 0x00EC43A0 File Offset: 0x00EC25A0
		private void OnEnergyBarEnableChange()
		{
			this.RefreshAllSpecialEnergyBarVisible();
		}

		// Token: 0x0401FF39 RID: 130873
		private UUIItem PhantomContainer;

		// Token: 0x0401FF3A RID: 130874
		private int EntityId;

		// Token: 0x0401FF3B RID: 130875
		private RoleSpecialEnergyBar CurRoleBar;

		// Token: 0x0401FF3C RID: 130876
		[Nullable(1)]
		private readonly Dictionary<int, RoleSpecialEnergyBar> RoleBarMap = new Dictionary<int, RoleSpecialEnergyBar>();

		// Token: 0x0401FF3D RID: 130877
		[Nullable(1)]
		private readonly MotorcycleSpecialEnergyBar MotorcycleSpecialEnergyBar = new MotorcycleSpecialEnergyBar();
	}
}
