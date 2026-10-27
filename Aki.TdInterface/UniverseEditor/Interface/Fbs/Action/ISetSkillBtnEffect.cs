using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200706D RID: 28781
	public struct ISetSkillBtnEffect : IFlatbufferObject
	{
		// Token: 0x1700D5EB RID: 54763
		// (get) Token: 0x06032F5A RID: 208730 RVA: 0x006DFD5E File Offset: 0x006DDF5E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032F5B RID: 208731 RVA: 0x006DFD6B File Offset: 0x006DDF6B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032F5C RID: 208732 RVA: 0x006DFD74 File Offset: 0x006DDF74
		public static ISetSkillBtnEffect GetRootAsISetSkillBtnEffect(ByteBuffer _bb)
		{
			return ISetSkillBtnEffect.GetRootAsISetSkillBtnEffect(_bb, default(ISetSkillBtnEffect));
		}

		// Token: 0x06032F5D RID: 208733 RVA: 0x006DFD90 File Offset: 0x006DDF90
		public static ISetSkillBtnEffect GetRootAsISetSkillBtnEffect(ByteBuffer _bb, ISetSkillBtnEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032F5E RID: 208734 RVA: 0x006DFDAD File Offset: 0x006DDFAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032F5F RID: 208735 RVA: 0x006DFDBC File Offset: 0x006DDFBC
		public ISetSkillBtnEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D5EC RID: 54764
		// (get) Token: 0x06032F60 RID: 208736 RVA: 0x006DFDCC File Offset: 0x006DDFCC
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

		// Token: 0x1700D5ED RID: 54765
		// (get) Token: 0x06032F61 RID: 208737 RVA: 0x006DFE08 File Offset: 0x006DE008
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

		// Token: 0x1700D5EE RID: 54766
		// (get) Token: 0x06032F62 RID: 208738 RVA: 0x006DFE68 File Offset: 0x006DE068
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

		// Token: 0x06032F63 RID: 208739 RVA: 0x006DFEA8 File Offset: 0x006DE0A8
		public static Offset<ISetSkillBtnEffect> CreateISetSkillBtnEffect(FlatBufferBuilder builder, ESkillButtonType SkillBtnType = ESkillButtonType.None, Offset<IMusicBattleBtnEffect> SkillBtnEffectDataOffset = default(Offset<IMusicBattleBtnEffect>), float Time = 0f)
		{
			builder.StartTable(3);
			ISetSkillBtnEffect.AddTime(builder, Time);
			ISetSkillBtnEffect.AddSkillBtnEffectData(builder, SkillBtnEffectDataOffset);
			ISetSkillBtnEffect.AddSkillBtnType(builder, SkillBtnType);
			return ISetSkillBtnEffect.EndISetSkillBtnEffect(builder);
		}

		// Token: 0x06032F64 RID: 208740 RVA: 0x006DFECC File Offset: 0x006DE0CC
		public static void StartISetSkillBtnEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06032F65 RID: 208741 RVA: 0x006DFED5 File Offset: 0x006DE0D5
		public static void AddSkillBtnType(FlatBufferBuilder builder, ESkillButtonType skillBtnType)
		{
			builder.AddUshort(0, (ushort)skillBtnType, 0);
		}

		// Token: 0x06032F66 RID: 208742 RVA: 0x006DFEE0 File Offset: 0x006DE0E0
		public static void AddSkillBtnEffectData(FlatBufferBuilder builder, Offset<IMusicBattleBtnEffect> skillBtnEffectDataOffset)
		{
			builder.AddOffset(1, skillBtnEffectDataOffset.Value, 0);
		}

		// Token: 0x06032F67 RID: 208743 RVA: 0x006DFEF0 File Offset: 0x006DE0F0
		public static void AddTime(FlatBufferBuilder builder, float time)
		{
			builder.AddFloat(2, time, 0.0);
		}

		// Token: 0x06032F68 RID: 208744 RVA: 0x006DFF03 File Offset: 0x006DE103
		public static Offset<ISetSkillBtnEffect> EndISetSkillBtnEffect(FlatBufferBuilder builder)
		{
			return new Offset<ISetSkillBtnEffect>(builder.EndTable());
		}

		// Token: 0x06032F69 RID: 208745 RVA: 0x006DFF10 File Offset: 0x006DE110
		public ISetSkillBtnEffectT UnPack()
		{
			ISetSkillBtnEffectT setSkillBtnEffectT = new ISetSkillBtnEffectT();
			this.UnPackTo(setSkillBtnEffectT);
			return setSkillBtnEffectT;
		}

		// Token: 0x06032F6A RID: 208746 RVA: 0x006DFF2C File Offset: 0x006DE12C
		public void UnPackTo(ISetSkillBtnEffectT _o)
		{
			_o.SkillBtnType = this.SkillBtnType;
			_o.SkillBtnEffectData = ((this.SkillBtnEffectData != null) ? this.SkillBtnEffectData.Value.UnPack() : null);
			_o.Time = this.Time;
		}

		// Token: 0x06032F6B RID: 208747 RVA: 0x006DFF80 File Offset: 0x006DE180
		public static Offset<ISetSkillBtnEffect> Pack(FlatBufferBuilder builder, ISetSkillBtnEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetSkillBtnEffect>);
			}
			Offset<IMusicBattleBtnEffect> skillBtnEffectDataOffset = (_o.SkillBtnEffectData == null) ? default(Offset<IMusicBattleBtnEffect>) : IMusicBattleBtnEffect.Pack(builder, _o.SkillBtnEffectData);
			return ISetSkillBtnEffect.CreateISetSkillBtnEffect(builder, _o.SkillBtnType, skillBtnEffectDataOffset, _o.Time);
		}

		// Token: 0x04011AD1 RID: 72401
		private Table __p;
	}
}
