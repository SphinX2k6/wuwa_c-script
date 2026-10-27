using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D53 RID: 27987
	public struct IPlotFilmModeConfig : IFlatbufferObject
	{
		// Token: 0x1700D0BA RID: 53434
		// (get) Token: 0x060316A8 RID: 202408 RVA: 0x006B371A File Offset: 0x006B191A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060316A9 RID: 202409 RVA: 0x006B3727 File Offset: 0x006B1927
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060316AA RID: 202410 RVA: 0x006B3730 File Offset: 0x006B1930
		public static IPlotFilmModeConfig GetRootAsIPlotFilmModeConfig(ByteBuffer _bb)
		{
			return IPlotFilmModeConfig.GetRootAsIPlotFilmModeConfig(_bb, default(IPlotFilmModeConfig));
		}

		// Token: 0x060316AB RID: 202411 RVA: 0x006B374C File Offset: 0x006B194C
		public static IPlotFilmModeConfig GetRootAsIPlotFilmModeConfig(ByteBuffer _bb, IPlotFilmModeConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060316AC RID: 202412 RVA: 0x006B3769 File Offset: 0x006B1969
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060316AD RID: 202413 RVA: 0x006B3778 File Offset: 0x006B1978
		public IPlotFilmModeConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D0BB RID: 53435
		// (get) Token: 0x060316AE RID: 202414 RVA: 0x006B3788 File Offset: 0x006B1988
		public bool IsAdaptFilmAspectRatio
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D0BC RID: 53436
		// (get) Token: 0x060316AF RID: 202415 RVA: 0x006B37C8 File Offset: 0x006B19C8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060316B0 RID: 202416 RVA: 0x006B3804 File Offset: 0x006B1A04
		public static Offset<IPlotFilmModeConfig> CreateIPlotFilmModeConfig(FlatBufferBuilder builder, bool IsAdaptFilmAspectRatio = false, byte NullMask = 0)
		{
			builder.StartTable(2);
			IPlotFilmModeConfig.AddNullMask(builder, NullMask);
			IPlotFilmModeConfig.AddIsAdaptFilmAspectRatio(builder, IsAdaptFilmAspectRatio);
			return IPlotFilmModeConfig.EndIPlotFilmModeConfig(builder);
		}

		// Token: 0x060316B1 RID: 202417 RVA: 0x006B3821 File Offset: 0x006B1A21
		public static void StartIPlotFilmModeConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060316B2 RID: 202418 RVA: 0x006B382A File Offset: 0x006B1A2A
		public static void AddIsAdaptFilmAspectRatio(FlatBufferBuilder builder, bool isAdaptFilmAspectRatio)
		{
			builder.AddBool(0, isAdaptFilmAspectRatio, false);
		}

		// Token: 0x060316B3 RID: 202419 RVA: 0x006B3835 File Offset: 0x006B1A35
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x060316B4 RID: 202420 RVA: 0x006B3840 File Offset: 0x006B1A40
		public static Offset<IPlotFilmModeConfig> EndIPlotFilmModeConfig(FlatBufferBuilder builder)
		{
			return new Offset<IPlotFilmModeConfig>(builder.EndTable());
		}

		// Token: 0x060316B5 RID: 202421 RVA: 0x006B3850 File Offset: 0x006B1A50
		public IPlotFilmModeConfigT UnPack()
		{
			IPlotFilmModeConfigT plotFilmModeConfigT = new IPlotFilmModeConfigT();
			this.UnPackTo(plotFilmModeConfigT);
			return plotFilmModeConfigT;
		}

		// Token: 0x060316B6 RID: 202422 RVA: 0x006B386B File Offset: 0x006B1A6B
		public void UnPackTo(IPlotFilmModeConfigT _o)
		{
			_o.IsAdaptFilmAspectRatio = this.IsAdaptFilmAspectRatio;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060316B7 RID: 202423 RVA: 0x006B3888 File Offset: 0x006B1A88
		public static Offset<IPlotFilmModeConfig> Pack(FlatBufferBuilder builder, IPlotFilmModeConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlotFilmModeConfig>);
			}
			return IPlotFilmModeConfig.CreateIPlotFilmModeConfig(builder, _o.IsAdaptFilmAspectRatio, _o.NullMask);
		}

		// Token: 0x04011705 RID: 71429
		private Table __p;
	}
}
