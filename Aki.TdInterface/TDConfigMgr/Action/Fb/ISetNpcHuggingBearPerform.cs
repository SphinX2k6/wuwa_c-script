using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A5F RID: 10847
	[NullableContext(1)]
	[Nullable(0)]
	public class ISetNpcHuggingBearPerform : ISetNpcGroupPerformType
	{
		// Token: 0x0600EE96 RID: 61078 RVA: 0x0022B83D File Offset: 0x00229A3D
		public static ISetNpcHuggingBearPerform Create(ISetNpcHuggingBearPerform? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetNpcHuggingBearPerform
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B9A RID: 19354
		// (get) Token: 0x0600EE97 RID: 61079 RVA: 0x0022B85C File Offset: 0x00229A5C
		public override ENpcGroupPerformType Type
		{
			get
			{
				return (ENpcGroupPerformType)this.Instance.Type;
			}
		}

		// Token: 0x17004B9B RID: 19355
		// (get) Token: 0x0600EE98 RID: 61080 RVA: 0x0022B869 File Offset: 0x00229A69
		public virtual IPlayerInitiator Initiator
		{
			get
			{
				if (this._InitiatorInited)
				{
					return this._InitiatorCache;
				}
				this._InitiatorInited = true;
				this._InitiatorCache = IPlayerInitiator.Create(this.Instance.Initiator);
				return this._InitiatorCache;
			}
		}

		// Token: 0x17004B9C RID: 19356
		// (get) Token: 0x0600EE99 RID: 61081 RVA: 0x0022B89D File Offset: 0x00229A9D
		public virtual int Target
		{
			get
			{
				return this.Instance.Target;
			}
		}

		// Token: 0x17004B9D RID: 19357
		// (get) Token: 0x0600EE9A RID: 61082 RVA: 0x0022B8AA File Offset: 0x00229AAA
		public virtual ENpcGroupPerformNpcType NpcType
		{
			get
			{
				return (ENpcGroupPerformNpcType)this.Instance.NpcType;
			}
		}

		// Token: 0x04008341 RID: 33601
		private ISetNpcHuggingBearPerform Instance;

		// Token: 0x04008342 RID: 33602
		[Nullable(2)]
		private IPlayerInitiator _InitiatorCache;

		// Token: 0x04008343 RID: 33603
		private bool _InitiatorInited;
	}
}
