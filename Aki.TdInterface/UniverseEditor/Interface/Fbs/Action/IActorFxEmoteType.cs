using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006724 RID: 26404
	public struct IActorFxEmoteType : IFlatbufferObject
	{
		// Token: 0x1700BFF3 RID: 49139
		// (get) Token: 0x0602CB89 RID: 183177 RVA: 0x0061E3A8 File Offset: 0x0061C5A8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CB8A RID: 183178 RVA: 0x0061E3B5 File Offset: 0x0061C5B5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CB8B RID: 183179 RVA: 0x0061E3BC File Offset: 0x0061C5BC
		public static IActorFxEmoteType GetRootAsIActorFxEmoteType(ByteBuffer _bb)
		{
			return IActorFxEmoteType.GetRootAsIActorFxEmoteType(_bb, default(IActorFxEmoteType));
		}

		// Token: 0x0602CB8C RID: 183180 RVA: 0x0061E3D8 File Offset: 0x0061C5D8
		public static IActorFxEmoteType GetRootAsIActorFxEmoteType(ByteBuffer _bb, IActorFxEmoteType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CB8D RID: 183181 RVA: 0x0061E3F5 File Offset: 0x0061C5F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CB8E RID: 183182 RVA: 0x0061E404 File Offset: 0x0061C604
		public IActorFxEmoteType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BFF4 RID: 49140
		// (get) Token: 0x0602CB8F RID: 183183 RVA: 0x0061E414 File Offset: 0x0061C614
		public EActorFxEmoteType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EActorFxEmoteType.Play;
				}
				return (EActorFxEmoteType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602CB90 RID: 183184 RVA: 0x0061E450 File Offset: 0x0061C650
		public static Offset<IActorFxEmoteType> CreateIActorFxEmoteType(FlatBufferBuilder builder, EActorFxEmoteType Type = EActorFxEmoteType.Play)
		{
			builder.StartTable(1);
			IActorFxEmoteType.AddType(builder, Type);
			return IActorFxEmoteType.EndIActorFxEmoteType(builder);
		}

		// Token: 0x0602CB91 RID: 183185 RVA: 0x0061E466 File Offset: 0x0061C666
		public static void StartIActorFxEmoteType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602CB92 RID: 183186 RVA: 0x0061E46F File Offset: 0x0061C66F
		public static void AddType(FlatBufferBuilder builder, EActorFxEmoteType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CB93 RID: 183187 RVA: 0x0061E47A File Offset: 0x0061C67A
		public static Offset<IActorFxEmoteType> EndIActorFxEmoteType(FlatBufferBuilder builder)
		{
			return new Offset<IActorFxEmoteType>(builder.EndTable());
		}

		// Token: 0x0602CB94 RID: 183188 RVA: 0x0061E488 File Offset: 0x0061C688
		public IActorFxEmoteTypeT UnPack()
		{
			IActorFxEmoteTypeT actorFxEmoteTypeT = new IActorFxEmoteTypeT();
			this.UnPackTo(actorFxEmoteTypeT);
			return actorFxEmoteTypeT;
		}

		// Token: 0x0602CB95 RID: 183189 RVA: 0x0061E4A3 File Offset: 0x0061C6A3
		public void UnPackTo(IActorFxEmoteTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602CB96 RID: 183190 RVA: 0x0061E4B4 File Offset: 0x0061C6B4
		public static Offset<IActorFxEmoteType> Pack(FlatBufferBuilder builder, IActorFxEmoteTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorFxEmoteType>);
			}
			return IActorFxEmoteType.CreateIActorFxEmoteType(builder, _o.Type);
		}

		// Token: 0x0401126D RID: 70253
		private Table __p;
	}
}
