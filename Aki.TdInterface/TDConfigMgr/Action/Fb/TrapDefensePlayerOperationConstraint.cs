using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A8E RID: 10894
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefensePlayerOperationConstraint : ActionParams
	{
		// Token: 0x0600EF57 RID: 61271 RVA: 0x0022CC60 File Offset: 0x0022AE60
		public static TrapDefensePlayerOperationConstraint Create(ITrapDefensePlayerOperationConstraint? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TrapDefensePlayerOperationConstraint
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004BFD RID: 19453
		// (get) Token: 0x0600EF58 RID: 61272 RVA: 0x0022CC7F File Offset: 0x0022AE7F
		public virtual ITrapDefensePlayerOperationType DisableOperation
		{
			get
			{
				if (this._DisableOperationInited)
				{
					return this._DisableOperationCache;
				}
				this._DisableOperationInited = true;
				this._DisableOperationCache = ActionReadHelper.ReadTrapDefensePlayerOperationConstraint_DisableOperation(this.Instance);
				return this._DisableOperationCache;
			}
		}

		// Token: 0x17004BFE RID: 19454
		// (get) Token: 0x0600EF59 RID: 61273 RVA: 0x0022CCAE File Offset: 0x0022AEAE
		public virtual bool IsConstrained
		{
			get
			{
				return this.Instance.IsConstrained;
			}
		}

		// Token: 0x17004BFF RID: 19455
		// (get) Token: 0x0600EF5A RID: 61274 RVA: 0x0022CCBB File Offset: 0x0022AEBB
		public virtual string TidPromptTxt
		{
			get
			{
				return this.Instance.TidPromptTxt;
			}
		}

		// Token: 0x17004C00 RID: 19456
		// (get) Token: 0x0600EF5B RID: 61275 RVA: 0x0022CCC8 File Offset: 0x0022AEC8
		[Nullable(2)]
		public virtual string EdTidPromptTxt
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x040083AE RID: 33710
		private ITrapDefensePlayerOperationConstraint Instance;

		// Token: 0x040083AF RID: 33711
		private ITrapDefensePlayerOperationType _DisableOperationCache;

		// Token: 0x040083B0 RID: 33712
		private bool _DisableOperationInited;
	}
}
