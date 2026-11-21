using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Sheriff.View.Item
{
	// Token: 0x02003C22 RID: 15394
	public class SheriffSelectClueItem : GridProxyAbstract<int>
	{
		// Token: 0x060276FA RID: 161530 RVA: 0x00B0EEE0 File Offset: 0x00B0D0E0
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

		// Token: 0x060276FB RID: 161531 RVA: 0x00B0EF28 File Offset: 0x00B0D128
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

		// Token: 0x040157FF RID: 88063
		protected int? CurId;

		// Token: 0x02009842 RID: 38978
		private static class ESelectClueItem
		{
			// Token: 0x0402F7D9 RID: 194521
			public const int TexIcon = 0;
		}
	}
}
