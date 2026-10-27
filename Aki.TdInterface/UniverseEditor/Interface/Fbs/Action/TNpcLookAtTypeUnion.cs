using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200773E RID: 30526
	public class TNpcLookAtTypeUnion
	{
		// Token: 0x1700E66D RID: 58989
		// (get) Token: 0x06037770 RID: 227184 RVA: 0x00782376 File Offset: 0x00780576
		// (set) Token: 0x06037771 RID: 227185 RVA: 0x0078237E File Offset: 0x0078057E
		public TNpcLookAtType Type { get; set; }

		// Token: 0x1700E66E RID: 58990
		// (get) Token: 0x06037772 RID: 227186 RVA: 0x00782387 File Offset: 0x00780587
		// (set) Token: 0x06037773 RID: 227187 RVA: 0x0078238F File Offset: 0x0078058F
		public object Value { get; set; }

		// Token: 0x06037774 RID: 227188 RVA: 0x00782398 File Offset: 0x00780598
		public TNpcLookAtTypeUnion()
		{
			this.Type = TNpcLookAtType.NONE;
			this.Value = null;
		}

		// Token: 0x06037775 RID: 227189 RVA: 0x007823AE File Offset: 0x007805AE
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037776 RID: 227190 RVA: 0x007823C0 File Offset: 0x007805C0
		public INpcLookAtEntityT AsINpcLookAtEntity()
		{
			return this.As<INpcLookAtEntityT>();
		}

		// Token: 0x06037777 RID: 227191 RVA: 0x007823C8 File Offset: 0x007805C8
		public static TNpcLookAtTypeUnion FromINpcLookAtEntity(INpcLookAtEntityT _inpclookatentity)
		{
			return new TNpcLookAtTypeUnion
			{
				Type = TNpcLookAtType.INpcLookAtEntity,
				Value = _inpclookatentity
			};
		}

		// Token: 0x06037778 RID: 227192 RVA: 0x007823DD File Offset: 0x007805DD
		public INpcLookAtPlayerT AsINpcLookAtPlayer()
		{
			return this.As<INpcLookAtPlayerT>();
		}

		// Token: 0x06037779 RID: 227193 RVA: 0x007823E5 File Offset: 0x007805E5
		public static TNpcLookAtTypeUnion FromINpcLookAtPlayer(INpcLookAtPlayerT _inpclookatplayer)
		{
			return new TNpcLookAtTypeUnion
			{
				Type = TNpcLookAtType.INpcLookAtPlayer,
				Value = _inpclookatplayer
			};
		}

		// Token: 0x0603777A RID: 227194 RVA: 0x007823FA File Offset: 0x007805FA
		public INpcLookAtPositionT AsINpcLookAtPosition()
		{
			return this.As<INpcLookAtPositionT>();
		}

		// Token: 0x0603777B RID: 227195 RVA: 0x00782402 File Offset: 0x00780602
		public static TNpcLookAtTypeUnion FromINpcLookAtPosition(INpcLookAtPositionT _inpclookatposition)
		{
			return new TNpcLookAtTypeUnion
			{
				Type = TNpcLookAtType.INpcLookAtPosition,
				Value = _inpclookatposition
			};
		}

		// Token: 0x0603777C RID: 227196 RVA: 0x00782418 File Offset: 0x00780618
		public static int Pack(FlatBufferBuilder builder, TNpcLookAtTypeUnion _o)
		{
			switch (_o.Type)
			{
			case TNpcLookAtType.INpcLookAtEntity:
				return INpcLookAtEntity.Pack(builder, _o.AsINpcLookAtEntity()).Value;
			case TNpcLookAtType.INpcLookAtPlayer:
				return INpcLookAtPlayer.Pack(builder, _o.AsINpcLookAtPlayer()).Value;
			case TNpcLookAtType.INpcLookAtPosition:
				return INpcLookAtPosition.Pack(builder, _o.AsINpcLookAtPosition()).Value;
			default:
				return 0;
			}
		}
	}
}
