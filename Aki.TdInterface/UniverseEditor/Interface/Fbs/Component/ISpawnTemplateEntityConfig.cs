using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005968 RID: 22888
	public struct ISpawnTemplateEntityConfig : IFlatbufferObject
	{
		// Token: 0x1700ABC4 RID: 43972
		// (get) Token: 0x06026BD7 RID: 158679 RVA: 0x005556E8 File Offset: 0x005538E8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026BD8 RID: 158680 RVA: 0x005556F5 File Offset: 0x005538F5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026BD9 RID: 158681 RVA: 0x005556FC File Offset: 0x005538FC
		public static ISpawnTemplateEntityConfig GetRootAsISpawnTemplateEntityConfig(ByteBuffer _bb)
		{
			return ISpawnTemplateEntityConfig.GetRootAsISpawnTemplateEntityConfig(_bb, default(ISpawnTemplateEntityConfig));
		}

		// Token: 0x06026BDA RID: 158682 RVA: 0x00555718 File Offset: 0x00553918
		public static ISpawnTemplateEntityConfig GetRootAsISpawnTemplateEntityConfig(ByteBuffer _bb, ISpawnTemplateEntityConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026BDB RID: 158683 RVA: 0x00555735 File Offset: 0x00553935
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026BDC RID: 158684 RVA: 0x00555744 File Offset: 0x00553944
		public ISpawnTemplateEntityConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ABC5 RID: 43973
		// (get) Token: 0x06026BDD RID: 158685 RVA: 0x00555754 File Offset: 0x00553954
		public string TemplateBpType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026BDE RID: 158686 RVA: 0x0055578B File Offset: 0x0055398B
		public Span<byte> GetTemplateBpTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06026BDF RID: 158687 RVA: 0x0055579A File Offset: 0x0055399A
		public byte[] GetTemplateBpTypeArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700ABC6 RID: 43974
		// (get) Token: 0x06026BE0 RID: 158688 RVA: 0x005557A8 File Offset: 0x005539A8
		public IVectorInfo? PosOffset
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

		// Token: 0x1700ABC7 RID: 43975
		// (get) Token: 0x06026BE1 RID: 158689 RVA: 0x00555808 File Offset: 0x00553A08
		public IVectorInfo? RotOffset
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06026BE2 RID: 158690 RVA: 0x00555868 File Offset: 0x00553A68
		public ETemplateEntityGroupType GroupTypes(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return ETemplateEntityGroupType.None;
			}
			return (ETemplateEntityGroupType)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700ABC8 RID: 43976
		// (get) Token: 0x06026BE3 RID: 158691 RVA: 0x005558A8 File Offset: 0x00553AA8
		public int GroupTypesLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06026BE4 RID: 158692 RVA: 0x005558D4 File Offset: 0x00553AD4
		public Span<ETemplateEntityGroupType> GetGroupTypesBytes()
		{
			return this.__p.__vector_as_span<ETemplateEntityGroupType>(10, 1);
		}

		// Token: 0x06026BE5 RID: 158693 RVA: 0x005558E4 File Offset: 0x00553AE4
		public ETemplateEntityGroupType[] GetGroupTypesArray()
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			ETemplateEntityGroupType[] array = new ETemplateEntityGroupType[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (ETemplateEntityGroupType)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x1700ABC9 RID: 43977
		// (get) Token: 0x06026BE6 RID: 158694 RVA: 0x00555950 File Offset: 0x00553B50
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026BE7 RID: 158695 RVA: 0x0055598D File Offset: 0x00553B8D
		public static Offset<ISpawnTemplateEntityConfig> CreateISpawnTemplateEntityConfig(FlatBufferBuilder builder, StringOffset TemplateBpTypeOffset = default(StringOffset), Offset<IVectorInfo> PosOffsetOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> RotOffsetOffset = default(Offset<IVectorInfo>), VectorOffset GroupTypesOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			ISpawnTemplateEntityConfig.AddGroupTypes(builder, GroupTypesOffset);
			ISpawnTemplateEntityConfig.AddRotOffset(builder, RotOffsetOffset);
			ISpawnTemplateEntityConfig.AddPosOffset(builder, PosOffsetOffset);
			ISpawnTemplateEntityConfig.AddTemplateBpType(builder, TemplateBpTypeOffset);
			ISpawnTemplateEntityConfig.AddNullMask(builder, NullMask);
			return ISpawnTemplateEntityConfig.EndISpawnTemplateEntityConfig(builder);
		}

		// Token: 0x06026BE8 RID: 158696 RVA: 0x005559C1 File Offset: 0x00553BC1
		public static void StartISpawnTemplateEntityConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06026BE9 RID: 158697 RVA: 0x005559CA File Offset: 0x00553BCA
		public static void AddTemplateBpType(FlatBufferBuilder builder, StringOffset templateBpTypeOffset)
		{
			builder.AddOffset(0, templateBpTypeOffset.Value, 0);
		}

		// Token: 0x06026BEA RID: 158698 RVA: 0x005559DA File Offset: 0x00553BDA
		public static void AddPosOffset(FlatBufferBuilder builder, Offset<IVectorInfo> posOffsetOffset)
		{
			builder.AddOffset(1, posOffsetOffset.Value, 0);
		}

		// Token: 0x06026BEB RID: 158699 RVA: 0x005559EA File Offset: 0x00553BEA
		public static void AddRotOffset(FlatBufferBuilder builder, Offset<IVectorInfo> rotOffsetOffset)
		{
			builder.AddOffset(2, rotOffsetOffset.Value, 0);
		}

		// Token: 0x06026BEC RID: 158700 RVA: 0x005559FA File Offset: 0x00553BFA
		public static void AddGroupTypes(FlatBufferBuilder builder, VectorOffset groupTypesOffset)
		{
			builder.AddOffset(3, groupTypesOffset.Value, 0);
		}

		// Token: 0x06026BED RID: 158701 RVA: 0x00555A0C File Offset: 0x00553C0C
		public static VectorOffset CreateGroupTypesVector(FlatBufferBuilder builder, ETemplateEntityGroupType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06026BEE RID: 158702 RVA: 0x00555A43 File Offset: 0x00553C43
		public static VectorOffset CreateGroupTypesVectorBlock(FlatBufferBuilder builder, ETemplateEntityGroupType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<ETemplateEntityGroupType>(data);
			return builder.EndVector();
		}

		// Token: 0x06026BEF RID: 158703 RVA: 0x00555A5D File Offset: 0x00553C5D
		public static VectorOffset CreateGroupTypesVectorBlock(FlatBufferBuilder builder, ArraySegment<ETemplateEntityGroupType> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<ETemplateEntityGroupType>(data);
			return builder.EndVector();
		}

		// Token: 0x06026BF0 RID: 158704 RVA: 0x00555A7B File Offset: 0x00553C7B
		public static VectorOffset CreateGroupTypesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<ETemplateEntityGroupType>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026BF1 RID: 158705 RVA: 0x00555A94 File Offset: 0x00553C94
		public static void StartGroupTypesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06026BF2 RID: 158706 RVA: 0x00555A9F File Offset: 0x00553C9F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06026BF3 RID: 158707 RVA: 0x00555AAA File Offset: 0x00553CAA
		public static Offset<ISpawnTemplateEntityConfig> EndISpawnTemplateEntityConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISpawnTemplateEntityConfig>(builder.EndTable());
		}

		// Token: 0x06026BF4 RID: 158708 RVA: 0x00555AB8 File Offset: 0x00553CB8
		public ISpawnTemplateEntityConfigT UnPack()
		{
			ISpawnTemplateEntityConfigT spawnTemplateEntityConfigT = new ISpawnTemplateEntityConfigT();
			this.UnPackTo(spawnTemplateEntityConfigT);
			return spawnTemplateEntityConfigT;
		}

		// Token: 0x06026BF5 RID: 158709 RVA: 0x00555AD4 File Offset: 0x00553CD4
		public void UnPackTo(ISpawnTemplateEntityConfigT _o)
		{
			_o.TemplateBpType = this.TemplateBpType;
			_o.PosOffset = ((this.PosOffset != null) ? this.PosOffset.Value.UnPack() : null);
			_o.RotOffset = ((this.RotOffset != null) ? this.RotOffset.Value.UnPack() : null);
			_o.GroupTypes = new List<ETemplateEntityGroupType>();
			for (int i = 0; i < this.GroupTypesLength; i++)
			{
				_o.GroupTypes.Add(this.GroupTypes(i));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06026BF6 RID: 158710 RVA: 0x00555B88 File Offset: 0x00553D88
		public static Offset<ISpawnTemplateEntityConfig> Pack(FlatBufferBuilder builder, ISpawnTemplateEntityConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISpawnTemplateEntityConfig>);
			}
			StringOffset templateBpTypeOffset = (_o.TemplateBpType == null) ? default(StringOffset) : builder.CreateString(_o.TemplateBpType);
			Offset<IVectorInfo> posOffsetOffset = (_o.PosOffset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.PosOffset);
			Offset<IVectorInfo> rotOffsetOffset = (_o.RotOffset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.RotOffset);
			VectorOffset groupTypesOffset = default(VectorOffset);
			if (_o.GroupTypes != null)
			{
				ETemplateEntityGroupType[] data = _o.GroupTypes.ToArray();
				groupTypesOffset = ISpawnTemplateEntityConfig.CreateGroupTypesVector(builder, data);
			}
			return ISpawnTemplateEntityConfig.CreateISpawnTemplateEntityConfig(builder, templateBpTypeOffset, posOffsetOffset, rotOffsetOffset, groupTypesOffset, _o.NullMask);
		}

		// Token: 0x0400EF4F RID: 61263
		private Table __p;
	}
}
