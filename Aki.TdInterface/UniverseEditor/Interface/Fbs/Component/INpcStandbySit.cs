using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005668 RID: 22120
	public struct INpcStandbySit : IFlatbufferObject
	{
		// Token: 0x1700A3E4 RID: 41956
		// (get) Token: 0x06024CA5 RID: 150693 RVA: 0x005137C6 File Offset: 0x005119C6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024CA6 RID: 150694 RVA: 0x005137D3 File Offset: 0x005119D3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024CA7 RID: 150695 RVA: 0x005137DC File Offset: 0x005119DC
		public static INpcStandbySit GetRootAsINpcStandbySit(ByteBuffer _bb)
		{
			return INpcStandbySit.GetRootAsINpcStandbySit(_bb, default(INpcStandbySit));
		}

		// Token: 0x06024CA8 RID: 150696 RVA: 0x005137F8 File Offset: 0x005119F8
		public static INpcStandbySit GetRootAsINpcStandbySit(ByteBuffer _bb, INpcStandbySit obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024CA9 RID: 150697 RVA: 0x00513815 File Offset: 0x00511A15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024CAA RID: 150698 RVA: 0x00513824 File Offset: 0x00511A24
		public INpcStandbySit __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A3E5 RID: 41957
		// (get) Token: 0x06024CAB RID: 150699 RVA: 0x00513834 File Offset: 0x00511A34
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

		// Token: 0x06024CAC RID: 150700 RVA: 0x00513870 File Offset: 0x00511A70
		public INpcLookAtConfig? LookAtConfigs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new INpcLookAtConfig?(default(INpcLookAtConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A3E6 RID: 41958
		// (get) Token: 0x06024CAD RID: 150701 RVA: 0x005138D0 File Offset: 0x00511AD0
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

		// Token: 0x1700A3E7 RID: 41959
		// (get) Token: 0x06024CAE RID: 150702 RVA: 0x005138FC File Offset: 0x00511AFC
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

		// Token: 0x06024CAF RID: 150703 RVA: 0x00513933 File Offset: 0x00511B33
		public Span<byte> GetMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06024CB0 RID: 150704 RVA: 0x00513942 File Offset: 0x00511B42
		public byte[] GetMontageArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700A3E8 RID: 41960
		// (get) Token: 0x06024CB1 RID: 150705 RVA: 0x00513950 File Offset: 0x00511B50
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

		// Token: 0x1700A3E9 RID: 41961
		// (get) Token: 0x06024CB2 RID: 150706 RVA: 0x005139B0 File Offset: 0x00511BB0
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

		// Token: 0x1700A3EA RID: 41962
		// (get) Token: 0x06024CB3 RID: 150707 RVA: 0x005139F0 File Offset: 0x00511BF0
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

		// Token: 0x1700A3EB RID: 41963
		// (get) Token: 0x06024CB4 RID: 150708 RVA: 0x00513A30 File Offset: 0x00511C30
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

		// Token: 0x06024CB5 RID: 150709 RVA: 0x00513A70 File Offset: 0x00511C70
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

		// Token: 0x06024CB6 RID: 150710 RVA: 0x00513ABF File Offset: 0x00511CBF
		public static void StartINpcStandbySit(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06024CB7 RID: 150711 RVA: 0x00513AC8 File Offset: 0x00511CC8
		public static void AddType(FlatBufferBuilder builder, ENpcStandbyShowMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024CB8 RID: 150712 RVA: 0x00513AD3 File Offset: 0x00511CD3
		public static void AddLookAtConfigs(FlatBufferBuilder builder, VectorOffset lookAtConfigsOffset)
		{
			builder.AddOffset(1, lookAtConfigsOffset.Value, 0);
		}

		// Token: 0x06024CB9 RID: 150713 RVA: 0x00513AE4 File Offset: 0x00511CE4
		public static VectorOffset CreateLookAtConfigsVector(FlatBufferBuilder builder, Offset<INpcLookAtConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06024CBA RID: 150714 RVA: 0x00513B24 File Offset: 0x00511D24
		public static VectorOffset CreateLookAtConfigsVectorBlock(FlatBufferBuilder builder, Offset<INpcLookAtConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<INpcLookAtConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024CBB RID: 150715 RVA: 0x00513B3E File Offset: 0x00511D3E
		public static VectorOffset CreateLookAtConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<INpcLookAtConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<INpcLookAtConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024CBC RID: 150716 RVA: 0x00513B5C File Offset: 0x00511D5C
		public static VectorOffset CreateLookAtConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<INpcLookAtConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024CBD RID: 150717 RVA: 0x00513B75 File Offset: 0x00511D75
		public static void StartLookAtConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024CBE RID: 150718 RVA: 0x00513B80 File Offset: 0x00511D80
		public static void AddMontage(FlatBufferBuilder builder, StringOffset montageOffset)
		{
			builder.AddOffset(2, montageOffset.Value, 0);
		}

		// Token: 0x06024CBF RID: 150719 RVA: 0x00513B90 File Offset: 0x00511D90
		public static void AddRegisteredMontageId(FlatBufferBuilder builder, Offset<IMontageId> registeredMontageIdOffset)
		{
			builder.AddOffset(3, registeredMontageIdOffset.Value, 0);
		}

		// Token: 0x06024CC0 RID: 150720 RVA: 0x00513BA0 File Offset: 0x00511DA0
		public static void AddFaceExpressionId(FlatBufferBuilder builder, int faceExpressionId)
		{
			builder.AddInt(4, faceExpressionId, 0);
		}

		// Token: 0x06024CC1 RID: 150721 RVA: 0x00513BAB File Offset: 0x00511DAB
		public static void AddPosEntityId(FlatBufferBuilder builder, int posEntityId)
		{
			builder.AddInt(5, posEntityId, 0);
		}

		// Token: 0x06024CC2 RID: 150722 RVA: 0x00513BB6 File Offset: 0x00511DB6
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06024CC3 RID: 150723 RVA: 0x00513BC1 File Offset: 0x00511DC1
		public static Offset<INpcStandbySit> EndINpcStandbySit(FlatBufferBuilder builder)
		{
			return new Offset<INpcStandbySit>(builder.EndTable());
		}

		// Token: 0x06024CC4 RID: 150724 RVA: 0x00513BD0 File Offset: 0x00511DD0
		public INpcStandbySitT UnPack()
		{
			INpcStandbySitT npcStandbySitT = new INpcStandbySitT();
			this.UnPackTo(npcStandbySitT);
			return npcStandbySitT;
		}

		// Token: 0x06024CC5 RID: 150725 RVA: 0x00513BEC File Offset: 0x00511DEC
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

		// Token: 0x06024CC6 RID: 150726 RVA: 0x00513CB8 File Offset: 0x00511EB8
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

		// Token: 0x0400EA29 RID: 59945
		private Table __p;
	}
}
