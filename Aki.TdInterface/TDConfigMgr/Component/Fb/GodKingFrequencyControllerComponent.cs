using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E9D RID: 3741
	public class GodKingFrequencyControllerComponent : IComponentBase
	{
		// Token: 0x06005472 RID: 21618 RVA: 0x000D00EA File Offset: 0x000CE2EA
		public static GodKingFrequencyControllerComponent Create(IGodKingFrequencyControllerComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new GodKingFrequencyControllerComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B33 RID: 6963
		// (get) Token: 0x06005473 RID: 21619 RVA: 0x000D010C File Offset: 0x000CE30C
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

		// Token: 0x17001B34 RID: 6964
		// (get) Token: 0x06005474 RID: 21620 RVA: 0x000D0144 File Offset: 0x000CE344
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B35 RID: 6965
		// (get) Token: 0x06005475 RID: 21621 RVA: 0x000D015C File Offset: 0x000CE35C
		public virtual List<int> StatueEntityIdList
		{
			get
			{
				if (this._StatueEntityIdListInited)
				{
					return this._StatueEntityIdListCache;
				}
				this._StatueEntityIdListInited = true;
				int statueEntityIdListLength = this.Instance.StatueEntityIdListLength;
				this._StatueEntityIdListCache = new List<int>(statueEntityIdListLength);
				for (int i = 0; i < statueEntityIdListLength; i++)
				{
					this._StatueEntityIdListCache.Add(this.Instance.StatueEntityIdList(i));
				}
				return this._StatueEntityIdListCache;
			}
		}

		// Token: 0x17001B36 RID: 6966
		// (get) Token: 0x06005476 RID: 21622 RVA: 0x000D01C0 File Offset: 0x000CE3C0
		public virtual int InitialAttachStatue
		{
			get
			{
				return this.Instance.InitialAttachStatue;
			}
		}

		// Token: 0x17001B37 RID: 6967
		// (get) Token: 0x06005477 RID: 21623 RVA: 0x000D01CD File Offset: 0x000CE3CD
		public virtual int GodKingFrequencyEntity
		{
			get
			{
				return this.Instance.GodKingFrequencyEntity;
			}
		}

		// Token: 0x17001B38 RID: 6968
		// (get) Token: 0x06005478 RID: 21624 RVA: 0x000D01DA File Offset: 0x000CE3DA
		public virtual string AttachSocket
		{
			get
			{
				return this.Instance.AttachSocket;
			}
		}

		// Token: 0x17001B39 RID: 6969
		// (get) Token: 0x06005479 RID: 21625 RVA: 0x000D01E7 File Offset: 0x000CE3E7
		public virtual float FlySpeed
		{
			get
			{
				return this.Instance.FlySpeed;
			}
		}

		// Token: 0x17001B3A RID: 6970
		// (get) Token: 0x0600547A RID: 21626 RVA: 0x000D01F4 File Offset: 0x000CE3F4
		public virtual float MaxFlyTime
		{
			get
			{
				return this.Instance.MaxFlyTime;
			}
		}

		// Token: 0x0400304C RID: 12364
		private IGodKingFrequencyControllerComponent Instance;

		// Token: 0x0400304D RID: 12365
		private List<int> _StatueEntityIdListCache;

		// Token: 0x0400304E RID: 12366
		private bool _StatueEntityIdListInited;
	}
}
