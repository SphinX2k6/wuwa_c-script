using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074D1 RID: 29905
	public struct IPlotModeUiStyleBase : IFlatbufferObject
	{
		// Token: 0x1700DC07 RID: 56327
		// (get) Token: 0x060346BA RID: 214714 RVA: 0x0070F006 File Offset: 0x0070D206
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060346BB RID: 214715 RVA: 0x0070F013 File Offset: 0x0070D213
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060346BC RID: 214716 RVA: 0x0070F01C File Offset: 0x0070D21C
		public static IPlotModeUiStyleBase GetRootAsIPlotModeUiStyleBase(ByteBuffer _bb)
		{
			return IPlotModeUiStyleBase.GetRootAsIPlotModeUiStyleBase(_bb, default(IPlotModeUiStyleBase));
		}

		// Token: 0x060346BD RID: 214717 RVA: 0x0070F038 File Offset: 0x0070D238
		public static IPlotModeUiStyleBase GetRootAsIPlotModeUiStyleBase(ByteBuffer _bb, IPlotModeUiStyleBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060346BE RID: 214718 RVA: 0x0070F055 File Offset: 0x0070D255
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060346BF RID: 214719 RVA: 0x0070F064 File Offset: 0x0070D264
		public IPlotModeUiStyleBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DC08 RID: 56328
		// (get) Token: 0x060346C0 RID: 214720 RVA: 0x0070F074 File Offset: 0x0070D274
		public EPlotModeUiStyleType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPlotModeUiStyleType.LevelD;
				}
				return (EPlotModeUiStyleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060346C1 RID: 214721 RVA: 0x0070F0B0 File Offset: 0x0070D2B0
		public static Offset<IPlotModeUiStyleBase> CreateIPlotModeUiStyleBase(FlatBufferBuilder builder, EPlotModeUiStyleType Type = EPlotModeUiStyleType.LevelD)
		{
			builder.StartTable(1);
			IPlotModeUiStyleBase.AddType(builder, Type);
			return IPlotModeUiStyleBase.EndIPlotModeUiStyleBase(builder);
		}

		// Token: 0x060346C2 RID: 214722 RVA: 0x0070F0C6 File Offset: 0x0070D2C6
		public static void StartIPlotModeUiStyleBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060346C3 RID: 214723 RVA: 0x0070F0CF File Offset: 0x0070D2CF
		public static void AddType(FlatBufferBuilder builder, EPlotModeUiStyleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060346C4 RID: 214724 RVA: 0x0070F0DA File Offset: 0x0070D2DA
		public static Offset<IPlotModeUiStyleBase> EndIPlotModeUiStyleBase(FlatBufferBuilder builder)
		{
			return new Offset<IPlotModeUiStyleBase>(builder.EndTable());
		}

		// Token: 0x060346C5 RID: 214725 RVA: 0x0070F0E8 File Offset: 0x0070D2E8
		public IPlotModeUiStyleBaseT UnPack()
		{
			IPlotModeUiStyleBaseT plotModeUiStyleBaseT = new IPlotModeUiStyleBaseT();
			this.UnPackTo(plotModeUiStyleBaseT);
			return plotModeUiStyleBaseT;
		}

		// Token: 0x060346C6 RID: 214726 RVA: 0x0070F103 File Offset: 0x0070D303
		public void UnPackTo(IPlotModeUiStyleBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060346C7 RID: 214727 RVA: 0x0070F114 File Offset: 0x0070D314
		public static Offset<IPlotModeUiStyleBase> Pack(FlatBufferBuilder builder, IPlotModeUiStyleBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlotModeUiStyleBase>);
			}
			return IPlotModeUiStyleBase.CreateIPlotModeUiStyleBase(builder, _o.Type);
		}

		// Token: 0x04012684 RID: 75396
		private Table __p;
	}
}
