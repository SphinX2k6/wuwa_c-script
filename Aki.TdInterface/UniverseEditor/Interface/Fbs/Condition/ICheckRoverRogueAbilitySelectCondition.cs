using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B20 RID: 19232
	public struct ICheckRoverRogueAbilitySelectCondition : IFlatbufferObject
	{
		// Token: 0x17008B7D RID: 35709
		// (get) Token: 0x0601E3FC RID: 123900 RVA: 0x0043D762 File Offset: 0x0043B962
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E3FD RID: 123901 RVA: 0x0043D76F File Offset: 0x0043B96F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E3FE RID: 123902 RVA: 0x0043D778 File Offset: 0x0043B978
		public static ICheckRoverRogueAbilitySelectCondition GetRootAsICheckRoverRogueAbilitySelectCondition(ByteBuffer _bb)
		{
			return ICheckRoverRogueAbilitySelectCondition.GetRootAsICheckRoverRogueAbilitySelectCondition(_bb, default(ICheckRoverRogueAbilitySelectCondition));
		}

		// Token: 0x0601E3FF RID: 123903 RVA: 0x0043D794 File Offset: 0x0043B994
		public static ICheckRoverRogueAbilitySelectCondition GetRootAsICheckRoverRogueAbilitySelectCondition(ByteBuffer _bb, ICheckRoverRogueAbilitySelectCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E400 RID: 123904 RVA: 0x0043D7B1 File Offset: 0x0043B9B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E401 RID: 123905 RVA: 0x0043D7C0 File Offset: 0x0043B9C0
		public ICheckRoverRogueAbilitySelectCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008B7E RID: 35710
		// (get) Token: 0x0601E402 RID: 123906 RVA: 0x0043D7D0 File Offset: 0x0043B9D0
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

		// Token: 0x17008B7F RID: 35711
		// (get) Token: 0x0601E403 RID: 123907 RVA: 0x0043D80C File Offset: 0x0043BA0C
		public ERoverRogueAbilitySelectType SelectType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ERoverRogueAbilitySelectType.Shop;
				}
				return (ERoverRogueAbilitySelectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008B80 RID: 35712
		// (get) Token: 0x0601E404 RID: 123908 RVA: 0x0043D848 File Offset: 0x0043BA48
		public bool IsReceived
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601E405 RID: 123909 RVA: 0x0043D887 File Offset: 0x0043BA87
		public static Offset<ICheckRoverRogueAbilitySelectCondition> CreateICheckRoverRogueAbilitySelectCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, ERoverRogueAbilitySelectType SelectType = ERoverRogueAbilitySelectType.Shop, bool IsReceived = false)
		{
			builder.StartTable(3);
			ICheckRoverRogueAbilitySelectCondition.AddIsReceived(builder, IsReceived);
			ICheckRoverRogueAbilitySelectCondition.AddSelectType(builder, SelectType);
			ICheckRoverRogueAbilitySelectCondition.AddType(builder, Type);
			return ICheckRoverRogueAbilitySelectCondition.EndICheckRoverRogueAbilitySelectCondition(builder);
		}

		// Token: 0x0601E406 RID: 123910 RVA: 0x0043D8AB File Offset: 0x0043BAAB
		public static void StartICheckRoverRogueAbilitySelectCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601E407 RID: 123911 RVA: 0x0043D8B4 File Offset: 0x0043BAB4
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E408 RID: 123912 RVA: 0x0043D8BF File Offset: 0x0043BABF
		public static void AddSelectType(FlatBufferBuilder builder, ERoverRogueAbilitySelectType selectType)
		{
			builder.AddByte(1, (byte)selectType, 0);
		}

		// Token: 0x0601E409 RID: 123913 RVA: 0x0043D8CA File Offset: 0x0043BACA
		public static void AddIsReceived(FlatBufferBuilder builder, bool isReceived)
		{
			builder.AddBool(2, isReceived, false);
		}

		// Token: 0x0601E40A RID: 123914 RVA: 0x0043D8D5 File Offset: 0x0043BAD5
		public static Offset<ICheckRoverRogueAbilitySelectCondition> EndICheckRoverRogueAbilitySelectCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckRoverRogueAbilitySelectCondition>(builder.EndTable());
		}

		// Token: 0x0601E40B RID: 123915 RVA: 0x0043D8E4 File Offset: 0x0043BAE4
		public ICheckRoverRogueAbilitySelectConditionT UnPack()
		{
			ICheckRoverRogueAbilitySelectConditionT checkRoverRogueAbilitySelectConditionT = new ICheckRoverRogueAbilitySelectConditionT();
			this.UnPackTo(checkRoverRogueAbilitySelectConditionT);
			return checkRoverRogueAbilitySelectConditionT;
		}

		// Token: 0x0601E40C RID: 123916 RVA: 0x0043D8FF File Offset: 0x0043BAFF
		public void UnPackTo(ICheckRoverRogueAbilitySelectConditionT _o)
		{
			_o.Type = this.Type;
			_o.SelectType = this.SelectType;
			_o.IsReceived = this.IsReceived;
		}

		// Token: 0x0601E40D RID: 123917 RVA: 0x0043D928 File Offset: 0x0043BB28
		public static Offset<ICheckRoverRogueAbilitySelectCondition> Pack(FlatBufferBuilder builder, ICheckRoverRogueAbilitySelectConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckRoverRogueAbilitySelectCondition>);
			}
			return ICheckRoverRogueAbilitySelectCondition.CreateICheckRoverRogueAbilitySelectCondition(builder, _o.Type, _o.SelectType, _o.IsReceived);
		}

		// Token: 0x0400D3C0 RID: 54208
		private Table __p;
	}
}
