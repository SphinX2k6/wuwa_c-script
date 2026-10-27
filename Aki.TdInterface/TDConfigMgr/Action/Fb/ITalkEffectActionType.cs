using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200253B RID: 9531
	public class ITalkEffectActionType
	{
		// Token: 0x0600D468 RID: 54376 RVA: 0x001F712E File Offset: 0x001F532E
		[NullableContext(1)]
		public static ITalkEffectActionType Create(ITalkEffectActionType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkEffectActionType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003BB4 RID: 15284
		// (get) Token: 0x0600D469 RID: 54377 RVA: 0x001F714D File Offset: 0x001F534D
		public virtual ETalkEffectActionType Type
		{
			get
			{
				return (ETalkEffectActionType)this.Instance.Type;
			}
		}

		// Token: 0x04007459 RID: 29785
		private ITalkEffectActionType Instance;
	}
}
