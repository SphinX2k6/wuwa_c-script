using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002861 RID: 10337
[NullableContext(1)]
[Nullable(0)]
public class RoleFavorHintItem : UiPanelBase
{
	// Token: 0x0601549F RID: 87199 RVA: 0x00560169 File Offset: 0x0055E369
	public RoleFavorHintItem(RoleFavorHintData roleFavorHintData, UUIItem uiItem)
	{
		this.RoleFavorHintData = roleFavorHintData;
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x060154A0 RID: 87200 RVA: 0x00560188 File Offset: 0x0055E388
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x060154A1 RID: 87201 RVA: 0x005601F8 File Offset: 0x0055E3F8
	protected override void OnStart()
	{
		if (this.RoleFavorHintData == null)
		{
			return;
		}
		int exp = this.RoleFavorHintData.Exp;
		string resourcePath = UiResourceConfig.Instance.GetResourcePath("T_IconA80_hgd_UI");
		base.SetTextureByPath(resourcePath, base.GetTexture(0), null, null);
		UUIText text = base.GetText(1);
		LguiUtil.Instance.SetLocalText(text, "FavorExp", Array.Empty<object>());
		UUIText text2 = base.GetText(2);
		if (text2 != null)
		{
			text2.SetText(exp.ToString(), true);
		}
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.SequenceFinish), false);
		this.PlayStart();
	}

	// Token: 0x060154A2 RID: 87202 RVA: 0x005602A8 File Offset: 0x0055E4A8
	private void SequenceFinish(string name)
	{
		if (name == "Start")
		{
			this.PlayHalfway();
			return;
		}
		if (name == "Move")
		{
			this.PlayEnd();
			return;
		}
		if (name == "Close")
		{
			this.OnSequenceFinish();
		}
	}

	// Token: 0x060154A3 RID: 87203 RVA: 0x005602E5 File Offset: 0x0055E4E5
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.Clear();
		}
		this.OnSequenceFinishCallBack = null;
		this.RoleFavorHintData = null;
	}

	// Token: 0x060154A4 RID: 87204 RVA: 0x00560308 File Offset: 0x0055E508
	protected void PlayStart()
	{
		this.LevelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
	}

	// Token: 0x060154A5 RID: 87205 RVA: 0x00560330 File Offset: 0x0055E530
	protected void PlayHalfway()
	{
		this.LevelSequencePlayer.PlayLevelSequenceByName("Move", false, null, false);
	}

	// Token: 0x060154A6 RID: 87206 RVA: 0x00560358 File Offset: 0x0055E558
	public void PlayEnd()
	{
		this.LevelSequencePlayer.PlayLevelSequenceByName("Close", false, null, false);
	}

	// Token: 0x060154A7 RID: 87207 RVA: 0x00560380 File Offset: 0x0055E580
	public void OnSequenceFinish()
	{
		TOnSequenceFinishCallBack onSequenceFinishCallBack = this.OnSequenceFinishCallBack;
		if (onSequenceFinishCallBack == null)
		{
			return;
		}
		onSequenceFinishCallBack();
	}

	// Token: 0x060154A8 RID: 87208 RVA: 0x00560392 File Offset: 0x0055E592
	public void SetSequenceFinishCallBack(TOnSequenceFinishCallBack onSequenceFinishCallBack)
	{
		this.OnSequenceFinishCallBack = onSequenceFinishCallBack;
	}

	// Token: 0x04009F04 RID: 40708
	[Nullable(2)]
	private TOnSequenceFinishCallBack OnSequenceFinishCallBack;

	// Token: 0x04009F05 RID: 40709
	[Nullable(2)]
	private RoleFavorHintData RoleFavorHintData;

	// Token: 0x04009F06 RID: 40710
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x02008E86 RID: 36486
	[NullableContext(0)]
	private enum ERoleFavorHintItemCom
	{
		// Token: 0x0402E399 RID: 189337
		ItemIcon,
		// Token: 0x0402E39A RID: 189338
		ItemNameText,
		// Token: 0x0402E39B RID: 189339
		ItemCountText,
		// Token: 0x0402E39C RID: 189340
		ItemXText
	}
}
