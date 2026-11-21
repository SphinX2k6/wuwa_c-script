using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005996 RID: 22934
	public struct IInhaledPerformance : IFlatbufferObject
	{
		// Token: 0x1700A693 RID: 42643
		// (get) Token: 0x06025643 RID: 153155 RVA: 0x00521815 File Offset: 0x0051FA15
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025644 RID: 153156 RVA: 0x00521822 File Offset: 0x0051FA22
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025645 RID: 153157 RVA: 0x0052182C File Offset: 0x0051FA2C
		public static IInhaledPerformance GetRootAsIInhaledPerformance(ByteBuffer _bb)
		{
			return IInhaledPerformance.GetRootAsIInhaledPerformance(_bb, default(IInhaledPerformance));
		}

		// Token: 0x06025646 RID: 153158 RVA: 0x00521848 File Offset: 0x0051FA48
		public static IInhaledPerformance GetRootAsIInhaledPerformance(ByteBuffer _bb, IInhaledPerformance obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025647 RID: 153159 RVA: 0x00521865 File Offset: 0x0051FA65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025648 RID: 153160 RVA: 0x00521874 File Offset: 0x0051FA74
		public IInhaledPerformance __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A694 RID: 42644
		// (get) Token: 0x06025649 RID: 153161 RVA: 0x00521884 File Offset: 0x0051FA84
		public float InhaledTime
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602564A RID: 153162 RVA: 0x005218C4 File Offset: 0x0051FAC4
		public static Offset<IInhaledPerformance> CreateIInhaledPerformance(FlatBufferBuilder builder, float InhaledTime = 0f)
		{
			builder.StartTable(1);
			IInhaledPerformance.AddInhaledTime(builder, InhaledTime);
			return IInhaledPerformance.EndIInhaledPerformance(builder);
		}

		// Token: 0x0602564B RID: 153163 RVA: 0x005218DA File Offset: 0x0051FADA
		public static void StartIInhaledPerformance(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602564C RID: 153164 RVA: 0x005218E3 File Offset: 0x0051FAE3
		public static void AddInhaledTime(FlatBufferBuilder builder, float inhaledTime)
		{
			builder.AddFloat(0, inhaledTime, 0.0);
		}

		// Token: 0x0602564D RID: 153165 RVA: 0x005218F6 File Offset: 0x0051FAF6
		public static Offset<IInhaledPerformance> EndIInhaledPerformance(FlatBufferBuilder builder)
		{
			return new Offset<IInhaledPerformance>(builder.EndTable());
		}

		// Token: 0x0602564E RID: 153166 RVA: 0x00521904 File Offset: 0x0051FB04
		public IInhaledPerformanceT UnPack()
		{
			IInhaledPerformanceT inhaledPerformanceT = new IInhaledPerformanceT();
			this.UnPackTo(inhaledPerformanceT);
			return inhaledPerformanceT;
		}

		// Token: 0x0602564F RID: 153167 RVA: 0x0052191F File Offset: 0x0051FB1F
		public void UnPackTo(IInhaledPerformanceT _o)
		{
			_o.InhaledTime = this.InhaledTime;
		}

		// Token: 0x06025650 RID: 153168 RVA: 0x00521930 File Offset: 0x0051FB30
		public static Offset<IInhaledPerformance> Pack(FlatBufferBuilder builder, IInhaledPerformanceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInhaledPerformance>);
			}
			return IInhaledPerformance.CreateIInhaledPerformance(builder, _o.InhaledTime);
		}

		// Token: 0x0400F28B RID: 62091
		private Table __p;
	}
}
