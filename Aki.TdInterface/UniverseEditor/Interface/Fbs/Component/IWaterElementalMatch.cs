using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B50 RID: 23376
	public struct IWaterElementalMatch : IFlatbufferObject
	{
		// Token: 0x1700B088 RID: 45192
		// (get) Token: 0x06027FAB RID: 163755 RVA: 0x0057F429 File Offset: 0x0057D629
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027FAC RID: 163756 RVA: 0x0057F436 File Offset: 0x0057D636
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027FAD RID: 163757 RVA: 0x0057F440 File Offset: 0x0057D640
		public static IWaterElementalMatch GetRootAsIWaterElementalMatch(ByteBuffer _bb)
		{
			return IWaterElementalMatch.GetRootAsIWaterElementalMatch(_bb, default(IWaterElementalMatch));
		}

		// Token: 0x06027FAE RID: 163758 RVA: 0x0057F45C File Offset: 0x0057D65C
		public static IWaterElementalMatch GetRootAsIWaterElementalMatch(ByteBuffer _bb, IWaterElementalMatch obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027FAF RID: 163759 RVA: 0x0057F479 File Offset: 0x0057D679
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027FB0 RID: 163760 RVA: 0x0057F488 File Offset: 0x0057D688
		public IWaterElementalMatch __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B089 RID: 45193
		// (get) Token: 0x06027FB1 RID: 163761 RVA: 0x0057F498 File Offset: 0x0057D698
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

		// Token: 0x1700B08A RID: 45194
		// (get) Token: 0x06027FB2 RID: 163762 RVA: 0x0057F4D4 File Offset: 0x0057D6D4
		public bool CanStagnate
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B08B RID: 45195
		// (get) Token: 0x06027FB3 RID: 163763 RVA: 0x0057F514 File Offset: 0x0057D714
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

		// Token: 0x1700B08C RID: 45196
		// (get) Token: 0x06027FB4 RID: 163764 RVA: 0x0057F574 File Offset: 0x0057D774
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

		// Token: 0x1700B08D RID: 45197
		// (get) Token: 0x06027FB5 RID: 163765 RVA: 0x0057F5B8 File Offset: 0x0057D7B8
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

		// Token: 0x06027FB6 RID: 163766 RVA: 0x0057F5F5 File Offset: 0x0057D7F5
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

		// Token: 0x06027FB7 RID: 163767 RVA: 0x0057F629 File Offset: 0x0057D829
		public static void StartIWaterElementalMatch(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06027FB8 RID: 163768 RVA: 0x0057F632 File Offset: 0x0057D832
		public static void AddType(FlatBufferBuilder builder, EElementalType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027FB9 RID: 163769 RVA: 0x0057F63D File Offset: 0x0057D83D
		public static void AddCanStagnate(FlatBufferBuilder builder, bool canStagnate)
		{
			builder.AddBool(1, canStagnate, false);
		}

		// Token: 0x06027FBA RID: 163770 RVA: 0x0057F648 File Offset: 0x0057D848
		public static void AddStagnationActorConfig(FlatBufferBuilder builder, Offset<IWaterStagnationActorConfig> stagnationActorConfigOffset)
		{
			builder.AddOffset(2, stagnationActorConfigOffset.Value, 0);
		}

		// Token: 0x06027FBB RID: 163771 RVA: 0x0057F658 File Offset: 0x0057D858
		public static void AddStagnationImmuneDurationAfterHit(FlatBufferBuilder builder, float stagnationImmuneDurationAfterHit)
		{
			builder.AddFloat(3, stagnationImmuneDurationAfterHit, 0.0);
		}

		// Token: 0x06027FBC RID: 163772 RVA: 0x0057F66B File Offset: 0x0057D86B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06027FBD RID: 163773 RVA: 0x0057F676 File Offset: 0x0057D876
		public static Offset<IWaterElementalMatch> EndIWaterElementalMatch(FlatBufferBuilder builder)
		{
			return new Offset<IWaterElementalMatch>(builder.EndTable());
		}

		// Token: 0x06027FBE RID: 163774 RVA: 0x0057F684 File Offset: 0x0057D884
		public IWaterElementalMatchT UnPack()
		{
			IWaterElementalMatchT waterElementalMatchT = new IWaterElementalMatchT();
			this.UnPackTo(waterElementalMatchT);
			return waterElementalMatchT;
		}

		// Token: 0x06027FBF RID: 163775 RVA: 0x0057F6A0 File Offset: 0x0057D8A0
		public void UnPackTo(IWaterElementalMatchT _o)
		{
			_o.Type = this.Type;
			_o.CanStagnate = this.CanStagnate;
			_o.StagnationActorConfig = ((this.StagnationActorConfig != null) ? this.StagnationActorConfig.Value.UnPack() : null);
			_o.StagnationImmuneDurationAfterHit = this.StagnationImmuneDurationAfterHit;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06027FC0 RID: 163776 RVA: 0x0057F70C File Offset: 0x0057D90C
		public static Offset<IWaterElementalMatch> Pack(FlatBufferBuilder builder, IWaterElementalMatchT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWaterElementalMatch>);
			}
			Offset<IWaterStagnationActorConfig> stagnationActorConfigOffset = (_o.StagnationActorConfig == null) ? default(Offset<IWaterStagnationActorConfig>) : IWaterStagnationActorConfig.Pack(builder, _o.StagnationActorConfig);
			return IWaterElementalMatch.CreateIWaterElementalMatch(builder, _o.Type, _o.CanStagnate, stagnationActorConfigOffset, _o.StagnationImmuneDurationAfterHit, _o.NullMask);
		}

		// Token: 0x0400F28D RID: 62093
		private Table __p;
	}
}
