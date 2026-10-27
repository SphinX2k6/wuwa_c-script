using System;
using System.Runtime.CompilerServices;

// Token: 0x0200017F RID: 383
internal class TurningParams
{
	// Token: 0x06001848 RID: 6216 RVA: 0x000815F3 File Offset: 0x0007F7F3
	public TurningParams(float totalTime)
	{
		this.TotalTime = totalTime;
	}

	// Token: 0x06001849 RID: 6217 RVA: 0x00081604 File Offset: 0x0007F804
	[NullableContext(1)]
	public unsafe void CalcTurningRate(CharacterActorComponent actorComp, float startTime, float deltaTime)
	{
		CharacterAnimationComponent component = actorComp.Entity.GetComponent<CharacterAnimationComponent>();
		this.EndAngle = component.MainAnimInstance.GetMainAnimsCurveValueWithDelta(CharacterNameDefines.Instance.ROOT_LOOK, this.TotalTime - startTime, false, false);
		this.StartAngle = component.MainAnimInstance.GetMainAnimsCurveValueWithDelta(CharacterNameDefines.Instance.ROOT_LOOK, 0f, false, false);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Test;
		ELogAuthor author = ELogAuthor.LCZ;
		string message = "TurnAdd 1058338";
		<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", actorComp.Entity.Id);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("endAngle", this.EndAngle);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("startTime", startTime);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("startAngle", this.StartAngle);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		float num = this.EndAngle - this.StartAngle;
		if (MathUtils.Instance.IsNearlyZero((double)num, null))
		{
			return;
		}
		float num2 = MathUtils.Instance.WrapAngle(GravityUtils.Instance.GetAngleOffsetFromCurrentToInput(actorComp));
		float num3 = this.IsRootMotionValid ? (num2 - num) : num2;
		float addRate = num3 / num;
		this.AddRate = addRate;
		this.NeedTurn = true;
		this.PreFrameAngle = this.StartAngle;
		this.IsInit = true;
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.Test;
		ELogAuthor author2 = ELogAuthor.LCZ;
		string message2 = "TurnAdd 1058338";
		<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray5<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("EntityId", actorComp.Entity.Id);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("needAddAngle", num3);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("Current", actorComp.ActorRotationProxy);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("Input", actorComp.InputRotatorProxy);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 4) = new ValueTuple<string, object>("Delta", num2);
		instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 5));
	}

	// Token: 0x0400103C RID: 4156
	public bool NeedTurn;

	// Token: 0x0400103D RID: 4157
	public float AddRate;

	// Token: 0x0400103E RID: 4158
	public float TotalTime;

	// Token: 0x0400103F RID: 4159
	public float StartAngle;

	// Token: 0x04001040 RID: 4160
	public float EndAngle;

	// Token: 0x04001041 RID: 4161
	public float PreFrameAngle;

	// Token: 0x04001042 RID: 4162
	public bool IsInit;

	// Token: 0x04001043 RID: 4163
	public bool IsRootMotionValid;
}
