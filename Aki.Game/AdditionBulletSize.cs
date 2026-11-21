using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020024A0 RID: 9376
[NullableContext(1)]
[Nullable(0)]
public class AdditionBulletSize : BuffEffect
{
	// Token: 0x06017575 RID: 95605 RVA: 0x006DE9A8 File Offset: 0x006DCBA8
	public AdditionBulletSize(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06017576 RID: 95606 RVA: 0x006DE9CD File Offset: 0x006DCBCD
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x06017577 RID: 95607 RVA: 0x006DE9D0 File Offset: 0x006DCBD0
	protected unsafe override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		int num = (extraEffectParameters_ != null) ? extraEffectParameters_.Length : 0;
		for (int i = 0; i < num; i++)
		{
			string text = extraEffectParameters_[i];
			string[] array = text.Split('#', StringSplitOptions.None);
			if (array.Length < 4)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.BuffItem;
				ELogAuthor author = ELogAuthor.HCW;
				string message = "参数数量不足, 需要4个";
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
				float item = float.Parse(array[1]);
				float item2 = float.Parse(array[2]);
				float item3 = float.Parse(array[3]);
				this.BulletScaleMap[key] = i * 3;
				this.ScaleArray.Add(item);
				this.ScaleArray.Add(item2);
				this.ScaleArray.Add(item3);
			}
		}
	}

	// Token: 0x06017578 RID: 95608 RVA: 0x006DEB14 File Offset: 0x006DCD14
	[NullableContext(0)]
	public unsafe ValueTuple<float, float, float>? GetBulletSizeScale([Nullable(1)] string bulletRowName)
	{
		int num;
		if (!this.BulletScaleMap.TryGetValue(bulletRowName, out num) || num < 0)
		{
			return null;
		}
		if (num >= this.ScaleArray.Count)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BuffItem;
			ELogAuthor author = ELogAuthor.HCW;
			string message = "获取到的索引超过了参数数量";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Buff", this.BuffId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("参数索引", num);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("参数数量", this.ScaleArray.Count);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("子弹ID", bulletRowName);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			return null;
		}
		int stackCount = base.Buff.StackCount;
		return new ValueTuple<float, float, float>?(new ValueTuple<float, float, float>(this.ScaleArray[num] * (float)stackCount, this.ScaleArray[num + 1] * (float)stackCount, this.ScaleArray[num + 2] * (float)stackCount));
	}

	// Token: 0x0400C5EC RID: 50668
	private const int SIZE_SCALE_PARAMS_LEN = 4;

	// Token: 0x0400C5ED RID: 50669
	private const int SIZE_SCALE_INDEX_BULLETROWNAME = 0;

	// Token: 0x0400C5EE RID: 50670
	private const int SIZE_SCALE_INDEX_X = 1;

	// Token: 0x0400C5EF RID: 50671
	private const int SIZE_SCALE_INDEX_Y = 2;

	// Token: 0x0400C5F0 RID: 50672
	private const int SIZE_SCALE_INDEX_Z = 3;

	// Token: 0x0400C5F1 RID: 50673
	private readonly Dictionary<string, int> BulletScaleMap = new Dictionary<string, int>();

	// Token: 0x0400C5F2 RID: 50674
	private readonly List<float> ScaleArray = new List<float>();
}
