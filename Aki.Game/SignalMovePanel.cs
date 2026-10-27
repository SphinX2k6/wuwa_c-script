using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002A14 RID: 10772
[NullableContext(2)]
[Nullable(0)]
public class SignalMovePanel : UiComponentAction
{
	// Token: 0x060165C3 RID: 91587 RVA: 0x005A8C70 File Offset: 0x005A6E70
	[NullableContext(1)]
	public UniTask Init(UUIItem uiItem, ESignalGameplayType gameplayType)
	{
		SignalMovePanel.<Init>d__8 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.uiItem = uiItem;
		<Init>d__.gameplayType = gameplayType;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<SignalMovePanel.<Init>d__8>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x060165C4 RID: 91588 RVA: 0x005A8CC4 File Offset: 0x005A6EC4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIHorizontalLayout))
		};
	}

	// Token: 0x060165C5 RID: 91589 RVA: 0x005A8D4C File Offset: 0x005A6F4C
	protected override void OnStart()
	{
		this.LongNode = base.GetItem(0);
		this.ShortNode = base.GetItem(1);
		this.LineNode = base.GetItem(2);
		this.ShortLineNode = base.GetItem(3);
		this.MoveNode = base.GetHorizontalLayout(4);
		this.MoveNode.SetEnable(false);
		this.MoveNode.SetAlign(ELGUILayoutAlignmentType.MiddleLeft);
		this.CreateSignals();
		this.LongNode.SetUIActive(false);
		this.LineNode.SetUIActive(false);
		this.ShortNode.SetUIActive(false);
		this.ShortLineNode.SetUIActive(false);
	}

	// Token: 0x060165C6 RID: 91590 RVA: 0x005A8DE8 File Offset: 0x005A6FE8
	private void CreateSignals()
	{
		SignalDecodeModel instance = SignalDecodeModel.Instance;
		string currentMorseCode = instance.CurrentMorseCode;
		this.Speed = instance.Speed;
		int startDecisionSize = instance.StartDecisionSize;
		int endDecisionSize = instance.EndDecisionSize;
		bool flag = instance.CurrentGameplayType == ESignalGameplayType.DrawSword;
		List<SignalItemBase> list = new List<SignalItemBase>();
		float rootHalfWidth = this.RootItem.GetWidth() / 2f;
		float num = 0f;
		for (int i = 0; i < currentMorseCode.Length; i++)
		{
			char c = currentMorseCode[i];
			int num2 = (int)char.GetNumericValue(c);
			if (c < '0' || c > '9')
			{
				num2 = 0;
			}
			if (i != currentMorseCode.Length - 1 && num2 != 0)
			{
				UUIItem uiItem = LguiUtil.Instance.CopyItem(this.LineNode, this.MoveNode.RootUIComp.Get());
				SignalLineItem signalLineItem = new SignalLineItem(ESignalType.Line, rootHalfWidth, startDecisionSize, endDecisionSize);
				signalLineItem.Init(uiItem, num);
				list.Add(signalLineItem);
				num -= signalLineItem.Width;
			}
			SignalItemBase signalItemBase;
			if (num2 != 1)
			{
				if (num2 != 2)
				{
					UUIItem uiItem2 = LguiUtil.Instance.CopyItem(this.LineNode, this.MoveNode.RootUIComp.Get());
					signalItemBase = new SignalLineItem(ESignalType.Line, rootHalfWidth, startDecisionSize, endDecisionSize);
					((SignalLineItem)signalItemBase).Init(uiItem2, num);
				}
				else
				{
					UUIItem uiItem3 = LguiUtil.Instance.CopyItem(this.LongNode, this.MoveNode.RootUIComp.Get());
					signalItemBase = new SignalItem(ESignalType.Long, rootHalfWidth, startDecisionSize, endDecisionSize);
					((SignalItem)signalItemBase).Init(uiItem3, num);
				}
			}
			else
			{
				UUIItem uiItem4 = LguiUtil.Instance.CopyItem(this.ShortNode, this.MoveNode.RootUIComp.Get());
				signalItemBase = new SignalItem(ESignalType.Short, rootHalfWidth, startDecisionSize, endDecisionSize);
				((SignalItem)signalItemBase).Init(uiItem4, num);
			}
			if (num2 == 0 && flag)
			{
				((SignalLineItem)signalItemBase).AddWidth(this.ShortLineNode.GetWidth());
			}
			num -= signalItemBase.Width;
			list.Add(signalItemBase);
		}
		this.Signals = list.ToArray();
	}

	// Token: 0x060165C7 RID: 91591 RVA: 0x005A900C File Offset: 0x005A720C
	public void InitByGameplayType(ESignalGameplayType type)
	{
		if (this.Signals == null)
		{
			return;
		}
		SignalItemBase[] signals = this.Signals;
		for (int i = 0; i < signals.Length; i++)
		{
			signals[i].InitByGameplayType(type);
		}
	}

	// Token: 0x060165C8 RID: 91592 RVA: 0x005A9040 File Offset: 0x005A7240
	public void InitMoveNode()
	{
		this.MoveNode.RootUIComp.Get().SetAnchorOffsetX(-1280f);
	}

	// Token: 0x060165C9 RID: 91593 RVA: 0x005A906C File Offset: 0x005A726C
	public void StartAgain()
	{
		if (this.Signals == null)
		{
			return;
		}
		SignalItemBase[] signals = this.Signals;
		for (int i = 0; i < signals.Length; i++)
		{
			signals[i].Reset();
		}
	}

	// Token: 0x060165CA RID: 91594 RVA: 0x005A909F File Offset: 0x005A729F
	public void UpdateMove(float delta)
	{
		this.UpdatePanelMove(delta);
		this.UpdateSignals();
	}

	// Token: 0x060165CB RID: 91595 RVA: 0x005A90B0 File Offset: 0x005A72B0
	public float GetCompleteness()
	{
		float num = 0f;
		float num2 = 0f;
		SignalItemBase[] signals = this.Signals;
		for (int i = 0; i < signals.Length; i++)
		{
			SignalItem signalItem = signals[i] as SignalItem;
			if (signalItem != null)
			{
				num2 += signalItem.GetCompleteness();
				num += 1f;
			}
		}
		if (num == 0f)
		{
			return 1f;
		}
		return num2 / num;
	}

	// Token: 0x060165CC RID: 91596 RVA: 0x005A9110 File Offset: 0x005A7310
	public float GetProgress()
	{
		float num = 0f;
		float num2 = 0f;
		foreach (SignalItemBase signalItemBase in this.Signals)
		{
			num2 += signalItemBase.GetProgress();
			num += 1f;
		}
		if (num == 0f)
		{
			return 1f;
		}
		return num2 / num;
	}

	// Token: 0x060165CD RID: 91597 RVA: 0x005A9168 File Offset: 0x005A7368
	private void UpdatePanelMove(float delta)
	{
		float anchorOffsetX = this.MoveNode.RootUIComp.Get().GetAnchorOffsetX() + delta / 1000f * this.Speed;
		this.MoveNode.RootUIComp.Get().SetAnchorOffsetX(anchorOffsetX);
	}

	// Token: 0x060165CE RID: 91598 RVA: 0x005A91B8 File Offset: 0x005A73B8
	private void UpdateSignals()
	{
		float anchorOffsetX = this.MoveNode.RootUIComp.Get().GetAnchorOffsetX();
		foreach (SignalItemBase signalItemBase in this.Signals)
		{
			float relativeX = anchorOffsetX + signalItemBase.GetRootItem().GetAnchorOffsetX();
			signalItemBase.Update(relativeX);
		}
	}

	// Token: 0x060165CF RID: 91599 RVA: 0x005A9214 File Offset: 0x005A7414
	public void OnCatchBtnDown()
	{
		SignalItemBase[] signals = this.Signals;
		for (int i = 0; i < signals.Length; i++)
		{
			signals[i].OnCatchBtnDown();
		}
	}

	// Token: 0x060165D0 RID: 91600 RVA: 0x005A9240 File Offset: 0x005A7440
	public void OnCatchBtnUp()
	{
		SignalItemBase[] signals = this.Signals;
		for (int i = 0; i < signals.Length; i++)
		{
			signals[i].OnCatchBtnUp();
		}
	}

	// Token: 0x0400A66F RID: 42607
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private SignalItemBase[] Signals;

	// Token: 0x0400A670 RID: 42608
	private UUIItem LongNode;

	// Token: 0x0400A671 RID: 42609
	private UUIItem ShortNode;

	// Token: 0x0400A672 RID: 42610
	private UUIItem LineNode;

	// Token: 0x0400A673 RID: 42611
	private UUIItem ShortLineNode;

	// Token: 0x0400A674 RID: 42612
	private UUIHorizontalLayout MoveNode;

	// Token: 0x0400A675 RID: 42613
	private float Speed;

	// Token: 0x02009053 RID: 36947
	[NullableContext(0)]
	private static class EChildComponent
	{
		// Token: 0x0402EBB9 RID: 191417
		public const int LongNode = 0;

		// Token: 0x0402EBBA RID: 191418
		public const int ShortNode = 1;

		// Token: 0x0402EBBB RID: 191419
		public const int LineNode = 2;

		// Token: 0x0402EBBC RID: 191420
		public const int ShortLineNode = 3;

		// Token: 0x0402EBBD RID: 191421
		public const int MoveNode = 4;
	}
}
