using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CD8 RID: 3288
	public class BuffConsumerComponent : IComponentBase
	{
		// Token: 0x06004B19 RID: 19225 RVA: 0x000BC96A File Offset: 0x000BAB6A
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

		// Token: 0x17001564 RID: 5476
		// (get) Token: 0x06004B1A RID: 19226 RVA: 0x000BC98C File Offset: 0x000BAB8C
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

		// Token: 0x17001565 RID: 5477
		// (get) Token: 0x06004B1B RID: 19227 RVA: 0x000BC9C4 File Offset: 0x000BABC4
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001566 RID: 5478
		// (get) Token: 0x06004B1C RID: 19228 RVA: 0x000BC9DA File Offset: 0x000BABDA
		public virtual long BuffId
		{
			get
			{
				return this.Instance.BuffId;
			}
		}

		// Token: 0x17001567 RID: 5479
		// (get) Token: 0x06004B1D RID: 19229 RVA: 0x000BC9E8 File Offset: 0x000BABE8
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

		// Token: 0x17001568 RID: 5480
		// (get) Token: 0x06004B1E RID: 19230 RVA: 0x000BCA20 File Offset: 0x000BAC20
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

		// Token: 0x04002A83 RID: 10883
		private IBuffConsumerComponent Instance;
	}
}
