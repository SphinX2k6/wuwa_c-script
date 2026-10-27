using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Skin.Tab.Motor
{
	// Token: 0x02004BF0 RID: 19440
	public class MotorSkinRecommendView : UiTabViewBase
	{
		// Token: 0x06032450 RID: 205904 RVA: 0x00BADF5F File Offset: 0x00BAC15F
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem))
			};
		}

		// Token: 0x06032451 RID: 205905 RVA: 0x00BADF84 File Offset: 0x00BAC184
		protected override UniTask OnBeforeStartAsync()
		{
			MotorSkinRecommendView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorSkinRecommendView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032452 RID: 205906 RVA: 0x00BADFC7 File Offset: 0x00BAC1C7
		protected override void AddEventListener()
		{
			EventSystem.Instance.Add<PayItemSuccess>(EEventName.OnPayItemSuccess, new Action<PayItemSuccess>(this.OnRefreshGoods));
		}

		// Token: 0x06032453 RID: 205907 RVA: 0x00BADFE5 File Offset: 0x00BAC1E5
		protected override void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnPayItemSuccess, new Action<PayItemSuccess>(this.OnRefreshGoods));
		}

		// Token: 0x06032454 RID: 205908 RVA: 0x00BAE003 File Offset: 0x00BAC203
		[NullableContext(1)]
		private void OnRefreshGoods(PayItemSuccess _)
		{
			this.RefreshView();
		}

		// Token: 0x06032455 RID: 205909 RVA: 0x00BAE00C File Offset: 0x00BAC20C
		protected override void OnBeforeShow()
		{
			this.RefreshView();
			UiTabSequence tabBehavior = base.GetTabBehavior<UiTabSequence>();
			((tabBehavior != null) ? tabBehavior.GetLevelSequencePlayer() : null).PlayLevelSequenceByName("Start", false, null, false);
		}

		// Token: 0x06032456 RID: 205910 RVA: 0x00BAE046 File Offset: 0x00BAC246
		private void RefreshView()
		{
			this.MotorSkinItemContent.Refresh(this.RecommendData.Id);
		}

		// Token: 0x0401ABD7 RID: 109527
		[Nullable(2)]
		private MotorSkinItemContent MotorSkinItemContent;

		// Token: 0x0401ABD8 RID: 109528
		[Nullable(2)]
		private PayShopRecommendData RecommendData;

		// Token: 0x0200ADE8 RID: 44520
		private enum EComponent
		{
			// Token: 0x04034D16 RID: 216342
			Content
		}
	}
}
