using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001317 RID: 4887
	public class IZaxisViewRange
	{
		// Token: 0x06007035 RID: 28725 RVA: 0x0010F1A4 File Offset: 0x0010D3A4
		[NullableContext(1)]
		public static IZaxisViewRange Create(IZaxisViewRange? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IZaxisViewRange
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170023DA RID: 9178
		// (get) Token: 0x06007036 RID: 28726 RVA: 0x0010F1C4 File Offset: 0x0010D3C4
		public virtual int? Up
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.Up);
			}
		}

		// Token: 0x170023DB RID: 9179
		// (get) Token: 0x06007037 RID: 28727 RVA: 0x0010F1FC File Offset: 0x0010D3FC
		public virtual int? Down
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.Down);
			}
		}

		// Token: 0x040040BD RID: 16573
		private IZaxisViewRange Instance;
	}
}
