using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002E09 RID: 11785
	public class IHandBookRollbackEmojiOption : IHandBookProgressOption
	{
		// Token: 0x0601001E RID: 65566 RVA: 0x0024DDAC File Offset: 0x0024BFAC
		public static IHandBookRollbackEmojiOption Create(IHandBookRollbackEmojiOption? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHandBookRollbackEmojiOption
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170050BA RID: 20666
		// (get) Token: 0x0601001F RID: 65567 RVA: 0x0024DDCB File Offset: 0x0024BFCB
		public override EHandBookProgressType Type
		{
			get
			{
				return (EHandBookProgressType)this.Instance.Type;
			}
		}

		// Token: 0x170050BB RID: 20667
		// (get) Token: 0x06010020 RID: 65568 RVA: 0x0024DDD8 File Offset: 0x0024BFD8
		public virtual List<int> EmojiIds
		{
			get
			{
				if (this._EmojiIdsInited)
				{
					return this._EmojiIdsCache;
				}
				this._EmojiIdsInited = true;
				int emojiIdsLength = this.Instance.EmojiIdsLength;
				this._EmojiIdsCache = new List<int>(emojiIdsLength);
				for (int i = 0; i < emojiIdsLength; i++)
				{
					this._EmojiIdsCache.Add(this.Instance.EmojiIds(i));
				}
				return this._EmojiIdsCache;
			}
		}

		// Token: 0x04008BC5 RID: 35781
		private IHandBookRollbackEmojiOption Instance;

		// Token: 0x04008BC6 RID: 35782
		private List<int> _EmojiIdsCache;

		// Token: 0x04008BC7 RID: 35783
		private bool _EmojiIdsInited;
	}
}
