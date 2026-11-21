using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B4C RID: 23372
	public struct IMotorAutoEjectPositionEntityConfig : IFlatbufferObject
	{
		// Token: 0x1700AA83 RID: 43651
		// (get) Token: 0x06026700 RID: 157440 RVA: 0x005435D2 File Offset: 0x005417D2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026701 RID: 157441 RVA: 0x005435DF File Offset: 0x005417DF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026702 RID: 157442 RVA: 0x005435E8 File Offset: 0x005417E8
		public static IMotorAutoEjectPositionEntityConfig GetRootAsIMotorAutoEjectPositionEntityConfig(ByteBuffer _bb)
		{
			return IMotorAutoEjectPositionEntityConfig.GetRootAsIMotorAutoEjectPositionEntityConfig(_bb, default(IMotorAutoEjectPositionEntityConfig));
		}

		// Token: 0x06026703 RID: 157443 RVA: 0x00543604 File Offset: 0x00541804
		public static IMotorAutoEjectPositionEntityConfig GetRootAsIMotorAutoEjectPositionEntityConfig(ByteBuffer _bb, IMotorAutoEjectPositionEntityConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026704 RID: 157444 RVA: 0x00543621 File Offset: 0x00541821
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026705 RID: 157445 RVA: 0x00543630 File Offset: 0x00541830
		public IMotorAutoEjectPositionEntityConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AA84 RID: 43652
		// (get) Token: 0x06026706 RID: 157446 RVA: 0x00543640 File Offset: 0x00541840
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

		// Token: 0x1700AA85 RID: 43653
		// (get) Token: 0x06026707 RID: 157447 RVA: 0x0054367C File Offset: 0x0054187C
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

		// Token: 0x06026708 RID: 157448 RVA: 0x005436B8 File Offset: 0x005418B8
		public static Offset<IMotorAutoEjectPositionEntityConfig> CreateIMotorAutoEjectPositionEntityConfig(FlatBufferBuilder builder, EMotorAutoEjectType Type = EMotorAutoEjectType.NextHook, int EntityId = 0)
		{
			builder.StartTable(2);
			IMotorAutoEjectPositionEntityConfig.AddEntityId(builder, EntityId);
			IMotorAutoEjectPositionEntityConfig.AddType(builder, Type);
			return IMotorAutoEjectPositionEntityConfig.EndIMotorAutoEjectPositionEntityConfig(builder);
		}

		// Token: 0x06026709 RID: 157449 RVA: 0x005436D5 File Offset: 0x005418D5
		public static void StartIMotorAutoEjectPositionEntityConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602670A RID: 157450 RVA: 0x005436DE File Offset: 0x005418DE
		public static void AddType(FlatBufferBuilder builder, EMotorAutoEjectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602670B RID: 157451 RVA: 0x005436E9 File Offset: 0x005418E9
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0602670C RID: 157452 RVA: 0x005436F4 File Offset: 0x005418F4
		public static Offset<IMotorAutoEjectPositionEntityConfig> EndIMotorAutoEjectPositionEntityConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMotorAutoEjectPositionEntityConfig>(builder.EndTable());
		}

		// Token: 0x0602670D RID: 157453 RVA: 0x00543704 File Offset: 0x00541904
		public IMotorAutoEjectPositionEntityConfigT UnPack()
		{
			IMotorAutoEjectPositionEntityConfigT motorAutoEjectPositionEntityConfigT = new IMotorAutoEjectPositionEntityConfigT();
			this.UnPackTo(motorAutoEjectPositionEntityConfigT);
			return motorAutoEjectPositionEntityConfigT;
		}

		// Token: 0x0602670E RID: 157454 RVA: 0x0054371F File Offset: 0x0054191F
		public void UnPackTo(IMotorAutoEjectPositionEntityConfigT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x0602670F RID: 157455 RVA: 0x0054373C File Offset: 0x0054193C
		public static Offset<IMotorAutoEjectPositionEntityConfig> Pack(FlatBufferBuilder builder, IMotorAutoEjectPositionEntityConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorAutoEjectPositionEntityConfig>);
			}
			return IMotorAutoEjectPositionEntityConfig.CreateIMotorAutoEjectPositionEntityConfig(builder, _o.Type, _o.EntityId);
		}

		// Token: 0x0400F545 RID: 62789
		private Table __p;
	}
}
