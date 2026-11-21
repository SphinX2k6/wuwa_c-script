using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DA9 RID: 19881
	[NullableContext(2)]
	[Nullable(0)]
	public class MotorcycleSpecialEnergyBar
	{
		// Token: 0x06031F71 RID: 204657 RVA: 0x00DFB727 File Offset: 0x00DF9927
		[NullableContext(1)]
		public void Init(UUIItem parentItem, Action enableChange)
		{
			this.ParentItem = parentItem;
			this.EnableChangeCallback = enableChange;
			this.RefreshSpecialEnergyBar();
		}

		// Token: 0x06031F72 RID: 204658 RVA: 0x00DFB73D File Offset: 0x00DF993D
		public bool IsEnable()
		{
			return this.EnergyBar != null;
		}

		// Token: 0x06031F73 RID: 204659 RVA: 0x00DFB748 File Offset: 0x00DF9948
		public void Destroy()
		{
			this.RemoveMotorcycleTagTask();
			this.DestroyEnergyBar();
			this.MotorcycleEntityHandle = null;
		}

		// Token: 0x06031F74 RID: 204660 RVA: 0x00DFB75D File Offset: 0x00DF995D
		public void Tick(float delta)
		{
			SpecialEnergyBarMotorcycle energyBar = this.EnergyBar;
			if (energyBar == null)
			{
				return;
			}
			energyBar.Tick(delta);
		}

		// Token: 0x06031F75 RID: 204661 RVA: 0x00DFB770 File Offset: 0x00DF9970
		public void AddEvents()
		{
			EventSystem.Instance.Add<bool>(EEventName.BattleUiMotorcycleStateChanged, new Action<bool>(this.BattleUiMotorcycleStateChanged));
		}

		// Token: 0x06031F76 RID: 204662 RVA: 0x00DFB78E File Offset: 0x00DF998E
		public void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.BattleUiMotorcycleStateChanged, new Action<bool>(this.BattleUiMotorcycleStateChanged));
		}

		// Token: 0x06031F77 RID: 204663 RVA: 0x00DFB7AC File Offset: 0x00DF99AC
		private void BattleUiMotorcycleStateChanged(bool b)
		{
			this.RefreshSpecialEnergyBar();
		}

		// Token: 0x06031F78 RID: 204664 RVA: 0x00DFB7B4 File Offset: 0x00DF99B4
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

		// Token: 0x06031F79 RID: 204665 RVA: 0x00DFB834 File Offset: 0x00DF9A34
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

		// Token: 0x06031F7A RID: 204666 RVA: 0x00DFB892 File Offset: 0x00DF9A92
		private void RemoveMotorcycleTagTask()
		{
			ITagTask motorcycleTagTask = this.MotorcycleTagTask;
			if (motorcycleTagTask != null)
			{
				motorcycleTagTask.EndTask();
			}
			this.MotorcycleTagTask = null;
		}

		// Token: 0x06031F7B RID: 204667 RVA: 0x00DFB8AC File Offset: 0x00DF9AAC
		private void CreateEnergyBar()
		{
			if (this.EnergyBar != null)
			{
				this.DestroyEnergyBar();
			}
			this.InitAsync(this.MotorcycleEntityHandle).Forget();
		}

		// Token: 0x06031F7C RID: 204668 RVA: 0x00DFB8D0 File Offset: 0x00DF9AD0
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

		// Token: 0x06031F7D RID: 204669 RVA: 0x00DFB91B File Offset: 0x00DF9B1B
		private void DestroyEnergyBar()
		{
			if (this.EnergyBar != null)
			{
				this.EnergyBar.Destroy(null);
				this.EnergyBar = null;
			}
		}

		// Token: 0x06031F7E RID: 204670 RVA: 0x00DFB938 File Offset: 0x00DF9B38
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

		// Token: 0x0401A739 RID: 108345
		private UUIItem ParentItem;

		// Token: 0x0401A73A RID: 108346
		public int EntityId;

		// Token: 0x0401A73B RID: 108347
		private SpecialEnergyBarMotorcycle EnergyBar;

		// Token: 0x0401A73C RID: 108348
		private EntityHandle MotorcycleEntityHandle;

		// Token: 0x0401A73D RID: 108349
		private ITagTask MotorcycleTagTask;

		// Token: 0x0401A73E RID: 108350
		private Action EnableChangeCallback;
	}
}
