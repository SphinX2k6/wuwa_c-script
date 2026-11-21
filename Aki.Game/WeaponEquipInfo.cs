using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x020025F4 RID: 9716
public class WeaponEquipInfo
{
	// Token: 0x06018393 RID: 99219 RVA: 0x0074ADC0 File Offset: 0x00748FC0
	[NullableContext(1)]
	public unsafe bool SetData(EquipComponentPb pb)
	{
		if (pb.WeaponId == 0 && pb.WeaponBreachLevel == 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "[武器组件]获取武器配置失败 pb";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("weaponId", pb.WeaponId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("WeaponBreachLevel", pb.WeaponBreachLevel);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		if (this.WeaponId != pb.WeaponId)
		{
			this.WeaponId = pb.WeaponId;
			WeaponConf? weaponConfigByItemId = WeaponConfig.Instance.GetWeaponConfigByItemId(this.WeaponId);
			if (weaponConfigByItemId == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Character;
				ELogAuthor author2 = ELogAuthor.LJM;
				string message2 = "[武器组件]获取武器配置失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("weaponId", this.WeaponId);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			this._WeaponConfig = weaponConfigByItemId;
		}
		this.WeaponBreachLevel = pb.WeaponBreachLevel;
		return true;
	}

	// Token: 0x0400D0C7 RID: 53447
	public int WeaponId;

	// Token: 0x0400D0C8 RID: 53448
	public WeaponConf? _WeaponConfig;

	// Token: 0x0400D0C9 RID: 53449
	public int WeaponBreachLevel;
}
