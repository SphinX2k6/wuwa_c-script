using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E52 RID: 3666
	[NullableContext(2)]
	[Nullable(0)]
	public class IGroupAiPatrol : IGroupAiMode
	{
		// Token: 0x060052F2 RID: 21234 RVA: 0x000CCE63 File Offset: 0x000CB063
		[NullableContext(0)]
		public static IGroupAiPatrol Create(IGroupAiPatrol? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGroupAiPatrol
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A49 RID: 6729
		// (get) Token: 0x060052F3 RID: 21235 RVA: 0x000CCE82 File Offset: 0x000CB082
		public override EGroupAiMode Type
		{
			get
			{
				return (EGroupAiMode)this.Instance.Type;
			}
		}

		// Token: 0x17001A4A RID: 6730
		// (get) Token: 0x060052F4 RID: 21236 RVA: 0x000CCE8F File Offset: 0x000CB08F
		public virtual int Leader
		{
			get
			{
				return this.Instance.Leader;
			}
		}

		// Token: 0x17001A4B RID: 6731
		// (get) Token: 0x060052F5 RID: 21237 RVA: 0x000CCE9C File Offset: 0x000CB09C
		public virtual int SplineEntityId
		{
			get
			{
				return this.Instance.SplineEntityId;
			}
		}

		// Token: 0x17001A4C RID: 6732
		// (get) Token: 0x060052F6 RID: 21238 RVA: 0x000CCEAC File Offset: 0x000CB0AC
		public virtual int? PlayerPlaceholderEntityId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.PlayerPlaceholderEntityId);
			}
		}

		// Token: 0x17001A4D RID: 6733
		// (get) Token: 0x060052F7 RID: 21239 RVA: 0x000CCEE4 File Offset: 0x000CB0E4
		public virtual EGroupAiFormationBasis? FormationBasis
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new EGroupAiFormationBasis?((EGroupAiFormationBasis)this.Instance.FormationBasis);
			}
		}

		// Token: 0x17001A4E RID: 6734
		// (get) Token: 0x060052F8 RID: 21240 RVA: 0x000CCF1C File Offset: 0x000CB11C
		public virtual bool? IsPreciseFormation
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsPreciseFormation);
			}
		}

		// Token: 0x17001A4F RID: 6735
		// (get) Token: 0x060052F9 RID: 21241 RVA: 0x000CCF52 File Offset: 0x000CB152
		public virtual IGroupAiEcologyGameplayAbp EcologyGameplayAbp
		{
			get
			{
				if (this._EcologyGameplayAbpInited)
				{
					return this._EcologyGameplayAbpCache;
				}
				this._EcologyGameplayAbpInited = true;
				this._EcologyGameplayAbpCache = IGroupAiEcologyGameplayAbp.Create(this.Instance.EcologyGameplayAbp);
				return this._EcologyGameplayAbpCache;
			}
		}

		// Token: 0x04002F5D RID: 12125
		private IGroupAiPatrol Instance;

		// Token: 0x04002F5E RID: 12126
		private IGroupAiEcologyGameplayAbp _EcologyGameplayAbpCache;

		// Token: 0x04002F5F RID: 12127
		private bool _EcologyGameplayAbpInited;
	}
}
