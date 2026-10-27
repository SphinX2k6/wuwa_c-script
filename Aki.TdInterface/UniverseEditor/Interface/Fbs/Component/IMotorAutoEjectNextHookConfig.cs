using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055AB RID: 21931
	public struct IMotorAutoEjectNextHookConfig : IFlatbufferObject
	{
		// Token: 0x1700A1F6 RID: 41462
		// (get) Token: 0x060244DD RID: 148701 RVA: 0x00502E5C File Offset: 0x0050105C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060244DE RID: 148702 RVA: 0x00502E69 File Offset: 0x00501069
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060244DF RID: 148703 RVA: 0x00502E70 File Offset: 0x00501070
		public static IMotorAutoEjectNextHookConfig GetRootAsIMotorAutoEjectNextHookConfig(ByteBuffer _bb)
		{
			return IMotorAutoEjectNextHookConfig.GetRootAsIMotorAutoEjectNextHookConfig(_bb, default(IMotorAutoEjectNextHookConfig));
		}

		// Token: 0x060244E0 RID: 148704 RVA: 0x00502E8C File Offset: 0x0050108C
		public static IMotorAutoEjectNextHookConfig GetRootAsIMotorAutoEjectNextHookConfig(ByteBuffer _bb, IMotorAutoEjectNextHookConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060244E1 RID: 148705 RVA: 0x00502EA9 File Offset: 0x005010A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060244E2 RID: 148706 RVA: 0x00502EB8 File Offset: 0x005010B8
		public IMotorAutoEjectNextHookConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A1F7 RID: 41463
		// (get) Token: 0x060244E3 RID: 148707 RVA: 0x00502EC8 File Offset: 0x005010C8
		public EMotorAutoEjectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMotorAutoEjectType.NextHook;
				}
				return (EMotorAutoEjectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A1F8 RID: 41464
		// (get) Token: 0x060244E4 RID: 148708 RVA: 0x00502F04 File Offset: 0x00501104
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

		// Token: 0x060244E5 RID: 148709 RVA: 0x00502F40 File Offset: 0x00501140
		public static Offset<IMotorAutoEjectNextHookConfig> CreateIMotorAutoEjectNextHookConfig(FlatBufferBuilder builder, EMotorAutoEjectType Type = EMotorAutoEjectType.NextHook, int EntityId = 0)
		{
			builder.StartTable(2);
			IMotorAutoEjectNextHookConfig.AddEntityId(builder, EntityId);
			IMotorAutoEjectNextHookConfig.AddType(builder, Type);
			return IMotorAutoEjectNextHookConfig.EndIMotorAutoEjectNextHookConfig(builder);
		}

		// Token: 0x060244E6 RID: 148710 RVA: 0x00502F5D File Offset: 0x0050115D
		public static void StartIMotorAutoEjectNextHookConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060244E7 RID: 148711 RVA: 0x00502F66 File Offset: 0x00501166
		public static void AddType(FlatBufferBuilder builder, EMotorAutoEjectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060244E8 RID: 148712 RVA: 0x00502F71 File Offset: 0x00501171
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x060244E9 RID: 148713 RVA: 0x00502F7C File Offset: 0x0050117C
		public static Offset<IMotorAutoEjectNextHookConfig> EndIMotorAutoEjectNextHookConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMotorAutoEjectNextHookConfig>(builder.EndTable());
		}

		// Token: 0x060244EA RID: 148714 RVA: 0x00502F8C File Offset: 0x0050118C
		public IMotorAutoEjectNextHookConfigT UnPack()
		{
			IMotorAutoEjectNextHookConfigT motorAutoEjectNextHookConfigT = new IMotorAutoEjectNextHookConfigT();
			this.UnPackTo(motorAutoEjectNextHookConfigT);
			return motorAutoEjectNextHookConfigT;
		}

		// Token: 0x060244EB RID: 148715 RVA: 0x00502FA7 File Offset: 0x005011A7
		public void UnPackTo(IMotorAutoEjectNextHookConfigT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x060244EC RID: 148716 RVA: 0x00502FC4 File Offset: 0x005011C4
		public static Offset<IMotorAutoEjectNextHookConfig> Pack(FlatBufferBuilder builder, IMotorAutoEjectNextHookConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorAutoEjectNextHookConfig>);
			}
			return IMotorAutoEjectNextHookConfig.CreateIMotorAutoEjectNextHookConfig(builder, _o.Type, _o.EntityId);
		}

		// Token: 0x0400E8E0 RID: 59616
		private Table __p;
	}
}
