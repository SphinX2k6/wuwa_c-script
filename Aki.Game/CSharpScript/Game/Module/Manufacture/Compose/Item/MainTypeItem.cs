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
	// Token: 0x02005686 RID: 22150
	[NullableContext(1)]
	[Nullable(0)]
	public class MainTypeItem : UiPanelBase, IGridProxy<EComposeListType>
	{
		// Token: 0x1700877A RID: 34682
		// (get) Token: 0x060385D7 RID: 230871 RVA: 0x00D61D1B File Offset: 0x00D5FF1B
		// (set) Token: 0x060385D8 RID: 230872 RVA: 0x00D61D23 File Offset: 0x00D5FF23
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

		// Token: 0x1700877B RID: 34683
		// (get) Token: 0x060385D9 RID: 230873 RVA: 0x00D61D2C File Offset: 0x00D5FF2C
		// (set) Token: 0x060385DA RID: 230874 RVA: 0x00D61D34 File Offset: 0x00D5FF34
		public int GridIndex { get; set; }

		// Token: 0x1700877C RID: 34684
		// (get) Token: 0x060385DB RID: 230875 RVA: 0x00D61D3D File Offset: 0x00D5FF3D
		// (set) Token: 0x060385DC RID: 230876 RVA: 0x00D61D45 File Offset: 0x00D5FF45
		public int DisplayIndex { get; set; }

		// Token: 0x060385DD RID: 230877 RVA: 0x00D61D50 File Offset: 0x00D5FF50
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

		// Token: 0x060385DE RID: 230878 RVA: 0x00D61DF8 File Offset: 0x00D5FFF8
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

		// Token: 0x060385DF RID: 230879 RVA: 0x00D61E7C File Offset: 0x00D6007C
		public void Clear()
		{
		}

		// Token: 0x060385E0 RID: 230880 RVA: 0x00D61E7E File Offset: 0x00D6007E
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

		// Token: 0x060385E1 RID: 230881 RVA: 0x00D61EA7 File Offset: 0x00D600A7
		public void OnDeselected(bool fireEvent)
		{
			base.GetExtendToggle(1).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x060385E2 RID: 230882 RVA: 0x00D61EBA File Offset: 0x00D600BA
		public void CreateThenShowByActor(AActor actor)
		{
			base.CreateThenShowByActor(actor, null);
		}

		// Token: 0x060385E3 RID: 230883 RVA: 0x00D61EC4 File Offset: 0x00D600C4
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

		// Token: 0x060385E4 RID: 230884 RVA: 0x00D61F10 File Offset: 0x00D60110
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

		// Token: 0x060385E5 RID: 230885 RVA: 0x00D61F5B File Offset: 0x00D6015B
		public object GetKey(EComposeListType data, int gridIndex)
		{
			return this.MainType;
		}

		// Token: 0x060385E6 RID: 230886 RVA: 0x00D61F68 File Offset: 0x00D60168
		public EComposeListType GetMainType()
		{
			return this.MainType;
		}

		// Token: 0x060385E7 RID: 230887 RVA: 0x00D61F70 File Offset: 0x00D60170
		public void SetMainTypeCallback(Action<int> mainTypeCallback)
		{
			this.OnClickedCallback = mainTypeCallback;
		}

		// Token: 0x060385E8 RID: 230888 RVA: 0x00D61F79 File Offset: 0x00D60179
		public void SelectedItem()
		{
			if (this.OnClickedCallback != null)
			{
				this.OnClickedCallback((int)this.MainType);
			}
		}

		// Token: 0x060385E9 RID: 230889 RVA: 0x00D61F94 File Offset: 0x00D60194
		private void OnItemButtonClicked(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				this.ScrollViewDelegate.SelectGridProxy(this.GridIndex, this.DisplayIndex, true);
			}
		}

		// Token: 0x0401D9E5 RID: 121317
		private EComposeListType MainType = EComposeListType.Purification;

		// Token: 0x0401D9E6 RID: 121318
		[Nullable(2)]
		private Action<int> OnClickedCallback;

		// Token: 0x0200B850 RID: 47184
		[NullableContext(0)]
		public class EMainTypeDefine
		{
			// Token: 0x04037C99 RID: 228505
			public const int IconSprite = 0;

			// Token: 0x04037C9A RID: 228506
			public const int MainTypeExtendToggle = 1;
		}
	}
}
