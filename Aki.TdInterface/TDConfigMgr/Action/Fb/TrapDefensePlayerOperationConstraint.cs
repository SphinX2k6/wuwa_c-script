using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D82 RID: 11650
	public class TrapDefensePlayerOperationConstraint : ActionParams
	{
		// Token: 0x0600FE0D RID: 65037 RVA: 0x0024A96C File Offset: 0x00248B6C
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

		// Token: 0x17004FB7 RID: 20407
		// (get) Token: 0x0600FE0E RID: 65038 RVA: 0x0024A98B File Offset: 0x00248B8B
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

		// Token: 0x17004FB8 RID: 20408
		// (get) Token: 0x0600FE0F RID: 65039 RVA: 0x0024A9BA File Offset: 0x00248BBA
		public virtual bool IsConstrained
		{
			get
			{
				return this.Instance.IsConstrained;
			}
		}

		// Token: 0x17004FB9 RID: 20409
		// (get) Token: 0x0600FE10 RID: 65040 RVA: 0x0024A9C7 File Offset: 0x00248BC7
		public virtual string TidPromptTxt
		{
			get
			{
				return this.Instance.TidPromptTxt;
			}
		}

		// Token: 0x17004FBA RID: 20410
		// (get) Token: 0x0600FE11 RID: 65041 RVA: 0x0024A9D4 File Offset: 0x00248BD4
		[Nullable(2)]
		public virtual string EdTidPromptTxt
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x04008AB2 RID: 35506
		private ITrapDefensePlayerOperationConstraint Instance;

		// Token: 0x04008AB3 RID: 35507
		private ITrapDefensePlayerOperationType _DisableOperationCache;

		// Token: 0x04008AB4 RID: 35508
		private bool _DisableOperationInited;
	}
}
