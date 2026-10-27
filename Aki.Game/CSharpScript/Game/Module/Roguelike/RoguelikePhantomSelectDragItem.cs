using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DF4 RID: 19956
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoguelikePhantomSelectDragItem : GridProxyAbstract<IPhantomSelectItemData>
	{
		// Token: 0x060337F7 RID: 210935 RVA: 0x00C08600 File Offset: 0x00C06800
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

		// Token: 0x060337F8 RID: 210936 RVA: 0x00C086C7 File Offset: 0x00C068C7
		protected override void OnStart()
		{
			base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.CanToggleStateChangeInternal));
		}

		// Token: 0x060337F9 RID: 210937 RVA: 0x00C086E8 File Offset: 0x00C068E8
		private bool CanToggleStateChangeInternal()
		{
			if (this.CanToggleStateChange != null)
			{
				EToggleState toggleState = base.GetExtendToggle(0).GetToggleState();
				return this.CanToggleStateChange(toggleState == EToggleState.ETT_Checked);
			}
			return true;
		}

		// Token: 0x060337FA RID: 210938 RVA: 0x00C0871B File Offset: 0x00C0691B
		private void OnClickToggle(EToggleState toggleState)
		{
			Action<IPhantomSelectItemData, bool> onSelectCallback = this.OnSelectCallback;
			if (onSelectCallback == null)
			{
				return;
			}
			onSelectCallback(this.CurrentData, toggleState == EToggleState.ETT_Checked);
		}

		// Token: 0x060337FB RID: 210939 RVA: 0x00C08737 File Offset: 0x00C06937
		public void SetToggleInteractive(bool bInteract)
		{
			base.GetExtendToggle(0).SetSelfInteractive(bInteract);
		}

		// Token: 0x060337FC RID: 210940 RVA: 0x00C08748 File Offset: 0x00C06948
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

		// Token: 0x060337FD RID: 210941 RVA: 0x00C087AF File Offset: 0x00C069AF
		public override void OnDeselected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x060337FE RID: 210942 RVA: 0x00C087C2 File Offset: 0x00C069C2
		public override void OnSelected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, fireEvent, false, false);
		}

		// Token: 0x0401B53F RID: 111935
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<IPhantomSelectItemData, bool> OnSelectCallback;

		// Token: 0x0401B540 RID: 111936
		public Func<bool, bool> CanToggleStateChange;

		// Token: 0x0401B541 RID: 111937
		private IPhantomSelectItemData CurrentData;

		// Token: 0x0200AF7B RID: 44923
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04035488 RID: 218248
			public const int TogSelf = 0;

			// Token: 0x04035489 RID: 218249
			public const int TexPhantom = 1;

			// Token: 0x0403548A RID: 218250
			public const int ItemLock = 2;
		}
	}
}
