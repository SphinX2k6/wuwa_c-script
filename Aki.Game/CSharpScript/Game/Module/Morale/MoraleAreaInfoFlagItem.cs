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
	// Token: 0x0200437C RID: 17276
	[NullableContext(1)]
	[Nullable(0)]
	public class MoraleAreaInfoFlagItem : UiPanelBase
	{
		// Token: 0x0602BA11 RID: 178705 RVA: 0x00C3F930 File Offset: 0x00C3DB30
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

		// Token: 0x0602BA12 RID: 178706 RVA: 0x00C3F98C File Offset: 0x00C3DB8C
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

		// Token: 0x0602BA13 RID: 178707 RVA: 0x00C3FAB6 File Offset: 0x00C3DCB6
		protected override void OnStart()
		{
			UUIText text = base.GetText(2);
			if (text == null)
			{
				return;
			}
			text.ShowTextNew(this.FlagData.Config.Index);
		}

		// Token: 0x0602BA14 RID: 178708 RVA: 0x00C3FAD9 File Offset: 0x00C3DCD9
		[Conditional("WITH_EDITOR")]
		private void EditorShowFlagInfo()
		{
		}

		// Token: 0x0602BA15 RID: 178709 RVA: 0x00C3FADB File Offset: 0x00C3DCDB
		private void OnBtnSelf(EToggleState toggleState)
		{
			Action<MoraleAreaFlagData> clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback(this.FlagData);
		}

		// Token: 0x0602BA16 RID: 178710 RVA: 0x00C3FAF4 File Offset: 0x00C3DCF4
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

		// Token: 0x0602BA17 RID: 178711 RVA: 0x00C3FBB8 File Offset: 0x00C3DDB8
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

		// Token: 0x0602BA18 RID: 178712 RVA: 0x00C3FBE0 File Offset: 0x00C3DDE0
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

		// Token: 0x0602BA19 RID: 178713 RVA: 0x00C3FC14 File Offset: 0x00C3DE14
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

		// Token: 0x040178AE RID: 96430
		public MoraleAreaFlagData FlagData;

		// Token: 0x040178AF RID: 96431
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<MoraleAreaFlagData> ClickCallback;

		// Token: 0x040178B0 RID: 96432
		[Nullable(2)]
		public LevelSequencePlayer Sequence;

		// Token: 0x0200A03C RID: 41020
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04031C77 RID: 203895
			ToggleSelf,
			// Token: 0x04031C78 RID: 203896
			TextureIcon,
			// Token: 0x04031C79 RID: 203897
			TxtTitle,
			// Token: 0x04031C7A RID: 203898
			ItemSelect,
			// Token: 0x04031C7B RID: 203899
			SpriteTitleBg,
			// Token: 0x04031C7C RID: 203900
			ItemBoxShow
		}
	}
}
