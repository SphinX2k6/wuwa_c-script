using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006945 RID: 26949
	public struct IInformationViewConfig : IFlatbufferObject
	{
		// Token: 0x1700C7EF RID: 51183
		// (get) Token: 0x0602F0E2 RID: 192738 RVA: 0x00669F66 File Offset: 0x00668166
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F0E3 RID: 192739 RVA: 0x00669F73 File Offset: 0x00668173
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F0E4 RID: 192740 RVA: 0x00669F7C File Offset: 0x0066817C
		public static IInformationViewConfig GetRootAsIInformationViewConfig(ByteBuffer _bb)
		{
			return IInformationViewConfig.GetRootAsIInformationViewConfig(_bb, default(IInformationViewConfig));
		}

		// Token: 0x0602F0E5 RID: 192741 RVA: 0x00669F98 File Offset: 0x00668198
		public static IInformationViewConfig GetRootAsIInformationViewConfig(ByteBuffer _bb, IInformationViewConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F0E6 RID: 192742 RVA: 0x00669FB5 File Offset: 0x006681B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F0E7 RID: 192743 RVA: 0x00669FC4 File Offset: 0x006681C4
		public IInformationViewConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C7F0 RID: 51184
		// (get) Token: 0x0602F0E8 RID: 192744 RVA: 0x00669FD4 File Offset: 0x006681D4
		public int InfoDisplayGroup
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C7F1 RID: 51185
		// (get) Token: 0x0602F0E9 RID: 192745 RVA: 0x0066A010 File Offset: 0x00668210
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F0EA RID: 192746 RVA: 0x0066A04C File Offset: 0x0066824C
		public static Offset<IInformationViewConfig> CreateIInformationViewConfig(FlatBufferBuilder builder, int InfoDisplayGroup = 0, byte NullMask = 0)
		{
			builder.StartTable(2);
			IInformationViewConfig.AddInfoDisplayGroup(builder, InfoDisplayGroup);
			IInformationViewConfig.AddNullMask(builder, NullMask);
			return IInformationViewConfig.EndIInformationViewConfig(builder);
		}

		// Token: 0x0602F0EB RID: 192747 RVA: 0x0066A069 File Offset: 0x00668269
		public static void StartIInformationViewConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602F0EC RID: 192748 RVA: 0x0066A072 File Offset: 0x00668272
		public static void AddInfoDisplayGroup(FlatBufferBuilder builder, int infoDisplayGroup)
		{
			builder.AddInt(0, infoDisplayGroup, 0);
		}

		// Token: 0x0602F0ED RID: 192749 RVA: 0x0066A07D File Offset: 0x0066827D
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x0602F0EE RID: 192750 RVA: 0x0066A088 File Offset: 0x00668288
		public static Offset<IInformationViewConfig> EndIInformationViewConfig(FlatBufferBuilder builder)
		{
			return new Offset<IInformationViewConfig>(builder.EndTable());
		}

		// Token: 0x0602F0EF RID: 192751 RVA: 0x0066A098 File Offset: 0x00668298
		public IInformationViewConfigT UnPack()
		{
			IInformationViewConfigT informationViewConfigT = new IInformationViewConfigT();
			this.UnPackTo(informationViewConfigT);
			return informationViewConfigT;
		}

		// Token: 0x0602F0F0 RID: 192752 RVA: 0x0066A0B3 File Offset: 0x006682B3
		public void UnPackTo(IInformationViewConfigT _o)
		{
			_o.InfoDisplayGroup = this.InfoDisplayGroup;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602F0F1 RID: 192753 RVA: 0x0066A0D0 File Offset: 0x006682D0
		public static Offset<IInformationViewConfig> Pack(FlatBufferBuilder builder, IInformationViewConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInformationViewConfig>);
			}
			return IInformationViewConfig.CreateIInformationViewConfig(builder, _o.InfoDisplayGroup, _o.NullMask);
		}

		// Token: 0x040110C3 RID: 69827
		private Table __p;
	}
}
