using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LifePoint
{
	// Token: 0x02006ACF RID: 27343
	public class AnimTask : IStaticVariableResetter
	{
		// Token: 0x06043EED RID: 278253 RVA: 0x010A811D File Offset: 0x010A631D
		static AnimTask()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(AnimTask.CreateStaticDefaultValue), new Action(AnimTask.ResetStaticDefaultValue));
		}

		// Token: 0x06043EEE RID: 278254 RVA: 0x010A813C File Offset: 0x010A633C
		[NullableContext(1)]
		public static AnimTask Get(float time, EPieceColorType color, float directionParam, float playRate, int order)
		{
			AnimTask animTask = AnimTask.Pool.Get();
			if (animTask == null)
			{
				animTask = AnimTask.Pool.Create();
			}
			animTask.Time = time;
			animTask.Color = color;
			animTask.DirectionParam = directionParam;
			animTask.PlayRate = playRate;
			animTask.Order = order;
			return animTask;
		}

		// Token: 0x06043EEF RID: 278255 RVA: 0x010A8187 File Offset: 0x010A6387
		public void Recycle()
		{
			AnimTask.Pool.Put(this);
		}

		// Token: 0x06043EF0 RID: 278256 RVA: 0x010A8195 File Offset: 0x010A6395
		public static void CreateStaticDefaultValue()
		{
			AnimTask.Pool = new Pool<AnimTask>(80, () => new AnimTask(), null);
		}

		// Token: 0x06043EF1 RID: 278257 RVA: 0x010A81C3 File Offset: 0x010A63C3
		public static void ResetStaticDefaultValue()
		{
			AnimTask.Pool = null;
		}

		// Token: 0x04023824 RID: 145444
		public float Time;

		// Token: 0x04023825 RID: 145445
		public EPieceColorType Color;

		// Token: 0x04023826 RID: 145446
		public float DirectionParam;

		// Token: 0x04023827 RID: 145447
		public float PlayRate = 1f;

		// Token: 0x04023828 RID: 145448
		public int Order;

		// Token: 0x04023829 RID: 145449
		[Nullable(1)]
		public static Pool<AnimTask> Pool;
	}
}
