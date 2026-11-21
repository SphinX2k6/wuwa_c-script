using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006485 RID: 25733
	public struct IProcessedValueType : IFlatbufferObject
	{
		// Token: 0x1700BDDA RID: 48602
		// (get) Token: 0x0602BB9D RID: 179101 RVA: 0x005F3010 File Offset: 0x005F1210
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BB9E RID: 179102 RVA: 0x005F301D File Offset: 0x005F121D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BB9F RID: 179103 RVA: 0x005F3024 File Offset: 0x005F1224
		public static IProcessedValueType GetRootAsIProcessedValueType(ByteBuffer _bb)
		{
			return IProcessedValueType.GetRootAsIProcessedValueType(_bb, default(IProcessedValueType));
		}

		// Token: 0x0602BBA0 RID: 179104 RVA: 0x005F3040 File Offset: 0x005F1240
		public static IProcessedValueType GetRootAsIProcessedValueType(ByteBuffer _bb, IProcessedValueType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BBA1 RID: 179105 RVA: 0x005F305D File Offset: 0x005F125D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BBA2 RID: 179106 RVA: 0x005F306C File Offset: 0x005F126C
		public IProcessedValueType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BDDB RID: 48603
		// (get) Token: 0x0602BBA3 RID: 179107 RVA: 0x005F307C File Offset: 0x005F127C
		public EProcessedValueType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EProcessedValueType.Constant;
				}
				return (EProcessedValueType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602BBA4 RID: 179108 RVA: 0x005F30B8 File Offset: 0x005F12B8
		public static Offset<IProcessedValueType> CreateIProcessedValueType(FlatBufferBuilder builder, EProcessedValueType Type = EProcessedValueType.Constant)
		{
			builder.StartTable(1);
			IProcessedValueType.AddType(builder, Type);
			return IProcessedValueType.EndIProcessedValueType(builder);
		}

		// Token: 0x0602BBA5 RID: 179109 RVA: 0x005F30CE File Offset: 0x005F12CE
		public static void StartIProcessedValueType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602BBA6 RID: 179110 RVA: 0x005F30D7 File Offset: 0x005F12D7
		public static void AddType(FlatBufferBuilder builder, EProcessedValueType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602BBA7 RID: 179111 RVA: 0x005F30E2 File Offset: 0x005F12E2
		public static Offset<IProcessedValueType> EndIProcessedValueType(FlatBufferBuilder builder)
		{
			return new Offset<IProcessedValueType>(builder.EndTable());
		}

		// Token: 0x0602BBA8 RID: 179112 RVA: 0x005F30F0 File Offset: 0x005F12F0
		public IProcessedValueTypeT UnPack()
		{
			IProcessedValueTypeT processedValueTypeT = new IProcessedValueTypeT();
			this.UnPackTo(processedValueTypeT);
			return processedValueTypeT;
		}

		// Token: 0x0602BBA9 RID: 179113 RVA: 0x005F310B File Offset: 0x005F130B
		public void UnPackTo(IProcessedValueTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602BBAA RID: 179114 RVA: 0x005F311C File Offset: 0x005F131C
		public static Offset<IProcessedValueType> Pack(FlatBufferBuilder builder, IProcessedValueTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IProcessedValueType>);
			}
			return IProcessedValueType.CreateIProcessedValueType(builder, _o.Type);
		}

		// Token: 0x040105A2 RID: 66978
		private Table __p;
	}
}
