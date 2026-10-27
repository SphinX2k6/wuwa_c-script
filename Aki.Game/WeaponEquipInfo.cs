using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x0200309D RID: 12445
public class WeaponEquipInfo
{
	// Token: 0x0601A995 RID: 108949 RVA: 0x00724FB4 File Offset: 0x007231B4
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

	// Token: 0x0400CCE4 RID: 52452
	public int WeaponId;

	// Token: 0x0400CCE5 RID: 52453
	public WeaponConf? _WeaponConfig;

	// Token: 0x0400CCE6 RID: 52454
	public int WeaponBreachLevel;
}
