using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057F3 RID: 22515
	public struct IRandomPoolConfig : IFlatbufferObject
	{
		// Token: 0x1700A82A RID: 43050
		// (get) Token: 0x06025D6C RID: 154988 RVA: 0x00537F30 File Offset: 0x00536130
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025D6D RID: 154989 RVA: 0x00537F3D File Offset: 0x0053613D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025D6E RID: 154990 RVA: 0x00537F44 File Offset: 0x00536144
		public static IRandomPoolConfig GetRootAsIRandomPoolConfig(ByteBuffer _bb)
		{
			return IRandomPoolConfig.GetRootAsIRandomPoolConfig(_bb, default(IRandomPoolConfig));
		}

		// Token: 0x06025D6F RID: 154991 RVA: 0x00537F60 File Offset: 0x00536160
		public static IRandomPoolConfig GetRootAsIRandomPoolConfig(ByteBuffer _bb, IRandomPoolConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025D70 RID: 154992 RVA: 0x00537F7D File Offset: 0x0053617D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025D71 RID: 154993 RVA: 0x00537F8C File Offset: 0x0053618C
		public IRandomPoolConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A82B RID: 43051
		// (get) Token: 0x06025D72 RID: 154994 RVA: 0x00537F9C File Offset: 0x0053619C
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A82C RID: 43052
		// (get) Token: 0x06025D73 RID: 154995 RVA: 0x00537FD8 File Offset: 0x005361D8
		public int Count
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

		// Token: 0x06025D74 RID: 154996 RVA: 0x00538014 File Offset: 0x00536214
		public static Offset<IRandomPoolConfig> CreateIRandomPoolConfig(FlatBufferBuilder builder, int Id = 0, int Count = 0)
		{
			builder.StartTable(2);
			IRandomPoolConfig.AddCount(builder, Count);
			IRandomPoolConfig.AddId(builder, Id);
			return IRandomPoolConfig.EndIRandomPoolConfig(builder);
		}

		// Token: 0x06025D75 RID: 154997 RVA: 0x00538031 File Offset: 0x00536231
		public static void StartIRandomPoolConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06025D76 RID: 154998 RVA: 0x0053803A File Offset: 0x0053623A
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x06025D77 RID: 154999 RVA: 0x00538045 File Offset: 0x00536245
		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(1, count, 0);
		}

		// Token: 0x06025D78 RID: 155000 RVA: 0x00538050 File Offset: 0x00536250
		public static Offset<IRandomPoolConfig> EndIRandomPoolConfig(FlatBufferBuilder builder)
		{
			return new Offset<IRandomPoolConfig>(builder.EndTable());
		}

		// Token: 0x06025D79 RID: 155001 RVA: 0x00538060 File Offset: 0x00536260
		public IRandomPoolConfigT UnPack()
		{
			IRandomPoolConfigT randomPoolConfigT = new IRandomPoolConfigT();
			this.UnPackTo(randomPoolConfigT);
			return randomPoolConfigT;
		}

		// Token: 0x06025D7A RID: 155002 RVA: 0x0053807B File Offset: 0x0053627B
		public void UnPackTo(IRandomPoolConfigT _o)
		{
			_o.Id = this.Id;
			_o.Count = this.Count;
		}

		// Token: 0x06025D7B RID: 155003 RVA: 0x00538098 File Offset: 0x00536298
		public static Offset<IRandomPoolConfig> Pack(FlatBufferBuilder builder, IRandomPoolConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRandomPoolConfig>);
			}
			return IRandomPoolConfig.CreateIRandomPoolConfig(builder, _o.Id, _o.Count);
		}

		// Token: 0x0400ECE6 RID: 60646
		private Table __p;
	}
}
