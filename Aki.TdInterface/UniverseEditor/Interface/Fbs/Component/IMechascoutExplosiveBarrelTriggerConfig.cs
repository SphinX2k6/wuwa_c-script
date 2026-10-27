using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005536 RID: 21814
	public struct IMechascoutExplosiveBarrelTriggerConfig : IFlatbufferObject
	{
		// Token: 0x1700A10E RID: 41230
		// (get) Token: 0x060240A9 RID: 147625 RVA: 0x004FAB80 File Offset: 0x004F8D80
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060240AA RID: 147626 RVA: 0x004FAB8D File Offset: 0x004F8D8D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060240AB RID: 147627 RVA: 0x004FAB94 File Offset: 0x004F8D94
		public static IMechascoutExplosiveBarrelTriggerConfig GetRootAsIMechascoutExplosiveBarrelTriggerConfig(ByteBuffer _bb)
		{
			return IMechascoutExplosiveBarrelTriggerConfig.GetRootAsIMechascoutExplosiveBarrelTriggerConfig(_bb, default(IMechascoutExplosiveBarrelTriggerConfig));
		}

		// Token: 0x060240AC RID: 147628 RVA: 0x004FABB0 File Offset: 0x004F8DB0
		public static IMechascoutExplosiveBarrelTriggerConfig GetRootAsIMechascoutExplosiveBarrelTriggerConfig(ByteBuffer _bb, IMechascoutExplosiveBarrelTriggerConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060240AD RID: 147629 RVA: 0x004FABCD File Offset: 0x004F8DCD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060240AE RID: 147630 RVA: 0x004FABDC File Offset: 0x004F8DDC
		public IMechascoutExplosiveBarrelTriggerConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A10F RID: 41231
		// (get) Token: 0x060240AF RID: 147631 RVA: 0x004FABEC File Offset: 0x004F8DEC
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

		// Token: 0x060240B0 RID: 147632 RVA: 0x004FAC28 File Offset: 0x004F8E28
		public static Offset<IMechascoutExplosiveBarrelTriggerConfig> CreateIMechascoutExplosiveBarrelTriggerConfig(FlatBufferBuilder builder, ETeleCtrlTriggerType Type = ETeleCtrlTriggerType.MechascoutJavelin)
		{
			builder.StartTable(1);
			IMechascoutExplosiveBarrelTriggerConfig.AddType(builder, Type);
			return IMechascoutExplosiveBarrelTriggerConfig.EndIMechascoutExplosiveBarrelTriggerConfig(builder);
		}

		// Token: 0x060240B1 RID: 147633 RVA: 0x004FAC3E File Offset: 0x004F8E3E
		public static void StartIMechascoutExplosiveBarrelTriggerConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060240B2 RID: 147634 RVA: 0x004FAC47 File Offset: 0x004F8E47
		public static void AddType(FlatBufferBuilder builder, ETeleCtrlTriggerType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060240B3 RID: 147635 RVA: 0x004FAC52 File Offset: 0x004F8E52
		public static Offset<IMechascoutExplosiveBarrelTriggerConfig> EndIMechascoutExplosiveBarrelTriggerConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMechascoutExplosiveBarrelTriggerConfig>(builder.EndTable());
		}

		// Token: 0x060240B4 RID: 147636 RVA: 0x004FAC60 File Offset: 0x004F8E60
		public IMechascoutExplosiveBarrelTriggerConfigT UnPack()
		{
			IMechascoutExplosiveBarrelTriggerConfigT mechascoutExplosiveBarrelTriggerConfigT = new IMechascoutExplosiveBarrelTriggerConfigT();
			this.UnPackTo(mechascoutExplosiveBarrelTriggerConfigT);
			return mechascoutExplosiveBarrelTriggerConfigT;
		}

		// Token: 0x060240B5 RID: 147637 RVA: 0x004FAC7B File Offset: 0x004F8E7B
		public void UnPackTo(IMechascoutExplosiveBarrelTriggerConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060240B6 RID: 147638 RVA: 0x004FAC8C File Offset: 0x004F8E8C
		public static Offset<IMechascoutExplosiveBarrelTriggerConfig> Pack(FlatBufferBuilder builder, IMechascoutExplosiveBarrelTriggerConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMechascoutExplosiveBarrelTriggerConfig>);
			}
			return IMechascoutExplosiveBarrelTriggerConfig.CreateIMechascoutExplosiveBarrelTriggerConfig(builder, _o.Type);
		}

		// Token: 0x0400E836 RID: 59446
		private Table __p;
	}
}
