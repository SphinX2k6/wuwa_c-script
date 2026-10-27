using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024E8 RID: 9448
	public class IEntityVarContext : IVarContext
	{
		// Token: 0x0600D2EF RID: 53999 RVA: 0x001F4A06 File Offset: 0x001F2C06
		[NullableContext(1)]
		public static IEntityVarContext Create(IEntityVarContext? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityVarContext
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003AE1 RID: 15073
		// (get) Token: 0x0600D2F0 RID: 54000 RVA: 0x001F4A25 File Offset: 0x001F2C25
		public override EVarContext Type
		{
			get
			{
				return (EVarContext)this.Instance.Type;
			}
		}

		// Token: 0x17003AE2 RID: 15074
		// (get) Token: 0x0600D2F1 RID: 54001 RVA: 0x001F4A32 File Offset: 0x001F2C32
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17003AE3 RID: 15075
		// (get) Token: 0x0600D2F2 RID: 54002 RVA: 0x001F4A40 File Offset: 0x001F2C40
		public virtual EEntityVarMatchType? MatchType
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new EEntityVarMatchType?((EEntityVarMatchType)this.Instance.MatchType);
			}
		}

		// Token: 0x040073B2 RID: 29618
		private IEntityVarContext Instance;
	}
}
