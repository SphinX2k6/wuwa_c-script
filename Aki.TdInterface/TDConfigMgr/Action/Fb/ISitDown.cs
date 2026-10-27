using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027D4 RID: 10196
	public class ISitDown : ILeisureInteractType
	{
		// Token: 0x0600E2A3 RID: 58019 RVA: 0x00217510 File Offset: 0x00215710
		[NullableContext(1)]
		public static ISitDown Create(ISitDown? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISitDown
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044BD RID: 17597
		// (get) Token: 0x0600E2A4 RID: 58020 RVA: 0x0021752F File Offset: 0x0021572F
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x170044BE RID: 17598
		// (get) Token: 0x0600E2A5 RID: 58021 RVA: 0x0021753C File Offset: 0x0021573C
		public virtual bool? OnlyAllowForwardStandUp
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.OnlyAllowForwardStandUp);
			}
		}

		// Token: 0x04007DA6 RID: 32166
		private ISitDown Instance;
	}
}
