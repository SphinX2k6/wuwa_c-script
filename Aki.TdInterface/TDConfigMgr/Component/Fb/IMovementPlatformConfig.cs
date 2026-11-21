using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CFB RID: 3323
	[NullableContext(2)]
	[Nullable(0)]
	public class IMovementPlatformConfig
	{
		// Token: 0x06004BBD RID: 19389 RVA: 0x000BDC65 File Offset: 0x000BBE65
		[NullableContext(0)]
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

		// Token: 0x170015C2 RID: 5570
		// (get) Token: 0x06004BBE RID: 19390 RVA: 0x000BDC84 File Offset: 0x000BBE84
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

		// Token: 0x170015C3 RID: 5571
		// (get) Token: 0x06004BBF RID: 19391 RVA: 0x000BDCFC File Offset: 0x000BBEFC
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

		// Token: 0x04002ACC RID: 10956
		private IMovementPlatformConfig Instance;

		// Token: 0x04002ACD RID: 10957
		private List<int> _PlayerAttachTagsCache;

		// Token: 0x04002ACE RID: 10958
		private bool _PlayerAttachTagsInited;
	}
}
