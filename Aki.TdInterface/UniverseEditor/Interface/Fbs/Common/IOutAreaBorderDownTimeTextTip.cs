using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006452 RID: 25682
	public struct IOutAreaBorderDownTimeTextTip : IFlatbufferObject
	{
		// Token: 0x1700BD9D RID: 48541
		// (get) Token: 0x0602BA56 RID: 178774 RVA: 0x005F0FC3 File Offset: 0x005EF1C3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BA57 RID: 178775 RVA: 0x005F0FD0 File Offset: 0x005EF1D0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BA58 RID: 178776 RVA: 0x005F0FD8 File Offset: 0x005EF1D8
		public static IOutAreaBorderDownTimeTextTip GetRootAsIOutAreaBorderDownTimeTextTip(ByteBuffer _bb)
		{
			return IOutAreaBorderDownTimeTextTip.GetRootAsIOutAreaBorderDownTimeTextTip(_bb, default(IOutAreaBorderDownTimeTextTip));
		}

		// Token: 0x0602BA59 RID: 178777 RVA: 0x005F0FF4 File Offset: 0x005EF1F4
		public static IOutAreaBorderDownTimeTextTip GetRootAsIOutAreaBorderDownTimeTextTip(ByteBuffer _bb, IOutAreaBorderDownTimeTextTip obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BA5A RID: 178778 RVA: 0x005F1011 File Offset: 0x005EF211
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BA5B RID: 178779 RVA: 0x005F1020 File Offset: 0x005EF220
		public IOutAreaBorderDownTimeTextTip __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BD9E RID: 48542
		// (get) Token: 0x0602BA5C RID: 178780 RVA: 0x005F1030 File Offset: 0x005EF230
		public EOutAreaBorderTipType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EOutAreaBorderTipType.DownTimeTextTip;
				}
				return (EOutAreaBorderTipType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602BA5D RID: 178781 RVA: 0x005F106C File Offset: 0x005EF26C
		public static Offset<IOutAreaBorderDownTimeTextTip> CreateIOutAreaBorderDownTimeTextTip(FlatBufferBuilder builder, EOutAreaBorderTipType Type = EOutAreaBorderTipType.DownTimeTextTip)
		{
			builder.StartTable(1);
			IOutAreaBorderDownTimeTextTip.AddType(builder, Type);
			return IOutAreaBorderDownTimeTextTip.EndIOutAreaBorderDownTimeTextTip(builder);
		}

		// Token: 0x0602BA5E RID: 178782 RVA: 0x005F1082 File Offset: 0x005EF282
		public static void StartIOutAreaBorderDownTimeTextTip(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602BA5F RID: 178783 RVA: 0x005F108B File Offset: 0x005EF28B
		public static void AddType(FlatBufferBuilder builder, EOutAreaBorderTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602BA60 RID: 178784 RVA: 0x005F1096 File Offset: 0x005EF296
		public static Offset<IOutAreaBorderDownTimeTextTip> EndIOutAreaBorderDownTimeTextTip(FlatBufferBuilder builder)
		{
			return new Offset<IOutAreaBorderDownTimeTextTip>(builder.EndTable());
		}

		// Token: 0x0602BA61 RID: 178785 RVA: 0x005F10A4 File Offset: 0x005EF2A4
		public IOutAreaBorderDownTimeTextTipT UnPack()
		{
			IOutAreaBorderDownTimeTextTipT outAreaBorderDownTimeTextTipT = new IOutAreaBorderDownTimeTextTipT();
			this.UnPackTo(outAreaBorderDownTimeTextTipT);
			return outAreaBorderDownTimeTextTipT;
		}

		// Token: 0x0602BA62 RID: 178786 RVA: 0x005F10BF File Offset: 0x005EF2BF
		public void UnPackTo(IOutAreaBorderDownTimeTextTipT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602BA63 RID: 178787 RVA: 0x005F10D0 File Offset: 0x005EF2D0
		public static Offset<IOutAreaBorderDownTimeTextTip> Pack(FlatBufferBuilder builder, IOutAreaBorderDownTimeTextTipT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOutAreaBorderDownTimeTextTip>);
			}
			return IOutAreaBorderDownTimeTextTip.CreateIOutAreaBorderDownTimeTextTip(builder, _o.Type);
		}

		// Token: 0x04010566 RID: 66918
		private Table __p;
	}
}
