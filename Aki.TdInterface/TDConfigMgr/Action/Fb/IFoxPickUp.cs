using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002805 RID: 10245
	public class IFoxPickUp : ILeisureInteractType
	{
		// Token: 0x0600E35B RID: 58203 RVA: 0x0021846C File Offset: 0x0021666C
		[NullableContext(1)]
		public static IFoxPickUp Create(IFoxPickUp? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFoxPickUp
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004513 RID: 17683
		// (get) Token: 0x0600E35C RID: 58204 RVA: 0x0021848B File Offset: 0x0021668B
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x17004514 RID: 17684
		// (get) Token: 0x0600E35D RID: 58205 RVA: 0x00218498 File Offset: 0x00216698
		public virtual int DataTableIndex
		{
			get
			{
				return this.Instance.DataTableIndex;
			}
		}

		// Token: 0x17004515 RID: 17685
		// (get) Token: 0x0600E35E RID: 58206 RVA: 0x002184A8 File Offset: 0x002166A8
		public virtual bool? MouthOpen
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.MouthOpen);
			}
		}

		// Token: 0x04007DE9 RID: 32233
		private IFoxPickUp Instance;
	}
}
