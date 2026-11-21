using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DFA RID: 24058
	public struct IRandomPoolConfig : IFlatbufferObject
	{
		// Token: 0x1700B14E RID: 45390
		// (get) Token: 0x0602828C RID: 164492 RVA: 0x0057E0BC File Offset: 0x0057C2BC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602828D RID: 164493 RVA: 0x0057E0C9 File Offset: 0x0057C2C9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602828E RID: 164494 RVA: 0x0057E0D0 File Offset: 0x0057C2D0
		public static IRandomPoolConfig GetRootAsIRandomPoolConfig(ByteBuffer _bb)
		{
			return IRandomPoolConfig.GetRootAsIRandomPoolConfig(_bb, default(IRandomPoolConfig));
		}

		// Token: 0x0602828F RID: 164495 RVA: 0x0057E0EC File Offset: 0x0057C2EC
		public static IRandomPoolConfig GetRootAsIRandomPoolConfig(ByteBuffer _bb, IRandomPoolConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028290 RID: 164496 RVA: 0x0057E109 File Offset: 0x0057C309
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028291 RID: 164497 RVA: 0x0057E118 File Offset: 0x0057C318
		public IRandomPoolConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B14F RID: 45391
		// (get) Token: 0x06028292 RID: 164498 RVA: 0x0057E128 File Offset: 0x0057C328
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

		// Token: 0x1700B150 RID: 45392
		// (get) Token: 0x06028293 RID: 164499 RVA: 0x0057E164 File Offset: 0x0057C364
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

		// Token: 0x06028294 RID: 164500 RVA: 0x0057E1A0 File Offset: 0x0057C3A0
		public static Offset<IRandomPoolConfig> CreateIRandomPoolConfig(FlatBufferBuilder builder, int Id = 0, int Count = 0)
		{
			builder.StartTable(2);
			IRandomPoolConfig.AddCount(builder, Count);
			IRandomPoolConfig.AddId(builder, Id);
			return IRandomPoolConfig.EndIRandomPoolConfig(builder);
		}

		// Token: 0x06028295 RID: 164501 RVA: 0x0057E1BD File Offset: 0x0057C3BD
		public static void StartIRandomPoolConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06028296 RID: 164502 RVA: 0x0057E1C6 File Offset: 0x0057C3C6
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x06028297 RID: 164503 RVA: 0x0057E1D1 File Offset: 0x0057C3D1
		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(1, count, 0);
		}

		// Token: 0x06028298 RID: 164504 RVA: 0x0057E1DC File Offset: 0x0057C3DC
		public static Offset<IRandomPoolConfig> EndIRandomPoolConfig(FlatBufferBuilder builder)
		{
			return new Offset<IRandomPoolConfig>(builder.EndTable());
		}

		// Token: 0x06028299 RID: 164505 RVA: 0x0057E1EC File Offset: 0x0057C3EC
		public IRandomPoolConfigT UnPack()
		{
			IRandomPoolConfigT randomPoolConfigT = new IRandomPoolConfigT();
			this.UnPackTo(randomPoolConfigT);
			return randomPoolConfigT;
		}

		// Token: 0x0602829A RID: 164506 RVA: 0x0057E207 File Offset: 0x0057C407
		public void UnPackTo(IRandomPoolConfigT _o)
		{
			_o.Id = this.Id;
			_o.Count = this.Count;
		}

		// Token: 0x0602829B RID: 164507 RVA: 0x0057E224 File Offset: 0x0057C424
		public static Offset<IRandomPoolConfig> Pack(FlatBufferBuilder builder, IRandomPoolConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRandomPoolConfig>);
			}
			return IRandomPoolConfig.CreateIRandomPoolConfig(builder, _o.Id, _o.Count);
		}

		// Token: 0x0400F9D1 RID: 63953
		private Table __p;
	}
}
