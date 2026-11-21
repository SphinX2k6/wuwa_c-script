using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F75 RID: 24437
	public struct ISpawnTemplateEntityConfig : IFlatbufferObject
	{
		// Token: 0x1700B4F8 RID: 46328
		// (get) Token: 0x06029141 RID: 168257 RVA: 0x0059C354 File Offset: 0x0059A554
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029142 RID: 168258 RVA: 0x0059C361 File Offset: 0x0059A561
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029143 RID: 168259 RVA: 0x0059C368 File Offset: 0x0059A568
		public static ISpawnTemplateEntityConfig GetRootAsISpawnTemplateEntityConfig(ByteBuffer _bb)
		{
			return ISpawnTemplateEntityConfig.GetRootAsISpawnTemplateEntityConfig(_bb, default(ISpawnTemplateEntityConfig));
		}

		// Token: 0x06029144 RID: 168260 RVA: 0x0059C384 File Offset: 0x0059A584
		public static ISpawnTemplateEntityConfig GetRootAsISpawnTemplateEntityConfig(ByteBuffer _bb, ISpawnTemplateEntityConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029145 RID: 168261 RVA: 0x0059C3A1 File Offset: 0x0059A5A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029146 RID: 168262 RVA: 0x0059C3B0 File Offset: 0x0059A5B0
		public ISpawnTemplateEntityConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B4F9 RID: 46329
		// (get) Token: 0x06029147 RID: 168263 RVA: 0x0059C3C0 File Offset: 0x0059A5C0
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

		// Token: 0x06029148 RID: 168264 RVA: 0x0059C3F7 File Offset: 0x0059A5F7
		public Span<byte> GetTemplateBpTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06029149 RID: 168265 RVA: 0x0059C406 File Offset: 0x0059A606
		public byte[] GetTemplateBpTypeArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700B4FA RID: 46330
		// (get) Token: 0x0602914A RID: 168266 RVA: 0x0059C414 File Offset: 0x0059A614
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

		// Token: 0x1700B4FB RID: 46331
		// (get) Token: 0x0602914B RID: 168267 RVA: 0x0059C474 File Offset: 0x0059A674
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

		// Token: 0x0602914C RID: 168268 RVA: 0x0059C4D4 File Offset: 0x0059A6D4
		public ETemplateEntityGroupType GroupTypes(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return ETemplateEntityGroupType.None;
			}
			return (ETemplateEntityGroupType)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700B4FC RID: 46332
		// (get) Token: 0x0602914D RID: 168269 RVA: 0x0059C514 File Offset: 0x0059A714
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

		// Token: 0x0602914E RID: 168270 RVA: 0x0059C540 File Offset: 0x0059A740
		public Span<ETemplateEntityGroupType> GetGroupTypesBytes()
		{
			return this.__p.__vector_as_span<ETemplateEntityGroupType>(10, 1);
		}

		// Token: 0x0602914F RID: 168271 RVA: 0x0059C550 File Offset: 0x0059A750
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

		// Token: 0x1700B4FD RID: 46333
		// (get) Token: 0x06029150 RID: 168272 RVA: 0x0059C5BC File Offset: 0x0059A7BC
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

		// Token: 0x06029151 RID: 168273 RVA: 0x0059C5F9 File Offset: 0x0059A7F9
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

		// Token: 0x06029152 RID: 168274 RVA: 0x0059C62D File Offset: 0x0059A82D
		public static void StartISpawnTemplateEntityConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06029153 RID: 168275 RVA: 0x0059C636 File Offset: 0x0059A836
		public static void AddTemplateBpType(FlatBufferBuilder builder, StringOffset templateBpTypeOffset)
		{
			builder.AddOffset(0, templateBpTypeOffset.Value, 0);
		}

		// Token: 0x06029154 RID: 168276 RVA: 0x0059C646 File Offset: 0x0059A846
		public static void AddPosOffset(FlatBufferBuilder builder, Offset<IVectorInfo> posOffsetOffset)
		{
			builder.AddOffset(1, posOffsetOffset.Value, 0);
		}

		// Token: 0x06029155 RID: 168277 RVA: 0x0059C656 File Offset: 0x0059A856
		public static void AddRotOffset(FlatBufferBuilder builder, Offset<IVectorInfo> rotOffsetOffset)
		{
			builder.AddOffset(2, rotOffsetOffset.Value, 0);
		}

		// Token: 0x06029156 RID: 168278 RVA: 0x0059C666 File Offset: 0x0059A866
		public static void AddGroupTypes(FlatBufferBuilder builder, VectorOffset groupTypesOffset)
		{
			builder.AddOffset(3, groupTypesOffset.Value, 0);
		}

		// Token: 0x06029157 RID: 168279 RVA: 0x0059C678 File Offset: 0x0059A878
		public static VectorOffset CreateGroupTypesVector(FlatBufferBuilder builder, ETemplateEntityGroupType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06029158 RID: 168280 RVA: 0x0059C6AF File Offset: 0x0059A8AF
		public static VectorOffset CreateGroupTypesVectorBlock(FlatBufferBuilder builder, ETemplateEntityGroupType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<ETemplateEntityGroupType>(data);
			return builder.EndVector();
		}

		// Token: 0x06029159 RID: 168281 RVA: 0x0059C6C9 File Offset: 0x0059A8C9
		public static VectorOffset CreateGroupTypesVectorBlock(FlatBufferBuilder builder, ArraySegment<ETemplateEntityGroupType> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<ETemplateEntityGroupType>(data);
			return builder.EndVector();
		}

		// Token: 0x0602915A RID: 168282 RVA: 0x0059C6E7 File Offset: 0x0059A8E7
		public static VectorOffset CreateGroupTypesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<ETemplateEntityGroupType>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602915B RID: 168283 RVA: 0x0059C700 File Offset: 0x0059A900
		public static void StartGroupTypesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0602915C RID: 168284 RVA: 0x0059C70B File Offset: 0x0059A90B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602915D RID: 168285 RVA: 0x0059C716 File Offset: 0x0059A916
		public static Offset<ISpawnTemplateEntityConfig> EndISpawnTemplateEntityConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISpawnTemplateEntityConfig>(builder.EndTable());
		}

		// Token: 0x0602915E RID: 168286 RVA: 0x0059C724 File Offset: 0x0059A924
		public ISpawnTemplateEntityConfigT UnPack()
		{
			ISpawnTemplateEntityConfigT spawnTemplateEntityConfigT = new ISpawnTemplateEntityConfigT();
			this.UnPackTo(spawnTemplateEntityConfigT);
			return spawnTemplateEntityConfigT;
		}

		// Token: 0x0602915F RID: 168287 RVA: 0x0059C740 File Offset: 0x0059A940
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

		// Token: 0x06029160 RID: 168288 RVA: 0x0059C7F4 File Offset: 0x0059A9F4
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

		// Token: 0x0400FC44 RID: 64580
		private Table __p;
	}
}
