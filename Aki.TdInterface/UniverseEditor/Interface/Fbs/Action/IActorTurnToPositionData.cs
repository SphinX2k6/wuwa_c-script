using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200676C RID: 26476
	public struct IActorTurnToPositionData : IFlatbufferObject
	{
		// Token: 0x1700C07E RID: 49278
		// (get) Token: 0x0602CDF8 RID: 183800 RVA: 0x00622C35 File Offset: 0x00620E35
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CDF9 RID: 183801 RVA: 0x00622C42 File Offset: 0x00620E42
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CDFA RID: 183802 RVA: 0x00622C4C File Offset: 0x00620E4C
		public static IActorTurnToPositionData GetRootAsIActorTurnToPositionData(ByteBuffer _bb)
		{
			return IActorTurnToPositionData.GetRootAsIActorTurnToPositionData(_bb, default(IActorTurnToPositionData));
		}

		// Token: 0x0602CDFB RID: 183803 RVA: 0x00622C68 File Offset: 0x00620E68
		public static IActorTurnToPositionData GetRootAsIActorTurnToPositionData(ByteBuffer _bb, IActorTurnToPositionData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CDFC RID: 183804 RVA: 0x00622C85 File Offset: 0x00620E85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CDFD RID: 183805 RVA: 0x00622C94 File Offset: 0x00620E94
		public IActorTurnToPositionData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C07F RID: 49279
		// (get) Token: 0x0602CDFE RID: 183806 RVA: 0x00622CA4 File Offset: 0x00620EA4
		public EActorTurnToMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EActorTurnToMode.Talker;
				}
				return (EActorTurnToMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C080 RID: 49280
		// (get) Token: 0x0602CDFF RID: 183807 RVA: 0x00622CE0 File Offset: 0x00620EE0
		public IVectorInfo? Pos
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602CE00 RID: 183808 RVA: 0x00622D3D File Offset: 0x00620F3D
		public static Offset<IActorTurnToPositionData> CreateIActorTurnToPositionData(FlatBufferBuilder builder, EActorTurnToMode Type = EActorTurnToMode.Talker, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IActorTurnToPositionData.AddPos(builder, PosOffset);
			IActorTurnToPositionData.AddType(builder, Type);
			return IActorTurnToPositionData.EndIActorTurnToPositionData(builder);
		}

		// Token: 0x0602CE01 RID: 183809 RVA: 0x00622D5A File Offset: 0x00620F5A
		public static void StartIActorTurnToPositionData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602CE02 RID: 183810 RVA: 0x00622D63 File Offset: 0x00620F63
		public static void AddType(FlatBufferBuilder builder, EActorTurnToMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CE03 RID: 183811 RVA: 0x00622D6E File Offset: 0x00620F6E
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(1, posOffset.Value, 0);
		}

		// Token: 0x0602CE04 RID: 183812 RVA: 0x00622D7E File Offset: 0x00620F7E
		public static Offset<IActorTurnToPositionData> EndIActorTurnToPositionData(FlatBufferBuilder builder)
		{
			return new Offset<IActorTurnToPositionData>(builder.EndTable());
		}

		// Token: 0x0602CE05 RID: 183813 RVA: 0x00622D8C File Offset: 0x00620F8C
		public IActorTurnToPositionDataT UnPack()
		{
			IActorTurnToPositionDataT actorTurnToPositionDataT = new IActorTurnToPositionDataT();
			this.UnPackTo(actorTurnToPositionDataT);
			return actorTurnToPositionDataT;
		}

		// Token: 0x0602CE06 RID: 183814 RVA: 0x00622DA8 File Offset: 0x00620FA8
		public void UnPackTo(IActorTurnToPositionDataT _o)
		{
			_o.Type = this.Type;
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
		}

		// Token: 0x0602CE07 RID: 183815 RVA: 0x00622DF0 File Offset: 0x00620FF0
		public static Offset<IActorTurnToPositionData> Pack(FlatBufferBuilder builder, IActorTurnToPositionDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorTurnToPositionData>);
			}
			Offset<IVectorInfo> posOffset = (_o.Pos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Pos);
			return IActorTurnToPositionData.CreateIActorTurnToPositionData(builder, _o.Type, posOffset);
		}

		// Token: 0x040112D8 RID: 70360
		private Table __p;
	}
}
