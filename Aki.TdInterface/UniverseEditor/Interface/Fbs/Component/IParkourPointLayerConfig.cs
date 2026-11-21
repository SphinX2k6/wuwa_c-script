using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C54 RID: 23636
	public struct IParkourPointLayerConfig : IFlatbufferObject
	{
		// Token: 0x1700AD9F RID: 44447
		// (get) Token: 0x06027305 RID: 160517 RVA: 0x0055E49C File Offset: 0x0055C69C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027306 RID: 160518 RVA: 0x0055E4A9 File Offset: 0x0055C6A9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027307 RID: 160519 RVA: 0x0055E4B0 File Offset: 0x0055C6B0
		public static IParkourPointLayerConfig GetRootAsIParkourPointLayerConfig(ByteBuffer _bb)
		{
			return IParkourPointLayerConfig.GetRootAsIParkourPointLayerConfig(_bb, default(IParkourPointLayerConfig));
		}

		// Token: 0x06027308 RID: 160520 RVA: 0x0055E4CC File Offset: 0x0055C6CC
		public static IParkourPointLayerConfig GetRootAsIParkourPointLayerConfig(ByteBuffer _bb, IParkourPointLayerConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027309 RID: 160521 RVA: 0x0055E4E9 File Offset: 0x0055C6E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602730A RID: 160522 RVA: 0x0055E4F8 File Offset: 0x0055C6F8
		public IParkourPointLayerConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ADA0 RID: 44448
		// (get) Token: 0x0602730B RID: 160523 RVA: 0x0055E508 File Offset: 0x0055C708
		public int Width
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

		// Token: 0x1700ADA1 RID: 44449
		// (get) Token: 0x0602730C RID: 160524 RVA: 0x0055E544 File Offset: 0x0055C744
		public int Length
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

		// Token: 0x0602730D RID: 160525 RVA: 0x0055E580 File Offset: 0x0055C780
		public static Offset<IParkourPointLayerConfig> CreateIParkourPointLayerConfig(FlatBufferBuilder builder, int Width = 0, int Length = 0)
		{
			builder.StartTable(2);
			IParkourPointLayerConfig.AddLength(builder, Length);
			IParkourPointLayerConfig.AddWidth(builder, Width);
			return IParkourPointLayerConfig.EndIParkourPointLayerConfig(builder);
		}

		// Token: 0x0602730E RID: 160526 RVA: 0x0055E59D File Offset: 0x0055C79D
		public static void StartIParkourPointLayerConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602730F RID: 160527 RVA: 0x0055E5A6 File Offset: 0x0055C7A6
		public static void AddWidth(FlatBufferBuilder builder, int width)
		{
			builder.AddInt(0, width, 0);
		}

		// Token: 0x06027310 RID: 160528 RVA: 0x0055E5B1 File Offset: 0x0055C7B1
		public static void AddLength(FlatBufferBuilder builder, int length)
		{
			builder.AddInt(1, length, 0);
		}

		// Token: 0x06027311 RID: 160529 RVA: 0x0055E5BC File Offset: 0x0055C7BC
		public static Offset<IParkourPointLayerConfig> EndIParkourPointLayerConfig(FlatBufferBuilder builder)
		{
			return new Offset<IParkourPointLayerConfig>(builder.EndTable());
		}

		// Token: 0x06027312 RID: 160530 RVA: 0x0055E5CC File Offset: 0x0055C7CC
		public IParkourPointLayerConfigT UnPack()
		{
			IParkourPointLayerConfigT parkourPointLayerConfigT = new IParkourPointLayerConfigT();
			this.UnPackTo(parkourPointLayerConfigT);
			return parkourPointLayerConfigT;
		}

		// Token: 0x06027313 RID: 160531 RVA: 0x0055E5E7 File Offset: 0x0055C7E7
		public void UnPackTo(IParkourPointLayerConfigT _o)
		{
			_o.Width = this.Width;
			_o.Length = this.Length;
		}

		// Token: 0x06027314 RID: 160532 RVA: 0x0055E604 File Offset: 0x0055C804
		public static Offset<IParkourPointLayerConfig> Pack(FlatBufferBuilder builder, IParkourPointLayerConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IParkourPointLayerConfig>);
			}
			return IParkourPointLayerConfig.CreateIParkourPointLayerConfig(builder, _o.Width, _o.Length);
		}

		// Token: 0x0400F743 RID: 63299
		private Table __p;
	}
}
