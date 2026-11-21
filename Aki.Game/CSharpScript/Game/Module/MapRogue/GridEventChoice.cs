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
	// Token: 0x020045A7 RID: 17831
	[NullableContext(2)]
	[Nullable(0)]
	public class GridEventChoice : UiPanelBase, IEventStepItem
	{
		// Token: 0x17005AC1 RID: 23233
		// (get) Token: 0x0602CECF RID: 184015 RVA: 0x00C90D5A File Offset: 0x00C8EF5A
		// (set) Token: 0x0602CED0 RID: 184016 RVA: 0x00C90D62 File Offset: 0x00C8EF62
		public Action<int, int> ExecuteStep { get; set; }

		// Token: 0x17005AC2 RID: 23234
		// (get) Token: 0x0602CED1 RID: 184017 RVA: 0x00C90D6B File Offset: 0x00C8EF6B
		public int StepId { get; }

		// Token: 0x17005AC3 RID: 23235
		// (get) Token: 0x0602CED2 RID: 184018 RVA: 0x00C90D73 File Offset: 0x00C8EF73
		public EStepType StepType { get; }

		// Token: 0x17005AC4 RID: 23236
		// (get) Token: 0x0602CED3 RID: 184019 RVA: 0x00C90D7B File Offset: 0x00C8EF7B
		// (set) Token: 0x0602CED4 RID: 184020 RVA: 0x00C90D83 File Offset: 0x00C8EF83
		public Action<int, EStepType> CanInteractCallback { get; set; }

		// Token: 0x0602CED5 RID: 184021 RVA: 0x00C90D8C File Offset: 0x00C8EF8C
		public GridEventChoice(int stepId, EStepType stepType = EStepType.Choose)
		{
			this.StepId = stepId;
			this.StepType = stepType;
		}

		// Token: 0x0602CED6 RID: 184022 RVA: 0x00C90DB0 File Offset: 0x00C8EFB0
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

		// Token: 0x0602CED7 RID: 184023 RVA: 0x00C90E78 File Offset: 0x00C8F078
		protected override UniTask OnBeforeStartAsync()
		{
			GridEventChoice.<OnBeforeStartAsync>d__20 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<GridEventChoice.<OnBeforeStartAsync>d__20>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602CED8 RID: 184024 RVA: 0x00C90EBB File Offset: 0x00C8F0BB
		protected override void OnStart()
		{
			this.ToggleLayout = new GenericLayout<GridEventChoiceToggle, IToggleItemData>(base.GetVerticalLayout(5), new Func<GridEventChoiceToggle>(this.OnCreateToggleItem), null, false, true);
		}

		// Token: 0x0602CED9 RID: 184025 RVA: 0x00C90EE0 File Offset: 0x00C8F0E0
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

		// Token: 0x0602CEDA RID: 184026 RVA: 0x00C90F2C File Offset: 0x00C8F12C
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

		// Token: 0x0602CEDB RID: 184027 RVA: 0x00C90F8A File Offset: 0x00C8F18A
		public void MaskClick()
		{
		}

		// Token: 0x0602CEDC RID: 184028 RVA: 0x00C90F8C File Offset: 0x00C8F18C
		[NullableContext(1)]
		private GridEventChoiceToggle OnCreateToggleItem()
		{
			return new GridEventChoiceToggle
			{
				OnExtendToggleStateChanged = new Action<EToggleState, int>(this.OnExtendToggleStateChanged),
				OnCanExecuteChangeFunc = new Func<EToggleState, int, bool>(this.OnCanExecuteChangeFunc)
			};
		}

		// Token: 0x0602CEDD RID: 184029 RVA: 0x00C90FB8 File Offset: 0x00C8F1B8
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

		// Token: 0x0602CEDE RID: 184030 RVA: 0x00C9101F File Offset: 0x00C8F21F
		private bool OnCanExecuteChangeFunc(EToggleState state, int optionId)
		{
			return this.CanInteract;
		}

		// Token: 0x04018112 RID: 98578
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericLayout<GridEventChoiceToggle, IToggleItemData> ToggleLayout;

		// Token: 0x04018113 RID: 98579
		[Nullable(1)]
		protected Dictionary<int, IToggleItemData> ToggleDataMap = new Dictionary<int, IToggleItemData>();

		// Token: 0x04018114 RID: 98580
		protected GridEventChoiceFinish FinishItemInstance;

		// Token: 0x04018115 RID: 98581
		private bool CanInteract;
	}
}
