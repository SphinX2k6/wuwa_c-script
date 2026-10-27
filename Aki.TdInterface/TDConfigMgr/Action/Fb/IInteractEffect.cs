using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002845 RID: 10309
	public class IInteractEffect
	{
		// Token: 0x0600E48A RID: 58506 RVA: 0x0021A226 File Offset: 0x00218426
		[NullableContext(1)]
		public static IInteractEffect Create(IInteractEffect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractEffect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045C2 RID: 17858
		// (get) Token: 0x0600E48B RID: 58507 RVA: 0x0021A245 File Offset: 0x00218445
		public virtual EInteractEffectType Type
		{
			get
			{
				return (EInteractEffectType)this.Instance.Type;
			}
		}

		// Token: 0x170045C3 RID: 17859
		// (get) Token: 0x0600E48C RID: 58508 RVA: 0x0021A254 File Offset: 0x00218454
		public virtual float? DelayTime
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.DelayTime);
			}
		}

		// Token: 0x04007E6F RID: 32367
		private IInteractEffect Instance;
	}
}
