using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065A3 RID: 26019
	public struct IDestroySummonedEntitiesType : IFlatbufferObject
	{
		// Token: 0x1700C137 RID: 49463
		// (get) Token: 0x0602D225 RID: 184869 RVA: 0x00630AAB File Offset: 0x0062ECAB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D226 RID: 184870 RVA: 0x00630AB8 File Offset: 0x0062ECB8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D227 RID: 184871 RVA: 0x00630AC0 File Offset: 0x0062ECC0
		public static IDestroySummonedEntitiesType GetRootAsIDestroySummonedEntitiesType(ByteBuffer _bb)
		{
			return IDestroySummonedEntitiesType.GetRootAsIDestroySummonedEntitiesType(_bb, default(IDestroySummonedEntitiesType));
		}

		// Token: 0x0602D228 RID: 184872 RVA: 0x00630ADC File Offset: 0x0062ECDC
		public static IDestroySummonedEntitiesType GetRootAsIDestroySummonedEntitiesType(ByteBuffer _bb, IDestroySummonedEntitiesType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D229 RID: 184873 RVA: 0x00630AF9 File Offset: 0x0062ECF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D22A RID: 184874 RVA: 0x00630B08 File Offset: 0x0062ED08
		public IDestroySummonedEntitiesType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C138 RID: 49464
		// (get) Token: 0x0602D22B RID: 184875 RVA: 0x00630B18 File Offset: 0x0062ED18
		public ESummonEntityType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESummonEntityType.Vehicle;
				}
				return (ESummonEntityType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C139 RID: 49465
		// (get) Token: 0x0602D22C RID: 184876 RVA: 0x00630B54 File Offset: 0x0062ED54
		public string TemplateId
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

		// Token: 0x0602D22D RID: 184877 RVA: 0x00630B8B File Offset: 0x0062ED8B
		public Span<byte> GetTemplateIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602D22E RID: 184878 RVA: 0x00630B9A File Offset: 0x0062ED9A
		public byte[] GetTemplateIdArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602D22F RID: 184879 RVA: 0x00630BA8 File Offset: 0x0062EDA8
		public static Offset<IDestroySummonedEntitiesType> CreateIDestroySummonedEntitiesType(FlatBufferBuilder builder, ESummonEntityType Type = ESummonEntityType.Vehicle, StringOffset TemplateIdOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IDestroySummonedEntitiesType.AddTemplateId(builder, TemplateIdOffset);
			IDestroySummonedEntitiesType.AddType(builder, Type);
			return IDestroySummonedEntitiesType.EndIDestroySummonedEntitiesType(builder);
		}

		// Token: 0x0602D230 RID: 184880 RVA: 0x00630BC5 File Offset: 0x0062EDC5
		public static void StartIDestroySummonedEntitiesType(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602D231 RID: 184881 RVA: 0x00630BCE File Offset: 0x0062EDCE
		public static void AddType(FlatBufferBuilder builder, ESummonEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D232 RID: 184882 RVA: 0x00630BD9 File Offset: 0x0062EDD9
		public static void AddTemplateId(FlatBufferBuilder builder, StringOffset templateIdOffset)
		{
			builder.AddOffset(1, templateIdOffset.Value, 0);
		}

		// Token: 0x0602D233 RID: 184883 RVA: 0x00630BE9 File Offset: 0x0062EDE9
		public static Offset<IDestroySummonedEntitiesType> EndIDestroySummonedEntitiesType(FlatBufferBuilder builder)
		{
			return new Offset<IDestroySummonedEntitiesType>(builder.EndTable());
		}

		// Token: 0x0602D234 RID: 184884 RVA: 0x00630BF8 File Offset: 0x0062EDF8
		public IDestroySummonedEntitiesTypeT UnPack()
		{
			IDestroySummonedEntitiesTypeT destroySummonedEntitiesTypeT = new IDestroySummonedEntitiesTypeT();
			this.UnPackTo(destroySummonedEntitiesTypeT);
			return destroySummonedEntitiesTypeT;
		}

		// Token: 0x0602D235 RID: 184885 RVA: 0x00630C13 File Offset: 0x0062EE13
		public void UnPackTo(IDestroySummonedEntitiesTypeT _o)
		{
			_o.Type = this.Type;
			_o.TemplateId = this.TemplateId;
		}

		// Token: 0x0602D236 RID: 184886 RVA: 0x00630C30 File Offset: 0x0062EE30
		public static Offset<IDestroySummonedEntitiesType> Pack(FlatBufferBuilder builder, IDestroySummonedEntitiesTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDestroySummonedEntitiesType>);
			}
			StringOffset templateIdOffset = (_o.TemplateId == null) ? default(StringOffset) : builder.CreateString(_o.TemplateId);
			return IDestroySummonedEntitiesType.CreateIDestroySummonedEntitiesType(builder, _o.Type, templateIdOffset);
		}

		// Token: 0x04010BFC RID: 68604
		private Table __p;
	}
}
