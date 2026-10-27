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
	// Token: 0x02005B24 RID: 23332
	[NullableContext(1)]
	[Nullable(0)]
	public class MainTypeItem : UiPanelBase, IGridProxy<ECookListType>
	{
		// Token: 0x17008C89 RID: 35977
		// (get) Token: 0x0603B12A RID: 241962 RVA: 0x00E160AF File Offset: 0x00E142AF
		// (set) Token: 0x0603B12B RID: 241963 RVA: 0x00E160B7 File Offset: 0x00E142B7
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

		// Token: 0x17008C8A RID: 35978
		// (get) Token: 0x0603B12C RID: 241964 RVA: 0x00E160C0 File Offset: 0x00E142C0
		// (set) Token: 0x0603B12D RID: 241965 RVA: 0x00E160C8 File Offset: 0x00E142C8
		public int GridIndex { get; set; }

		// Token: 0x17008C8B RID: 35979
		// (get) Token: 0x0603B12E RID: 241966 RVA: 0x00E160D1 File Offset: 0x00E142D1
		// (set) Token: 0x0603B12F RID: 241967 RVA: 0x00E160D9 File Offset: 0x00E142D9
		public int DisplayIndex { get; set; }

		// Token: 0x0603B130 RID: 241968 RVA: 0x00E160E4 File Offset: 0x00E142E4
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

		// Token: 0x0603B131 RID: 241969 RVA: 0x00E1615B File Offset: 0x00E1435B
		public void Clear()
		{
		}

		// Token: 0x0603B132 RID: 241970 RVA: 0x00E1615D File Offset: 0x00E1435D
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

		// Token: 0x0603B133 RID: 241971 RVA: 0x00E1618B File Offset: 0x00E1438B
		public void OnDeselected(bool fireEvent)
		{
			base.GetExtendToggle(1).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0603B134 RID: 241972 RVA: 0x00E1619E File Offset: 0x00E1439E
		public void CreateThenShowByActor(AActor actor)
		{
			base.CreateThenShowByActor(actor, null);
		}

		// Token: 0x0603B135 RID: 241973 RVA: 0x00E161A8 File Offset: 0x00E143A8
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

		// Token: 0x0603B136 RID: 241974 RVA: 0x00E161F4 File Offset: 0x00E143F4
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

		// Token: 0x0603B137 RID: 241975 RVA: 0x00E1623F File Offset: 0x00E1443F
		public object GetKey(ECookListType data, int gridIndex)
		{
			return gridIndex;
		}

		// Token: 0x0603B138 RID: 241976 RVA: 0x00E16248 File Offset: 0x00E14448
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

		// Token: 0x0603B139 RID: 241977 RVA: 0x00E162EE File Offset: 0x00E144EE
		public ECookListType GetMainType()
		{
			return this.MainType.Value;
		}

		// Token: 0x0603B13A RID: 241978 RVA: 0x00E162FB File Offset: 0x00E144FB
		public void SetMainTypeCallback(Action<int> mainTypeCallback)
		{
			this.OnClickedCallback = mainTypeCallback;
		}

		// Token: 0x0603B13B RID: 241979 RVA: 0x00E16304 File Offset: 0x00E14504
		private void OnItemButtonClicked(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				this.ScrollViewDelegate.SelectGridProxy(this.GridIndex, this.DisplayIndex, true);
			}
		}

		// Token: 0x0401ECDF RID: 126175
		private ECookListType? MainType;

		// Token: 0x0401ECE0 RID: 126176
		[Nullable(2)]
		private Action<int> OnClickedCallback;
	}
}
