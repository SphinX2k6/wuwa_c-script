using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002585 RID: 9605
	public class IVisualNovelDate
	{
		// Token: 0x0600D795 RID: 55189 RVA: 0x00201B2A File Offset: 0x001FFD2A
		[NullableContext(1)]
		public static IVisualNovelDate Create(IVisualNovelDate? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelDate
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E4D RID: 15949
		// (get) Token: 0x0600D796 RID: 55190 RVA: 0x00201B49 File Offset: 0x001FFD49
		public virtual int Month
		{
			get
			{
				return this.Instance.Month;
			}
		}

		// Token: 0x17003E4E RID: 15950
		// (get) Token: 0x0600D797 RID: 55191 RVA: 0x00201B56 File Offset: 0x001FFD56
		public virtual int Day
		{
			get
			{
				return this.Instance.Day;
			}
		}

		// Token: 0x04007749 RID: 30537
		private IVisualNovelDate Instance;
	}
}
