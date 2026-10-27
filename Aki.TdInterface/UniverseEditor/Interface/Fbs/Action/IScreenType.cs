using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F48 RID: 28488
	public struct IScreenType : IFlatbufferObject
	{
		// Token: 0x1700D3B4 RID: 54196
		// (get) Token: 0x06032549 RID: 206153 RVA: 0x006CBF02 File Offset: 0x006CA102
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603254A RID: 206154 RVA: 0x006CBF0F File Offset: 0x006CA10F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603254B RID: 206155 RVA: 0x006CBF18 File Offset: 0x006CA118
		public static IScreenType GetRootAsIScreenType(ByteBuffer _bb)
		{
			return IScreenType.GetRootAsIScreenType(_bb, default(IScreenType));
		}

		// Token: 0x0603254C RID: 206156 RVA: 0x006CBF34 File Offset: 0x006CA134
		public static IScreenType GetRootAsIScreenType(ByteBuffer _bb, IScreenType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603254D RID: 206157 RVA: 0x006CBF51 File Offset: 0x006CA151
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603254E RID: 206158 RVA: 0x006CBF60 File Offset: 0x006CA160
		public IScreenType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D3B5 RID: 54197
		// (get) Token: 0x0603254F RID: 206159 RVA: 0x006CBF70 File Offset: 0x006CA170
		public EScreenType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EScreenType.Main;
				}
				return (EScreenType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032550 RID: 206160 RVA: 0x006CBFAC File Offset: 0x006CA1AC
		public static Offset<IScreenType> CreateIScreenType(FlatBufferBuilder builder, EScreenType Type = EScreenType.Main)
		{
			builder.StartTable(1);
			IScreenType.AddType(builder, Type);
			return IScreenType.EndIScreenType(builder);
		}

		// Token: 0x06032551 RID: 206161 RVA: 0x006CBFC2 File Offset: 0x006CA1C2
		public static void StartIScreenType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06032552 RID: 206162 RVA: 0x006CBFCB File Offset: 0x006CA1CB
		public static void AddType(FlatBufferBuilder builder, EScreenType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032553 RID: 206163 RVA: 0x006CBFD6 File Offset: 0x006CA1D6
		public static Offset<IScreenType> EndIScreenType(FlatBufferBuilder builder)
		{
			return new Offset<IScreenType>(builder.EndTable());
		}

		// Token: 0x06032554 RID: 206164 RVA: 0x006CBFE4 File Offset: 0x006CA1E4
		public IScreenTypeT UnPack()
		{
			IScreenTypeT screenTypeT = new IScreenTypeT();
			this.UnPackTo(screenTypeT);
			return screenTypeT;
		}

		// Token: 0x06032555 RID: 206165 RVA: 0x006CBFFF File Offset: 0x006CA1FF
		public void UnPackTo(IScreenTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06032556 RID: 206166 RVA: 0x006CC010 File Offset: 0x006CA210
		public static Offset<IScreenType> Pack(FlatBufferBuilder builder, IScreenTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IScreenType>);
			}
			return IScreenType.CreateIScreenType(builder, _o.Type);
		}

		// Token: 0x0401193F RID: 71999
		private Table __p;
	}
}
