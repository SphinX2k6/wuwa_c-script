using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020016D5 RID: 5845
public class AdviceItem : UiPanelBase
{
	// Token: 0x0600A74C RID: 42828 RVA: 0x002585AC File Offset: 0x002567AC
	[NullableContext(1)]
	public AdviceItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600A74D RID: 42829 RVA: 0x002585C4 File Offset: 0x002567C4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUITexture)),
			new ValueTuple<int, Type>(5, typeof(UUISprite))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickDeleteBtn))
		};
	}

	// Token: 0x0600A74E RID: 42830 RVA: 0x00258683 File Offset: 0x00256883
	protected override void OnStart()
	{
		EventSystem.Instance.Add(EEventName.OnModifyAdviceSuccess, new Action<long>(this.OnOnModifyAdviceSuccess));
	}

	// Token: 0x0600A74F RID: 42831 RVA: 0x002586A1 File Offset: 0x002568A1
	private void OnOnModifyAdviceSuccess(long modifyId)
	{
		if (this.AdviceDataInstance != null && modifyId == this.AdviceDataInstance.GetAdviceId())
		{
			this.RefreshView();
		}
	}

	// Token: 0x0600A750 RID: 42832 RVA: 0x002586C0 File Offset: 0x002568C0
	private void OnClickDeleteBtn()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.AdviceDeleteTips);
		confirmBoxDataNew.FunctionMap[2] = delegate()
		{
			AdviceController.Instance.RequestDeleteAdvice(this.AdviceDataInstance.GetAdviceId());
		};
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x0600A751 RID: 42833 RVA: 0x002586F9 File Offset: 0x002568F9
	[NullableContext(1)]
	public void Update(AdviceData adviceData)
	{
		this.AdviceDataInstance = adviceData;
		this.RefreshView();
	}

	// Token: 0x0600A752 RID: 42834 RVA: 0x00258708 File Offset: 0x00256908
	private void RefreshView()
	{
		this.RefreshText();
		this.RefreshEmojiTexture();
		this.RefreshLikeNum();
		this.RefreshLocationText();
	}

	// Token: 0x0600A753 RID: 42835 RVA: 0x00258722 File Offset: 0x00256922
	private void RefreshText()
	{
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		text.SetText(this.AdviceDataInstance.GetAdviceShowText(), true);
	}

	// Token: 0x0600A754 RID: 42836 RVA: 0x00258744 File Offset: 0x00256944
	private void RefreshEmojiTexture()
	{
		bool flag = this.AdviceDataInstance.GetAdviceExpressionId() > 0;
		if (flag)
		{
			ChatExpression? expressionConfig = ChatConfig.Instance.GetExpressionConfig(this.AdviceDataInstance.GetAdviceExpressionId());
			if (expressionConfig != null)
			{
				base.SetTextureByPath(expressionConfig.Value.ExpressionTexturePath, base.GetTexture(4), null, null);
			}
		}
		UUISprite sprite = base.GetSprite(5);
		if (sprite != null)
		{
			sprite.SetUIActive(!flag);
		}
		UUITexture texture = base.GetTexture(4);
		if (texture == null)
		{
			return;
		}
		texture.SetUIActive(flag);
	}

	// Token: 0x0600A755 RID: 42837 RVA: 0x002587D0 File Offset: 0x002569D0
	private void RefreshLikeNum()
	{
		long vote = this.AdviceDataInstance.GetVote();
		UUIText text = base.GetText(2);
		if (text == null)
		{
			return;
		}
		text.SetText(vote.ToString(), true);
	}

	// Token: 0x0600A756 RID: 42838 RVA: 0x00258804 File Offset: 0x00256A04
	private void RefreshLocationText()
	{
		int areaId = this.AdviceDataInstance.GetAreaId();
		Area? areaInfo = AreaConfig.Instance.GetAreaInfo(areaId);
		if (areaInfo != null)
		{
			string areaLocalName = AreaConfig.Instance.GetAreaLocalName(areaInfo.Value.Title);
			UUIText text = base.GetText(3);
			if (text == null)
			{
				return;
			}
			text.SetText(areaLocalName, true);
		}
	}

	// Token: 0x0600A757 RID: 42839 RVA: 0x0025885F File Offset: 0x00256A5F
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnModifyAdviceSuccess, new Action<long>(this.OnOnModifyAdviceSuccess));
	}

	// Token: 0x04004B83 RID: 19331
	[Nullable(2)]
	private AdviceData AdviceDataInstance;

	// Token: 0x02007CA9 RID: 31913
	private static class EChildType
	{
		// Token: 0x04028E40 RID: 167488
		public const int DeleteBtn = 0;

		// Token: 0x04028E41 RID: 167489
		public const int DescText = 1;

		// Token: 0x04028E42 RID: 167490
		public const int LikeNumText = 2;

		// Token: 0x04028E43 RID: 167491
		public const int LocationText = 3;

		// Token: 0x04028E44 RID: 167492
		public const int EmojiTexture = 4;

		// Token: 0x04028E45 RID: 167493
		public const int DefaultSprite = 5;
	}
}
