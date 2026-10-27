using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AF6 RID: 2806
	public class IMechHookConfigType
	{
		// Token: 0x0600409A RID: 16538 RVA: 0x000A5356 File Offset: 0x000A3556
		[NullableContext(1)]
		public static IMechHookConfigType Create(IMechHookConfigType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechHookConfigType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700106B RID: 4203
		// (get) Token: 0x0600409B RID: 16539 RVA: 0x000A5375 File Offset: 0x000A3575
		public virtual EMechHookConfigType Type
		{
			get
			{
				return (EMechHookConfigType)this.Instance.Type;
			}
		}

		// Token: 0x04002421 RID: 9249
		private IMechHookConfigType Instance;
	}
}
