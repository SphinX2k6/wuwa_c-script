using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005718 RID: 22296
	public struct IPerformanceOptimization : IFlatbufferObject
	{
		// Token: 0x1700A61F RID: 42527
		// (get) Token: 0x060254C8 RID: 152776 RVA: 0x00525A8E File Offset: 0x00523C8E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060254C9 RID: 152777 RVA: 0x00525A9B File Offset: 0x00523C9B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060254CA RID: 152778 RVA: 0x00525AA4 File Offset: 0x00523CA4
		public static IPerformanceOptimization GetRootAsIPerformanceOptimization(ByteBuffer _bb)
		{
			return IPerformanceOptimization.GetRootAsIPerformanceOptimization(_bb, default(IPerformanceOptimization));
		}

		// Token: 0x060254CB RID: 152779 RVA: 0x00525AC0 File Offset: 0x00523CC0
		public static IPerformanceOptimization GetRootAsIPerformanceOptimization(ByteBuffer _bb, IPerformanceOptimization obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060254CC RID: 152780 RVA: 0x00525ADD File Offset: 0x00523CDD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060254CD RID: 152781 RVA: 0x00525AEC File Offset: 0x00523CEC
		public IPerformanceOptimization __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A620 RID: 42528
		// (get) Token: 0x060254CE RID: 152782 RVA: 0x00525AFC File Offset: 0x00523CFC
		public EPerformanceOptimizationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPerformanceOptimizationType.PlaneMovementOptimization;
				}
				return (EPerformanceOptimizationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060254CF RID: 152783 RVA: 0x00525B38 File Offset: 0x00523D38
		public static Offset<IPerformanceOptimization> CreateIPerformanceOptimization(FlatBufferBuilder builder, EPerformanceOptimizationType Type = EPerformanceOptimizationType.PlaneMovementOptimization)
		{
			builder.StartTable(1);
			IPerformanceOptimization.AddType(builder, Type);
			return IPerformanceOptimization.EndIPerformanceOptimization(builder);
		}

		// Token: 0x060254D0 RID: 152784 RVA: 0x00525B4E File Offset: 0x00523D4E
		public static void StartIPerformanceOptimization(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060254D1 RID: 152785 RVA: 0x00525B57 File Offset: 0x00523D57
		public static void AddType(FlatBufferBuilder builder, EPerformanceOptimizationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060254D2 RID: 152786 RVA: 0x00525B62 File Offset: 0x00523D62
		public static Offset<IPerformanceOptimization> EndIPerformanceOptimization(FlatBufferBuilder builder)
		{
			return new Offset<IPerformanceOptimization>(builder.EndTable());
		}

		// Token: 0x060254D3 RID: 152787 RVA: 0x00525B70 File Offset: 0x00523D70
		public IPerformanceOptimizationT UnPack()
		{
			IPerformanceOptimizationT performanceOptimizationT = new IPerformanceOptimizationT();
			this.UnPackTo(performanceOptimizationT);
			return performanceOptimizationT;
		}

		// Token: 0x060254D4 RID: 152788 RVA: 0x00525B8B File Offset: 0x00523D8B
		public void UnPackTo(IPerformanceOptimizationT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060254D5 RID: 152789 RVA: 0x00525B9C File Offset: 0x00523D9C
		public static Offset<IPerformanceOptimization> Pack(FlatBufferBuilder builder, IPerformanceOptimizationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPerformanceOptimization>);
			}
			return IPerformanceOptimization.CreateIPerformanceOptimization(builder, _o.Type);
		}

		// Token: 0x0400EB89 RID: 60297
		private Table __p;
	}
}
