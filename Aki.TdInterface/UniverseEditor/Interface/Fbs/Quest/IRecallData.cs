using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044C6 RID: 17606
	public struct IRecallData : IFlatbufferObject
	{
		// Token: 0x17007A92 RID: 31378
		// (get) Token: 0x06019706 RID: 104198 RVA: 0x003A12E5 File Offset: 0x0039F4E5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019707 RID: 104199 RVA: 0x003A12F2 File Offset: 0x0039F4F2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019708 RID: 104200 RVA: 0x003A12FC File Offset: 0x0039F4FC
		public static IRecallData GetRootAsIRecallData(ByteBuffer _bb)
		{
			return IRecallData.GetRootAsIRecallData(_bb, default(IRecallData));
		}

		// Token: 0x06019709 RID: 104201 RVA: 0x003A1318 File Offset: 0x0039F518
		public static IRecallData GetRootAsIRecallData(ByteBuffer _bb, IRecallData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601970A RID: 104202 RVA: 0x003A1335 File Offset: 0x0039F535
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601970B RID: 104203 RVA: 0x003A1344 File Offset: 0x0039F544
		public IRecallData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007A93 RID: 31379
		// (get) Token: 0x0601970C RID: 104204 RVA: 0x003A1354 File Offset: 0x0039F554
		public ERecallDataType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERecallDataType.LevelPlay;
				}
				return (ERecallDataType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007A94 RID: 31380
		// (get) Token: 0x0601970D RID: 104205 RVA: 0x003A1390 File Offset: 0x0039F590
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

		// Token: 0x0601970E RID: 104206 RVA: 0x003A13CC File Offset: 0x0039F5CC
		public static Offset<IRecallData> CreateIRecallData(FlatBufferBuilder builder, ERecallDataType Type = ERecallDataType.LevelPlay, int Id = 0)
		{
			builder.StartTable(2);
			IRecallData.AddId(builder, Id);
			IRecallData.AddType(builder, Type);
			return IRecallData.EndIRecallData(builder);
		}

		// Token: 0x0601970F RID: 104207 RVA: 0x003A13E9 File Offset: 0x0039F5E9
		public static void StartIRecallData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06019710 RID: 104208 RVA: 0x003A13F2 File Offset: 0x0039F5F2
		public static void AddType(FlatBufferBuilder builder, ERecallDataType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019711 RID: 104209 RVA: 0x003A13FD File Offset: 0x0039F5FD
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06019712 RID: 104210 RVA: 0x003A1408 File Offset: 0x0039F608
		public static Offset<IRecallData> EndIRecallData(FlatBufferBuilder builder)
		{
			return new Offset<IRecallData>(builder.EndTable());
		}

		// Token: 0x06019713 RID: 104211 RVA: 0x003A1418 File Offset: 0x0039F618
		public IRecallDataT UnPack()
		{
			IRecallDataT recallDataT = new IRecallDataT();
			this.UnPackTo(recallDataT);
			return recallDataT;
		}

		// Token: 0x06019714 RID: 104212 RVA: 0x003A1433 File Offset: 0x0039F633
		public void UnPackTo(IRecallDataT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x06019715 RID: 104213 RVA: 0x003A1450 File Offset: 0x0039F650
		public static Offset<IRecallData> Pack(FlatBufferBuilder builder, IRecallDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRecallData>);
			}
			return IRecallData.CreateIRecallData(builder, _o.Type, _o.Id);
		}

		// Token: 0x0400C5F1 RID: 50673
		private Table __p;
	}
}
