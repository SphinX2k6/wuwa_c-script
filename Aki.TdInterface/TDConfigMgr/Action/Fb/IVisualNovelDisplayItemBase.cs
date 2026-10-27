using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200256C RID: 9580
	public class IVisualNovelDisplayItemBase
	{
		// Token: 0x0600D705 RID: 55045 RVA: 0x002009EB File Offset: 0x001FEBEB
		[NullableContext(1)]
		public static IVisualNovelDisplayItemBase Create(IVisualNovelDisplayItemBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelDisplayItemBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003DEF RID: 15855
		// (get) Token: 0x0600D706 RID: 55046 RVA: 0x00200A0A File Offset: 0x001FEC0A
		public virtual EVisualNovelDisplayItemType Type
		{
			get
			{
				return (EVisualNovelDisplayItemType)this.Instance.Type;
			}
		}

		// Token: 0x0400770E RID: 30478
		private IVisualNovelDisplayItemBase Instance;
	}
}
