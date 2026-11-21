using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C0B RID: 27659
	public struct IDestroySummonedEntitiesType : IFlatbufferObject
	{
		// Token: 0x1700CAC6 RID: 51910
		// (get) Token: 0x0602F9A9 RID: 194985 RVA: 0x0067CC6F File Offset: 0x0067AE6F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F9AA RID: 194986 RVA: 0x0067CC7C File Offset: 0x0067AE7C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F9AB RID: 194987 RVA: 0x0067CC84 File Offset: 0x0067AE84
		public static IDestroySummonedEntitiesType GetRootAsIDestroySummonedEntitiesType(ByteBuffer _bb)
		{
			return IDestroySummonedEntitiesType.GetRootAsIDestroySummonedEntitiesType(_bb, default(IDestroySummonedEntitiesType));
		}

		// Token: 0x0602F9AC RID: 194988 RVA: 0x0067CCA0 File Offset: 0x0067AEA0
		public static IDestroySummonedEntitiesType GetRootAsIDestroySummonedEntitiesType(ByteBuffer _bb, IDestroySummonedEntitiesType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F9AD RID: 194989 RVA: 0x0067CCBD File Offset: 0x0067AEBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F9AE RID: 194990 RVA: 0x0067CCCC File Offset: 0x0067AECC
		public IDestroySummonedEntitiesType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CAC7 RID: 51911
		// (get) Token: 0x0602F9AF RID: 194991 RVA: 0x0067CCDC File Offset: 0x0067AEDC
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

		// Token: 0x1700CAC8 RID: 51912
		// (get) Token: 0x0602F9B0 RID: 194992 RVA: 0x0067CD18 File Offset: 0x0067AF18
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

		// Token: 0x0602F9B1 RID: 194993 RVA: 0x0067CD4F File Offset: 0x0067AF4F
		public Span<byte> GetTemplateIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602F9B2 RID: 194994 RVA: 0x0067CD5E File Offset: 0x0067AF5E
		public byte[] GetTemplateIdArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602F9B3 RID: 194995 RVA: 0x0067CD6C File Offset: 0x0067AF6C
		public static Offset<IDestroySummonedEntitiesType> CreateIDestroySummonedEntitiesType(FlatBufferBuilder builder, ESummonEntityType Type = ESummonEntityType.Vehicle, StringOffset TemplateIdOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IDestroySummonedEntitiesType.AddTemplateId(builder, TemplateIdOffset);
			IDestroySummonedEntitiesType.AddType(builder, Type);
			return IDestroySummonedEntitiesType.EndIDestroySummonedEntitiesType(builder);
		}

		// Token: 0x0602F9B4 RID: 194996 RVA: 0x0067CD89 File Offset: 0x0067AF89
		public static void StartIDestroySummonedEntitiesType(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602F9B5 RID: 194997 RVA: 0x0067CD92 File Offset: 0x0067AF92
		public static void AddType(FlatBufferBuilder builder, ESummonEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F9B6 RID: 194998 RVA: 0x0067CD9D File Offset: 0x0067AF9D
		public static void AddTemplateId(FlatBufferBuilder builder, StringOffset templateIdOffset)
		{
			builder.AddOffset(1, templateIdOffset.Value, 0);
		}

		// Token: 0x0602F9B7 RID: 194999 RVA: 0x0067CDAD File Offset: 0x0067AFAD
		public static Offset<IDestroySummonedEntitiesType> EndIDestroySummonedEntitiesType(FlatBufferBuilder builder)
		{
			return new Offset<IDestroySummonedEntitiesType>(builder.EndTable());
		}

		// Token: 0x0602F9B8 RID: 195000 RVA: 0x0067CDBC File Offset: 0x0067AFBC
		public IDestroySummonedEntitiesTypeT UnPack()
		{
			IDestroySummonedEntitiesTypeT destroySummonedEntitiesTypeT = new IDestroySummonedEntitiesTypeT();
			this.UnPackTo(destroySummonedEntitiesTypeT);
			return destroySummonedEntitiesTypeT;
		}

		// Token: 0x0602F9B9 RID: 195001 RVA: 0x0067CDD7 File Offset: 0x0067AFD7
		public void UnPackTo(IDestroySummonedEntitiesTypeT _o)
		{
			_o.Type = this.Type;
			_o.TemplateId = this.TemplateId;
		}

		// Token: 0x0602F9BA RID: 195002 RVA: 0x0067CDF4 File Offset: 0x0067AFF4
		public static Offset<IDestroySummonedEntitiesType> Pack(FlatBufferBuilder builder, IDestroySummonedEntitiesTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDestroySummonedEntitiesType>);
			}
			StringOffset templateIdOffset = (_o.TemplateId == null) ? default(StringOffset) : builder.CreateString(_o.TemplateId);
			return IDestroySummonedEntitiesType.CreateIDestroySummonedEntitiesType(builder, _o.Type, templateIdOffset);
		}

		// Token: 0x04011A0E RID: 72206
		private Table __p;
	}
}
