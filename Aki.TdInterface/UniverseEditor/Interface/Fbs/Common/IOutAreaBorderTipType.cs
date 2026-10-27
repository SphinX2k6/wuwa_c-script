using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E21 RID: 24097
	public struct IOutAreaBorderTipType : IFlatbufferObject
	{
		// Token: 0x1700B44A RID: 46154
		// (get) Token: 0x0602941E RID: 168990 RVA: 0x005A8B3D File Offset: 0x005A6D3D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602941F RID: 168991 RVA: 0x005A8B4A File Offset: 0x005A6D4A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029420 RID: 168992 RVA: 0x005A8B54 File Offset: 0x005A6D54
		public static IOutAreaBorderTipType GetRootAsIOutAreaBorderTipType(ByteBuffer _bb)
		{
			return IOutAreaBorderTipType.GetRootAsIOutAreaBorderTipType(_bb, default(IOutAreaBorderTipType));
		}

		// Token: 0x06029421 RID: 168993 RVA: 0x005A8B70 File Offset: 0x005A6D70
		public static IOutAreaBorderTipType GetRootAsIOutAreaBorderTipType(ByteBuffer _bb, IOutAreaBorderTipType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029422 RID: 168994 RVA: 0x005A8B8D File Offset: 0x005A6D8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029423 RID: 168995 RVA: 0x005A8B9C File Offset: 0x005A6D9C
		public IOutAreaBorderTipType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B44B RID: 46155
		// (get) Token: 0x06029424 RID: 168996 RVA: 0x005A8BAC File Offset: 0x005A6DAC
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

		// Token: 0x06029425 RID: 168997 RVA: 0x005A8BE8 File Offset: 0x005A6DE8
		public static Offset<IOutAreaBorderTipType> CreateIOutAreaBorderTipType(FlatBufferBuilder builder, EOutAreaBorderTipType Type = EOutAreaBorderTipType.DownTimeTextTip)
		{
			builder.StartTable(1);
			IOutAreaBorderTipType.AddType(builder, Type);
			return IOutAreaBorderTipType.EndIOutAreaBorderTipType(builder);
		}

		// Token: 0x06029426 RID: 168998 RVA: 0x005A8BFE File Offset: 0x005A6DFE
		public static void StartIOutAreaBorderTipType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06029427 RID: 168999 RVA: 0x005A8C07 File Offset: 0x005A6E07
		public static void AddType(FlatBufferBuilder builder, EOutAreaBorderTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029428 RID: 169000 RVA: 0x005A8C12 File Offset: 0x005A6E12
		public static Offset<IOutAreaBorderTipType> EndIOutAreaBorderTipType(FlatBufferBuilder builder)
		{
			return new Offset<IOutAreaBorderTipType>(builder.EndTable());
		}

		// Token: 0x06029429 RID: 169001 RVA: 0x005A8C20 File Offset: 0x005A6E20
		public IOutAreaBorderTipTypeT UnPack()
		{
			IOutAreaBorderTipTypeT outAreaBorderTipTypeT = new IOutAreaBorderTipTypeT();
			this.UnPackTo(outAreaBorderTipTypeT);
			return outAreaBorderTipTypeT;
		}

		// Token: 0x0602942A RID: 169002 RVA: 0x005A8C3B File Offset: 0x005A6E3B
		public void UnPackTo(IOutAreaBorderTipTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602942B RID: 169003 RVA: 0x005A8C4C File Offset: 0x005A6E4C
		public static Offset<IOutAreaBorderTipType> Pack(FlatBufferBuilder builder, IOutAreaBorderTipTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOutAreaBorderTipType>);
			}
			return IOutAreaBorderTipType.CreateIOutAreaBorderTipType(builder, _o.Type);
		}

		// Token: 0x0400F81B RID: 63515
		private Table __p;
	}
}
