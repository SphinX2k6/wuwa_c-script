using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D37 RID: 23863
	public struct IPhysHandleConfig : IFlatbufferObject
	{
		// Token: 0x1700AF7B RID: 44923
		// (get) Token: 0x06027AE2 RID: 162530 RVA: 0x0056DCD7 File Offset: 0x0056BED7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027AE3 RID: 162531 RVA: 0x0056DCE4 File Offset: 0x0056BEE4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027AE4 RID: 162532 RVA: 0x0056DCEC File Offset: 0x0056BEEC
		public static IPhysHandleConfig GetRootAsIPhysHandleConfig(ByteBuffer _bb)
		{
			return IPhysHandleConfig.GetRootAsIPhysHandleConfig(_bb, default(IPhysHandleConfig));
		}

		// Token: 0x06027AE5 RID: 162533 RVA: 0x0056DD08 File Offset: 0x0056BF08
		public static IPhysHandleConfig GetRootAsIPhysHandleConfig(ByteBuffer _bb, IPhysHandleConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027AE6 RID: 162534 RVA: 0x0056DD25 File Offset: 0x0056BF25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027AE7 RID: 162535 RVA: 0x0056DD34 File Offset: 0x0056BF34
		public IPhysHandleConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AF7C RID: 44924
		// (get) Token: 0x06027AE8 RID: 162536 RVA: 0x0056DD44 File Offset: 0x0056BF44
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

		// Token: 0x1700AF7D RID: 44925
		// (get) Token: 0x06027AE9 RID: 162537 RVA: 0x0056DD80 File Offset: 0x0056BF80
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

		// Token: 0x1700AF7E RID: 44926
		// (get) Token: 0x06027AEA RID: 162538 RVA: 0x0056DDBC File Offset: 0x0056BFBC
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

		// Token: 0x1700AF7F RID: 44927
		// (get) Token: 0x06027AEB RID: 162539 RVA: 0x0056DDF8 File Offset: 0x0056BFF8
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

		// Token: 0x06027AEC RID: 162540 RVA: 0x0056DE35 File Offset: 0x0056C035
		public static Offset<IPhysHandleConfig> CreateIPhysHandleConfig(FlatBufferBuilder builder, int PhysHandleLinearDamping = 0, int PhysHandleAngularStiffness = 0, int PhysHandleLinearStiffness = 0, int PhysHandleAngularDamping = 0)
		{
			builder.StartTable(4);
			IPhysHandleConfig.AddPhysHandleAngularDamping(builder, PhysHandleAngularDamping);
			IPhysHandleConfig.AddPhysHandleLinearStiffness(builder, PhysHandleLinearStiffness);
			IPhysHandleConfig.AddPhysHandleAngularStiffness(builder, PhysHandleAngularStiffness);
			IPhysHandleConfig.AddPhysHandleLinearDamping(builder, PhysHandleLinearDamping);
			return IPhysHandleConfig.EndIPhysHandleConfig(builder);
		}

		// Token: 0x06027AED RID: 162541 RVA: 0x0056DE61 File Offset: 0x0056C061
		public static void StartIPhysHandleConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06027AEE RID: 162542 RVA: 0x0056DE6A File Offset: 0x0056C06A
		public static void AddPhysHandleLinearDamping(FlatBufferBuilder builder, int physHandleLinearDamping)
		{
			builder.AddInt(0, physHandleLinearDamping, 0);
		}

		// Token: 0x06027AEF RID: 162543 RVA: 0x0056DE75 File Offset: 0x0056C075
		public static void AddPhysHandleAngularStiffness(FlatBufferBuilder builder, int physHandleAngularStiffness)
		{
			builder.AddInt(1, physHandleAngularStiffness, 0);
		}

		// Token: 0x06027AF0 RID: 162544 RVA: 0x0056DE80 File Offset: 0x0056C080
		public static void AddPhysHandleLinearStiffness(FlatBufferBuilder builder, int physHandleLinearStiffness)
		{
			builder.AddInt(2, physHandleLinearStiffness, 0);
		}

		// Token: 0x06027AF1 RID: 162545 RVA: 0x0056DE8B File Offset: 0x0056C08B
		public static void AddPhysHandleAngularDamping(FlatBufferBuilder builder, int physHandleAngularDamping)
		{
			builder.AddInt(3, physHandleAngularDamping, 0);
		}

		// Token: 0x06027AF2 RID: 162546 RVA: 0x0056DE96 File Offset: 0x0056C096
		public static Offset<IPhysHandleConfig> EndIPhysHandleConfig(FlatBufferBuilder builder)
		{
			return new Offset<IPhysHandleConfig>(builder.EndTable());
		}

		// Token: 0x06027AF3 RID: 162547 RVA: 0x0056DEA4 File Offset: 0x0056C0A4
		public IPhysHandleConfigT UnPack()
		{
			IPhysHandleConfigT physHandleConfigT = new IPhysHandleConfigT();
			this.UnPackTo(physHandleConfigT);
			return physHandleConfigT;
		}

		// Token: 0x06027AF4 RID: 162548 RVA: 0x0056DEBF File Offset: 0x0056C0BF
		public void UnPackTo(IPhysHandleConfigT _o)
		{
			_o.PhysHandleLinearDamping = this.PhysHandleLinearDamping;
			_o.PhysHandleAngularStiffness = this.PhysHandleAngularStiffness;
			_o.PhysHandleLinearStiffness = this.PhysHandleLinearStiffness;
			_o.PhysHandleAngularDamping = this.PhysHandleAngularDamping;
		}

		// Token: 0x06027AF5 RID: 162549 RVA: 0x0056DEF4 File Offset: 0x0056C0F4
		public static Offset<IPhysHandleConfig> Pack(FlatBufferBuilder builder, IPhysHandleConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhysHandleConfig>);
			}
			return IPhysHandleConfig.CreateIPhysHandleConfig(builder, _o.PhysHandleLinearDamping, _o.PhysHandleAngularStiffness, _o.PhysHandleLinearStiffness, _o.PhysHandleAngularDamping);
		}

		// Token: 0x0400F899 RID: 63641
		private Table __p;
	}
}
