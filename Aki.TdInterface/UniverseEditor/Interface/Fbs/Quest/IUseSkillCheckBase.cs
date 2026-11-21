using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046A0 RID: 18080
	public struct IUseSkillCheckBase : IFlatbufferObject
	{
		// Token: 0x17007EA4 RID: 32420
		// (get) Token: 0x0601A8D7 RID: 108759 RVA: 0x003C715F File Offset: 0x003C535F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A8D8 RID: 108760 RVA: 0x003C716C File Offset: 0x003C536C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A8D9 RID: 108761 RVA: 0x003C7174 File Offset: 0x003C5374
		public static IUseSkillCheckBase GetRootAsIUseSkillCheckBase(ByteBuffer _bb)
		{
			return IUseSkillCheckBase.GetRootAsIUseSkillCheckBase(_bb, default(IUseSkillCheckBase));
		}

		// Token: 0x0601A8DA RID: 108762 RVA: 0x003C7190 File Offset: 0x003C5390
		public static IUseSkillCheckBase GetRootAsIUseSkillCheckBase(ByteBuffer _bb, IUseSkillCheckBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A8DB RID: 108763 RVA: 0x003C71AD File Offset: 0x003C53AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A8DC RID: 108764 RVA: 0x003C71BC File Offset: 0x003C53BC
		public IUseSkillCheckBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007EA5 RID: 32421
		// (get) Token: 0x0601A8DD RID: 108765 RVA: 0x003C71CC File Offset: 0x003C53CC
		public EUseSkillCheckType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EUseSkillCheckType.CheckSkillGenre;
				}
				return (EUseSkillCheckType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A8DE RID: 108766 RVA: 0x003C7208 File Offset: 0x003C5408
		public static Offset<IUseSkillCheckBase> CreateIUseSkillCheckBase(FlatBufferBuilder builder, EUseSkillCheckType Type = EUseSkillCheckType.CheckSkillGenre)
		{
			builder.StartTable(1);
			IUseSkillCheckBase.AddType(builder, Type);
			return IUseSkillCheckBase.EndIUseSkillCheckBase(builder);
		}

		// Token: 0x0601A8DF RID: 108767 RVA: 0x003C721E File Offset: 0x003C541E
		public static void StartIUseSkillCheckBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601A8E0 RID: 108768 RVA: 0x003C7227 File Offset: 0x003C5427
		public static void AddType(FlatBufferBuilder builder, EUseSkillCheckType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A8E1 RID: 108769 RVA: 0x003C7232 File Offset: 0x003C5432
		public static Offset<IUseSkillCheckBase> EndIUseSkillCheckBase(FlatBufferBuilder builder)
		{
			return new Offset<IUseSkillCheckBase>(builder.EndTable());
		}

		// Token: 0x0601A8E2 RID: 108770 RVA: 0x003C7240 File Offset: 0x003C5440
		public IUseSkillCheckBaseT UnPack()
		{
			IUseSkillCheckBaseT useSkillCheckBaseT = new IUseSkillCheckBaseT();
			this.UnPackTo(useSkillCheckBaseT);
			return useSkillCheckBaseT;
		}

		// Token: 0x0601A8E3 RID: 108771 RVA: 0x003C725B File Offset: 0x003C545B
		public void UnPackTo(IUseSkillCheckBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601A8E4 RID: 108772 RVA: 0x003C726C File Offset: 0x003C546C
		public static Offset<IUseSkillCheckBase> Pack(FlatBufferBuilder builder, IUseSkillCheckBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUseSkillCheckBase>);
			}
			return IUseSkillCheckBase.CreateIUseSkillCheckBase(builder, _o.Type);
		}

		// Token: 0x0400C8D5 RID: 51413
		private Table __p;
	}
}
