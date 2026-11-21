using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Input
{
	// Token: 0x020057CF RID: 22479
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlMobileAdapter : IDangobrawlInputAdapter
	{
		// Token: 0x17006AF3 RID: 27379
		// (get) Token: 0x060377FD RID: 227325 RVA: 0x00F82D4A File Offset: 0x00F80F4A
		public EInputPlatform Platform
		{
			get
			{
				return EInputPlatform.Mobile;
			}
		}

		// Token: 0x060377FE RID: 227326 RVA: 0x00F82D4D File Offset: 0x00F80F4D
		public DangoBrawlMobileAdapter(DangoBrawlDragCtrl dragCtrl)
		{
			this.DragCtrl = dragCtrl;
		}

		// Token: 0x060377FF RID: 227327 RVA: 0x00F82D5C File Offset: 0x00F80F5C
		public void Start()
		{
			InputDistributeController.Instance.BindTouch(1, new TInputHandle<InputDistributeDefine.ITouchData>(this.OnSecondFingerTouch));
		}

		// Token: 0x06037800 RID: 227328 RVA: 0x00F82D75 File Offset: 0x00F80F75
		public void Stop()
		{
			InputDistributeController.Instance.UnBindTouch(1, new TInputHandle<InputDistributeDefine.ITouchData>(this.OnSecondFingerTouch));
		}

		// Token: 0x06037801 RID: 227329 RVA: 0x00F82D90 File Offset: 0x00F80F90
		private void OnSecondFingerTouch(string _, InputDistributeDefine.ITouchData touchData, InputIdentification __)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.DangoBrawl;
			ELogAuthor author = ELogAuthor.LSH;
			string str = "charsiew : [旋转/Touch2] touchType=";
			string str2 = touchData.TouchType.ToString();
			string str3 = " draggingUid=";
			int? draggingUid = this.DragCtrl.DraggingUid;
			instance.Info(module, author, str + str2 + str3 + (((draggingUid != null) ? draggingUid.GetValueOrDefault().ToString() : null) ?? "null"), default(ReadOnlySpan<ValueTuple<string, object>>));
			if (touchData.TouchType != InputDistributeDefine.ETouchType.TouchBegin)
			{
				return;
			}
			draggingUid = this.DragCtrl.DraggingUid;
			if (draggingUid != null)
			{
				int valueOrDefault = draggingUid.GetValueOrDefault();
				Log.Instance.Info(ELogModule.DangoBrawl, ELogAuthor.LSH, "charsiew : [旋转/Touch2] 拖拽中第二指按下 → 旋转 uid=" + valueOrDefault.ToString(), default(ReadOnlySpan<ValueTuple<string, object>>));
				EventSystem.Instance.Emit<int>(EEventName.OnDangoBrawlRotateRequest, valueOrDefault);
			}
		}

		// Token: 0x06037802 RID: 227330 RVA: 0x00F82E6E File Offset: 0x00F8106E
		public void OnTick(float delta)
		{
		}

		// Token: 0x06037803 RID: 227331 RVA: 0x00F82E70 File Offset: 0x00F81070
		public UniTask OnPointerClick(EDragSourceKind source, IDangoBrawlDraggableView view, FVector pointerPos)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06037804 RID: 227332 RVA: 0x00F82E77 File Offset: 0x00F81077
		public UniTask OnPointerBeginDrag(EDragSourceKind source, IDangoBrawlDraggableView view, FVector pointerPos)
		{
			return this.DragCtrl.BeginDrag(source, view, pointerPos);
		}

		// Token: 0x06037805 RID: 227333 RVA: 0x00F82E87 File Offset: 0x00F81087
		public void OnPointerDrag(FVector pointerPos)
		{
			this.DragCtrl.UpdateDrag(pointerPos);
		}

		// Token: 0x06037806 RID: 227334 RVA: 0x00F82E95 File Offset: 0x00F81095
		public UniTask OnPointerEndDrag(FVector pointerPos)
		{
			return this.DragCtrl.EndDrag(pointerPos);
		}

		// Token: 0x0401D488 RID: 119944
		private readonly DangoBrawlDragCtrl DragCtrl;
	}
}
