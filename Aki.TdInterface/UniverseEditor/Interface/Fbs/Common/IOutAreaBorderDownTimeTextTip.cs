using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E15 RID: 24085
	public struct IOutAreaBorderDownTimeTextTip : IFlatbufferObject
	{
		// Token: 0x1700B437 RID: 46135
		// (get) Token: 0x060293CC RID: 168908 RVA: 0x005A8293 File Offset: 0x005A6493
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060293CD RID: 168909 RVA: 0x005A82A0 File Offset: 0x005A64A0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060293CE RID: 168910 RVA: 0x005A82A8 File Offset: 0x005A64A8
		public static IOutAreaBorderDownTimeTextTip GetRootAsIOutAreaBorderDownTimeTextTip(ByteBuffer _bb)
		{
			return IOutAreaBorderDownTimeTextTip.GetRootAsIOutAreaBorderDownTimeTextTip(_bb, default(IOutAreaBorderDownTimeTextTip));
		}

		// Token: 0x060293CF RID: 168911 RVA: 0x005A82C4 File Offset: 0x005A64C4
		public static IOutAreaBorderDownTimeTextTip GetRootAsIOutAreaBorderDownTimeTextTip(ByteBuffer _bb, IOutAreaBorderDownTimeTextTip obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060293D0 RID: 168912 RVA: 0x005A82E1 File Offset: 0x005A64E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060293D1 RID: 168913 RVA: 0x005A82F0 File Offset: 0x005A64F0
		public IOutAreaBorderDownTimeTextTip __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B438 RID: 46136
		// (get) Token: 0x060293D2 RID: 168914 RVA: 0x005A8300 File Offset: 0x005A6500
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

		// Token: 0x060293D3 RID: 168915 RVA: 0x005A833C File Offset: 0x005A653C
		public static Offset<IOutAreaBorderDownTimeTextTip> CreateIOutAreaBorderDownTimeTextTip(FlatBufferBuilder builder, EOutAreaBorderTipType Type = EOutAreaBorderTipType.DownTimeTextTip)
		{
			builder.StartTable(1);
			IOutAreaBorderDownTimeTextTip.AddType(builder, Type);
			return IOutAreaBorderDownTimeTextTip.EndIOutAreaBorderDownTimeTextTip(builder);
		}

		// Token: 0x060293D4 RID: 168916 RVA: 0x005A8352 File Offset: 0x005A6552
		public static void StartIOutAreaBorderDownTimeTextTip(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060293D5 RID: 168917 RVA: 0x005A835B File Offset: 0x005A655B
		public static void AddType(FlatBufferBuilder builder, EOutAreaBorderTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060293D6 RID: 168918 RVA: 0x005A8366 File Offset: 0x005A6566
		public static Offset<IOutAreaBorderDownTimeTextTip> EndIOutAreaBorderDownTimeTextTip(FlatBufferBuilder builder)
		{
			return new Offset<IOutAreaBorderDownTimeTextTip>(builder.EndTable());
		}

		// Token: 0x060293D7 RID: 168919 RVA: 0x005A8374 File Offset: 0x005A6574
		public IOutAreaBorderDownTimeTextTipT UnPack()
		{
			IOutAreaBorderDownTimeTextTipT outAreaBorderDownTimeTextTipT = new IOutAreaBorderDownTimeTextTipT();
			this.UnPackTo(outAreaBorderDownTimeTextTipT);
			return outAreaBorderDownTimeTextTipT;
		}

		// Token: 0x060293D8 RID: 168920 RVA: 0x005A838F File Offset: 0x005A658F
		public void UnPackTo(IOutAreaBorderDownTimeTextTipT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060293D9 RID: 168921 RVA: 0x005A83A0 File Offset: 0x005A65A0
		public static Offset<IOutAreaBorderDownTimeTextTip> Pack(FlatBufferBuilder builder, IOutAreaBorderDownTimeTextTipT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOutAreaBorderDownTimeTextTip>);
			}
			return IOutAreaBorderDownTimeTextTip.CreateIOutAreaBorderDownTimeTextTip(builder, _o.Type);
		}

		// Token: 0x0400F80B RID: 63499
		private Table __p;
	}
}
