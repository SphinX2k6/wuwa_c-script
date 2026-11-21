using System;

namespace System.Reflection.Emit
{
	// Token: 0x020007B3 RID: 1971
	internal sealed class ModuleBuilderTokenGenerator : ITokenGenerator
	{
		// Token: 0x06007E3B RID: 32315 RVA: 0x0012A817 File Offset: 0x00128A17
		public ModuleBuilderTokenGenerator(RuntimeModuleBuilder mb)
		{
			this.mb = mb;
		}

		// Token: 0x06007E3C RID: 32316 RVA: 0x0012A826 File Offset: 0x00128A26
		public int GetToken(string str)
		{
			return this.mb.GetToken(str);
		}

		// Token: 0x06007E3D RID: 32317 RVA: 0x0012A834 File Offset: 0x00128A34
		public int GetToken(MemberInfo member, bool create_open_instance)
		{
			return this.mb.GetToken(member, create_open_instance);
		}

		// Token: 0x06007E3E RID: 32318 RVA: 0x0012A843 File Offset: 0x00128A43
		public int GetToken(MethodBase method, Type[] opt_param_types)
		{
			return this.mb.GetToken(method, opt_param_types);
		}

		// Token: 0x06007E3F RID: 32319 RVA: 0x0012A852 File Offset: 0x00128A52
		public int GetToken(SignatureHelper helper)
		{
			return this.mb.GetToken(helper);
		}

		// Token: 0x0400184E RID: 6222
		private RuntimeModuleBuilder mb;
	}
}
