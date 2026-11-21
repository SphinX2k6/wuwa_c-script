using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001D18 RID: 7448
public class RoleIconItem : UiPanelBase
{
	// Token: 0x0601270A RID: 75530 RVA: 0x00572C04 File Offset: 0x00570E04
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUISprite)),
			new ValueTuple<int, Type>(3, typeof(UUISprite))
		};
	}

	// Token: 0x0601270B RID: 75531 RVA: 0x00572C74 File Offset: 0x00570E74
	protected override void OnStart()
	{
		this.SequencePlayer = new UiSequencePlayer(this.RootItem);
	}

	// Token: 0x0601270C RID: 75532 RVA: 0x00572C88 File Offset: 0x00570E88
	[NullableContext(1)]
	public void Refresh(RoleDataBase roleInstance)
	{
		this.QualityId = roleInstance.GetRoleConfig().QualityId;
		base.SetRoleIconByRoleIdOrSkinId(roleInstance.GetRoleConfig().RoleHeadIconBig, base.GetTexture(0), roleInstance.GetRoleId(), new int?(roleInstance.GetRoleSkinId()), null, new EUiViewName?(EUiViewName.RoleRootView));
		this.RefreshQualitySprite(this.QualityId);
		this.PlaySequenceByQualityId(this.QualityId);
	}

	// Token: 0x0601270D RID: 75533 RVA: 0x00572CF8 File Offset: 0x00570EF8
	private void PlaySequenceByQualityId(int qualityId)
	{
		if (qualityId == 4)
		{
			this.SequencePlayer.PlaySequencePurely("Purple".ToString(), false, false);
			return;
		}
		if (qualityId == 5)
		{
			this.SequencePlayer.PlaySequencePurely("Yellow".ToString(), false, false);
		}
	}

	// Token: 0x0601270E RID: 75534 RVA: 0x00572D34 File Offset: 0x00570F34
	public void PlaySelectSequence()
	{
		int qualityId = this.QualityId;
		if (qualityId == 4)
		{
			this.SequencePlayer.PlaySequencePurely("PurpleSelect".ToString(), false, false);
			return;
		}
		if (qualityId != 5)
		{
			return;
		}
		this.SequencePlayer.PlaySequencePurely("YellowSelect".ToString(), false, false);
	}

	// Token: 0x0601270F RID: 75535 RVA: 0x00572D80 File Offset: 0x00570F80
	public void StopSelectSequence()
	{
		this.SequencePlayer.StopSequenceByKey("PurpleSelect".ToString(), false, true);
		this.SequencePlayer.StopSequenceByKey("YellowSelect".ToString(), false, true);
	}

	// Token: 0x06012710 RID: 75536 RVA: 0x00572DB0 File Offset: 0x00570FB0
	private void RefreshQualitySprite(int qualityId)
	{
		UUISprite sprite = base.GetSprite(1);
		UUISprite sprite2 = base.GetSprite(2);
		UUISprite sprite3 = base.GetSprite(3);
		UiResourceConfig instance = UiResourceConfig.Instance;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 1);
		defaultInterpolatedStringHandler.AppendLiteral("SP_RoleIconBgUnCheckedUnHoverNew");
		defaultInterpolatedStringHandler.AppendFormatted<int>(qualityId);
		string resourcePath = instance.GetResourcePath(defaultInterpolatedStringHandler.ToStringAndClear());
		this.SetSpriteByPath(resourcePath, sprite3, false, null, null);
		UiResourceConfig instance2 = UiResourceConfig.Instance;
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 1);
		defaultInterpolatedStringHandler.AppendLiteral("SP_RoleIconBgUnCheckedHoverNew");
		defaultInterpolatedStringHandler.AppendFormatted<int>(qualityId);
		string resourcePath2 = instance2.GetResourcePath(defaultInterpolatedStringHandler.ToStringAndClear());
		this.SetSpriteByPath(resourcePath2, sprite2, false, null, null);
		UiResourceConfig instance3 = UiResourceConfig.Instance;
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 1);
		defaultInterpolatedStringHandler.AppendLiteral("SP_RoleIconBgCheckedNew");
		defaultInterpolatedStringHandler.AppendFormatted<int>(qualityId);
		string resourcePath3 = instance3.GetResourcePath(defaultInterpolatedStringHandler.ToStringAndClear());
		this.SetSpriteByPath(resourcePath3, sprite, false, null, null);
	}

	// Token: 0x0400A08F RID: 41103
	private int QualityId;

	// Token: 0x0400A090 RID: 41104
	[Nullable(2)]
	private UiSequencePlayer SequencePlayer;

	// Token: 0x02008059 RID: 32857
	private enum ERoleIconDefine
	{
		// Token: 0x0402986D RID: 170093
		RoleIcon,
		// Token: 0x0402986E RID: 170094
		SpriteSelect,
		// Token: 0x0402986F RID: 170095
		SpriteHover,
		// Token: 0x04029870 RID: 170096
		SpriteNormal
	}
}
