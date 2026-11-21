using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069BD RID: 27069
	public struct ICharacterLookAtPositionData : IFlatbufferObject
	{
		// Token: 0x1700C730 RID: 50992
		// (get) Token: 0x0602E6EA RID: 190186 RVA: 0x00655F2D File Offset: 0x0065412D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E6EB RID: 190187 RVA: 0x00655F3A File Offset: 0x0065413A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E6EC RID: 190188 RVA: 0x00655F44 File Offset: 0x00654144
		public static ICharacterLookAtPositionData GetRootAsICharacterLookAtPositionData(ByteBuffer _bb)
		{
			return ICharacterLookAtPositionData.GetRootAsICharacterLookAtPositionData(_bb, default(ICharacterLookAtPositionData));
		}

		// Token: 0x0602E6ED RID: 190189 RVA: 0x00655F60 File Offset: 0x00654160
		public static ICharacterLookAtPositionData GetRootAsICharacterLookAtPositionData(ByteBuffer _bb, ICharacterLookAtPositionData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E6EE RID: 190190 RVA: 0x00655F7D File Offset: 0x0065417D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E6EF RID: 190191 RVA: 0x00655F8C File Offset: 0x0065418C
		public ICharacterLookAtPositionData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C731 RID: 50993
		// (get) Token: 0x0602E6F0 RID: 190192 RVA: 0x00655F9C File Offset: 0x0065419C
		public ECharacterLookAt Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECharacterLookAt.Empty;
				}
				return (ECharacterLookAt)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C732 RID: 50994
		// (get) Token: 0x0602E6F1 RID: 190193 RVA: 0x00655FD8 File Offset: 0x006541D8
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

		// Token: 0x0602E6F2 RID: 190194 RVA: 0x00656035 File Offset: 0x00654235
		public static Offset<ICharacterLookAtPositionData> CreateICharacterLookAtPositionData(FlatBufferBuilder builder, ECharacterLookAt Type = ECharacterLookAt.Empty, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			ICharacterLookAtPositionData.AddPos(builder, PosOffset);
			ICharacterLookAtPositionData.AddType(builder, Type);
			return ICharacterLookAtPositionData.EndICharacterLookAtPositionData(builder);
		}

		// Token: 0x0602E6F3 RID: 190195 RVA: 0x00656052 File Offset: 0x00654252
		public static void StartICharacterLookAtPositionData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602E6F4 RID: 190196 RVA: 0x0065605B File Offset: 0x0065425B
		public static void AddType(FlatBufferBuilder builder, ECharacterLookAt type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E6F5 RID: 190197 RVA: 0x00656066 File Offset: 0x00654266
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(1, posOffset.Value, 0);
		}

		// Token: 0x0602E6F6 RID: 190198 RVA: 0x00656076 File Offset: 0x00654276
		public static Offset<ICharacterLookAtPositionData> EndICharacterLookAtPositionData(FlatBufferBuilder builder)
		{
			return new Offset<ICharacterLookAtPositionData>(builder.EndTable());
		}

		// Token: 0x0602E6F7 RID: 190199 RVA: 0x00656084 File Offset: 0x00654284
		public ICharacterLookAtPositionDataT UnPack()
		{
			ICharacterLookAtPositionDataT characterLookAtPositionDataT = new ICharacterLookAtPositionDataT();
			this.UnPackTo(characterLookAtPositionDataT);
			return characterLookAtPositionDataT;
		}

		// Token: 0x0602E6F8 RID: 190200 RVA: 0x006560A0 File Offset: 0x006542A0
		public void UnPackTo(ICharacterLookAtPositionDataT _o)
		{
			_o.Type = this.Type;
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
		}

		// Token: 0x0602E6F9 RID: 190201 RVA: 0x006560E8 File Offset: 0x006542E8
		public static Offset<ICharacterLookAtPositionData> Pack(FlatBufferBuilder builder, ICharacterLookAtPositionDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICharacterLookAtPositionData>);
			}
			Offset<IVectorInfo> posOffset = (_o.Pos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Pos);
			return ICharacterLookAtPositionData.CreateICharacterLookAtPositionData(builder, _o.Type, posOffset);
		}

		// Token: 0x0401172C RID: 71468
		private Table __p;
	}
}
