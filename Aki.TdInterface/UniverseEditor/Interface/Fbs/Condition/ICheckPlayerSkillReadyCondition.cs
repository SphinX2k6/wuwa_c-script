using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AFF RID: 19199
	public struct ICheckPlayerSkillReadyCondition : IFlatbufferObject
	{
		// Token: 0x17008B41 RID: 35649
		// (get) Token: 0x0601E2EF RID: 123631 RVA: 0x0043B94F File Offset: 0x00439B4F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E2F0 RID: 123632 RVA: 0x0043B95C File Offset: 0x00439B5C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E2F1 RID: 123633 RVA: 0x0043B964 File Offset: 0x00439B64
		public static ICheckPlayerSkillReadyCondition GetRootAsICheckPlayerSkillReadyCondition(ByteBuffer _bb)
		{
			return ICheckPlayerSkillReadyCondition.GetRootAsICheckPlayerSkillReadyCondition(_bb, default(ICheckPlayerSkillReadyCondition));
		}

		// Token: 0x0601E2F2 RID: 123634 RVA: 0x0043B980 File Offset: 0x00439B80
		public static ICheckPlayerSkillReadyCondition GetRootAsICheckPlayerSkillReadyCondition(ByteBuffer _bb, ICheckPlayerSkillReadyCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E2F3 RID: 123635 RVA: 0x0043B99D File Offset: 0x00439B9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E2F4 RID: 123636 RVA: 0x0043B9AC File Offset: 0x00439BAC
		public ICheckPlayerSkillReadyCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008B42 RID: 35650
		// (get) Token: 0x0601E2F5 RID: 123637 RVA: 0x0043B9BC File Offset: 0x00439BBC
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008B43 RID: 35651
		// (get) Token: 0x0601E2F6 RID: 123638 RVA: 0x0043B9F8 File Offset: 0x00439BF8
		public TSkillReadyOption SkillOptionType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TSkillReadyOption.NONE;
				}
				return (TSkillReadyOption)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E2F7 RID: 123639 RVA: 0x0043BA34 File Offset: 0x00439C34
		public TTable? SkillOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601E2F8 RID: 123640 RVA: 0x0043BA78 File Offset: 0x00439C78
		public IESkillReady SkillOptionAsIESkillReady()
		{
			return this.SkillOption<IESkillReady>().Value;
		}

		// Token: 0x0601E2F9 RID: 123641 RVA: 0x0043BA94 File Offset: 0x00439C94
		public IUltimateSkillReady SkillOptionAsIUltimateSkillReady()
		{
			return this.SkillOption<IUltimateSkillReady>().Value;
		}

		// Token: 0x0601E2FA RID: 123642 RVA: 0x0043BAB0 File Offset: 0x00439CB0
		public IVisionSkillReady SkillOptionAsIVisionSkillReady()
		{
			return this.SkillOption<IVisionSkillReady>().Value;
		}

		// Token: 0x0601E2FB RID: 123643 RVA: 0x0043BACB File Offset: 0x00439CCB
		public static Offset<ICheckPlayerSkillReadyCondition> CreateICheckPlayerSkillReadyCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, TSkillReadyOption SkillOption_type = TSkillReadyOption.NONE, int SkillOptionOffset = 0)
		{
			builder.StartTable(3);
			ICheckPlayerSkillReadyCondition.AddSkillOption(builder, SkillOptionOffset);
			ICheckPlayerSkillReadyCondition.AddSkillOptionType(builder, SkillOption_type);
			ICheckPlayerSkillReadyCondition.AddType(builder, Type);
			return ICheckPlayerSkillReadyCondition.EndICheckPlayerSkillReadyCondition(builder);
		}

		// Token: 0x0601E2FC RID: 123644 RVA: 0x0043BAEF File Offset: 0x00439CEF
		public static void StartICheckPlayerSkillReadyCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601E2FD RID: 123645 RVA: 0x0043BAF8 File Offset: 0x00439CF8
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E2FE RID: 123646 RVA: 0x0043BB03 File Offset: 0x00439D03
		public static void AddSkillOptionType(FlatBufferBuilder builder, TSkillReadyOption skillOptionType)
		{
			builder.AddByte(1, (byte)skillOptionType, 0);
		}

		// Token: 0x0601E2FF RID: 123647 RVA: 0x0043BB0E File Offset: 0x00439D0E
		public static void AddSkillOption(FlatBufferBuilder builder, int skillOptionOffset)
		{
			builder.AddOffset(2, skillOptionOffset, 0);
		}

		// Token: 0x0601E300 RID: 123648 RVA: 0x0043BB19 File Offset: 0x00439D19
		public static Offset<ICheckPlayerSkillReadyCondition> EndICheckPlayerSkillReadyCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckPlayerSkillReadyCondition>(builder.EndTable());
		}

		// Token: 0x0601E301 RID: 123649 RVA: 0x0043BB28 File Offset: 0x00439D28
		public ICheckPlayerSkillReadyConditionT UnPack()
		{
			ICheckPlayerSkillReadyConditionT checkPlayerSkillReadyConditionT = new ICheckPlayerSkillReadyConditionT();
			this.UnPackTo(checkPlayerSkillReadyConditionT);
			return checkPlayerSkillReadyConditionT;
		}

		// Token: 0x0601E302 RID: 123650 RVA: 0x0043BB44 File Offset: 0x00439D44
		public void UnPackTo(ICheckPlayerSkillReadyConditionT _o)
		{
			_o.Type = this.Type;
			_o.SkillOption = new TSkillReadyOptionUnion();
			_o.SkillOption.Type = this.SkillOptionType;
			switch (this.SkillOptionType)
			{
			case TSkillReadyOption.IESkillReady:
				_o.SkillOption.Value = ((this.SkillOption<IESkillReady>() != null) ? this.SkillOption<IESkillReady>().Value.UnPack() : null);
				return;
			case TSkillReadyOption.IUltimateSkillReady:
				_o.SkillOption.Value = ((this.SkillOption<IUltimateSkillReady>() != null) ? this.SkillOption<IUltimateSkillReady>().Value.UnPack() : null);
				return;
			case TSkillReadyOption.IVisionSkillReady:
				_o.SkillOption.Value = ((this.SkillOption<IVisionSkillReady>() != null) ? this.SkillOption<IVisionSkillReady>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0601E303 RID: 123651 RVA: 0x0043BC38 File Offset: 0x00439E38
		public static Offset<ICheckPlayerSkillReadyCondition> Pack(FlatBufferBuilder builder, ICheckPlayerSkillReadyConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckPlayerSkillReadyCondition>);
			}
			TSkillReadyOption skillOption_type = (_o.SkillOption == null) ? TSkillReadyOption.NONE : _o.SkillOption.Type;
			int skillOptionOffset = (_o.SkillOption == null) ? 0 : TSkillReadyOptionUnion.Pack(builder, _o.SkillOption);
			return ICheckPlayerSkillReadyCondition.CreateICheckPlayerSkillReadyCondition(builder, _o.Type, skillOption_type, skillOptionOffset);
		}

		// Token: 0x0400D397 RID: 54167
		private Table __p;
	}
}
