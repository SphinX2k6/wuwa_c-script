using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020055D1 RID: 21969
	[NullableContext(2)]
	[Nullable(0)]
	public class GridEventChoice : UiPanelBase, IEventStepItem
	{
		// Token: 0x170086FA RID: 34554
		// (get) Token: 0x06037FD1 RID: 229329 RVA: 0x00D43012 File Offset: 0x00D41212
		// (set) Token: 0x06037FD2 RID: 229330 RVA: 0x00D4301A File Offset: 0x00D4121A
		public Action<int, int> ExecuteStep { get; set; }

		// Token: 0x170086FB RID: 34555
		// (get) Token: 0x06037FD3 RID: 229331 RVA: 0x00D43023 File Offset: 0x00D41223
		public int StepId { get; }

		// Token: 0x170086FC RID: 34556
		// (get) Token: 0x06037FD4 RID: 229332 RVA: 0x00D4302B File Offset: 0x00D4122B
		public EStepType StepType { get; }

		// Token: 0x170086FD RID: 34557
		// (get) Token: 0x06037FD5 RID: 229333 RVA: 0x00D43033 File Offset: 0x00D41233
		// (set) Token: 0x06037FD6 RID: 229334 RVA: 0x00D4303B File Offset: 0x00D4123B
		public Action<int, EStepType> CanInteractCallback { get; set; }

		// Token: 0x06037FD7 RID: 229335 RVA: 0x00D43044 File Offset: 0x00D41244
		public GridEventChoice(int stepId, EStepType stepType = EStepType.Choose)
		{
			this.StepId = stepId;
			this.StepType = stepType;
		}

		// Token: 0x06037FD8 RID: 229336 RVA: 0x00D43068 File Offset: 0x00D41268
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUISprite)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUIVerticalLayout)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem))
			};
		}

		// Token: 0x06037FD9 RID: 229337 RVA: 0x00D43130 File Offset: 0x00D41330
		protected override UniTask OnBeforeStartAsync()
		{
			GridEventChoice.<OnBeforeStartAsync>d__20 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<GridEventChoice.<OnBeforeStartAsync>d__20>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037FDA RID: 229338 RVA: 0x00D43173 File Offset: 0x00D41373
		protected override void OnStart()
		{
			this.ToggleLayout = new GenericLayout<GridEventChoiceToggle, IToggleItemData>(base.GetVerticalLayout(5), new Func<GridEventChoiceToggle>(this.OnCreateToggleItem), null, false, true);
		}

		// Token: 0x06037FDB RID: 229339 RVA: 0x00D43198 File Offset: 0x00D41398
		[NullableContext(1)]
		public UniTask Refresh(IList<EventOption> options)
		{
			GridEventChoice.<Refresh>d__22 <Refresh>d__;
			<Refresh>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Refresh>d__.<>4__this = this;
			<Refresh>d__.options = options;
			<Refresh>d__.<>1__state = -1;
			<Refresh>d__.<>t__builder.Start<GridEventChoice.<Refresh>d__22>(ref <Refresh>d__);
			return <Refresh>d__.<>t__builder.Task;
		}

		// Token: 0x06037FDC RID: 229340 RVA: 0x00D431E4 File Offset: 0x00D413E4
		[NullableContext(1)]
		private void SetTitle(string tagId, [Nullable(2)] string tagColor = null)
		{
			UUIText text = base.GetText(2);
			UUISprite sprite = base.GetSprite(3);
			UUIItem item = base.GetItem(1);
			if (StringUtils.IsEmpty(tagId))
			{
				item.SetUIActive(false);
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(text, tagId, Array.Empty<object>());
			if (tagColor != null)
			{
				FColor color = FColor.FromHex(tagColor);
				sprite.SetColor(color);
			}
			item.SetUIActive(true);
		}

		// Token: 0x06037FDD RID: 229341 RVA: 0x00D43242 File Offset: 0x00D41442
		public void MaskClick()
		{
		}

		// Token: 0x06037FDE RID: 229342 RVA: 0x00D43244 File Offset: 0x00D41444
		[NullableContext(1)]
		private GridEventChoiceToggle OnCreateToggleItem()
		{
			return new GridEventChoiceToggle
			{
				OnExtendToggleStateChanged = new Action<EToggleState, int>(this.OnExtendToggleStateChanged),
				OnCanExecuteChangeFunc = new Func<EToggleState, int, bool>(this.OnCanExecuteChangeFunc)
			};
		}

		// Token: 0x06037FDF RID: 229343 RVA: 0x00D43270 File Offset: 0x00D41470
		private void OnExtendToggleStateChanged(EToggleState state, int optionId)
		{
			if (state != EToggleState.ETT_UnChecked)
			{
				IToggleItemData data;
				if (!this.ToggleDataMap.TryGetValue(optionId, out data))
				{
					return;
				}
				this.FinishItemInstance.Refresh(data);
				UUIItem rootUiItem = this.ToggleLayout.GetRootUiItem();
				if (rootUiItem != null)
				{
					rootUiItem.SetUIActive(false);
				}
				this.FinishItemInstance.SetActive(true);
				Action<int, int> executeStep = this.ExecuteStep;
				if (executeStep == null)
				{
					return;
				}
				executeStep(this.StepId, optionId);
			}
		}

		// Token: 0x06037FE0 RID: 229344 RVA: 0x00D432D7 File Offset: 0x00D414D7
		private bool OnCanExecuteChangeFunc(EToggleState state, int optionId)
		{
			return this.CanInteract;
		}

		// Token: 0x0401D687 RID: 120455
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericLayout<GridEventChoiceToggle, IToggleItemData> ToggleLayout;

		// Token: 0x0401D688 RID: 120456
		[Nullable(1)]
		protected Dictionary<int, IToggleItemData> ToggleDataMap = new Dictionary<int, IToggleItemData>();

		// Token: 0x0401D689 RID: 120457
		protected GridEventChoiceFinish FinishItemInstance;

		// Token: 0x0401D68A RID: 120458
		private bool CanInteract;
	}
}
