using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B1A RID: 15130
	public struct IVarStringValidateConfig : IFlatbufferObject
	{
		// Token: 0x170067CB RID: 26571
		// (get) Token: 0x06014A73 RID: 84595 RVA: 0x00301752 File Offset: 0x002FF952
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014A74 RID: 84596 RVA: 0x0030175F File Offset: 0x002FF95F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014A75 RID: 84597 RVA: 0x00301768 File Offset: 0x002FF968
		public static IVarStringValidateConfig GetRootAsIVarStringValidateConfig(ByteBuffer _bb)
		{
			return IVarStringValidateConfig.GetRootAsIVarStringValidateConfig(_bb, default(IVarStringValidateConfig));
		}

		// Token: 0x06014A76 RID: 84598 RVA: 0x00301784 File Offset: 0x002FF984
		public static IVarStringValidateConfig GetRootAsIVarStringValidateConfig(ByteBuffer _bb, IVarStringValidateConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014A77 RID: 84599 RVA: 0x003017A1 File Offset: 0x002FF9A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014A78 RID: 84600 RVA: 0x003017B0 File Offset: 0x002FF9B0
		public IVarStringValidateConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170067CC RID: 26572
		// (get) Token: 0x06014A79 RID: 84601 RVA: 0x003017C0 File Offset: 0x002FF9C0
		public EVar Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVar.Boolean;
				}
				return (EVar)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06014A7A RID: 84602 RVA: 0x003017FC File Offset: 0x002FF9FC
		public string ValidList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170067CD RID: 26573
		// (get) Token: 0x06014A7B RID: 84603 RVA: 0x00301838 File Offset: 0x002FFA38
		public int ValidListLength
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

		// Token: 0x170067CE RID: 26574
		// (get) Token: 0x06014A7C RID: 84604 RVA: 0x00301864 File Offset: 0x002FFA64
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06014A7D RID: 84605 RVA: 0x003018A0 File Offset: 0x002FFAA0
		public static Offset<IVarStringValidateConfig> CreateIVarStringValidateConfig(FlatBufferBuilder builder, EVar Type = EVar.Boolean, VectorOffset ValidListOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IVarStringValidateConfig.AddValidList(builder, ValidListOffset);
			IVarStringValidateConfig.AddNullMask(builder, NullMask);
			IVarStringValidateConfig.AddType(builder, Type);
			return IVarStringValidateConfig.EndIVarStringValidateConfig(builder);
		}

		// Token: 0x06014A7E RID: 84606 RVA: 0x003018C4 File Offset: 0x002FFAC4
		public static void StartIVarStringValidateConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06014A7F RID: 84607 RVA: 0x003018CD File Offset: 0x002FFACD
		public static void AddType(FlatBufferBuilder builder, EVar type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06014A80 RID: 84608 RVA: 0x003018D8 File Offset: 0x002FFAD8
		public static void AddValidList(FlatBufferBuilder builder, VectorOffset validListOffset)
		{
			builder.AddOffset(1, validListOffset.Value, 0);
		}

		// Token: 0x06014A81 RID: 84609 RVA: 0x003018E8 File Offset: 0x002FFAE8
		public static VectorOffset CreateValidListVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06014A82 RID: 84610 RVA: 0x00301928 File Offset: 0x002FFB28
		public static VectorOffset CreateValidListVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06014A83 RID: 84611 RVA: 0x00301942 File Offset: 0x002FFB42
		public static VectorOffset CreateValidListVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06014A84 RID: 84612 RVA: 0x00301960 File Offset: 0x002FFB60
		public static VectorOffset CreateValidListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06014A85 RID: 84613 RVA: 0x00301979 File Offset: 0x002FFB79
		public static void StartValidListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06014A86 RID: 84614 RVA: 0x00301984 File Offset: 0x002FFB84
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06014A87 RID: 84615 RVA: 0x0030198F File Offset: 0x002FFB8F
		public static Offset<IVarStringValidateConfig> EndIVarStringValidateConfig(FlatBufferBuilder builder)
		{
			return new Offset<IVarStringValidateConfig>(builder.EndTable());
		}

		// Token: 0x06014A88 RID: 84616 RVA: 0x0030199C File Offset: 0x002FFB9C
		public IVarStringValidateConfigT UnPack()
		{
			IVarStringValidateConfigT varStringValidateConfigT = new IVarStringValidateConfigT();
			this.UnPackTo(varStringValidateConfigT);
			return varStringValidateConfigT;
		}

		// Token: 0x06014A89 RID: 84617 RVA: 0x003019B8 File Offset: 0x002FFBB8
		public void UnPackTo(IVarStringValidateConfigT _o)
		{
			_o.Type = this.Type;
			_o.ValidList = new List<string>();
			for (int i = 0; i < this.ValidListLength; i++)
			{
				_o.ValidList.Add(this.ValidList(i));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06014A8A RID: 84618 RVA: 0x00301A0C File Offset: 0x002FFC0C
		public static Offset<IVarStringValidateConfig> Pack(FlatBufferBuilder builder, IVarStringValidateConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVarStringValidateConfig>);
			}
			VectorOffset validListOffset = default(VectorOffset);
			if (_o.ValidList != null)
			{
				StringOffset[] array = new StringOffset[_o.ValidList.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.ValidList[i]);
				}
				validListOffset = IVarStringValidateConfig.CreateValidListVector(builder, array);
			}
			return IVarStringValidateConfig.CreateIVarStringValidateConfig(builder, _o.Type, validListOffset, _o.NullMask);
		}

		// Token: 0x0400AFE8 RID: 45032
		private Table __p;
	}
}
