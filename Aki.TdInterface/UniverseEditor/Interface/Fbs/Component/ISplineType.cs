using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005986 RID: 22918
	public struct ISplineType : IFlatbufferObject
	{
		// Token: 0x1700AC00 RID: 44032
		// (get) Token: 0x06026CEA RID: 158954 RVA: 0x0055796F File Offset: 0x00555B6F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026CEB RID: 158955 RVA: 0x0055797C File Offset: 0x00555B7C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026CEC RID: 158956 RVA: 0x00557984 File Offset: 0x00555B84
		public static ISplineType GetRootAsISplineType(ByteBuffer _bb)
		{
			return ISplineType.GetRootAsISplineType(_bb, default(ISplineType));
		}

		// Token: 0x06026CED RID: 158957 RVA: 0x005579A0 File Offset: 0x00555BA0
		public static ISplineType GetRootAsISplineType(ByteBuffer _bb, ISplineType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026CEE RID: 158958 RVA: 0x005579BD File Offset: 0x00555BBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026CEF RID: 158959 RVA: 0x005579CC File Offset: 0x00555BCC
		public ISplineType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AC01 RID: 44033
		// (get) Token: 0x06026CF0 RID: 158960 RVA: 0x005579DC File Offset: 0x00555BDC
		public ESplineType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESplineType.Common;
				}
				return (ESplineType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026CF1 RID: 158961 RVA: 0x00557A18 File Offset: 0x00555C18
		public static Offset<ISplineType> CreateISplineType(FlatBufferBuilder builder, ESplineType Type = ESplineType.Common)
		{
			builder.StartTable(1);
			ISplineType.AddType(builder, Type);
			return ISplineType.EndISplineType(builder);
		}

		// Token: 0x06026CF2 RID: 158962 RVA: 0x00557A2E File Offset: 0x00555C2E
		public static void StartISplineType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06026CF3 RID: 158963 RVA: 0x00557A37 File Offset: 0x00555C37
		public static void AddType(FlatBufferBuilder builder, ESplineType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026CF4 RID: 158964 RVA: 0x00557A42 File Offset: 0x00555C42
		public static Offset<ISplineType> EndISplineType(FlatBufferBuilder builder)
		{
			return new Offset<ISplineType>(builder.EndTable());
		}

		// Token: 0x06026CF5 RID: 158965 RVA: 0x00557A50 File Offset: 0x00555C50
		public ISplineTypeT UnPack()
		{
			ISplineTypeT splineTypeT = new ISplineTypeT();
			this.UnPackTo(splineTypeT);
			return splineTypeT;
		}

		// Token: 0x06026CF6 RID: 158966 RVA: 0x00557A6B File Offset: 0x00555C6B
		public void UnPackTo(ISplineTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06026CF7 RID: 158967 RVA: 0x00557A7C File Offset: 0x00555C7C
		public static Offset<ISplineType> Pack(FlatBufferBuilder builder, ISplineTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISplineType>);
			}
			return ISplineType.CreateISplineType(builder, _o.Type);
		}

		// Token: 0x0400EF7B RID: 61307
		private Table __p;
	}
}
