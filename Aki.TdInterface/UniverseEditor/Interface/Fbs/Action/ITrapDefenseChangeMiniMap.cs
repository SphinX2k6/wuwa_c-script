using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007457 RID: 29783
	public struct ITrapDefenseChangeMiniMap : IFlatbufferObject
	{
		// Token: 0x1700E21B RID: 57883
		// (get) Token: 0x060361BF RID: 221631 RVA: 0x0075BACF File Offset: 0x00759CCF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060361C0 RID: 221632 RVA: 0x0075BADC File Offset: 0x00759CDC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060361C1 RID: 221633 RVA: 0x0075BAE4 File Offset: 0x00759CE4
		public static ITrapDefenseChangeMiniMap GetRootAsITrapDefenseChangeMiniMap(ByteBuffer _bb)
		{
			return ITrapDefenseChangeMiniMap.GetRootAsITrapDefenseChangeMiniMap(_bb, default(ITrapDefenseChangeMiniMap));
		}

		// Token: 0x060361C2 RID: 221634 RVA: 0x0075BB00 File Offset: 0x00759D00
		public static ITrapDefenseChangeMiniMap GetRootAsITrapDefenseChangeMiniMap(ByteBuffer _bb, ITrapDefenseChangeMiniMap obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060361C3 RID: 221635 RVA: 0x0075BB1D File Offset: 0x00759D1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060361C4 RID: 221636 RVA: 0x0075BB2C File Offset: 0x00759D2C
		public ITrapDefenseChangeMiniMap __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E21C RID: 57884
		// (get) Token: 0x060361C5 RID: 221637 RVA: 0x0075BB3C File Offset: 0x00759D3C
		public int MiniMapId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060361C6 RID: 221638 RVA: 0x0075BB78 File Offset: 0x00759D78
		public static Offset<ITrapDefenseChangeMiniMap> CreateITrapDefenseChangeMiniMap(FlatBufferBuilder builder, int MiniMapId = 0)
		{
			builder.StartTable(1);
			ITrapDefenseChangeMiniMap.AddMiniMapId(builder, MiniMapId);
			return ITrapDefenseChangeMiniMap.EndITrapDefenseChangeMiniMap(builder);
		}

		// Token: 0x060361C7 RID: 221639 RVA: 0x0075BB8E File Offset: 0x00759D8E
		public static void StartITrapDefenseChangeMiniMap(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060361C8 RID: 221640 RVA: 0x0075BB97 File Offset: 0x00759D97
		public static void AddMiniMapId(FlatBufferBuilder builder, int miniMapId)
		{
			builder.AddInt(0, miniMapId, 0);
		}

		// Token: 0x060361C9 RID: 221641 RVA: 0x0075BBA2 File Offset: 0x00759DA2
		public static Offset<ITrapDefenseChangeMiniMap> EndITrapDefenseChangeMiniMap(FlatBufferBuilder builder)
		{
			return new Offset<ITrapDefenseChangeMiniMap>(builder.EndTable());
		}

		// Token: 0x060361CA RID: 221642 RVA: 0x0075BBB0 File Offset: 0x00759DB0
		public ITrapDefenseChangeMiniMapT UnPack()
		{
			ITrapDefenseChangeMiniMapT trapDefenseChangeMiniMapT = new ITrapDefenseChangeMiniMapT();
			this.UnPackTo(trapDefenseChangeMiniMapT);
			return trapDefenseChangeMiniMapT;
		}

		// Token: 0x060361CB RID: 221643 RVA: 0x0075BBCB File Offset: 0x00759DCB
		public void UnPackTo(ITrapDefenseChangeMiniMapT _o)
		{
			_o.MiniMapId = this.MiniMapId;
		}

		// Token: 0x060361CC RID: 221644 RVA: 0x0075BBDC File Offset: 0x00759DDC
		public static Offset<ITrapDefenseChangeMiniMap> Pack(FlatBufferBuilder builder, ITrapDefenseChangeMiniMapT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrapDefenseChangeMiniMap>);
			}
			return ITrapDefenseChangeMiniMap.CreateITrapDefenseChangeMiniMap(builder, _o.MiniMapId);
		}

		// Token: 0x040122E1 RID: 74465
		private Table __p;
	}
}
