using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BC5 RID: 27589
	public class INpcLeisureInteractType_UnionUnion
	{
		// Token: 0x1700CD06 RID: 52486
		// (get) Token: 0x06030769 RID: 198505 RVA: 0x00694BE4 File Offset: 0x00692DE4
		// (set) Token: 0x0603076A RID: 198506 RVA: 0x00694BEC File Offset: 0x00692DEC
		public INpcLeisureInteractType_Union Type { get; set; }

		// Token: 0x1700CD07 RID: 52487
		// (get) Token: 0x0603076B RID: 198507 RVA: 0x00694BF5 File Offset: 0x00692DF5
		// (set) Token: 0x0603076C RID: 198508 RVA: 0x00694BFD File Offset: 0x00692DFD
		public object Value { get; set; }

		// Token: 0x0603076D RID: 198509 RVA: 0x00694C06 File Offset: 0x00692E06
		public INpcLeisureInteractType_UnionUnion()
		{
			this.Type = INpcLeisureInteractType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0603076E RID: 198510 RVA: 0x00694C1C File Offset: 0x00692E1C
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603076F RID: 198511 RVA: 0x00694C2E File Offset: 0x00692E2E
		public INpcLeisureInteractTypeT AsINpcLeisureInteractType()
		{
			return this.As<INpcLeisureInteractTypeT>();
		}

		// Token: 0x06030770 RID: 198512 RVA: 0x00694C36 File Offset: 0x00692E36
		public static INpcLeisureInteractType_UnionUnion FromINpcLeisureInteractType(INpcLeisureInteractTypeT _inpcleisureinteracttype)
		{
			return new INpcLeisureInteractType_UnionUnion
			{
				Type = INpcLeisureInteractType_Union.INpcLeisureInteractType,
				Value = _inpcleisureinteracttype
			};
		}

		// Token: 0x06030771 RID: 198513 RVA: 0x00694C4B File Offset: 0x00692E4B
		public INpcSitDownT AsINpcSitDown()
		{
			return this.As<INpcSitDownT>();
		}

		// Token: 0x06030772 RID: 198514 RVA: 0x00694C53 File Offset: 0x00692E53
		public static INpcLeisureInteractType_UnionUnion FromINpcSitDown(INpcSitDownT _inpcsitdown)
		{
			return new INpcLeisureInteractType_UnionUnion
			{
				Type = INpcLeisureInteractType_Union.INpcSitDown,
				Value = _inpcsitdown
			};
		}

		// Token: 0x06030773 RID: 198515 RVA: 0x00694C68 File Offset: 0x00692E68
		public INpcSwingT AsINpcSwing()
		{
			return this.As<INpcSwingT>();
		}

		// Token: 0x06030774 RID: 198516 RVA: 0x00694C70 File Offset: 0x00692E70
		public static INpcLeisureInteractType_UnionUnion FromINpcSwing(INpcSwingT _inpcswing)
		{
			return new INpcLeisureInteractType_UnionUnion
			{
				Type = INpcLeisureInteractType_Union.INpcSwing,
				Value = _inpcswing
			};
		}

		// Token: 0x06030775 RID: 198517 RVA: 0x00694C85 File Offset: 0x00692E85
		public INpcSwingGetUpT AsINpcSwingGetUp()
		{
			return this.As<INpcSwingGetUpT>();
		}

		// Token: 0x06030776 RID: 198518 RVA: 0x00694C8D File Offset: 0x00692E8D
		public static INpcLeisureInteractType_UnionUnion FromINpcSwingGetUp(INpcSwingGetUpT _inpcswinggetup)
		{
			return new INpcLeisureInteractType_UnionUnion
			{
				Type = INpcLeisureInteractType_Union.INpcSwingGetUp,
				Value = _inpcswinggetup
			};
		}

		// Token: 0x06030777 RID: 198519 RVA: 0x00694CA2 File Offset: 0x00692EA2
		public INpcExitCurrentInteractT AsINpcExitCurrentInteract()
		{
			return this.As<INpcExitCurrentInteractT>();
		}

		// Token: 0x06030778 RID: 198520 RVA: 0x00694CAA File Offset: 0x00692EAA
		public static INpcLeisureInteractType_UnionUnion FromINpcExitCurrentInteract(INpcExitCurrentInteractT _inpcexitcurrentinteract)
		{
			return new INpcLeisureInteractType_UnionUnion
			{
				Type = INpcLeisureInteractType_Union.INpcExitCurrentInteract,
				Value = _inpcexitcurrentinteract
			};
		}

		// Token: 0x06030779 RID: 198521 RVA: 0x00694CC0 File Offset: 0x00692EC0
		public static int Pack(FlatBufferBuilder builder, INpcLeisureInteractType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case INpcLeisureInteractType_Union.INpcLeisureInteractType:
				return INpcLeisureInteractType.Pack(builder, _o.AsINpcLeisureInteractType()).Value;
			case INpcLeisureInteractType_Union.INpcSitDown:
				return INpcSitDown.Pack(builder, _o.AsINpcSitDown()).Value;
			case INpcLeisureInteractType_Union.INpcSwing:
				return INpcSwing.Pack(builder, _o.AsINpcSwing()).Value;
			case INpcLeisureInteractType_Union.INpcSwingGetUp:
				return INpcSwingGetUp.Pack(builder, _o.AsINpcSwingGetUp()).Value;
			case INpcLeisureInteractType_Union.INpcExitCurrentInteract:
				return INpcExitCurrentInteract.Pack(builder, _o.AsINpcExitCurrentInteract()).Value;
			default:
				return 0;
			}
		}
	}
}
