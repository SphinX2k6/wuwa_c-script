using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068DF RID: 26847
	public struct IHealthBarDisplayClientFunction : IFlatbufferObject
	{
		// Token: 0x1700C729 RID: 50985
		// (get) Token: 0x0602ED2A RID: 191786 RVA: 0x0066372A File Offset: 0x0066192A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602ED2B RID: 191787 RVA: 0x00663737 File Offset: 0x00661937
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602ED2C RID: 191788 RVA: 0x00663740 File Offset: 0x00661940
		public static IHealthBarDisplayClientFunction GetRootAsIHealthBarDisplayClientFunction(ByteBuffer _bb)
		{
			return IHealthBarDisplayClientFunction.GetRootAsIHealthBarDisplayClientFunction(_bb, default(IHealthBarDisplayClientFunction));
		}

		// Token: 0x0602ED2D RID: 191789 RVA: 0x0066375C File Offset: 0x0066195C
		public static IHealthBarDisplayClientFunction GetRootAsIHealthBarDisplayClientFunction(ByteBuffer _bb, IHealthBarDisplayClientFunction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602ED2E RID: 191790 RVA: 0x00663779 File Offset: 0x00661979
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602ED2F RID: 191791 RVA: 0x00663788 File Offset: 0x00661988
		public IHealthBarDisplayClientFunction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C72A RID: 50986
		// (get) Token: 0x0602ED30 RID: 191792 RVA: 0x00663798 File Offset: 0x00661998
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

		// Token: 0x1700C72B RID: 50987
		// (get) Token: 0x0602ED31 RID: 191793 RVA: 0x006637D4 File Offset: 0x006619D4
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

		// Token: 0x1700C72C RID: 50988
		// (get) Token: 0x0602ED32 RID: 191794 RVA: 0x00663810 File Offset: 0x00661A10
		public bool IsVisible
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602ED33 RID: 191795 RVA: 0x0066384F File Offset: 0x00661A4F
		public static Offset<IHealthBarDisplayClientFunction> CreateIHealthBarDisplayClientFunction(FlatBufferBuilder builder, EEnableClientFunctionType Type = EEnableClientFunctionType.HealthBarDisplay, int EntityId = 0, bool IsVisible = false)
		{
			builder.StartTable(3);
			IHealthBarDisplayClientFunction.AddEntityId(builder, EntityId);
			IHealthBarDisplayClientFunction.AddIsVisible(builder, IsVisible);
			IHealthBarDisplayClientFunction.AddType(builder, Type);
			return IHealthBarDisplayClientFunction.EndIHealthBarDisplayClientFunction(builder);
		}

		// Token: 0x0602ED34 RID: 191796 RVA: 0x00663873 File Offset: 0x00661A73
		public static void StartIHealthBarDisplayClientFunction(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602ED35 RID: 191797 RVA: 0x0066387C File Offset: 0x00661A7C
		public static void AddType(FlatBufferBuilder builder, EEnableClientFunctionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602ED36 RID: 191798 RVA: 0x00663887 File Offset: 0x00661A87
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0602ED37 RID: 191799 RVA: 0x00663892 File Offset: 0x00661A92
		public static void AddIsVisible(FlatBufferBuilder builder, bool isVisible)
		{
			builder.AddBool(2, isVisible, false);
		}

		// Token: 0x0602ED38 RID: 191800 RVA: 0x0066389D File Offset: 0x00661A9D
		public static Offset<IHealthBarDisplayClientFunction> EndIHealthBarDisplayClientFunction(FlatBufferBuilder builder)
		{
			return new Offset<IHealthBarDisplayClientFunction>(builder.EndTable());
		}

		// Token: 0x0602ED39 RID: 191801 RVA: 0x006638AC File Offset: 0x00661AAC
		public IHealthBarDisplayClientFunctionT UnPack()
		{
			IHealthBarDisplayClientFunctionT healthBarDisplayClientFunctionT = new IHealthBarDisplayClientFunctionT();
			this.UnPackTo(healthBarDisplayClientFunctionT);
			return healthBarDisplayClientFunctionT;
		}

		// Token: 0x0602ED3A RID: 191802 RVA: 0x006638C7 File Offset: 0x00661AC7
		public void UnPackTo(IHealthBarDisplayClientFunctionT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.IsVisible = this.IsVisible;
		}

		// Token: 0x0602ED3B RID: 191803 RVA: 0x006638F0 File Offset: 0x00661AF0
		public static Offset<IHealthBarDisplayClientFunction> Pack(FlatBufferBuilder builder, IHealthBarDisplayClientFunctionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHealthBarDisplayClientFunction>);
			}
			return IHealthBarDisplayClientFunction.CreateIHealthBarDisplayClientFunction(builder, _o.Type, _o.EntityId, _o.IsVisible);
		}

		// Token: 0x04011040 RID: 69696
		private Table __p;
	}
}
