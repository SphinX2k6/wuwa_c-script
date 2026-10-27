using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071FC RID: 29180
	public struct ISubPlotModePromptWithProfilePic : IFlatbufferObject
	{
		// Token: 0x1700D8A7 RID: 55463
		// (get) Token: 0x06033C12 RID: 211986 RVA: 0x006F7676 File Offset: 0x006F5876
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033C13 RID: 211987 RVA: 0x006F7683 File Offset: 0x006F5883
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033C14 RID: 211988 RVA: 0x006F768C File Offset: 0x006F588C
		public static ISubPlotModePromptWithProfilePic GetRootAsISubPlotModePromptWithProfilePic(ByteBuffer _bb)
		{
			return ISubPlotModePromptWithProfilePic.GetRootAsISubPlotModePromptWithProfilePic(_bb, default(ISubPlotModePromptWithProfilePic));
		}

		// Token: 0x06033C15 RID: 211989 RVA: 0x006F76A8 File Offset: 0x006F58A8
		public static ISubPlotModePromptWithProfilePic GetRootAsISubPlotModePromptWithProfilePic(ByteBuffer _bb, ISubPlotModePromptWithProfilePic obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033C16 RID: 211990 RVA: 0x006F76C5 File Offset: 0x006F58C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033C17 RID: 211991 RVA: 0x006F76D4 File Offset: 0x006F58D4
		public ISubPlotModePromptWithProfilePic __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D8A8 RID: 55464
		// (get) Token: 0x06033C18 RID: 211992 RVA: 0x006F76E4 File Offset: 0x006F58E4
		public ESubPlotModeType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESubPlotModeType.PromptWithProfilePic;
				}
				return (ESubPlotModeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033C19 RID: 211993 RVA: 0x006F7720 File Offset: 0x006F5920
		public static Offset<ISubPlotModePromptWithProfilePic> CreateISubPlotModePromptWithProfilePic(FlatBufferBuilder builder, ESubPlotModeType Type = ESubPlotModeType.PromptWithProfilePic)
		{
			builder.StartTable(1);
			ISubPlotModePromptWithProfilePic.AddType(builder, Type);
			return ISubPlotModePromptWithProfilePic.EndISubPlotModePromptWithProfilePic(builder);
		}

		// Token: 0x06033C1A RID: 211994 RVA: 0x006F7736 File Offset: 0x006F5936
		public static void StartISubPlotModePromptWithProfilePic(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06033C1B RID: 211995 RVA: 0x006F773F File Offset: 0x006F593F
		public static void AddType(FlatBufferBuilder builder, ESubPlotModeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033C1C RID: 211996 RVA: 0x006F774A File Offset: 0x006F594A
		public static Offset<ISubPlotModePromptWithProfilePic> EndISubPlotModePromptWithProfilePic(FlatBufferBuilder builder)
		{
			return new Offset<ISubPlotModePromptWithProfilePic>(builder.EndTable());
		}

		// Token: 0x06033C1D RID: 211997 RVA: 0x006F7758 File Offset: 0x006F5958
		public ISubPlotModePromptWithProfilePicT UnPack()
		{
			ISubPlotModePromptWithProfilePicT subPlotModePromptWithProfilePicT = new ISubPlotModePromptWithProfilePicT();
			this.UnPackTo(subPlotModePromptWithProfilePicT);
			return subPlotModePromptWithProfilePicT;
		}

		// Token: 0x06033C1E RID: 211998 RVA: 0x006F7773 File Offset: 0x006F5973
		public void UnPackTo(ISubPlotModePromptWithProfilePicT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06033C1F RID: 211999 RVA: 0x006F7784 File Offset: 0x006F5984
		public static Offset<ISubPlotModePromptWithProfilePic> Pack(FlatBufferBuilder builder, ISubPlotModePromptWithProfilePicT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISubPlotModePromptWithProfilePic>);
			}
			return ISubPlotModePromptWithProfilePic.CreateISubPlotModePromptWithProfilePic(builder, _o.Type);
		}

		// Token: 0x04011CE1 RID: 72929
		private Table __p;
	}
}
