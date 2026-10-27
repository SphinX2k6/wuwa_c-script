using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004250 RID: 16976
	public struct IUseSkillCheckBySkillId : IFlatbufferObject
	{
		// Token: 0x17007882 RID: 30850
		// (get) Token: 0x060191BD RID: 102845 RVA: 0x0039C20E File Offset: 0x0039A40E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060191BE RID: 102846 RVA: 0x0039C21B File Offset: 0x0039A41B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060191BF RID: 102847 RVA: 0x0039C224 File Offset: 0x0039A424
		public static IUseSkillCheckBySkillId GetRootAsIUseSkillCheckBySkillId(ByteBuffer _bb)
		{
			return IUseSkillCheckBySkillId.GetRootAsIUseSkillCheckBySkillId(_bb, default(IUseSkillCheckBySkillId));
		}

		// Token: 0x060191C0 RID: 102848 RVA: 0x0039C240 File Offset: 0x0039A440
		public static IUseSkillCheckBySkillId GetRootAsIUseSkillCheckBySkillId(ByteBuffer _bb, IUseSkillCheckBySkillId obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060191C1 RID: 102849 RVA: 0x0039C25D File Offset: 0x0039A45D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060191C2 RID: 102850 RVA: 0x0039C26C File Offset: 0x0039A46C
		public IUseSkillCheckBySkillId __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007883 RID: 30851
		// (get) Token: 0x060191C3 RID: 102851 RVA: 0x0039C27C File Offset: 0x0039A47C
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

		// Token: 0x17007884 RID: 30852
		// (get) Token: 0x060191C4 RID: 102852 RVA: 0x0039C2B8 File Offset: 0x0039A4B8
		public int SkillId
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

		// Token: 0x060191C5 RID: 102853 RVA: 0x0039C2F4 File Offset: 0x0039A4F4
		public static Offset<IUseSkillCheckBySkillId> CreateIUseSkillCheckBySkillId(FlatBufferBuilder builder, EUseSkillCheckType Type = EUseSkillCheckType.CheckSkillGenre, int SkillId = 0)
		{
			builder.StartTable(2);
			IUseSkillCheckBySkillId.AddSkillId(builder, SkillId);
			IUseSkillCheckBySkillId.AddType(builder, Type);
			return IUseSkillCheckBySkillId.EndIUseSkillCheckBySkillId(builder);
		}

		// Token: 0x060191C6 RID: 102854 RVA: 0x0039C311 File Offset: 0x0039A511
		public static void StartIUseSkillCheckBySkillId(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060191C7 RID: 102855 RVA: 0x0039C31A File Offset: 0x0039A51A
		public static void AddType(FlatBufferBuilder builder, EUseSkillCheckType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060191C8 RID: 102856 RVA: 0x0039C325 File Offset: 0x0039A525
		public static void AddSkillId(FlatBufferBuilder builder, int skillId)
		{
			builder.AddInt(1, skillId, 0);
		}

		// Token: 0x060191C9 RID: 102857 RVA: 0x0039C330 File Offset: 0x0039A530
		public static Offset<IUseSkillCheckBySkillId> EndIUseSkillCheckBySkillId(FlatBufferBuilder builder)
		{
			return new Offset<IUseSkillCheckBySkillId>(builder.EndTable());
		}

		// Token: 0x060191CA RID: 102858 RVA: 0x0039C340 File Offset: 0x0039A540
		public IUseSkillCheckBySkillIdT UnPack()
		{
			IUseSkillCheckBySkillIdT useSkillCheckBySkillIdT = new IUseSkillCheckBySkillIdT();
			this.UnPackTo(useSkillCheckBySkillIdT);
			return useSkillCheckBySkillIdT;
		}

		// Token: 0x060191CB RID: 102859 RVA: 0x0039C35B File Offset: 0x0039A55B
		public void UnPackTo(IUseSkillCheckBySkillIdT _o)
		{
			_o.Type = this.Type;
			_o.SkillId = this.SkillId;
		}

		// Token: 0x060191CC RID: 102860 RVA: 0x0039C378 File Offset: 0x0039A578
		public static Offset<IUseSkillCheckBySkillId> Pack(FlatBufferBuilder builder, IUseSkillCheckBySkillIdT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUseSkillCheckBySkillId>);
			}
			return IUseSkillCheckBySkillId.CreateIUseSkillCheckBySkillId(builder, _o.Type, _o.SkillId);
		}

		// Token: 0x0400BEDA RID: 48858
		private Table __p;
	}
}
