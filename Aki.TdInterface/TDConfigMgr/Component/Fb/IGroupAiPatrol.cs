using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D58 RID: 3416
	[NullableContext(2)]
	[Nullable(0)]
	public class IGroupAiPatrol : IGroupAiMode
	{
		// Token: 0x06004DD6 RID: 19926 RVA: 0x000C171F File Offset: 0x000BF91F
		[NullableContext(1)]
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

		// Token: 0x170018E3 RID: 6371
		// (get) Token: 0x06004DD7 RID: 19927 RVA: 0x000C173E File Offset: 0x000BF93E
		public override EGroupAiMode Type
		{
			get
			{
				return (EGroupAiMode)this.Instance.Type;
			}
		}

		// Token: 0x170018E4 RID: 6372
		// (get) Token: 0x06004DD8 RID: 19928 RVA: 0x000C174B File Offset: 0x000BF94B
		public virtual int Leader
		{
			get
			{
				return this.Instance.Leader;
			}
		}

		// Token: 0x170018E5 RID: 6373
		// (get) Token: 0x06004DD9 RID: 19929 RVA: 0x000C1758 File Offset: 0x000BF958
		public virtual int SplineEntityId
		{
			get
			{
				return this.Instance.SplineEntityId;
			}
		}

		// Token: 0x170018E6 RID: 6374
		// (get) Token: 0x06004DDA RID: 19930 RVA: 0x000C1768 File Offset: 0x000BF968
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

		// Token: 0x170018E7 RID: 6375
		// (get) Token: 0x06004DDB RID: 19931 RVA: 0x000C17A0 File Offset: 0x000BF9A0
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

		// Token: 0x170018E8 RID: 6376
		// (get) Token: 0x06004DDC RID: 19932 RVA: 0x000C17D8 File Offset: 0x000BF9D8
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

		// Token: 0x170018E9 RID: 6377
		// (get) Token: 0x06004DDD RID: 19933 RVA: 0x000C180E File Offset: 0x000BFA0E
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

		// Token: 0x04002C9D RID: 11421
		private IGroupAiPatrol Instance;

		// Token: 0x04002C9E RID: 11422
		private IGroupAiEcologyGameplayAbp _EcologyGameplayAbpCache;

		// Token: 0x04002C9F RID: 11423
		private bool _EcologyGameplayAbpInited;
	}
}
