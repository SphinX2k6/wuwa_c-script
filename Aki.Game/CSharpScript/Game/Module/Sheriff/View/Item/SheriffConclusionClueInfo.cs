using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Sheriff.View.Item
{
	// Token: 0x02004C6D RID: 19565
	public class SheriffConclusionClueInfo : GridProxyAbstract<int>
	{
		// Token: 0x0603292E RID: 207150 RVA: 0x00BC9980 File Offset: 0x00BC7B80
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603292F RID: 207151 RVA: 0x00BC99C8 File Offset: 0x00BC7BC8
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			SheriffClue? clueConfigById = SheriffConfig.Instance.GetClueConfigById(data);
			if (clueConfigById == null)
			{
				return;
			}
			base.SetTextureByPath(clueConfigById.Value.Icon, base.GetTexture(0), null, null);
		}

		// Token: 0x0200AE20 RID: 44576
		private static class EClueInfo
		{
			// Token: 0x04034E22 RID: 216610
			public const int TexIcon = 0;
		}
	}
}
