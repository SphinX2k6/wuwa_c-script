using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D7F RID: 23935
	public struct IConstraintValueType : IFlatbufferObject
	{
		// Token: 0x1700B344 RID: 45892
		// (get) Token: 0x06028F26 RID: 167718 RVA: 0x0059FA62 File Offset: 0x0059DC62
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028F27 RID: 167719 RVA: 0x0059FA6F File Offset: 0x0059DC6F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028F28 RID: 167720 RVA: 0x0059FA78 File Offset: 0x0059DC78
		public static IConstraintValueType GetRootAsIConstraintValueType(ByteBuffer _bb)
		{
			return IConstraintValueType.GetRootAsIConstraintValueType(_bb, default(IConstraintValueType));
		}

		// Token: 0x06028F29 RID: 167721 RVA: 0x0059FA94 File Offset: 0x0059DC94
		public static IConstraintValueType GetRootAsIConstraintValueType(ByteBuffer _bb, IConstraintValueType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028F2A RID: 167722 RVA: 0x0059FAB1 File Offset: 0x0059DCB1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028F2B RID: 167723 RVA: 0x0059FAC0 File Offset: 0x0059DCC0
		public IConstraintValueType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B345 RID: 45893
		// (get) Token: 0x06028F2C RID: 167724 RVA: 0x0059FAD0 File Offset: 0x0059DCD0
		public EConstraintValueType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EConstraintValueType.Max;
				}
				return (EConstraintValueType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028F2D RID: 167725 RVA: 0x0059FB0C File Offset: 0x0059DD0C
		public static Offset<IConstraintValueType> CreateIConstraintValueType(FlatBufferBuilder builder, EConstraintValueType Type = EConstraintValueType.Max)
		{
			builder.StartTable(1);
			IConstraintValueType.AddType(builder, Type);
			return IConstraintValueType.EndIConstraintValueType(builder);
		}

		// Token: 0x06028F2E RID: 167726 RVA: 0x0059FB22 File Offset: 0x0059DD22
		public static void StartIConstraintValueType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06028F2F RID: 167727 RVA: 0x0059FB2B File Offset: 0x0059DD2B
		public static void AddType(FlatBufferBuilder builder, EConstraintValueType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028F30 RID: 167728 RVA: 0x0059FB36 File Offset: 0x0059DD36
		public static Offset<IConstraintValueType> EndIConstraintValueType(FlatBufferBuilder builder)
		{
			return new Offset<IConstraintValueType>(builder.EndTable());
		}

		// Token: 0x06028F31 RID: 167729 RVA: 0x0059FB44 File Offset: 0x0059DD44
		public IConstraintValueTypeT UnPack()
		{
			IConstraintValueTypeT constraintValueTypeT = new IConstraintValueTypeT();
			this.UnPackTo(constraintValueTypeT);
			return constraintValueTypeT;
		}

		// Token: 0x06028F32 RID: 167730 RVA: 0x0059FB5F File Offset: 0x0059DD5F
		public void UnPackTo(IConstraintValueTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06028F33 RID: 167731 RVA: 0x0059FB70 File Offset: 0x0059DD70
		public static Offset<IConstraintValueType> Pack(FlatBufferBuilder builder, IConstraintValueTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConstraintValueType>);
			}
			return IConstraintValueType.CreateIConstraintValueType(builder, _o.Type);
		}

		// Token: 0x0400F74A RID: 63306
		private Table __p;
	}
}
