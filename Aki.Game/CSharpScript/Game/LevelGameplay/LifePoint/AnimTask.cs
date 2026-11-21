using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LifePoint
{
	// Token: 0x02005C47 RID: 23623
	public class AnimTask : IStaticVariableResetter
	{
		// Token: 0x0603A036 RID: 237622 RVA: 0x010517CD File Offset: 0x0104F9CD
		static AnimTask()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(AnimTask.CreateStaticDefaultValue), new Action(AnimTask.ResetStaticDefaultValue));
		}

		// Token: 0x0603A037 RID: 237623 RVA: 0x010517EC File Offset: 0x0104F9EC
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

		// Token: 0x0603A038 RID: 237624 RVA: 0x01051837 File Offset: 0x0104FA37
		public void Recycle()
		{
			AnimTask.Pool.Put(this);
		}

		// Token: 0x0603A039 RID: 237625 RVA: 0x01051845 File Offset: 0x0104FA45
		public static void CreateStaticDefaultValue()
		{
			AnimTask.Pool = new Pool<AnimTask>(80, () => new AnimTask(), null);
		}

		// Token: 0x0603A03A RID: 237626 RVA: 0x01051873 File Offset: 0x0104FA73
		public static void ResetStaticDefaultValue()
		{
			AnimTask.Pool = null;
		}

		// Token: 0x0401EAC4 RID: 125636
		public float Time;

		// Token: 0x0401EAC5 RID: 125637
		public EPieceColorType Color;

		// Token: 0x0401EAC6 RID: 125638
		public float DirectionParam;

		// Token: 0x0401EAC7 RID: 125639
		public float PlayRate = 1f;

		// Token: 0x0401EAC8 RID: 125640
		public int Order;

		// Token: 0x0401EAC9 RID: 125641
		[Nullable(1)]
		public static Pool<AnimTask> Pool;
	}
}
