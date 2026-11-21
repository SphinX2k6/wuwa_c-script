using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D5D RID: 11613
	public class ILookAtBubbleEntity : IDefaultLookAtType
	{
		// Token: 0x0600FD7F RID: 64895 RVA: 0x00249B1C File Offset: 0x00247D1C
		public static ILookAtBubbleEntity Create(ILookAtBubbleEntity? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILookAtBubbleEntity
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F73 RID: 20339
		// (get) Token: 0x0600FD80 RID: 64896 RVA: 0x00249B3B File Offset: 0x00247D3B
		public override EDefaultLookAtType Type
		{
			get
			{
				return (EDefaultLookAtType)this.Instance.Type;
			}
		}

		// Token: 0x17004F74 RID: 20340
		// (get) Token: 0x0600FD81 RID: 64897 RVA: 0x00249B48 File Offset: 0x00247D48
		public virtual List<ILookAtBubbleEntityConfig> BubbleEntityConfig
		{
			get
			{
				if (this._BubbleEntityConfigInited)
				{
					return this._BubbleEntityConfigCache;
				}
				this._BubbleEntityConfigInited = true;
				int bubbleEntityConfigLength = this.Instance.BubbleEntityConfigLength;
				this._BubbleEntityConfigCache = new List<ILookAtBubbleEntityConfig>(bubbleEntityConfigLength);
				for (int i = 0; i < bubbleEntityConfigLength; i++)
				{
					this._BubbleEntityConfigCache.Add(ILookAtBubbleEntityConfig.Create(this.Instance.BubbleEntityConfig(i)));
				}
				return this._BubbleEntityConfigCache;
			}
		}

		// Token: 0x04008A61 RID: 35425
		private ILookAtBubbleEntity Instance;

		// Token: 0x04008A62 RID: 35426
		private List<ILookAtBubbleEntityConfig> _BubbleEntityConfigCache;

		// Token: 0x04008A63 RID: 35427
		private bool _BubbleEntityConfigInited;
	}
}
