using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200298C RID: 10636
	public class IPerformerAiMoveConfig
	{
		// Token: 0x0600EB86 RID: 60294 RVA: 0x00227282 File Offset: 0x00225482
		[NullableContext(1)]
		public static IPerformerAiMoveConfig Create(IPerformerAiMoveConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPerformerAiMoveConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A30 RID: 18992
		// (get) Token: 0x0600EB87 RID: 60295 RVA: 0x002272A1 File Offset: 0x002254A1
		public virtual EPerformerAiMoveToType Type
		{
			get
			{
				return (EPerformerAiMoveToType)this.Instance.Type;
			}
		}

		// Token: 0x040081B6 RID: 33206
		private IPerformerAiMoveConfig Instance;
	}
}
