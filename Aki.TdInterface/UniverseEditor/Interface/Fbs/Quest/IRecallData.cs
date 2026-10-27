using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004085 RID: 16517
	public struct IRecallData : IFlatbufferObject
	{
		// Token: 0x17007490 RID: 29840
		// (get) Token: 0x0601806D RID: 98413 RVA: 0x003774AD File Offset: 0x003756AD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601806E RID: 98414 RVA: 0x003774BA File Offset: 0x003756BA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601806F RID: 98415 RVA: 0x003774C4 File Offset: 0x003756C4
		public static IRecallData GetRootAsIRecallData(ByteBuffer _bb)
		{
			return IRecallData.GetRootAsIRecallData(_bb, default(IRecallData));
		}

		// Token: 0x06018070 RID: 98416 RVA: 0x003774E0 File Offset: 0x003756E0
		public static IRecallData GetRootAsIRecallData(ByteBuffer _bb, IRecallData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018071 RID: 98417 RVA: 0x003774FD File Offset: 0x003756FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018072 RID: 98418 RVA: 0x0037750C File Offset: 0x0037570C
		public IRecallData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007491 RID: 29841
		// (get) Token: 0x06018073 RID: 98419 RVA: 0x0037751C File Offset: 0x0037571C
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

		// Token: 0x17007492 RID: 29842
		// (get) Token: 0x06018074 RID: 98420 RVA: 0x00377558 File Offset: 0x00375758
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

		// Token: 0x06018075 RID: 98421 RVA: 0x00377594 File Offset: 0x00375794
		public static Offset<IRecallData> CreateIRecallData(FlatBufferBuilder builder, ERecallDataType Type = ERecallDataType.LevelPlay, int Id = 0)
		{
			builder.StartTable(2);
			IRecallData.AddId(builder, Id);
			IRecallData.AddType(builder, Type);
			return IRecallData.EndIRecallData(builder);
		}

		// Token: 0x06018076 RID: 98422 RVA: 0x003775B1 File Offset: 0x003757B1
		public static void StartIRecallData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06018077 RID: 98423 RVA: 0x003775BA File Offset: 0x003757BA
		public static void AddType(FlatBufferBuilder builder, ERecallDataType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018078 RID: 98424 RVA: 0x003775C5 File Offset: 0x003757C5
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06018079 RID: 98425 RVA: 0x003775D0 File Offset: 0x003757D0
		public static Offset<IRecallData> EndIRecallData(FlatBufferBuilder builder)
		{
			return new Offset<IRecallData>(builder.EndTable());
		}

		// Token: 0x0601807A RID: 98426 RVA: 0x003775E0 File Offset: 0x003757E0
		public IRecallDataT UnPack()
		{
			IRecallDataT recallDataT = new IRecallDataT();
			this.UnPackTo(recallDataT);
			return recallDataT;
		}

		// Token: 0x0601807B RID: 98427 RVA: 0x003775FB File Offset: 0x003757FB
		public void UnPackTo(IRecallDataT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x0601807C RID: 98428 RVA: 0x00377618 File Offset: 0x00375818
		public static Offset<IRecallData> Pack(FlatBufferBuilder builder, IRecallDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRecallData>);
			}
			return IRecallData.CreateIRecallData(builder, _o.Type, _o.Id);
		}

		// Token: 0x0400BC0A RID: 48138
		private Table __p;
	}
}
