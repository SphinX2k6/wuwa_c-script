using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BossPiling.View
{
	// Token: 0x02005C0E RID: 23566
	public class BossPilingKeyBuffFloatView : UiViewBase
	{
		// Token: 0x0603B8D0 RID: 243920 RVA: 0x00E32B79 File Offset: 0x00E30D79
		[NullableContext(1)]
		public BossPilingKeyBuffFloatView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603B8D1 RID: 243921 RVA: 0x00E32B84 File Offset: 0x00E30D84
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

		// Token: 0x0603B8D2 RID: 243922 RVA: 0x00E32BED File Offset: 0x00E30DED
		protected override void OnStart()
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence != null)
			{
				uiViewSequence.AddSequenceFinishEvent("Start", new Action<string>(this.OnStartAnimEnd), false);
			}
			this.RefreshBuffInfo();
		}

		// Token: 0x0603B8D3 RID: 243923 RVA: 0x00E32C1C File Offset: 0x00E30E1C
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

		// Token: 0x0603B8D4 RID: 243924 RVA: 0x00E32CB0 File Offset: 0x00E30EB0
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

		// Token: 0x0200BDED RID: 48621
		private enum EDefine
		{
			// Token: 0x04039439 RID: 234553
			Tex,
			// Token: 0x0403943A RID: 234554
			Txt
		}
	}
}
