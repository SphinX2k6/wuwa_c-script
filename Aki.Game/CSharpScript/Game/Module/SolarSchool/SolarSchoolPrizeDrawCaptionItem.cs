using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x0200592B RID: 22827
	[NullableContext(2)]
	[Nullable(0)]
	public class SolarSchoolPrizeDrawCaptionItem : UiPanelBase
	{
		// Token: 0x06038401 RID: 230401 RVA: 0x00FBA638 File Offset: 0x00FB8838
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnBtnCloseClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038402 RID: 230402 RVA: 0x00FBA700 File Offset: 0x00FB8900
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolPrizeDrawCaptionItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolPrizeDrawCaptionItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038403 RID: 230403 RVA: 0x00FBA743 File Offset: 0x00FB8943
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x06038404 RID: 230404 RVA: 0x00FBA756 File Offset: 0x00FB8956
		protected override void OnBeforeShow()
		{
			this.PlayStart(false);
		}

		// Token: 0x06038405 RID: 230405 RVA: 0x00FBA75F File Offset: 0x00FB895F
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
			this.CloseCallback = null;
			this.TipCost = null;
		}

		// Token: 0x06038406 RID: 230406 RVA: 0x00FBA787 File Offset: 0x00FB8987
		[NullableContext(1)]
		public void SetCloseCallBack(Action callback)
		{
			this.CloseCallback = callback;
		}

		// Token: 0x06038407 RID: 230407 RVA: 0x00FBA790 File Offset: 0x00FB8990
		public void SetHelpGroupId(int helpGroupId)
		{
			UUIItem item = base.GetItem(0);
			bool flag = helpGroupId != 0;
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			if (!flag)
			{
				return;
			}
			object obj;
			if (item == null)
			{
				obj = null;
			}
			else
			{
				AActor owner = item.GetOwner();
				obj = ((owner != null) ? owner.GetComponentByClass(UUIExtendButtonComponent.StaticClass()) : null);
			}
			UUIExtendButtonComponent uuiextendButtonComponent = obj as UUIExtendButtonComponent;
			if (uuiextendButtonComponent != null)
			{
				uuiextendButtonComponent.HelpGroupId = helpGroupId;
			}
		}

		// Token: 0x06038408 RID: 230408 RVA: 0x00FBA7EC File Offset: 0x00FB89EC
		public void PlayStart(bool blockClick = false)
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlaySequencePurely("Start", blockClick, false, null, null, false);
		}

		// Token: 0x06038409 RID: 230409 RVA: 0x00FBA81C File Offset: 0x00FB8A1C
		public void PlayClose(bool blockClick = false)
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlaySequencePurely("Close", blockClick, false, null, null, false);
		}

		// Token: 0x0603840A RID: 230410 RVA: 0x00FBA84B File Offset: 0x00FB8A4B
		private void OnBtnCloseClick()
		{
			Action closeCallback = this.CloseCallback;
			if (closeCallback == null)
			{
				return;
			}
			closeCallback();
		}

		// Token: 0x0401DA07 RID: 121351
		[Nullable(1)]
		public const string ResourceId = "UiItem_SolarSchoolCaptionC";

		// Token: 0x0401DA08 RID: 121352
		private SolarSchoolPrizeDrawTipCostItem TipCost;

		// Token: 0x0401DA09 RID: 121353
		private Action CloseCallback;

		// Token: 0x0401DA0A RID: 121354
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x0200B4E7 RID: 46311
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x04037EF2 RID: 229106
			BtnHelpInfo,
			// Token: 0x04037EF3 RID: 229107
			BtnSolarSchoolTipCost,
			// Token: 0x04037EF4 RID: 229108
			BtnSolarSchoolBack
		}
	}
}
