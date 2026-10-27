using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DA1 RID: 3489
	[NullableContext(1)]
	[Nullable(0)]
	public class GodKingFrequencyControllerComponent : IComponentBase
	{
		// Token: 0x06004F4D RID: 20301 RVA: 0x000C489A File Offset: 0x000C2A9A
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

		// Token: 0x170019C8 RID: 6600
		// (get) Token: 0x06004F4E RID: 20302 RVA: 0x000C48BC File Offset: 0x000C2ABC
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

		// Token: 0x170019C9 RID: 6601
		// (get) Token: 0x06004F4F RID: 20303 RVA: 0x000C48F4 File Offset: 0x000C2AF4
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019CA RID: 6602
		// (get) Token: 0x06004F50 RID: 20304 RVA: 0x000C490C File Offset: 0x000C2B0C
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

		// Token: 0x170019CB RID: 6603
		// (get) Token: 0x06004F51 RID: 20305 RVA: 0x000C4970 File Offset: 0x000C2B70
		public virtual int InitialAttachStatue
		{
			get
			{
				return this.Instance.InitialAttachStatue;
			}
		}

		// Token: 0x170019CC RID: 6604
		// (get) Token: 0x06004F52 RID: 20306 RVA: 0x000C497D File Offset: 0x000C2B7D
		public virtual int GodKingFrequencyEntity
		{
			get
			{
				return this.Instance.GodKingFrequencyEntity;
			}
		}

		// Token: 0x170019CD RID: 6605
		// (get) Token: 0x06004F53 RID: 20307 RVA: 0x000C498A File Offset: 0x000C2B8A
		public virtual string AttachSocket
		{
			get
			{
				return this.Instance.AttachSocket;
			}
		}

		// Token: 0x170019CE RID: 6606
		// (get) Token: 0x06004F54 RID: 20308 RVA: 0x000C4997 File Offset: 0x000C2B97
		public virtual float FlySpeed
		{
			get
			{
				return this.Instance.FlySpeed;
			}
		}

		// Token: 0x170019CF RID: 6607
		// (get) Token: 0x06004F55 RID: 20309 RVA: 0x000C49A4 File Offset: 0x000C2BA4
		public virtual float MaxFlyTime
		{
			get
			{
				return this.Instance.MaxFlyTime;
			}
		}

		// Token: 0x04002D86 RID: 11654
		private IGodKingFrequencyControllerComponent Instance;

		// Token: 0x04002D87 RID: 11655
		private List<int> _StatueEntityIdListCache;

		// Token: 0x04002D88 RID: 11656
		private bool _StatueEntityIdListInited;
	}
}
