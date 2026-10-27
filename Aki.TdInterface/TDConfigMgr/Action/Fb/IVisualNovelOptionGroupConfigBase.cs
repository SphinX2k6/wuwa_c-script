using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002591 RID: 9617
	public class IVisualNovelOptionGroupConfigBase
	{
		// Token: 0x0600D7C8 RID: 55240 RVA: 0x00202016 File Offset: 0x00200216
		[NullableContext(1)]
		public static IVisualNovelOptionGroupConfigBase Create(IVisualNovelOptionGroupConfigBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelOptionGroupConfigBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E68 RID: 15976
		// (get) Token: 0x0600D7C9 RID: 55241 RVA: 0x00202035 File Offset: 0x00200235
		public virtual EVisualNovelOptionGroupType Type
		{
			get
			{
				return (EVisualNovelOptionGroupType)this.Instance.Type;
			}
		}

		// Token: 0x04007761 RID: 30561
		private IVisualNovelOptionGroupConfigBase Instance;
	}
}
