using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A39 RID: 14905
	public struct IBvbCardFilterCompareActiveSkillTag : IFlatbufferObject
	{
		// Token: 0x17006622 RID: 26146
		// (get) Token: 0x060142B4 RID: 82612 RVA: 0x002F2E86 File Offset: 0x002F1086
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060142B5 RID: 82613 RVA: 0x002F2E93 File Offset: 0x002F1093
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060142B6 RID: 82614 RVA: 0x002F2E9C File Offset: 0x002F109C
		public static IBvbCardFilterCompareActiveSkillTag GetRootAsIBvbCardFilterCompareActiveSkillTag(ByteBuffer _bb)
		{
			return IBvbCardFilterCompareActiveSkillTag.GetRootAsIBvbCardFilterCompareActiveSkillTag(_bb, default(IBvbCardFilterCompareActiveSkillTag));
		}

		// Token: 0x060142B7 RID: 82615 RVA: 0x002F2EB8 File Offset: 0x002F10B8
		public static IBvbCardFilterCompareActiveSkillTag GetRootAsIBvbCardFilterCompareActiveSkillTag(ByteBuffer _bb, IBvbCardFilterCompareActiveSkillTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060142B8 RID: 82616 RVA: 0x002F2ED5 File Offset: 0x002F10D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060142B9 RID: 82617 RVA: 0x002F2EE4 File Offset: 0x002F10E4
		public IBvbCardFilterCompareActiveSkillTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006623 RID: 26147
		// (get) Token: 0x060142BA RID: 82618 RVA: 0x002F2EF4 File Offset: 0x002F10F4
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

		// Token: 0x17006624 RID: 26148
		// (get) Token: 0x060142BB RID: 82619 RVA: 0x002F2F30 File Offset: 0x002F1130
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

		// Token: 0x060142BC RID: 82620 RVA: 0x002F2F6C File Offset: 0x002F116C
		public static Offset<IBvbCardFilterCompareActiveSkillTag> CreateIBvbCardFilterCompareActiveSkillTag(FlatBufferBuilder builder, EBvbCardFilterType Type = EBvbCardFilterType.CompareCost, int ActiveSkillTag = 0)
		{
			builder.StartTable(2);
			IBvbCardFilterCompareActiveSkillTag.AddActiveSkillTag(builder, ActiveSkillTag);
			IBvbCardFilterCompareActiveSkillTag.AddType(builder, Type);
			return IBvbCardFilterCompareActiveSkillTag.EndIBvbCardFilterCompareActiveSkillTag(builder);
		}

		// Token: 0x060142BD RID: 82621 RVA: 0x002F2F89 File Offset: 0x002F1189
		public static void StartIBvbCardFilterCompareActiveSkillTag(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060142BE RID: 82622 RVA: 0x002F2F92 File Offset: 0x002F1192
		public static void AddType(FlatBufferBuilder builder, EBvbCardFilterType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060142BF RID: 82623 RVA: 0x002F2F9D File Offset: 0x002F119D
		public static void AddActiveSkillTag(FlatBufferBuilder builder, int activeSkillTag)
		{
			builder.AddInt(1, activeSkillTag, 0);
		}

		// Token: 0x060142C0 RID: 82624 RVA: 0x002F2FA8 File Offset: 0x002F11A8
		public static Offset<IBvbCardFilterCompareActiveSkillTag> EndIBvbCardFilterCompareActiveSkillTag(FlatBufferBuilder builder)
		{
			return new Offset<IBvbCardFilterCompareActiveSkillTag>(builder.EndTable());
		}

		// Token: 0x060142C1 RID: 82625 RVA: 0x002F2FB8 File Offset: 0x002F11B8
		public IBvbCardFilterCompareActiveSkillTagT UnPack()
		{
			IBvbCardFilterCompareActiveSkillTagT bvbCardFilterCompareActiveSkillTagT = new IBvbCardFilterCompareActiveSkillTagT();
			this.UnPackTo(bvbCardFilterCompareActiveSkillTagT);
			return bvbCardFilterCompareActiveSkillTagT;
		}

		// Token: 0x060142C2 RID: 82626 RVA: 0x002F2FD3 File Offset: 0x002F11D3
		public void UnPackTo(IBvbCardFilterCompareActiveSkillTagT _o)
		{
			_o.Type = this.Type;
			_o.ActiveSkillTag = this.ActiveSkillTag;
		}

		// Token: 0x060142C3 RID: 82627 RVA: 0x002F2FF0 File Offset: 0x002F11F0
		public static Offset<IBvbCardFilterCompareActiveSkillTag> Pack(FlatBufferBuilder builder, IBvbCardFilterCompareActiveSkillTagT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbCardFilterCompareActiveSkillTag>);
			}
			return IBvbCardFilterCompareActiveSkillTag.CreateIBvbCardFilterCompareActiveSkillTag(builder, _o.Type, _o.ActiveSkillTag);
		}

		// Token: 0x0400AEB8 RID: 44728
		private Table __p;
	}
}
