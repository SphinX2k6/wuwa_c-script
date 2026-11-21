using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200754F RID: 30031
	public struct IPromptStylePhoto : IFlatbufferObject
	{
		// Token: 0x1700DCE2 RID: 56546
		// (get) Token: 0x06034A8F RID: 215695 RVA: 0x00715869 File Offset: 0x00713A69
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034A90 RID: 215696 RVA: 0x00715876 File Offset: 0x00713A76
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034A91 RID: 215697 RVA: 0x00715880 File Offset: 0x00713A80
		public static IPromptStylePhoto GetRootAsIPromptStylePhoto(ByteBuffer _bb)
		{
			return IPromptStylePhoto.GetRootAsIPromptStylePhoto(_bb, default(IPromptStylePhoto));
		}

		// Token: 0x06034A92 RID: 215698 RVA: 0x0071589C File Offset: 0x00713A9C
		public static IPromptStylePhoto GetRootAsIPromptStylePhoto(ByteBuffer _bb, IPromptStylePhoto obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034A93 RID: 215699 RVA: 0x007158B9 File Offset: 0x00713AB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034A94 RID: 215700 RVA: 0x007158C8 File Offset: 0x00713AC8
		public IPromptStylePhoto __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DCE3 RID: 56547
		// (get) Token: 0x06034A95 RID: 215701 RVA: 0x007158D8 File Offset: 0x00713AD8
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

		// Token: 0x06034A96 RID: 215702 RVA: 0x00715914 File Offset: 0x00713B14
		public static Offset<IPromptStylePhoto> CreateIPromptStylePhoto(FlatBufferBuilder builder, EPromptStyle Type = EPromptStyle.Default)
		{
			builder.StartTable(1);
			IPromptStylePhoto.AddType(builder, Type);
			return IPromptStylePhoto.EndIPromptStylePhoto(builder);
		}

		// Token: 0x06034A97 RID: 215703 RVA: 0x0071592A File Offset: 0x00713B2A
		public static void StartIPromptStylePhoto(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06034A98 RID: 215704 RVA: 0x00715933 File Offset: 0x00713B33
		public static void AddType(FlatBufferBuilder builder, EPromptStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034A99 RID: 215705 RVA: 0x0071593E File Offset: 0x00713B3E
		public static Offset<IPromptStylePhoto> EndIPromptStylePhoto(FlatBufferBuilder builder)
		{
			return new Offset<IPromptStylePhoto>(builder.EndTable());
		}

		// Token: 0x06034A9A RID: 215706 RVA: 0x0071594C File Offset: 0x00713B4C
		public IPromptStylePhotoT UnPack()
		{
			IPromptStylePhotoT promptStylePhotoT = new IPromptStylePhotoT();
			this.UnPackTo(promptStylePhotoT);
			return promptStylePhotoT;
		}

		// Token: 0x06034A9B RID: 215707 RVA: 0x00715967 File Offset: 0x00713B67
		public void UnPackTo(IPromptStylePhotoT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06034A9C RID: 215708 RVA: 0x00715978 File Offset: 0x00713B78
		public static Offset<IPromptStylePhoto> Pack(FlatBufferBuilder builder, IPromptStylePhotoT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPromptStylePhoto>);
			}
			return IPromptStylePhoto.CreateIPromptStylePhoto(builder, _o.Type);
		}

		// Token: 0x04012730 RID: 75568
		private Table __p;
	}
}
