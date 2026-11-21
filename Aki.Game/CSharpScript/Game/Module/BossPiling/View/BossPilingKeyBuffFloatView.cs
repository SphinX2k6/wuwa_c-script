using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BossPiling.View
{
	// Token: 0x02004BEE RID: 19438
	public class BossPilingKeyBuffFloatView : UiViewBase
	{
		// Token: 0x0603081B RID: 198683 RVA: 0x00D82EB9 File Offset: 0x00D810B9
		[NullableContext(1)]
		public BossPilingKeyBuffFloatView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603081C RID: 198684 RVA: 0x00D82EC4 File Offset: 0x00D810C4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603081D RID: 198685 RVA: 0x00D82F2D File Offset: 0x00D8112D
		protected override void OnStart()
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence != null)
			{
				uiViewSequence.AddSequenceFinishEvent("Start", new Action<string>(this.OnStartAnimEnd), false);
			}
			this.RefreshBuffInfo();
		}

		// Token: 0x0603081E RID: 198686 RVA: 0x00D82F5C File Offset: 0x00D8115C
		protected bool RefreshBuffInfo()
		{
			if (BossPilingModel.Instance.InstKeyBuffList.Count == 0)
			{
				base.CloseMe(null);
				return false;
			}
			int id = BossPilingModel.Instance.InstKeyBuffList[0];
			BossPilingModel.Instance.InstKeyBuffList.RemoveAt(0);
			BossPilingBuff value = BossPilingConfig.Instance.GetBuffInfo(id).Value;
			base.SetTextureByPath(value.Icon, base.GetTexture(0), null, null);
			UUIText text = base.GetText(1);
			if (text != null)
			{
				text.ShowTextNew(value.Name);
			}
			return true;
		}

		// Token: 0x0603081F RID: 198687 RVA: 0x00D82FF0 File Offset: 0x00D811F0
		[NullableContext(1)]
		private void OnStartAnimEnd(string _)
		{
			if (this.RefreshBuffInfo())
			{
				UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
				if (uiViewSequence == null)
				{
					return;
				}
				uiViewSequence.PlayOrReplaySequenceByName("Start", false, null);
			}
		}

		// Token: 0x0200A7F5 RID: 42997
		private enum EDefine
		{
			// Token: 0x04033DFC RID: 212476
			Tex,
			// Token: 0x04033DFD RID: 212477
			Txt
		}
	}
}
