using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x02005173 RID: 20851
	[NullableContext(2)]
	[Nullable(0)]
	internal class PhantomArenaMapEntranceDifficultItem : GridProxyAbstract<int>
	{
		// Token: 0x060354F0 RID: 218352 RVA: 0x00C9FE68 File Offset: 0x00C9E068
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

		// Token: 0x060354F1 RID: 218353 RVA: 0x00C9FEE8 File Offset: 0x00C9E0E8
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

		// Token: 0x060354F2 RID: 218354 RVA: 0x00C9FF38 File Offset: 0x00C9E138
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

		// Token: 0x060354F3 RID: 218355 RVA: 0x00C9FF68 File Offset: 0x00C9E168
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

		// Token: 0x060354F4 RID: 218356 RVA: 0x00CA0001 File Offset: 0x00C9E201
		public override void OnSelected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, fireEvent, false, false);
		}

		// Token: 0x060354F5 RID: 218357 RVA: 0x00CA0014 File Offset: 0x00C9E214
		public override void OnDeselected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x060354F6 RID: 218358 RVA: 0x00CA0027 File Offset: 0x00C9E227
		public override object GetKey(int data, int displayIndex)
		{
			return this.Difficult;
		}

		// Token: 0x0401C594 RID: 116116
		private int Difficult;

		// Token: 0x0401C595 RID: 116117
		public Action<int> SelectCallBack;

		// Token: 0x0401C596 RID: 116118
		public Func<int> GetCurrentMapId;

		// Token: 0x0200B2DB RID: 45787
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x0403630E RID: 221966
			public const int Toggle = 0;

			// Token: 0x0403630F RID: 221967
			public const int TexRome = 1;

			// Token: 0x04036310 RID: 221968
			public const int Done = 2;
		}
	}
}
