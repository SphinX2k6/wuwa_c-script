using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074CB RID: 29899
	public struct IPlotConfig : IFlatbufferObject
	{
		// Token: 0x1700DC01 RID: 56321
		// (get) Token: 0x06034697 RID: 214679 RVA: 0x0070ED1B File Offset: 0x0070CF1B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034698 RID: 214680 RVA: 0x0070ED28 File Offset: 0x0070CF28
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034699 RID: 214681 RVA: 0x0070ED30 File Offset: 0x0070CF30
		public static IPlotConfig GetRootAsIPlotConfig(ByteBuffer _bb)
		{
			return IPlotConfig.GetRootAsIPlotConfig(_bb, default(IPlotConfig));
		}

		// Token: 0x0603469A RID: 214682 RVA: 0x0070ED4C File Offset: 0x0070CF4C
		public static IPlotConfig GetRootAsIPlotConfig(ByteBuffer _bb, IPlotConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603469B RID: 214683 RVA: 0x0070ED69 File Offset: 0x0070CF69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603469C RID: 214684 RVA: 0x0070ED78 File Offset: 0x0070CF78
		public IPlotConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0603469D RID: 214685 RVA: 0x0070ED88 File Offset: 0x0070CF88
		public static void StartIPlotConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0603469E RID: 214686 RVA: 0x0070ED91 File Offset: 0x0070CF91
		public static Offset<IPlotConfig> EndIPlotConfig(FlatBufferBuilder builder)
		{
			return new Offset<IPlotConfig>(builder.EndTable());
		}

		// Token: 0x0603469F RID: 214687 RVA: 0x0070EDA0 File Offset: 0x0070CFA0
		public IPlotConfigT UnPack()
		{
			IPlotConfigT plotConfigT = new IPlotConfigT();
			this.UnPackTo(plotConfigT);
			return plotConfigT;
		}

		// Token: 0x060346A0 RID: 214688 RVA: 0x0070EDBB File Offset: 0x0070CFBB
		public void UnPackTo(IPlotConfigT _o)
		{
		}

		// Token: 0x060346A1 RID: 214689 RVA: 0x0070EDC0 File Offset: 0x0070CFC0
		public static Offset<IPlotConfig> Pack(FlatBufferBuilder builder, IPlotConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlotConfig>);
			}
			IPlotConfig.StartIPlotConfig(builder);
			return IPlotConfig.EndIPlotConfig(builder);
		}

		// Token: 0x04012680 RID: 75392
		private Table __p;
	}
}
