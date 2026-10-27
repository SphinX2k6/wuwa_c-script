using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200296A RID: 10602
	public class IPieceIndex
	{
		// Token: 0x0600EAF9 RID: 60153 RVA: 0x00226416 File Offset: 0x00224616
		[NullableContext(1)]
		public static IPieceIndex Create(IPieceIndex? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPieceIndex
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170049E7 RID: 18919
		// (get) Token: 0x0600EAFA RID: 60154 RVA: 0x00226435 File Offset: 0x00224635
		public virtual int RowIndex
		{
			get
			{
				return this.Instance.RowIndex;
			}
		}

		// Token: 0x170049E8 RID: 18920
		// (get) Token: 0x0600EAFB RID: 60155 RVA: 0x00226442 File Offset: 0x00224642
		public virtual int ColumnIndex
		{
			get
			{
				return this.Instance.ColumnIndex;
			}
		}

		// Token: 0x04008174 RID: 33140
		private IPieceIndex Instance;
	}
}
