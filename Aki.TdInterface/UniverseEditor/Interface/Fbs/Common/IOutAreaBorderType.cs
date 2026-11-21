using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006464 RID: 25700
	public struct IOutAreaBorderType : IFlatbufferObject
	{
		// Token: 0x1700BDB5 RID: 48565
		// (get) Token: 0x0602BAC6 RID: 178886 RVA: 0x005F1AE2 File Offset: 0x005EFCE2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BAC7 RID: 178887 RVA: 0x005F1AEF File Offset: 0x005EFCEF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BAC8 RID: 178888 RVA: 0x005F1AF8 File Offset: 0x005EFCF8
		public static IOutAreaBorderType GetRootAsIOutAreaBorderType(ByteBuffer _bb)
		{
			return IOutAreaBorderType.GetRootAsIOutAreaBorderType(_bb, default(IOutAreaBorderType));
		}

		// Token: 0x0602BAC9 RID: 178889 RVA: 0x005F1B14 File Offset: 0x005EFD14
		public static IOutAreaBorderType GetRootAsIOutAreaBorderType(ByteBuffer _bb, IOutAreaBorderType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BACA RID: 178890 RVA: 0x005F1B31 File Offset: 0x005EFD31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BACB RID: 178891 RVA: 0x005F1B40 File Offset: 0x005EFD40
		public IOutAreaBorderType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BDB6 RID: 48566
		// (get) Token: 0x0602BACC RID: 178892 RVA: 0x005F1B50 File Offset: 0x005EFD50
		public EOutAreaBorderType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EOutAreaBorderType.TeleportTimer;
				}
				return (EOutAreaBorderType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602BACD RID: 178893 RVA: 0x005F1B8C File Offset: 0x005EFD8C
		public static Offset<IOutAreaBorderType> CreateIOutAreaBorderType(FlatBufferBuilder builder, EOutAreaBorderType Type = EOutAreaBorderType.TeleportTimer)
		{
			builder.StartTable(1);
			IOutAreaBorderType.AddType(builder, Type);
			return IOutAreaBorderType.EndIOutAreaBorderType(builder);
		}

		// Token: 0x0602BACE RID: 178894 RVA: 0x005F1BA2 File Offset: 0x005EFDA2
		public static void StartIOutAreaBorderType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602BACF RID: 178895 RVA: 0x005F1BAB File Offset: 0x005EFDAB
		public static void AddType(FlatBufferBuilder builder, EOutAreaBorderType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602BAD0 RID: 178896 RVA: 0x005F1BB6 File Offset: 0x005EFDB6
		public static Offset<IOutAreaBorderType> EndIOutAreaBorderType(FlatBufferBuilder builder)
		{
			return new Offset<IOutAreaBorderType>(builder.EndTable());
		}

		// Token: 0x0602BAD1 RID: 178897 RVA: 0x005F1BC4 File Offset: 0x005EFDC4
		public IOutAreaBorderTypeT UnPack()
		{
			IOutAreaBorderTypeT outAreaBorderTypeT = new IOutAreaBorderTypeT();
			this.UnPackTo(outAreaBorderTypeT);
			return outAreaBorderTypeT;
		}

		// Token: 0x0602BAD2 RID: 178898 RVA: 0x005F1BDF File Offset: 0x005EFDDF
		public void UnPackTo(IOutAreaBorderTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602BAD3 RID: 178899 RVA: 0x005F1BF0 File Offset: 0x005EFDF0
		public static Offset<IOutAreaBorderType> Pack(FlatBufferBuilder builder, IOutAreaBorderTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOutAreaBorderType>);
			}
			return IOutAreaBorderType.CreateIOutAreaBorderType(builder, _o.Type);
		}

		// Token: 0x0401057E RID: 66942
		private Table __p;
	}
}
