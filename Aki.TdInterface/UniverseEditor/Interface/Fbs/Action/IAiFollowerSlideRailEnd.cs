using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006179 RID: 24953
	public struct IAiFollowerSlideRailEnd : IFlatbufferObject
	{
		// Token: 0x1700BA07 RID: 47623
		// (get) Token: 0x0602AFA0 RID: 176032 RVA: 0x005EE05E File Offset: 0x005EC25E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602AFA1 RID: 176033 RVA: 0x005EE06B File Offset: 0x005EC26B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602AFA2 RID: 176034 RVA: 0x005EE074 File Offset: 0x005EC274
		public static IAiFollowerSlideRailEnd GetRootAsIAiFollowerSlideRailEnd(ByteBuffer _bb)
		{
			return IAiFollowerSlideRailEnd.GetRootAsIAiFollowerSlideRailEnd(_bb, default(IAiFollowerSlideRailEnd));
		}

		// Token: 0x0602AFA3 RID: 176035 RVA: 0x005EE090 File Offset: 0x005EC290
		public static IAiFollowerSlideRailEnd GetRootAsIAiFollowerSlideRailEnd(ByteBuffer _bb, IAiFollowerSlideRailEnd obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602AFA4 RID: 176036 RVA: 0x005EE0AD File Offset: 0x005EC2AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602AFA5 RID: 176037 RVA: 0x005EE0BC File Offset: 0x005EC2BC
		public IAiFollowerSlideRailEnd __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BA08 RID: 47624
		// (get) Token: 0x0602AFA6 RID: 176038 RVA: 0x005EE0CC File Offset: 0x005EC2CC
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

		// Token: 0x1700BA09 RID: 47625
		// (get) Token: 0x0602AFA7 RID: 176039 RVA: 0x005EE108 File Offset: 0x005EC308
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

		// Token: 0x0602AFA8 RID: 176040 RVA: 0x005EE144 File Offset: 0x005EC344
		public static Offset<IAiFollowerSlideRailEnd> CreateIAiFollowerSlideRailEnd(FlatBufferBuilder builder, ESlideRailEndType Type = ESlideRailEndType.Player, int AiEntityId = 0)
		{
			builder.StartTable(2);
			IAiFollowerSlideRailEnd.AddAiEntityId(builder, AiEntityId);
			IAiFollowerSlideRailEnd.AddType(builder, Type);
			return IAiFollowerSlideRailEnd.EndIAiFollowerSlideRailEnd(builder);
		}

		// Token: 0x0602AFA9 RID: 176041 RVA: 0x005EE161 File Offset: 0x005EC361
		public static void StartIAiFollowerSlideRailEnd(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602AFAA RID: 176042 RVA: 0x005EE16A File Offset: 0x005EC36A
		public static void AddType(FlatBufferBuilder builder, ESlideRailEndType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602AFAB RID: 176043 RVA: 0x005EE175 File Offset: 0x005EC375
		public static void AddAiEntityId(FlatBufferBuilder builder, int aiEntityId)
		{
			builder.AddInt(1, aiEntityId, 0);
		}

		// Token: 0x0602AFAC RID: 176044 RVA: 0x005EE180 File Offset: 0x005EC380
		public static Offset<IAiFollowerSlideRailEnd> EndIAiFollowerSlideRailEnd(FlatBufferBuilder builder)
		{
			return new Offset<IAiFollowerSlideRailEnd>(builder.EndTable());
		}

		// Token: 0x0602AFAD RID: 176045 RVA: 0x005EE190 File Offset: 0x005EC390
		public IAiFollowerSlideRailEndT UnPack()
		{
			IAiFollowerSlideRailEndT aiFollowerSlideRailEndT = new IAiFollowerSlideRailEndT();
			this.UnPackTo(aiFollowerSlideRailEndT);
			return aiFollowerSlideRailEndT;
		}

		// Token: 0x0602AFAE RID: 176046 RVA: 0x005EE1AB File Offset: 0x005EC3AB
		public void UnPackTo(IAiFollowerSlideRailEndT _o)
		{
			_o.Type = this.Type;
			_o.AiEntityId = this.AiEntityId;
		}

		// Token: 0x0602AFAF RID: 176047 RVA: 0x005EE1C8 File Offset: 0x005EC3C8
		public static Offset<IAiFollowerSlideRailEnd> Pack(FlatBufferBuilder builder, IAiFollowerSlideRailEndT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAiFollowerSlideRailEnd>);
			}
			return IAiFollowerSlideRailEnd.CreateIAiFollowerSlideRailEnd(builder, _o.Type, _o.AiEntityId);
		}

		// Token: 0x04010676 RID: 67190
		private Table __p;
	}
}
