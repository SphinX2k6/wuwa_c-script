using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Cook.View
{
	// Token: 0x02004B05 RID: 19205
	[NullableContext(1)]
	[Nullable(0)]
	public class MainTypeItem : UiPanelBase, IGridProxy<ECookListType>
	{
		// Token: 0x17006063 RID: 24675
		// (get) Token: 0x0603009C RID: 196764 RVA: 0x00D66DC7 File Offset: 0x00D64FC7
		// (set) Token: 0x0603009D RID: 196765 RVA: 0x00D66DCF File Offset: 0x00D64FCF
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public IScrollViewDelegate<IGridProxy<ECookListType>, ECookListType> ScrollViewDelegate { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17006064 RID: 24676
		// (get) Token: 0x0603009E RID: 196766 RVA: 0x00D66DD8 File Offset: 0x00D64FD8
		// (set) Token: 0x0603009F RID: 196767 RVA: 0x00D66DE0 File Offset: 0x00D64FE0
		public int GridIndex { get; set; }

		// Token: 0x17006065 RID: 24677
		// (get) Token: 0x060300A0 RID: 196768 RVA: 0x00D66DE9 File Offset: 0x00D64FE9
		// (set) Token: 0x060300A1 RID: 196769 RVA: 0x00D66DF1 File Offset: 0x00D64FF1
		public int DisplayIndex { get; set; }

		// Token: 0x060300A2 RID: 196770 RVA: 0x00D66DFC File Offset: 0x00D64FFC
		public void Refresh(ECookListType data, bool isSelected, int gridIndex)
		{
			this.MainType = new ECookListType?(data);
			ECookListType? mainType = this.MainType;
			ECookListType ecookListType = ECookListType.Cooking;
			string resourcePath;
			if (mainType.GetValueOrDefault() == ecookListType & mainType != null)
			{
				resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_Cooking");
			}
			else
			{
				resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_Machining");
			}
			this.SetSpriteByPath(resourcePath, base.GetSprite(0), false, null, null);
		}

		// Token: 0x060300A3 RID: 196771 RVA: 0x00D66E73 File Offset: 0x00D65073
		public void Clear()
		{
		}

		// Token: 0x060300A4 RID: 196772 RVA: 0x00D66E75 File Offset: 0x00D65075
		public void OnSelected(bool fireEvent)
		{
			base.GetExtendToggle(1).SetToggleState(EToggleState.ETT_Checked, fireEvent, false, false);
			Action<int> onClickedCallback = this.OnClickedCallback;
			if (onClickedCallback == null)
			{
				return;
			}
			onClickedCallback((int)this.MainType.Value);
		}

		// Token: 0x060300A5 RID: 196773 RVA: 0x00D66EA3 File Offset: 0x00D650A3
		public void OnDeselected(bool fireEvent)
		{
			base.GetExtendToggle(1).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x060300A6 RID: 196774 RVA: 0x00D66EB6 File Offset: 0x00D650B6
		public void CreateThenShowByActor(AActor actor)
		{
			base.CreateThenShowByActor(actor, null);
		}

		// Token: 0x060300A7 RID: 196775 RVA: 0x00D66EC0 File Offset: 0x00D650C0
		public UniTask CreateThenShowByActorAsync(AActor actor)
		{
			MainTypeItem.<CreateThenShowByActorAsync>d__19 <CreateThenShowByActorAsync>d__;
			<CreateThenShowByActorAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateThenShowByActorAsync>d__.<>4__this = this;
			<CreateThenShowByActorAsync>d__.actor = actor;
			<CreateThenShowByActorAsync>d__.<>1__state = -1;
			<CreateThenShowByActorAsync>d__.<>t__builder.Start<MainTypeItem.<CreateThenShowByActorAsync>d__19>(ref <CreateThenShowByActorAsync>d__);
			return <CreateThenShowByActorAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060300A8 RID: 196776 RVA: 0x00D66F0C File Offset: 0x00D6510C
		public UniTask CreateByActorAsync(AActor actor)
		{
			MainTypeItem.<CreateByActorAsync>d__20 <CreateByActorAsync>d__;
			<CreateByActorAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateByActorAsync>d__.<>4__this = this;
			<CreateByActorAsync>d__.actor = actor;
			<CreateByActorAsync>d__.<>1__state = -1;
			<CreateByActorAsync>d__.<>t__builder.Start<MainTypeItem.<CreateByActorAsync>d__20>(ref <CreateByActorAsync>d__);
			return <CreateByActorAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060300A9 RID: 196777 RVA: 0x00D66F57 File Offset: 0x00D65157
		public object GetKey(ECookListType data, int gridIndex)
		{
			return gridIndex;
		}

		// Token: 0x060300AA RID: 196778 RVA: 0x00D66F60 File Offset: 0x00D65160
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

		// Token: 0x060300AB RID: 196779 RVA: 0x00D67006 File Offset: 0x00D65206
		public ECookListType GetMainType()
		{
			return this.MainType.Value;
		}

		// Token: 0x060300AC RID: 196780 RVA: 0x00D67013 File Offset: 0x00D65213
		public void SetMainTypeCallback(Action<int> mainTypeCallback)
		{
			this.OnClickedCallback = mainTypeCallback;
		}

		// Token: 0x060300AD RID: 196781 RVA: 0x00D6701C File Offset: 0x00D6521C
		private void OnItemButtonClicked(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				this.ScrollViewDelegate.SelectGridProxy(this.GridIndex, this.DisplayIndex, true);
			}
		}

		// Token: 0x0401979B RID: 104347
		private ECookListType? MainType;

		// Token: 0x0401979C RID: 104348
		[Nullable(2)]
		private Action<int> OnClickedCallback;
	}
}
