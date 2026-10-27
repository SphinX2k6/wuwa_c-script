using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002819 RID: 10265
	public class INpcSwingGetUp : INpcLeisureInteractType
	{
		// Token: 0x0600E3B9 RID: 58297 RVA: 0x00218D0E File Offset: 0x00216F0E
		[NullableContext(1)]
		public static INpcSwingGetUp Create(INpcSwingGetUp? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcSwingGetUp
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004549 RID: 17737
		// (get) Token: 0x0600E3BA RID: 58298 RVA: 0x00218D2D File Offset: 0x00216F2D
		public override ENpcLeisureInteract Type
		{
			get
			{
				return (ENpcLeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x1700454A RID: 17738
		// (get) Token: 0x0600E3BB RID: 58299 RVA: 0x00218D3C File Offset: 0x00216F3C
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

		// Token: 0x1700454B RID: 17739
		// (get) Token: 0x0600E3BC RID: 58300 RVA: 0x00218D72 File Offset: 0x00216F72
		public virtual int TargetNpcId
		{
			get
			{
				return this.Instance.TargetNpcId;
			}
		}

		// Token: 0x04007E0F RID: 32271
		private INpcSwingGetUp Instance;
	}
}
