using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Manufacture.Compose.Item
{
	// Token: 0x0200465C RID: 18012
	[NullableContext(1)]
	[Nullable(0)]
	public class MainTypeItem : UiPanelBase, IGridProxy<EComposeListType>
	{
		// Token: 0x17005B41 RID: 23361
		// (get) Token: 0x0602D4D4 RID: 185556 RVA: 0x00CAFE6B File Offset: 0x00CAE06B
		// (set) Token: 0x0602D4D5 RID: 185557 RVA: 0x00CAFE73 File Offset: 0x00CAE073
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public IScrollViewDelegate<IGridProxy<EComposeListType>, EComposeListType> ScrollViewDelegate { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17005B42 RID: 23362
		// (get) Token: 0x0602D4D6 RID: 185558 RVA: 0x00CAFE7C File Offset: 0x00CAE07C
		// (set) Token: 0x0602D4D7 RID: 185559 RVA: 0x00CAFE84 File Offset: 0x00CAE084
		public int GridIndex { get; set; }

		// Token: 0x17005B43 RID: 23363
		// (get) Token: 0x0602D4D8 RID: 185560 RVA: 0x00CAFE8D File Offset: 0x00CAE08D
		// (set) Token: 0x0602D4D9 RID: 185561 RVA: 0x00CAFE95 File Offset: 0x00CAE095
		public int DisplayIndex { get; set; }

		// Token: 0x0602D4DA RID: 185562 RVA: 0x00CAFEA0 File Offset: 0x00CAE0A0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnItemButtonClicked));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602D4DB RID: 185563 RVA: 0x00CAFF48 File Offset: 0x00CAE148
		public void Refresh(EComposeListType data, bool isSelected, int gridIndex)
		{
			this.MainType = data;
			string path = "";
			switch (this.MainType)
			{
			case EComposeListType.ReagentProduction:
				path = UiResourceConfig.Instance.GetResourcePath("SP_ReagentProduction");
				break;
			case EComposeListType.Structure:
				path = UiResourceConfig.Instance.GetResourcePath("SP_Structure");
				break;
			case EComposeListType.Purification:
				path = UiResourceConfig.Instance.GetResourcePath("SP_Purification");
				break;
			}
			this.SetSpriteByPath(path, base.GetSprite(0), false, null, null);
		}

		// Token: 0x0602D4DC RID: 185564 RVA: 0x00CAFFCC File Offset: 0x00CAE1CC
		public void Clear()
		{
		}

		// Token: 0x0602D4DD RID: 185565 RVA: 0x00CAFFCE File Offset: 0x00CAE1CE
		public void OnSelected(bool fireEvent)
		{
			base.GetExtendToggle(1).SetToggleState(EToggleState.ETT_Checked, fireEvent, false, false);
			Action<int> onClickedCallback = this.OnClickedCallback;
			if (onClickedCallback == null)
			{
				return;
			}
			onClickedCallback((int)this.MainType);
		}

		// Token: 0x0602D4DE RID: 185566 RVA: 0x00CAFFF7 File Offset: 0x00CAE1F7
		public void OnDeselected(bool fireEvent)
		{
			base.GetExtendToggle(1).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0602D4DF RID: 185567 RVA: 0x00CB000A File Offset: 0x00CAE20A
		public void CreateThenShowByActor(AActor actor)
		{
			base.CreateThenShowByActor(actor, null);
		}

		// Token: 0x0602D4E0 RID: 185568 RVA: 0x00CB0014 File Offset: 0x00CAE214
		public UniTask CreateThenShowByActorAsync(AActor actor)
		{
			MainTypeItem.<CreateThenShowByActorAsync>d__21 <CreateThenShowByActorAsync>d__;
			<CreateThenShowByActorAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateThenShowByActorAsync>d__.<>4__this = this;
			<CreateThenShowByActorAsync>d__.actor = actor;
			<CreateThenShowByActorAsync>d__.<>1__state = -1;
			<CreateThenShowByActorAsync>d__.<>t__builder.Start<MainTypeItem.<CreateThenShowByActorAsync>d__21>(ref <CreateThenShowByActorAsync>d__);
			return <CreateThenShowByActorAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602D4E1 RID: 185569 RVA: 0x00CB0060 File Offset: 0x00CAE260
		public UniTask CreateByActorAsync(AActor actor)
		{
			MainTypeItem.<CreateByActorAsync>d__22 <CreateByActorAsync>d__;
			<CreateByActorAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateByActorAsync>d__.<>4__this = this;
			<CreateByActorAsync>d__.actor = actor;
			<CreateByActorAsync>d__.<>1__state = -1;
			<CreateByActorAsync>d__.<>t__builder.Start<MainTypeItem.<CreateByActorAsync>d__22>(ref <CreateByActorAsync>d__);
			return <CreateByActorAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602D4E2 RID: 185570 RVA: 0x00CB00AB File Offset: 0x00CAE2AB
		public object GetKey(EComposeListType data, int gridIndex)
		{
			return this.MainType;
		}

		// Token: 0x0602D4E3 RID: 185571 RVA: 0x00CB00B8 File Offset: 0x00CAE2B8
		public EComposeListType GetMainType()
		{
			return this.MainType;
		}

		// Token: 0x0602D4E4 RID: 185572 RVA: 0x00CB00C0 File Offset: 0x00CAE2C0
		public void SetMainTypeCallback(Action<int> mainTypeCallback)
		{
			this.OnClickedCallback = mainTypeCallback;
		}

		// Token: 0x0602D4E5 RID: 185573 RVA: 0x00CB00C9 File Offset: 0x00CAE2C9
		public void SelectedItem()
		{
			if (this.OnClickedCallback != null)
			{
				this.OnClickedCallback((int)this.MainType);
			}
		}

		// Token: 0x0602D4E6 RID: 185574 RVA: 0x00CB00E4 File Offset: 0x00CAE2E4
		private void OnItemButtonClicked(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				this.ScrollViewDelegate.SelectGridProxy(this.GridIndex, this.DisplayIndex, true);
			}
		}

		// Token: 0x04018470 RID: 99440
		private EComposeListType MainType = EComposeListType.Purification;

		// Token: 0x04018471 RID: 99441
		[Nullable(2)]
		private Action<int> OnClickedCallback;

		// Token: 0x0200A278 RID: 41592
		[NullableContext(0)]
		public class EMainTypeDefine
		{
			// Token: 0x040326B6 RID: 206518
			public const int IconSprite = 0;

			// Token: 0x040326B7 RID: 206519
			public const int MainTypeExtendToggle = 1;
		}
	}
}
