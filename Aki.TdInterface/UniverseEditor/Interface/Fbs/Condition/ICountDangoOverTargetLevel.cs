using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BEF RID: 19439
	public struct ICountDangoOverTargetLevel : IFlatbufferObject
	{
		// Token: 0x17008D31 RID: 36145
		// (get) Token: 0x0601EC59 RID: 126041 RVA: 0x0044FA10 File Offset: 0x0044DC10
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EC5A RID: 126042 RVA: 0x0044FA1D File Offset: 0x0044DC1D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EC5B RID: 126043 RVA: 0x0044FA24 File Offset: 0x0044DC24
		public static ICountDangoOverTargetLevel GetRootAsICountDangoOverTargetLevel(ByteBuffer _bb)
		{
			return ICountDangoOverTargetLevel.GetRootAsICountDangoOverTargetLevel(_bb, default(ICountDangoOverTargetLevel));
		}

		// Token: 0x0601EC5C RID: 126044 RVA: 0x0044FA40 File Offset: 0x0044DC40
		public static ICountDangoOverTargetLevel GetRootAsICountDangoOverTargetLevel(ByteBuffer _bb, ICountDangoOverTargetLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EC5D RID: 126045 RVA: 0x0044FA5D File Offset: 0x0044DC5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EC5E RID: 126046 RVA: 0x0044FA6C File Offset: 0x0044DC6C
		public ICountDangoOverTargetLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008D32 RID: 36146
		// (get) Token: 0x0601EC5F RID: 126047 RVA: 0x0044FA7C File Offset: 0x0044DC7C
		public ECheckDangoCultivationProgressType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckDangoCultivationProgressType.CountDangoOverTargetLevel;
				}
				return (ECheckDangoCultivationProgressType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008D33 RID: 36147
		// (get) Token: 0x0601EC60 RID: 126048 RVA: 0x0044FAB8 File Offset: 0x0044DCB8
		public int TargetNumber
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

		// Token: 0x17008D34 RID: 36148
		// (get) Token: 0x0601EC61 RID: 126049 RVA: 0x0044FAF4 File Offset: 0x0044DCF4
		public int TargetLevel
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601EC62 RID: 126050 RVA: 0x0044FB30 File Offset: 0x0044DD30
		public static Offset<ICountDangoOverTargetLevel> CreateICountDangoOverTargetLevel(FlatBufferBuilder builder, ECheckDangoCultivationProgressType Type = ECheckDangoCultivationProgressType.CountDangoOverTargetLevel, int TargetNumber = 0, int TargetLevel = 0)
		{
			builder.StartTable(3);
			ICountDangoOverTargetLevel.AddTargetLevel(builder, TargetLevel);
			ICountDangoOverTargetLevel.AddTargetNumber(builder, TargetNumber);
			ICountDangoOverTargetLevel.AddType(builder, Type);
			return ICountDangoOverTargetLevel.EndICountDangoOverTargetLevel(builder);
		}

		// Token: 0x0601EC63 RID: 126051 RVA: 0x0044FB54 File Offset: 0x0044DD54
		public static void StartICountDangoOverTargetLevel(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601EC64 RID: 126052 RVA: 0x0044FB5D File Offset: 0x0044DD5D
		public static void AddType(FlatBufferBuilder builder, ECheckDangoCultivationProgressType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601EC65 RID: 126053 RVA: 0x0044FB68 File Offset: 0x0044DD68
		public static void AddTargetNumber(FlatBufferBuilder builder, int targetNumber)
		{
			builder.AddInt(1, targetNumber, 0);
		}

		// Token: 0x0601EC66 RID: 126054 RVA: 0x0044FB73 File Offset: 0x0044DD73
		public static void AddTargetLevel(FlatBufferBuilder builder, int targetLevel)
		{
			builder.AddInt(2, targetLevel, 0);
		}

		// Token: 0x0601EC67 RID: 126055 RVA: 0x0044FB7E File Offset: 0x0044DD7E
		public static Offset<ICountDangoOverTargetLevel> EndICountDangoOverTargetLevel(FlatBufferBuilder builder)
		{
			return new Offset<ICountDangoOverTargetLevel>(builder.EndTable());
		}

		// Token: 0x0601EC68 RID: 126056 RVA: 0x0044FB8C File Offset: 0x0044DD8C
		public ICountDangoOverTargetLevelT UnPack()
		{
			ICountDangoOverTargetLevelT countDangoOverTargetLevelT = new ICountDangoOverTargetLevelT();
			this.UnPackTo(countDangoOverTargetLevelT);
			return countDangoOverTargetLevelT;
		}

		// Token: 0x0601EC69 RID: 126057 RVA: 0x0044FBA7 File Offset: 0x0044DDA7
		public void UnPackTo(ICountDangoOverTargetLevelT _o)
		{
			_o.Type = this.Type;
			_o.TargetNumber = this.TargetNumber;
			_o.TargetLevel = this.TargetLevel;
		}

		// Token: 0x0601EC6A RID: 126058 RVA: 0x0044FBD0 File Offset: 0x0044DDD0
		public static Offset<ICountDangoOverTargetLevel> Pack(FlatBufferBuilder builder, ICountDangoOverTargetLevelT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICountDangoOverTargetLevel>);
			}
			return ICountDangoOverTargetLevel.CreateICountDangoOverTargetLevel(builder, _o.Type, _o.TargetNumber, _o.TargetLevel);
		}

		// Token: 0x0400D579 RID: 54649
		private Table __p;
	}
}
