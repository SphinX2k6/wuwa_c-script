using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F8F RID: 28559
	public struct IHealthBarDisplayClientFunction : IFlatbufferObject
	{
		// Token: 0x1700D123 RID: 53539
		// (get) Token: 0x060316DC RID: 202460 RVA: 0x006B3872 File Offset: 0x006B1A72
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060316DD RID: 202461 RVA: 0x006B387F File Offset: 0x006B1A7F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060316DE RID: 202462 RVA: 0x006B3888 File Offset: 0x006B1A88
		public static IHealthBarDisplayClientFunction GetRootAsIHealthBarDisplayClientFunction(ByteBuffer _bb)
		{
			return IHealthBarDisplayClientFunction.GetRootAsIHealthBarDisplayClientFunction(_bb, default(IHealthBarDisplayClientFunction));
		}

		// Token: 0x060316DF RID: 202463 RVA: 0x006B38A4 File Offset: 0x006B1AA4
		public static IHealthBarDisplayClientFunction GetRootAsIHealthBarDisplayClientFunction(ByteBuffer _bb, IHealthBarDisplayClientFunction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060316E0 RID: 202464 RVA: 0x006B38C1 File Offset: 0x006B1AC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060316E1 RID: 202465 RVA: 0x006B38D0 File Offset: 0x006B1AD0
		public IHealthBarDisplayClientFunction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D124 RID: 53540
		// (get) Token: 0x060316E2 RID: 202466 RVA: 0x006B38E0 File Offset: 0x006B1AE0
		public EEnableClientFunctionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEnableClientFunctionType.HealthBarDisplay;
				}
				return (EEnableClientFunctionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D125 RID: 53541
		// (get) Token: 0x060316E3 RID: 202467 RVA: 0x006B391C File Offset: 0x006B1B1C
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D126 RID: 53542
		// (get) Token: 0x060316E4 RID: 202468 RVA: 0x006B3958 File Offset: 0x006B1B58
		public bool IsVisible
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060316E5 RID: 202469 RVA: 0x006B3997 File Offset: 0x006B1B97
		public static Offset<IHealthBarDisplayClientFunction> CreateIHealthBarDisplayClientFunction(FlatBufferBuilder builder, EEnableClientFunctionType Type = EEnableClientFunctionType.HealthBarDisplay, int EntityId = 0, bool IsVisible = false)
		{
			builder.StartTable(3);
			IHealthBarDisplayClientFunction.AddEntityId(builder, EntityId);
			IHealthBarDisplayClientFunction.AddIsVisible(builder, IsVisible);
			IHealthBarDisplayClientFunction.AddType(builder, Type);
			return IHealthBarDisplayClientFunction.EndIHealthBarDisplayClientFunction(builder);
		}

		// Token: 0x060316E6 RID: 202470 RVA: 0x006B39BB File Offset: 0x006B1BBB
		public static void StartIHealthBarDisplayClientFunction(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060316E7 RID: 202471 RVA: 0x006B39C4 File Offset: 0x006B1BC4
		public static void AddType(FlatBufferBuilder builder, EEnableClientFunctionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060316E8 RID: 202472 RVA: 0x006B39CF File Offset: 0x006B1BCF
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x060316E9 RID: 202473 RVA: 0x006B39DA File Offset: 0x006B1BDA
		public static void AddIsVisible(FlatBufferBuilder builder, bool isVisible)
		{
			builder.AddBool(2, isVisible, false);
		}

		// Token: 0x060316EA RID: 202474 RVA: 0x006B39E5 File Offset: 0x006B1BE5
		public static Offset<IHealthBarDisplayClientFunction> EndIHealthBarDisplayClientFunction(FlatBufferBuilder builder)
		{
			return new Offset<IHealthBarDisplayClientFunction>(builder.EndTable());
		}

		// Token: 0x060316EB RID: 202475 RVA: 0x006B39F4 File Offset: 0x006B1BF4
		public IHealthBarDisplayClientFunctionT UnPack()
		{
			IHealthBarDisplayClientFunctionT healthBarDisplayClientFunctionT = new IHealthBarDisplayClientFunctionT();
			this.UnPackTo(healthBarDisplayClientFunctionT);
			return healthBarDisplayClientFunctionT;
		}

		// Token: 0x060316EC RID: 202476 RVA: 0x006B3A0F File Offset: 0x006B1C0F
		public void UnPackTo(IHealthBarDisplayClientFunctionT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.IsVisible = this.IsVisible;
		}

		// Token: 0x060316ED RID: 202477 RVA: 0x006B3A38 File Offset: 0x006B1C38
		public static Offset<IHealthBarDisplayClientFunction> Pack(FlatBufferBuilder builder, IHealthBarDisplayClientFunctionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHealthBarDisplayClientFunction>);
			}
			return IHealthBarDisplayClientFunction.CreateIHealthBarDisplayClientFunction(builder, _o.Type, _o.EntityId, _o.IsVisible);
		}

		// Token: 0x04011EA7 RID: 73383
		private Table __p;
	}
}
