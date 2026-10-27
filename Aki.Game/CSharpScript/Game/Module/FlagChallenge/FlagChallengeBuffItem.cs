using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02005A5B RID: 23131
	[NullableContext(1)]
	[Nullable(0)]
	public class FlagChallengeBuffItem : UiPanelBase
	{
		// Token: 0x0603AA27 RID: 240167 RVA: 0x00DF56AC File Offset: 0x00DF38AC
		public FlagChallengeBuffItem(FlagChallengeBuffData data)
		{
			this.BuffData = data;
		}

		// Token: 0x0603AA28 RID: 240168 RVA: 0x00DF56BC File Offset: 0x00DF38BC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUITexture)),
				new ValueTuple<int, Type>(6, typeof(UUIText)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnBuffToggle))
			};
		}

		// Token: 0x0603AA29 RID: 240169 RVA: 0x00DF57C0 File Offset: 0x00DF39C0
		protected override void OnStart()
		{
			UUIItem item = base.GetItem(8);
			int id = this.BuffData.Id;
			RedDotController.Instance.BindRedDot(ERedDotName.RedDotFlagChallengeActivityBuffItemNewlyUnlocked, item, null, id);
			int buffActivityId = FlagChallengeUtils.GetBuffActivityId(id);
			FlagChallengeData flagChallengeData = FlagChallengeModel.Instance.GetFlagChallengeData(buffActivityId);
			item.SetUIActive(flagChallengeData.IsBuffNewlyUnlocked(id));
		}

		// Token: 0x0603AA2A RID: 240170 RVA: 0x00DF5813 File Offset: 0x00DF3A13
		protected override void OnBeforeDestroy()
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RedDotFlagChallengeActivityBuffItemNewlyUnlocked, base.GetItem(8), this.BuffData.Id);
		}

		// Token: 0x0603AA2B RID: 240171 RVA: 0x00DF5838 File Offset: 0x00DF3A38
		public void RefreshView()
		{
			base.GetText(6).SetText(this.BuffData.Config.Level.ToString(), true);
			this.UpdateToggleState();
			this.UpdateState();
		}

		// Token: 0x0603AA2C RID: 240172 RVA: 0x00DF587C File Offset: 0x00DF3A7C
		public void UpdateToggleState()
		{
			EToggleState state = this.BuffData.IsSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(1).SetToggleStateForce(state, false, false, false);
		}

		// Token: 0x0603AA2D RID: 240173 RVA: 0x00DF58AB File Offset: 0x00DF3AAB
		public void SetClickCallback(Action<FlagChallengeBuffData> callback)
		{
			this.ClickCallback = callback;
		}

		// Token: 0x0603AA2E RID: 240174 RVA: 0x00DF58B4 File Offset: 0x00DF3AB4
		private void OnBuffToggle(EToggleState state)
		{
			Action<FlagChallengeBuffData> clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback(this.BuffData);
		}

		// Token: 0x0603AA2F RID: 240175 RVA: 0x00DF58CC File Offset: 0x00DF3ACC
		public void UpdateState()
		{
			switch (this.BuffData.GetBuffStatus())
			{
			case EFlagChallengeBuffStatus.NotActive:
				this.SetStateNotActive();
				return;
			case EFlagChallengeBuffStatus.Active:
				this.SetStateActive();
				return;
			case EFlagChallengeBuffStatus.TempActive:
				this.SetStateTempActive();
				return;
			default:
				return;
			}
		}

		// Token: 0x0603AA30 RID: 240176 RVA: 0x00DF590C File Offset: 0x00DF3B0C
		public void SetStateActive()
		{
			this.SetStarState(true);
			this.SetLockState(false);
			this.SetStateItemShow(3);
			this.SetIcon(this.BuffData.Config.IconPathActive);
			this.SetUseIconChangeColor(true);
		}

		// Token: 0x0603AA31 RID: 240177 RVA: 0x00DF5950 File Offset: 0x00DF3B50
		public void SetStateTempActive()
		{
			this.SetStarState(true);
			this.SetLockState(false);
			this.SetStateItemShow(2);
			this.SetIcon(this.BuffData.Config.IconPathActive);
			this.SetUseIconChangeColor(true);
		}

		// Token: 0x0603AA32 RID: 240178 RVA: 0x00DF5994 File Offset: 0x00DF3B94
		public void SetStateNotActive()
		{
			this.SetStarState(false);
			this.SetLockState(true);
			this.SetStateItemShow(4);
			this.SetIcon(this.BuffData.Config.IconPathNormal);
			this.SetUseIconChangeColor(false);
		}

		// Token: 0x0603AA33 RID: 240179 RVA: 0x00DF59D6 File Offset: 0x00DF3BD6
		private void SetStarState(bool show)
		{
			base.GetSprite(0).SetUIActive(show);
		}

		// Token: 0x0603AA34 RID: 240180 RVA: 0x00DF59E5 File Offset: 0x00DF3BE5
		private void SetLockState(bool show)
		{
			base.GetItem(7).SetUIActive(show);
		}

		// Token: 0x0603AA35 RID: 240181 RVA: 0x00DF59F4 File Offset: 0x00DF3BF4
		private void SetIcon(string path)
		{
			UUITexture texture = base.GetTexture(5);
			base.SetTextureByPath(path, texture, null, null);
		}

		// Token: 0x0603AA36 RID: 240182 RVA: 0x00DF5A1C File Offset: 0x00DF3C1C
		private void SetUseIconChangeColor(bool isUse)
		{
			UUITexture texture = base.GetTexture(5);
			UUIItem uuiitem = texture;
			FColor? fcolor = new FColor?(texture.changeColor);
			uuiitem.SetChangeColor(isUse, fcolor);
		}

		// Token: 0x0603AA37 RID: 240183 RVA: 0x00DF5A48 File Offset: 0x00DF3C48
		private void SetStateItemShow(int index)
		{
			foreach (int num in new List<int>
			{
				3,
				2,
				4
			})
			{
				base.GetItem(num).SetUIActive(index == num);
			}
		}

		// Token: 0x0401E91A RID: 125210
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<FlagChallengeBuffData> ClickCallback;

		// Token: 0x0401E91B RID: 125211
		private readonly FlagChallengeBuffData BuffData;
	}
}
