using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200713F RID: 28991
	public struct ISlideConfig : IFlatbufferObject
	{
		// Token: 0x1700D76B RID: 55147
		// (get) Token: 0x06033650 RID: 210512 RVA: 0x006ED172 File Offset: 0x006EB372
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033651 RID: 210513 RVA: 0x006ED17F File Offset: 0x006EB37F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033652 RID: 210514 RVA: 0x006ED188 File Offset: 0x006EB388
		public static ISlideConfig GetRootAsISlideConfig(ByteBuffer _bb)
		{
			return ISlideConfig.GetRootAsISlideConfig(_bb, default(ISlideConfig));
		}

		// Token: 0x06033653 RID: 210515 RVA: 0x006ED1A4 File Offset: 0x006EB3A4
		public static ISlideConfig GetRootAsISlideConfig(ByteBuffer _bb, ISlideConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033654 RID: 210516 RVA: 0x006ED1C1 File Offset: 0x006EB3C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033655 RID: 210517 RVA: 0x006ED1D0 File Offset: 0x006EB3D0
		public ISlideConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D76C RID: 55148
		// (get) Token: 0x06033656 RID: 210518 RVA: 0x006ED1E0 File Offset: 0x006EB3E0
		public ESportStateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESportStateType.Slide;
				}
				return (ESportStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D76D RID: 55149
		// (get) Token: 0x06033657 RID: 210519 RVA: 0x006ED21C File Offset: 0x006EB41C
		public int SlideId
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

		// Token: 0x06033658 RID: 210520 RVA: 0x006ED258 File Offset: 0x006EB458
		public static Offset<ISlideConfig> CreateISlideConfig(FlatBufferBuilder builder, ESportStateType Type = ESportStateType.Slide, int SlideId = 0)
		{
			builder.StartTable(2);
			ISlideConfig.AddSlideId(builder, SlideId);
			ISlideConfig.AddType(builder, Type);
			return ISlideConfig.EndISlideConfig(builder);
		}

		// Token: 0x06033659 RID: 210521 RVA: 0x006ED275 File Offset: 0x006EB475
		public static void StartISlideConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603365A RID: 210522 RVA: 0x006ED27E File Offset: 0x006EB47E
		public static void AddType(FlatBufferBuilder builder, ESportStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603365B RID: 210523 RVA: 0x006ED289 File Offset: 0x006EB489
		public static void AddSlideId(FlatBufferBuilder builder, int slideId)
		{
			builder.AddInt(1, slideId, 0);
		}

		// Token: 0x0603365C RID: 210524 RVA: 0x006ED294 File Offset: 0x006EB494
		public static Offset<ISlideConfig> EndISlideConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISlideConfig>(builder.EndTable());
		}

		// Token: 0x0603365D RID: 210525 RVA: 0x006ED2A4 File Offset: 0x006EB4A4
		public ISlideConfigT UnPack()
		{
			ISlideConfigT slideConfigT = new ISlideConfigT();
			this.UnPackTo(slideConfigT);
			return slideConfigT;
		}

		// Token: 0x0603365E RID: 210526 RVA: 0x006ED2BF File Offset: 0x006EB4BF
		public void UnPackTo(ISlideConfigT _o)
		{
			_o.Type = this.Type;
			_o.SlideId = this.SlideId;
		}

		// Token: 0x0603365F RID: 210527 RVA: 0x006ED2DC File Offset: 0x006EB4DC
		public static Offset<ISlideConfig> Pack(FlatBufferBuilder builder, ISlideConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISlideConfig>);
			}
			return ISlideConfig.CreateISlideConfig(builder, _o.Type, _o.SlideId);
		}

		// Token: 0x04011BDA RID: 72666
		private Table __p;
	}
}
