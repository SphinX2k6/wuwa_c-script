using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001DDC RID: 7644
[NullableContext(1)]
[Nullable(0)]
public class RoleFavorHintItem : UiPanelBase
{
	// Token: 0x06012E9D RID: 77469 RVA: 0x0058AEC5 File Offset: 0x005890C5
	public RoleFavorHintItem(RoleFavorHintData roleFavorHintData, UUIItem uiItem)
	{
		this.RoleFavorHintData = roleFavorHintData;
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06012E9E RID: 77470 RVA: 0x0058AEE4 File Offset: 0x005890E4
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

	// Token: 0x06012E9F RID: 77471 RVA: 0x0058AF54 File Offset: 0x00589154
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

	// Token: 0x06012EA0 RID: 77472 RVA: 0x0058B004 File Offset: 0x00589204
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

	// Token: 0x06012EA1 RID: 77473 RVA: 0x0058B041 File Offset: 0x00589241
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

	// Token: 0x06012EA2 RID: 77474 RVA: 0x0058B064 File Offset: 0x00589264
	protected void PlayStart()
	{
		this.LevelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
	}

	// Token: 0x06012EA3 RID: 77475 RVA: 0x0058B08C File Offset: 0x0058928C
	protected void PlayHalfway()
	{
		this.LevelSequencePlayer.PlayLevelSequenceByName("Move", false, null, false);
	}

	// Token: 0x06012EA4 RID: 77476 RVA: 0x0058B0B4 File Offset: 0x005892B4
	public void PlayEnd()
	{
		this.LevelSequencePlayer.PlayLevelSequenceByName("Close", false, null, false);
	}

	// Token: 0x06012EA5 RID: 77477 RVA: 0x0058B0DC File Offset: 0x005892DC
	public void OnSequenceFinish()
	{
		TOnSequenceFinishCallBack onSequenceFinishCallBack = this.OnSequenceFinishCallBack;
		if (onSequenceFinishCallBack == null)
		{
			return;
		}
		onSequenceFinishCallBack();
	}

	// Token: 0x06012EA6 RID: 77478 RVA: 0x0058B0EE File Offset: 0x005892EE
	public void SetSequenceFinishCallBack(TOnSequenceFinishCallBack onSequenceFinishCallBack)
	{
		this.OnSequenceFinishCallBack = onSequenceFinishCallBack;
	}

	// Token: 0x0400A2ED RID: 41709
	[Nullable(2)]
	private TOnSequenceFinishCallBack OnSequenceFinishCallBack;

	// Token: 0x0400A2EE RID: 41710
	[Nullable(2)]
	private RoleFavorHintData RoleFavorHintData;

	// Token: 0x0400A2EF RID: 41711
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x020080CC RID: 32972
	[NullableContext(0)]
	private enum ERoleFavorHintItemCom
	{
		// Token: 0x04029A93 RID: 170643
		ItemIcon,
		// Token: 0x04029A94 RID: 170644
		ItemNameText,
		// Token: 0x04029A95 RID: 170645
		ItemCountText,
		// Token: 0x04029A96 RID: 170646
		ItemXText
	}
}
