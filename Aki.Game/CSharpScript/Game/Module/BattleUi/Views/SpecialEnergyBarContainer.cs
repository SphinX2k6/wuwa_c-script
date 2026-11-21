using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004E01 RID: 19969
	[NullableContext(2)]
	[Nullable(0)]
	public class SpecialEnergyBarContainer : BattleVisibleChildView
	{
		// Token: 0x060323E7 RID: 205799 RVA: 0x00E1550C File Offset: 0x00E1370C
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

		// Token: 0x060323E8 RID: 205800 RVA: 0x00E15580 File Offset: 0x00E13780
		protected override void OnBeforeDestroy()
		{
			this.CurRoleBar = null;
			foreach (RoleSpecialEnergyBar roleSpecialEnergyBar in this.RoleBarMap.Values)
			{
				roleSpecialEnergyBar.Destroy();
			}
			this.MotorcycleSpecialEnergyBar.Destroy();
		}

		// Token: 0x060323E9 RID: 205801 RVA: 0x00E155E8 File Offset: 0x00E137E8
		public override void Reset()
		{
			this.RemoveEvents();
			base.Reset();
		}

		// Token: 0x060323EA RID: 205802 RVA: 0x00E155F8 File Offset: 0x00E137F8
		public void Tick(float delta)
		{
			foreach (RoleSpecialEnergyBar roleSpecialEnergyBar in this.RoleBarMap.Values)
			{
				roleSpecialEnergyBar.Tick(delta);
			}
			this.MotorcycleSpecialEnergyBar.Tick(delta);
		}

		// Token: 0x060323EB RID: 205803 RVA: 0x00E1565C File Offset: 0x00E1385C
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

		// Token: 0x060323EC RID: 205804 RVA: 0x00E156FC File Offset: 0x00E138FC
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

		// Token: 0x060323ED RID: 205805 RVA: 0x00E1572F File Offset: 0x00E1392F
		private void AddEvents()
		{
			EventSystem.Instance.Add(EEventName.BattleUiAllRoleDataChanged, new Action(this.OnFormationLoaded));
			this.MotorcycleSpecialEnergyBar.AddEvents();
		}

		// Token: 0x060323EE RID: 205806 RVA: 0x00E15758 File Offset: 0x00E13958
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.BattleUiAllRoleDataChanged, new Action(this.OnFormationLoaded));
			this.MotorcycleSpecialEnergyBar.RemoveEvents();
		}

		// Token: 0x060323EF RID: 205807 RVA: 0x00E15781 File Offset: 0x00E13981
		private void OnFormationLoaded()
		{
			this.LoadAllSpecialEnergyBar();
			this.RefreshAllSpecialEnergyBarVisible();
		}

		// Token: 0x060323F0 RID: 205808 RVA: 0x00E15790 File Offset: 0x00E13990
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

		// Token: 0x060323F1 RID: 205809 RVA: 0x00E1582C File Offset: 0x00E13A2C
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

		// Token: 0x060323F2 RID: 205810 RVA: 0x00E15878 File Offset: 0x00E13A78
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

		// Token: 0x060323F3 RID: 205811 RVA: 0x00E15900 File Offset: 0x00E13B00
		private void OnEnergyBarEnableChange()
		{
			this.RefreshAllSpecialEnergyBarVisible();
		}

		// Token: 0x0401AA00 RID: 109056
		private UUIItem PhantomContainer;

		// Token: 0x0401AA01 RID: 109057
		private int EntityId;

		// Token: 0x0401AA02 RID: 109058
		private RoleSpecialEnergyBar CurRoleBar;

		// Token: 0x0401AA03 RID: 109059
		[Nullable(1)]
		private readonly Dictionary<int, RoleSpecialEnergyBar> RoleBarMap = new Dictionary<int, RoleSpecialEnergyBar>();

		// Token: 0x0401AA04 RID: 109060
		[Nullable(1)]
		private readonly MotorcycleSpecialEnergyBar MotorcycleSpecialEnergyBar = new MotorcycleSpecialEnergyBar();
	}
}
