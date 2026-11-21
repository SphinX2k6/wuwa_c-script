using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FDA RID: 20442
	public struct ICheckPlayerSkillReadyCondition : IFlatbufferObject
	{
		// Token: 0x17009242 RID: 37442
		// (get) Token: 0x0601FE30 RID: 130608 RVA: 0x0046D9FB File Offset: 0x0046BBFB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FE31 RID: 130609 RVA: 0x0046DA08 File Offset: 0x0046BC08
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FE32 RID: 130610 RVA: 0x0046DA10 File Offset: 0x0046BC10
		public static ICheckPlayerSkillReadyCondition GetRootAsICheckPlayerSkillReadyCondition(ByteBuffer _bb)
		{
			return ICheckPlayerSkillReadyCondition.GetRootAsICheckPlayerSkillReadyCondition(_bb, default(ICheckPlayerSkillReadyCondition));
		}

		// Token: 0x0601FE33 RID: 130611 RVA: 0x0046DA2C File Offset: 0x0046BC2C
		public static ICheckPlayerSkillReadyCondition GetRootAsICheckPlayerSkillReadyCondition(ByteBuffer _bb, ICheckPlayerSkillReadyCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FE34 RID: 130612 RVA: 0x0046DA49 File Offset: 0x0046BC49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FE35 RID: 130613 RVA: 0x0046DA58 File Offset: 0x0046BC58
		public ICheckPlayerSkillReadyCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009243 RID: 37443
		// (get) Token: 0x0601FE36 RID: 130614 RVA: 0x0046DA68 File Offset: 0x0046BC68
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

		// Token: 0x17009244 RID: 37444
		// (get) Token: 0x0601FE37 RID: 130615 RVA: 0x0046DAA4 File Offset: 0x0046BCA4
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

		// Token: 0x0601FE38 RID: 130616 RVA: 0x0046DAE0 File Offset: 0x0046BCE0
		public TTable? SkillOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601FE39 RID: 130617 RVA: 0x0046DB24 File Offset: 0x0046BD24
		public IESkillReady SkillOptionAsIESkillReady()
		{
			return this.SkillOption<IESkillReady>().Value;
		}

		// Token: 0x0601FE3A RID: 130618 RVA: 0x0046DB40 File Offset: 0x0046BD40
		public IUltimateSkillReady SkillOptionAsIUltimateSkillReady()
		{
			return this.SkillOption<IUltimateSkillReady>().Value;
		}

		// Token: 0x0601FE3B RID: 130619 RVA: 0x0046DB5C File Offset: 0x0046BD5C
		public IVisionSkillReady SkillOptionAsIVisionSkillReady()
		{
			return this.SkillOption<IVisionSkillReady>().Value;
		}

		// Token: 0x0601FE3C RID: 130620 RVA: 0x0046DB77 File Offset: 0x0046BD77
		public static Offset<ICheckPlayerSkillReadyCondition> CreateICheckPlayerSkillReadyCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, TSkillReadyOption SkillOption_type = TSkillReadyOption.NONE, int SkillOptionOffset = 0)
		{
			builder.StartTable(3);
			ICheckPlayerSkillReadyCondition.AddSkillOption(builder, SkillOptionOffset);
			ICheckPlayerSkillReadyCondition.AddSkillOptionType(builder, SkillOption_type);
			ICheckPlayerSkillReadyCondition.AddType(builder, Type);
			return ICheckPlayerSkillReadyCondition.EndICheckPlayerSkillReadyCondition(builder);
		}

		// Token: 0x0601FE3D RID: 130621 RVA: 0x0046DB9B File Offset: 0x0046BD9B
		public static void StartICheckPlayerSkillReadyCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601FE3E RID: 130622 RVA: 0x0046DBA4 File Offset: 0x0046BDA4
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FE3F RID: 130623 RVA: 0x0046DBAF File Offset: 0x0046BDAF
		public static void AddSkillOptionType(FlatBufferBuilder builder, TSkillReadyOption skillOptionType)
		{
			builder.AddByte(1, (byte)skillOptionType, 0);
		}

		// Token: 0x0601FE40 RID: 130624 RVA: 0x0046DBBA File Offset: 0x0046BDBA
		public static void AddSkillOption(FlatBufferBuilder builder, int skillOptionOffset)
		{
			builder.AddOffset(2, skillOptionOffset, 0);
		}

		// Token: 0x0601FE41 RID: 130625 RVA: 0x0046DBC5 File Offset: 0x0046BDC5
		public static Offset<ICheckPlayerSkillReadyCondition> EndICheckPlayerSkillReadyCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckPlayerSkillReadyCondition>(builder.EndTable());
		}

		// Token: 0x0601FE42 RID: 130626 RVA: 0x0046DBD4 File Offset: 0x0046BDD4
		public ICheckPlayerSkillReadyConditionT UnPack()
		{
			ICheckPlayerSkillReadyConditionT checkPlayerSkillReadyConditionT = new ICheckPlayerSkillReadyConditionT();
			this.UnPackTo(checkPlayerSkillReadyConditionT);
			return checkPlayerSkillReadyConditionT;
		}

		// Token: 0x0601FE43 RID: 130627 RVA: 0x0046DBF0 File Offset: 0x0046BDF0
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

		// Token: 0x0601FE44 RID: 130628 RVA: 0x0046DCE4 File Offset: 0x0046BEE4
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

		// Token: 0x0400DE88 RID: 56968
		private Table __p;
	}
}
