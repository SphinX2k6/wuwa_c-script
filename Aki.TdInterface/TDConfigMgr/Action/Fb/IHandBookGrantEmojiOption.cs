using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002E08 RID: 11784
	public class IHandBookGrantEmojiOption : IHandBookProgressOption
	{
		// Token: 0x0601001A RID: 65562 RVA: 0x0024DD12 File Offset: 0x0024BF12
		public static IHandBookGrantEmojiOption Create(IHandBookGrantEmojiOption? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHandBookGrantEmojiOption
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170050B8 RID: 20664
		// (get) Token: 0x0601001B RID: 65563 RVA: 0x0024DD31 File Offset: 0x0024BF31
		public override EHandBookProgressType Type
		{
			get
			{
				return (EHandBookProgressType)this.Instance.Type;
			}
		}

		// Token: 0x170050B9 RID: 20665
		// (get) Token: 0x0601001C RID: 65564 RVA: 0x0024DD40 File Offset: 0x0024BF40
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

		// Token: 0x04008BC2 RID: 35778
		private IHandBookGrantEmojiOption Instance;

		// Token: 0x04008BC3 RID: 35779
		private List<int> _EmojiIdsCache;

		// Token: 0x04008BC4 RID: 35780
		private bool _EmojiIdsInited;
	}
}
