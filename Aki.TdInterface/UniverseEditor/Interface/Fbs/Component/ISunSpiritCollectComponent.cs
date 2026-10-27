using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059F5 RID: 23029
	public struct ISunSpiritCollectComponent : IFlatbufferObject
	{
		// Token: 0x1700AD03 RID: 44291
		// (get) Token: 0x06027144 RID: 160068 RVA: 0x005605F4 File Offset: 0x0055E7F4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027145 RID: 160069 RVA: 0x00560601 File Offset: 0x0055E801
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027146 RID: 160070 RVA: 0x00560608 File Offset: 0x0055E808
		public static ISunSpiritCollectComponent GetRootAsISunSpiritCollectComponent(ByteBuffer _bb)
		{
			return ISunSpiritCollectComponent.GetRootAsISunSpiritCollectComponent(_bb, default(ISunSpiritCollectComponent));
		}

		// Token: 0x06027147 RID: 160071 RVA: 0x00560624 File Offset: 0x0055E824
		public static ISunSpiritCollectComponent GetRootAsISunSpiritCollectComponent(ByteBuffer _bb, ISunSpiritCollectComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027148 RID: 160072 RVA: 0x00560641 File Offset: 0x0055E841
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027149 RID: 160073 RVA: 0x00560650 File Offset: 0x0055E850
		public ISunSpiritCollectComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AD04 RID: 44292
		// (get) Token: 0x0602714A RID: 160074 RVA: 0x00560660 File Offset: 0x0055E860
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AD05 RID: 44293
		// (get) Token: 0x0602714B RID: 160075 RVA: 0x005606A0 File Offset: 0x0055E8A0
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

		// Token: 0x1700AD06 RID: 44294
		// (get) Token: 0x0602714C RID: 160076 RVA: 0x005606DC File Offset: 0x0055E8DC
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

		// Token: 0x1700AD07 RID: 44295
		// (get) Token: 0x0602714D RID: 160077 RVA: 0x0056071C File Offset: 0x0055E91C
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

		// Token: 0x1700AD08 RID: 44296
		// (get) Token: 0x0602714E RID: 160078 RVA: 0x0056077C File Offset: 0x0055E97C
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

		// Token: 0x0602714F RID: 160079 RVA: 0x005607B9 File Offset: 0x0055E9B9
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

		// Token: 0x06027150 RID: 160080 RVA: 0x005607ED File Offset: 0x0055E9ED
		public static void StartISunSpiritCollectComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06027151 RID: 160081 RVA: 0x005607F6 File Offset: 0x0055E9F6
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06027152 RID: 160082 RVA: 0x00560801 File Offset: 0x0055EA01
		public static void AddAreaId(FlatBufferBuilder builder, int areaId)
		{
			builder.AddInt(1, areaId, 0);
		}

		// Token: 0x06027153 RID: 160083 RVA: 0x0056080C File Offset: 0x0055EA0C
		public static void AddSunSpiritScale(FlatBufferBuilder builder, float sunSpiritScale)
		{
			builder.AddFloat(2, sunSpiritScale, 0.0);
		}

		// Token: 0x06027154 RID: 160084 RVA: 0x0056081F File Offset: 0x0055EA1F
		public static void AddPlayerBattleConfig(FlatBufferBuilder builder, Offset<ISunSpiritPlayerBattleConfig> playerBattleConfigOffset)
		{
			builder.AddOffset(3, playerBattleConfigOffset.Value, 0);
		}

		// Token: 0x06027155 RID: 160085 RVA: 0x0056082F File Offset: 0x0055EA2F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06027156 RID: 160086 RVA: 0x0056083A File Offset: 0x0055EA3A
		public static Offset<ISunSpiritCollectComponent> EndISunSpiritCollectComponent(FlatBufferBuilder builder)
		{
			return new Offset<ISunSpiritCollectComponent>(builder.EndTable());
		}

		// Token: 0x06027157 RID: 160087 RVA: 0x00560848 File Offset: 0x0055EA48
		public ISunSpiritCollectComponentT UnPack()
		{
			ISunSpiritCollectComponentT sunSpiritCollectComponentT = new ISunSpiritCollectComponentT();
			this.UnPackTo(sunSpiritCollectComponentT);
			return sunSpiritCollectComponentT;
		}

		// Token: 0x06027158 RID: 160088 RVA: 0x00560864 File Offset: 0x0055EA64
		public void UnPackTo(ISunSpiritCollectComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.AreaId = this.AreaId;
			_o.SunSpiritScale = this.SunSpiritScale;
			_o.PlayerBattleConfig = ((this.PlayerBattleConfig != null) ? this.PlayerBattleConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06027159 RID: 160089 RVA: 0x005608D0 File Offset: 0x0055EAD0
		public static Offset<ISunSpiritCollectComponent> Pack(FlatBufferBuilder builder, ISunSpiritCollectComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISunSpiritCollectComponent>);
			}
			Offset<ISunSpiritPlayerBattleConfig> playerBattleConfigOffset = (_o.PlayerBattleConfig == null) ? default(Offset<ISunSpiritPlayerBattleConfig>) : ISunSpiritPlayerBattleConfig.Pack(builder, _o.PlayerBattleConfig);
			return ISunSpiritCollectComponent.CreateISunSpiritCollectComponent(builder, _o.Disabled, _o.AreaId, _o.SunSpiritScale, playerBattleConfigOffset, _o.NullMask);
		}

		// Token: 0x0400F030 RID: 61488
		private Table __p;
	}
}
