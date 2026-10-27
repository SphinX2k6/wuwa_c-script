using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AC0 RID: 19136
	public struct ICheckLevelPlayCompleteNumber : IFlatbufferObject
	{
		// Token: 0x17008AB5 RID: 35509
		// (get) Token: 0x0601E0A4 RID: 123044 RVA: 0x0043730C File Offset: 0x0043550C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E0A5 RID: 123045 RVA: 0x00437319 File Offset: 0x00435519
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E0A6 RID: 123046 RVA: 0x00437320 File Offset: 0x00435520
		public static ICheckLevelPlayCompleteNumber GetRootAsICheckLevelPlayCompleteNumber(ByteBuffer _bb)
		{
			return ICheckLevelPlayCompleteNumber.GetRootAsICheckLevelPlayCompleteNumber(_bb, default(ICheckLevelPlayCompleteNumber));
		}

		// Token: 0x0601E0A7 RID: 123047 RVA: 0x0043733C File Offset: 0x0043553C
		public static ICheckLevelPlayCompleteNumber GetRootAsICheckLevelPlayCompleteNumber(ByteBuffer _bb, ICheckLevelPlayCompleteNumber obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E0A8 RID: 123048 RVA: 0x00437359 File Offset: 0x00435559
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E0A9 RID: 123049 RVA: 0x00437368 File Offset: 0x00435568
		public ICheckLevelPlayCompleteNumber __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008AB6 RID: 35510
		// (get) Token: 0x0601E0AA RID: 123050 RVA: 0x00437378 File Offset: 0x00435578
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

		// Token: 0x17008AB7 RID: 35511
		// (get) Token: 0x0601E0AB RID: 123051 RVA: 0x004373B4 File Offset: 0x004355B4
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

		// Token: 0x17008AB8 RID: 35512
		// (get) Token: 0x0601E0AC RID: 123052 RVA: 0x004373F0 File Offset: 0x004355F0
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

		// Token: 0x17008AB9 RID: 35513
		// (get) Token: 0x0601E0AD RID: 123053 RVA: 0x0043742C File Offset: 0x0043562C
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

		// Token: 0x0601E0AE RID: 123054 RVA: 0x00437469 File Offset: 0x00435669
		public static Offset<ICheckLevelPlayCompleteNumber> CreateICheckLevelPlayCompleteNumber(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int LevelId = 0, ECompare Compare = ECompare.Eq, int Number = 0)
		{
			builder.StartTable(4);
			ICheckLevelPlayCompleteNumber.AddNumber(builder, Number);
			ICheckLevelPlayCompleteNumber.AddLevelId(builder, LevelId);
			ICheckLevelPlayCompleteNumber.AddCompare(builder, Compare);
			ICheckLevelPlayCompleteNumber.AddType(builder, Type);
			return ICheckLevelPlayCompleteNumber.EndICheckLevelPlayCompleteNumber(builder);
		}

		// Token: 0x0601E0AF RID: 123055 RVA: 0x00437495 File Offset: 0x00435695
		public static void StartICheckLevelPlayCompleteNumber(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601E0B0 RID: 123056 RVA: 0x0043749E File Offset: 0x0043569E
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E0B1 RID: 123057 RVA: 0x004374A9 File Offset: 0x004356A9
		public static void AddLevelId(FlatBufferBuilder builder, int levelId)
		{
			builder.AddInt(1, levelId, 0);
		}

		// Token: 0x0601E0B2 RID: 123058 RVA: 0x004374B4 File Offset: 0x004356B4
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x0601E0B3 RID: 123059 RVA: 0x004374BF File Offset: 0x004356BF
		public static void AddNumber(FlatBufferBuilder builder, int number)
		{
			builder.AddInt(3, number, 0);
		}

		// Token: 0x0601E0B4 RID: 123060 RVA: 0x004374CA File Offset: 0x004356CA
		public static Offset<ICheckLevelPlayCompleteNumber> EndICheckLevelPlayCompleteNumber(FlatBufferBuilder builder)
		{
			return new Offset<ICheckLevelPlayCompleteNumber>(builder.EndTable());
		}

		// Token: 0x0601E0B5 RID: 123061 RVA: 0x004374D8 File Offset: 0x004356D8
		public ICheckLevelPlayCompleteNumberT UnPack()
		{
			ICheckLevelPlayCompleteNumberT checkLevelPlayCompleteNumberT = new ICheckLevelPlayCompleteNumberT();
			this.UnPackTo(checkLevelPlayCompleteNumberT);
			return checkLevelPlayCompleteNumberT;
		}

		// Token: 0x0601E0B6 RID: 123062 RVA: 0x004374F3 File Offset: 0x004356F3
		public void UnPackTo(ICheckLevelPlayCompleteNumberT _o)
		{
			_o.Type = this.Type;
			_o.LevelId = this.LevelId;
			_o.Compare = this.Compare;
			_o.Number = this.Number;
		}

		// Token: 0x0601E0B7 RID: 123063 RVA: 0x00437528 File Offset: 0x00435728
		public static Offset<ICheckLevelPlayCompleteNumber> Pack(FlatBufferBuilder builder, ICheckLevelPlayCompleteNumberT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckLevelPlayCompleteNumber>);
			}
			return ICheckLevelPlayCompleteNumber.CreateICheckLevelPlayCompleteNumber(builder, _o.Type, _o.LevelId, _o.Compare, _o.Number);
		}

		// Token: 0x0400D343 RID: 54083
		private Table __p;
	}
}
