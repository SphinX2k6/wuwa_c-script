using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004253 RID: 16979
	public struct IUseSkillCheckByVisionShowId : IFlatbufferObject
	{
		// Token: 0x17007887 RID: 30855
		// (get) Token: 0x060191D3 RID: 102867 RVA: 0x0039C40E File Offset: 0x0039A60E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060191D4 RID: 102868 RVA: 0x0039C41B File Offset: 0x0039A61B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060191D5 RID: 102869 RVA: 0x0039C424 File Offset: 0x0039A624
		public static IUseSkillCheckByVisionShowId GetRootAsIUseSkillCheckByVisionShowId(ByteBuffer _bb)
		{
			return IUseSkillCheckByVisionShowId.GetRootAsIUseSkillCheckByVisionShowId(_bb, default(IUseSkillCheckByVisionShowId));
		}

		// Token: 0x060191D6 RID: 102870 RVA: 0x0039C440 File Offset: 0x0039A640
		public static IUseSkillCheckByVisionShowId GetRootAsIUseSkillCheckByVisionShowId(ByteBuffer _bb, IUseSkillCheckByVisionShowId obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060191D7 RID: 102871 RVA: 0x0039C45D File Offset: 0x0039A65D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060191D8 RID: 102872 RVA: 0x0039C46C File Offset: 0x0039A66C
		public IUseSkillCheckByVisionShowId __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007888 RID: 30856
		// (get) Token: 0x060191D9 RID: 102873 RVA: 0x0039C47C File Offset: 0x0039A67C
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

		// Token: 0x17007889 RID: 30857
		// (get) Token: 0x060191DA RID: 102874 RVA: 0x0039C4B8 File Offset: 0x0039A6B8
		public int VisionId
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

		// Token: 0x060191DB RID: 102875 RVA: 0x0039C4F4 File Offset: 0x0039A6F4
		public static Offset<IUseSkillCheckByVisionShowId> CreateIUseSkillCheckByVisionShowId(FlatBufferBuilder builder, EUseSkillCheckType Type = EUseSkillCheckType.CheckSkillGenre, int VisionId = 0)
		{
			builder.StartTable(2);
			IUseSkillCheckByVisionShowId.AddVisionId(builder, VisionId);
			IUseSkillCheckByVisionShowId.AddType(builder, Type);
			return IUseSkillCheckByVisionShowId.EndIUseSkillCheckByVisionShowId(builder);
		}

		// Token: 0x060191DC RID: 102876 RVA: 0x0039C511 File Offset: 0x0039A711
		public static void StartIUseSkillCheckByVisionShowId(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060191DD RID: 102877 RVA: 0x0039C51A File Offset: 0x0039A71A
		public static void AddType(FlatBufferBuilder builder, EUseSkillCheckType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060191DE RID: 102878 RVA: 0x0039C525 File Offset: 0x0039A725
		public static void AddVisionId(FlatBufferBuilder builder, int visionId)
		{
			builder.AddInt(1, visionId, 0);
		}

		// Token: 0x060191DF RID: 102879 RVA: 0x0039C530 File Offset: 0x0039A730
		public static Offset<IUseSkillCheckByVisionShowId> EndIUseSkillCheckByVisionShowId(FlatBufferBuilder builder)
		{
			return new Offset<IUseSkillCheckByVisionShowId>(builder.EndTable());
		}

		// Token: 0x060191E0 RID: 102880 RVA: 0x0039C540 File Offset: 0x0039A740
		public IUseSkillCheckByVisionShowIdT UnPack()
		{
			IUseSkillCheckByVisionShowIdT useSkillCheckByVisionShowIdT = new IUseSkillCheckByVisionShowIdT();
			this.UnPackTo(useSkillCheckByVisionShowIdT);
			return useSkillCheckByVisionShowIdT;
		}

		// Token: 0x060191E1 RID: 102881 RVA: 0x0039C55B File Offset: 0x0039A75B
		public void UnPackTo(IUseSkillCheckByVisionShowIdT _o)
		{
			_o.Type = this.Type;
			_o.VisionId = this.VisionId;
		}

		// Token: 0x060191E2 RID: 102882 RVA: 0x0039C578 File Offset: 0x0039A778
		public static Offset<IUseSkillCheckByVisionShowId> Pack(FlatBufferBuilder builder, IUseSkillCheckByVisionShowIdT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUseSkillCheckByVisionShowId>);
			}
			return IUseSkillCheckByVisionShowId.CreateIUseSkillCheckByVisionShowId(builder, _o.Type, _o.VisionId);
		}

		// Token: 0x0400BEDD RID: 48861
		private Table __p;
	}
}
