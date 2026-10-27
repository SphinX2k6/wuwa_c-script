using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Giant.View
{
	// Token: 0x02005978 RID: 22904
	[NullableContext(1)]
	[Nullable(0)]
	public class GiantAttitudeRowItem : UiPanelBase
	{
		// Token: 0x0603A21F RID: 238111 RVA: 0x00DD2AEC File Offset: 0x00DD0CEC
		public UniTask Init(UUIItem item)
		{
			GiantAttitudeRowItem.<Init>d__1 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.item = item;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<GiantAttitudeRowItem.<Init>d__1>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x0603A220 RID: 238112 RVA: 0x00DD2B38 File Offset: 0x00DD0D38
		protected unsafe override void OnRegisterComponent()
		{
			int num = 11;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603A221 RID: 238113 RVA: 0x00DD2D0A File Offset: 0x00DD0F0A
		public void SetClickCallback(Action call)
		{
			this.OnClickCall = call;
		}

		// Token: 0x0603A222 RID: 238114 RVA: 0x00DD2D14 File Offset: 0x00DD0F14
		public void Refresh(GiantAttitudeRowData attitude, GiantAttitudeRowData assist, bool locked, bool active)
		{
			this.RefreshRow(EAttitudeRowComp.PnlIcon01, EAttitudeRowComp.SprIcon01, EAttitudeRowComp.PnlLock01, EAttitudeRowComp.TxtContent01, attitude, locked);
			this.RefreshRow(EAttitudeRowComp.PnlIcon02, EAttitudeRowComp.SprIcon02, EAttitudeRowComp.PnlLock02, EAttitudeRowComp.TxtContent02, assist, locked);
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(!active);
			}
			UUIItem item2 = base.GetItem(2);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(active);
		}

		// Token: 0x0603A223 RID: 238115 RVA: 0x00DD2D68 File Offset: 0x00DD0F68
		private void RefreshRow(EAttitudeRowComp pnlIcon, EAttitudeRowComp sprIcon, EAttitudeRowComp pnlLock, EAttitudeRowComp txtContent, GiantAttitudeRowData data, bool locked)
		{
			UUIText text = base.GetText((int)txtContent);
			if (text != null)
			{
				text.SetText(data.Text, true);
			}
			UUIItem item = base.GetItem((int)pnlLock);
			if (item != null)
			{
				item.SetUIActive(locked);
			}
			UUIItem item2 = base.GetItem((int)pnlIcon);
			if (item2 != null)
			{
				item2.SetUIActive(!locked);
			}
			if (!locked && data.IconPath != null)
			{
				base.TrySetSpriteByPath(data.IconPath, base.GetSprite((int)sprIcon), false, null, null);
			}
			UUIText text2 = base.GetText((int)txtContent);
			if (text2 != null)
			{
				UUIItem uuiitem = text2;
				FColor? fcolor = new FColor?(text2.changeColor);
				uuiitem.SetChangeColor(locked, fcolor);
			}
		}

		// Token: 0x0603A224 RID: 238116 RVA: 0x00DD2E09 File Offset: 0x00DD1009
		private void OnClick()
		{
			Action onClickCall = this.OnClickCall;
			if (onClickCall == null)
			{
				return;
			}
			onClickCall();
		}

		// Token: 0x0401E54C RID: 124236
		[Nullable(2)]
		private Action OnClickCall;
	}
}
