using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007544 RID: 30020
	public struct IVillageInfrTreeProcess : IFlatbufferObject
	{
		// Token: 0x1700E3C4 RID: 58308
		// (get) Token: 0x060369DE RID: 223710 RVA: 0x0076B7C0 File Offset: 0x007699C0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060369DF RID: 223711 RVA: 0x0076B7CD File Offset: 0x007699CD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060369E0 RID: 223712 RVA: 0x0076B7D4 File Offset: 0x007699D4
		public static IVillageInfrTreeProcess GetRootAsIVillageInfrTreeProcess(ByteBuffer _bb)
		{
			return IVillageInfrTreeProcess.GetRootAsIVillageInfrTreeProcess(_bb, default(IVillageInfrTreeProcess));
		}

		// Token: 0x060369E1 RID: 223713 RVA: 0x0076B7F0 File Offset: 0x007699F0
		public static IVillageInfrTreeProcess GetRootAsIVillageInfrTreeProcess(ByteBuffer _bb, IVillageInfrTreeProcess obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060369E2 RID: 223714 RVA: 0x0076B80D File Offset: 0x00769A0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060369E3 RID: 223715 RVA: 0x0076B81C File Offset: 0x00769A1C
		public IVillageInfrTreeProcess __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E3C5 RID: 58309
		// (get) Token: 0x060369E4 RID: 223716 RVA: 0x0076B82C File Offset: 0x00769A2C
		public EVillageInfrBuildType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVillageInfrBuildType.Village;
				}
				return (EVillageInfrBuildType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E3C6 RID: 58310
		// (get) Token: 0x060369E5 RID: 223717 RVA: 0x0076B868 File Offset: 0x00769A68
		public int Id
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060369E6 RID: 223718 RVA: 0x0076B8A4 File Offset: 0x00769AA4
		public static Offset<IVillageInfrTreeProcess> CreateIVillageInfrTreeProcess(FlatBufferBuilder builder, EVillageInfrBuildType Type = EVillageInfrBuildType.Village, int Id = 0)
		{
			builder.StartTable(2);
			IVillageInfrTreeProcess.AddId(builder, Id);
			IVillageInfrTreeProcess.AddType(builder, Type);
			return IVillageInfrTreeProcess.EndIVillageInfrTreeProcess(builder);
		}

		// Token: 0x060369E7 RID: 223719 RVA: 0x0076B8C1 File Offset: 0x00769AC1
		public static void StartIVillageInfrTreeProcess(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060369E8 RID: 223720 RVA: 0x0076B8CA File Offset: 0x00769ACA
		public static void AddType(FlatBufferBuilder builder, EVillageInfrBuildType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060369E9 RID: 223721 RVA: 0x0076B8D5 File Offset: 0x00769AD5
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x060369EA RID: 223722 RVA: 0x0076B8E0 File Offset: 0x00769AE0
		public static Offset<IVillageInfrTreeProcess> EndIVillageInfrTreeProcess(FlatBufferBuilder builder)
		{
			return new Offset<IVillageInfrTreeProcess>(builder.EndTable());
		}

		// Token: 0x060369EB RID: 223723 RVA: 0x0076B8F0 File Offset: 0x00769AF0
		public IVillageInfrTreeProcessT UnPack()
		{
			IVillageInfrTreeProcessT villageInfrTreeProcessT = new IVillageInfrTreeProcessT();
			this.UnPackTo(villageInfrTreeProcessT);
			return villageInfrTreeProcessT;
		}

		// Token: 0x060369EC RID: 223724 RVA: 0x0076B90B File Offset: 0x00769B0B
		public void UnPackTo(IVillageInfrTreeProcessT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x060369ED RID: 223725 RVA: 0x0076B928 File Offset: 0x00769B28
		public static Offset<IVillageInfrTreeProcess> Pack(FlatBufferBuilder builder, IVillageInfrTreeProcessT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVillageInfrTreeProcess>);
			}
			return IVillageInfrTreeProcess.CreateIVillageInfrTreeProcess(builder, _o.Type, _o.Id);
		}

		// Token: 0x0401243A RID: 74810
		private Table __p;
	}
}
