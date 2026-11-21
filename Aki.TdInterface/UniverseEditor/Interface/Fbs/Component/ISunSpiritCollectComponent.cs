using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006002 RID: 24578
	public struct ISunSpiritCollectComponent : IFlatbufferObject
	{
		// Token: 0x1700B63B RID: 46651
		// (get) Token: 0x060296BC RID: 169660 RVA: 0x005A75B8 File Offset: 0x005A57B8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060296BD RID: 169661 RVA: 0x005A75C5 File Offset: 0x005A57C5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060296BE RID: 169662 RVA: 0x005A75CC File Offset: 0x005A57CC
		public static ISunSpiritCollectComponent GetRootAsISunSpiritCollectComponent(ByteBuffer _bb)
		{
			return ISunSpiritCollectComponent.GetRootAsISunSpiritCollectComponent(_bb, default(ISunSpiritCollectComponent));
		}

		// Token: 0x060296BF RID: 169663 RVA: 0x005A75E8 File Offset: 0x005A57E8
		public static ISunSpiritCollectComponent GetRootAsISunSpiritCollectComponent(ByteBuffer _bb, ISunSpiritCollectComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060296C0 RID: 169664 RVA: 0x005A7605 File Offset: 0x005A5805
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060296C1 RID: 169665 RVA: 0x005A7614 File Offset: 0x005A5814
		public ISunSpiritCollectComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B63C RID: 46652
		// (get) Token: 0x060296C2 RID: 169666 RVA: 0x005A7624 File Offset: 0x005A5824
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B63D RID: 46653
		// (get) Token: 0x060296C3 RID: 169667 RVA: 0x005A7664 File Offset: 0x005A5864
		public int AreaId
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

		// Token: 0x1700B63E RID: 46654
		// (get) Token: 0x060296C4 RID: 169668 RVA: 0x005A76A0 File Offset: 0x005A58A0
		public float SunSpiritScale
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B63F RID: 46655
		// (get) Token: 0x060296C5 RID: 169669 RVA: 0x005A76E0 File Offset: 0x005A58E0
		public ISunSpiritPlayerBattleConfig? PlayerBattleConfig
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new ISunSpiritPlayerBattleConfig?(default(ISunSpiritPlayerBattleConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B640 RID: 46656
		// (get) Token: 0x060296C6 RID: 169670 RVA: 0x005A7740 File Offset: 0x005A5940
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060296C7 RID: 169671 RVA: 0x005A777D File Offset: 0x005A597D
		public static Offset<ISunSpiritCollectComponent> CreateISunSpiritCollectComponent(FlatBufferBuilder builder, bool Disabled = false, int AreaId = 0, float SunSpiritScale = 0f, Offset<ISunSpiritPlayerBattleConfig> PlayerBattleConfigOffset = default(Offset<ISunSpiritPlayerBattleConfig>), byte NullMask = 0)
		{
			builder.StartTable(5);
			ISunSpiritCollectComponent.AddPlayerBattleConfig(builder, PlayerBattleConfigOffset);
			ISunSpiritCollectComponent.AddSunSpiritScale(builder, SunSpiritScale);
			ISunSpiritCollectComponent.AddAreaId(builder, AreaId);
			ISunSpiritCollectComponent.AddNullMask(builder, NullMask);
			ISunSpiritCollectComponent.AddDisabled(builder, Disabled);
			return ISunSpiritCollectComponent.EndISunSpiritCollectComponent(builder);
		}

		// Token: 0x060296C8 RID: 169672 RVA: 0x005A77B1 File Offset: 0x005A59B1
		public static void StartISunSpiritCollectComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060296C9 RID: 169673 RVA: 0x005A77BA File Offset: 0x005A59BA
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060296CA RID: 169674 RVA: 0x005A77C5 File Offset: 0x005A59C5
		public static void AddAreaId(FlatBufferBuilder builder, int areaId)
		{
			builder.AddInt(1, areaId, 0);
		}

		// Token: 0x060296CB RID: 169675 RVA: 0x005A77D0 File Offset: 0x005A59D0
		public static void AddSunSpiritScale(FlatBufferBuilder builder, float sunSpiritScale)
		{
			builder.AddFloat(2, sunSpiritScale, 0.0);
		}

		// Token: 0x060296CC RID: 169676 RVA: 0x005A77E3 File Offset: 0x005A59E3
		public static void AddPlayerBattleConfig(FlatBufferBuilder builder, Offset<ISunSpiritPlayerBattleConfig> playerBattleConfigOffset)
		{
			builder.AddOffset(3, playerBattleConfigOffset.Value, 0);
		}

		// Token: 0x060296CD RID: 169677 RVA: 0x005A77F3 File Offset: 0x005A59F3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060296CE RID: 169678 RVA: 0x005A77FE File Offset: 0x005A59FE
		public static Offset<ISunSpiritCollectComponent> EndISunSpiritCollectComponent(FlatBufferBuilder builder)
		{
			return new Offset<ISunSpiritCollectComponent>(builder.EndTable());
		}

		// Token: 0x060296CF RID: 169679 RVA: 0x005A780C File Offset: 0x005A5A0C
		public ISunSpiritCollectComponentT UnPack()
		{
			ISunSpiritCollectComponentT sunSpiritCollectComponentT = new ISunSpiritCollectComponentT();
			this.UnPackTo(sunSpiritCollectComponentT);
			return sunSpiritCollectComponentT;
		}

		// Token: 0x060296D0 RID: 169680 RVA: 0x005A7828 File Offset: 0x005A5A28
		public void UnPackTo(ISunSpiritCollectComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.AreaId = this.AreaId;
			_o.SunSpiritScale = this.SunSpiritScale;
			_o.PlayerBattleConfig = ((this.PlayerBattleConfig != null) ? this.PlayerBattleConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060296D1 RID: 169681 RVA: 0x005A7894 File Offset: 0x005A5A94
		public static Offset<ISunSpiritCollectComponent> Pack(FlatBufferBuilder builder, ISunSpiritCollectComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISunSpiritCollectComponent>);
			}
			Offset<ISunSpiritPlayerBattleConfig> playerBattleConfigOffset = (_o.PlayerBattleConfig == null) ? default(Offset<ISunSpiritPlayerBattleConfig>) : ISunSpiritPlayerBattleConfig.Pack(builder, _o.PlayerBattleConfig);
			return ISunSpiritCollectComponent.CreateISunSpiritCollectComponent(builder, _o.Disabled, _o.AreaId, _o.SunSpiritScale, playerBattleConfigOffset, _o.NullMask);
		}

		// Token: 0x0400FD27 RID: 64807
		private Table __p;
	}
}
