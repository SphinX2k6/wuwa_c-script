using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064FE RID: 25854
	public struct ICustomScreenLoading : IFlatbufferObject
	{
		// Token: 0x1700C04A RID: 49226
		// (get) Token: 0x0602CD9B RID: 183707 RVA: 0x00629501 File Offset: 0x00627701
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CD9C RID: 183708 RVA: 0x0062950E File Offset: 0x0062770E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CD9D RID: 183709 RVA: 0x00629518 File Offset: 0x00627718
		public static ICustomScreenLoading GetRootAsICustomScreenLoading(ByteBuffer _bb)
		{
			return ICustomScreenLoading.GetRootAsICustomScreenLoading(_bb, default(ICustomScreenLoading));
		}

		// Token: 0x0602CD9E RID: 183710 RVA: 0x00629534 File Offset: 0x00627734
		public static ICustomScreenLoading GetRootAsICustomScreenLoading(ByteBuffer _bb, ICustomScreenLoading obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CD9F RID: 183711 RVA: 0x00629551 File Offset: 0x00627751
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CDA0 RID: 183712 RVA: 0x00629560 File Offset: 0x00627760
		public ICustomScreenLoading __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C04B RID: 49227
		// (get) Token: 0x0602CDA1 RID: 183713 RVA: 0x00629570 File Offset: 0x00627770
		public ECustomScreenType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECustomScreenType.Spine;
				}
				return (ECustomScreenType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C04C RID: 49228
		// (get) Token: 0x0602CDA2 RID: 183714 RVA: 0x006295AC File Offset: 0x006277AC
		public ICustomScreenLoadingCyberpunk? LoadingType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ICustomScreenLoadingCyberpunk?(default(ICustomScreenLoadingCyberpunk).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602CDA3 RID: 183715 RVA: 0x00629609 File Offset: 0x00627809
		public static Offset<ICustomScreenLoading> CreateICustomScreenLoading(FlatBufferBuilder builder, ECustomScreenType Type = ECustomScreenType.Spine, Offset<ICustomScreenLoadingCyberpunk> LoadingTypeOffset = default(Offset<ICustomScreenLoadingCyberpunk>))
		{
			builder.StartTable(2);
			ICustomScreenLoading.AddLoadingType(builder, LoadingTypeOffset);
			ICustomScreenLoading.AddType(builder, Type);
			return ICustomScreenLoading.EndICustomScreenLoading(builder);
		}

		// Token: 0x0602CDA4 RID: 183716 RVA: 0x00629626 File Offset: 0x00627826
		public static void StartICustomScreenLoading(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602CDA5 RID: 183717 RVA: 0x0062962F File Offset: 0x0062782F
		public static void AddType(FlatBufferBuilder builder, ECustomScreenType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CDA6 RID: 183718 RVA: 0x0062963A File Offset: 0x0062783A
		public static void AddLoadingType(FlatBufferBuilder builder, Offset<ICustomScreenLoadingCyberpunk> loadingTypeOffset)
		{
			builder.AddOffset(1, loadingTypeOffset.Value, 0);
		}

		// Token: 0x0602CDA7 RID: 183719 RVA: 0x0062964A File Offset: 0x0062784A
		public static Offset<ICustomScreenLoading> EndICustomScreenLoading(FlatBufferBuilder builder)
		{
			return new Offset<ICustomScreenLoading>(builder.EndTable());
		}

		// Token: 0x0602CDA8 RID: 183720 RVA: 0x00629658 File Offset: 0x00627858
		public ICustomScreenLoadingT UnPack()
		{
			ICustomScreenLoadingT customScreenLoadingT = new ICustomScreenLoadingT();
			this.UnPackTo(customScreenLoadingT);
			return customScreenLoadingT;
		}

		// Token: 0x0602CDA9 RID: 183721 RVA: 0x00629674 File Offset: 0x00627874
		public void UnPackTo(ICustomScreenLoadingT _o)
		{
			_o.Type = this.Type;
			_o.LoadingType = ((this.LoadingType != null) ? this.LoadingType.Value.UnPack() : null);
		}

		// Token: 0x0602CDAA RID: 183722 RVA: 0x006296BC File Offset: 0x006278BC
		public static Offset<ICustomScreenLoading> Pack(FlatBufferBuilder builder, ICustomScreenLoadingT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICustomScreenLoading>);
			}
			Offset<ICustomScreenLoadingCyberpunk> loadingTypeOffset = (_o.LoadingType == null) ? default(Offset<ICustomScreenLoadingCyberpunk>) : ICustomScreenLoadingCyberpunk.Pack(builder, _o.LoadingType);
			return ICustomScreenLoading.CreateICustomScreenLoading(builder, _o.Type, loadingTypeOffset);
		}

		// Token: 0x04010B41 RID: 68417
		private Table __p;
	}
}
