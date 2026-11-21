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
	// Token: 0x02004D38 RID: 19768
	[NullableContext(2)]
	[Nullable(0)]
	public class BattleHonamiStoryRoleItem : UiPanelBase
	{
		// Token: 0x060319EC RID: 203244 RVA: 0x00DDFE30 File Offset: 0x00DDE030
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

		// Token: 0x060319ED RID: 203245 RVA: 0x00DDFF60 File Offset: 0x00DDE160
		protected override UniTask OnBeforeStartAsync()
		{
			BattleHonamiStoryRoleItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BattleHonamiStoryRoleItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060319EE RID: 203246 RVA: 0x00DDFFA4 File Offset: 0x00DDE1A4
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

		// Token: 0x060319EF RID: 203247 RVA: 0x00DDFFEF File Offset: 0x00DDE1EF
		protected override void OnStart()
		{
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
			base.GetUiNiagara(7).SetUIActive(false);
		}

		// Token: 0x060319F0 RID: 203248 RVA: 0x00DE000F File Offset: 0x00DDE20F
		protected override void OnBeforeShow()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlaySequencePurely("Start", false, false);
		}

		// Token: 0x060319F1 RID: 203249 RVA: 0x00DE0028 File Offset: 0x00DDE228
		protected override UniTask OnHideAsyncImplementImplement()
		{
			BattleHonamiStoryRoleItem.<OnHideAsyncImplementImplement>d__11 <OnHideAsyncImplementImplement>d__;
			<OnHideAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnHideAsyncImplementImplement>d__.<>4__this = this;
			<OnHideAsyncImplementImplement>d__.<>1__state = -1;
			<OnHideAsyncImplementImplement>d__.<>t__builder.Start<BattleHonamiStoryRoleItem.<OnHideAsyncImplementImplement>d__11>(ref <OnHideAsyncImplementImplement>d__);
			return <OnHideAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x060319F2 RID: 203250 RVA: 0x00DE006B File Offset: 0x00DDE26B
		protected override void OnAfterHide()
		{
			Action onAfterHideCallback = this.OnAfterHideCallback;
			if (onAfterHideCallback == null)
			{
				return;
			}
			onAfterHideCallback();
		}

		// Token: 0x060319F3 RID: 203251 RVA: 0x00DE007D File Offset: 0x00DDE27D
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

		// Token: 0x060319F4 RID: 203252 RVA: 0x00DE00B7 File Offset: 0x00DDE2B7
		[NullableContext(1)]
		public void RegisterOnAfterHide(Action onAfterHide)
		{
			this.OnAfterHideCallback = onAfterHide;
		}

		// Token: 0x060319F5 RID: 203253 RVA: 0x00DE00C0 File Offset: 0x00DDE2C0
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

		// Token: 0x060319F6 RID: 203254 RVA: 0x00DE02F4 File Offset: 0x00DDE4F4
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

		// Token: 0x060319F7 RID: 203255 RVA: 0x00DE031C File Offset: 0x00DDE51C
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

		// Token: 0x0401A44F RID: 107599
		[Nullable(1)]
		private readonly List<BattleHonamiStoryRoleSuitItem> SuitItems = new List<BattleHonamiStoryRoleSuitItem>();

		// Token: 0x0401A450 RID: 107600
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0401A451 RID: 107601
		private TimerHandle HideTimerHandle;

		// Token: 0x0401A452 RID: 107602
		private TimerHandle BuffEffectTimerHandle;

		// Token: 0x0401A453 RID: 107603
		private Action OnAfterHideCallback;

		// Token: 0x0200AA0A RID: 43530
		[NullableContext(0)]
		private enum EComponentType
		{
			// Token: 0x040348D1 RID: 215249
			RoleTexture,
			// Token: 0x040348D2 RID: 215250
			SuitItemA,
			// Token: 0x040348D3 RID: 215251
			SuitItemB,
			// Token: 0x040348D4 RID: 215252
			SuitItemC,
			// Token: 0x040348D5 RID: 215253
			EmptySprite,
			// Token: 0x040348D6 RID: 215254
			SuitPanel,
			// Token: 0x040348D7 RID: 215255
			LevelUpSprite,
			// Token: 0x040348D8 RID: 215256
			BuffEffect
		}
	}
}
