using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x020053A0 RID: 21408
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MoraleAreaProgressPointItem : GridProxyAbstract<MoraleAreaProgressData>
	{
		// Token: 0x06036B26 RID: 224038 RVA: 0x00CF204C File Offset: 0x00CF024C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06036B27 RID: 224039 RVA: 0x00CF2094 File Offset: 0x00CF0294
		public override void Refresh(MoraleAreaProgressData data, bool isSelected, int gridIndex)
		{
			this.ItemData = data;
			this.SetUiProgressByScore(data.StartScore);
		}

		// Token: 0x06036B28 RID: 224040 RVA: 0x00CF20A9 File Offset: 0x00CF02A9
		private void SetPointShow(bool show)
		{
			UUIItem item = base.GetItem(0);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(show);
		}

		// Token: 0x06036B29 RID: 224041 RVA: 0x00CF20C0 File Offset: 0x00CF02C0
		public void SetUiProgressByScore(int score)
		{
			bool pointShow = score >= this.ItemData.TargetScore;
			this.SetPointShow(pointShow);
		}

		// Token: 0x0401CE35 RID: 118325
		public MoraleAreaProgressData ItemData;

		// Token: 0x0401CE36 RID: 118326
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<MoraleAreaProgressData> ClickCallBack;

		// Token: 0x0200B61A RID: 46618
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04037296 RID: 225942
			ItemPoint
		}
	}
}
