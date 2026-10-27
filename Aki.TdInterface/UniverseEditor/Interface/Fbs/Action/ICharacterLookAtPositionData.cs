using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200634C RID: 25420
	public struct ICharacterLookAtPositionData : IFlatbufferObject
	{
		// Token: 0x1700BDA8 RID: 48552
		// (get) Token: 0x0602BF80 RID: 180096 RVA: 0x0060ADD9 File Offset: 0x00608FD9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BF81 RID: 180097 RVA: 0x0060ADE6 File Offset: 0x00608FE6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BF82 RID: 180098 RVA: 0x0060ADF0 File Offset: 0x00608FF0
		public static ICharacterLookAtPositionData GetRootAsICharacterLookAtPositionData(ByteBuffer _bb)
		{
			return ICharacterLookAtPositionData.GetRootAsICharacterLookAtPositionData(_bb, default(ICharacterLookAtPositionData));
		}

		// Token: 0x0602BF83 RID: 180099 RVA: 0x0060AE0C File Offset: 0x0060900C
		public static ICharacterLookAtPositionData GetRootAsICharacterLookAtPositionData(ByteBuffer _bb, ICharacterLookAtPositionData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BF84 RID: 180100 RVA: 0x0060AE29 File Offset: 0x00609029
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BF85 RID: 180101 RVA: 0x0060AE38 File Offset: 0x00609038
		public ICharacterLookAtPositionData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BDA9 RID: 48553
		// (get) Token: 0x0602BF86 RID: 180102 RVA: 0x0060AE48 File Offset: 0x00609048
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

		// Token: 0x1700BDAA RID: 48554
		// (get) Token: 0x0602BF87 RID: 180103 RVA: 0x0060AE84 File Offset: 0x00609084
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

		// Token: 0x0602BF88 RID: 180104 RVA: 0x0060AEE1 File Offset: 0x006090E1
		public static Offset<ICharacterLookAtPositionData> CreateICharacterLookAtPositionData(FlatBufferBuilder builder, ECharacterLookAt Type = ECharacterLookAt.Empty, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			ICharacterLookAtPositionData.AddPos(builder, PosOffset);
			ICharacterLookAtPositionData.AddType(builder, Type);
			return ICharacterLookAtPositionData.EndICharacterLookAtPositionData(builder);
		}

		// Token: 0x0602BF89 RID: 180105 RVA: 0x0060AEFE File Offset: 0x006090FE
		public static void StartICharacterLookAtPositionData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602BF8A RID: 180106 RVA: 0x0060AF07 File Offset: 0x00609107
		public static void AddType(FlatBufferBuilder builder, ECharacterLookAt type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602BF8B RID: 180107 RVA: 0x0060AF12 File Offset: 0x00609112
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(1, posOffset.Value, 0);
		}

		// Token: 0x0602BF8C RID: 180108 RVA: 0x0060AF22 File Offset: 0x00609122
		public static Offset<ICharacterLookAtPositionData> EndICharacterLookAtPositionData(FlatBufferBuilder builder)
		{
			return new Offset<ICharacterLookAtPositionData>(builder.EndTable());
		}

		// Token: 0x0602BF8D RID: 180109 RVA: 0x0060AF30 File Offset: 0x00609130
		public ICharacterLookAtPositionDataT UnPack()
		{
			ICharacterLookAtPositionDataT characterLookAtPositionDataT = new ICharacterLookAtPositionDataT();
			this.UnPackTo(characterLookAtPositionDataT);
			return characterLookAtPositionDataT;
		}

		// Token: 0x0602BF8E RID: 180110 RVA: 0x0060AF4C File Offset: 0x0060914C
		public void UnPackTo(ICharacterLookAtPositionDataT _o)
		{
			_o.Type = this.Type;
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
		}

		// Token: 0x0602BF8F RID: 180111 RVA: 0x0060AF94 File Offset: 0x00609194
		public static Offset<ICharacterLookAtPositionData> Pack(FlatBufferBuilder builder, ICharacterLookAtPositionDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICharacterLookAtPositionData>);
			}
			Offset<IVectorInfo> posOffset = (_o.Pos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Pos);
			return ICharacterLookAtPositionData.CreateICharacterLookAtPositionData(builder, _o.Type, posOffset);
		}

		// Token: 0x04010917 RID: 67863
		private Table __p;
	}
}
