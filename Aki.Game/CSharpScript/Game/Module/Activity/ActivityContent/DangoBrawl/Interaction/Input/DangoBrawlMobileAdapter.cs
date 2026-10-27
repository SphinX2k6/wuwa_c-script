using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Input
{
	// Token: 0x0200687F RID: 26751
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlMobileAdapter : IDangobrawlInputAdapter
	{
		// Token: 0x170097B3 RID: 38835
		// (get) Token: 0x06042CA5 RID: 273573 RVA: 0x010417D2 File Offset: 0x0103F9D2
		public EInputPlatform Platform
		{
			get
			{
				return EInputPlatform.Mobile;
			}
		}

		// Token: 0x06042CA6 RID: 273574 RVA: 0x010417D5 File Offset: 0x0103F9D5
		public DangoBrawlMobileAdapter(DangoBrawlDragCtrl dragCtrl)
		{
			this.DragCtrl = dragCtrl;
		}

		// Token: 0x06042CA7 RID: 273575 RVA: 0x010417E4 File Offset: 0x0103F9E4
		public void Start()
		{
			InputDistributeController.Instance.BindTouch(1, new TInputHandle<InputDistributeDefine.ITouchData>(this.OnSecondFingerTouch));
		}

		// Token: 0x06042CA8 RID: 273576 RVA: 0x010417FD File Offset: 0x0103F9FD
		public void Stop()
		{
			InputDistributeController.Instance.UnBindTouch(1, new TInputHandle<InputDistributeDefine.ITouchData>(this.OnSecondFingerTouch));
		}

		// Token: 0x06042CA9 RID: 273577 RVA: 0x01041818 File Offset: 0x0103FA18
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

		// Token: 0x06042CAA RID: 273578 RVA: 0x010418F6 File Offset: 0x0103FAF6
		public void OnTick(float delta)
		{
		}

		// Token: 0x06042CAB RID: 273579 RVA: 0x010418F8 File Offset: 0x0103FAF8
		public UniTask OnPointerClick(EDragSourceKind source, IDangoBrawlDraggableView view, FVector pointerPos)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06042CAC RID: 273580 RVA: 0x010418FF File Offset: 0x0103FAFF
		public UniTask OnPointerBeginDrag(EDragSourceKind source, IDangoBrawlDraggableView view, FVector pointerPos)
		{
			return this.DragCtrl.BeginDrag(source, view, pointerPos);
		}

		// Token: 0x06042CAD RID: 273581 RVA: 0x0104190F File Offset: 0x0103FB0F
		public void OnPointerDrag(FVector pointerPos)
		{
			this.DragCtrl.UpdateDrag(pointerPos);
		}

		// Token: 0x06042CAE RID: 273582 RVA: 0x0104191D File Offset: 0x0103FB1D
		public UniTask OnPointerEndDrag(FVector pointerPos)
		{
			return this.DragCtrl.EndDrag(pointerPos);
		}

		// Token: 0x04022C2C RID: 142380
		private readonly DangoBrawlDragCtrl DragCtrl;
	}
}
