using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DC5 RID: 24005
	[NullableContext(2)]
	[Nullable(0)]
	public class MotorcycleSpecialEnergyBar
	{
		// Token: 0x0603CFFA RID: 249850 RVA: 0x00EAA84B File Offset: 0x00EA8A4B
		[NullableContext(1)]
		public void Init(UUIItem parentItem, Action enableChange)
		{
			this.ParentItem = parentItem;
			this.EnableChangeCallback = enableChange;
			this.RefreshSpecialEnergyBar();
		}

		// Token: 0x0603CFFB RID: 249851 RVA: 0x00EAA861 File Offset: 0x00EA8A61
		public bool IsEnable()
		{
			return this.EnergyBar != null;
		}

		// Token: 0x0603CFFC RID: 249852 RVA: 0x00EAA86C File Offset: 0x00EA8A6C
		public void Destroy()
		{
			this.RemoveMotorcycleTagTask();
			this.DestroyEnergyBar();
			this.MotorcycleEntityHandle = null;
		}

		// Token: 0x0603CFFD RID: 249853 RVA: 0x00EAA881 File Offset: 0x00EA8A81
		public void Tick(float delta)
		{
			SpecialEnergyBarMotorcycle energyBar = this.EnergyBar;
			if (energyBar == null)
			{
				return;
			}
			energyBar.Tick(delta);
		}

		// Token: 0x0603CFFE RID: 249854 RVA: 0x00EAA894 File Offset: 0x00EA8A94
		public void AddEvents()
		{
			EventSystem.Instance.Add<bool>(EEventName.BattleUiMotorcycleStateChanged, new Action<bool>(this.BattleUiMotorcycleStateChanged));
		}

		// Token: 0x0603CFFF RID: 249855 RVA: 0x00EAA8B2 File Offset: 0x00EA8AB2
		public void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.BattleUiMotorcycleStateChanged, new Action<bool>(this.BattleUiMotorcycleStateChanged));
		}

		// Token: 0x0603D000 RID: 249856 RVA: 0x00EAA8D0 File Offset: 0x00EA8AD0
		private void BattleUiMotorcycleStateChanged(bool b)
		{
			this.RefreshSpecialEnergyBar();
		}

		// Token: 0x0603D001 RID: 249857 RVA: 0x00EAA8D8 File Offset: 0x00EA8AD8
		private void RefreshSpecialEnergyBar()
		{
			bool flag = this.IsEnable();
			if (BattleUiModel.Instance.MotorcycleData.IsDriving)
			{
				this.MotorcycleEntityHandle = BattleUiModel.Instance.MotorcycleData.MotorcycleEntityHandle;
				this.RemoveMotorcycleTagTask();
				this.AddMotorcycleTagTask(this.MotorcycleEntityHandle.Entity);
			}
			else
			{
				this.RemoveMotorcycleTagTask();
				this.DestroyEnergyBar();
				this.MotorcycleEntityHandle = null;
			}
			if (flag != this.IsEnable())
			{
				Action enableChangeCallback = this.EnableChangeCallback;
				if (enableChangeCallback == null)
				{
					return;
				}
				enableChangeCallback();
			}
		}

		// Token: 0x0603D002 RID: 249858 RVA: 0x00EAA958 File Offset: 0x00EA8B58
		[NullableContext(1)]
		private void AddMotorcycleTagTask(Entity entity)
		{
			BaseTagComponent component = entity.GetComponent<BaseTagComponent>();
			this.MotorcycleTagTask = component.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["关卡.沙虫BOSS战.开启脉冲炮弹能量槽"]), new BaseTagComponent.TTagSwitchedCallback(this.OnMotorcycleTagChange), null);
			if (component.HasTag(GameplayTagDefine.EGameplayTagId["关卡.沙虫BOSS战.开启脉冲炮弹能量槽"]))
			{
				this.CreateEnergyBar();
			}
		}

		// Token: 0x0603D003 RID: 249859 RVA: 0x00EAA9B6 File Offset: 0x00EA8BB6
		private void RemoveMotorcycleTagTask()
		{
			ITagTask motorcycleTagTask = this.MotorcycleTagTask;
			if (motorcycleTagTask != null)
			{
				motorcycleTagTask.EndTask();
			}
			this.MotorcycleTagTask = null;
		}

		// Token: 0x0603D004 RID: 249860 RVA: 0x00EAA9D0 File Offset: 0x00EA8BD0
		private void CreateEnergyBar()
		{
			if (this.EnergyBar != null)
			{
				this.DestroyEnergyBar();
			}
			this.InitAsync(this.MotorcycleEntityHandle).Forget();
		}

		// Token: 0x0603D005 RID: 249861 RVA: 0x00EAA9F4 File Offset: 0x00EA8BF4
		[NullableContext(1)]
		private UniTask InitAsync(EntityHandle entityHandle)
		{
			MotorcycleSpecialEnergyBar.<InitAsync>d__17 <InitAsync>d__;
			<InitAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitAsync>d__.<>4__this = this;
			<InitAsync>d__.entityHandle = entityHandle;
			<InitAsync>d__.<>1__state = -1;
			<InitAsync>d__.<>t__builder.Start<MotorcycleSpecialEnergyBar.<InitAsync>d__17>(ref <InitAsync>d__);
			return <InitAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D006 RID: 249862 RVA: 0x00EAAA3F File Offset: 0x00EA8C3F
		private void DestroyEnergyBar()
		{
			if (this.EnergyBar != null)
			{
				this.EnergyBar.Destroy(null);
				this.EnergyBar = null;
			}
		}

		// Token: 0x0603D007 RID: 249863 RVA: 0x00EAAA5C File Offset: 0x00EA8C5C
		private void OnMotorcycleTagChange(int tagId, bool tagExist)
		{
			bool flag = this.IsEnable();
			if (tagExist)
			{
				this.CreateEnergyBar();
			}
			else
			{
				this.DestroyEnergyBar();
			}
			if (flag != this.IsEnable())
			{
				Action enableChangeCallback = this.EnableChangeCallback;
				if (enableChangeCallback == null)
				{
					return;
				}
				enableChangeCallback();
			}
		}

		// Token: 0x0401FC7C RID: 130172
		private UUIItem ParentItem;

		// Token: 0x0401FC7D RID: 130173
		public int EntityId;

		// Token: 0x0401FC7E RID: 130174
		private SpecialEnergyBarMotorcycle EnergyBar;

		// Token: 0x0401FC7F RID: 130175
		private EntityHandle MotorcycleEntityHandle;

		// Token: 0x0401FC80 RID: 130176
		private ITagTask MotorcycleTagTask;

		// Token: 0x0401FC81 RID: 130177
		private Action EnableChangeCallback;
	}
}
