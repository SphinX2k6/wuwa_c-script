using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DD4 RID: 28116
	public struct IPromptStylePhoto : IFlatbufferObject
	{
		// Token: 0x1700D19A RID: 53658
		// (get) Token: 0x06031A93 RID: 203411 RVA: 0x006BA181 File Offset: 0x006B8381
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031A94 RID: 203412 RVA: 0x006BA18E File Offset: 0x006B838E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031A95 RID: 203413 RVA: 0x006BA198 File Offset: 0x006B8398
		public static IPromptStylePhoto GetRootAsIPromptStylePhoto(ByteBuffer _bb)
		{
			return IPromptStylePhoto.GetRootAsIPromptStylePhoto(_bb, default(IPromptStylePhoto));
		}

		// Token: 0x06031A96 RID: 203414 RVA: 0x006BA1B4 File Offset: 0x006B83B4
		public static IPromptStylePhoto GetRootAsIPromptStylePhoto(ByteBuffer _bb, IPromptStylePhoto obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031A97 RID: 203415 RVA: 0x006BA1D1 File Offset: 0x006B83D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031A98 RID: 203416 RVA: 0x006BA1E0 File Offset: 0x006B83E0
		public IPromptStylePhoto __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D19B RID: 53659
		// (get) Token: 0x06031A99 RID: 203417 RVA: 0x006BA1F0 File Offset: 0x006B83F0
		public EPromptStyle Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPromptStyle.Default;
				}
				return (EPromptStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031A9A RID: 203418 RVA: 0x006BA22C File Offset: 0x006B842C
		public static Offset<IPromptStylePhoto> CreateIPromptStylePhoto(FlatBufferBuilder builder, EPromptStyle Type = EPromptStyle.Default)
		{
			builder.StartTable(1);
			IPromptStylePhoto.AddType(builder, Type);
			return IPromptStylePhoto.EndIPromptStylePhoto(builder);
		}

		// Token: 0x06031A9B RID: 203419 RVA: 0x006BA242 File Offset: 0x006B8442
		public static void StartIPromptStylePhoto(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031A9C RID: 203420 RVA: 0x006BA24B File Offset: 0x006B844B
		public static void AddType(FlatBufferBuilder builder, EPromptStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031A9D RID: 203421 RVA: 0x006BA256 File Offset: 0x006B8456
		public static Offset<IPromptStylePhoto> EndIPromptStylePhoto(FlatBufferBuilder builder)
		{
			return new Offset<IPromptStylePhoto>(builder.EndTable());
		}

		// Token: 0x06031A9E RID: 203422 RVA: 0x006BA264 File Offset: 0x006B8464
		public IPromptStylePhotoT UnPack()
		{
			IPromptStylePhotoT promptStylePhotoT = new IPromptStylePhotoT();
			this.UnPackTo(promptStylePhotoT);
			return promptStylePhotoT;
		}

		// Token: 0x06031A9F RID: 203423 RVA: 0x006BA27F File Offset: 0x006B847F
		public void UnPackTo(IPromptStylePhotoT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06031AA0 RID: 203424 RVA: 0x006BA290 File Offset: 0x006B8490
		public static Offset<IPromptStylePhoto> Pack(FlatBufferBuilder builder, IPromptStylePhotoT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPromptStylePhoto>);
			}
			return IPromptStylePhoto.CreateIPromptStylePhoto(builder, _o.Type);
		}

		// Token: 0x040117B4 RID: 71604
		private Table __p;
	}
}
