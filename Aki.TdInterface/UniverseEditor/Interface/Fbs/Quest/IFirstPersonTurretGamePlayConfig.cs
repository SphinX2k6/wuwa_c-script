using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200428F RID: 17039
	public struct IFirstPersonTurretGamePlayConfig : IFlatbufferObject
	{
		// Token: 0x1700748C RID: 29836
		// (get) Token: 0x06017D76 RID: 97654 RVA: 0x00367F38 File Offset: 0x00366138
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017D77 RID: 97655 RVA: 0x00367F45 File Offset: 0x00366145
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017D78 RID: 97656 RVA: 0x00367F4C File Offset: 0x0036614C
		public static IFirstPersonTurretGamePlayConfig GetRootAsIFirstPersonTurretGamePlayConfig(ByteBuffer _bb)
		{
			return IFirstPersonTurretGamePlayConfig.GetRootAsIFirstPersonTurretGamePlayConfig(_bb, default(IFirstPersonTurretGamePlayConfig));
		}

		// Token: 0x06017D79 RID: 97657 RVA: 0x00367F68 File Offset: 0x00366168
		public static IFirstPersonTurretGamePlayConfig GetRootAsIFirstPersonTurretGamePlayConfig(ByteBuffer _bb, IFirstPersonTurretGamePlayConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017D7A RID: 97658 RVA: 0x00367F85 File Offset: 0x00366185
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017D7B RID: 97659 RVA: 0x00367F94 File Offset: 0x00366194
		public IFirstPersonTurretGamePlayConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700748D RID: 29837
		// (get) Token: 0x06017D7C RID: 97660 RVA: 0x00367FA4 File Offset: 0x003661A4
		public ESpecialGamePlayConfigType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESpecialGamePlayConfigType.Stalking;
				}
				return (ESpecialGamePlayConfigType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017D7D RID: 97661 RVA: 0x00367FE0 File Offset: 0x003661E0
		public static Offset<IFirstPersonTurretGamePlayConfig> CreateIFirstPersonTurretGamePlayConfig(FlatBufferBuilder builder, ESpecialGamePlayConfigType Type = ESpecialGamePlayConfigType.Stalking)
		{
			builder.StartTable(1);
			IFirstPersonTurretGamePlayConfig.AddType(builder, Type);
			return IFirstPersonTurretGamePlayConfig.EndIFirstPersonTurretGamePlayConfig(builder);
		}

		// Token: 0x06017D7E RID: 97662 RVA: 0x00367FF6 File Offset: 0x003661F6
		public static void StartIFirstPersonTurretGamePlayConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06017D7F RID: 97663 RVA: 0x00367FFF File Offset: 0x003661FF
		public static void AddType(FlatBufferBuilder builder, ESpecialGamePlayConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017D80 RID: 97664 RVA: 0x0036800A File Offset: 0x0036620A
		public static Offset<IFirstPersonTurretGamePlayConfig> EndIFirstPersonTurretGamePlayConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFirstPersonTurretGamePlayConfig>(builder.EndTable());
		}

		// Token: 0x06017D81 RID: 97665 RVA: 0x00368018 File Offset: 0x00366218
		public IFirstPersonTurretGamePlayConfigT UnPack()
		{
			IFirstPersonTurretGamePlayConfigT firstPersonTurretGamePlayConfigT = new IFirstPersonTurretGamePlayConfigT();
			this.UnPackTo(firstPersonTurretGamePlayConfigT);
			return firstPersonTurretGamePlayConfigT;
		}

		// Token: 0x06017D82 RID: 97666 RVA: 0x00368033 File Offset: 0x00366233
		public void UnPackTo(IFirstPersonTurretGamePlayConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06017D83 RID: 97667 RVA: 0x00368044 File Offset: 0x00366244
		public static Offset<IFirstPersonTurretGamePlayConfig> Pack(FlatBufferBuilder builder, IFirstPersonTurretGamePlayConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFirstPersonTurretGamePlayConfig>);
			}
			return IFirstPersonTurretGamePlayConfig.CreateIFirstPersonTurretGamePlayConfig(builder, _o.Type);
		}

		// Token: 0x0400C1DC RID: 49628
		private Table __p;
	}
}
