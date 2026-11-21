using System;
using System.Runtime.CompilerServices;

// Token: 0x020001F8 RID: 504
[NullableContext(1)]
public interface ICanGetConfigMapValue
{
	// Token: 0x06002032 RID: 8242
	string GetConfigMapValue(int key);

	// Token: 0x06002033 RID: 8243
	bool GetPairConfigKey<[Nullable(0)] T>(T key, out T pairKey) where T : Enum;

	// Token: 0x06002034 RID: 8244
	bool GetPairConfigKey(int key, out int pairKey);

	// Token: 0x06002035 RID: 8245
	float GetConfigValue(string key);
}
