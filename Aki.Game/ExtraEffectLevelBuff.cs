using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002490 RID: 9360
[NullableContext(1)]
[Nullable(0)]
public class ExtraEffectLevelBuff : BuffEffect
{
	// Token: 0x060174FD RID: 95485 RVA: 0x006DBA70 File Offset: 0x006D9C70
	public ExtraEffectLevelBuff(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x060174FE RID: 95486 RVA: 0x006DBA80 File Offset: 0x006D9C80
	protected unsafe override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		if (extraEffectParameters_ == null || extraEffectParameters_.Length == 0)
		{
			return;
		}
		string text = extraEffectParameters_[0];
		int num = extraEffectParameters_.Length - 1;
		string[] array = (num > 0) ? new string[num] : Array.Empty<string>();
		for (int i = 1; i < extraEffectParameters_.Length; i++)
		{
			array[i - 1] = extraEffectParameters_[i];
		}
		float levelValue = AbilityUtils.GetLevelValue<float>(parameters.ExtraEffectGrowParameters1, this.Level, 0f);
		float levelValue2 = AbilityUtils.GetLevelValue<float>(parameters.ExtraEffectGrowParameters2, this.Level, 0f);
		Func<Entity, long, string[], float, float, LevelBuffBase> func;
		if (!ExtraEffectLevelBuff._levelBuffFactoryMap.TryGetValue(text, out func))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Level;
			ELogAuthor author = ELogAuthor.HXY;
			string message = "没有注册玩法效果";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ClassName", text);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Buff", this.BuffId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		this._levelBuff = func(base.OwnerEntity, this.BuffId, array, levelValue, levelValue2);
	}

	// Token: 0x060174FF RID: 95487 RVA: 0x006DBB8F File Offset: 0x006D9D8F
	public override void OnCreated()
	{
		LevelBuffBase levelBuff = this._levelBuff;
		if (levelBuff == null)
		{
			return;
		}
		levelBuff.OnCreated();
	}

	// Token: 0x06017500 RID: 95488 RVA: 0x006DBBA1 File Offset: 0x006D9DA1
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x06017501 RID: 95489 RVA: 0x006DBBA4 File Offset: 0x006D9DA4
	public override void OnRemoved(bool bPremature)
	{
		LevelBuffBase levelBuff = this._levelBuff;
		if (levelBuff == null)
		{
			return;
		}
		levelBuff.OnRemoved(bPremature);
	}

	// Token: 0x06017502 RID: 95490 RVA: 0x006DBBB7 File Offset: 0x006D9DB7
	public override void OnStackIncreased(int newCount, int oldCount, long? instigatorId)
	{
		LevelBuffBase levelBuff = this._levelBuff;
		if (levelBuff == null)
		{
			return;
		}
		levelBuff.OnStackChanged(newCount, oldCount, false);
	}

	// Token: 0x06017503 RID: 95491 RVA: 0x006DBBCC File Offset: 0x006D9DCC
	public override void OnStackDecreased(int newCount, int oldCount, bool bPremature)
	{
		LevelBuffBase levelBuff = this._levelBuff;
		if (levelBuff == null)
		{
			return;
		}
		levelBuff.OnStackChanged(newCount, oldCount, bPremature);
	}

	// Token: 0x06017504 RID: 95492 RVA: 0x006DBBE4 File Offset: 0x006D9DE4
	// Note: this type is marked as 'beforefieldinit'.
	static ExtraEffectLevelBuff()
	{
		Dictionary<string, Func<Entity, long, string[], float, float, LevelBuffBase>> dictionary = new Dictionary<string, Func<Entity, long, string[], float, float, LevelBuffBase>>();
		dictionary["LevelBuffSceneItem"] = ((Entity entity, long buffId, string[] @params, float param1, float param2) => new LevelBuffSceneItem(entity, buffId, @params, param1, param2));
		dictionary["LevelBuffSetWalkableFloorAngle"] = ((Entity entity, long buffId, string[] @params, float param1, float param2) => new LevelBuffSetWalkableFloorAngle(entity, buffId, @params, param1, param2));
		ExtraEffectLevelBuff._levelBuffFactoryMap = dictionary;
	}

	// Token: 0x0400C5C1 RID: 50625
	[StaticVariableRuleIgnore]
	private static readonly Dictionary<string, Func<Entity, long, string[], float, float, LevelBuffBase>> _levelBuffFactoryMap;

	// Token: 0x0400C5C2 RID: 50626
	[Nullable(2)]
	private LevelBuffBase _levelBuff;
}
