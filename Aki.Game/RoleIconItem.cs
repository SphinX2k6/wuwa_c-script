using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200279E RID: 10142
public class RoleIconItem : UiPanelBase
{
	// Token: 0x06014D35 RID: 85301 RVA: 0x00548AA8 File Offset: 0x00546CA8
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

	// Token: 0x06014D36 RID: 85302 RVA: 0x00548B18 File Offset: 0x00546D18
	protected override void OnStart()
	{
		this.SequencePlayer = new UiSequencePlayer(this.RootItem);
	}

	// Token: 0x06014D37 RID: 85303 RVA: 0x00548B2C File Offset: 0x00546D2C
	[NullableContext(1)]
	public void Refresh(RoleDataBase roleInstance)
	{
		this.QualityId = roleInstance.GetRoleConfig().QualityId;
		base.SetRoleIconByRoleIdOrSkinId(roleInstance.GetRoleConfig().RoleHeadIconBig, base.GetTexture(0), roleInstance.GetRoleId(), new int?(roleInstance.GetRoleSkinId()), null, new EUiViewName?(EUiViewName.RoleRootView));
		this.RefreshQualitySprite(this.QualityId);
		this.PlaySequenceByQualityId(this.QualityId);
	}

	// Token: 0x06014D38 RID: 85304 RVA: 0x00548B9C File Offset: 0x00546D9C
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

	// Token: 0x06014D39 RID: 85305 RVA: 0x00548BD8 File Offset: 0x00546DD8
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

	// Token: 0x06014D3A RID: 85306 RVA: 0x00548C24 File Offset: 0x00546E24
	public void StopSelectSequence()
	{
		this.SequencePlayer.StopSequenceByKey("PurpleSelect".ToString(), false, false);
		this.SequencePlayer.StopSequenceByKey("YellowSelect".ToString(), false, false);
	}

	// Token: 0x06014D3B RID: 85307 RVA: 0x00548C54 File Offset: 0x00546E54
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

	// Token: 0x04009CC1 RID: 40129
	private int QualityId;

	// Token: 0x04009CC2 RID: 40130
	[Nullable(2)]
	private UiSequencePlayer SequencePlayer;

	// Token: 0x02008E14 RID: 36372
	private enum ERoleIconDefine
	{
		// Token: 0x0402E191 RID: 188817
		RoleIcon,
		// Token: 0x0402E192 RID: 188818
		SpriteSelect,
		// Token: 0x0402E193 RID: 188819
		SpriteHover,
		// Token: 0x0402E194 RID: 188820
		SpriteNormal
	}
}
