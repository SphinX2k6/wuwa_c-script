using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x0200539F RID: 21407
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MoraleAreaProgressItem : GridProxyAbstract<MoraleAreaProgressData>
	{
		// Token: 0x06036B20 RID: 224032 RVA: 0x00CF1F84 File Offset: 0x00CF0184
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06036B21 RID: 224033 RVA: 0x00CF1FCC File Offset: 0x00CF01CC
		public override void Refresh(MoraleAreaProgressData data, bool isSelected, int gridIndex)
		{
			this.ItemData = data;
			this.SetUiProgressByScore(data.StartScore);
		}

		// Token: 0x06036B22 RID: 224034 RVA: 0x00CF1FE1 File Offset: 0x00CF01E1
		private float GetProgress(int score)
		{
			if (score >= this.ItemData.TargetScore)
			{
				return 1f;
			}
			return (float)(score - this.ItemData.LastTargetScore) / (float)(this.ItemData.TargetScore - this.ItemData.LastTargetScore);
		}

		// Token: 0x06036B23 RID: 224035 RVA: 0x00CF201E File Offset: 0x00CF021E
		private void SetUiProgress(float percent)
		{
			UUISprite sprite = base.GetSprite(0);
			if (sprite == null)
			{
				return;
			}
			sprite.SetFillAmount(percent);
		}

		// Token: 0x06036B24 RID: 224036 RVA: 0x00CF2032 File Offset: 0x00CF0232
		public void SetUiProgressByScore(int score)
		{
			this.SetUiProgress(this.GetProgress(score));
		}

		// Token: 0x0401CE34 RID: 118324
		public MoraleAreaProgressData ItemData;

		// Token: 0x0200B619 RID: 46617
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04037294 RID: 225940
			SpriteProgress
		}
	}
}
