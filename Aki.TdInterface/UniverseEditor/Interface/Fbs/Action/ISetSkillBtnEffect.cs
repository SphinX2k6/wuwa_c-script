using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007839 RID: 30777
	public struct ISetSkillBtnEffect : IFlatbufferObject
	{
		// Token: 0x1700E1CE RID: 57806
		// (get) Token: 0x060361FB RID: 221691 RVA: 0x00740312 File Offset: 0x0073E512
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060361FC RID: 221692 RVA: 0x0074031F File Offset: 0x0073E51F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060361FD RID: 221693 RVA: 0x00740328 File Offset: 0x0073E528
		public static ISetSkillBtnEffect GetRootAsISetSkillBtnEffect(ByteBuffer _bb)
		{
			return ISetSkillBtnEffect.GetRootAsISetSkillBtnEffect(_bb, default(ISetSkillBtnEffect));
		}

		// Token: 0x060361FE RID: 221694 RVA: 0x00740344 File Offset: 0x0073E544
		public static ISetSkillBtnEffect GetRootAsISetSkillBtnEffect(ByteBuffer _bb, ISetSkillBtnEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060361FF RID: 221695 RVA: 0x00740361 File Offset: 0x0073E561
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036200 RID: 221696 RVA: 0x00740370 File Offset: 0x0073E570
		public ISetSkillBtnEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E1CF RID: 57807
		// (get) Token: 0x06036201 RID: 221697 RVA: 0x00740380 File Offset: 0x0073E580
		public ESkillButtonType SkillBtnType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESkillButtonType.None;
				}
				return (ESkillButtonType)this.__p.bb.GetUshort(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E1D0 RID: 57808
		// (get) Token: 0x06036202 RID: 221698 RVA: 0x007403BC File Offset: 0x0073E5BC
		public IMusicBattleBtnEffect? SkillBtnEffectData
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IMusicBattleBtnEffect?(default(IMusicBattleBtnEffect).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700E1D1 RID: 57809
		// (get) Token: 0x06036203 RID: 221699 RVA: 0x0074041C File Offset: 0x0073E61C
		public float Time
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

		// Token: 0x06036204 RID: 221700 RVA: 0x0074045C File Offset: 0x0073E65C
		public static Offset<ISetSkillBtnEffect> CreateISetSkillBtnEffect(FlatBufferBuilder builder, ESkillButtonType SkillBtnType = ESkillButtonType.None, Offset<IMusicBattleBtnEffect> SkillBtnEffectDataOffset = default(Offset<IMusicBattleBtnEffect>), float Time = 0f)
		{
			builder.StartTable(3);
			ISetSkillBtnEffect.AddTime(builder, Time);
			ISetSkillBtnEffect.AddSkillBtnEffectData(builder, SkillBtnEffectDataOffset);
			ISetSkillBtnEffect.AddSkillBtnType(builder, SkillBtnType);
			return ISetSkillBtnEffect.EndISetSkillBtnEffect(builder);
		}

		// Token: 0x06036205 RID: 221701 RVA: 0x00740480 File Offset: 0x0073E680
		public static void StartISetSkillBtnEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06036206 RID: 221702 RVA: 0x00740489 File Offset: 0x0073E689
		public static void AddSkillBtnType(FlatBufferBuilder builder, ESkillButtonType skillBtnType)
		{
			builder.AddUshort(0, (ushort)skillBtnType, 0);
		}

		// Token: 0x06036207 RID: 221703 RVA: 0x00740494 File Offset: 0x0073E694
		public static void AddSkillBtnEffectData(FlatBufferBuilder builder, Offset<IMusicBattleBtnEffect> skillBtnEffectDataOffset)
		{
			builder.AddOffset(1, skillBtnEffectDataOffset.Value, 0);
		}

		// Token: 0x06036208 RID: 221704 RVA: 0x007404A4 File Offset: 0x0073E6A4
		public static void AddTime(FlatBufferBuilder builder, float time)
		{
			builder.AddFloat(2, time, 0.0);
		}

		// Token: 0x06036209 RID: 221705 RVA: 0x007404B7 File Offset: 0x0073E6B7
		public static Offset<ISetSkillBtnEffect> EndISetSkillBtnEffect(FlatBufferBuilder builder)
		{
			return new Offset<ISetSkillBtnEffect>(builder.EndTable());
		}

		// Token: 0x0603620A RID: 221706 RVA: 0x007404C4 File Offset: 0x0073E6C4
		public ISetSkillBtnEffectT UnPack()
		{
			ISetSkillBtnEffectT setSkillBtnEffectT = new ISetSkillBtnEffectT();
			this.UnPackTo(setSkillBtnEffectT);
			return setSkillBtnEffectT;
		}

		// Token: 0x0603620B RID: 221707 RVA: 0x007404E0 File Offset: 0x0073E6E0
		public void UnPackTo(ISetSkillBtnEffectT _o)
		{
			_o.SkillBtnType = this.SkillBtnType;
			_o.SkillBtnEffectData = ((this.SkillBtnEffectData != null) ? this.SkillBtnEffectData.Value.UnPack() : null);
			_o.Time = this.Time;
		}

		// Token: 0x0603620C RID: 221708 RVA: 0x00740534 File Offset: 0x0073E734
		public static Offset<ISetSkillBtnEffect> Pack(FlatBufferBuilder builder, ISetSkillBtnEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetSkillBtnEffect>);
			}
			Offset<IMusicBattleBtnEffect> skillBtnEffectDataOffset = (_o.SkillBtnEffectData == null) ? default(Offset<IMusicBattleBtnEffect>) : IMusicBattleBtnEffect.Pack(builder, _o.SkillBtnEffectData);
			return ISetSkillBtnEffect.CreateISetSkillBtnEffect(builder, _o.SkillBtnType, skillBtnEffectDataOffset, _o.Time);
		}

		// Token: 0x04012ABF RID: 76479
		private Table __p;
	}
}
