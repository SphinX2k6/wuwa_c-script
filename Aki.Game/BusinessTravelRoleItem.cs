using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Activity.ActivityContent.MoonChasing;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020007E6 RID: 2022
[NullableContext(1)]
[Nullable(0)]
public class BusinessTravelRoleItem : GridProxyAbstract<int>
{
	// Token: 0x06005C6D RID: 23661 RVA: 0x001DCB38 File Offset: 0x001DAD38
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(USpineSkeletonAnimationComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIItem))
		};
	}

	// Token: 0x06005C6E RID: 23662 RVA: 0x001DCC30 File Offset: 0x001DAE30
	protected override void OnStart()
	{
		this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.SequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.FinishEvent), false);
		UUIItem item = base.GetItem(3);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIItem item2 = base.GetItem(9);
		if (item2 != null)
		{
			item2.SetUIActive(false);
		}
		UUIItem item3 = base.GetItem(4);
		if (item3 != null)
		{
			item3.SetUIActive(false);
		}
		UUIItem item4 = base.GetItem(5);
		if (item4 != null)
		{
			item4.SetUIActive(false);
		}
		UUIItem item5 = base.GetItem(6);
		if (item5 != null)
		{
			item5.SetUIActive(false);
		}
		UUIItem item6 = base.GetItem(1);
		if (item6 == null)
		{
			return;
		}
		item6.SetUIActive(false);
	}

	// Token: 0x06005C6F RID: 23663 RVA: 0x001DCCD8 File Offset: 0x001DAED8
	protected override void OnBeforeDestroy()
	{
		this.SequencePlayer.Clear();
	}

	// Token: 0x06005C70 RID: 23664 RVA: 0x001DCCE5 File Offset: 0x001DAEE5
	private void FinishEvent(string name)
	{
		if (name == "Action03")
		{
			this.HideDialog();
			this.SetSuccessItemActive(false);
			this.SetFailItemActive(false);
			this.SetNormalItemActive(false);
			this.HideFavorItem();
			this.SetLightItemActive(false);
		}
	}

	// Token: 0x06005C71 RID: 23665 RVA: 0x001DCD1C File Offset: 0x001DAF1C
	private void SwitchRoleSpineAnim(ESpineAnimation animName, float mixDuration)
	{
		UTrackEntry utrackEntry = base.GetSpine(0).SetAnimation(0, animName.ToString(), true);
		if (utrackEntry == null)
		{
			return;
		}
		utrackEntry.SetMixDuration(mixDuration);
	}

	// Token: 0x06005C72 RID: 23666 RVA: 0x001DCD44 File Offset: 0x001DAF44
	private void ShowDialog(string textId)
	{
		UUIItem item = base.GetItem(1);
		if (item != null)
		{
			item.SetUIActive(true);
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), textId, Array.Empty<object>());
	}

	// Token: 0x06005C73 RID: 23667 RVA: 0x001DCD70 File Offset: 0x001DAF70
	private void HideDialog()
	{
		UUIItem item = base.GetItem(1);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(false);
	}

	// Token: 0x06005C74 RID: 23668 RVA: 0x001DCD84 File Offset: 0x001DAF84
	private void SetSuccessItemActive(bool value)
	{
		UUIItem item = base.GetItem(3);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(value);
	}

	// Token: 0x06005C75 RID: 23669 RVA: 0x001DCD98 File Offset: 0x001DAF98
	private void SetFailItemActive(bool value)
	{
		UUIItem item = base.GetItem(4);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(value);
	}

	// Token: 0x06005C76 RID: 23670 RVA: 0x001DCDAC File Offset: 0x001DAFAC
	private void SetNormalItemActive(bool value)
	{
		UUIItem item = base.GetItem(5);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(value);
	}

	// Token: 0x06005C77 RID: 23671 RVA: 0x001DCDC0 File Offset: 0x001DAFC0
	private void ShowFavorItem(int lastLevel)
	{
		EditTeamData editTeamDataById = MoonChasingBusinessModel.Instance.GetEditTeamDataById(this.RoleId);
		if (editTeamDataById.Level > lastLevel)
		{
			UUIItem item = base.GetItem(6);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			UUIText text = base.GetText(7);
			if (text != null)
			{
				text.SetText(lastLevel.ToString(), true);
			}
			UUIText text2 = base.GetText(8);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(editTeamDataById.Level.ToString(), true);
		}
	}

	// Token: 0x06005C78 RID: 23672 RVA: 0x001DCE36 File Offset: 0x001DB036
	private void HideFavorItem()
	{
		UUIItem item = base.GetItem(6);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(false);
	}

	// Token: 0x06005C79 RID: 23673 RVA: 0x001DCE4A File Offset: 0x001DB04A
	private void SetLightItemActive(bool value)
	{
		UUIItem item = base.GetItem(9);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(value);
	}

	// Token: 0x06005C7A RID: 23674 RVA: 0x001DCE5F File Offset: 0x001DB05F
	public override void Refresh(int roleId, bool isSelected, int gridIndex)
	{
		this.RoleId = roleId;
	}

	// Token: 0x06005C7B RID: 23675 RVA: 0x001DCE68 File Offset: 0x001DB068
	public UniTask RefreshAsync()
	{
		BusinessTravelRoleItem.<RefreshAsync>d__17 <RefreshAsync>d__;
		<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAsync>d__.<>4__this = this;
		<RefreshAsync>d__.<>1__state = -1;
		<RefreshAsync>d__.<>t__builder.Start<BusinessTravelRoleItem.<RefreshAsync>d__17>(ref <RefreshAsync>d__);
		return <RefreshAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06005C7C RID: 23676 RVA: 0x001DCEAC File Offset: 0x001DB0AC
	public void PlayStartAction()
	{
		AudioSystem.Instance.PostEvent("play_ui_zuiyuejie_loading");
		this.SequencePlayer.PlayLevelSequenceByName("Action01", false, null, false);
		this.SwitchRoleSpineAnim(ESpineAnimation.Working, 0.1f);
		this.SetLightItemActive(true);
	}

	// Token: 0x06005C7D RID: 23677 RVA: 0x001DCEFC File Offset: 0x001DB0FC
	public void PlayRunFinishAction(RoleSettleResult result, int lastLevel)
	{
		AudioSystem.Instance.ExecuteAction("play_ui_zuiyuejie_loading", EAudioActionType.Stop, null);
		this.SequencePlayer.PlayLevelSequenceByName("Action02", false, null, false);
		EntrustRole entrustRoleById = BusinessConfig.Instance.GetEntrustRoleById(this.RoleId);
		if (result == RoleSettleResult.Good)
		{
			AudioSystem.Instance.PostEvent("play_ui_zhuiyuejie_positive");
			this.ShowDialog(entrustRoleById.SuccessDialog);
			this.SwitchRoleSpineAnim(ESpineAnimation.Success, 0f);
			this.SetSuccessItemActive(true);
		}
		else if (result == RoleSettleResult.Bad)
		{
			AudioSystem.Instance.PostEvent("play_ui_zhuiyuejie_passive");
			this.ShowDialog(entrustRoleById.FailDialog);
			this.SwitchRoleSpineAnim(ESpineAnimation.Fail, 0f);
			this.SetFailItemActive(true);
		}
		else
		{
			AudioSystem.Instance.PostEvent("play_ui_haoping");
			this.SwitchRoleSpineAnim(ESpineAnimation.Idle, 0f);
			this.SetNormalItemActive(true);
		}
		this.ShowFavorItem(lastLevel);
	}

	// Token: 0x06005C7E RID: 23678 RVA: 0x001DCFF0 File Offset: 0x001DB1F0
	public void PlayEndAction()
	{
		this.SequencePlayer.PlayLevelSequenceByName("Action03", false, null, false);
	}

	// Token: 0x06005C7F RID: 23679 RVA: 0x001DD018 File Offset: 0x001DB218
	public void StopRunToLastFrame()
	{
		this.SequencePlayer.StopSequenceByKey("Action02", true, true);
	}

	// Token: 0x06005C80 RID: 23680 RVA: 0x001DD02C File Offset: 0x001DB22C
	public int GetRoleId()
	{
		return this.RoleId;
	}

	// Token: 0x04003D97 RID: 15767
	protected int RoleId;

	// Token: 0x04003D98 RID: 15768
	protected LevelSequencePlayer SequencePlayer;

	// Token: 0x02006B29 RID: 27433
	[NullableContext(0)]
	private static class ERoleItem
	{
		// Token: 0x040233E9 RID: 144361
		public const int RoleSpine = 0;

		// Token: 0x040233EA RID: 144362
		public const int DialogItem = 1;

		// Token: 0x040233EB RID: 144363
		public const int Dialog = 2;

		// Token: 0x040233EC RID: 144364
		public const int SuccessItem = 3;

		// Token: 0x040233ED RID: 144365
		public const int FailItem = 4;

		// Token: 0x040233EE RID: 144366
		public const int NormalItem = 5;

		// Token: 0x040233EF RID: 144367
		public const int MultiLevelItem = 6;

		// Token: 0x040233F0 RID: 144368
		public const int MultiLevelBefore = 7;

		// Token: 0x040233F1 RID: 144369
		public const int MultiLevelAfter = 8;

		// Token: 0x040233F2 RID: 144370
		public const int LightItem = 9;
	}
}
