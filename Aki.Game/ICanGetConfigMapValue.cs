using System;
using System.Runtime.CompilerServices;

// Token: 0x020001F4 RID: 500
[NullableContext(1)]
public interface ICanGetConfigMapValue
{
	// Token: 0x06001F83 RID: 8067
	string GetConfigMapValue(int key);

	// Token: 0x06001F84 RID: 8068
	bool GetPairConfigKey<[Nullable(0)] T>(T key, out T pairKey) where T : Enum;

	// Token: 0x06001F85 RID: 8069
	bool GetPairConfigKey(int key, out int pairKey);

	// Token: 0x06001F86 RID: 8070
	float GetConfigValue(string key);
}
