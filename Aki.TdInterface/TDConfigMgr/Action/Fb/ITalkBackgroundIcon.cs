using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002524 RID: 9508
	[NullableContext(1)]
	[Nullable(0)]
	public class ITalkBackgroundIcon : ITalkBackground
	{
		// Token: 0x0600D408 RID: 54280 RVA: 0x001F677E File Offset: 0x001F497E
		public static ITalkBackgroundIcon Create(ITalkBackgroundIcon? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkBackgroundIcon
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003B82 RID: 15234
		// (get) Token: 0x0600D409 RID: 54281 RVA: 0x001F679D File Offset: 0x001F499D
		public override ETalkBackgroundType Type
		{
			get
			{
				return (ETalkBackgroundType)this.Instance.Type;
			}
		}

		// Token: 0x17003B83 RID: 15235
		// (get) Token: 0x0600D40A RID: 54282 RVA: 0x001F67AA File Offset: 0x001F49AA
		public virtual string ImageAsset
		{
			get
			{
				return this.Instance.ImageAsset;
			}
		}

		// Token: 0x0400742A RID: 29738
		private ITalkBackgroundIcon Instance;
	}
}
