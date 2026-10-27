using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SeekTrace.View
{
	// Token: 0x02006A61 RID: 27233
	public class SeekTraceClawItem : UiPanelBase
	{
		// Token: 0x06043B47 RID: 277319 RVA: 0x01091ED4 File Offset: 0x010900D4
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

		// Token: 0x06043B48 RID: 277320 RVA: 0x01091F80 File Offset: 0x01090180
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

		// Token: 0x0200CB7F RID: 52095
		public enum EComponentType
		{
			// Token: 0x0403D6F5 RID: 251637
			Line1Texture,
			// Token: 0x0403D6F6 RID: 251638
			Line2Texture,
			// Token: 0x0403D6F7 RID: 251639
			IconTexture,
			// Token: 0x0403D6F8 RID: 251640
			BackgroundTexture
		}
	}
}
