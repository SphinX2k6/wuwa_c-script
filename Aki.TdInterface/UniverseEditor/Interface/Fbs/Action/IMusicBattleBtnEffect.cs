using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B91 RID: 27537
	public struct IMusicBattleBtnEffect : IFlatbufferObject
	{
		// Token: 0x1700CCAE RID: 52398
		// (get) Token: 0x060305BF RID: 198079 RVA: 0x00691C06 File Offset: 0x0068FE06
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060305C0 RID: 198080 RVA: 0x00691C13 File Offset: 0x0068FE13
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060305C1 RID: 198081 RVA: 0x00691C1C File Offset: 0x0068FE1C
		public static IMusicBattleBtnEffect GetRootAsIMusicBattleBtnEffect(ByteBuffer _bb)
		{
			return IMusicBattleBtnEffect.GetRootAsIMusicBattleBtnEffect(_bb, default(IMusicBattleBtnEffect));
		}

		// Token: 0x060305C2 RID: 198082 RVA: 0x00691C38 File Offset: 0x0068FE38
		public static IMusicBattleBtnEffect GetRootAsIMusicBattleBtnEffect(ByteBuffer _bb, IMusicBattleBtnEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060305C3 RID: 198083 RVA: 0x00691C55 File Offset: 0x0068FE55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060305C4 RID: 198084 RVA: 0x00691C64 File Offset: 0x0068FE64
		public IMusicBattleBtnEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CCAF RID: 52399
		// (get) Token: 0x060305C5 RID: 198085 RVA: 0x00691C74 File Offset: 0x0068FE74
		public ESkillBtnEffectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESkillBtnEffectType.MusicBattleBtnEffect;
				}
				return (ESkillBtnEffectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060305C6 RID: 198086 RVA: 0x00691CB0 File Offset: 0x0068FEB0
		public static Offset<IMusicBattleBtnEffect> CreateIMusicBattleBtnEffect(FlatBufferBuilder builder, ESkillBtnEffectType Type = ESkillBtnEffectType.MusicBattleBtnEffect)
		{
			builder.StartTable(1);
			IMusicBattleBtnEffect.AddType(builder, Type);
			return IMusicBattleBtnEffect.EndIMusicBattleBtnEffect(builder);
		}

		// Token: 0x060305C7 RID: 198087 RVA: 0x00691CC6 File Offset: 0x0068FEC6
		public static void StartIMusicBattleBtnEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060305C8 RID: 198088 RVA: 0x00691CCF File Offset: 0x0068FECF
		public static void AddType(FlatBufferBuilder builder, ESkillBtnEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060305C9 RID: 198089 RVA: 0x00691CDA File Offset: 0x0068FEDA
		public static Offset<IMusicBattleBtnEffect> EndIMusicBattleBtnEffect(FlatBufferBuilder builder)
		{
			return new Offset<IMusicBattleBtnEffect>(builder.EndTable());
		}

		// Token: 0x060305CA RID: 198090 RVA: 0x00691CE8 File Offset: 0x0068FEE8
		public IMusicBattleBtnEffectT UnPack()
		{
			IMusicBattleBtnEffectT musicBattleBtnEffectT = new IMusicBattleBtnEffectT();
			this.UnPackTo(musicBattleBtnEffectT);
			return musicBattleBtnEffectT;
		}

		// Token: 0x060305CB RID: 198091 RVA: 0x00691D03 File Offset: 0x0068FF03
		public void UnPackTo(IMusicBattleBtnEffectT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060305CC RID: 198092 RVA: 0x00691D14 File Offset: 0x0068FF14
		public static Offset<IMusicBattleBtnEffect> Pack(FlatBufferBuilder builder, IMusicBattleBtnEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMusicBattleBtnEffect>);
			}
			return IMusicBattleBtnEffect.CreateIMusicBattleBtnEffect(builder, _o.Type);
		}

		// Token: 0x04011453 RID: 70739
		private Table __p;
	}
}
