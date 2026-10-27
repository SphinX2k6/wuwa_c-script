using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002F4E RID: 12110
[NullableContext(1)]
[Nullable(0)]
public class AdditionBulletDuration : BuffEffect
{
	// Token: 0x06019C6E RID: 105582 RVA: 0x006B8926 File Offset: 0x006B6B26
	public AdditionBulletDuration(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06019C6F RID: 105583 RVA: 0x006B8940 File Offset: 0x006B6B40
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x06019C70 RID: 105584 RVA: 0x006B8944 File Offset: 0x006B6B44
	protected unsafe override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		int num = (extraEffectParameters_ != null) ? extraEffectParameters_.Length : 0;
		for (int i = 0; i < num; i++)
		{
			string text = extraEffectParameters_[i];
			string[] array = text.Split('#', StringSplitOptions.None);
			if (array.Length < 2)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.BuffItem;
				ELogAuthor author = ELogAuthor.HCW;
				string message = "参数数量不足, 需要2个";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Buff", this.BuffId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("参数", text);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("参数索引", i);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("参数数量", num);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			}
			else
			{
				string key = array[0];
				float value = float.Parse(array[1]);
				this.BulletDurationMap[key] = value;
			}
		}
	}

	// Token: 0x06019C71 RID: 105585 RVA: 0x006B8A4C File Offset: 0x006B6C4C
	public float GetBulletDuration(string bulletRowName)
	{
		float valueOrDefault = this.BulletDurationMap.GetValueOrDefault(bulletRowName, 0f);
		int stackCount = base.Buff.StackCount;
		return valueOrDefault * (float)stackCount;
	}

	// Token: 0x06019C72 RID: 105586 RVA: 0x006B8A7C File Offset: 0x006B6C7C
	public static float ApplyEffects(Entity ownerEntity, string bulletRowName)
	{
		float num = 0f;
		bool flag = false;
		BaseBuffComponent component = ownerEntity.GetComponent<BaseBuffComponent>();
		ExtraEffectManager extraEffectManager = (component != null) ? component.BuffEffectManager : null;
		if (extraEffectManager != null)
		{
			foreach (AdditionBulletDuration additionBulletDuration in extraEffectManager.FilterById<AdditionBulletDuration>(EExtraEffectId.AdditionBulletDuration, null))
			{
				num += additionBulletDuration.GetBulletDuration(bulletRowName);
				flag = true;
			}
		}
		if (flag)
		{
			return num;
		}
		if (component != null && component.IsRoleBuffComponent())
		{
			RoleBuffComponent roleBuffComponent = component as RoleBuffComponent;
			if (roleBuffComponent != null && roleBuffComponent.HasBuffAuthority())
			{
				PlayerBuffComponent formationBuffComp = roleBuffComponent.GetFormationBuffComp();
				if (((formationBuffComp != null) ? formationBuffComp.BuffEffectManager : null) != null)
				{
					foreach (AdditionBulletDuration additionBulletDuration2 in formationBuffComp.BuffEffectManager.FilterById<AdditionBulletDuration>(EExtraEffectId.AdditionBulletDuration, null))
					{
						num += additionBulletDuration2.GetBulletDuration(bulletRowName);
					}
				}
			}
		}
		return num;
	}

	// Token: 0x0400C251 RID: 49745
	private const int DURATION_SCALE_PARAMS_LEN = 2;

	// Token: 0x0400C252 RID: 49746
	private const int DURATION_SCALE_INDEX_BULLETROWNAME = 0;

	// Token: 0x0400C253 RID: 49747
	private const int DURATION_SCALE_INDEX_DURATION = 1;

	// Token: 0x0400C254 RID: 49748
	private readonly Dictionary<string, float> BulletDurationMap = new Dictionary<string, float>();
}
