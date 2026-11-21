using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046B2 RID: 18098
	public struct IUseSkillCheckByVisionSummonId : IFlatbufferObject
	{
		// Token: 0x17007EBD RID: 32445
		// (get) Token: 0x0601A955 RID: 108885 RVA: 0x003C7CE6 File Offset: 0x003C5EE6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A956 RID: 108886 RVA: 0x003C7CF3 File Offset: 0x003C5EF3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A957 RID: 108887 RVA: 0x003C7CFC File Offset: 0x003C5EFC
		public static IUseSkillCheckByVisionSummonId GetRootAsIUseSkillCheckByVisionSummonId(ByteBuffer _bb)
		{
			return IUseSkillCheckByVisionSummonId.GetRootAsIUseSkillCheckByVisionSummonId(_bb, default(IUseSkillCheckByVisionSummonId));
		}

		// Token: 0x0601A958 RID: 108888 RVA: 0x003C7D18 File Offset: 0x003C5F18
		public static IUseSkillCheckByVisionSummonId GetRootAsIUseSkillCheckByVisionSummonId(ByteBuffer _bb, IUseSkillCheckByVisionSummonId obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A959 RID: 108889 RVA: 0x003C7D35 File Offset: 0x003C5F35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A95A RID: 108890 RVA: 0x003C7D44 File Offset: 0x003C5F44
		public IUseSkillCheckByVisionSummonId __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007EBE RID: 32446
		// (get) Token: 0x0601A95B RID: 108891 RVA: 0x003C7D54 File Offset: 0x003C5F54
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

		// Token: 0x17007EBF RID: 32447
		// (get) Token: 0x0601A95C RID: 108892 RVA: 0x003C7D90 File Offset: 0x003C5F90
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

		// Token: 0x0601A95D RID: 108893 RVA: 0x003C7DCC File Offset: 0x003C5FCC
		public static Offset<IUseSkillCheckByVisionSummonId> CreateIUseSkillCheckByVisionSummonId(FlatBufferBuilder builder, EUseSkillCheckType Type = EUseSkillCheckType.CheckSkillGenre, int VisionId = 0)
		{
			builder.StartTable(2);
			IUseSkillCheckByVisionSummonId.AddVisionId(builder, VisionId);
			IUseSkillCheckByVisionSummonId.AddType(builder, Type);
			return IUseSkillCheckByVisionSummonId.EndIUseSkillCheckByVisionSummonId(builder);
		}

		// Token: 0x0601A95E RID: 108894 RVA: 0x003C7DE9 File Offset: 0x003C5FE9
		public static void StartIUseSkillCheckByVisionSummonId(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601A95F RID: 108895 RVA: 0x003C7DF2 File Offset: 0x003C5FF2
		public static void AddType(FlatBufferBuilder builder, EUseSkillCheckType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A960 RID: 108896 RVA: 0x003C7DFD File Offset: 0x003C5FFD
		public static void AddVisionId(FlatBufferBuilder builder, int visionId)
		{
			builder.AddInt(1, visionId, 0);
		}

		// Token: 0x0601A961 RID: 108897 RVA: 0x003C7E08 File Offset: 0x003C6008
		public static Offset<IUseSkillCheckByVisionSummonId> EndIUseSkillCheckByVisionSummonId(FlatBufferBuilder builder)
		{
			return new Offset<IUseSkillCheckByVisionSummonId>(builder.EndTable());
		}

		// Token: 0x0601A962 RID: 108898 RVA: 0x003C7E18 File Offset: 0x003C6018
		public IUseSkillCheckByVisionSummonIdT UnPack()
		{
			IUseSkillCheckByVisionSummonIdT useSkillCheckByVisionSummonIdT = new IUseSkillCheckByVisionSummonIdT();
			this.UnPackTo(useSkillCheckByVisionSummonIdT);
			return useSkillCheckByVisionSummonIdT;
		}

		// Token: 0x0601A963 RID: 108899 RVA: 0x003C7E33 File Offset: 0x003C6033
		public void UnPackTo(IUseSkillCheckByVisionSummonIdT _o)
		{
			_o.Type = this.Type;
			_o.VisionId = this.VisionId;
		}

		// Token: 0x0601A964 RID: 108900 RVA: 0x003C7E50 File Offset: 0x003C6050
		public static Offset<IUseSkillCheckByVisionSummonId> Pack(FlatBufferBuilder builder, IUseSkillCheckByVisionSummonIdT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUseSkillCheckByVisionSummonId>);
			}
			return IUseSkillCheckByVisionSummonId.CreateIUseSkillCheckByVisionSummonId(builder, _o.Type, _o.VisionId);
		}

		// Token: 0x0400C8ED RID: 51437
		private Table __p;
	}
}
