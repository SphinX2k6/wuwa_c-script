using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C08 RID: 3080
	public class BuffConsumerComponent : IComponentBase
	{
		// Token: 0x060046B6 RID: 18102 RVA: 0x000B279E File Offset: 0x000B099E
		[NullableContext(1)]
		public static BuffConsumerComponent Create(IBuffConsumerComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new BuffConsumerComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001463 RID: 5219
		// (get) Token: 0x060046B7 RID: 18103 RVA: 0x000B27C0 File Offset: 0x000B09C0
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

		// Token: 0x17001464 RID: 5220
		// (get) Token: 0x060046B8 RID: 18104 RVA: 0x000B27F8 File Offset: 0x000B09F8
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001465 RID: 5221
		// (get) Token: 0x060046B9 RID: 18105 RVA: 0x000B280E File Offset: 0x000B0A0E
		public virtual long BuffId
		{
			get
			{
				return this.Instance.BuffId;
			}
		}

		// Token: 0x17001466 RID: 5222
		// (get) Token: 0x060046BA RID: 18106 RVA: 0x000B281C File Offset: 0x000B0A1C
		public virtual long? BulletId
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new long?(this.Instance.BulletId);
			}
		}

		// Token: 0x17001467 RID: 5223
		// (get) Token: 0x060046BB RID: 18107 RVA: 0x000B2854 File Offset: 0x000B0A54
		public virtual int? ProducerEntityId
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new int?(this.Instance.ProducerEntityId);
			}
		}

		// Token: 0x04002837 RID: 10295
		private IBuffConsumerComponent Instance;
	}
}
