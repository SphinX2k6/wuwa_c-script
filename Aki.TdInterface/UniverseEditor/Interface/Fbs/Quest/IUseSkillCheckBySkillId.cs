using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046AC RID: 18092
	public struct IUseSkillCheckBySkillId : IFlatbufferObject
	{
		// Token: 0x17007EB3 RID: 32435
		// (get) Token: 0x0601A929 RID: 108841 RVA: 0x003C78E6 File Offset: 0x003C5AE6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A92A RID: 108842 RVA: 0x003C78F3 File Offset: 0x003C5AF3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A92B RID: 108843 RVA: 0x003C78FC File Offset: 0x003C5AFC
		public static IUseSkillCheckBySkillId GetRootAsIUseSkillCheckBySkillId(ByteBuffer _bb)
		{
			return IUseSkillCheckBySkillId.GetRootAsIUseSkillCheckBySkillId(_bb, default(IUseSkillCheckBySkillId));
		}

		// Token: 0x0601A92C RID: 108844 RVA: 0x003C7918 File Offset: 0x003C5B18
		public static IUseSkillCheckBySkillId GetRootAsIUseSkillCheckBySkillId(ByteBuffer _bb, IUseSkillCheckBySkillId obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A92D RID: 108845 RVA: 0x003C7935 File Offset: 0x003C5B35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A92E RID: 108846 RVA: 0x003C7944 File Offset: 0x003C5B44
		public IUseSkillCheckBySkillId __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007EB4 RID: 32436
		// (get) Token: 0x0601A92F RID: 108847 RVA: 0x003C7954 File Offset: 0x003C5B54
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

		// Token: 0x17007EB5 RID: 32437
		// (get) Token: 0x0601A930 RID: 108848 RVA: 0x003C7990 File Offset: 0x003C5B90
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

		// Token: 0x0601A931 RID: 108849 RVA: 0x003C79CC File Offset: 0x003C5BCC
		public static Offset<IUseSkillCheckBySkillId> CreateIUseSkillCheckBySkillId(FlatBufferBuilder builder, EUseSkillCheckType Type = EUseSkillCheckType.CheckSkillGenre, int SkillId = 0)
		{
			builder.StartTable(2);
			IUseSkillCheckBySkillId.AddSkillId(builder, SkillId);
			IUseSkillCheckBySkillId.AddType(builder, Type);
			return IUseSkillCheckBySkillId.EndIUseSkillCheckBySkillId(builder);
		}

		// Token: 0x0601A932 RID: 108850 RVA: 0x003C79E9 File Offset: 0x003C5BE9
		public static void StartIUseSkillCheckBySkillId(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601A933 RID: 108851 RVA: 0x003C79F2 File Offset: 0x003C5BF2
		public static void AddType(FlatBufferBuilder builder, EUseSkillCheckType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A934 RID: 108852 RVA: 0x003C79FD File Offset: 0x003C5BFD
		public static void AddSkillId(FlatBufferBuilder builder, int skillId)
		{
			builder.AddInt(1, skillId, 0);
		}

		// Token: 0x0601A935 RID: 108853 RVA: 0x003C7A08 File Offset: 0x003C5C08
		public static Offset<IUseSkillCheckBySkillId> EndIUseSkillCheckBySkillId(FlatBufferBuilder builder)
		{
			return new Offset<IUseSkillCheckBySkillId>(builder.EndTable());
		}

		// Token: 0x0601A936 RID: 108854 RVA: 0x003C7A18 File Offset: 0x003C5C18
		public IUseSkillCheckBySkillIdT UnPack()
		{
			IUseSkillCheckBySkillIdT useSkillCheckBySkillIdT = new IUseSkillCheckBySkillIdT();
			this.UnPackTo(useSkillCheckBySkillIdT);
			return useSkillCheckBySkillIdT;
		}

		// Token: 0x0601A937 RID: 108855 RVA: 0x003C7A33 File Offset: 0x003C5C33
		public void UnPackTo(IUseSkillCheckBySkillIdT _o)
		{
			_o.Type = this.Type;
			_o.SkillId = this.SkillId;
		}

		// Token: 0x0601A938 RID: 108856 RVA: 0x003C7A50 File Offset: 0x003C5C50
		public static Offset<IUseSkillCheckBySkillId> Pack(FlatBufferBuilder builder, IUseSkillCheckBySkillIdT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUseSkillCheckBySkillId>);
			}
			return IUseSkillCheckBySkillId.CreateIUseSkillCheckBySkillId(builder, _o.Type, _o.SkillId);
		}

		// Token: 0x0400C8E7 RID: 51431
		private Table __p;
	}
}
