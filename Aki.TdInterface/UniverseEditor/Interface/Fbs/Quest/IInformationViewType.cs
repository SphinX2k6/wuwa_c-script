using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EAE RID: 16046
	public struct IInformationViewType : IFlatbufferObject
	{
		// Token: 0x17006F63 RID: 28515
		// (get) Token: 0x06016A93 RID: 92819 RVA: 0x00345B55 File Offset: 0x00343D55
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016A94 RID: 92820 RVA: 0x00345B62 File Offset: 0x00343D62
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016A95 RID: 92821 RVA: 0x00345B6C File Offset: 0x00343D6C
		public static IInformationViewType GetRootAsIInformationViewType(ByteBuffer _bb)
		{
			return IInformationViewType.GetRootAsIInformationViewType(_bb, default(IInformationViewType));
		}

		// Token: 0x06016A96 RID: 92822 RVA: 0x00345B88 File Offset: 0x00343D88
		public static IInformationViewType GetRootAsIInformationViewType(ByteBuffer _bb, IInformationViewType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016A97 RID: 92823 RVA: 0x00345BA5 File Offset: 0x00343DA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016A98 RID: 92824 RVA: 0x00345BB4 File Offset: 0x00343DB4
		public IInformationViewType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006F64 RID: 28516
		// (get) Token: 0x06016A99 RID: 92825 RVA: 0x00345BC4 File Offset: 0x00343DC4
		public EInformationViewType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInformationViewType.LevelPlay;
				}
				return (EInformationViewType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06016A9A RID: 92826 RVA: 0x00345C00 File Offset: 0x00343E00
		public static Offset<IInformationViewType> CreateIInformationViewType(FlatBufferBuilder builder, EInformationViewType Type = EInformationViewType.LevelPlay)
		{
			builder.StartTable(1);
			IInformationViewType.AddType(builder, Type);
			return IInformationViewType.EndIInformationViewType(builder);
		}

		// Token: 0x06016A9B RID: 92827 RVA: 0x00345C16 File Offset: 0x00343E16
		public static void StartIInformationViewType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06016A9C RID: 92828 RVA: 0x00345C1F File Offset: 0x00343E1F
		public static void AddType(FlatBufferBuilder builder, EInformationViewType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016A9D RID: 92829 RVA: 0x00345C2A File Offset: 0x00343E2A
		public static Offset<IInformationViewType> EndIInformationViewType(FlatBufferBuilder builder)
		{
			return new Offset<IInformationViewType>(builder.EndTable());
		}

		// Token: 0x06016A9E RID: 92830 RVA: 0x00345C38 File Offset: 0x00343E38
		public IInformationViewTypeT UnPack()
		{
			IInformationViewTypeT informationViewTypeT = new IInformationViewTypeT();
			this.UnPackTo(informationViewTypeT);
			return informationViewTypeT;
		}

		// Token: 0x06016A9F RID: 92831 RVA: 0x00345C53 File Offset: 0x00343E53
		public void UnPackTo(IInformationViewTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06016AA0 RID: 92832 RVA: 0x00345C64 File Offset: 0x00343E64
		public static Offset<IInformationViewType> Pack(FlatBufferBuilder builder, IInformationViewTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInformationViewType>);
			}
			return IInformationViewType.CreateIInformationViewType(builder, _o.Type);
		}

		// Token: 0x0400B87A RID: 47226
		private Table __p;
	}
}
