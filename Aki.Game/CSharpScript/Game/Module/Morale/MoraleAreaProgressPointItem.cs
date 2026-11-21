using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x02004383 RID: 17283
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MoraleAreaProgressPointItem : GridProxyAbstract<MoraleAreaProgressData>
	{
		// Token: 0x0602BA6C RID: 178796 RVA: 0x00C410F4 File Offset: 0x00C3F2F4
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

		// Token: 0x0602BA6D RID: 178797 RVA: 0x00C4113C File Offset: 0x00C3F33C
		public override void Refresh(MoraleAreaProgressData data, bool isSelected, int gridIndex)
		{
			this.ItemData = data;
			this.SetUiProgressByScore(data.StartScore);
		}

		// Token: 0x0602BA6E RID: 178798 RVA: 0x00C41151 File Offset: 0x00C3F351
		private void SetPointShow(bool show)
		{
			UUIItem item = base.GetItem(0);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(show);
		}

		// Token: 0x0602BA6F RID: 178799 RVA: 0x00C41168 File Offset: 0x00C3F368
		public void SetUiProgressByScore(int score)
		{
			bool pointShow = score >= this.ItemData.TargetScore;
			this.SetPointShow(pointShow);
		}

		// Token: 0x040178CD RID: 96461
		public MoraleAreaProgressData ItemData;

		// Token: 0x040178CE RID: 96462
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<MoraleAreaProgressData> ClickCallBack;

		// Token: 0x0200A052 RID: 41042
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04031CEB RID: 204011
			ItemPoint
		}
	}
}
