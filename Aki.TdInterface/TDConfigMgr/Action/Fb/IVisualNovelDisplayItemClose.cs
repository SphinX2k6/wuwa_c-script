using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200256F RID: 9583
	public class IVisualNovelDisplayItemClose : IVisualNovelDisplayItemBase
	{
		// Token: 0x0600D710 RID: 55056 RVA: 0x00200AA1 File Offset: 0x001FECA1
		[NullableContext(1)]
		public static IVisualNovelDisplayItemClose Create(IVisualNovelDisplayItemClose? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelDisplayItemClose
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003DF4 RID: 15860
		// (get) Token: 0x0600D711 RID: 55057 RVA: 0x00200AC0 File Offset: 0x001FECC0
		public override EVisualNovelDisplayItemType Type
		{
			get
			{
				return (EVisualNovelDisplayItemType)this.Instance.Type;
			}
		}

		// Token: 0x04007711 RID: 30481
		private IVisualNovelDisplayItemClose Instance;
	}
}
