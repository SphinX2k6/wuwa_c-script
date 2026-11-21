using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02004A37 RID: 18999
	[NullableContext(1)]
	[Nullable(0)]
	public class FlagChallengeBuffItem : UiPanelBase
	{
		// Token: 0x0602F970 RID: 194928 RVA: 0x00D45C30 File Offset: 0x00D43E30
		public FlagChallengeBuffItem(FlagChallengeBuffData data)
		{
			this.BuffData = data;
		}

		// Token: 0x0602F971 RID: 194929 RVA: 0x00D45C40 File Offset: 0x00D43E40
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

		// Token: 0x0602F972 RID: 194930 RVA: 0x00D45D44 File Offset: 0x00D43F44
		protected override void OnStart()
		{
			UUIItem item = base.GetItem(8);
			int id = this.BuffData.Id;
			RedDotController.Instance.BindRedDot(ERedDotName.RedDotFlagChallengeActivityBuffItemNewlyUnlocked, item, null, id);
			int buffActivityId = FlagChallengeUtils.GetBuffActivityId(id);
			FlagChallengeData flagChallengeData = FlagChallengeModel.Instance.GetFlagChallengeData(buffActivityId);
			item.SetUIActive(flagChallengeData.IsBuffNewlyUnlocked(id));
		}

		// Token: 0x0602F973 RID: 194931 RVA: 0x00D45D97 File Offset: 0x00D43F97
		protected override void OnBeforeDestroy()
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RedDotFlagChallengeActivityBuffItemNewlyUnlocked, base.GetItem(8), this.BuffData.Id);
		}

		// Token: 0x0602F974 RID: 194932 RVA: 0x00D45DBC File Offset: 0x00D43FBC
		public void RefreshView()
		{
			base.GetText(6).SetText(this.BuffData.Config.Level.ToString(), true);
			this.UpdateToggleState();
			this.UpdateState();
		}

		// Token: 0x0602F975 RID: 194933 RVA: 0x00D45E00 File Offset: 0x00D44000
		public void UpdateToggleState()
		{
			EToggleState state = this.BuffData.IsSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(1).SetToggleStateForce(state, false, false, false);
		}

		// Token: 0x0602F976 RID: 194934 RVA: 0x00D45E2F File Offset: 0x00D4402F
		public void SetClickCallback(Action<FlagChallengeBuffData> callback)
		{
			this.ClickCallback = callback;
		}

		// Token: 0x0602F977 RID: 194935 RVA: 0x00D45E38 File Offset: 0x00D44038
		private void OnBuffToggle(EToggleState state)
		{
			Action<FlagChallengeBuffData> clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback(this.BuffData);
		}

		// Token: 0x0602F978 RID: 194936 RVA: 0x00D45E50 File Offset: 0x00D44050
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

		// Token: 0x0602F979 RID: 194937 RVA: 0x00D45E90 File Offset: 0x00D44090
		public void SetStateActive()
		{
			this.SetStarState(true);
			this.SetLockState(false);
			this.SetStateItemShow(3);
			this.SetIcon(this.BuffData.Config.IconPathActive);
			this.SetUseIconChangeColor(true);
		}

		// Token: 0x0602F97A RID: 194938 RVA: 0x00D45ED4 File Offset: 0x00D440D4
		public void SetStateTempActive()
		{
			this.SetStarState(true);
			this.SetLockState(false);
			this.SetStateItemShow(2);
			this.SetIcon(this.BuffData.Config.IconPathActive);
			this.SetUseIconChangeColor(true);
		}

		// Token: 0x0602F97B RID: 194939 RVA: 0x00D45F18 File Offset: 0x00D44118
		public void SetStateNotActive()
		{
			this.SetStarState(false);
			this.SetLockState(true);
			this.SetStateItemShow(4);
			this.SetIcon(this.BuffData.Config.IconPathNormal);
			this.SetUseIconChangeColor(false);
		}

		// Token: 0x0602F97C RID: 194940 RVA: 0x00D45F5A File Offset: 0x00D4415A
		private void SetStarState(bool show)
		{
			base.GetSprite(0).SetUIActive(show);
		}

		// Token: 0x0602F97D RID: 194941 RVA: 0x00D45F69 File Offset: 0x00D44169
		private void SetLockState(bool show)
		{
			base.GetItem(7).SetUIActive(show);
		}

		// Token: 0x0602F97E RID: 194942 RVA: 0x00D45F78 File Offset: 0x00D44178
		private void SetIcon(string path)
		{
			UUITexture texture = base.GetTexture(5);
			base.SetTextureByPath(path, texture, null, null);
		}

		// Token: 0x0602F97F RID: 194943 RVA: 0x00D45FA0 File Offset: 0x00D441A0
		private void SetUseIconChangeColor(bool isUse)
		{
			UUITexture texture = base.GetTexture(5);
			UUIItem uuiitem = texture;
			FColor? fcolor = new FColor?(texture.changeColor);
			uuiitem.SetChangeColor(isUse, fcolor);
		}

		// Token: 0x0602F980 RID: 194944 RVA: 0x00D45FCC File Offset: 0x00D441CC
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

		// Token: 0x040193C1 RID: 103361
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<FlagChallengeBuffData> ClickCallback;

		// Token: 0x040193C2 RID: 103362
		private readonly FlagChallengeBuffData BuffData;
	}
}
