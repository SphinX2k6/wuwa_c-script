using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005999 RID: 22937
	public struct IInhaledPerResultType : IFlatbufferObject
	{
		// Token: 0x1700A696 RID: 42646
		// (get) Token: 0x06025655 RID: 153173 RVA: 0x0052199D File Offset: 0x0051FB9D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025656 RID: 153174 RVA: 0x005219AA File Offset: 0x0051FBAA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025657 RID: 153175 RVA: 0x005219B4 File Offset: 0x0051FBB4
		public static IInhaledPerResultType GetRootAsIInhaledPerResultType(ByteBuffer _bb)
		{
			return IInhaledPerResultType.GetRootAsIInhaledPerResultType(_bb, default(IInhaledPerResultType));
		}

		// Token: 0x06025658 RID: 153176 RVA: 0x005219D0 File Offset: 0x0051FBD0
		public static IInhaledPerResultType GetRootAsIInhaledPerResultType(ByteBuffer _bb, IInhaledPerResultType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025659 RID: 153177 RVA: 0x005219ED File Offset: 0x0051FBED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602565A RID: 153178 RVA: 0x005219FC File Offset: 0x0051FBFC
		public IInhaledPerResultType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A697 RID: 42647
		// (get) Token: 0x0602565B RID: 153179 RVA: 0x00521A0C File Offset: 0x0051FC0C
		public EInhaledPerResultType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInhaledPerResultType.DestroySelf;
				}
				return (EInhaledPerResultType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602565C RID: 153180 RVA: 0x00521A48 File Offset: 0x0051FC48
		public static Offset<IInhaledPerResultType> CreateIInhaledPerResultType(FlatBufferBuilder builder, EInhaledPerResultType Type = EInhaledPerResultType.DestroySelf)
		{
			builder.StartTable(1);
			IInhaledPerResultType.AddType(builder, Type);
			return IInhaledPerResultType.EndIInhaledPerResultType(builder);
		}

		// Token: 0x0602565D RID: 153181 RVA: 0x00521A5E File Offset: 0x0051FC5E
		public static void StartIInhaledPerResultType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602565E RID: 153182 RVA: 0x00521A67 File Offset: 0x0051FC67
		public static void AddType(FlatBufferBuilder builder, EInhaledPerResultType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602565F RID: 153183 RVA: 0x00521A72 File Offset: 0x0051FC72
		public static Offset<IInhaledPerResultType> EndIInhaledPerResultType(FlatBufferBuilder builder)
		{
			return new Offset<IInhaledPerResultType>(builder.EndTable());
		}

		// Token: 0x06025660 RID: 153184 RVA: 0x00521A80 File Offset: 0x0051FC80
		public IInhaledPerResultTypeT UnPack()
		{
			IInhaledPerResultTypeT inhaledPerResultTypeT = new IInhaledPerResultTypeT();
			this.UnPackTo(inhaledPerResultTypeT);
			return inhaledPerResultTypeT;
		}

		// Token: 0x06025661 RID: 153185 RVA: 0x00521A9B File Offset: 0x0051FC9B
		public void UnPackTo(IInhaledPerResultTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06025662 RID: 153186 RVA: 0x00521AAC File Offset: 0x0051FCAC
		public static Offset<IInhaledPerResultType> Pack(FlatBufferBuilder builder, IInhaledPerResultTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInhaledPerResultType>);
			}
			return IInhaledPerResultType.CreateIInhaledPerResultType(builder, _o.Type);
		}

		// Token: 0x0400F28D RID: 62093
		private Table __p;
	}
}
