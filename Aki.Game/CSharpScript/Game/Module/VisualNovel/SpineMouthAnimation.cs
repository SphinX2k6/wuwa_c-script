using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.SpineMouthAnimation.Struct;
using UnrealEngine;

namespace CSharpScript.Game.Module.VisualNovel
{
	// Token: 0x0200379A RID: 14234
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class SpineMouthAnimation
	{
		// Token: 0x06025055 RID: 151637 RVA: 0x00A74790 File Offset: 0x00A72990
		public SpineMouthAnimation(BP_SpineMouthAnimation_C asset)
		{
			this.DurationMs = asset.DurationMs;
			TArray<SSpineMouthKey> keys = asset.Keys;
			this.Keys = new SSpineMouthKey[keys.Count];
			for (int i = 0; i < keys.Count; i++)
			{
				this.Keys[i] = keys[i];
			}
		}

		// Token: 0x06025056 RID: 151638 RVA: 0x00A747EC File Offset: 0x00A729EC
		public EVisualNovelMouthShape GetShape(int positionMs)
		{
			if (positionMs < 0 || positionMs >= this.DurationMs || this.Keys.Length == 0)
			{
				return EVisualNovelMouthShape.Closed;
			}
			int i = 0;
			int num = this.Keys.Length - 1;
			while (i <= num)
			{
				int num2 = i + (num - i) / 2;
				if (this.Keys[num2].TimeMs <= positionMs)
				{
					i = num2 + 1;
				}
				else
				{
					num = num2 - 1;
				}
			}
			if (num < 0)
			{
				return EVisualNovelMouthShape.Closed;
			}
			byte b = this.Keys[num].Shape;
			if (b > 2)
			{
				return EVisualNovelMouthShape.Closed;
			}
			return (EVisualNovelMouthShape)b;
		}

		// Token: 0x040147A6 RID: 83878
		private readonly int DurationMs;

		// Token: 0x040147A7 RID: 83879
		private readonly SSpineMouthKey[] Keys;
	}
}
