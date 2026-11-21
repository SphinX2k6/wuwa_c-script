using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005706 RID: 22278
	public struct IEntityMatchSpecificBp : IFlatbufferObject
	{
		// Token: 0x1700A09C RID: 41116
		// (get) Token: 0x06023C55 RID: 146517 RVA: 0x004EAD27 File Offset: 0x004E8F27
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023C56 RID: 146518 RVA: 0x004EAD34 File Offset: 0x004E8F34
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023C57 RID: 146519 RVA: 0x004EAD3C File Offset: 0x004E8F3C
		public static IEntityMatchSpecificBp GetRootAsIEntityMatchSpecificBp(ByteBuffer _bb)
		{
			return IEntityMatchSpecificBp.GetRootAsIEntityMatchSpecificBp(_bb, default(IEntityMatchSpecificBp));
		}

		// Token: 0x06023C58 RID: 146520 RVA: 0x004EAD58 File Offset: 0x004E8F58
		public static IEntityMatchSpecificBp GetRootAsIEntityMatchSpecificBp(ByteBuffer _bb, IEntityMatchSpecificBp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023C59 RID: 146521 RVA: 0x004EAD75 File Offset: 0x004E8F75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023C5A RID: 146522 RVA: 0x004EAD84 File Offset: 0x004E8F84
		public IEntityMatchSpecificBp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A09D RID: 41117
		// (get) Token: 0x06023C5B RID: 146523 RVA: 0x004EAD94 File Offset: 0x004E8F94
		public EEntityMatchType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEntityMatchType.Player;
				}
				return (EEntityMatchType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023C5C RID: 146524 RVA: 0x004EADD0 File Offset: 0x004E8FD0
		public string SpecificBpList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A09E RID: 41118
		// (get) Token: 0x06023C5D RID: 146525 RVA: 0x004EAE0C File Offset: 0x004E900C
		public int SpecificBpListLength
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

		// Token: 0x06023C5E RID: 146526 RVA: 0x004EAE37 File Offset: 0x004E9037
		public static Offset<IEntityMatchSpecificBp> CreateIEntityMatchSpecificBp(FlatBufferBuilder builder, EEntityMatchType Type = EEntityMatchType.Player, VectorOffset SpecificBpListOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IEntityMatchSpecificBp.AddSpecificBpList(builder, SpecificBpListOffset);
			IEntityMatchSpecificBp.AddType(builder, Type);
			return IEntityMatchSpecificBp.EndIEntityMatchSpecificBp(builder);
		}

		// Token: 0x06023C5F RID: 146527 RVA: 0x004EAE54 File Offset: 0x004E9054
		public static void StartIEntityMatchSpecificBp(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06023C60 RID: 146528 RVA: 0x004EAE5D File Offset: 0x004E905D
		public static void AddType(FlatBufferBuilder builder, EEntityMatchType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023C61 RID: 146529 RVA: 0x004EAE68 File Offset: 0x004E9068
		public static void AddSpecificBpList(FlatBufferBuilder builder, VectorOffset specificBpListOffset)
		{
			builder.AddOffset(1, specificBpListOffset.Value, 0);
		}

		// Token: 0x06023C62 RID: 146530 RVA: 0x004EAE78 File Offset: 0x004E9078
		public static VectorOffset CreateSpecificBpListVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023C63 RID: 146531 RVA: 0x004EAEB8 File Offset: 0x004E90B8
		public static VectorOffset CreateSpecificBpListVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06023C64 RID: 146532 RVA: 0x004EAED2 File Offset: 0x004E90D2
		public static VectorOffset CreateSpecificBpListVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06023C65 RID: 146533 RVA: 0x004EAEF0 File Offset: 0x004E90F0
		public static VectorOffset CreateSpecificBpListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023C66 RID: 146534 RVA: 0x004EAF09 File Offset: 0x004E9109
		public static void StartSpecificBpListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023C67 RID: 146535 RVA: 0x004EAF14 File Offset: 0x004E9114
		public static Offset<IEntityMatchSpecificBp> EndIEntityMatchSpecificBp(FlatBufferBuilder builder)
		{
			return new Offset<IEntityMatchSpecificBp>(builder.EndTable());
		}

		// Token: 0x06023C68 RID: 146536 RVA: 0x004EAF24 File Offset: 0x004E9124
		public IEntityMatchSpecificBpT UnPack()
		{
			IEntityMatchSpecificBpT entityMatchSpecificBpT = new IEntityMatchSpecificBpT();
			this.UnPackTo(entityMatchSpecificBpT);
			return entityMatchSpecificBpT;
		}

		// Token: 0x06023C69 RID: 146537 RVA: 0x004EAF40 File Offset: 0x004E9140
		public void UnPackTo(IEntityMatchSpecificBpT _o)
		{
			_o.Type = this.Type;
			_o.SpecificBpList = new List<string>();
			for (int i = 0; i < this.SpecificBpListLength; i++)
			{
				_o.SpecificBpList.Add(this.SpecificBpList(i));
			}
		}

		// Token: 0x06023C6A RID: 146538 RVA: 0x004EAF88 File Offset: 0x004E9188
		public static Offset<IEntityMatchSpecificBp> Pack(FlatBufferBuilder builder, IEntityMatchSpecificBpT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityMatchSpecificBp>);
			}
			VectorOffset specificBpListOffset = default(VectorOffset);
			if (_o.SpecificBpList != null)
			{
				StringOffset[] array = new StringOffset[_o.SpecificBpList.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.SpecificBpList[i]);
				}
				specificBpListOffset = IEntityMatchSpecificBp.CreateSpecificBpListVector(builder, array);
			}
			return IEntityMatchSpecificBp.CreateIEntityMatchSpecificBp(builder, _o.Type, specificBpListOffset);
		}

		// Token: 0x0400EE7D RID: 61053
		private Table __p;
	}
}
