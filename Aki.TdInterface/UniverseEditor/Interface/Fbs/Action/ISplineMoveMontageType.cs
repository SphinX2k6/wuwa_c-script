using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007959 RID: 31065
	public struct ISplineMoveMontageType : IFlatbufferObject
	{
		// Token: 0x1700E3D1 RID: 58321
		// (get) Token: 0x06036B4E RID: 224078 RVA: 0x00751CEC File Offset: 0x0074FEEC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036B4F RID: 224079 RVA: 0x00751CF9 File Offset: 0x0074FEF9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036B50 RID: 224080 RVA: 0x00751D00 File Offset: 0x0074FF00
		public static ISplineMoveMontageType GetRootAsISplineMoveMontageType(ByteBuffer _bb)
		{
			return ISplineMoveMontageType.GetRootAsISplineMoveMontageType(_bb, default(ISplineMoveMontageType));
		}

		// Token: 0x06036B51 RID: 224081 RVA: 0x00751D1C File Offset: 0x0074FF1C
		public static ISplineMoveMontageType GetRootAsISplineMoveMontageType(ByteBuffer _bb, ISplineMoveMontageType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036B52 RID: 224082 RVA: 0x00751D39 File Offset: 0x0074FF39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036B53 RID: 224083 RVA: 0x00751D48 File Offset: 0x0074FF48
		public ISplineMoveMontageType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E3D2 RID: 58322
		// (get) Token: 0x06036B54 RID: 224084 RVA: 0x00751D58 File Offset: 0x0074FF58
		public ESplineMoveMontageType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESplineMoveMontageType.ThreeStageMontage;
				}
				return (ESplineMoveMontageType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036B55 RID: 224085 RVA: 0x00751D94 File Offset: 0x0074FF94
		public static Offset<ISplineMoveMontageType> CreateISplineMoveMontageType(FlatBufferBuilder builder, ESplineMoveMontageType Type = ESplineMoveMontageType.ThreeStageMontage)
		{
			builder.StartTable(1);
			ISplineMoveMontageType.AddType(builder, Type);
			return ISplineMoveMontageType.EndISplineMoveMontageType(builder);
		}

		// Token: 0x06036B56 RID: 224086 RVA: 0x00751DAA File Offset: 0x0074FFAA
		public static void StartISplineMoveMontageType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06036B57 RID: 224087 RVA: 0x00751DB3 File Offset: 0x0074FFB3
		public static void AddType(FlatBufferBuilder builder, ESplineMoveMontageType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036B58 RID: 224088 RVA: 0x00751DBE File Offset: 0x0074FFBE
		public static Offset<ISplineMoveMontageType> EndISplineMoveMontageType(FlatBufferBuilder builder)
		{
			return new Offset<ISplineMoveMontageType>(builder.EndTable());
		}

		// Token: 0x06036B59 RID: 224089 RVA: 0x00751DCC File Offset: 0x0074FFCC
		public ISplineMoveMontageTypeT UnPack()
		{
			ISplineMoveMontageTypeT splineMoveMontageTypeT = new ISplineMoveMontageTypeT();
			this.UnPackTo(splineMoveMontageTypeT);
			return splineMoveMontageTypeT;
		}

		// Token: 0x06036B5A RID: 224090 RVA: 0x00751DE7 File Offset: 0x0074FFE7
		public void UnPackTo(ISplineMoveMontageTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06036B5B RID: 224091 RVA: 0x00751DF8 File Offset: 0x0074FFF8
		public static Offset<ISplineMoveMontageType> Pack(FlatBufferBuilder builder, ISplineMoveMontageTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISplineMoveMontageType>);
			}
			return ISplineMoveMontageType.CreateISplineMoveMontageType(builder, _o.Type);
		}

		// Token: 0x04012C31 RID: 76849
		private Table __p;
	}
}
