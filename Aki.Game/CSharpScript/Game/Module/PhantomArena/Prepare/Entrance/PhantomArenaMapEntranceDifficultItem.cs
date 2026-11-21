using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x02004143 RID: 16707
	[NullableContext(2)]
	[Nullable(0)]
	internal class PhantomArenaMapEntranceDifficultItem : GridProxyAbstract<int>
	{
		// Token: 0x0602A3EC RID: 173036 RVA: 0x00BED3E4 File Offset: 0x00BEB5E4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickItem))
			};
		}

		// Token: 0x0602A3ED RID: 173037 RVA: 0x00BED464 File Offset: 0x00BEB664
		private void OnClickItem(EToggleState toggleState)
		{
			if (base.GetExtendToggle(0).GetToggleState() == EToggleState.ETT_UnChecked)
			{
				return;
			}
			Action<int> selectCallBack = this.SelectCallBack;
			if (selectCallBack != null)
			{
				selectCallBack(this.Difficult);
			}
			IScrollViewDelegate<IGridProxy<int>, int> scrollViewDelegate = base.ScrollViewDelegate;
			if (scrollViewDelegate == null)
			{
				return;
			}
			scrollViewDelegate.SelectGridProxy(base.GridIndex, base.DisplayIndex, false);
		}

		// Token: 0x0602A3EE RID: 173038 RVA: 0x00BED4B4 File Offset: 0x00BEB6B4
		protected override void OnStart()
		{
			base.GetExtendToggle(0).CanExecuteChange.Bind(delegate()
			{
				IScrollViewDelegate<IGridProxy<int>, int> scrollViewDelegate = base.ScrollViewDelegate;
				int? num = (scrollViewDelegate != null) ? new int?(scrollViewDelegate.GetSelectedGridIndex()) : null;
				int gridIndex = base.GridIndex;
				return !(num.GetValueOrDefault() == gridIndex & num != null);
			});
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0602A3EF RID: 173039 RVA: 0x00BED4E4 File Offset: 0x00BEB6E4
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			this.Difficult = data;
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(PhantomArenaDefine.difficultNumTextures[data]);
			base.TrySetTextureByPath(resourcePath, base.GetTexture(1), null, null);
			Func<int> getCurrentMapId = this.GetCurrentMapId;
			int? num = (getCurrentMapId != null) ? new int?(getCurrentMapId()) : null;
			bool uiactive = num != null && PhantomArenaModel.Instance.GetPermanentIsDifficultCompleted(num.Value, this.Difficult);
			UUIItem item = base.GetItem(2);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(uiactive);
		}

		// Token: 0x0602A3F0 RID: 173040 RVA: 0x00BED57D File Offset: 0x00BEB77D
		public override void OnSelected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, fireEvent, false, false);
		}

		// Token: 0x0602A3F1 RID: 173041 RVA: 0x00BED590 File Offset: 0x00BEB790
		public override void OnDeselected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x0602A3F2 RID: 173042 RVA: 0x00BED5A3 File Offset: 0x00BEB7A3
		public override object GetKey(int data, int displayIndex)
		{
			return this.Difficult;
		}

		// Token: 0x04016FC9 RID: 94153
		private int Difficult;

		// Token: 0x04016FCA RID: 94154
		public Action<int> SelectCallBack;

		// Token: 0x04016FCB RID: 94155
		public Func<int> GetCurrentMapId;

		// Token: 0x02009D15 RID: 40213
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04030D65 RID: 200037
			public const int Toggle = 0;

			// Token: 0x04030D66 RID: 200038
			public const int TexRome = 1;

			// Token: 0x04030D67 RID: 200039
			public const int Done = 2;
		}
	}
}
