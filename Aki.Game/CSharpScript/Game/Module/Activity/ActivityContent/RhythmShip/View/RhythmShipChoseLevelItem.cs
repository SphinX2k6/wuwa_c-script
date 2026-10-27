using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x02006219 RID: 25113
	[NullableContext(1)]
	[Nullable(0)]
	internal class RhythmShipChoseLevelItem : UiPanelBase
	{
		// Token: 0x0603F5A5 RID: 259493 RVA: 0x00F4FEAC File Offset: 0x00F4E0AC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUITexture)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle))
			};
		}

		// Token: 0x0603F5A6 RID: 259494 RVA: 0x00F4FFF2 File Offset: 0x00F4E1F2
		protected override void OnStart()
		{
			EventSystem.Instance.Add(EEventName.OnRhythmShipRedDotRefresh, new Action<List<int>, List<int>, List<int>>(this.OnRhythmShipRedDotRefresh));
		}

		// Token: 0x0603F5A7 RID: 259495 RVA: 0x00F50010 File Offset: 0x00F4E210
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnRhythmShipRedDotRefresh, new Action<List<int>, List<int>, List<int>>(this.OnRhythmShipRedDotRefresh));
		}

		// Token: 0x0603F5A8 RID: 259496 RVA: 0x00F50030 File Offset: 0x00F4E230
		protected override UniTask OnBeforeStartAsync()
		{
			RhythmShipChoseLevelItem.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RhythmShipChoseLevelItem.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F5A9 RID: 259497 RVA: 0x00F50074 File Offset: 0x00F4E274
		private void OnToggleUndeterminedClicked()
		{
			RhythmShipLevel? rhythmShipLevelById = RhythmShipConfig.Instance.GetRhythmShipLevelById(this.LevelId);
			if (rhythmShipLevelById == null)
			{
				return;
			}
			if (!RhythmShipModel.Instance.GetPlanetLevelUnlock(rhythmShipLevelById.Value.Planet))
			{
				ScrollingTipsController.Instance.ShowTipsByText(RhythmShipModel.Instance.GetPlanetOpenLeftTimeString(rhythmShipLevelById.Value.Planet) ?? "");
				return;
			}
			ScrollingTipsController.Instance.ShowTipsByTextId(RhythmShipModel.Instance.GetLevelLockTips(this.LevelId) ?? "RhythmShipLevelLockTips", Array.Empty<object>());
		}

		// Token: 0x0603F5AA RID: 259498 RVA: 0x00F5010C File Offset: 0x00F4E30C
		public void RefreshItem(int levelId, bool playTinyAni)
		{
			this.LevelId = levelId;
			if (this.LevelId == 0)
			{
				base.SetUiActive(false);
				return;
			}
			base.SetUiActive(true);
			RhythmShipLevel? rhythmShipLevelById = RhythmShipConfig.Instance.GetRhythmShipLevelById(this.LevelId);
			if (rhythmShipLevelById == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), rhythmShipLevelById.Value.Name, Array.Empty<object>());
			base.SetTextureByPath(rhythmShipLevelById.Value.IconTexture, base.GetTexture(1), null, null);
			Dictionary<int, RhythmSubLevelPb> subLevelInfoMapByLevelId = RhythmShipModel.Instance.GetSubLevelInfoMapByLevelId(this.LevelId);
			List<int> list;
			RhythmShipModel.Instance.LevelSubLevelInfoMap.TryGetValue(this.LevelId, out list);
			list = (list ?? new List<int>());
			for (int i = 0; i < this.StarItemList.Count; i++)
			{
				RhythmShipChoseStarItem rhythmShipChoseStarItem = this.StarItemList[i];
				bool flag = i < list.Count;
				rhythmShipChoseStarItem.SetUiActive(flag);
				if (flag)
				{
					RhythmSubLevelPb rhythmSubLevelPb = null;
					if (subLevelInfoMapByLevelId != null)
					{
						subLevelInfoMapByLevelId.TryGetValue(list[i], out rhythmSubLevelPb);
					}
					bool lightItemActive = rhythmSubLevelPb != null && rhythmSubLevelPb.Cleared;
					rhythmShipChoseStarItem.SetLightItemActive(lightItemActive);
				}
			}
			this.IsLock = !RhythmShipModel.Instance.GetLevelIsUnlock(this.LevelId);
			base.GetExtendToggle(0).SetToggleState(this.IsLock ? EToggleState.ETT_UnDetermined : EToggleState.ETT_UnChecked, false, false, false);
			base.GetItem(9).SetUIActive(this.IsLock);
			this.RefreshRedDotItem();
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("T_RhythmShipLevelNum0" + rhythmShipLevelById.Value.SortNumber.ToString());
			base.SetTextureByPath(resourcePath, base.GetTexture(2), null, null);
			RhythmShipPlanet? rhythmShipPlanetById = RhythmShipConfig.Instance.GetRhythmShipPlanetById(rhythmShipLevelById.Value.Planet);
			ERhythmShipLevelBgType erhythmShipLevelBgType = (ERhythmShipLevelBgType)((rhythmShipPlanetById != null) ? rhythmShipPlanetById.Value.LevelType : 1);
			base.GetItem(7).SetUIActive(erhythmShipLevelBgType == ERhythmShipLevelBgType.BgA);
			base.GetItem(8).SetUIActive(erhythmShipLevelBgType == ERhythmShipLevelBgType.BgB);
			if (playTinyAni)
			{
				LevelSequencePlayer levelSequencePlayerIns = this.LevelSequencePlayerIns;
				if (levelSequencePlayerIns == null)
				{
					return;
				}
				levelSequencePlayerIns.PlayLevelSequenceByName("Tiny", false, null, false);
			}
		}

		// Token: 0x0603F5AB RID: 259499 RVA: 0x00F5035B File Offset: 0x00F4E55B
		private void RefreshRedDotItem()
		{
			this.HaveRedDotItem = RhythmShipModel.Instance.GetLevelRedDotActive(this.LevelId);
			base.GetItem(11).SetUIActive(this.HaveRedDotItem);
		}

		// Token: 0x0603F5AC RID: 259500 RVA: 0x00F50386 File Offset: 0x00F4E586
		private void OnClickToggle(EToggleState state)
		{
			Action<int> onClickToggleCallBack = this.OnClickToggleCallBack;
			if (onClickToggleCallBack == null)
			{
				return;
			}
			onClickToggleCallBack(this.LevelId);
		}

		// Token: 0x0603F5AD RID: 259501 RVA: 0x00F503A0 File Offset: 0x00F4E5A0
		[NullableContext(2)]
		private void OnRhythmShipRedDotRefresh(List<int> planet, List<int> subLevel, List<int> role)
		{
			if (subLevel == null || !this.HaveRedDotItem)
			{
				return;
			}
			List<int> list;
			RhythmShipModel.Instance.LevelSubLevelInfoMap.TryGetValue(this.LevelId, out list);
			foreach (int item in subLevel)
			{
				if (list != null && list.Contains(item))
				{
					this.RefreshRedDotItem();
					break;
				}
			}
		}

		// Token: 0x0603F5AE RID: 259502 RVA: 0x00F50420 File Offset: 0x00F4E620
		public void SetToggleSelect(bool isSelect)
		{
			base.GetExtendToggle(0).SetToggleState(isSelect ? EToggleState.ETT_Checked : (this.IsLock ? EToggleState.ETT_UnDetermined : EToggleState.ETT_UnChecked), false, false, false);
		}

		// Token: 0x0603F5AF RID: 259503 RVA: 0x00F50444 File Offset: 0x00F4E644
		public void LevelSequencePlayerPlay(string name)
		{
			LevelSequencePlayer levelSequencePlayerIns = this.LevelSequencePlayerIns;
			if (levelSequencePlayerIns == null)
			{
				return;
			}
			levelSequencePlayerIns.PlayOrReplaySequenceByName(name, false, null);
		}

		// Token: 0x0603F5B0 RID: 259504 RVA: 0x00F5046C File Offset: 0x00F4E66C
		private void OnLevelSequenceEnd(string name)
		{
			if (name == "Big" || name == "Small")
			{
				if (!this.IsLock && !RhythmShipModel.Instance.GetLocalHavePlayAniByLevelId(this.LevelId))
				{
					base.GetItem(9).SetUIActive(true);
					LevelSequencePlayer levelSequencePlayerIns = this.LevelSequencePlayerIns;
					if (levelSequencePlayerIns != null)
					{
						levelSequencePlayerIns.PlayLevelSequenceByName("Unlock", false, null, false);
					}
					RhythmShipModel.Instance.SetLocalHavePlayAniLevelId(this.LevelId);
					return;
				}
			}
			else
			{
				base.GetItem(9).SetUIActive(this.IsLock);
			}
		}

		// Token: 0x040210F9 RID: 135417
		private int LevelId;

		// Token: 0x040210FA RID: 135418
		private bool IsLock;

		// Token: 0x040210FB RID: 135419
		private bool HaveRedDotItem;

		// Token: 0x040210FC RID: 135420
		private readonly List<RhythmShipChoseStarItem> StarItemList = new List<RhythmShipChoseStarItem>();

		// Token: 0x040210FD RID: 135421
		[Nullable(2)]
		public Action<int> OnClickToggleCallBack;

		// Token: 0x040210FE RID: 135422
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayerIns;
	}
}
