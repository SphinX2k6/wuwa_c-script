using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005410 RID: 21520
	public struct IInhaledPerformance : IFlatbufferObject
	{
		// Token: 0x17009E59 RID: 40537
		// (get) Token: 0x0602358B RID: 144779 RVA: 0x004E47E9 File Offset: 0x004E29E9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602358C RID: 144780 RVA: 0x004E47F6 File Offset: 0x004E29F6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602358D RID: 144781 RVA: 0x004E4800 File Offset: 0x004E2A00
		public static IInhaledPerformance GetRootAsIInhaledPerformance(ByteBuffer _bb)
		{
			return IInhaledPerformance.GetRootAsIInhaledPerformance(_bb, default(IInhaledPerformance));
		}

		// Token: 0x0602358E RID: 144782 RVA: 0x004E481C File Offset: 0x004E2A1C
		public static IInhaledPerformance GetRootAsIInhaledPerformance(ByteBuffer _bb, IInhaledPerformance obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602358F RID: 144783 RVA: 0x004E4839 File Offset: 0x004E2A39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023590 RID: 144784 RVA: 0x004E4848 File Offset: 0x004E2A48
		public IInhaledPerformance __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009E5A RID: 40538
		// (get) Token: 0x06023591 RID: 144785 RVA: 0x004E4858 File Offset: 0x004E2A58
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

		// Token: 0x06023592 RID: 144786 RVA: 0x004E4898 File Offset: 0x004E2A98
		public static Offset<IInhaledPerformance> CreateIInhaledPerformance(FlatBufferBuilder builder, float InhaledTime = 0f)
		{
			builder.StartTable(1);
			IInhaledPerformance.AddInhaledTime(builder, InhaledTime);
			return IInhaledPerformance.EndIInhaledPerformance(builder);
		}

		// Token: 0x06023593 RID: 144787 RVA: 0x004E48AE File Offset: 0x004E2AAE
		public static void StartIInhaledPerformance(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06023594 RID: 144788 RVA: 0x004E48B7 File Offset: 0x004E2AB7
		public static void AddInhaledTime(FlatBufferBuilder builder, float inhaledTime)
		{
			builder.AddFloat(0, inhaledTime, 0.0);
		}

		// Token: 0x06023595 RID: 144789 RVA: 0x004E48CA File Offset: 0x004E2ACA
		public static Offset<IInhaledPerformance> EndIInhaledPerformance(FlatBufferBuilder builder)
		{
			return new Offset<IInhaledPerformance>(builder.EndTable());
		}

		// Token: 0x06023596 RID: 144790 RVA: 0x004E48D8 File Offset: 0x004E2AD8
		public IInhaledPerformanceT UnPack()
		{
			IInhaledPerformanceT inhaledPerformanceT = new IInhaledPerformanceT();
			this.UnPackTo(inhaledPerformanceT);
			return inhaledPerformanceT;
		}

		// Token: 0x06023597 RID: 144791 RVA: 0x004E48F3 File Offset: 0x004E2AF3
		public void UnPackTo(IInhaledPerformanceT _o)
		{
			_o.InhaledTime = this.InhaledTime;
		}

		// Token: 0x06023598 RID: 144792 RVA: 0x004E4904 File Offset: 0x004E2B04
		public static Offset<IInhaledPerformance> Pack(FlatBufferBuilder builder, IInhaledPerformanceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInhaledPerformance>);
			}
			return IInhaledPerformance.CreateIInhaledPerformance(builder, _o.InhaledTime);
		}

		// Token: 0x0400E65A RID: 58970
		private Table __p;
	}
}
