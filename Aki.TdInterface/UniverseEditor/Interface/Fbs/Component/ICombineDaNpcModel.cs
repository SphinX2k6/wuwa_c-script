using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005523 RID: 21795
	public struct ICombineDaNpcModel : IFlatbufferObject
	{
		// Token: 0x17009BBF RID: 39871
		// (get) Token: 0x06022727 RID: 141095 RVA: 0x004BEEA2 File Offset: 0x004BD0A2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022728 RID: 141096 RVA: 0x004BEEAF File Offset: 0x004BD0AF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022729 RID: 141097 RVA: 0x004BEEB8 File Offset: 0x004BD0B8
		public static ICombineDaNpcModel GetRootAsICombineDaNpcModel(ByteBuffer _bb)
		{
			return ICombineDaNpcModel.GetRootAsICombineDaNpcModel(_bb, default(ICombineDaNpcModel));
		}

		// Token: 0x0602272A RID: 141098 RVA: 0x004BEED4 File Offset: 0x004BD0D4
		public static ICombineDaNpcModel GetRootAsICombineDaNpcModel(ByteBuffer _bb, ICombineDaNpcModel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602272B RID: 141099 RVA: 0x004BEEF1 File Offset: 0x004BD0F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602272C RID: 141100 RVA: 0x004BEF00 File Offset: 0x004BD100
		public ICombineDaNpcModel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009BC0 RID: 39872
		// (get) Token: 0x0602272D RID: 141101 RVA: 0x004BEF10 File Offset: 0x004BD110
		public ENpcModelType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENpcModelType.Mesh;
				}
				return (ENpcModelType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009BC1 RID: 39873
		// (get) Token: 0x0602272E RID: 141102 RVA: 0x004BEF4C File Offset: 0x004BD14C
		public string Da
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602272F RID: 141103 RVA: 0x004BEF83 File Offset: 0x004BD183
		public Span<byte> GetDaBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06022730 RID: 141104 RVA: 0x004BEF92 File Offset: 0x004BD192
		public byte[] GetDaArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06022731 RID: 141105 RVA: 0x004BEFA0 File Offset: 0x004BD1A0
		public string InitialHiddenAttachTypes(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17009BC2 RID: 39874
		// (get) Token: 0x06022732 RID: 141106 RVA: 0x004BEFDC File Offset: 0x004BD1DC
		public int InitialHiddenAttachTypesLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17009BC3 RID: 39875
		// (get) Token: 0x06022733 RID: 141107 RVA: 0x004BF008 File Offset: 0x004BD208
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022734 RID: 141108 RVA: 0x004BF045 File Offset: 0x004BD245
		public static Offset<ICombineDaNpcModel> CreateICombineDaNpcModel(FlatBufferBuilder builder, ENpcModelType Type = ENpcModelType.Mesh, StringOffset DaOffset = default(StringOffset), VectorOffset InitialHiddenAttachTypesOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			ICombineDaNpcModel.AddInitialHiddenAttachTypes(builder, InitialHiddenAttachTypesOffset);
			ICombineDaNpcModel.AddDa(builder, DaOffset);
			ICombineDaNpcModel.AddNullMask(builder, NullMask);
			ICombineDaNpcModel.AddType(builder, Type);
			return ICombineDaNpcModel.EndICombineDaNpcModel(builder);
		}

		// Token: 0x06022735 RID: 141109 RVA: 0x004BF071 File Offset: 0x004BD271
		public static void StartICombineDaNpcModel(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06022736 RID: 141110 RVA: 0x004BF07A File Offset: 0x004BD27A
		public static void AddType(FlatBufferBuilder builder, ENpcModelType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022737 RID: 141111 RVA: 0x004BF085 File Offset: 0x004BD285
		public static void AddDa(FlatBufferBuilder builder, StringOffset daOffset)
		{
			builder.AddOffset(1, daOffset.Value, 0);
		}

		// Token: 0x06022738 RID: 141112 RVA: 0x004BF095 File Offset: 0x004BD295
		public static void AddInitialHiddenAttachTypes(FlatBufferBuilder builder, VectorOffset initialHiddenAttachTypesOffset)
		{
			builder.AddOffset(2, initialHiddenAttachTypesOffset.Value, 0);
		}

		// Token: 0x06022739 RID: 141113 RVA: 0x004BF0A8 File Offset: 0x004BD2A8
		public static VectorOffset CreateInitialHiddenAttachTypesVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602273A RID: 141114 RVA: 0x004BF0E8 File Offset: 0x004BD2E8
		public static VectorOffset CreateInitialHiddenAttachTypesVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602273B RID: 141115 RVA: 0x004BF102 File Offset: 0x004BD302
		public static VectorOffset CreateInitialHiddenAttachTypesVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602273C RID: 141116 RVA: 0x004BF120 File Offset: 0x004BD320
		public static VectorOffset CreateInitialHiddenAttachTypesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602273D RID: 141117 RVA: 0x004BF139 File Offset: 0x004BD339
		public static void StartInitialHiddenAttachTypesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602273E RID: 141118 RVA: 0x004BF144 File Offset: 0x004BD344
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602273F RID: 141119 RVA: 0x004BF14F File Offset: 0x004BD34F
		public static Offset<ICombineDaNpcModel> EndICombineDaNpcModel(FlatBufferBuilder builder)
		{
			return new Offset<ICombineDaNpcModel>(builder.EndTable());
		}

		// Token: 0x06022740 RID: 141120 RVA: 0x004BF15C File Offset: 0x004BD35C
		public ICombineDaNpcModelT UnPack()
		{
			ICombineDaNpcModelT combineDaNpcModelT = new ICombineDaNpcModelT();
			this.UnPackTo(combineDaNpcModelT);
			return combineDaNpcModelT;
		}

		// Token: 0x06022741 RID: 141121 RVA: 0x004BF178 File Offset: 0x004BD378
		public void UnPackTo(ICombineDaNpcModelT _o)
		{
			_o.Type = this.Type;
			_o.Da = this.Da;
			_o.InitialHiddenAttachTypes = new List<string>();
			for (int i = 0; i < this.InitialHiddenAttachTypesLength; i++)
			{
				_o.InitialHiddenAttachTypes.Add(this.InitialHiddenAttachTypes(i));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06022742 RID: 141122 RVA: 0x004BF1D8 File Offset: 0x004BD3D8
		public static Offset<ICombineDaNpcModel> Pack(FlatBufferBuilder builder, ICombineDaNpcModelT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICombineDaNpcModel>);
			}
			StringOffset daOffset = (_o.Da == null) ? default(StringOffset) : builder.CreateString(_o.Da);
			VectorOffset initialHiddenAttachTypesOffset = default(VectorOffset);
			if (_o.InitialHiddenAttachTypes != null)
			{
				StringOffset[] array = new StringOffset[_o.InitialHiddenAttachTypes.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.InitialHiddenAttachTypes[i]);
				}
				initialHiddenAttachTypesOffset = ICombineDaNpcModel.CreateInitialHiddenAttachTypesVector(builder, array);
			}
			return ICombineDaNpcModel.CreateICombineDaNpcModel(builder, _o.Type, daOffset, initialHiddenAttachTypesOffset, _o.NullMask);
		}

		// Token: 0x0400EA93 RID: 60051
		private Table __p;
	}
}
