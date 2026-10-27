using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D31 RID: 3377
	[NullableContext(1)]
	[Nullable(0)]
	public class AiGearStrategyComponent : IComponentBase
	{
		// Token: 0x06004D0F RID: 19727 RVA: 0x000BFBE5 File Offset: 0x000BDDE5
		public static AiGearStrategyComponent Create(IAiGearStrategyComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AiGearStrategyComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700186A RID: 6250
		// (get) Token: 0x06004D10 RID: 19728 RVA: 0x000BFC04 File Offset: 0x000BDE04
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x1700186B RID: 6251
		// (get) Token: 0x06004D11 RID: 19729 RVA: 0x000BFC3C File Offset: 0x000BDE3C
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700186C RID: 6252
		// (get) Token: 0x06004D12 RID: 19730 RVA: 0x000BFC52 File Offset: 0x000BDE52
		public virtual IAiGearStrategy StrategyType
		{
			get
			{
				if (this._StrategyTypeInited)
				{
					return this._StrategyTypeCache;
				}
				this._StrategyTypeInited = true;
				this._StrategyTypeCache = ComponentReadHelper.ReadAiGearStrategyComponent_StrategyType(this.Instance);
				return this._StrategyTypeCache;
			}
		}

		// Token: 0x04002C28 RID: 11304
		private IAiGearStrategyComponent Instance;

		// Token: 0x04002C29 RID: 11305
		private IAiGearStrategy _StrategyTypeCache;

		// Token: 0x04002C2A RID: 11306
		private bool _StrategyTypeInited;
	}
}
