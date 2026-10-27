using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002884 RID: 10372
	public class IMontageId
	{
		// Token: 0x0600E5BB RID: 58811 RVA: 0x0021C3D2 File Offset: 0x0021A5D2
		[NullableContext(1)]
		public static IMontageId Create(IMontageId? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMontageId
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004675 RID: 18037
		// (get) Token: 0x0600E5BC RID: 58812 RVA: 0x0021C3F1 File Offset: 0x0021A5F1
		public virtual int MontageId
		{
			get
			{
				return this.Instance.MontageId;
			}
		}

		// Token: 0x17004676 RID: 18038
		// (get) Token: 0x0600E5BD RID: 58813 RVA: 0x0021C400 File Offset: 0x0021A600
		public virtual bool? IsAbp
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsAbp);
			}
		}

		// Token: 0x04007F08 RID: 32520
		private IMontageId Instance;
	}
}
