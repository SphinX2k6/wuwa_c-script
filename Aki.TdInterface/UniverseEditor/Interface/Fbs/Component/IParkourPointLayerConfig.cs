using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056B0 RID: 22192
	public struct IParkourPointLayerConfig : IFlatbufferObject
	{
		// Token: 0x1700A50B RID: 42251
		// (get) Token: 0x060250B0 RID: 151728 RVA: 0x0051D554 File Offset: 0x0051B754
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060250B1 RID: 151729 RVA: 0x0051D561 File Offset: 0x0051B761
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060250B2 RID: 151730 RVA: 0x0051D568 File Offset: 0x0051B768
		public static IParkourPointLayerConfig GetRootAsIParkourPointLayerConfig(ByteBuffer _bb)
		{
			return IParkourPointLayerConfig.GetRootAsIParkourPointLayerConfig(_bb, default(IParkourPointLayerConfig));
		}

		// Token: 0x060250B3 RID: 151731 RVA: 0x0051D584 File Offset: 0x0051B784
		public static IParkourPointLayerConfig GetRootAsIParkourPointLayerConfig(ByteBuffer _bb, IParkourPointLayerConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060250B4 RID: 151732 RVA: 0x0051D5A1 File Offset: 0x0051B7A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060250B5 RID: 151733 RVA: 0x0051D5B0 File Offset: 0x0051B7B0
		public IParkourPointLayerConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A50C RID: 42252
		// (get) Token: 0x060250B6 RID: 151734 RVA: 0x0051D5C0 File Offset: 0x0051B7C0
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

		// Token: 0x1700A50D RID: 42253
		// (get) Token: 0x060250B7 RID: 151735 RVA: 0x0051D5FC File Offset: 0x0051B7FC
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

		// Token: 0x060250B8 RID: 151736 RVA: 0x0051D638 File Offset: 0x0051B838
		public static Offset<IParkourPointLayerConfig> CreateIParkourPointLayerConfig(FlatBufferBuilder builder, int Width = 0, int Length = 0)
		{
			builder.StartTable(2);
			IParkourPointLayerConfig.AddLength(builder, Length);
			IParkourPointLayerConfig.AddWidth(builder, Width);
			return IParkourPointLayerConfig.EndIParkourPointLayerConfig(builder);
		}

		// Token: 0x060250B9 RID: 151737 RVA: 0x0051D655 File Offset: 0x0051B855
		public static void StartIParkourPointLayerConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060250BA RID: 151738 RVA: 0x0051D65E File Offset: 0x0051B85E
		public static void AddWidth(FlatBufferBuilder builder, int width)
		{
			builder.AddInt(0, width, 0);
		}

		// Token: 0x060250BB RID: 151739 RVA: 0x0051D669 File Offset: 0x0051B869
		public static void AddLength(FlatBufferBuilder builder, int length)
		{
			builder.AddInt(1, length, 0);
		}

		// Token: 0x060250BC RID: 151740 RVA: 0x0051D674 File Offset: 0x0051B874
		public static Offset<IParkourPointLayerConfig> EndIParkourPointLayerConfig(FlatBufferBuilder builder)
		{
			return new Offset<IParkourPointLayerConfig>(builder.EndTable());
		}

		// Token: 0x060250BD RID: 151741 RVA: 0x0051D684 File Offset: 0x0051B884
		public IParkourPointLayerConfigT UnPack()
		{
			IParkourPointLayerConfigT parkourPointLayerConfigT = new IParkourPointLayerConfigT();
			this.UnPackTo(parkourPointLayerConfigT);
			return parkourPointLayerConfigT;
		}

		// Token: 0x060250BE RID: 151742 RVA: 0x0051D69F File Offset: 0x0051B89F
		public void UnPackTo(IParkourPointLayerConfigT _o)
		{
			_o.Width = this.Width;
			_o.Length = this.Length;
		}

		// Token: 0x060250BF RID: 151743 RVA: 0x0051D6BC File Offset: 0x0051B8BC
		public static Offset<IParkourPointLayerConfig> Pack(FlatBufferBuilder builder, IParkourPointLayerConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IParkourPointLayerConfig>);
			}
			return IParkourPointLayerConfig.CreateIParkourPointLayerConfig(builder, _o.Width, _o.Length);
		}

		// Token: 0x0400EAD7 RID: 60119
		private Table __p;
	}
}
