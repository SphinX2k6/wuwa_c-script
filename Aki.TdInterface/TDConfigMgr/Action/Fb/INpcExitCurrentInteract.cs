using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200281A RID: 10266
	public class INpcExitCurrentInteract : INpcLeisureInteractType
	{
		// Token: 0x0600E3BE RID: 58302 RVA: 0x00218D87 File Offset: 0x00216F87
		[NullableContext(1)]
		public static INpcExitCurrentInteract Create(INpcExitCurrentInteract? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcExitCurrentInteract
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700454C RID: 17740
		// (get) Token: 0x0600E3BF RID: 58303 RVA: 0x00218DA6 File Offset: 0x00216FA6
		public override ENpcLeisureInteract Type
		{
			get
			{
				return (ENpcLeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x1700454D RID: 17741
		// (get) Token: 0x0600E3C0 RID: 58304 RVA: 0x00218DB4 File Offset: 0x00216FB4
		public override bool? KeepState
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.KeepState);
			}
		}

		// Token: 0x04007E10 RID: 32272
		private INpcExitCurrentInteract Instance;
	}
}
