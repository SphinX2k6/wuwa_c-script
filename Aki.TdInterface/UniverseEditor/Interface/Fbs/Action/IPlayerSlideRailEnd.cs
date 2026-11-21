using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007489 RID: 29833
	public struct IPlayerSlideRailEnd : IFlatbufferObject
	{
		// Token: 0x1700DB28 RID: 56104
		// (get) Token: 0x060343A0 RID: 213920 RVA: 0x00708D5C File Offset: 0x00706F5C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060343A1 RID: 213921 RVA: 0x00708D69 File Offset: 0x00706F69
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060343A2 RID: 213922 RVA: 0x00708D70 File Offset: 0x00706F70
		public static IPlayerSlideRailEnd GetRootAsIPlayerSlideRailEnd(ByteBuffer _bb)
		{
			return IPlayerSlideRailEnd.GetRootAsIPlayerSlideRailEnd(_bb, default(IPlayerSlideRailEnd));
		}

		// Token: 0x060343A3 RID: 213923 RVA: 0x00708D8C File Offset: 0x00706F8C
		public static IPlayerSlideRailEnd GetRootAsIPlayerSlideRailEnd(ByteBuffer _bb, IPlayerSlideRailEnd obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060343A4 RID: 213924 RVA: 0x00708DA9 File Offset: 0x00706FA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060343A5 RID: 213925 RVA: 0x00708DB8 File Offset: 0x00706FB8
		public IPlayerSlideRailEnd __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DB29 RID: 56105
		// (get) Token: 0x060343A6 RID: 213926 RVA: 0x00708DC8 File Offset: 0x00706FC8
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

		// Token: 0x060343A7 RID: 213927 RVA: 0x00708E04 File Offset: 0x00707004
		public static Offset<IPlayerSlideRailEnd> CreateIPlayerSlideRailEnd(FlatBufferBuilder builder, ESlideRailEndType Type = ESlideRailEndType.Player)
		{
			builder.StartTable(1);
			IPlayerSlideRailEnd.AddType(builder, Type);
			return IPlayerSlideRailEnd.EndIPlayerSlideRailEnd(builder);
		}

		// Token: 0x060343A8 RID: 213928 RVA: 0x00708E1A File Offset: 0x0070701A
		public static void StartIPlayerSlideRailEnd(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060343A9 RID: 213929 RVA: 0x00708E23 File Offset: 0x00707023
		public static void AddType(FlatBufferBuilder builder, ESlideRailEndType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060343AA RID: 213930 RVA: 0x00708E2E File Offset: 0x0070702E
		public static Offset<IPlayerSlideRailEnd> EndIPlayerSlideRailEnd(FlatBufferBuilder builder)
		{
			return new Offset<IPlayerSlideRailEnd>(builder.EndTable());
		}

		// Token: 0x060343AB RID: 213931 RVA: 0x00708E3C File Offset: 0x0070703C
		public IPlayerSlideRailEndT UnPack()
		{
			IPlayerSlideRailEndT playerSlideRailEndT = new IPlayerSlideRailEndT();
			this.UnPackTo(playerSlideRailEndT);
			return playerSlideRailEndT;
		}

		// Token: 0x060343AC RID: 213932 RVA: 0x00708E57 File Offset: 0x00707057
		public void UnPackTo(IPlayerSlideRailEndT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060343AD RID: 213933 RVA: 0x00708E68 File Offset: 0x00707068
		public static Offset<IPlayerSlideRailEnd> Pack(FlatBufferBuilder builder, IPlayerSlideRailEndT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayerSlideRailEnd>);
			}
			return IPlayerSlideRailEnd.CreateIPlayerSlideRailEnd(builder, _o.Type);
		}

		// Token: 0x04012604 RID: 75268
		private Table __p;
	}
}
