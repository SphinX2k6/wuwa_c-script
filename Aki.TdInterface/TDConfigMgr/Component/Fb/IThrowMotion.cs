using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B45 RID: 2885
	public class IThrowMotion
	{
		// Token: 0x0600427B RID: 17019 RVA: 0x000A9FD6 File Offset: 0x000A81D6
		[NullableContext(1)]
		public static IThrowMotion Create(IThrowMotion? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IThrowMotion
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170011AE RID: 4526
		// (get) Token: 0x0600427C RID: 17020 RVA: 0x000A9FF5 File Offset: 0x000A81F5
		public virtual EThrowMotion Type
		{
			get
			{
				return (EThrowMotion)this.Instance.Type;
			}
		}

		// Token: 0x04002574 RID: 9588
		private IThrowMotion Instance;
	}
}
