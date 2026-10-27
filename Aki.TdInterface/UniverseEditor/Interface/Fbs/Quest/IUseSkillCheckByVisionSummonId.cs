using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004256 RID: 16982
	public struct IUseSkillCheckByVisionSummonId : IFlatbufferObject
	{
		// Token: 0x1700788C RID: 30860
		// (get) Token: 0x060191E9 RID: 102889 RVA: 0x0039C60E File Offset: 0x0039A80E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060191EA RID: 102890 RVA: 0x0039C61B File Offset: 0x0039A81B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060191EB RID: 102891 RVA: 0x0039C624 File Offset: 0x0039A824
		public static IUseSkillCheckByVisionSummonId GetRootAsIUseSkillCheckByVisionSummonId(ByteBuffer _bb)
		{
			return IUseSkillCheckByVisionSummonId.GetRootAsIUseSkillCheckByVisionSummonId(_bb, default(IUseSkillCheckByVisionSummonId));
		}

		// Token: 0x060191EC RID: 102892 RVA: 0x0039C640 File Offset: 0x0039A840
		public static IUseSkillCheckByVisionSummonId GetRootAsIUseSkillCheckByVisionSummonId(ByteBuffer _bb, IUseSkillCheckByVisionSummonId obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060191ED RID: 102893 RVA: 0x0039C65D File Offset: 0x0039A85D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060191EE RID: 102894 RVA: 0x0039C66C File Offset: 0x0039A86C
		public IUseSkillCheckByVisionSummonId __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700788D RID: 30861
		// (get) Token: 0x060191EF RID: 102895 RVA: 0x0039C67C File Offset: 0x0039A87C
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

		// Token: 0x1700788E RID: 30862
		// (get) Token: 0x060191F0 RID: 102896 RVA: 0x0039C6B8 File Offset: 0x0039A8B8
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

		// Token: 0x060191F1 RID: 102897 RVA: 0x0039C6F4 File Offset: 0x0039A8F4
		public static Offset<IUseSkillCheckByVisionSummonId> CreateIUseSkillCheckByVisionSummonId(FlatBufferBuilder builder, EUseSkillCheckType Type = EUseSkillCheckType.CheckSkillGenre, int VisionId = 0)
		{
			builder.StartTable(2);
			IUseSkillCheckByVisionSummonId.AddVisionId(builder, VisionId);
			IUseSkillCheckByVisionSummonId.AddType(builder, Type);
			return IUseSkillCheckByVisionSummonId.EndIUseSkillCheckByVisionSummonId(builder);
		}

		// Token: 0x060191F2 RID: 102898 RVA: 0x0039C711 File Offset: 0x0039A911
		public static void StartIUseSkillCheckByVisionSummonId(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060191F3 RID: 102899 RVA: 0x0039C71A File Offset: 0x0039A91A
		public static void AddType(FlatBufferBuilder builder, EUseSkillCheckType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060191F4 RID: 102900 RVA: 0x0039C725 File Offset: 0x0039A925
		public static void AddVisionId(FlatBufferBuilder builder, int visionId)
		{
			builder.AddInt(1, visionId, 0);
		}

		// Token: 0x060191F5 RID: 102901 RVA: 0x0039C730 File Offset: 0x0039A930
		public static Offset<IUseSkillCheckByVisionSummonId> EndIUseSkillCheckByVisionSummonId(FlatBufferBuilder builder)
		{
			return new Offset<IUseSkillCheckByVisionSummonId>(builder.EndTable());
		}

		// Token: 0x060191F6 RID: 102902 RVA: 0x0039C740 File Offset: 0x0039A940
		public IUseSkillCheckByVisionSummonIdT UnPack()
		{
			IUseSkillCheckByVisionSummonIdT useSkillCheckByVisionSummonIdT = new IUseSkillCheckByVisionSummonIdT();
			this.UnPackTo(useSkillCheckByVisionSummonIdT);
			return useSkillCheckByVisionSummonIdT;
		}

		// Token: 0x060191F7 RID: 102903 RVA: 0x0039C75B File Offset: 0x0039A95B
		public void UnPackTo(IUseSkillCheckByVisionSummonIdT _o)
		{
			_o.Type = this.Type;
			_o.VisionId = this.VisionId;
		}

		// Token: 0x060191F8 RID: 102904 RVA: 0x0039C778 File Offset: 0x0039A978
		public static Offset<IUseSkillCheckByVisionSummonId> Pack(FlatBufferBuilder builder, IUseSkillCheckByVisionSummonIdT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUseSkillCheckByVisionSummonId>);
			}
			return IUseSkillCheckByVisionSummonId.CreateIUseSkillCheckByVisionSummonId(builder, _o.Type, _o.VisionId);
		}

		// Token: 0x0400BEE0 RID: 48864
		private Table __p;
	}
}
