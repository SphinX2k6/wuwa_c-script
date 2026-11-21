using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067E4 RID: 26596
	public struct IAiFollowerSlideRailEnd : IFlatbufferObject
	{
		// Token: 0x1700C385 RID: 50053
		// (get) Token: 0x0602D6D1 RID: 186065 RVA: 0x006388D2 File Offset: 0x00636AD2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D6D2 RID: 186066 RVA: 0x006388DF File Offset: 0x00636ADF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D6D3 RID: 186067 RVA: 0x006388E8 File Offset: 0x00636AE8
		public static IAiFollowerSlideRailEnd GetRootAsIAiFollowerSlideRailEnd(ByteBuffer _bb)
		{
			return IAiFollowerSlideRailEnd.GetRootAsIAiFollowerSlideRailEnd(_bb, default(IAiFollowerSlideRailEnd));
		}

		// Token: 0x0602D6D4 RID: 186068 RVA: 0x00638904 File Offset: 0x00636B04
		public static IAiFollowerSlideRailEnd GetRootAsIAiFollowerSlideRailEnd(ByteBuffer _bb, IAiFollowerSlideRailEnd obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D6D5 RID: 186069 RVA: 0x00638921 File Offset: 0x00636B21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D6D6 RID: 186070 RVA: 0x00638930 File Offset: 0x00636B30
		public IAiFollowerSlideRailEnd __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C386 RID: 50054
		// (get) Token: 0x0602D6D7 RID: 186071 RVA: 0x00638940 File Offset: 0x00636B40
		public ESlideRailEndType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESlideRailEndType.Player;
				}
				return (ESlideRailEndType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C387 RID: 50055
		// (get) Token: 0x0602D6D8 RID: 186072 RVA: 0x0063897C File Offset: 0x00636B7C
		public int AiEntityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D6D9 RID: 186073 RVA: 0x006389B8 File Offset: 0x00636BB8
		public static Offset<IAiFollowerSlideRailEnd> CreateIAiFollowerSlideRailEnd(FlatBufferBuilder builder, ESlideRailEndType Type = ESlideRailEndType.Player, int AiEntityId = 0)
		{
			builder.StartTable(2);
			IAiFollowerSlideRailEnd.AddAiEntityId(builder, AiEntityId);
			IAiFollowerSlideRailEnd.AddType(builder, Type);
			return IAiFollowerSlideRailEnd.EndIAiFollowerSlideRailEnd(builder);
		}

		// Token: 0x0602D6DA RID: 186074 RVA: 0x006389D5 File Offset: 0x00636BD5
		public static void StartIAiFollowerSlideRailEnd(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602D6DB RID: 186075 RVA: 0x006389DE File Offset: 0x00636BDE
		public static void AddType(FlatBufferBuilder builder, ESlideRailEndType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D6DC RID: 186076 RVA: 0x006389E9 File Offset: 0x00636BE9
		public static void AddAiEntityId(FlatBufferBuilder builder, int aiEntityId)
		{
			builder.AddInt(1, aiEntityId, 0);
		}

		// Token: 0x0602D6DD RID: 186077 RVA: 0x006389F4 File Offset: 0x00636BF4
		public static Offset<IAiFollowerSlideRailEnd> EndIAiFollowerSlideRailEnd(FlatBufferBuilder builder)
		{
			return new Offset<IAiFollowerSlideRailEnd>(builder.EndTable());
		}

		// Token: 0x0602D6DE RID: 186078 RVA: 0x00638A04 File Offset: 0x00636C04
		public IAiFollowerSlideRailEndT UnPack()
		{
			IAiFollowerSlideRailEndT aiFollowerSlideRailEndT = new IAiFollowerSlideRailEndT();
			this.UnPackTo(aiFollowerSlideRailEndT);
			return aiFollowerSlideRailEndT;
		}

		// Token: 0x0602D6DF RID: 186079 RVA: 0x00638A1F File Offset: 0x00636C1F
		public void UnPackTo(IAiFollowerSlideRailEndT _o)
		{
			_o.Type = this.Type;
			_o.AiEntityId = this.AiEntityId;
		}

		// Token: 0x0602D6E0 RID: 186080 RVA: 0x00638A3C File Offset: 0x00636C3C
		public static Offset<IAiFollowerSlideRailEnd> Pack(FlatBufferBuilder builder, IAiFollowerSlideRailEndT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAiFollowerSlideRailEnd>);
			}
			return IAiFollowerSlideRailEnd.CreateIAiFollowerSlideRailEnd(builder, _o.Type, _o.AiEntityId);
		}

		// Token: 0x04011485 RID: 70789
		private Table __p;
	}
}
