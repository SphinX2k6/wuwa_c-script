using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DBD RID: 15805
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoguelikePhantomSelectDragItem : GridProxyAbstract<IPhantomSelectItemData>
	{
		// Token: 0x06028662 RID: 165474 RVA: 0x00B51B10 File Offset: 0x00B4FD10
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06028663 RID: 165475 RVA: 0x00B51BD7 File Offset: 0x00B4FDD7
		protected override void OnStart()
		{
			base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.CanToggleStateChangeInternal));
		}

		// Token: 0x06028664 RID: 165476 RVA: 0x00B51BF8 File Offset: 0x00B4FDF8
		private bool CanToggleStateChangeInternal()
		{
			if (this.CanToggleStateChange != null)
			{
				EToggleState toggleState = base.GetExtendToggle(0).GetToggleState();
				return this.CanToggleStateChange(toggleState == EToggleState.ETT_Checked);
			}
			return true;
		}

		// Token: 0x06028665 RID: 165477 RVA: 0x00B51C2B File Offset: 0x00B4FE2B
		private void OnClickToggle(EToggleState toggleState)
		{
			Action<IPhantomSelectItemData, bool> onSelectCallback = this.OnSelectCallback;
			if (onSelectCallback == null)
			{
				return;
			}
			onSelectCallback(this.CurrentData, toggleState == EToggleState.ETT_Checked);
		}

		// Token: 0x06028666 RID: 165478 RVA: 0x00B51C47 File Offset: 0x00B4FE47
		public void SetToggleInteractive(bool bInteract)
		{
			base.GetExtendToggle(0).SetSelfInteractive(bInteract);
		}

		// Token: 0x06028667 RID: 165479 RVA: 0x00B51C58 File Offset: 0x00B4FE58
		[NullableContext(1)]
		public override void Refresh(IPhantomSelectItemData data, bool isSelected, int gridIndex)
		{
			this.CurrentData = data;
			base.GetItem(2).SetUIActive(data.IsLock);
			RoguePokemon? roguePhantomConfig = RoguelikeConfig.Instance.GetRoguePhantomConfig(data.PhantomId);
			if (roguePhantomConfig == null)
			{
				return;
			}
			base.SetTextureByPath(roguePhantomConfig.Value.PokemonIcon, base.GetTexture(1), null, null);
		}

		// Token: 0x06028668 RID: 165480 RVA: 0x00B51CBF File Offset: 0x00B4FEBF
		public override void OnDeselected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x06028669 RID: 165481 RVA: 0x00B51CD2 File Offset: 0x00B4FED2
		public override void OnSelected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, fireEvent, false, false);
		}

		// Token: 0x04015F12 RID: 89874
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<IPhantomSelectItemData, bool> OnSelectCallback;

		// Token: 0x04015F13 RID: 89875
		public Func<bool, bool> CanToggleStateChange;

		// Token: 0x04015F14 RID: 89876
		private IPhantomSelectItemData CurrentData;

		// Token: 0x020099B0 RID: 39344
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0402FEBB RID: 196283
			public const int TogSelf = 0;

			// Token: 0x0402FEBC RID: 196284
			public const int TexPhantom = 1;

			// Token: 0x0402FEBD RID: 196285
			public const int ItemLock = 2;
		}
	}
}
