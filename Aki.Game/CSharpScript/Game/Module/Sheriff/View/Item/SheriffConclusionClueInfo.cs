using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Sheriff.View.Item
{
	// Token: 0x02003C1E RID: 15390
	public class SheriffConclusionClueInfo : GridProxyAbstract<int>
	{
		// Token: 0x060276E1 RID: 161505 RVA: 0x00B0E5E4 File Offset: 0x00B0C7E4
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

		// Token: 0x060276E2 RID: 161506 RVA: 0x00B0E62C File Offset: 0x00B0C82C
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			SheriffClue? clueConfigById = SheriffConfig.Instance.GetClueConfigById(data);
			if (clueConfigById == null)
			{
				return;
			}
			base.SetTextureByPath(clueConfigById.Value.Icon, base.GetTexture(0), null, null);
		}

		// Token: 0x0200983E RID: 38974
		private static class EClueInfo
		{
			// Token: 0x0402F7C7 RID: 194503
			public const int TexIcon = 0;
		}
	}
}
