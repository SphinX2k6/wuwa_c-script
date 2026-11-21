using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F67 RID: 32615
	public class TNpcLookAtTypeUnion
	{
		// Token: 0x1700F2BD RID: 62141
		// (get) Token: 0x0603ACAB RID: 240811 RVA: 0x007E7306 File Offset: 0x007E5506
		// (set) Token: 0x0603ACAC RID: 240812 RVA: 0x007E730E File Offset: 0x007E550E
		public TNpcLookAtType Type { get; set; }

		// Token: 0x1700F2BE RID: 62142
		// (get) Token: 0x0603ACAD RID: 240813 RVA: 0x007E7317 File Offset: 0x007E5517
		// (set) Token: 0x0603ACAE RID: 240814 RVA: 0x007E731F File Offset: 0x007E551F
		public object Value { get; set; }

		// Token: 0x0603ACAF RID: 240815 RVA: 0x007E7328 File Offset: 0x007E5528
		public TNpcLookAtTypeUnion()
		{
			this.Type = TNpcLookAtType.NONE;
			this.Value = null;
		}

		// Token: 0x0603ACB0 RID: 240816 RVA: 0x007E733E File Offset: 0x007E553E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603ACB1 RID: 240817 RVA: 0x007E7350 File Offset: 0x007E5550
		public INpcLookAtEntityT AsINpcLookAtEntity()
		{
			return this.As<INpcLookAtEntityT>();
		}

		// Token: 0x0603ACB2 RID: 240818 RVA: 0x007E7358 File Offset: 0x007E5558
		public static TNpcLookAtTypeUnion FromINpcLookAtEntity(INpcLookAtEntityT _inpclookatentity)
		{
			return new TNpcLookAtTypeUnion
			{
				Type = TNpcLookAtType.INpcLookAtEntity,
				Value = _inpclookatentity
			};
		}

		// Token: 0x0603ACB3 RID: 240819 RVA: 0x007E736D File Offset: 0x007E556D
		public INpcLookAtPlayerT AsINpcLookAtPlayer()
		{
			return this.As<INpcLookAtPlayerT>();
		}

		// Token: 0x0603ACB4 RID: 240820 RVA: 0x007E7375 File Offset: 0x007E5575
		public static TNpcLookAtTypeUnion FromINpcLookAtPlayer(INpcLookAtPlayerT _inpclookatplayer)
		{
			return new TNpcLookAtTypeUnion
			{
				Type = TNpcLookAtType.INpcLookAtPlayer,
				Value = _inpclookatplayer
			};
		}

		// Token: 0x0603ACB5 RID: 240821 RVA: 0x007E738A File Offset: 0x007E558A
		public INpcLookAtPositionT AsINpcLookAtPosition()
		{
			return this.As<INpcLookAtPositionT>();
		}

		// Token: 0x0603ACB6 RID: 240822 RVA: 0x007E7392 File Offset: 0x007E5592
		public static TNpcLookAtTypeUnion FromINpcLookAtPosition(INpcLookAtPositionT _inpclookatposition)
		{
			return new TNpcLookAtTypeUnion
			{
				Type = TNpcLookAtType.INpcLookAtPosition,
				Value = _inpclookatposition
			};
		}

		// Token: 0x0603ACB7 RID: 240823 RVA: 0x007E73A8 File Offset: 0x007E55A8
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
