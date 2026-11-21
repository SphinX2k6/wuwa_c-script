using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200733B RID: 29499
	public class INpcLookAtTypeBase_UnionUnion
	{
		// Token: 0x1700D82F RID: 55343
		// (get) Token: 0x0603370E RID: 210702 RVA: 0x006EF3D9 File Offset: 0x006ED5D9
		// (set) Token: 0x0603370F RID: 210703 RVA: 0x006EF3E1 File Offset: 0x006ED5E1
		public INpcLookAtTypeBase_Union Type { get; set; }

		// Token: 0x1700D830 RID: 55344
		// (get) Token: 0x06033710 RID: 210704 RVA: 0x006EF3EA File Offset: 0x006ED5EA
		// (set) Token: 0x06033711 RID: 210705 RVA: 0x006EF3F2 File Offset: 0x006ED5F2
		public object Value { get; set; }

		// Token: 0x06033712 RID: 210706 RVA: 0x006EF3FB File Offset: 0x006ED5FB
		public INpcLookAtTypeBase_UnionUnion()
		{
			this.Type = INpcLookAtTypeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06033713 RID: 210707 RVA: 0x006EF411 File Offset: 0x006ED611
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06033714 RID: 210708 RVA: 0x006EF423 File Offset: 0x006ED623
		public INpcLookAtTypeBaseT AsINpcLookAtTypeBase()
		{
			return this.As<INpcLookAtTypeBaseT>();
		}

		// Token: 0x06033715 RID: 210709 RVA: 0x006EF42B File Offset: 0x006ED62B
		public static INpcLookAtTypeBase_UnionUnion FromINpcLookAtTypeBase(INpcLookAtTypeBaseT _inpclookattypebase)
		{
			return new INpcLookAtTypeBase_UnionUnion
			{
				Type = INpcLookAtTypeBase_Union.INpcLookAtTypeBase,
				Value = _inpclookattypebase
			};
		}

		// Token: 0x06033716 RID: 210710 RVA: 0x006EF440 File Offset: 0x006ED640
		public INpcLookAtPlayerT AsINpcLookAtPlayer()
		{
			return this.As<INpcLookAtPlayerT>();
		}

		// Token: 0x06033717 RID: 210711 RVA: 0x006EF448 File Offset: 0x006ED648
		public static INpcLookAtTypeBase_UnionUnion FromINpcLookAtPlayer(INpcLookAtPlayerT _inpclookatplayer)
		{
			return new INpcLookAtTypeBase_UnionUnion
			{
				Type = INpcLookAtTypeBase_Union.INpcLookAtPlayer,
				Value = _inpclookatplayer
			};
		}

		// Token: 0x06033718 RID: 210712 RVA: 0x006EF45D File Offset: 0x006ED65D
		public INpcLookAtEntityT AsINpcLookAtEntity()
		{
			return this.As<INpcLookAtEntityT>();
		}

		// Token: 0x06033719 RID: 210713 RVA: 0x006EF465 File Offset: 0x006ED665
		public static INpcLookAtTypeBase_UnionUnion FromINpcLookAtEntity(INpcLookAtEntityT _inpclookatentity)
		{
			return new INpcLookAtTypeBase_UnionUnion
			{
				Type = INpcLookAtTypeBase_Union.INpcLookAtEntity,
				Value = _inpclookatentity
			};
		}

		// Token: 0x0603371A RID: 210714 RVA: 0x006EF47A File Offset: 0x006ED67A
		public INpcLookAtPositionT AsINpcLookAtPosition()
		{
			return this.As<INpcLookAtPositionT>();
		}

		// Token: 0x0603371B RID: 210715 RVA: 0x006EF482 File Offset: 0x006ED682
		public static INpcLookAtTypeBase_UnionUnion FromINpcLookAtPosition(INpcLookAtPositionT _inpclookatposition)
		{
			return new INpcLookAtTypeBase_UnionUnion
			{
				Type = INpcLookAtTypeBase_Union.INpcLookAtPosition,
				Value = _inpclookatposition
			};
		}

		// Token: 0x0603371C RID: 210716 RVA: 0x006EF498 File Offset: 0x006ED698
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
