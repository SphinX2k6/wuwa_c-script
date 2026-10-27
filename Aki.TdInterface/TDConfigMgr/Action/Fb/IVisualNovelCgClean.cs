using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002568 RID: 9576
	public class IVisualNovelCgClean : IVisualNovelCgBase
	{
		// Token: 0x0600D6F8 RID: 55032 RVA: 0x0020090E File Offset: 0x001FEB0E
		[NullableContext(1)]
		public static IVisualNovelCgClean Create(IVisualNovelCgClean? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelCgClean
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003DEA RID: 15850
		// (get) Token: 0x0600D6F9 RID: 55033 RVA: 0x0020092D File Offset: 0x001FEB2D
		public override EVisualNovelCgType Type
		{
			get
			{
				return (EVisualNovelCgType)this.Instance.Type;
			}
		}

		// Token: 0x0400770A RID: 30474
		private IVisualNovelCgClean Instance;
	}
}
