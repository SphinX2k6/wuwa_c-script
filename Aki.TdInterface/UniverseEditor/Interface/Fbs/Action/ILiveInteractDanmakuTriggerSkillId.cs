using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007106 RID: 28934
	public struct ILiveInteractDanmakuTriggerSkillId : IFlatbufferObject
	{
		// Token: 0x1700D3E5 RID: 54245
		// (get) Token: 0x0603240B RID: 205835 RVA: 0x006CBC9A File Offset: 0x006C9E9A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603240C RID: 205836 RVA: 0x006CBCA7 File Offset: 0x006C9EA7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603240D RID: 205837 RVA: 0x006CBCB0 File Offset: 0x006C9EB0
		public static ILiveInteractDanmakuTriggerSkillId GetRootAsILiveInteractDanmakuTriggerSkillId(ByteBuffer _bb)
		{
			return ILiveInteractDanmakuTriggerSkillId.GetRootAsILiveInteractDanmakuTriggerSkillId(_bb, default(ILiveInteractDanmakuTriggerSkillId));
		}

		// Token: 0x0603240E RID: 205838 RVA: 0x006CBCCC File Offset: 0x006C9ECC
		public static ILiveInteractDanmakuTriggerSkillId GetRootAsILiveInteractDanmakuTriggerSkillId(ByteBuffer _bb, ILiveInteractDanmakuTriggerSkillId obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603240F RID: 205839 RVA: 0x006CBCE9 File Offset: 0x006C9EE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032410 RID: 205840 RVA: 0x006CBCF8 File Offset: 0x006C9EF8
		public ILiveInteractDanmakuTriggerSkillId __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D3E6 RID: 54246
		// (get) Token: 0x06032411 RID: 205841 RVA: 0x006CBD08 File Offset: 0x006C9F08
		public ELiveInteractDanmakuTriggerType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELiveInteractDanmakuTriggerType.SkillGenre;
				}
				return (ELiveInteractDanmakuTriggerType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D3E7 RID: 54247
		// (get) Token: 0x06032412 RID: 205842 RVA: 0x006CBD44 File Offset: 0x006C9F44
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

		// Token: 0x06032413 RID: 205843 RVA: 0x006CBD80 File Offset: 0x006C9F80
		public static Offset<ILiveInteractDanmakuTriggerSkillId> CreateILiveInteractDanmakuTriggerSkillId(FlatBufferBuilder builder, ELiveInteractDanmakuTriggerType Type = ELiveInteractDanmakuTriggerType.SkillGenre, int SkillId = 0)
		{
			builder.StartTable(2);
			ILiveInteractDanmakuTriggerSkillId.AddSkillId(builder, SkillId);
			ILiveInteractDanmakuTriggerSkillId.AddType(builder, Type);
			return ILiveInteractDanmakuTriggerSkillId.EndILiveInteractDanmakuTriggerSkillId(builder);
		}

		// Token: 0x06032414 RID: 205844 RVA: 0x006CBD9D File Offset: 0x006C9F9D
		public static void StartILiveInteractDanmakuTriggerSkillId(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06032415 RID: 205845 RVA: 0x006CBDA6 File Offset: 0x006C9FA6
		public static void AddType(FlatBufferBuilder builder, ELiveInteractDanmakuTriggerType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032416 RID: 205846 RVA: 0x006CBDB1 File Offset: 0x006C9FB1
		public static void AddSkillId(FlatBufferBuilder builder, int skillId)
		{
			builder.AddInt(1, skillId, 0);
		}

		// Token: 0x06032417 RID: 205847 RVA: 0x006CBDBC File Offset: 0x006C9FBC
		public static Offset<ILiveInteractDanmakuTriggerSkillId> EndILiveInteractDanmakuTriggerSkillId(FlatBufferBuilder builder)
		{
			return new Offset<ILiveInteractDanmakuTriggerSkillId>(builder.EndTable());
		}

		// Token: 0x06032418 RID: 205848 RVA: 0x006CBDCC File Offset: 0x006C9FCC
		public ILiveInteractDanmakuTriggerSkillIdT UnPack()
		{
			ILiveInteractDanmakuTriggerSkillIdT liveInteractDanmakuTriggerSkillIdT = new ILiveInteractDanmakuTriggerSkillIdT();
			this.UnPackTo(liveInteractDanmakuTriggerSkillIdT);
			return liveInteractDanmakuTriggerSkillIdT;
		}

		// Token: 0x06032419 RID: 205849 RVA: 0x006CBDE7 File Offset: 0x006C9FE7
		public void UnPackTo(ILiveInteractDanmakuTriggerSkillIdT _o)
		{
			_o.Type = this.Type;
			_o.SkillId = this.SkillId;
		}

		// Token: 0x0603241A RID: 205850 RVA: 0x006CBE04 File Offset: 0x006CA004
		public static Offset<ILiveInteractDanmakuTriggerSkillId> Pack(FlatBufferBuilder builder, ILiveInteractDanmakuTriggerSkillIdT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILiveInteractDanmakuTriggerSkillId>);
			}
			return ILiveInteractDanmakuTriggerSkillId.CreateILiveInteractDanmakuTriggerSkillId(builder, _o.Type, _o.SkillId);
		}

		// Token: 0x040120D9 RID: 73945
		private Table __p;
	}
}
