using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200645E RID: 25694
	public struct IOutAreaBorderTipType : IFlatbufferObject
	{
		// Token: 0x1700BDB0 RID: 48560
		// (get) Token: 0x0602BAA8 RID: 178856 RVA: 0x005F186D File Offset: 0x005EFA6D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BAA9 RID: 178857 RVA: 0x005F187A File Offset: 0x005EFA7A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BAAA RID: 178858 RVA: 0x005F1884 File Offset: 0x005EFA84
		public static IOutAreaBorderTipType GetRootAsIOutAreaBorderTipType(ByteBuffer _bb)
		{
			return IOutAreaBorderTipType.GetRootAsIOutAreaBorderTipType(_bb, default(IOutAreaBorderTipType));
		}

		// Token: 0x0602BAAB RID: 178859 RVA: 0x005F18A0 File Offset: 0x005EFAA0
		public static IOutAreaBorderTipType GetRootAsIOutAreaBorderTipType(ByteBuffer _bb, IOutAreaBorderTipType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BAAC RID: 178860 RVA: 0x005F18BD File Offset: 0x005EFABD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BAAD RID: 178861 RVA: 0x005F18CC File Offset: 0x005EFACC
		public IOutAreaBorderTipType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BDB1 RID: 48561
		// (get) Token: 0x0602BAAE RID: 178862 RVA: 0x005F18DC File Offset: 0x005EFADC
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

		// Token: 0x0602BAAF RID: 178863 RVA: 0x005F1918 File Offset: 0x005EFB18
		public static Offset<IOutAreaBorderTipType> CreateIOutAreaBorderTipType(FlatBufferBuilder builder, EOutAreaBorderTipType Type = EOutAreaBorderTipType.DownTimeTextTip)
		{
			builder.StartTable(1);
			IOutAreaBorderTipType.AddType(builder, Type);
			return IOutAreaBorderTipType.EndIOutAreaBorderTipType(builder);
		}

		// Token: 0x0602BAB0 RID: 178864 RVA: 0x005F192E File Offset: 0x005EFB2E
		public static void StartIOutAreaBorderTipType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602BAB1 RID: 178865 RVA: 0x005F1937 File Offset: 0x005EFB37
		public static void AddType(FlatBufferBuilder builder, EOutAreaBorderTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602BAB2 RID: 178866 RVA: 0x005F1942 File Offset: 0x005EFB42
		public static Offset<IOutAreaBorderTipType> EndIOutAreaBorderTipType(FlatBufferBuilder builder)
		{
			return new Offset<IOutAreaBorderTipType>(builder.EndTable());
		}

		// Token: 0x0602BAB3 RID: 178867 RVA: 0x005F1950 File Offset: 0x005EFB50
		public IOutAreaBorderTipTypeT UnPack()
		{
			IOutAreaBorderTipTypeT outAreaBorderTipTypeT = new IOutAreaBorderTipTypeT();
			this.UnPackTo(outAreaBorderTipTypeT);
			return outAreaBorderTipTypeT;
		}

		// Token: 0x0602BAB4 RID: 178868 RVA: 0x005F196B File Offset: 0x005EFB6B
		public void UnPackTo(IOutAreaBorderTipTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602BAB5 RID: 178869 RVA: 0x005F197C File Offset: 0x005EFB7C
		public static Offset<IOutAreaBorderTipType> Pack(FlatBufferBuilder builder, IOutAreaBorderTipTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOutAreaBorderTipType>);
			}
			return IOutAreaBorderTipType.CreateIOutAreaBorderTipType(builder, _o.Type);
		}

		// Token: 0x04010576 RID: 66934
		private Table __p;
	}
}
