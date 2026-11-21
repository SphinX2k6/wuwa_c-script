using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E39 RID: 3641
	public class IBatchBulletCaster
	{
		// Token: 0x06005271 RID: 21105 RVA: 0x000CBE2B File Offset: 0x000CA02B
		public static IBatchBulletCaster Create(IBatchBulletCaster? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBatchBulletCaster
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170019FA RID: 6650
		// (get) Token: 0x06005272 RID: 21106 RVA: 0x000CBE4A File Offset: 0x000CA04A
		public virtual int BulletIndex
		{
			get
			{
				return this.Instance.BulletIndex;
			}
		}

		// Token: 0x170019FB RID: 6651
		// (get) Token: 0x06005273 RID: 21107 RVA: 0x000CBE57 File Offset: 0x000CA057
		public virtual long BulletType
		{
			get
			{
				return this.Instance.BulletType;
			}
		}

		// Token: 0x170019FC RID: 6652
		// (get) Token: 0x06005274 RID: 21108 RVA: 0x000CBE64 File Offset: 0x000CA064
		public virtual int? DelayTime
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.DelayTime);
			}
		}

		// Token: 0x170019FD RID: 6653
		// (get) Token: 0x06005275 RID: 21109 RVA: 0x000CBE9A File Offset: 0x000CA09A
		public virtual int FlyTime
		{
			get
			{
				return this.Instance.FlyTime;
			}
		}

		// Token: 0x170019FE RID: 6654
		// (get) Token: 0x06005276 RID: 21110 RVA: 0x000CBEA7 File Offset: 0x000CA0A7
		public virtual int FlyDistance
		{
			get
			{
				return this.Instance.FlyDistance;
			}
		}

		// Token: 0x170019FF RID: 6655
		// (get) Token: 0x06005277 RID: 21111 RVA: 0x000CBEB4 File Offset: 0x000CA0B4
		public virtual int WarningTime
		{
			get
			{
				return this.Instance.WarningTime;
			}
		}

		// Token: 0x17001A00 RID: 6656
		// (get) Token: 0x06005278 RID: 21112 RVA: 0x000CBEC1 File Offset: 0x000CA0C1
		public virtual int WarningWidth
		{
			get
			{
				return this.Instance.WarningWidth;
			}
		}

		// Token: 0x04002F1A RID: 12058
		private IBatchBulletCaster Instance;
	}
}
