using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C28 RID: 3112
	[NullableContext(2)]
	[Nullable(0)]
	public class IMovementPlatformConfig
	{
		// Token: 0x0600474D RID: 18253 RVA: 0x000B38B3 File Offset: 0x000B1AB3
		[NullableContext(1)]
		public static IMovementPlatformConfig Create(IMovementPlatformConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMovementPlatformConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170014BA RID: 5306
		// (get) Token: 0x0600474E RID: 18254 RVA: 0x000B38D4 File Offset: 0x000B1AD4
		public virtual List<int> PlayerAttachTags
		{
			get
			{
				if (this._PlayerAttachTagsInited)
				{
					return this._PlayerAttachTagsCache;
				}
				this._PlayerAttachTagsInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int playerAttachTagsLength = this.Instance.PlayerAttachTagsLength;
				this._PlayerAttachTagsCache = new List<int>(playerAttachTagsLength);
				for (int i = 0; i < playerAttachTagsLength; i++)
				{
					this._PlayerAttachTagsCache.Add(this.Instance.PlayerAttachTags(i));
				}
				return this._PlayerAttachTagsCache;
			}
		}

		// Token: 0x170014BB RID: 5307
		// (get) Token: 0x0600474F RID: 18255 RVA: 0x000B394C File Offset: 0x000B1B4C
		public virtual int? SafePointId
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.SafePointId);
			}
		}

		// Token: 0x04002877 RID: 10359
		private IMovementPlatformConfig Instance;

		// Token: 0x04002878 RID: 10360
		private List<int> _PlayerAttachTagsCache;

		// Token: 0x04002879 RID: 10361
		private bool _PlayerAttachTagsInited;
	}
}
