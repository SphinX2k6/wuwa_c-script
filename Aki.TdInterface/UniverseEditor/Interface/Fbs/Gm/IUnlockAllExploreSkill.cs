using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x020046CC RID: 18124
	public struct IUnlockAllExploreSkill : IFlatbufferObject
	{
		// Token: 0x170080C7 RID: 32967
		// (get) Token: 0x0601B8DB RID: 112859 RVA: 0x003E8BB9 File Offset: 0x003E6DB9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B8DC RID: 112860 RVA: 0x003E8BC6 File Offset: 0x003E6DC6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B8DD RID: 112861 RVA: 0x003E8BD0 File Offset: 0x003E6DD0
		public static IUnlockAllExploreSkill GetRootAsIUnlockAllExploreSkill(ByteBuffer _bb)
		{
			return IUnlockAllExploreSkill.GetRootAsIUnlockAllExploreSkill(_bb, default(IUnlockAllExploreSkill));
		}

		// Token: 0x0601B8DE RID: 112862 RVA: 0x003E8BEC File Offset: 0x003E6DEC
		public static IUnlockAllExploreSkill GetRootAsIUnlockAllExploreSkill(ByteBuffer _bb, IUnlockAllExploreSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B8DF RID: 112863 RVA: 0x003E8C09 File Offset: 0x003E6E09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B8E0 RID: 112864 RVA: 0x003E8C18 File Offset: 0x003E6E18
		public IUnlockAllExploreSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170080C8 RID: 32968
		// (get) Token: 0x0601B8E1 RID: 112865 RVA: 0x003E8C28 File Offset: 0x003E6E28
		public EGmCommand Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGmCommand.SkipToLevelPlayNode;
				}
				return (EGmCommand)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B8E2 RID: 112866 RVA: 0x003E8C64 File Offset: 0x003E6E64
		public static Offset<IUnlockAllExploreSkill> CreateIUnlockAllExploreSkill(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode)
		{
			builder.StartTable(1);
			IUnlockAllExploreSkill.AddType(builder, Type);
			return IUnlockAllExploreSkill.EndIUnlockAllExploreSkill(builder);
		}

		// Token: 0x0601B8E3 RID: 112867 RVA: 0x003E8C7A File Offset: 0x003E6E7A
		public static void StartIUnlockAllExploreSkill(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601B8E4 RID: 112868 RVA: 0x003E8C83 File Offset: 0x003E6E83
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B8E5 RID: 112869 RVA: 0x003E8C8E File Offset: 0x003E6E8E
		public static Offset<IUnlockAllExploreSkill> EndIUnlockAllExploreSkill(FlatBufferBuilder builder)
		{
			return new Offset<IUnlockAllExploreSkill>(builder.EndTable());
		}

		// Token: 0x0601B8E6 RID: 112870 RVA: 0x003E8C9C File Offset: 0x003E6E9C
		public IUnlockAllExploreSkillT UnPack()
		{
			IUnlockAllExploreSkillT unlockAllExploreSkillT = new IUnlockAllExploreSkillT();
			this.UnPackTo(unlockAllExploreSkillT);
			return unlockAllExploreSkillT;
		}

		// Token: 0x0601B8E7 RID: 112871 RVA: 0x003E8CB7 File Offset: 0x003E6EB7
		public void UnPackTo(IUnlockAllExploreSkillT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601B8E8 RID: 112872 RVA: 0x003E8CC8 File Offset: 0x003E6EC8
		public static Offset<IUnlockAllExploreSkill> Pack(FlatBufferBuilder builder, IUnlockAllExploreSkillT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUnlockAllExploreSkill>);
			}
			return IUnlockAllExploreSkill.CreateIUnlockAllExploreSkill(builder, _o.Type);
		}

		// Token: 0x0400C89F RID: 51359
		private Table __p;
	}
}
