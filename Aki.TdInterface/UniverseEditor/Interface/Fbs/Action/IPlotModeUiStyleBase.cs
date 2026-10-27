using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D56 RID: 27990
	public struct IPlotModeUiStyleBase : IFlatbufferObject
	{
		// Token: 0x1700D0BF RID: 53439
		// (get) Token: 0x060316BE RID: 202430 RVA: 0x006B391E File Offset: 0x006B1B1E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060316BF RID: 202431 RVA: 0x006B392B File Offset: 0x006B1B2B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060316C0 RID: 202432 RVA: 0x006B3934 File Offset: 0x006B1B34
		public static IPlotModeUiStyleBase GetRootAsIPlotModeUiStyleBase(ByteBuffer _bb)
		{
			return IPlotModeUiStyleBase.GetRootAsIPlotModeUiStyleBase(_bb, default(IPlotModeUiStyleBase));
		}

		// Token: 0x060316C1 RID: 202433 RVA: 0x006B3950 File Offset: 0x006B1B50
		public static IPlotModeUiStyleBase GetRootAsIPlotModeUiStyleBase(ByteBuffer _bb, IPlotModeUiStyleBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060316C2 RID: 202434 RVA: 0x006B396D File Offset: 0x006B1B6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060316C3 RID: 202435 RVA: 0x006B397C File Offset: 0x006B1B7C
		public IPlotModeUiStyleBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D0C0 RID: 53440
		// (get) Token: 0x060316C4 RID: 202436 RVA: 0x006B398C File Offset: 0x006B1B8C
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

		// Token: 0x060316C5 RID: 202437 RVA: 0x006B39C8 File Offset: 0x006B1BC8
		public static Offset<IPlotModeUiStyleBase> CreateIPlotModeUiStyleBase(FlatBufferBuilder builder, EPlotModeUiStyleType Type = EPlotModeUiStyleType.LevelD)
		{
			builder.StartTable(1);
			IPlotModeUiStyleBase.AddType(builder, Type);
			return IPlotModeUiStyleBase.EndIPlotModeUiStyleBase(builder);
		}

		// Token: 0x060316C6 RID: 202438 RVA: 0x006B39DE File Offset: 0x006B1BDE
		public static void StartIPlotModeUiStyleBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060316C7 RID: 202439 RVA: 0x006B39E7 File Offset: 0x006B1BE7
		public static void AddType(FlatBufferBuilder builder, EPlotModeUiStyleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060316C8 RID: 202440 RVA: 0x006B39F2 File Offset: 0x006B1BF2
		public static Offset<IPlotModeUiStyleBase> EndIPlotModeUiStyleBase(FlatBufferBuilder builder)
		{
			return new Offset<IPlotModeUiStyleBase>(builder.EndTable());
		}

		// Token: 0x060316C9 RID: 202441 RVA: 0x006B3A00 File Offset: 0x006B1C00
		public IPlotModeUiStyleBaseT UnPack()
		{
			IPlotModeUiStyleBaseT plotModeUiStyleBaseT = new IPlotModeUiStyleBaseT();
			this.UnPackTo(plotModeUiStyleBaseT);
			return plotModeUiStyleBaseT;
		}

		// Token: 0x060316CA RID: 202442 RVA: 0x006B3A1B File Offset: 0x006B1C1B
		public void UnPackTo(IPlotModeUiStyleBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060316CB RID: 202443 RVA: 0x006B3A2C File Offset: 0x006B1C2C
		public static Offset<IPlotModeUiStyleBase> Pack(FlatBufferBuilder builder, IPlotModeUiStyleBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlotModeUiStyleBase>);
			}
			return IPlotModeUiStyleBase.CreateIPlotModeUiStyleBase(builder, _o.Type);
		}

		// Token: 0x04011708 RID: 71432
		private Table __p;
	}
}
