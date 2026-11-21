using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071E9 RID: 29161
	public struct IModifyActorMedia : IFlatbufferObject
	{
		// Token: 0x1700D57B RID: 54651
		// (get) Token: 0x06032BA2 RID: 207778 RVA: 0x006DA2DC File Offset: 0x006D84DC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032BA3 RID: 207779 RVA: 0x006DA2E9 File Offset: 0x006D84E9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032BA4 RID: 207780 RVA: 0x006DA2F0 File Offset: 0x006D84F0
		public static IModifyActorMedia GetRootAsIModifyActorMedia(ByteBuffer _bb)
		{
			return IModifyActorMedia.GetRootAsIModifyActorMedia(_bb, default(IModifyActorMedia));
		}

		// Token: 0x06032BA5 RID: 207781 RVA: 0x006DA30C File Offset: 0x006D850C
		public static IModifyActorMedia GetRootAsIModifyActorMedia(ByteBuffer _bb, IModifyActorMedia obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032BA6 RID: 207782 RVA: 0x006DA329 File Offset: 0x006D8529
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032BA7 RID: 207783 RVA: 0x006DA338 File Offset: 0x006D8538
		public IModifyActorMedia __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D57C RID: 54652
		// (get) Token: 0x06032BA8 RID: 207784 RVA: 0x006DA348 File Offset: 0x006D8548
		public IChangeMediaPlayDa? Config
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IChangeMediaPlayDa?(default(IChangeMediaPlayDa).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06032BA9 RID: 207785 RVA: 0x006DA3A5 File Offset: 0x006D85A5
		public static Offset<IModifyActorMedia> CreateIModifyActorMedia(FlatBufferBuilder builder, Offset<IChangeMediaPlayDa> ConfigOffset = default(Offset<IChangeMediaPlayDa>))
		{
			builder.StartTable(1);
			IModifyActorMedia.AddConfig(builder, ConfigOffset);
			return IModifyActorMedia.EndIModifyActorMedia(builder);
		}

		// Token: 0x06032BAA RID: 207786 RVA: 0x006DA3BB File Offset: 0x006D85BB
		public static void StartIModifyActorMedia(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06032BAB RID: 207787 RVA: 0x006DA3C4 File Offset: 0x006D85C4
		public static void AddConfig(FlatBufferBuilder builder, Offset<IChangeMediaPlayDa> configOffset)
		{
			builder.AddOffset(0, configOffset.Value, 0);
		}

		// Token: 0x06032BAC RID: 207788 RVA: 0x006DA3D4 File Offset: 0x006D85D4
		public static Offset<IModifyActorMedia> EndIModifyActorMedia(FlatBufferBuilder builder)
		{
			return new Offset<IModifyActorMedia>(builder.EndTable());
		}

		// Token: 0x06032BAD RID: 207789 RVA: 0x006DA3E4 File Offset: 0x006D85E4
		public IModifyActorMediaT UnPack()
		{
			IModifyActorMediaT modifyActorMediaT = new IModifyActorMediaT();
			this.UnPackTo(modifyActorMediaT);
			return modifyActorMediaT;
		}

		// Token: 0x06032BAE RID: 207790 RVA: 0x006DA400 File Offset: 0x006D8600
		public void UnPackTo(IModifyActorMediaT _o)
		{
			_o.Config = ((this.Config != null) ? this.Config.Value.UnPack() : null);
		}

		// Token: 0x06032BAF RID: 207791 RVA: 0x006DA43C File Offset: 0x006D863C
		public static Offset<IModifyActorMedia> Pack(FlatBufferBuilder builder, IModifyActorMediaT _o)
		{
			if (_o == null)
			{
				return default(Offset<IModifyActorMedia>);
			}
			Offset<IChangeMediaPlayDa> configOffset = (_o.Config == null) ? default(Offset<IChangeMediaPlayDa>) : IChangeMediaPlayDa.Pack(builder, _o.Config);
			return IModifyActorMedia.CreateIModifyActorMedia(builder, configOffset);
		}

		// Token: 0x04012204 RID: 74244
		private Table __p;
	}
}
