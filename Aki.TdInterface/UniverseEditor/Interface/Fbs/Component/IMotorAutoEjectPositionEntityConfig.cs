using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055AE RID: 21934
	public struct IMotorAutoEjectPositionEntityConfig : IFlatbufferObject
	{
		// Token: 0x1700A1FB RID: 41467
		// (get) Token: 0x060244F3 RID: 148723 RVA: 0x0050305A File Offset: 0x0050125A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060244F4 RID: 148724 RVA: 0x00503067 File Offset: 0x00501267
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060244F5 RID: 148725 RVA: 0x00503070 File Offset: 0x00501270
		public static IMotorAutoEjectPositionEntityConfig GetRootAsIMotorAutoEjectPositionEntityConfig(ByteBuffer _bb)
		{
			return IMotorAutoEjectPositionEntityConfig.GetRootAsIMotorAutoEjectPositionEntityConfig(_bb, default(IMotorAutoEjectPositionEntityConfig));
		}

		// Token: 0x060244F6 RID: 148726 RVA: 0x0050308C File Offset: 0x0050128C
		public static IMotorAutoEjectPositionEntityConfig GetRootAsIMotorAutoEjectPositionEntityConfig(ByteBuffer _bb, IMotorAutoEjectPositionEntityConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060244F7 RID: 148727 RVA: 0x005030A9 File Offset: 0x005012A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060244F8 RID: 148728 RVA: 0x005030B8 File Offset: 0x005012B8
		public IMotorAutoEjectPositionEntityConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A1FC RID: 41468
		// (get) Token: 0x060244F9 RID: 148729 RVA: 0x005030C8 File Offset: 0x005012C8
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

		// Token: 0x1700A1FD RID: 41469
		// (get) Token: 0x060244FA RID: 148730 RVA: 0x00503104 File Offset: 0x00501304
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

		// Token: 0x060244FB RID: 148731 RVA: 0x00503140 File Offset: 0x00501340
		public static Offset<IMotorAutoEjectPositionEntityConfig> CreateIMotorAutoEjectPositionEntityConfig(FlatBufferBuilder builder, EMotorAutoEjectType Type = EMotorAutoEjectType.NextHook, int EntityId = 0)
		{
			builder.StartTable(2);
			IMotorAutoEjectPositionEntityConfig.AddEntityId(builder, EntityId);
			IMotorAutoEjectPositionEntityConfig.AddType(builder, Type);
			return IMotorAutoEjectPositionEntityConfig.EndIMotorAutoEjectPositionEntityConfig(builder);
		}

		// Token: 0x060244FC RID: 148732 RVA: 0x0050315D File Offset: 0x0050135D
		public static void StartIMotorAutoEjectPositionEntityConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060244FD RID: 148733 RVA: 0x00503166 File Offset: 0x00501366
		public static void AddType(FlatBufferBuilder builder, EMotorAutoEjectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060244FE RID: 148734 RVA: 0x00503171 File Offset: 0x00501371
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x060244FF RID: 148735 RVA: 0x0050317C File Offset: 0x0050137C
		public static Offset<IMotorAutoEjectPositionEntityConfig> EndIMotorAutoEjectPositionEntityConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMotorAutoEjectPositionEntityConfig>(builder.EndTable());
		}

		// Token: 0x06024500 RID: 148736 RVA: 0x0050318C File Offset: 0x0050138C
		public IMotorAutoEjectPositionEntityConfigT UnPack()
		{
			IMotorAutoEjectPositionEntityConfigT motorAutoEjectPositionEntityConfigT = new IMotorAutoEjectPositionEntityConfigT();
			this.UnPackTo(motorAutoEjectPositionEntityConfigT);
			return motorAutoEjectPositionEntityConfigT;
		}

		// Token: 0x06024501 RID: 148737 RVA: 0x005031A7 File Offset: 0x005013A7
		public void UnPackTo(IMotorAutoEjectPositionEntityConfigT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x06024502 RID: 148738 RVA: 0x005031C4 File Offset: 0x005013C4
		public static Offset<IMotorAutoEjectPositionEntityConfig> Pack(FlatBufferBuilder builder, IMotorAutoEjectPositionEntityConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorAutoEjectPositionEntityConfig>);
			}
			return IMotorAutoEjectPositionEntityConfig.CreateIMotorAutoEjectPositionEntityConfig(builder, _o.Type, _o.EntityId);
		}

		// Token: 0x0400E8E3 RID: 59619
		private Table __p;
	}
}
