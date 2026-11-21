using System;

namespace System.Reflection.Emit
{
	// Token: 0x020007AB RID: 1963
	internal interface ITokenGenerator
	{
		// Token: 0x06007D83 RID: 32131
		int GetToken(string str);

		// Token: 0x06007D84 RID: 32132
		int GetToken(MemberInfo member, bool create_open_instance);

		// Token: 0x06007D85 RID: 32133
		int GetToken(MethodBase method, Type[] opt_param_types);

		// Token: 0x06007D86 RID: 32134
		int GetToken(SignatureHelper helper);
	}
}
