using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005730 RID: 22320
	public struct IPhysHandleConfig : IFlatbufferObject
	{
		// Token: 0x1700A657 RID: 42583
		// (get) Token: 0x060255C2 RID: 153026 RVA: 0x00527B4B File Offset: 0x00525D4B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060255C3 RID: 153027 RVA: 0x00527B58 File Offset: 0x00525D58
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060255C4 RID: 153028 RVA: 0x00527B60 File Offset: 0x00525D60
		public static IPhysHandleConfig GetRootAsIPhysHandleConfig(ByteBuffer _bb)
		{
			return IPhysHandleConfig.GetRootAsIPhysHandleConfig(_bb, default(IPhysHandleConfig));
		}

		// Token: 0x060255C5 RID: 153029 RVA: 0x00527B7C File Offset: 0x00525D7C
		public static IPhysHandleConfig GetRootAsIPhysHandleConfig(ByteBuffer _bb, IPhysHandleConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060255C6 RID: 153030 RVA: 0x00527B99 File Offset: 0x00525D99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060255C7 RID: 153031 RVA: 0x00527BA8 File Offset: 0x00525DA8
		public IPhysHandleConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A658 RID: 42584
		// (get) Token: 0x060255C8 RID: 153032 RVA: 0x00527BB8 File Offset: 0x00525DB8
		public int PhysHandleLinearDamping
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A659 RID: 42585
		// (get) Token: 0x060255C9 RID: 153033 RVA: 0x00527BF4 File Offset: 0x00525DF4
		public int PhysHandleAngularStiffness
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

		// Token: 0x1700A65A RID: 42586
		// (get) Token: 0x060255CA RID: 153034 RVA: 0x00527C30 File Offset: 0x00525E30
		public int PhysHandleLinearStiffness
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A65B RID: 42587
		// (get) Token: 0x060255CB RID: 153035 RVA: 0x00527C6C File Offset: 0x00525E6C
		public int PhysHandleAngularDamping
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060255CC RID: 153036 RVA: 0x00527CA9 File Offset: 0x00525EA9
		public static Offset<IPhysHandleConfig> CreateIPhysHandleConfig(FlatBufferBuilder builder, int PhysHandleLinearDamping = 0, int PhysHandleAngularStiffness = 0, int PhysHandleLinearStiffness = 0, int PhysHandleAngularDamping = 0)
		{
			builder.StartTable(4);
			IPhysHandleConfig.AddPhysHandleAngularDamping(builder, PhysHandleAngularDamping);
			IPhysHandleConfig.AddPhysHandleLinearStiffness(builder, PhysHandleLinearStiffness);
			IPhysHandleConfig.AddPhysHandleAngularStiffness(builder, PhysHandleAngularStiffness);
			IPhysHandleConfig.AddPhysHandleLinearDamping(builder, PhysHandleLinearDamping);
			return IPhysHandleConfig.EndIPhysHandleConfig(builder);
		}

		// Token: 0x060255CD RID: 153037 RVA: 0x00527CD5 File Offset: 0x00525ED5
		public static void StartIPhysHandleConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060255CE RID: 153038 RVA: 0x00527CDE File Offset: 0x00525EDE
		public static void AddPhysHandleLinearDamping(FlatBufferBuilder builder, int physHandleLinearDamping)
		{
			builder.AddInt(0, physHandleLinearDamping, 0);
		}

		// Token: 0x060255CF RID: 153039 RVA: 0x00527CE9 File Offset: 0x00525EE9
		public static void AddPhysHandleAngularStiffness(FlatBufferBuilder builder, int physHandleAngularStiffness)
		{
			builder.AddInt(1, physHandleAngularStiffness, 0);
		}

		// Token: 0x060255D0 RID: 153040 RVA: 0x00527CF4 File Offset: 0x00525EF4
		public static void AddPhysHandleLinearStiffness(FlatBufferBuilder builder, int physHandleLinearStiffness)
		{
			builder.AddInt(2, physHandleLinearStiffness, 0);
		}

		// Token: 0x060255D1 RID: 153041 RVA: 0x00527CFF File Offset: 0x00525EFF
		public static void AddPhysHandleAngularDamping(FlatBufferBuilder builder, int physHandleAngularDamping)
		{
			builder.AddInt(3, physHandleAngularDamping, 0);
		}

		// Token: 0x060255D2 RID: 153042 RVA: 0x00527D0A File Offset: 0x00525F0A
		public static Offset<IPhysHandleConfig> EndIPhysHandleConfig(FlatBufferBuilder builder)
		{
			return new Offset<IPhysHandleConfig>(builder.EndTable());
		}

		// Token: 0x060255D3 RID: 153043 RVA: 0x00527D18 File Offset: 0x00525F18
		public IPhysHandleConfigT UnPack()
		{
			IPhysHandleConfigT physHandleConfigT = new IPhysHandleConfigT();
			this.UnPackTo(physHandleConfigT);
			return physHandleConfigT;
		}

		// Token: 0x060255D4 RID: 153044 RVA: 0x00527D33 File Offset: 0x00525F33
		public void UnPackTo(IPhysHandleConfigT _o)
		{
			_o.PhysHandleLinearDamping = this.PhysHandleLinearDamping;
			_o.PhysHandleAngularStiffness = this.PhysHandleAngularStiffness;
			_o.PhysHandleLinearStiffness = this.PhysHandleLinearStiffness;
			_o.PhysHandleAngularDamping = this.PhysHandleAngularDamping;
		}

		// Token: 0x060255D5 RID: 153045 RVA: 0x00527D68 File Offset: 0x00525F68
		public static Offset<IPhysHandleConfig> Pack(FlatBufferBuilder builder, IPhysHandleConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhysHandleConfig>);
			}
			return IPhysHandleConfig.CreateIPhysHandleConfig(builder, _o.PhysHandleLinearDamping, _o.PhysHandleAngularStiffness, _o.PhysHandleLinearStiffness, _o.PhysHandleAngularDamping);
		}

		// Token: 0x0400EBAE RID: 60334
		private Table __p;
	}
}
