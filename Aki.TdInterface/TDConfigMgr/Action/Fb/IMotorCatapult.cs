using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AAB RID: 10923
	public class IMotorCatapult : ILeisureInteractType
	{
		// Token: 0x0600F0DB RID: 61659 RVA: 0x00234522 File Offset: 0x00232722
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

		// Token: 0x17004833 RID: 18483
		// (get) Token: 0x0600F0DC RID: 61660 RVA: 0x00234541 File Offset: 0x00232741
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x17004834 RID: 18484
		// (get) Token: 0x0600F0DD RID: 61661 RVA: 0x0023454E File Offset: 0x0023274E
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

		// Token: 0x17004835 RID: 18485
		// (get) Token: 0x0600F0DE RID: 61662 RVA: 0x00234584 File Offset: 0x00232784
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

		// Token: 0x04008465 RID: 33893
		private IMotorCatapult Instance;

		// Token: 0x04008466 RID: 33894
		[Nullable(2)]
		private IMotorCatapultParam _ParamCache;

		// Token: 0x04008467 RID: 33895
		private bool _ParamInited;
	}
}
