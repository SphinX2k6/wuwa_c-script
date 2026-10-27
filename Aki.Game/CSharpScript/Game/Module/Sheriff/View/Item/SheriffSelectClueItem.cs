using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Sheriff.View.Item
{
	// Token: 0x02004C71 RID: 19569
	public class SheriffSelectClueItem : GridProxyAbstract<int>
	{
		// Token: 0x06032947 RID: 207175 RVA: 0x00BCA27C File Offset: 0x00BC847C
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

		// Token: 0x06032948 RID: 207176 RVA: 0x00BCA2C4 File Offset: 0x00BC84C4
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			int? curId = this.CurId;
			if (curId.GetValueOrDefault() == data & curId != null)
			{
				return;
			}
			this.CurId = new int?(data);
			UUIItem texture = base.GetTexture(0);
			curId = this.CurId;
			int num = 0;
			texture.SetUIActive(curId.GetValueOrDefault() > num & curId != null);
			curId = this.CurId;
			num = 0;
			if (curId.GetValueOrDefault() <= num & curId != null)
			{
				return;
			}
			SheriffClue? clueConfigById = SheriffConfig.Instance.GetClueConfigById(data);
			if (clueConfigById != null)
			{
				base.SetTextureByPath(clueConfigById.Value.Icon, base.GetTexture(0), null, null);
			}
		}

		// Token: 0x0401AEA2 RID: 110242
		protected int? CurId;

		// Token: 0x0200AE24 RID: 44580
		private static class ESelectClueItem
		{
			// Token: 0x04034E34 RID: 216628
			public const int TexIcon = 0;
		}
	}
}
