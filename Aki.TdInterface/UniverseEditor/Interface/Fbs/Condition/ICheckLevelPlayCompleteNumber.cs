using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F8F RID: 20367
	public struct ICheckLevelPlayCompleteNumber : IFlatbufferObject
	{
		// Token: 0x170091A2 RID: 37282
		// (get) Token: 0x0601FB8D RID: 129933 RVA: 0x00468B2C File Offset: 0x00466D2C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FB8E RID: 129934 RVA: 0x00468B39 File Offset: 0x00466D39
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FB8F RID: 129935 RVA: 0x00468B40 File Offset: 0x00466D40
		public static ICheckLevelPlayCompleteNumber GetRootAsICheckLevelPlayCompleteNumber(ByteBuffer _bb)
		{
			return ICheckLevelPlayCompleteNumber.GetRootAsICheckLevelPlayCompleteNumber(_bb, default(ICheckLevelPlayCompleteNumber));
		}

		// Token: 0x0601FB90 RID: 129936 RVA: 0x00468B5C File Offset: 0x00466D5C
		public static ICheckLevelPlayCompleteNumber GetRootAsICheckLevelPlayCompleteNumber(ByteBuffer _bb, ICheckLevelPlayCompleteNumber obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FB91 RID: 129937 RVA: 0x00468B79 File Offset: 0x00466D79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FB92 RID: 129938 RVA: 0x00468B88 File Offset: 0x00466D88
		public ICheckLevelPlayCompleteNumber __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170091A3 RID: 37283
		// (get) Token: 0x0601FB93 RID: 129939 RVA: 0x00468B98 File Offset: 0x00466D98
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170091A4 RID: 37284
		// (get) Token: 0x0601FB94 RID: 129940 RVA: 0x00468BD4 File Offset: 0x00466DD4
		public int LevelId
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

		// Token: 0x170091A5 RID: 37285
		// (get) Token: 0x0601FB95 RID: 129941 RVA: 0x00468C10 File Offset: 0x00466E10
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170091A6 RID: 37286
		// (get) Token: 0x0601FB96 RID: 129942 RVA: 0x00468C4C File Offset: 0x00466E4C
		public int Number
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601FB97 RID: 129943 RVA: 0x00468C89 File Offset: 0x00466E89
		public static Offset<ICheckLevelPlayCompleteNumber> CreateICheckLevelPlayCompleteNumber(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int LevelId = 0, ECompare Compare = ECompare.Eq, int Number = 0)
		{
			builder.StartTable(4);
			ICheckLevelPlayCompleteNumber.AddNumber(builder, Number);
			ICheckLevelPlayCompleteNumber.AddLevelId(builder, LevelId);
			ICheckLevelPlayCompleteNumber.AddCompare(builder, Compare);
			ICheckLevelPlayCompleteNumber.AddType(builder, Type);
			return ICheckLevelPlayCompleteNumber.EndICheckLevelPlayCompleteNumber(builder);
		}

		// Token: 0x0601FB98 RID: 129944 RVA: 0x00468CB5 File Offset: 0x00466EB5
		public static void StartICheckLevelPlayCompleteNumber(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601FB99 RID: 129945 RVA: 0x00468CBE File Offset: 0x00466EBE
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FB9A RID: 129946 RVA: 0x00468CC9 File Offset: 0x00466EC9
		public static void AddLevelId(FlatBufferBuilder builder, int levelId)
		{
			builder.AddInt(1, levelId, 0);
		}

		// Token: 0x0601FB9B RID: 129947 RVA: 0x00468CD4 File Offset: 0x00466ED4
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x0601FB9C RID: 129948 RVA: 0x00468CDF File Offset: 0x00466EDF
		public static void AddNumber(FlatBufferBuilder builder, int number)
		{
			builder.AddInt(3, number, 0);
		}

		// Token: 0x0601FB9D RID: 129949 RVA: 0x00468CEA File Offset: 0x00466EEA
		public static Offset<ICheckLevelPlayCompleteNumber> EndICheckLevelPlayCompleteNumber(FlatBufferBuilder builder)
		{
			return new Offset<ICheckLevelPlayCompleteNumber>(builder.EndTable());
		}

		// Token: 0x0601FB9E RID: 129950 RVA: 0x00468CF8 File Offset: 0x00466EF8
		public ICheckLevelPlayCompleteNumberT UnPack()
		{
			ICheckLevelPlayCompleteNumberT checkLevelPlayCompleteNumberT = new ICheckLevelPlayCompleteNumberT();
			this.UnPackTo(checkLevelPlayCompleteNumberT);
			return checkLevelPlayCompleteNumberT;
		}

		// Token: 0x0601FB9F RID: 129951 RVA: 0x00468D13 File Offset: 0x00466F13
		public void UnPackTo(ICheckLevelPlayCompleteNumberT _o)
		{
			_o.Type = this.Type;
			_o.LevelId = this.LevelId;
			_o.Compare = this.Compare;
			_o.Number = this.Number;
		}

		// Token: 0x0601FBA0 RID: 129952 RVA: 0x00468D48 File Offset: 0x00466F48
		public static Offset<ICheckLevelPlayCompleteNumber> Pack(FlatBufferBuilder builder, ICheckLevelPlayCompleteNumberT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckLevelPlayCompleteNumber>);
			}
			return ICheckLevelPlayCompleteNumber.CreateICheckLevelPlayCompleteNumber(builder, _o.Type, _o.LevelId, _o.Compare, _o.Number);
		}

		// Token: 0x0400DE28 RID: 56872
		private Table __p;
	}
}
