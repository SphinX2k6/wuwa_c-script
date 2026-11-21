using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D1F RID: 23839
	public struct IPerformanceOptimization : IFlatbufferObject
	{
		// Token: 0x1700AF3F RID: 44863
		// (get) Token: 0x060279D7 RID: 162263 RVA: 0x0056B796 File Offset: 0x00569996
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060279D8 RID: 162264 RVA: 0x0056B7A3 File Offset: 0x005699A3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060279D9 RID: 162265 RVA: 0x0056B7AC File Offset: 0x005699AC
		public static IPerformanceOptimization GetRootAsIPerformanceOptimization(ByteBuffer _bb)
		{
			return IPerformanceOptimization.GetRootAsIPerformanceOptimization(_bb, default(IPerformanceOptimization));
		}

		// Token: 0x060279DA RID: 162266 RVA: 0x0056B7C8 File Offset: 0x005699C8
		public static IPerformanceOptimization GetRootAsIPerformanceOptimization(ByteBuffer _bb, IPerformanceOptimization obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060279DB RID: 162267 RVA: 0x0056B7E5 File Offset: 0x005699E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060279DC RID: 162268 RVA: 0x0056B7F4 File Offset: 0x005699F4
		public IPerformanceOptimization __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AF40 RID: 44864
		// (get) Token: 0x060279DD RID: 162269 RVA: 0x0056B804 File Offset: 0x00569A04
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

		// Token: 0x060279DE RID: 162270 RVA: 0x0056B840 File Offset: 0x00569A40
		public static Offset<IPerformanceOptimization> CreateIPerformanceOptimization(FlatBufferBuilder builder, EPerformanceOptimizationType Type = EPerformanceOptimizationType.PlaneMovementOptimization)
		{
			builder.StartTable(1);
			IPerformanceOptimization.AddType(builder, Type);
			return IPerformanceOptimization.EndIPerformanceOptimization(builder);
		}

		// Token: 0x060279DF RID: 162271 RVA: 0x0056B856 File Offset: 0x00569A56
		public static void StartIPerformanceOptimization(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060279E0 RID: 162272 RVA: 0x0056B85F File Offset: 0x00569A5F
		public static void AddType(FlatBufferBuilder builder, EPerformanceOptimizationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060279E1 RID: 162273 RVA: 0x0056B86A File Offset: 0x00569A6A
		public static Offset<IPerformanceOptimization> EndIPerformanceOptimization(FlatBufferBuilder builder)
		{
			return new Offset<IPerformanceOptimization>(builder.EndTable());
		}

		// Token: 0x060279E2 RID: 162274 RVA: 0x0056B878 File Offset: 0x00569A78
		public IPerformanceOptimizationT UnPack()
		{
			IPerformanceOptimizationT performanceOptimizationT = new IPerformanceOptimizationT();
			this.UnPackTo(performanceOptimizationT);
			return performanceOptimizationT;
		}

		// Token: 0x060279E3 RID: 162275 RVA: 0x0056B893 File Offset: 0x00569A93
		public void UnPackTo(IPerformanceOptimizationT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060279E4 RID: 162276 RVA: 0x0056B8A4 File Offset: 0x00569AA4
		public static Offset<IPerformanceOptimization> Pack(FlatBufferBuilder builder, IPerformanceOptimizationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPerformanceOptimization>);
			}
			return IPerformanceOptimization.CreateIPerformanceOptimization(builder, _o.Type);
		}

		// Token: 0x0400F872 RID: 63602
		private Table __p;
	}
}
