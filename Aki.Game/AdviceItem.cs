using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000B8D RID: 2957
public class AdviceItem : UiPanelBase
{
	// Token: 0x06007B2C RID: 31532 RVA: 0x002629B8 File Offset: 0x00260BB8
	[NullableContext(1)]
	public AdviceItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06007B2D RID: 31533 RVA: 0x002629D0 File Offset: 0x00260BD0
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

	// Token: 0x06007B2E RID: 31534 RVA: 0x00262A8F File Offset: 0x00260C8F
	protected override void OnStart()
	{
		EventSystem.Instance.Add(EEventName.OnModifyAdviceSuccess, new Action<long>(this.OnOnModifyAdviceSuccess));
	}

	// Token: 0x06007B2F RID: 31535 RVA: 0x00262AAD File Offset: 0x00260CAD
	private void OnOnModifyAdviceSuccess(long modifyId)
	{
		if (this.AdviceDataInstance != null && modifyId == this.AdviceDataInstance.GetAdviceId())
		{
			this.RefreshView();
		}
	}

	// Token: 0x06007B30 RID: 31536 RVA: 0x00262ACC File Offset: 0x00260CCC
	private void OnClickDeleteBtn()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.AdviceDeleteTips);
		confirmBoxDataNew.FunctionMap[2] = delegate()
		{
			AdviceController.Instance.RequestDeleteAdvice(this.AdviceDataInstance.GetAdviceId());
		};
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06007B31 RID: 31537 RVA: 0x00262B05 File Offset: 0x00260D05
	[NullableContext(1)]
	public void Update(AdviceData adviceData)
	{
		this.AdviceDataInstance = adviceData;
		this.RefreshView();
	}

	// Token: 0x06007B32 RID: 31538 RVA: 0x00262B14 File Offset: 0x00260D14
	private void RefreshView()
	{
		this.RefreshText();
		this.RefreshEmojiTexture();
		this.RefreshLikeNum();
		this.RefreshLocationText();
	}

	// Token: 0x06007B33 RID: 31539 RVA: 0x00262B2E File Offset: 0x00260D2E
	private void RefreshText()
	{
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		text.SetText(this.AdviceDataInstance.GetAdviceShowText(), true);
	}

	// Token: 0x06007B34 RID: 31540 RVA: 0x00262B50 File Offset: 0x00260D50
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

	// Token: 0x06007B35 RID: 31541 RVA: 0x00262BDC File Offset: 0x00260DDC
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

	// Token: 0x06007B36 RID: 31542 RVA: 0x00262C10 File Offset: 0x00260E10
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

	// Token: 0x06007B37 RID: 31543 RVA: 0x00262C6B File Offset: 0x00260E6B
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnModifyAdviceSuccess, new Action<long>(this.OnOnModifyAdviceSuccess));
	}

	// Token: 0x04004C2A RID: 19498
	[Nullable(2)]
	private AdviceData AdviceDataInstance;

	// Token: 0x02006E2E RID: 28206
	private static class EChildType
	{
		// Token: 0x04024169 RID: 147817
		public const int DeleteBtn = 0;

		// Token: 0x0402416A RID: 147818
		public const int DescText = 1;

		// Token: 0x0402416B RID: 147819
		public const int LikeNumText = 2;

		// Token: 0x0402416C RID: 147820
		public const int LocationText = 3;

		// Token: 0x0402416D RID: 147821
		public const int EmojiTexture = 4;

		// Token: 0x0402416E RID: 147822
		public const int DefaultSprite = 5;
	}
}
