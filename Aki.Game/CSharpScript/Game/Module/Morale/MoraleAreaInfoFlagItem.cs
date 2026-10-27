using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Morale.Data;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x02005399 RID: 21401
	[NullableContext(1)]
	[Nullable(0)]
	public class MoraleAreaInfoFlagItem : UiPanelBase
	{
		// Token: 0x06036ACB RID: 223947 RVA: 0x00CF0888 File Offset: 0x00CEEA88
		public UniTask Init(string path, UUIItem parentItem, MoraleAreaFlagData flagData)
		{
			MoraleAreaInfoFlagItem.<Init>d__4 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.path = path;
			<Init>d__.parentItem = parentItem;
			<Init>d__.flagData = flagData;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<MoraleAreaInfoFlagItem.<Init>d__4>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x06036ACC RID: 223948 RVA: 0x00CF08E4 File Offset: 0x00CEEAE4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnBtnSelf));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06036ACD RID: 223949 RVA: 0x00CF0A0E File Offset: 0x00CEEC0E
		protected override void OnStart()
		{
			UUIText text = base.GetText(2);
			if (text == null)
			{
				return;
			}
			text.ShowTextNew(this.FlagData.Config.Index);
		}

		// Token: 0x06036ACE RID: 223950 RVA: 0x00CF0A31 File Offset: 0x00CEEC31
		[Conditional("WITH_EDITOR")]
		private void EditorShowFlagInfo()
		{
		}

		// Token: 0x06036ACF RID: 223951 RVA: 0x00CF0A33 File Offset: 0x00CEEC33
		private void OnBtnSelf(EToggleState toggleState)
		{
			Action<MoraleAreaFlagData> clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback(this.FlagData);
		}

		// Token: 0x06036AD0 RID: 223952 RVA: 0x00CF0A4C File Offset: 0x00CEEC4C
		public void UpdateData()
		{
			this.UpdateSelectState();
			bool uiactive = this.FlagData.HasBoxCanGet();
			UUIItem item = base.GetItem(5);
			if (item != null)
			{
				item.SetUIActive(uiactive);
			}
			bool isActive = this.FlagData.IsActive;
			string[] array = this.FlagData.TypeConfig.Value.IconPathNormal();
			string[] array2 = this.FlagData.TypeConfig.Value.IconPathActive();
			UUITexture texture = base.GetTexture(1);
			base.SetTextureByPath(isActive ? array2[0] : array[0], texture, null, null);
			UUISprite sprite = base.GetSprite(4);
			this.SetSpriteByPath(isActive ? array2[1] : array[1], sprite, false, null, null);
		}

		// Token: 0x06036AD1 RID: 223953 RVA: 0x00CF0B10 File Offset: 0x00CEED10
		public void UpdatePosition(UUIItem item)
		{
			FVector uiworldPosition = item.GetUIWorldPosition();
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetUIWorldLocation(uiworldPosition);
		}

		// Token: 0x06036AD2 RID: 223954 RVA: 0x00CF0B38 File Offset: 0x00CEED38
		public void UpdateSelectState()
		{
			EToggleState state = this.FlagData.IsSelect ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(state, false, false, false);
		}

		// Token: 0x06036AD3 RID: 223955 RVA: 0x00CF0B6C File Offset: 0x00CEED6C
		public void PlayStartSequence()
		{
			LevelSequencePlayer sequence = this.Sequence;
			if (sequence != null)
			{
				sequence.PlaySequencePurely("Start", false, false, null, null, false);
			}
			if (this.FlagData.IsSelect)
			{
				LevelSequencePlayer sequence2 = this.Sequence;
				if (sequence2 == null)
				{
					return;
				}
				sequence2.PlaySequencePurely("Select", false, false, null, null, false);
			}
		}

		// Token: 0x0401CE16 RID: 118294
		public MoraleAreaFlagData FlagData;

		// Token: 0x0401CE17 RID: 118295
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<MoraleAreaFlagData> ClickCallback;

		// Token: 0x0401CE18 RID: 118296
		[Nullable(2)]
		public LevelSequencePlayer Sequence;

		// Token: 0x0200B604 RID: 46596
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04037222 RID: 225826
			ToggleSelf,
			// Token: 0x04037223 RID: 225827
			TextureIcon,
			// Token: 0x04037224 RID: 225828
			TxtTitle,
			// Token: 0x04037225 RID: 225829
			ItemSelect,
			// Token: 0x04037226 RID: 225830
			SpriteTitleBg,
			// Token: 0x04037227 RID: 225831
			ItemBoxShow
		}
	}
}
