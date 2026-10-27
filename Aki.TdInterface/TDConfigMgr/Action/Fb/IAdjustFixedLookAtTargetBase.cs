using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028B7 RID: 10423
	public class IAdjustFixedLookAtTargetBase
	{
		// Token: 0x0600E764 RID: 59236 RVA: 0x0021FB8A File Offset: 0x0021DD8A
		[NullableContext(1)]
		public static IAdjustFixedLookAtTargetBase Create(IAdjustFixedLookAtTargetBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAdjustFixedLookAtTargetBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170047B8 RID: 18360
		// (get) Token: 0x0600E765 RID: 59237 RVA: 0x0021FBA9 File Offset: 0x0021DDA9
		public virtual EFixedLookAtTargetType Type
		{
			get
			{
				return (EFixedLookAtTargetType)this.Instance.Type;
			}
		}

		// Token: 0x04007FE3 RID: 32739
		private IAdjustFixedLookAtTargetBase Instance;
	}
}
