using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F8F RID: 8079
[NullableContext(2)]
[Nullable(0)]
public class SignalMovePanel : UiComponentAction
{
	// Token: 0x06013FCA RID: 81866 RVA: 0x005D3C48 File Offset: 0x005D1E48
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

	// Token: 0x06013FCB RID: 81867 RVA: 0x005D3C9C File Offset: 0x005D1E9C
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

	// Token: 0x06013FCC RID: 81868 RVA: 0x005D3D24 File Offset: 0x005D1F24
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

	// Token: 0x06013FCD RID: 81869 RVA: 0x005D3DC0 File Offset: 0x005D1FC0
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

	// Token: 0x06013FCE RID: 81870 RVA: 0x005D3FE4 File Offset: 0x005D21E4
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

	// Token: 0x06013FCF RID: 81871 RVA: 0x005D4018 File Offset: 0x005D2218
	public void InitMoveNode()
	{
		this.MoveNode.RootUIComp.Get().SetAnchorOffsetX(-1280f);
	}

	// Token: 0x06013FD0 RID: 81872 RVA: 0x005D4044 File Offset: 0x005D2244
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

	// Token: 0x06013FD1 RID: 81873 RVA: 0x005D4077 File Offset: 0x005D2277
	public void UpdateMove(float delta)
	{
		this.UpdatePanelMove(delta);
		this.UpdateSignals();
	}

	// Token: 0x06013FD2 RID: 81874 RVA: 0x005D4088 File Offset: 0x005D2288
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

	// Token: 0x06013FD3 RID: 81875 RVA: 0x005D40E8 File Offset: 0x005D22E8
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

	// Token: 0x06013FD4 RID: 81876 RVA: 0x005D4140 File Offset: 0x005D2340
	private void UpdatePanelMove(float delta)
	{
		float anchorOffsetX = this.MoveNode.RootUIComp.Get().GetAnchorOffsetX() + delta / 1000f * this.Speed;
		this.MoveNode.RootUIComp.Get().SetAnchorOffsetX(anchorOffsetX);
	}

	// Token: 0x06013FD5 RID: 81877 RVA: 0x005D4190 File Offset: 0x005D2390
	private void UpdateSignals()
	{
		float anchorOffsetX = this.MoveNode.RootUIComp.Get().GetAnchorOffsetX();
		foreach (SignalItemBase signalItemBase in this.Signals)
		{
			float relativeX = anchorOffsetX + signalItemBase.GetRootItem().GetAnchorOffsetX();
			signalItemBase.Update(relativeX);
		}
	}

	// Token: 0x06013FD6 RID: 81878 RVA: 0x005D41EC File Offset: 0x005D23EC
	public void OnCatchBtnDown()
	{
		SignalItemBase[] signals = this.Signals;
		for (int i = 0; i < signals.Length; i++)
		{
			signals[i].OnCatchBtnDown();
		}
	}

	// Token: 0x06013FD7 RID: 81879 RVA: 0x005D4218 File Offset: 0x005D2418
	public void OnCatchBtnUp()
	{
		SignalItemBase[] signals = this.Signals;
		for (int i = 0; i < signals.Length; i++)
		{
			signals[i].OnCatchBtnUp();
		}
	}

	// Token: 0x0400AA59 RID: 43609
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private SignalItemBase[] Signals;

	// Token: 0x0400AA5A RID: 43610
	private UUIItem LongNode;

	// Token: 0x0400AA5B RID: 43611
	private UUIItem ShortNode;

	// Token: 0x0400AA5C RID: 43612
	private UUIItem LineNode;

	// Token: 0x0400AA5D RID: 43613
	private UUIItem ShortLineNode;

	// Token: 0x0400AA5E RID: 43614
	private UUIHorizontalLayout MoveNode;

	// Token: 0x0400AA5F RID: 43615
	private float Speed;

	// Token: 0x0200829A RID: 33434
	[NullableContext(0)]
	private static class EChildComponent
	{
		// Token: 0x0402A2B1 RID: 172721
		public const int LongNode = 0;

		// Token: 0x0402A2B2 RID: 172722
		public const int ShortNode = 1;

		// Token: 0x0402A2B3 RID: 172723
		public const int LineNode = 2;

		// Token: 0x0402A2B4 RID: 172724
		public const int ShortLineNode = 3;

		// Token: 0x0402A2B5 RID: 172725
		public const int MoveNode = 4;
	}
}
