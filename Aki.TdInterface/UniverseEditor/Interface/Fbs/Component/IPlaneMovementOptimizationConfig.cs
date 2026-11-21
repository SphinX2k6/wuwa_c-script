using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D4C RID: 23884
	public struct IPlaneMovementOptimizationConfig : IFlatbufferObject
	{
		// Token: 0x1700AFD5 RID: 45013
		// (get) Token: 0x06027C15 RID: 162837 RVA: 0x00570A54 File Offset: 0x0056EC54
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027C16 RID: 162838 RVA: 0x00570A61 File Offset: 0x0056EC61
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027C17 RID: 162839 RVA: 0x00570A68 File Offset: 0x0056EC68
		public static IPlaneMovementOptimizationConfig GetRootAsIPlaneMovementOptimizationConfig(ByteBuffer _bb)
		{
			return IPlaneMovementOptimizationConfig.GetRootAsIPlaneMovementOptimizationConfig(_bb, default(IPlaneMovementOptimizationConfig));
		}

		// Token: 0x06027C18 RID: 162840 RVA: 0x00570A84 File Offset: 0x0056EC84
		public static IPlaneMovementOptimizationConfig GetRootAsIPlaneMovementOptimizationConfig(ByteBuffer _bb, IPlaneMovementOptimizationConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027C19 RID: 162841 RVA: 0x00570AA1 File Offset: 0x0056ECA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027C1A RID: 162842 RVA: 0x00570AB0 File Offset: 0x0056ECB0
		public IPlaneMovementOptimizationConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AFD6 RID: 45014
		// (get) Token: 0x06027C1B RID: 162843 RVA: 0x00570AC0 File Offset: 0x0056ECC0
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

		// Token: 0x06027C1C RID: 162844 RVA: 0x00570AFC File Offset: 0x0056ECFC
		public static Offset<IPlaneMovementOptimizationConfig> CreateIPlaneMovementOptimizationConfig(FlatBufferBuilder builder, EPerformanceOptimizationType Type = EPerformanceOptimizationType.PlaneMovementOptimization)
		{
			builder.StartTable(1);
			IPlaneMovementOptimizationConfig.AddType(builder, Type);
			return IPlaneMovementOptimizationConfig.EndIPlaneMovementOptimizationConfig(builder);
		}

		// Token: 0x06027C1D RID: 162845 RVA: 0x00570B12 File Offset: 0x0056ED12
		public static void StartIPlaneMovementOptimizationConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06027C1E RID: 162846 RVA: 0x00570B1B File Offset: 0x0056ED1B
		public static void AddType(FlatBufferBuilder builder, EPerformanceOptimizationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027C1F RID: 162847 RVA: 0x00570B26 File Offset: 0x0056ED26
		public static Offset<IPlaneMovementOptimizationConfig> EndIPlaneMovementOptimizationConfig(FlatBufferBuilder builder)
		{
			return new Offset<IPlaneMovementOptimizationConfig>(builder.EndTable());
		}

		// Token: 0x06027C20 RID: 162848 RVA: 0x00570B34 File Offset: 0x0056ED34
		public IPlaneMovementOptimizationConfigT UnPack()
		{
			IPlaneMovementOptimizationConfigT planeMovementOptimizationConfigT = new IPlaneMovementOptimizationConfigT();
			this.UnPackTo(planeMovementOptimizationConfigT);
			return planeMovementOptimizationConfigT;
		}

		// Token: 0x06027C21 RID: 162849 RVA: 0x00570B4F File Offset: 0x0056ED4F
		public void UnPackTo(IPlaneMovementOptimizationConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06027C22 RID: 162850 RVA: 0x00570B60 File Offset: 0x0056ED60
		public static Offset<IPlaneMovementOptimizationConfig> Pack(FlatBufferBuilder builder, IPlaneMovementOptimizationConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlaneMovementOptimizationConfig>);
			}
			return IPlaneMovementOptimizationConfig.CreateIPlaneMovementOptimizationConfig(builder, _o.Type);
		}

		// Token: 0x0400F8CE RID: 63694
		private Table __p;
	}
}
