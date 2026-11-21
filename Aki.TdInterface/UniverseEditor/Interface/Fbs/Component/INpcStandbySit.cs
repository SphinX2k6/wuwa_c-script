using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C09 RID: 23561
	public struct INpcStandbySit : IFlatbufferObject
	{
		// Token: 0x1700AC73 RID: 44147
		// (get) Token: 0x06026EDE RID: 159454 RVA: 0x00554362 File Offset: 0x00552562
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026EDF RID: 159455 RVA: 0x0055436F File Offset: 0x0055256F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026EE0 RID: 159456 RVA: 0x00554378 File Offset: 0x00552578
		public static INpcStandbySit GetRootAsINpcStandbySit(ByteBuffer _bb)
		{
			return INpcStandbySit.GetRootAsINpcStandbySit(_bb, default(INpcStandbySit));
		}

		// Token: 0x06026EE1 RID: 159457 RVA: 0x00554394 File Offset: 0x00552594
		public static INpcStandbySit GetRootAsINpcStandbySit(ByteBuffer _bb, INpcStandbySit obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026EE2 RID: 159458 RVA: 0x005543B1 File Offset: 0x005525B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026EE3 RID: 159459 RVA: 0x005543C0 File Offset: 0x005525C0
		public INpcStandbySit __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AC74 RID: 44148
		// (get) Token: 0x06026EE4 RID: 159460 RVA: 0x005543D0 File Offset: 0x005525D0
		public ENpcStandbyShowMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENpcStandbyShowMode.Finite;
				}
				return (ENpcStandbyShowMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026EE5 RID: 159461 RVA: 0x0055440C File Offset: 0x0055260C
		public INpcLookAtConfig? LookAtConfigs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new INpcLookAtConfig?(default(INpcLookAtConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AC75 RID: 44149
		// (get) Token: 0x06026EE6 RID: 159462 RVA: 0x0055446C File Offset: 0x0055266C
		public int LookAtConfigsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700AC76 RID: 44150
		// (get) Token: 0x06026EE7 RID: 159463 RVA: 0x00554498 File Offset: 0x00552698
		public string Montage
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026EE8 RID: 159464 RVA: 0x005544CF File Offset: 0x005526CF
		public Span<byte> GetMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06026EE9 RID: 159465 RVA: 0x005544DE File Offset: 0x005526DE
		public byte[] GetMontageArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700AC77 RID: 44151
		// (get) Token: 0x06026EEA RID: 159466 RVA: 0x005544EC File Offset: 0x005526EC
		public IMontageId? RegisteredMontageId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IMontageId?(default(IMontageId).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AC78 RID: 44152
		// (get) Token: 0x06026EEB RID: 159467 RVA: 0x0055454C File Offset: 0x0055274C
		public int FaceExpressionId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AC79 RID: 44153
		// (get) Token: 0x06026EEC RID: 159468 RVA: 0x0055458C File Offset: 0x0055278C
		public int PosEntityId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AC7A RID: 44154
		// (get) Token: 0x06026EED RID: 159469 RVA: 0x005545CC File Offset: 0x005527CC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026EEE RID: 159470 RVA: 0x0055460C File Offset: 0x0055280C
		public static Offset<INpcStandbySit> CreateINpcStandbySit(FlatBufferBuilder builder, ENpcStandbyShowMode Type = ENpcStandbyShowMode.Finite, VectorOffset LookAtConfigsOffset = default(VectorOffset), StringOffset MontageOffset = default(StringOffset), Offset<IMontageId> RegisteredMontageIdOffset = default(Offset<IMontageId>), int FaceExpressionId = 0, int PosEntityId = 0, byte NullMask = 0)
		{
			builder.StartTable(7);
			INpcStandbySit.AddPosEntityId(builder, PosEntityId);
			INpcStandbySit.AddFaceExpressionId(builder, FaceExpressionId);
			INpcStandbySit.AddRegisteredMontageId(builder, RegisteredMontageIdOffset);
			INpcStandbySit.AddMontage(builder, MontageOffset);
			INpcStandbySit.AddLookAtConfigs(builder, LookAtConfigsOffset);
			INpcStandbySit.AddNullMask(builder, NullMask);
			INpcStandbySit.AddType(builder, Type);
			return INpcStandbySit.EndINpcStandbySit(builder);
		}

		// Token: 0x06026EEF RID: 159471 RVA: 0x0055465B File Offset: 0x0055285B
		public static void StartINpcStandbySit(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06026EF0 RID: 159472 RVA: 0x00554664 File Offset: 0x00552864
		public static void AddType(FlatBufferBuilder builder, ENpcStandbyShowMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026EF1 RID: 159473 RVA: 0x0055466F File Offset: 0x0055286F
		public static void AddLookAtConfigs(FlatBufferBuilder builder, VectorOffset lookAtConfigsOffset)
		{
			builder.AddOffset(1, lookAtConfigsOffset.Value, 0);
		}

		// Token: 0x06026EF2 RID: 159474 RVA: 0x00554680 File Offset: 0x00552880
		public static VectorOffset CreateLookAtConfigsVector(FlatBufferBuilder builder, Offset<INpcLookAtConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06026EF3 RID: 159475 RVA: 0x005546C0 File Offset: 0x005528C0
		public static VectorOffset CreateLookAtConfigsVectorBlock(FlatBufferBuilder builder, Offset<INpcLookAtConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<INpcLookAtConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026EF4 RID: 159476 RVA: 0x005546DA File Offset: 0x005528DA
		public static VectorOffset CreateLookAtConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<INpcLookAtConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<INpcLookAtConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026EF5 RID: 159477 RVA: 0x005546F8 File Offset: 0x005528F8
		public static VectorOffset CreateLookAtConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<INpcLookAtConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026EF6 RID: 159478 RVA: 0x00554711 File Offset: 0x00552911
		public static void StartLookAtConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06026EF7 RID: 159479 RVA: 0x0055471C File Offset: 0x0055291C
		public static void AddMontage(FlatBufferBuilder builder, StringOffset montageOffset)
		{
			builder.AddOffset(2, montageOffset.Value, 0);
		}

		// Token: 0x06026EF8 RID: 159480 RVA: 0x0055472C File Offset: 0x0055292C
		public static void AddRegisteredMontageId(FlatBufferBuilder builder, Offset<IMontageId> registeredMontageIdOffset)
		{
			builder.AddOffset(3, registeredMontageIdOffset.Value, 0);
		}

		// Token: 0x06026EF9 RID: 159481 RVA: 0x0055473C File Offset: 0x0055293C
		public static void AddFaceExpressionId(FlatBufferBuilder builder, int faceExpressionId)
		{
			builder.AddInt(4, faceExpressionId, 0);
		}

		// Token: 0x06026EFA RID: 159482 RVA: 0x00554747 File Offset: 0x00552947
		public static void AddPosEntityId(FlatBufferBuilder builder, int posEntityId)
		{
			builder.AddInt(5, posEntityId, 0);
		}

		// Token: 0x06026EFB RID: 159483 RVA: 0x00554752 File Offset: 0x00552952
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06026EFC RID: 159484 RVA: 0x0055475D File Offset: 0x0055295D
		public static Offset<INpcStandbySit> EndINpcStandbySit(FlatBufferBuilder builder)
		{
			return new Offset<INpcStandbySit>(builder.EndTable());
		}

		// Token: 0x06026EFD RID: 159485 RVA: 0x0055476C File Offset: 0x0055296C
		public INpcStandbySitT UnPack()
		{
			INpcStandbySitT npcStandbySitT = new INpcStandbySitT();
			this.UnPackTo(npcStandbySitT);
			return npcStandbySitT;
		}

		// Token: 0x06026EFE RID: 159486 RVA: 0x00554788 File Offset: 0x00552988
		public void UnPackTo(INpcStandbySitT _o)
		{
			_o.Type = this.Type;
			_o.LookAtConfigs = new List<INpcLookAtConfigT>();
			for (int i = 0; i < this.LookAtConfigsLength; i++)
			{
				_o.LookAtConfigs.Add((this.LookAtConfigs(i) != null) ? this.LookAtConfigs(i).Value.UnPack() : null);
			}
			_o.Montage = this.Montage;
			_o.RegisteredMontageId = ((this.RegisteredMontageId != null) ? this.RegisteredMontageId.Value.UnPack() : null);
			_o.FaceExpressionId = this.FaceExpressionId;
			_o.PosEntityId = this.PosEntityId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06026EFF RID: 159487 RVA: 0x00554854 File Offset: 0x00552A54
		public static Offset<INpcStandbySit> Pack(FlatBufferBuilder builder, INpcStandbySitT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcStandbySit>);
			}
			VectorOffset lookAtConfigsOffset = default(VectorOffset);
			if (_o.LookAtConfigs != null)
			{
				Offset<INpcLookAtConfig>[] array = new Offset<INpcLookAtConfig>[_o.LookAtConfigs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = INpcLookAtConfig.Pack(builder, _o.LookAtConfigs[i]);
				}
				lookAtConfigsOffset = INpcStandbySit.CreateLookAtConfigsVector(builder, array);
			}
			StringOffset montageOffset = (_o.Montage == null) ? default(StringOffset) : builder.CreateString(_o.Montage);
			Offset<IMontageId> registeredMontageIdOffset = (_o.RegisteredMontageId == null) ? default(Offset<IMontageId>) : IMontageId.Pack(builder, _o.RegisteredMontageId);
			return INpcStandbySit.CreateINpcStandbySit(builder, _o.Type, lookAtConfigsOffset, montageOffset, registeredMontageIdOffset, _o.FaceExpressionId, _o.PosEntityId, _o.NullMask);
		}

		// Token: 0x0400F692 RID: 63122
		private Table __p;
	}
}
