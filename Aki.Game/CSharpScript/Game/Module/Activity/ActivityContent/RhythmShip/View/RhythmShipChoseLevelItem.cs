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
	// Token: 0x02005197 RID: 20887
	[NullableContext(1)]
	[Nullable(0)]
	internal class RhythmShipChoseLevelItem : UiPanelBase
	{
		// Token: 0x06034266 RID: 213606 RVA: 0x00E96E04 File Offset: 0x00E95004
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

		// Token: 0x06034267 RID: 213607 RVA: 0x00E96F4A File Offset: 0x00E9514A
		protected override void OnStart()
		{
			EventSystem.Instance.Add(EEventName.OnRhythmShipRedDotRefresh, new Action<List<int>, List<int>, List<int>>(this.OnRhythmShipRedDotRefresh));
		}

		// Token: 0x06034268 RID: 213608 RVA: 0x00E96F68 File Offset: 0x00E95168
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnRhythmShipRedDotRefresh, new Action<List<int>, List<int>, List<int>>(this.OnRhythmShipRedDotRefresh));
		}

		// Token: 0x06034269 RID: 213609 RVA: 0x00E96F88 File Offset: 0x00E95188
		protected override UniTask OnBeforeStartAsync()
		{
			RhythmShipChoseLevelItem.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RhythmShipChoseLevelItem.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603426A RID: 213610 RVA: 0x00E96FCC File Offset: 0x00E951CC
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

		// Token: 0x0603426B RID: 213611 RVA: 0x00E97064 File Offset: 0x00E95264
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

		// Token: 0x0603426C RID: 213612 RVA: 0x00E972B3 File Offset: 0x00E954B3
		private void RefreshRedDotItem()
		{
			this.HaveRedDotItem = RhythmShipModel.Instance.GetLevelRedDotActive(this.LevelId);
			base.GetItem(11).SetUIActive(this.HaveRedDotItem);
		}

		// Token: 0x0603426D RID: 213613 RVA: 0x00E972DE File Offset: 0x00E954DE
		private void OnClickToggle(EToggleState state)
		{
			Action<int> onClickToggleCallBack = this.OnClickToggleCallBack;
			if (onClickToggleCallBack == null)
			{
				return;
			}
			onClickToggleCallBack(this.LevelId);
		}

		// Token: 0x0603426E RID: 213614 RVA: 0x00E972F8 File Offset: 0x00E954F8
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

		// Token: 0x0603426F RID: 213615 RVA: 0x00E97378 File Offset: 0x00E95578
		public void SetToggleSelect(bool isSelect)
		{
			base.GetExtendToggle(0).SetToggleState(isSelect ? EToggleState.ETT_Checked : (this.IsLock ? EToggleState.ETT_UnDetermined : EToggleState.ETT_UnChecked), false, false, false);
		}

		// Token: 0x06034270 RID: 213616 RVA: 0x00E9739C File Offset: 0x00E9559C
		public void LevelSequencePlayerPlay(string name)
		{
			LevelSequencePlayer levelSequencePlayerIns = this.LevelSequencePlayerIns;
			if (levelSequencePlayerIns == null)
			{
				return;
			}
			levelSequencePlayerIns.PlayOrReplaySequenceByName(name, false, null);
		}

		// Token: 0x06034271 RID: 213617 RVA: 0x00E973C4 File Offset: 0x00E955C4
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

		// Token: 0x0401BA28 RID: 113192
		private int LevelId;

		// Token: 0x0401BA29 RID: 113193
		private bool IsLock;

		// Token: 0x0401BA2A RID: 113194
		private bool HaveRedDotItem;

		// Token: 0x0401BA2B RID: 113195
		private readonly List<RhythmShipChoseStarItem> StarItemList = new List<RhythmShipChoseStarItem>();

		// Token: 0x0401BA2C RID: 113196
		[Nullable(2)]
		public Action<int> OnClickToggleCallBack;

		// Token: 0x0401BA2D RID: 113197
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayerIns;
	}
}
