using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013A2 RID: 5026
	public class ICiacconaAvgBoard : IShowUi
	{
		// Token: 0x060072DA RID: 29402 RVA: 0x00113DC8 File Offset: 0x00111FC8
		[NullableContext(1)]
		public static ICiacconaAvgBoard Create(ICiacconaAvgBoard? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICiacconaAvgBoard
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002569 RID: 9577
		// (get) Token: 0x060072DB RID: 29403 RVA: 0x00113DE7 File Offset: 0x00111FE7
		public override EShowUiType Type
		{
			get
			{
				return (EShowUiType)this.Instance.Type;
			}
		}

		// Token: 0x1700256A RID: 9578
		// (get) Token: 0x060072DC RID: 29404 RVA: 0x00113DF4 File Offset: 0x00111FF4
		public virtual int? EndingId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.EndingId);
			}
		}

		// Token: 0x04004260 RID: 16992
		private ICiacconaAvgBoard Instance;
	}
}
