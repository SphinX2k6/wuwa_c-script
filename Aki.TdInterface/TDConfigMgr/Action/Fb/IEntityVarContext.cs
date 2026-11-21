using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200278D RID: 10125
	public class IEntityVarContext : IVarContext
	{
		// Token: 0x0600E045 RID: 57413 RVA: 0x0021029E File Offset: 0x0020E49E
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

		// Token: 0x17003DD9 RID: 15833
		// (get) Token: 0x0600E046 RID: 57414 RVA: 0x002102BD File Offset: 0x0020E4BD
		public override EVarContext Type
		{
			get
			{
				return (EVarContext)this.Instance.Type;
			}
		}

		// Token: 0x17003DDA RID: 15834
		// (get) Token: 0x0600E047 RID: 57415 RVA: 0x002102CA File Offset: 0x0020E4CA
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17003DDB RID: 15835
		// (get) Token: 0x0600E048 RID: 57416 RVA: 0x002102D8 File Offset: 0x0020E4D8
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

		// Token: 0x040079FF RID: 31231
		private IEntityVarContext Instance;
	}
}
