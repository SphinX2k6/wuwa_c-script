using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027D8 RID: 10200
	[NullableContext(1)]
	[Nullable(0)]
	public class IMotorCatapult : ILeisureInteractType
	{
		// Token: 0x0600E2B7 RID: 58039 RVA: 0x002176EE File Offset: 0x002158EE
		public static IMotorCatapult Create(IMotorCatapult? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorCatapult
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044C9 RID: 17609
		// (get) Token: 0x0600E2B8 RID: 58040 RVA: 0x0021770D File Offset: 0x0021590D
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x170044CA RID: 17610
		// (get) Token: 0x0600E2B9 RID: 58041 RVA: 0x0021771A File Offset: 0x0021591A
		public virtual IMotorCatapultParam Param
		{
			get
			{
				if (this._ParamInited)
				{
					return this._ParamCache;
				}
				this._ParamInited = true;
				this._ParamCache = IMotorCatapultParam.Create(this.Instance.Param);
				return this._ParamCache;
			}
		}

		// Token: 0x170044CB RID: 17611
		// (get) Token: 0x0600E2BA RID: 58042 RVA: 0x00217750 File Offset: 0x00215950
		public virtual EMotorCatapultSkillType? SkillType
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new EMotorCatapultSkillType?((EMotorCatapultSkillType)this.Instance.SkillType);
			}
		}

		// Token: 0x04007DAA RID: 32170
		private IMotorCatapult Instance;

		// Token: 0x04007DAB RID: 32171
		[Nullable(2)]
		private IMotorCatapultParam _ParamCache;

		// Token: 0x04007DAC RID: 32172
		private bool _ParamInited;
	}
}
