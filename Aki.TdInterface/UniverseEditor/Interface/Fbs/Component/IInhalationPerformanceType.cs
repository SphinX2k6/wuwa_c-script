using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005987 RID: 22919
	public struct IInhalationPerformanceType : IFlatbufferObject
	{
		// Token: 0x1700A679 RID: 42617
		// (get) Token: 0x060255CF RID: 153039 RVA: 0x00520B60 File Offset: 0x0051ED60
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060255D0 RID: 153040 RVA: 0x00520B6D File Offset: 0x0051ED6D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060255D1 RID: 153041 RVA: 0x00520B74 File Offset: 0x0051ED74
		public static IInhalationPerformanceType GetRootAsIInhalationPerformanceType(ByteBuffer _bb)
		{
			return IInhalationPerformanceType.GetRootAsIInhalationPerformanceType(_bb, default(IInhalationPerformanceType));
		}

		// Token: 0x060255D2 RID: 153042 RVA: 0x00520B90 File Offset: 0x0051ED90
		public static IInhalationPerformanceType GetRootAsIInhalationPerformanceType(ByteBuffer _bb, IInhalationPerformanceType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060255D3 RID: 153043 RVA: 0x00520BAD File Offset: 0x0051EDAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060255D4 RID: 153044 RVA: 0x00520BBC File Offset: 0x0051EDBC
		public IInhalationPerformanceType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A67A RID: 42618
		// (get) Token: 0x060255D5 RID: 153045 RVA: 0x00520BCC File Offset: 0x0051EDCC
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

		// Token: 0x060255D6 RID: 153046 RVA: 0x00520C08 File Offset: 0x0051EE08
		public static Offset<IInhalationPerformanceType> CreateIInhalationPerformanceType(FlatBufferBuilder builder, EInhalationPerformanceType Type = EInhalationPerformanceType.Role)
		{
			builder.StartTable(1);
			IInhalationPerformanceType.AddType(builder, Type);
			return IInhalationPerformanceType.EndIInhalationPerformanceType(builder);
		}

		// Token: 0x060255D7 RID: 153047 RVA: 0x00520C1E File Offset: 0x0051EE1E
		public static void StartIInhalationPerformanceType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060255D8 RID: 153048 RVA: 0x00520C27 File Offset: 0x0051EE27
		public static void AddType(FlatBufferBuilder builder, EInhalationPerformanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060255D9 RID: 153049 RVA: 0x00520C32 File Offset: 0x0051EE32
		public static Offset<IInhalationPerformanceType> EndIInhalationPerformanceType(FlatBufferBuilder builder)
		{
			return new Offset<IInhalationPerformanceType>(builder.EndTable());
		}

		// Token: 0x060255DA RID: 153050 RVA: 0x00520C40 File Offset: 0x0051EE40
		public IInhalationPerformanceTypeT UnPack()
		{
			IInhalationPerformanceTypeT inhalationPerformanceTypeT = new IInhalationPerformanceTypeT();
			this.UnPackTo(inhalationPerformanceTypeT);
			return inhalationPerformanceTypeT;
		}

		// Token: 0x060255DB RID: 153051 RVA: 0x00520C5B File Offset: 0x0051EE5B
		public void UnPackTo(IInhalationPerformanceTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060255DC RID: 153052 RVA: 0x00520C6C File Offset: 0x0051EE6C
		public static Offset<IInhalationPerformanceType> Pack(FlatBufferBuilder builder, IInhalationPerformanceTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInhalationPerformanceType>);
			}
			return IInhalationPerformanceType.CreateIInhalationPerformanceType(builder, _o.Type);
		}

		// Token: 0x0400F276 RID: 62070
		private Table __p;
	}
}
