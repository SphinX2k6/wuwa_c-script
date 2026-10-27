using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E44 RID: 3652
	public class IGraph3dEffectBase
	{
		// Token: 0x06005281 RID: 21121 RVA: 0x000CB1D2 File Offset: 0x000C93D2
		[NullableContext(1)]
		public static IGraph3dEffectBase Create(IGraph3dEffectBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGraph3dEffectBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001BB6 RID: 7094
		// (get) Token: 0x06005282 RID: 21122 RVA: 0x000CB1F1 File Offset: 0x000C93F1
		public virtual EGraph3dEffectType Type
		{
			get
			{
				return (EGraph3dEffectType)this.Instance.Type;
			}
		}

		// Token: 0x04002F8F RID: 12175
		private IGraph3dEffectBase Instance;
	}
}
