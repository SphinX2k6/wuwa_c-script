using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BD7 RID: 27607
	public class INpcLookAtTypeBase_UnionUnion
	{
		// Token: 0x1700CD23 RID: 52515
		// (get) Token: 0x060307F2 RID: 198642 RVA: 0x00695AD9 File Offset: 0x00693CD9
		// (set) Token: 0x060307F3 RID: 198643 RVA: 0x00695AE1 File Offset: 0x00693CE1
		public INpcLookAtTypeBase_Union Type { get; set; }

		// Token: 0x1700CD24 RID: 52516
		// (get) Token: 0x060307F4 RID: 198644 RVA: 0x00695AEA File Offset: 0x00693CEA
		// (set) Token: 0x060307F5 RID: 198645 RVA: 0x00695AF2 File Offset: 0x00693CF2
		public object Value { get; set; }

		// Token: 0x060307F6 RID: 198646 RVA: 0x00695AFB File Offset: 0x00693CFB
		public INpcLookAtTypeBase_UnionUnion()
		{
			this.Type = INpcLookAtTypeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060307F7 RID: 198647 RVA: 0x00695B11 File Offset: 0x00693D11
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060307F8 RID: 198648 RVA: 0x00695B23 File Offset: 0x00693D23
		public INpcLookAtTypeBaseT AsINpcLookAtTypeBase()
		{
			return this.As<INpcLookAtTypeBaseT>();
		}

		// Token: 0x060307F9 RID: 198649 RVA: 0x00695B2B File Offset: 0x00693D2B
		public static INpcLookAtTypeBase_UnionUnion FromINpcLookAtTypeBase(INpcLookAtTypeBaseT _inpclookattypebase)
		{
			return new INpcLookAtTypeBase_UnionUnion
			{
				Type = INpcLookAtTypeBase_Union.INpcLookAtTypeBase,
				Value = _inpclookattypebase
			};
		}

		// Token: 0x060307FA RID: 198650 RVA: 0x00695B40 File Offset: 0x00693D40
		public INpcLookAtPlayerT AsINpcLookAtPlayer()
		{
			return this.As<INpcLookAtPlayerT>();
		}

		// Token: 0x060307FB RID: 198651 RVA: 0x00695B48 File Offset: 0x00693D48
		public static INpcLookAtTypeBase_UnionUnion FromINpcLookAtPlayer(INpcLookAtPlayerT _inpclookatplayer)
		{
			return new INpcLookAtTypeBase_UnionUnion
			{
				Type = INpcLookAtTypeBase_Union.INpcLookAtPlayer,
				Value = _inpclookatplayer
			};
		}

		// Token: 0x060307FC RID: 198652 RVA: 0x00695B5D File Offset: 0x00693D5D
		public INpcLookAtEntityT AsINpcLookAtEntity()
		{
			return this.As<INpcLookAtEntityT>();
		}

		// Token: 0x060307FD RID: 198653 RVA: 0x00695B65 File Offset: 0x00693D65
		public static INpcLookAtTypeBase_UnionUnion FromINpcLookAtEntity(INpcLookAtEntityT _inpclookatentity)
		{
			return new INpcLookAtTypeBase_UnionUnion
			{
				Type = INpcLookAtTypeBase_Union.INpcLookAtEntity,
				Value = _inpclookatentity
			};
		}

		// Token: 0x060307FE RID: 198654 RVA: 0x00695B7A File Offset: 0x00693D7A
		public INpcLookAtPositionT AsINpcLookAtPosition()
		{
			return this.As<INpcLookAtPositionT>();
		}

		// Token: 0x060307FF RID: 198655 RVA: 0x00695B82 File Offset: 0x00693D82
		public static INpcLookAtTypeBase_UnionUnion FromINpcLookAtPosition(INpcLookAtPositionT _inpclookatposition)
		{
			return new INpcLookAtTypeBase_UnionUnion
			{
				Type = INpcLookAtTypeBase_Union.INpcLookAtPosition,
				Value = _inpclookatposition
			};
		}

		// Token: 0x06030800 RID: 198656 RVA: 0x00695B98 File Offset: 0x00693D98
		public static int Pack(FlatBufferBuilder builder, INpcLookAtTypeBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case INpcLookAtTypeBase_Union.INpcLookAtTypeBase:
				return INpcLookAtTypeBase.Pack(builder, _o.AsINpcLookAtTypeBase()).Value;
			case INpcLookAtTypeBase_Union.INpcLookAtPlayer:
				return INpcLookAtPlayer.Pack(builder, _o.AsINpcLookAtPlayer()).Value;
			case INpcLookAtTypeBase_Union.INpcLookAtEntity:
				return INpcLookAtEntity.Pack(builder, _o.AsINpcLookAtEntity()).Value;
			case INpcLookAtTypeBase_Union.INpcLookAtPosition:
				return INpcLookAtPosition.Pack(builder, _o.AsINpcLookAtPosition()).Value;
			default:
				return 0;
			}
		}
	}
}
