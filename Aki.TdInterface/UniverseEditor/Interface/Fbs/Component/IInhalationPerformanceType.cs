using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005401 RID: 21505
	public struct IInhalationPerformanceType : IFlatbufferObject
	{
		// Token: 0x17009E3F RID: 40511
		// (get) Token: 0x06023517 RID: 144663 RVA: 0x004E3B34 File Offset: 0x004E1D34
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023518 RID: 144664 RVA: 0x004E3B41 File Offset: 0x004E1D41
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023519 RID: 144665 RVA: 0x004E3B48 File Offset: 0x004E1D48
		public static IInhalationPerformanceType GetRootAsIInhalationPerformanceType(ByteBuffer _bb)
		{
			return IInhalationPerformanceType.GetRootAsIInhalationPerformanceType(_bb, default(IInhalationPerformanceType));
		}

		// Token: 0x0602351A RID: 144666 RVA: 0x004E3B64 File Offset: 0x004E1D64
		public static IInhalationPerformanceType GetRootAsIInhalationPerformanceType(ByteBuffer _bb, IInhalationPerformanceType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602351B RID: 144667 RVA: 0x004E3B81 File Offset: 0x004E1D81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602351C RID: 144668 RVA: 0x004E3B90 File Offset: 0x004E1D90
		public IInhalationPerformanceType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009E40 RID: 40512
		// (get) Token: 0x0602351D RID: 144669 RVA: 0x004E3BA0 File Offset: 0x004E1DA0
		public EInhalationPerformanceType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInhalationPerformanceType.Role;
				}
				return (EInhalationPerformanceType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602351E RID: 144670 RVA: 0x004E3BDC File Offset: 0x004E1DDC
		public static Offset<IInhalationPerformanceType> CreateIInhalationPerformanceType(FlatBufferBuilder builder, EInhalationPerformanceType Type = EInhalationPerformanceType.Role)
		{
			builder.StartTable(1);
			IInhalationPerformanceType.AddType(builder, Type);
			return IInhalationPerformanceType.EndIInhalationPerformanceType(builder);
		}

		// Token: 0x0602351F RID: 144671 RVA: 0x004E3BF2 File Offset: 0x004E1DF2
		public static void StartIInhalationPerformanceType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06023520 RID: 144672 RVA: 0x004E3BFB File Offset: 0x004E1DFB
		public static void AddType(FlatBufferBuilder builder, EInhalationPerformanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023521 RID: 144673 RVA: 0x004E3C06 File Offset: 0x004E1E06
		public static Offset<IInhalationPerformanceType> EndIInhalationPerformanceType(FlatBufferBuilder builder)
		{
			return new Offset<IInhalationPerformanceType>(builder.EndTable());
		}

		// Token: 0x06023522 RID: 144674 RVA: 0x004E3C14 File Offset: 0x004E1E14
		public IInhalationPerformanceTypeT UnPack()
		{
			IInhalationPerformanceTypeT inhalationPerformanceTypeT = new IInhalationPerformanceTypeT();
			this.UnPackTo(inhalationPerformanceTypeT);
			return inhalationPerformanceTypeT;
		}

		// Token: 0x06023523 RID: 144675 RVA: 0x004E3C2F File Offset: 0x004E1E2F
		public void UnPackTo(IInhalationPerformanceTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06023524 RID: 144676 RVA: 0x004E3C40 File Offset: 0x004E1E40
		public static Offset<IInhalationPerformanceType> Pack(FlatBufferBuilder builder, IInhalationPerformanceTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInhalationPerformanceType>);
			}
			return IInhalationPerformanceType.CreateIInhalationPerformanceType(builder, _o.Type);
		}

		// Token: 0x0400E645 RID: 58949
		private Table __p;
	}
}
