using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054DB RID: 21723
	public struct ICircuitConnectLayoutBase : IFlatbufferObject
	{
		// Token: 0x17009B32 RID: 39730
		// (get) Token: 0x060224A7 RID: 140455 RVA: 0x004BA2C1 File Offset: 0x004B84C1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060224A8 RID: 140456 RVA: 0x004BA2CE File Offset: 0x004B84CE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060224A9 RID: 140457 RVA: 0x004BA2D8 File Offset: 0x004B84D8
		public static ICircuitConnectLayoutBase GetRootAsICircuitConnectLayoutBase(ByteBuffer _bb)
		{
			return ICircuitConnectLayoutBase.GetRootAsICircuitConnectLayoutBase(_bb, default(ICircuitConnectLayoutBase));
		}

		// Token: 0x060224AA RID: 140458 RVA: 0x004BA2F4 File Offset: 0x004B84F4
		public static ICircuitConnectLayoutBase GetRootAsICircuitConnectLayoutBase(ByteBuffer _bb, ICircuitConnectLayoutBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060224AB RID: 140459 RVA: 0x004BA311 File Offset: 0x004B8511
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060224AC RID: 140460 RVA: 0x004BA320 File Offset: 0x004B8520
		public ICircuitConnectLayoutBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009B33 RID: 39731
		// (get) Token: 0x060224AD RID: 140461 RVA: 0x004BA330 File Offset: 0x004B8530
		public ECircuitConnectElementType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECircuitConnectElementType.Straight;
				}
				return (ECircuitConnectElementType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060224AE RID: 140462 RVA: 0x004BA36C File Offset: 0x004B856C
		public static Offset<ICircuitConnectLayoutBase> CreateICircuitConnectLayoutBase(FlatBufferBuilder builder, ECircuitConnectElementType Type = ECircuitConnectElementType.Straight)
		{
			builder.StartTable(1);
			ICircuitConnectLayoutBase.AddType(builder, Type);
			return ICircuitConnectLayoutBase.EndICircuitConnectLayoutBase(builder);
		}

		// Token: 0x060224AF RID: 140463 RVA: 0x004BA382 File Offset: 0x004B8582
		public static void StartICircuitConnectLayoutBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060224B0 RID: 140464 RVA: 0x004BA38B File Offset: 0x004B858B
		public static void AddType(FlatBufferBuilder builder, ECircuitConnectElementType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060224B1 RID: 140465 RVA: 0x004BA396 File Offset: 0x004B8596
		public static Offset<ICircuitConnectLayoutBase> EndICircuitConnectLayoutBase(FlatBufferBuilder builder)
		{
			return new Offset<ICircuitConnectLayoutBase>(builder.EndTable());
		}

		// Token: 0x060224B2 RID: 140466 RVA: 0x004BA3A4 File Offset: 0x004B85A4
		public ICircuitConnectLayoutBaseT UnPack()
		{
			ICircuitConnectLayoutBaseT circuitConnectLayoutBaseT = new ICircuitConnectLayoutBaseT();
			this.UnPackTo(circuitConnectLayoutBaseT);
			return circuitConnectLayoutBaseT;
		}

		// Token: 0x060224B3 RID: 140467 RVA: 0x004BA3BF File Offset: 0x004B85BF
		public void UnPackTo(ICircuitConnectLayoutBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060224B4 RID: 140468 RVA: 0x004BA3D0 File Offset: 0x004B85D0
		public static Offset<ICircuitConnectLayoutBase> Pack(FlatBufferBuilder builder, ICircuitConnectLayoutBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICircuitConnectLayoutBase>);
			}
			return ICircuitConnectLayoutBase.CreateICircuitConnectLayoutBase(builder, _o.Type);
		}

		// Token: 0x0400EA2F RID: 59951
		private Table __p;
	}
}
