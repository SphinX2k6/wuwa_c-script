using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005539 RID: 21817
	public struct IMechascoutJavelinTriggerConfig : IFlatbufferObject
	{
		// Token: 0x1700A111 RID: 41233
		// (get) Token: 0x060240BB RID: 147643 RVA: 0x004FACF5 File Offset: 0x004F8EF5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060240BC RID: 147644 RVA: 0x004FAD02 File Offset: 0x004F8F02
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060240BD RID: 147645 RVA: 0x004FAD0C File Offset: 0x004F8F0C
		public static IMechascoutJavelinTriggerConfig GetRootAsIMechascoutJavelinTriggerConfig(ByteBuffer _bb)
		{
			return IMechascoutJavelinTriggerConfig.GetRootAsIMechascoutJavelinTriggerConfig(_bb, default(IMechascoutJavelinTriggerConfig));
		}

		// Token: 0x060240BE RID: 147646 RVA: 0x004FAD28 File Offset: 0x004F8F28
		public static IMechascoutJavelinTriggerConfig GetRootAsIMechascoutJavelinTriggerConfig(ByteBuffer _bb, IMechascoutJavelinTriggerConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060240BF RID: 147647 RVA: 0x004FAD45 File Offset: 0x004F8F45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060240C0 RID: 147648 RVA: 0x004FAD54 File Offset: 0x004F8F54
		public IMechascoutJavelinTriggerConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A112 RID: 41234
		// (get) Token: 0x060240C1 RID: 147649 RVA: 0x004FAD64 File Offset: 0x004F8F64
		public ETeleCtrlTriggerType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETeleCtrlTriggerType.MechascoutJavelin;
				}
				return (ETeleCtrlTriggerType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060240C2 RID: 147650 RVA: 0x004FADA0 File Offset: 0x004F8FA0
		public static Offset<IMechascoutJavelinTriggerConfig> CreateIMechascoutJavelinTriggerConfig(FlatBufferBuilder builder, ETeleCtrlTriggerType Type = ETeleCtrlTriggerType.MechascoutJavelin)
		{
			builder.StartTable(1);
			IMechascoutJavelinTriggerConfig.AddType(builder, Type);
			return IMechascoutJavelinTriggerConfig.EndIMechascoutJavelinTriggerConfig(builder);
		}

		// Token: 0x060240C3 RID: 147651 RVA: 0x004FADB6 File Offset: 0x004F8FB6
		public static void StartIMechascoutJavelinTriggerConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060240C4 RID: 147652 RVA: 0x004FADBF File Offset: 0x004F8FBF
		public static void AddType(FlatBufferBuilder builder, ETeleCtrlTriggerType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060240C5 RID: 147653 RVA: 0x004FADCA File Offset: 0x004F8FCA
		public static Offset<IMechascoutJavelinTriggerConfig> EndIMechascoutJavelinTriggerConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMechascoutJavelinTriggerConfig>(builder.EndTable());
		}

		// Token: 0x060240C6 RID: 147654 RVA: 0x004FADD8 File Offset: 0x004F8FD8
		public IMechascoutJavelinTriggerConfigT UnPack()
		{
			IMechascoutJavelinTriggerConfigT mechascoutJavelinTriggerConfigT = new IMechascoutJavelinTriggerConfigT();
			this.UnPackTo(mechascoutJavelinTriggerConfigT);
			return mechascoutJavelinTriggerConfigT;
		}

		// Token: 0x060240C7 RID: 147655 RVA: 0x004FADF3 File Offset: 0x004F8FF3
		public void UnPackTo(IMechascoutJavelinTriggerConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060240C8 RID: 147656 RVA: 0x004FAE04 File Offset: 0x004F9004
		public static Offset<IMechascoutJavelinTriggerConfig> Pack(FlatBufferBuilder builder, IMechascoutJavelinTriggerConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMechascoutJavelinTriggerConfig>);
			}
			return IMechascoutJavelinTriggerConfig.CreateIMechascoutJavelinTriggerConfig(builder, _o.Type);
		}

		// Token: 0x0400E838 RID: 59448
		private Table __p;
	}
}
