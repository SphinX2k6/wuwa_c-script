using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046AF RID: 18095
	public struct IUseSkillCheckByVisionShowId : IFlatbufferObject
	{
		// Token: 0x17007EB8 RID: 32440
		// (get) Token: 0x0601A93F RID: 108863 RVA: 0x003C7AE6 File Offset: 0x003C5CE6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A940 RID: 108864 RVA: 0x003C7AF3 File Offset: 0x003C5CF3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A941 RID: 108865 RVA: 0x003C7AFC File Offset: 0x003C5CFC
		public static IUseSkillCheckByVisionShowId GetRootAsIUseSkillCheckByVisionShowId(ByteBuffer _bb)
		{
			return IUseSkillCheckByVisionShowId.GetRootAsIUseSkillCheckByVisionShowId(_bb, default(IUseSkillCheckByVisionShowId));
		}

		// Token: 0x0601A942 RID: 108866 RVA: 0x003C7B18 File Offset: 0x003C5D18
		public static IUseSkillCheckByVisionShowId GetRootAsIUseSkillCheckByVisionShowId(ByteBuffer _bb, IUseSkillCheckByVisionShowId obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A943 RID: 108867 RVA: 0x003C7B35 File Offset: 0x003C5D35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A944 RID: 108868 RVA: 0x003C7B44 File Offset: 0x003C5D44
		public IUseSkillCheckByVisionShowId __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007EB9 RID: 32441
		// (get) Token: 0x0601A945 RID: 108869 RVA: 0x003C7B54 File Offset: 0x003C5D54
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

		// Token: 0x17007EBA RID: 32442
		// (get) Token: 0x0601A946 RID: 108870 RVA: 0x003C7B90 File Offset: 0x003C5D90
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

		// Token: 0x0601A947 RID: 108871 RVA: 0x003C7BCC File Offset: 0x003C5DCC
		public static Offset<IUseSkillCheckByVisionShowId> CreateIUseSkillCheckByVisionShowId(FlatBufferBuilder builder, EUseSkillCheckType Type = EUseSkillCheckType.CheckSkillGenre, int VisionId = 0)
		{
			builder.StartTable(2);
			IUseSkillCheckByVisionShowId.AddVisionId(builder, VisionId);
			IUseSkillCheckByVisionShowId.AddType(builder, Type);
			return IUseSkillCheckByVisionShowId.EndIUseSkillCheckByVisionShowId(builder);
		}

		// Token: 0x0601A948 RID: 108872 RVA: 0x003C7BE9 File Offset: 0x003C5DE9
		public static void StartIUseSkillCheckByVisionShowId(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601A949 RID: 108873 RVA: 0x003C7BF2 File Offset: 0x003C5DF2
		public static void AddType(FlatBufferBuilder builder, EUseSkillCheckType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A94A RID: 108874 RVA: 0x003C7BFD File Offset: 0x003C5DFD
		public static void AddVisionId(FlatBufferBuilder builder, int visionId)
		{
			builder.AddInt(1, visionId, 0);
		}

		// Token: 0x0601A94B RID: 108875 RVA: 0x003C7C08 File Offset: 0x003C5E08
		public static Offset<IUseSkillCheckByVisionShowId> EndIUseSkillCheckByVisionShowId(FlatBufferBuilder builder)
		{
			return new Offset<IUseSkillCheckByVisionShowId>(builder.EndTable());
		}

		// Token: 0x0601A94C RID: 108876 RVA: 0x003C7C18 File Offset: 0x003C5E18
		public IUseSkillCheckByVisionShowIdT UnPack()
		{
			IUseSkillCheckByVisionShowIdT useSkillCheckByVisionShowIdT = new IUseSkillCheckByVisionShowIdT();
			this.UnPackTo(useSkillCheckByVisionShowIdT);
			return useSkillCheckByVisionShowIdT;
		}

		// Token: 0x0601A94D RID: 108877 RVA: 0x003C7C33 File Offset: 0x003C5E33
		public void UnPackTo(IUseSkillCheckByVisionShowIdT _o)
		{
			_o.Type = this.Type;
			_o.VisionId = this.VisionId;
		}

		// Token: 0x0601A94E RID: 108878 RVA: 0x003C7C50 File Offset: 0x003C5E50
		public static Offset<IUseSkillCheckByVisionShowId> Pack(FlatBufferBuilder builder, IUseSkillCheckByVisionShowIdT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUseSkillCheckByVisionShowId>);
			}
			return IUseSkillCheckByVisionShowId.CreateIUseSkillCheckByVisionShowId(builder, _o.Type, _o.VisionId);
		}

		// Token: 0x0400C8EA RID: 51434
		private Table __p;
	}
}
