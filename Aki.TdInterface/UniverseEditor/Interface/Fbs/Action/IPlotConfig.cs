using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D50 RID: 27984
	public struct IPlotConfig : IFlatbufferObject
	{
		// Token: 0x1700D0B9 RID: 53433
		// (get) Token: 0x0603169B RID: 202395 RVA: 0x006B3633 File Offset: 0x006B1833
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603169C RID: 202396 RVA: 0x006B3640 File Offset: 0x006B1840
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603169D RID: 202397 RVA: 0x006B3648 File Offset: 0x006B1848
		public static IPlotConfig GetRootAsIPlotConfig(ByteBuffer _bb)
		{
			return IPlotConfig.GetRootAsIPlotConfig(_bb, default(IPlotConfig));
		}

		// Token: 0x0603169E RID: 202398 RVA: 0x006B3664 File Offset: 0x006B1864
		public static IPlotConfig GetRootAsIPlotConfig(ByteBuffer _bb, IPlotConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603169F RID: 202399 RVA: 0x006B3681 File Offset: 0x006B1881
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060316A0 RID: 202400 RVA: 0x006B3690 File Offset: 0x006B1890
		public IPlotConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x060316A1 RID: 202401 RVA: 0x006B36A0 File Offset: 0x006B18A0
		public static void StartIPlotConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x060316A2 RID: 202402 RVA: 0x006B36A9 File Offset: 0x006B18A9
		public static Offset<IPlotConfig> EndIPlotConfig(FlatBufferBuilder builder)
		{
			return new Offset<IPlotConfig>(builder.EndTable());
		}

		// Token: 0x060316A3 RID: 202403 RVA: 0x006B36B8 File Offset: 0x006B18B8
		public IPlotConfigT UnPack()
		{
			IPlotConfigT plotConfigT = new IPlotConfigT();
			this.UnPackTo(plotConfigT);
			return plotConfigT;
		}

		// Token: 0x060316A4 RID: 202404 RVA: 0x006B36D3 File Offset: 0x006B18D3
		public void UnPackTo(IPlotConfigT _o)
		{
		}

		// Token: 0x060316A5 RID: 202405 RVA: 0x006B36D8 File Offset: 0x006B18D8
		public static Offset<IPlotConfig> Pack(FlatBufferBuilder builder, IPlotConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlotConfig>);
			}
			IPlotConfig.StartIPlotConfig(builder);
			return IPlotConfig.EndIPlotConfig(builder);
		}

		// Token: 0x04011704 RID: 71428
		private Table __p;
	}
}
