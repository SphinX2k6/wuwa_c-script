using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005745 RID: 22341
	public struct IPlaneMovementOptimizationConfig : IFlatbufferObject
	{
		// Token: 0x1700A6B1 RID: 42673
		// (get) Token: 0x060256F5 RID: 153333 RVA: 0x0052A8C8 File Offset: 0x00528AC8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060256F6 RID: 153334 RVA: 0x0052A8D5 File Offset: 0x00528AD5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060256F7 RID: 153335 RVA: 0x0052A8DC File Offset: 0x00528ADC
		public static IPlaneMovementOptimizationConfig GetRootAsIPlaneMovementOptimizationConfig(ByteBuffer _bb)
		{
			return IPlaneMovementOptimizationConfig.GetRootAsIPlaneMovementOptimizationConfig(_bb, default(IPlaneMovementOptimizationConfig));
		}

		// Token: 0x060256F8 RID: 153336 RVA: 0x0052A8F8 File Offset: 0x00528AF8
		public static IPlaneMovementOptimizationConfig GetRootAsIPlaneMovementOptimizationConfig(ByteBuffer _bb, IPlaneMovementOptimizationConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060256F9 RID: 153337 RVA: 0x0052A915 File Offset: 0x00528B15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060256FA RID: 153338 RVA: 0x0052A924 File Offset: 0x00528B24
		public IPlaneMovementOptimizationConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A6B2 RID: 42674
		// (get) Token: 0x060256FB RID: 153339 RVA: 0x0052A934 File Offset: 0x00528B34
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

		// Token: 0x060256FC RID: 153340 RVA: 0x0052A970 File Offset: 0x00528B70
		public static Offset<IPlaneMovementOptimizationConfig> CreateIPlaneMovementOptimizationConfig(FlatBufferBuilder builder, EPerformanceOptimizationType Type = EPerformanceOptimizationType.PlaneMovementOptimization)
		{
			builder.StartTable(1);
			IPlaneMovementOptimizationConfig.AddType(builder, Type);
			return IPlaneMovementOptimizationConfig.EndIPlaneMovementOptimizationConfig(builder);
		}

		// Token: 0x060256FD RID: 153341 RVA: 0x0052A986 File Offset: 0x00528B86
		public static void StartIPlaneMovementOptimizationConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060256FE RID: 153342 RVA: 0x0052A98F File Offset: 0x00528B8F
		public static void AddType(FlatBufferBuilder builder, EPerformanceOptimizationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060256FF RID: 153343 RVA: 0x0052A99A File Offset: 0x00528B9A
		public static Offset<IPlaneMovementOptimizationConfig> EndIPlaneMovementOptimizationConfig(FlatBufferBuilder builder)
		{
			return new Offset<IPlaneMovementOptimizationConfig>(builder.EndTable());
		}

		// Token: 0x06025700 RID: 153344 RVA: 0x0052A9A8 File Offset: 0x00528BA8
		public IPlaneMovementOptimizationConfigT UnPack()
		{
			IPlaneMovementOptimizationConfigT planeMovementOptimizationConfigT = new IPlaneMovementOptimizationConfigT();
			this.UnPackTo(planeMovementOptimizationConfigT);
			return planeMovementOptimizationConfigT;
		}

		// Token: 0x06025701 RID: 153345 RVA: 0x0052A9C3 File Offset: 0x00528BC3
		public void UnPackTo(IPlaneMovementOptimizationConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06025702 RID: 153346 RVA: 0x0052A9D4 File Offset: 0x00528BD4
		public static Offset<IPlaneMovementOptimizationConfig> Pack(FlatBufferBuilder builder, IPlaneMovementOptimizationConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlaneMovementOptimizationConfig>);
			}
			return IPlaneMovementOptimizationConfig.CreateIPlaneMovementOptimizationConfig(builder, _o.Type);
		}

		// Token: 0x0400EBE3 RID: 60387
		private Table __p;
	}
}
