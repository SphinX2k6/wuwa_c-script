using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006166 RID: 24934
	public struct IWaterElementalMatch : IFlatbufferObject
	{
		// Token: 0x1700B9D0 RID: 47568
		// (get) Token: 0x0602A56F RID: 173423 RVA: 0x005C6EB9 File Offset: 0x005C50B9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A570 RID: 173424 RVA: 0x005C6EC6 File Offset: 0x005C50C6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A571 RID: 173425 RVA: 0x005C6ED0 File Offset: 0x005C50D0
		public static IWaterElementalMatch GetRootAsIWaterElementalMatch(ByteBuffer _bb)
		{
			return IWaterElementalMatch.GetRootAsIWaterElementalMatch(_bb, default(IWaterElementalMatch));
		}

		// Token: 0x0602A572 RID: 173426 RVA: 0x005C6EEC File Offset: 0x005C50EC
		public static IWaterElementalMatch GetRootAsIWaterElementalMatch(ByteBuffer _bb, IWaterElementalMatch obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A573 RID: 173427 RVA: 0x005C6F09 File Offset: 0x005C5109
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A574 RID: 173428 RVA: 0x005C6F18 File Offset: 0x005C5118
		public IWaterElementalMatch __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B9D1 RID: 47569
		// (get) Token: 0x0602A575 RID: 173429 RVA: 0x005C6F28 File Offset: 0x005C5128
		public EElementalType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EElementalType.Fire;
				}
				return (EElementalType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B9D2 RID: 47570
		// (get) Token: 0x0602A576 RID: 173430 RVA: 0x005C6F64 File Offset: 0x005C5164
		public bool CanStagnate
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B9D3 RID: 47571
		// (get) Token: 0x0602A577 RID: 173431 RVA: 0x005C6FA4 File Offset: 0x005C51A4
		public IWaterStagnationActorConfig? StagnationActorConfig
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IWaterStagnationActorConfig?(default(IWaterStagnationActorConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B9D4 RID: 47572
		// (get) Token: 0x0602A578 RID: 173432 RVA: 0x005C7004 File Offset: 0x005C5204
		public float StagnationImmuneDurationAfterHit
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B9D5 RID: 47573
		// (get) Token: 0x0602A579 RID: 173433 RVA: 0x005C7048 File Offset: 0x005C5248
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

		// Token: 0x0602A57A RID: 173434 RVA: 0x005C7085 File Offset: 0x005C5285
		public static Offset<IWaterElementalMatch> CreateIWaterElementalMatch(FlatBufferBuilder builder, EElementalType Type = EElementalType.Fire, bool CanStagnate = false, Offset<IWaterStagnationActorConfig> StagnationActorConfigOffset = default(Offset<IWaterStagnationActorConfig>), float StagnationImmuneDurationAfterHit = 0f, byte NullMask = 0)
		{
			builder.StartTable(5);
			IWaterElementalMatch.AddStagnationImmuneDurationAfterHit(builder, StagnationImmuneDurationAfterHit);
			IWaterElementalMatch.AddStagnationActorConfig(builder, StagnationActorConfigOffset);
			IWaterElementalMatch.AddNullMask(builder, NullMask);
			IWaterElementalMatch.AddCanStagnate(builder, CanStagnate);
			IWaterElementalMatch.AddType(builder, Type);
			return IWaterElementalMatch.EndIWaterElementalMatch(builder);
		}

		// Token: 0x0602A57B RID: 173435 RVA: 0x005C70B9 File Offset: 0x005C52B9
		public static void StartIWaterElementalMatch(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602A57C RID: 173436 RVA: 0x005C70C2 File Offset: 0x005C52C2
		public static void AddType(FlatBufferBuilder builder, EElementalType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A57D RID: 173437 RVA: 0x005C70CD File Offset: 0x005C52CD
		public static void AddCanStagnate(FlatBufferBuilder builder, bool canStagnate)
		{
			builder.AddBool(1, canStagnate, false);
		}

		// Token: 0x0602A57E RID: 173438 RVA: 0x005C70D8 File Offset: 0x005C52D8
		public static void AddStagnationActorConfig(FlatBufferBuilder builder, Offset<IWaterStagnationActorConfig> stagnationActorConfigOffset)
		{
			builder.AddOffset(2, stagnationActorConfigOffset.Value, 0);
		}

		// Token: 0x0602A57F RID: 173439 RVA: 0x005C70E8 File Offset: 0x005C52E8
		public static void AddStagnationImmuneDurationAfterHit(FlatBufferBuilder builder, float stagnationImmuneDurationAfterHit)
		{
			builder.AddFloat(3, stagnationImmuneDurationAfterHit, 0.0);
		}

		// Token: 0x0602A580 RID: 173440 RVA: 0x005C70FB File Offset: 0x005C52FB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602A581 RID: 173441 RVA: 0x005C7106 File Offset: 0x005C5306
		public static Offset<IWaterElementalMatch> EndIWaterElementalMatch(FlatBufferBuilder builder)
		{
			return new Offset<IWaterElementalMatch>(builder.EndTable());
		}

		// Token: 0x0602A582 RID: 173442 RVA: 0x005C7114 File Offset: 0x005C5314
		public IWaterElementalMatchT UnPack()
		{
			IWaterElementalMatchT waterElementalMatchT = new IWaterElementalMatchT();
			this.UnPackTo(waterElementalMatchT);
			return waterElementalMatchT;
		}

		// Token: 0x0602A583 RID: 173443 RVA: 0x005C7130 File Offset: 0x005C5330
		public void UnPackTo(IWaterElementalMatchT _o)
		{
			_o.Type = this.Type;
			_o.CanStagnate = this.CanStagnate;
			_o.StagnationActorConfig = ((this.StagnationActorConfig != null) ? this.StagnationActorConfig.Value.UnPack() : null);
			_o.StagnationImmuneDurationAfterHit = this.StagnationImmuneDurationAfterHit;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602A584 RID: 173444 RVA: 0x005C719C File Offset: 0x005C539C
		public static Offset<IWaterElementalMatch> Pack(FlatBufferBuilder builder, IWaterElementalMatchT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWaterElementalMatch>);
			}
			Offset<IWaterStagnationActorConfig> stagnationActorConfigOffset = (_o.StagnationActorConfig == null) ? default(Offset<IWaterStagnationActorConfig>) : IWaterStagnationActorConfig.Pack(builder, _o.StagnationActorConfig);
			return IWaterElementalMatch.CreateIWaterElementalMatch(builder, _o.Type, _o.CanStagnate, stagnationActorConfigOffset, _o.StagnationImmuneDurationAfterHit, _o.NullMask);
		}

		// Token: 0x0400FF93 RID: 65427
		private Table __p;
	}
}
