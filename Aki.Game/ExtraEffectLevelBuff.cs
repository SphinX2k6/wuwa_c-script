using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002F3D RID: 12093
[NullableContext(1)]
[Nullable(0)]
public class ExtraEffectLevelBuff : BuffEffect
{
	// Token: 0x06019BF2 RID: 105458 RVA: 0x006B5750 File Offset: 0x006B3950
	public ExtraEffectLevelBuff(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06019BF3 RID: 105459 RVA: 0x006B5760 File Offset: 0x006B3960
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

	// Token: 0x06019BF4 RID: 105460 RVA: 0x006B586F File Offset: 0x006B3A6F
	public override void OnCreated()
	{
		LevelBuffBase levelBuff = this._levelBuff;
		if (levelBuff == null)
		{
			return;
		}
		levelBuff.OnCreated();
	}

	// Token: 0x06019BF5 RID: 105461 RVA: 0x006B5881 File Offset: 0x006B3A81
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x06019BF6 RID: 105462 RVA: 0x006B5884 File Offset: 0x006B3A84
	public override void OnRemoved(bool bPremature)
	{
		LevelBuffBase levelBuff = this._levelBuff;
		if (levelBuff == null)
		{
			return;
		}
		levelBuff.OnRemoved(bPremature);
	}

	// Token: 0x06019BF7 RID: 105463 RVA: 0x006B5897 File Offset: 0x006B3A97
	public override void OnStackIncreased(int newCount, int oldCount, long? instigatorId)
	{
		LevelBuffBase levelBuff = this._levelBuff;
		if (levelBuff == null)
		{
			return;
		}
		levelBuff.OnStackChanged(newCount, oldCount, false);
	}

	// Token: 0x06019BF8 RID: 105464 RVA: 0x006B58AC File Offset: 0x006B3AAC
	public override void OnStackDecreased(int newCount, int oldCount, bool bPremature)
	{
		LevelBuffBase levelBuff = this._levelBuff;
		if (levelBuff == null)
		{
			return;
		}
		levelBuff.OnStackChanged(newCount, oldCount, bPremature);
	}

	// Token: 0x06019BF9 RID: 105465 RVA: 0x006B58C4 File Offset: 0x006B3AC4
	// Note: this type is marked as 'beforefieldinit'.
	static ExtraEffectLevelBuff()
	{
		Dictionary<string, Func<Entity, long, string[], float, float, LevelBuffBase>> dictionary = new Dictionary<string, Func<Entity, long, string[], float, float, LevelBuffBase>>();
		dictionary["LevelBuffSceneItem"] = ((Entity entity, long buffId, string[] @params, float param1, float param2) => new LevelBuffSceneItem(entity, buffId, @params, param1, param2));
		dictionary["LevelBuffSetWalkableFloorAngle"] = ((Entity entity, long buffId, string[] @params, float param1, float param2) => new LevelBuffSetWalkableFloorAngle(entity, buffId, @params, param1, param2));
		ExtraEffectLevelBuff._levelBuffFactoryMap = dictionary;
	}

	// Token: 0x0400C21F RID: 49695
	[StaticVariableRuleIgnore]
	private static readonly Dictionary<string, Func<Entity, long, string[], float, float, LevelBuffBase>> _levelBuffFactoryMap;

	// Token: 0x0400C220 RID: 49696
	[Nullable(2)]
	private LevelBuffBase _levelBuff;
}
