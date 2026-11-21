using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D91 RID: 23953
	public struct IProceduralMaterialType : IFlatbufferObject
	{
		// Token: 0x1700B04D RID: 45133
		// (get) Token: 0x06027E47 RID: 163399 RVA: 0x00574DD7 File Offset: 0x00572FD7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027E48 RID: 163400 RVA: 0x00574DE4 File Offset: 0x00572FE4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027E49 RID: 163401 RVA: 0x00574DEC File Offset: 0x00572FEC
		public static IProceduralMaterialType GetRootAsIProceduralMaterialType(ByteBuffer _bb)
		{
			return IProceduralMaterialType.GetRootAsIProceduralMaterialType(_bb, default(IProceduralMaterialType));
		}

		// Token: 0x06027E4A RID: 163402 RVA: 0x00574E08 File Offset: 0x00573008
		public static IProceduralMaterialType GetRootAsIProceduralMaterialType(ByteBuffer _bb, IProceduralMaterialType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027E4B RID: 163403 RVA: 0x00574E25 File Offset: 0x00573025
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027E4C RID: 163404 RVA: 0x00574E34 File Offset: 0x00573034
		public IProceduralMaterialType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B04E RID: 45134
		// (get) Token: 0x06027E4D RID: 163405 RVA: 0x00574E44 File Offset: 0x00573044
		public EProceduralMaterialType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EProceduralMaterialType.CustomPrimitiveData;
				}
				return (EProceduralMaterialType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027E4E RID: 163406 RVA: 0x00574E80 File Offset: 0x00573080
		public static Offset<IProceduralMaterialType> CreateIProceduralMaterialType(FlatBufferBuilder builder, EProceduralMaterialType Type = EProceduralMaterialType.CustomPrimitiveData)
		{
			builder.StartTable(1);
			IProceduralMaterialType.AddType(builder, Type);
			return IProceduralMaterialType.EndIProceduralMaterialType(builder);
		}

		// Token: 0x06027E4F RID: 163407 RVA: 0x00574E96 File Offset: 0x00573096
		public static void StartIProceduralMaterialType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06027E50 RID: 163408 RVA: 0x00574E9F File Offset: 0x0057309F
		public static void AddType(FlatBufferBuilder builder, EProceduralMaterialType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027E51 RID: 163409 RVA: 0x00574EAA File Offset: 0x005730AA
		public static Offset<IProceduralMaterialType> EndIProceduralMaterialType(FlatBufferBuilder builder)
		{
			return new Offset<IProceduralMaterialType>(builder.EndTable());
		}

		// Token: 0x06027E52 RID: 163410 RVA: 0x00574EB8 File Offset: 0x005730B8
		public IProceduralMaterialTypeT UnPack()
		{
			IProceduralMaterialTypeT proceduralMaterialTypeT = new IProceduralMaterialTypeT();
			this.UnPackTo(proceduralMaterialTypeT);
			return proceduralMaterialTypeT;
		}

		// Token: 0x06027E53 RID: 163411 RVA: 0x00574ED3 File Offset: 0x005730D3
		public void UnPackTo(IProceduralMaterialTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06027E54 RID: 163412 RVA: 0x00574EE4 File Offset: 0x005730E4
		public static Offset<IProceduralMaterialType> Pack(FlatBufferBuilder builder, IProceduralMaterialTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IProceduralMaterialType>);
			}
			return IProceduralMaterialType.CreateIProceduralMaterialType(builder, _o.Type);
		}

		// Token: 0x0400F924 RID: 63780
		private Table __p;
	}
}
