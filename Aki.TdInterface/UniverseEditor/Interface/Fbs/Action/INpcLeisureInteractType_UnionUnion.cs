using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007329 RID: 29481
	public class INpcLeisureInteractType_UnionUnion
	{
		// Token: 0x1700D812 RID: 55314
		// (get) Token: 0x06033685 RID: 210565 RVA: 0x006EE4E4 File Offset: 0x006EC6E4
		// (set) Token: 0x06033686 RID: 210566 RVA: 0x006EE4EC File Offset: 0x006EC6EC
		public INpcLeisureInteractType_Union Type { get; set; }

		// Token: 0x1700D813 RID: 55315
		// (get) Token: 0x06033687 RID: 210567 RVA: 0x006EE4F5 File Offset: 0x006EC6F5
		// (set) Token: 0x06033688 RID: 210568 RVA: 0x006EE4FD File Offset: 0x006EC6FD
		public object Value { get; set; }

		// Token: 0x06033689 RID: 210569 RVA: 0x006EE506 File Offset: 0x006EC706
		public INpcLeisureInteractType_UnionUnion()
		{
			this.Type = INpcLeisureInteractType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0603368A RID: 210570 RVA: 0x006EE51C File Offset: 0x006EC71C
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603368B RID: 210571 RVA: 0x006EE52E File Offset: 0x006EC72E
		public INpcLeisureInteractTypeT AsINpcLeisureInteractType()
		{
			return this.As<INpcLeisureInteractTypeT>();
		}

		// Token: 0x0603368C RID: 210572 RVA: 0x006EE536 File Offset: 0x006EC736
		public static INpcLeisureInteractType_UnionUnion FromINpcLeisureInteractType(INpcLeisureInteractTypeT _inpcleisureinteracttype)
		{
			return new INpcLeisureInteractType_UnionUnion
			{
				Type = INpcLeisureInteractType_Union.INpcLeisureInteractType,
				Value = _inpcleisureinteracttype
			};
		}

		// Token: 0x0603368D RID: 210573 RVA: 0x006EE54B File Offset: 0x006EC74B
		public INpcSitDownT AsINpcSitDown()
		{
			return this.As<INpcSitDownT>();
		}

		// Token: 0x0603368E RID: 210574 RVA: 0x006EE553 File Offset: 0x006EC753
		public static INpcLeisureInteractType_UnionUnion FromINpcSitDown(INpcSitDownT _inpcsitdown)
		{
			return new INpcLeisureInteractType_UnionUnion
			{
				Type = INpcLeisureInteractType_Union.INpcSitDown,
				Value = _inpcsitdown
			};
		}

		// Token: 0x0603368F RID: 210575 RVA: 0x006EE568 File Offset: 0x006EC768
		public INpcSwingT AsINpcSwing()
		{
			return this.As<INpcSwingT>();
		}

		// Token: 0x06033690 RID: 210576 RVA: 0x006EE570 File Offset: 0x006EC770
		public static INpcLeisureInteractType_UnionUnion FromINpcSwing(INpcSwingT _inpcswing)
		{
			return new INpcLeisureInteractType_UnionUnion
			{
				Type = INpcLeisureInteractType_Union.INpcSwing,
				Value = _inpcswing
			};
		}

		// Token: 0x06033691 RID: 210577 RVA: 0x006EE585 File Offset: 0x006EC785
		public INpcSwingGetUpT AsINpcSwingGetUp()
		{
			return this.As<INpcSwingGetUpT>();
		}

		// Token: 0x06033692 RID: 210578 RVA: 0x006EE58D File Offset: 0x006EC78D
		public static INpcLeisureInteractType_UnionUnion FromINpcSwingGetUp(INpcSwingGetUpT _inpcswinggetup)
		{
			return new INpcLeisureInteractType_UnionUnion
			{
				Type = INpcLeisureInteractType_Union.INpcSwingGetUp,
				Value = _inpcswinggetup
			};
		}

		// Token: 0x06033693 RID: 210579 RVA: 0x006EE5A2 File Offset: 0x006EC7A2
		public INpcExitCurrentInteractT AsINpcExitCurrentInteract()
		{
			return this.As<INpcExitCurrentInteractT>();
		}

		// Token: 0x06033694 RID: 210580 RVA: 0x006EE5AA File Offset: 0x006EC7AA
		public static INpcLeisureInteractType_UnionUnion FromINpcExitCurrentInteract(INpcExitCurrentInteractT _inpcexitcurrentinteract)
		{
			return new INpcLeisureInteractType_UnionUnion
			{
				Type = INpcLeisureInteractType_Union.INpcExitCurrentInteract,
				Value = _inpcexitcurrentinteract
			};
		}

		// Token: 0x06033695 RID: 210581 RVA: 0x006EE5C0 File Offset: 0x006EC7C0
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
