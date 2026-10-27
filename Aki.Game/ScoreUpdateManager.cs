using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020000D7 RID: 215
[NullableContext(1)]
[Nullable(0)]
public class ScoreUpdateManager
{
	// Token: 0x06000CD6 RID: 3286 RVA: 0x00043F8E File Offset: 0x0004218E
	public ScoreUpdateManager(float maxUpdateValue = 0.5f, int maxUpdateCount = 5)
	{
		this.MaxUpdateValue = maxUpdateValue;
		this.MaxUpdateCount = maxUpdateCount;
	}

	// Token: 0x06000CD7 RID: 3287 RVA: 0x00043FBC File Offset: 0x000421BC
	public void AddScore(IScoreUpdateObject obj, int addScore = 1)
	{
		if (addScore < 1)
		{
			Log.Instance.Error(ELogModule.AI, ELogAuthor.LCZ, "AddScore is less than 1", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		int num;
		if (this.ObjectScores.TryGetValue(obj, out num))
		{
			this.Objects[num].Remove(obj);
		}
		int num2 = (num > 0) ? (num + addScore) : addScore;
		if (this.MaxScore < num2)
		{
			this.MaxScore = num2;
		}
		while (this.Objects.Count <= num2)
		{
			this.Objects.Add(new HashSet<IScoreUpdateObject>());
		}
		this.Objects[num2].Add(obj);
		this.ObjectScores[obj] = num2;
	}

	// Token: 0x06000CD8 RID: 3288 RVA: 0x00044068 File Offset: 0x00042268
	public void RemoveObject(IScoreUpdateObject obj)
	{
		int index;
		if (this.ObjectScores.TryGetValue(obj, out index))
		{
			this.Objects[index].Remove(obj);
		}
		this.ObjectScores.Remove(obj);
	}

	// Token: 0x06000CD9 RID: 3289 RVA: 0x000440A8 File Offset: 0x000422A8
	public unsafe void Update()
	{
		if (this.MaxScore == 0)
		{
			return;
		}
		float num = 0f;
		int num2 = 0;
		for (int i = this.MaxScore; i > 0; i--)
		{
			HashSet<IScoreUpdateObject> hashSet = this.Objects[i];
			float num3 = 1f / (float)i;
			foreach (IScoreUpdateObject scoreUpdateObject in new HashSet<IScoreUpdateObject>(hashSet))
			{
				try
				{
					scoreUpdateObject.ScoreUpdate();
				}
				catch (Exception ex)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.AI;
					ELogAuthor author = ELogAuthor.LCZ;
					string message = "ScoreUpdate执行异常";
					Exception error = ex;
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ScoreObject", scoreUpdateObject.GetType().Name);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("error", ex.Message);
					instance.ErrorWithStack(module, author, message, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
				this.ObjectScores[scoreUpdateObject] = 0;
				hashSet.Remove(scoreUpdateObject);
				num += num3;
				num2++;
				if (num >= this.MaxUpdateValue || num2 >= this.MaxUpdateCount)
				{
					return;
				}
			}
			this.MaxScore--;
		}
	}

	// Token: 0x04000A27 RID: 2599
	[StaticVariableRuleIgnore]
	private static readonly Stat StatObj = Stat.Create("ScoreUpdate AiPerception", "", "");

	// Token: 0x04000A28 RID: 2600
	private readonly List<HashSet<IScoreUpdateObject>> Objects = new List<HashSet<IScoreUpdateObject>>();

	// Token: 0x04000A29 RID: 2601
	private readonly Dictionary<IScoreUpdateObject, int> ObjectScores = new Dictionary<IScoreUpdateObject, int>();

	// Token: 0x04000A2A RID: 2602
	private int MaxScore;

	// Token: 0x04000A2B RID: 2603
	private readonly float MaxUpdateValue;

	// Token: 0x04000A2C RID: 2604
	private readonly int MaxUpdateCount;
}
