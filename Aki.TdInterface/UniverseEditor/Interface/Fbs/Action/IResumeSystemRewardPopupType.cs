using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200764B RID: 30283
	public struct IResumeSystemRewardPopupType : IFlatbufferObject
	{
		// Token: 0x1700DE64 RID: 56932
		// (get) Token: 0x06035227 RID: 217639 RVA: 0x0072267F File Offset: 0x0072087F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035228 RID: 217640 RVA: 0x0072268C File Offset: 0x0072088C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035229 RID: 217641 RVA: 0x00722694 File Offset: 0x00720894
		public static IResumeSystemRewardPopupType GetRootAsIResumeSystemRewardPopupType(ByteBuffer _bb)
		{
			return IResumeSystemRewardPopupType.GetRootAsIResumeSystemRewardPopupType(_bb, default(IResumeSystemRewardPopupType));
		}

		// Token: 0x0603522A RID: 217642 RVA: 0x007226B0 File Offset: 0x007208B0
		public static IResumeSystemRewardPopupType GetRootAsIResumeSystemRewardPopupType(ByteBuffer _bb, IResumeSystemRewardPopupType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603522B RID: 217643 RVA: 0x007226CD File Offset: 0x007208CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603522C RID: 217644 RVA: 0x007226DC File Offset: 0x007208DC
		public IResumeSystemRewardPopupType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DE65 RID: 56933
		// (get) Token: 0x0603522D RID: 217645 RVA: 0x007226EC File Offset: 0x007208EC
		public ESystemType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESystemType.Shop;
				}
				return (ESystemType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603522E RID: 217646 RVA: 0x00722728 File Offset: 0x00720928
		public static Offset<IResumeSystemRewardPopupType> CreateIResumeSystemRewardPopupType(FlatBufferBuilder builder, ESystemType Type = ESystemType.Shop)
		{
			builder.StartTable(1);
			IResumeSystemRewardPopupType.AddType(builder, Type);
			return IResumeSystemRewardPopupType.EndIResumeSystemRewardPopupType(builder);
		}

		// Token: 0x0603522F RID: 217647 RVA: 0x0072273E File Offset: 0x0072093E
		public static void StartIResumeSystemRewardPopupType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035230 RID: 217648 RVA: 0x00722747 File Offset: 0x00720947
		public static void AddType(FlatBufferBuilder builder, ESystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035231 RID: 217649 RVA: 0x00722752 File Offset: 0x00720952
		public static Offset<IResumeSystemRewardPopupType> EndIResumeSystemRewardPopupType(FlatBufferBuilder builder)
		{
			return new Offset<IResumeSystemRewardPopupType>(builder.EndTable());
		}

		// Token: 0x06035232 RID: 217650 RVA: 0x00722760 File Offset: 0x00720960
		public IResumeSystemRewardPopupTypeT UnPack()
		{
			IResumeSystemRewardPopupTypeT resumeSystemRewardPopupTypeT = new IResumeSystemRewardPopupTypeT();
			this.UnPackTo(resumeSystemRewardPopupTypeT);
			return resumeSystemRewardPopupTypeT;
		}

		// Token: 0x06035233 RID: 217651 RVA: 0x0072277B File Offset: 0x0072097B
		public void UnPackTo(IResumeSystemRewardPopupTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06035234 RID: 217652 RVA: 0x0072278C File Offset: 0x0072098C
		public static Offset<IResumeSystemRewardPopupType> Pack(FlatBufferBuilder builder, IResumeSystemRewardPopupTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IResumeSystemRewardPopupType>);
			}
			return IResumeSystemRewardPopupType.CreateIResumeSystemRewardPopupType(builder, _o.Type);
		}

		// Token: 0x0401283C RID: 75836
		private Table __p;
	}
}
