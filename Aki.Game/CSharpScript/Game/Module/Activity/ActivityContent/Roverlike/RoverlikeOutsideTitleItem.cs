using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050A4 RID: 20644
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoverlikeOutsideTitleItem : SyncGridProxyAbstract<RoverlikeOutsideTitleData>
	{
		// Token: 0x06033AC7 RID: 211655 RVA: 0x00E76514 File Offset: 0x00E74714
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06033AC8 RID: 211656 RVA: 0x00E765A0 File Offset: 0x00E747A0
		[NullableContext(1)]
		public override void Refresh(RoverlikeOutsideTitleData data)
		{
			bool flag = !StringUtils.IsEmpty(data.IconPath);
			bool flag2 = !StringUtils.IsEmpty(data.TitleKey);
			UUIText text = base.GetText(2);
			if (text != null)
			{
				text.SetUIActive(flag2);
				if (flag2)
				{
					LguiUtil.Instance.SetLocalTextNew(text, data.TitleKey, Array.Empty<object>());
				}
			}
			UUITexture texture = base.GetTexture(1);
			if (texture != null)
			{
				texture.SetUIActive(flag);
				if (flag)
				{
					base.SetTextureByPath(data.IconPath, texture, null, null);
				}
			}
		}

		// Token: 0x0200AD68 RID: 44392
		private enum EComponents
		{
			// Token: 0x04035958 RID: 219480
			SprLine,
			// Token: 0x04035959 RID: 219481
			TexElementIcon,
			// Token: 0x0403595A RID: 219482
			TxtName
		}
	}
}
