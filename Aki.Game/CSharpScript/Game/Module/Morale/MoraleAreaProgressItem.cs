using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x02004382 RID: 17282
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MoraleAreaProgressItem : GridProxyAbstract<MoraleAreaProgressData>
	{
		// Token: 0x0602BA66 RID: 178790 RVA: 0x00C4102C File Offset: 0x00C3F22C
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

		// Token: 0x0602BA67 RID: 178791 RVA: 0x00C41074 File Offset: 0x00C3F274
		public override void Refresh(MoraleAreaProgressData data, bool isSelected, int gridIndex)
		{
			this.ItemData = data;
			this.SetUiProgressByScore(data.StartScore);
		}

		// Token: 0x0602BA68 RID: 178792 RVA: 0x00C41089 File Offset: 0x00C3F289
		private float GetProgress(int score)
		{
			if (score >= this.ItemData.TargetScore)
			{
				return 1f;
			}
			return (float)(score - this.ItemData.LastTargetScore) / (float)(this.ItemData.TargetScore - this.ItemData.LastTargetScore);
		}

		// Token: 0x0602BA69 RID: 178793 RVA: 0x00C410C6 File Offset: 0x00C3F2C6
		private void SetUiProgress(float percent)
		{
			UUISprite sprite = base.GetSprite(0);
			if (sprite == null)
			{
				return;
			}
			sprite.SetFillAmount(percent);
		}

		// Token: 0x0602BA6A RID: 178794 RVA: 0x00C410DA File Offset: 0x00C3F2DA
		public void SetUiProgressByScore(int score)
		{
			this.SetUiProgress(this.GetProgress(score));
		}

		// Token: 0x040178CC RID: 96460
		public MoraleAreaProgressData ItemData;

		// Token: 0x0200A051 RID: 41041
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04031CE9 RID: 204009
			SpriteProgress
		}
	}
}
