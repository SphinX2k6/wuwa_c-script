using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054E7 RID: 21735
	public struct ICircuitConnectModeBase : IFlatbufferObject
	{
		// Token: 0x17009B47 RID: 39751
		// (get) Token: 0x0602251B RID: 140571 RVA: 0x004BB233 File Offset: 0x004B9433
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602251C RID: 140572 RVA: 0x004BB240 File Offset: 0x004B9440
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602251D RID: 140573 RVA: 0x004BB248 File Offset: 0x004B9448
		public static ICircuitConnectModeBase GetRootAsICircuitConnectModeBase(ByteBuffer _bb)
		{
			return ICircuitConnectModeBase.GetRootAsICircuitConnectModeBase(_bb, default(ICircuitConnectModeBase));
		}

		// Token: 0x0602251E RID: 140574 RVA: 0x004BB264 File Offset: 0x004B9464
		public static ICircuitConnectModeBase GetRootAsICircuitConnectModeBase(ByteBuffer _bb, ICircuitConnectModeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602251F RID: 140575 RVA: 0x004BB281 File Offset: 0x004B9481
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022520 RID: 140576 RVA: 0x004BB290 File Offset: 0x004B9490
		public ICircuitConnectModeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009B48 RID: 39752
		// (get) Token: 0x06022521 RID: 140577 RVA: 0x004BB2A0 File Offset: 0x004B94A0
		public ECircuitConnectMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECircuitConnectMode.TwoRings;
				}
				return (ECircuitConnectMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022522 RID: 140578 RVA: 0x004BB2DC File Offset: 0x004B94DC
		public static Offset<ICircuitConnectModeBase> CreateICircuitConnectModeBase(FlatBufferBuilder builder, ECircuitConnectMode Type = ECircuitConnectMode.TwoRings)
		{
			builder.StartTable(1);
			ICircuitConnectModeBase.AddType(builder, Type);
			return ICircuitConnectModeBase.EndICircuitConnectModeBase(builder);
		}

		// Token: 0x06022523 RID: 140579 RVA: 0x004BB2F2 File Offset: 0x004B94F2
		public static void StartICircuitConnectModeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06022524 RID: 140580 RVA: 0x004BB2FB File Offset: 0x004B94FB
		public static void AddType(FlatBufferBuilder builder, ECircuitConnectMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022525 RID: 140581 RVA: 0x004BB306 File Offset: 0x004B9506
		public static Offset<ICircuitConnectModeBase> EndICircuitConnectModeBase(FlatBufferBuilder builder)
		{
			return new Offset<ICircuitConnectModeBase>(builder.EndTable());
		}

		// Token: 0x06022526 RID: 140582 RVA: 0x004BB314 File Offset: 0x004B9514
		public ICircuitConnectModeBaseT UnPack()
		{
			ICircuitConnectModeBaseT circuitConnectModeBaseT = new ICircuitConnectModeBaseT();
			this.UnPackTo(circuitConnectModeBaseT);
			return circuitConnectModeBaseT;
		}

		// Token: 0x06022527 RID: 140583 RVA: 0x004BB32F File Offset: 0x004B952F
		public void UnPackTo(ICircuitConnectModeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06022528 RID: 140584 RVA: 0x004BB340 File Offset: 0x004B9540
		public static Offset<ICircuitConnectModeBase> Pack(FlatBufferBuilder builder, ICircuitConnectModeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICircuitConnectModeBase>);
			}
			return ICircuitConnectModeBase.CreateICircuitConnectModeBase(builder, _o.Type);
		}

		// Token: 0x0400EA43 RID: 59971
		private Table __p;
	}
}
