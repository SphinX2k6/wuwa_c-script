using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A69 RID: 10857
	[NullableContext(1)]
	[Nullable(0)]
	public class ILookAtBubbleEntity : IDefaultLookAtType
	{
		// Token: 0x0600EEC9 RID: 61129 RVA: 0x0022BE10 File Offset: 0x0022A010
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

		// Token: 0x17004BB9 RID: 19385
		// (get) Token: 0x0600EECA RID: 61130 RVA: 0x0022BE2F File Offset: 0x0022A02F
		public override EDefaultLookAtType Type
		{
			get
			{
				return (EDefaultLookAtType)this.Instance.Type;
			}
		}

		// Token: 0x17004BBA RID: 19386
		// (get) Token: 0x0600EECB RID: 61131 RVA: 0x0022BE3C File Offset: 0x0022A03C
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

		// Token: 0x0400835D RID: 33629
		private ILookAtBubbleEntity Instance;

		// Token: 0x0400835E RID: 33630
		private List<ILookAtBubbleEntityConfig> _BubbleEntityConfigCache;

		// Token: 0x0400835F RID: 33631
		private bool _BubbleEntityConfigInited;
	}
}
