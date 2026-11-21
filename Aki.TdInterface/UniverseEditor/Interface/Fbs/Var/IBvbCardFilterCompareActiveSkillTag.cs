using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E14 RID: 15892
	public struct IBvbCardFilterCompareActiveSkillTag : IFlatbufferObject
	{
		// Token: 0x17006B52 RID: 27474
		// (get) Token: 0x060155D0 RID: 87504 RVA: 0x00316072 File Offset: 0x00314272
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060155D1 RID: 87505 RVA: 0x0031607F File Offset: 0x0031427F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060155D2 RID: 87506 RVA: 0x00316088 File Offset: 0x00314288
		public static IBvbCardFilterCompareActiveSkillTag GetRootAsIBvbCardFilterCompareActiveSkillTag(ByteBuffer _bb)
		{
			return IBvbCardFilterCompareActiveSkillTag.GetRootAsIBvbCardFilterCompareActiveSkillTag(_bb, default(IBvbCardFilterCompareActiveSkillTag));
		}

		// Token: 0x060155D3 RID: 87507 RVA: 0x003160A4 File Offset: 0x003142A4
		public static IBvbCardFilterCompareActiveSkillTag GetRootAsIBvbCardFilterCompareActiveSkillTag(ByteBuffer _bb, IBvbCardFilterCompareActiveSkillTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060155D4 RID: 87508 RVA: 0x003160C1 File Offset: 0x003142C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060155D5 RID: 87509 RVA: 0x003160D0 File Offset: 0x003142D0
		public IBvbCardFilterCompareActiveSkillTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006B53 RID: 27475
		// (get) Token: 0x060155D6 RID: 87510 RVA: 0x003160E0 File Offset: 0x003142E0
		public EBvbCardFilterType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBvbCardFilterType.CompareCost;
				}
				return (EBvbCardFilterType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006B54 RID: 27476
		// (get) Token: 0x060155D7 RID: 87511 RVA: 0x0031611C File Offset: 0x0031431C
		public int ActiveSkillTag
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

		// Token: 0x060155D8 RID: 87512 RVA: 0x00316158 File Offset: 0x00314358
		public static Offset<IBvbCardFilterCompareActiveSkillTag> CreateIBvbCardFilterCompareActiveSkillTag(FlatBufferBuilder builder, EBvbCardFilterType Type = EBvbCardFilterType.CompareCost, int ActiveSkillTag = 0)
		{
			builder.StartTable(2);
			IBvbCardFilterCompareActiveSkillTag.AddActiveSkillTag(builder, ActiveSkillTag);
			IBvbCardFilterCompareActiveSkillTag.AddType(builder, Type);
			return IBvbCardFilterCompareActiveSkillTag.EndIBvbCardFilterCompareActiveSkillTag(builder);
		}

		// Token: 0x060155D9 RID: 87513 RVA: 0x00316175 File Offset: 0x00314375
		public static void StartIBvbCardFilterCompareActiveSkillTag(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060155DA RID: 87514 RVA: 0x0031617E File Offset: 0x0031437E
		public static void AddType(FlatBufferBuilder builder, EBvbCardFilterType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060155DB RID: 87515 RVA: 0x00316189 File Offset: 0x00314389
		public static void AddActiveSkillTag(FlatBufferBuilder builder, int activeSkillTag)
		{
			builder.AddInt(1, activeSkillTag, 0);
		}

		// Token: 0x060155DC RID: 87516 RVA: 0x00316194 File Offset: 0x00314394
		public static Offset<IBvbCardFilterCompareActiveSkillTag> EndIBvbCardFilterCompareActiveSkillTag(FlatBufferBuilder builder)
		{
			return new Offset<IBvbCardFilterCompareActiveSkillTag>(builder.EndTable());
		}

		// Token: 0x060155DD RID: 87517 RVA: 0x003161A4 File Offset: 0x003143A4
		public IBvbCardFilterCompareActiveSkillTagT UnPack()
		{
			IBvbCardFilterCompareActiveSkillTagT bvbCardFilterCompareActiveSkillTagT = new IBvbCardFilterCompareActiveSkillTagT();
			this.UnPackTo(bvbCardFilterCompareActiveSkillTagT);
			return bvbCardFilterCompareActiveSkillTagT;
		}

		// Token: 0x060155DE RID: 87518 RVA: 0x003161BF File Offset: 0x003143BF
		public void UnPackTo(IBvbCardFilterCompareActiveSkillTagT _o)
		{
			_o.Type = this.Type;
			_o.ActiveSkillTag = this.ActiveSkillTag;
		}

		// Token: 0x060155DF RID: 87519 RVA: 0x003161DC File Offset: 0x003143DC
		public static Offset<IBvbCardFilterCompareActiveSkillTag> Pack(FlatBufferBuilder builder, IBvbCardFilterCompareActiveSkillTagT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbCardFilterCompareActiveSkillTag>);
			}
			return IBvbCardFilterCompareActiveSkillTag.CreateIBvbCardFilterCompareActiveSkillTag(builder, _o.Type, _o.ActiveSkillTag);
		}

		// Token: 0x0400B7DA RID: 47066
		private Table __p;
	}
}
