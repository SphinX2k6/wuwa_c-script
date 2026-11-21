using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074CE RID: 29902
	public struct IPlotFilmModeConfig : IFlatbufferObject
	{
		// Token: 0x1700DC02 RID: 56322
		// (get) Token: 0x060346A4 RID: 214692 RVA: 0x0070EE02 File Offset: 0x0070D002
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060346A5 RID: 214693 RVA: 0x0070EE0F File Offset: 0x0070D00F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060346A6 RID: 214694 RVA: 0x0070EE18 File Offset: 0x0070D018
		public static IPlotFilmModeConfig GetRootAsIPlotFilmModeConfig(ByteBuffer _bb)
		{
			return IPlotFilmModeConfig.GetRootAsIPlotFilmModeConfig(_bb, default(IPlotFilmModeConfig));
		}

		// Token: 0x060346A7 RID: 214695 RVA: 0x0070EE34 File Offset: 0x0070D034
		public static IPlotFilmModeConfig GetRootAsIPlotFilmModeConfig(ByteBuffer _bb, IPlotFilmModeConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060346A8 RID: 214696 RVA: 0x0070EE51 File Offset: 0x0070D051
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060346A9 RID: 214697 RVA: 0x0070EE60 File Offset: 0x0070D060
		public IPlotFilmModeConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DC03 RID: 56323
		// (get) Token: 0x060346AA RID: 214698 RVA: 0x0070EE70 File Offset: 0x0070D070
		public bool IsAdaptFilmAspectRatio
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DC04 RID: 56324
		// (get) Token: 0x060346AB RID: 214699 RVA: 0x0070EEB0 File Offset: 0x0070D0B0
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

		// Token: 0x060346AC RID: 214700 RVA: 0x0070EEEC File Offset: 0x0070D0EC
		public static Offset<IPlotFilmModeConfig> CreateIPlotFilmModeConfig(FlatBufferBuilder builder, bool IsAdaptFilmAspectRatio = false, byte NullMask = 0)
		{
			builder.StartTable(2);
			IPlotFilmModeConfig.AddNullMask(builder, NullMask);
			IPlotFilmModeConfig.AddIsAdaptFilmAspectRatio(builder, IsAdaptFilmAspectRatio);
			return IPlotFilmModeConfig.EndIPlotFilmModeConfig(builder);
		}

		// Token: 0x060346AD RID: 214701 RVA: 0x0070EF09 File Offset: 0x0070D109
		public static void StartIPlotFilmModeConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060346AE RID: 214702 RVA: 0x0070EF12 File Offset: 0x0070D112
		public static void AddIsAdaptFilmAspectRatio(FlatBufferBuilder builder, bool isAdaptFilmAspectRatio)
		{
			builder.AddBool(0, isAdaptFilmAspectRatio, false);
		}

		// Token: 0x060346AF RID: 214703 RVA: 0x0070EF1D File Offset: 0x0070D11D
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x060346B0 RID: 214704 RVA: 0x0070EF28 File Offset: 0x0070D128
		public static Offset<IPlotFilmModeConfig> EndIPlotFilmModeConfig(FlatBufferBuilder builder)
		{
			return new Offset<IPlotFilmModeConfig>(builder.EndTable());
		}

		// Token: 0x060346B1 RID: 214705 RVA: 0x0070EF38 File Offset: 0x0070D138
		public IPlotFilmModeConfigT UnPack()
		{
			IPlotFilmModeConfigT plotFilmModeConfigT = new IPlotFilmModeConfigT();
			this.UnPackTo(plotFilmModeConfigT);
			return plotFilmModeConfigT;
		}

		// Token: 0x060346B2 RID: 214706 RVA: 0x0070EF53 File Offset: 0x0070D153
		public void UnPackTo(IPlotFilmModeConfigT _o)
		{
			_o.IsAdaptFilmAspectRatio = this.IsAdaptFilmAspectRatio;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060346B3 RID: 214707 RVA: 0x0070EF70 File Offset: 0x0070D170
		public static Offset<IPlotFilmModeConfig> Pack(FlatBufferBuilder builder, IPlotFilmModeConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlotFilmModeConfig>);
			}
			return IPlotFilmModeConfig.CreateIPlotFilmModeConfig(builder, _o.IsAdaptFilmAspectRatio, _o.NullMask);
		}

		// Token: 0x04012681 RID: 75393
		private Table __p;
	}
}
