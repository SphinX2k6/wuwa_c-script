using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051A1 RID: 20897
	public struct IEntityMatchSpecificBp : IFlatbufferObject
	{
		// Token: 0x170098AD RID: 39085
		// (get) Token: 0x06021CFD RID: 138493 RVA: 0x004B0CBF File Offset: 0x004AEEBF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021CFE RID: 138494 RVA: 0x004B0CCC File Offset: 0x004AEECC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021CFF RID: 138495 RVA: 0x004B0CD4 File Offset: 0x004AEED4
		public static IEntityMatchSpecificBp GetRootAsIEntityMatchSpecificBp(ByteBuffer _bb)
		{
			return IEntityMatchSpecificBp.GetRootAsIEntityMatchSpecificBp(_bb, default(IEntityMatchSpecificBp));
		}

		// Token: 0x06021D00 RID: 138496 RVA: 0x004B0CF0 File Offset: 0x004AEEF0
		public static IEntityMatchSpecificBp GetRootAsIEntityMatchSpecificBp(ByteBuffer _bb, IEntityMatchSpecificBp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021D01 RID: 138497 RVA: 0x004B0D0D File Offset: 0x004AEF0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021D02 RID: 138498 RVA: 0x004B0D1C File Offset: 0x004AEF1C
		public IEntityMatchSpecificBp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170098AE RID: 39086
		// (get) Token: 0x06021D03 RID: 138499 RVA: 0x004B0D2C File Offset: 0x004AEF2C
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

		// Token: 0x06021D04 RID: 138500 RVA: 0x004B0D68 File Offset: 0x004AEF68
		public string SpecificBpList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170098AF RID: 39087
		// (get) Token: 0x06021D05 RID: 138501 RVA: 0x004B0DA4 File Offset: 0x004AEFA4
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

		// Token: 0x06021D06 RID: 138502 RVA: 0x004B0DCF File Offset: 0x004AEFCF
		public static Offset<IEntityMatchSpecificBp> CreateIEntityMatchSpecificBp(FlatBufferBuilder builder, EEntityMatchType Type = EEntityMatchType.Player, VectorOffset SpecificBpListOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IEntityMatchSpecificBp.AddSpecificBpList(builder, SpecificBpListOffset);
			IEntityMatchSpecificBp.AddType(builder, Type);
			return IEntityMatchSpecificBp.EndIEntityMatchSpecificBp(builder);
		}

		// Token: 0x06021D07 RID: 138503 RVA: 0x004B0DEC File Offset: 0x004AEFEC
		public static void StartIEntityMatchSpecificBp(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06021D08 RID: 138504 RVA: 0x004B0DF5 File Offset: 0x004AEFF5
		public static void AddType(FlatBufferBuilder builder, EEntityMatchType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021D09 RID: 138505 RVA: 0x004B0E00 File Offset: 0x004AF000
		public static void AddSpecificBpList(FlatBufferBuilder builder, VectorOffset specificBpListOffset)
		{
			builder.AddOffset(1, specificBpListOffset.Value, 0);
		}

		// Token: 0x06021D0A RID: 138506 RVA: 0x004B0E10 File Offset: 0x004AF010
		public static VectorOffset CreateSpecificBpListVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06021D0B RID: 138507 RVA: 0x004B0E50 File Offset: 0x004AF050
		public static VectorOffset CreateSpecificBpListVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06021D0C RID: 138508 RVA: 0x004B0E6A File Offset: 0x004AF06A
		public static VectorOffset CreateSpecificBpListVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06021D0D RID: 138509 RVA: 0x004B0E88 File Offset: 0x004AF088
		public static VectorOffset CreateSpecificBpListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021D0E RID: 138510 RVA: 0x004B0EA1 File Offset: 0x004AF0A1
		public static void StartSpecificBpListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021D0F RID: 138511 RVA: 0x004B0EAC File Offset: 0x004AF0AC
		public static Offset<IEntityMatchSpecificBp> EndIEntityMatchSpecificBp(FlatBufferBuilder builder)
		{
			return new Offset<IEntityMatchSpecificBp>(builder.EndTable());
		}

		// Token: 0x06021D10 RID: 138512 RVA: 0x004B0EBC File Offset: 0x004AF0BC
		public IEntityMatchSpecificBpT UnPack()
		{
			IEntityMatchSpecificBpT entityMatchSpecificBpT = new IEntityMatchSpecificBpT();
			this.UnPackTo(entityMatchSpecificBpT);
			return entityMatchSpecificBpT;
		}

		// Token: 0x06021D11 RID: 138513 RVA: 0x004B0ED8 File Offset: 0x004AF0D8
		public void UnPackTo(IEntityMatchSpecificBpT _o)
		{
			_o.Type = this.Type;
			_o.SpecificBpList = new List<string>();
			for (int i = 0; i < this.SpecificBpListLength; i++)
			{
				_o.SpecificBpList.Add(this.SpecificBpList(i));
			}
		}

		// Token: 0x06021D12 RID: 138514 RVA: 0x004B0F20 File Offset: 0x004AF120
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

		// Token: 0x0400E27F RID: 57983
		private Table __p;
	}
}
