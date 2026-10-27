using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D1F RID: 3359
	public class ISceneTextTypeBase
	{
		// Token: 0x06004CAA RID: 19626 RVA: 0x000BEF01 File Offset: 0x000BD101
		[NullableContext(1)]
		public static ISceneTextTypeBase Create(ISceneTextTypeBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneTextTypeBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001829 RID: 6185
		// (get) Token: 0x06004CAB RID: 19627 RVA: 0x000BEF20 File Offset: 0x000BD120
		public virtual ESceneTextType Type
		{
			get
			{
				return (ESceneTextType)this.Instance.Type;
			}
		}

		// Token: 0x04002BE4 RID: 11236
		private ISceneTextTypeBase Instance;
	}
}
