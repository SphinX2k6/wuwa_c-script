using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D56 RID: 23894
	[NullableContext(2)]
	[Nullable(0)]
	public class BattleHonamiStoryRoleItem : UiPanelBase
	{
		// Token: 0x0603CA93 RID: 248467 RVA: 0x00E8F67C File Offset: 0x00E8D87C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUINiagara));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603CA94 RID: 248468 RVA: 0x00E8F7AC File Offset: 0x00E8D9AC
		protected override UniTask OnBeforeStartAsync()
		{
			BattleHonamiStoryRoleItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BattleHonamiStoryRoleItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603CA95 RID: 248469 RVA: 0x00E8F7F0 File Offset: 0x00E8D9F0
		private UniTask CreateSuitItem(BattleHonamiStoryRoleItem.EComponentType suitType)
		{
			BattleHonamiStoryRoleItem.<CreateSuitItem>d__8 <CreateSuitItem>d__;
			<CreateSuitItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateSuitItem>d__.<>4__this = this;
			<CreateSuitItem>d__.suitType = suitType;
			<CreateSuitItem>d__.<>1__state = -1;
			<CreateSuitItem>d__.<>t__builder.Start<BattleHonamiStoryRoleItem.<CreateSuitItem>d__8>(ref <CreateSuitItem>d__);
			return <CreateSuitItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603CA96 RID: 248470 RVA: 0x00E8F83B File Offset: 0x00E8DA3B
		protected override void OnStart()
		{
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
			base.GetUiNiagara(7).SetUIActive(false);
		}

		// Token: 0x0603CA97 RID: 248471 RVA: 0x00E8F85B File Offset: 0x00E8DA5B
		protected override void OnBeforeShow()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlaySequencePurely("Start", false, false);
		}

		// Token: 0x0603CA98 RID: 248472 RVA: 0x00E8F874 File Offset: 0x00E8DA74
		protected override UniTask OnHideAsyncImplementImplement()
		{
			BattleHonamiStoryRoleItem.<OnHideAsyncImplementImplement>d__11 <OnHideAsyncImplementImplement>d__;
			<OnHideAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnHideAsyncImplementImplement>d__.<>4__this = this;
			<OnHideAsyncImplementImplement>d__.<>1__state = -1;
			<OnHideAsyncImplementImplement>d__.<>t__builder.Start<BattleHonamiStoryRoleItem.<OnHideAsyncImplementImplement>d__11>(ref <OnHideAsyncImplementImplement>d__);
			return <OnHideAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0603CA99 RID: 248473 RVA: 0x00E8F8B7 File Offset: 0x00E8DAB7
		protected override void OnAfterHide()
		{
			Action onAfterHideCallback = this.OnAfterHideCallback;
			if (onAfterHideCallback == null)
			{
				return;
			}
			onAfterHideCallback();
		}

		// Token: 0x0603CA9A RID: 248474 RVA: 0x00E8F8C9 File Offset: 0x00E8DAC9
		protected override void OnBeforeDestroy()
		{
			this.OnAfterHideCallback = null;
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
			TimerHandle hideTimerHandle = this.HideTimerHandle;
			if (hideTimerHandle != null)
			{
				hideTimerHandle.Remove();
			}
			this.HideTimerHandle = null;
		}

		// Token: 0x0603CA9B RID: 248475 RVA: 0x00E8F903 File Offset: 0x00E8DB03
		[NullableContext(1)]
		public void RegisterOnAfterHide(Action onAfterHide)
		{
			this.OnAfterHideCallback = onAfterHide;
		}

		// Token: 0x0603CA9C RID: 248476 RVA: 0x00E8F90C File Offset: 0x00E8DB0C
		[NullableContext(1)]
		public void ShowRoleItem(HonamiStoryRoleItemData data, int duration)
		{
			int roleId = data.RoleId;
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(roleId);
			if (roleConfig == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.HonamiStory;
				ELogAuthor author = ELogAuthor.LYY;
				string message = "拾取提示角色配置不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("RoleId", roleId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				Action onAfterHideCallback = this.OnAfterHideCallback;
				if (onAfterHideCallback == null)
				{
					return;
				}
				onAfterHideCallback();
				return;
			}
			else
			{
				RoleInfo value = roleConfig.Value;
				this.SetActive(true);
				UUITexture texture = base.GetTexture(0);
				texture.SetUIActive(false);
				RoleSkinData roleSkinDataByRoleId = RoleSkinModel.Instance.GetRoleSkinDataByRoleId(roleId);
				string path = (roleSkinDataByRoleId != null) ? roleSkinDataByRoleId.GetRoleSkinConfig().RoleHeadIconLarge : value.RoleHeadIconLarge;
				base.SetRoleIconByRoleIdOrSkinId(path, texture, roleId, new int?(value.SkinId), delegate(bool _)
				{
					UUITexture texture2 = base.GetTexture(0);
					if (texture2 == null)
					{
						return;
					}
					texture2.SetUIActive(true);
				}, null);
				if (data.BuffActive)
				{
					base.GetUiNiagara(7).SetUIActive(true);
					this.BuffEffectTimerHandle = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
					{
						this.BuffEffectTimerHandle = null;
						base.GetUiNiagara(7).SetUIActive(false);
					}, 1000f, null, null, true, 1f);
				}
				List<int> suitIdList = data.SuitIdList;
				List<HonamiStoryWeaponSuitActiveData> suitDataList = data.SuitDataList;
				bool flag = suitIdList == null || suitDataList == null;
				base.GetSprite(4).SetUIActive(flag);
				base.GetItem(5).SetUIActive(!flag);
				if (flag)
				{
					this.StartAutoHide(duration);
					return;
				}
				int itemSubType = data.ItemSubType;
				int count = this.SuitItems.Count;
				int num = Math.Min(suitIdList.Count, count);
				BattleHonamiStoryRoleSuitItem battleHonamiStoryRoleSuitItem = null;
				for (int i = 0; i < num; i++)
				{
					int suitId = suitIdList[i];
					HonamiStoryWeaponSuitActiveData honamiStoryWeaponSuitActiveData = suitDataList[i];
					int weaponPluginType = HonamiStoryModel.Instance.GetWeaponSuitData(suitId).WeaponPluginType;
					BattleHonamiStoryRoleSuitItem battleHonamiStoryRoleSuitItem2 = this.SuitItems[i];
					battleHonamiStoryRoleSuitItem2.Refresh(honamiStoryWeaponSuitActiveData, weaponPluginType);
					battleHonamiStoryRoleSuitItem2.SetUiActive(true);
					if (honamiStoryWeaponSuitActiveData.IsActive && itemSubType == weaponPluginType)
					{
						battleHonamiStoryRoleSuitItem = battleHonamiStoryRoleSuitItem2;
					}
				}
				if (battleHonamiStoryRoleSuitItem != null)
				{
					battleHonamiStoryRoleSuitItem.PlayBurst();
				}
				for (int j = num; j < count; j++)
				{
					this.SuitItems[j].SetUiActive(false);
				}
				this.StartAutoHide(duration);
				return;
			}
		}

		// Token: 0x0603CA9D RID: 248477 RVA: 0x00E8FB40 File Offset: 0x00E8DD40
		private void StartAutoHide(int duration)
		{
			this.HideTimerHandle = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				this.HideTimerHandle = null;
				if (!base.IsHideOrHiding)
				{
					this.SetActive(false);
				}
			}, (float)duration, null, null, true, 1f);
		}

		// Token: 0x0603CA9E RID: 248478 RVA: 0x00E8FB68 File Offset: 0x00E8DD68
		public void HideRoleItem()
		{
			TimerHandle hideTimerHandle = this.HideTimerHandle;
			if (hideTimerHandle != null)
			{
				hideTimerHandle.Remove();
			}
			this.HideTimerHandle = null;
			if (!base.IsHideOrHiding)
			{
				this.SetActive(false);
			}
		}

		// Token: 0x0401F996 RID: 129430
		[Nullable(1)]
		private readonly List<BattleHonamiStoryRoleSuitItem> SuitItems = new List<BattleHonamiStoryRoleSuitItem>();

		// Token: 0x0401F997 RID: 129431
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0401F998 RID: 129432
		private TimerHandle HideTimerHandle;

		// Token: 0x0401F999 RID: 129433
		private TimerHandle BuffEffectTimerHandle;

		// Token: 0x0401F99A RID: 129434
		private Action OnAfterHideCallback;

		// Token: 0x0200C004 RID: 49156
		[NullableContext(0)]
		private enum EComponentType
		{
			// Token: 0x04039F0F RID: 237327
			RoleTexture,
			// Token: 0x04039F10 RID: 237328
			SuitItemA,
			// Token: 0x04039F11 RID: 237329
			SuitItemB,
			// Token: 0x04039F12 RID: 237330
			SuitItemC,
			// Token: 0x04039F13 RID: 237331
			EmptySprite,
			// Token: 0x04039F14 RID: 237332
			SuitPanel,
			// Token: 0x04039F15 RID: 237333
			LevelUpSprite,
			// Token: 0x04039F16 RID: 237334
			BuffEffect
		}
	}
}
