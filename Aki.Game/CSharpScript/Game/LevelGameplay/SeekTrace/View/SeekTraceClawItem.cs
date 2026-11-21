using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SeekTrace.View
{
	// Token: 0x02005BBE RID: 23486
	public class SeekTraceClawItem : UiPanelBase
	{
		// Token: 0x06039B95 RID: 236437 RVA: 0x01036708 File Offset: 0x01034908
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06039B96 RID: 236438 RVA: 0x010367B4 File Offset: 0x010349B4
		protected override void OnBeforeShow()
		{
			string resourceId = "TraceClawType3Icon";
			string resourceId2 = "TraceClawType3Bg";
			ETraceTracingImageType iconType = SeekTraceModel.Instance.IconType;
			if (iconType != ETraceTracingImageType.Type1)
			{
				if (iconType == ETraceTracingImageType.Type2)
				{
					resourceId = "TraceClawType2Icon";
					resourceId2 = "TraceClawType2Bg";
				}
			}
			else
			{
				resourceId = "TraceClawType1Icon";
				resourceId2 = "TraceClawType1Bg";
			}
			base.SetTextureByPath(UiResourceConfig.Instance.GetResourcePath(resourceId), base.GetTexture(2), null, null);
			base.SetTextureByPath(UiResourceConfig.Instance.GetResourcePath(resourceId2), base.GetTexture(3), null, null);
		}

		// Token: 0x0200B75E RID: 46942
		public enum EComponentType
		{
			// Token: 0x04038AD7 RID: 232151
			Line1Texture,
			// Token: 0x04038AD8 RID: 232152
			Line2Texture,
			// Token: 0x04038AD9 RID: 232153
			IconTexture,
			// Token: 0x04038ADA RID: 232154
			BackgroundTexture
		}
	}
}
