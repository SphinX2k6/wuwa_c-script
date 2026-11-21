using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050DC RID: 20700
	public struct ICountDangoOverTargetLevel : IFlatbufferObject
	{
		// Token: 0x17009455 RID: 37973
		// (get) Token: 0x0602083F RID: 133183 RVA: 0x00483078 File Offset: 0x00481278
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020840 RID: 133184 RVA: 0x00483085 File Offset: 0x00481285
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020841 RID: 133185 RVA: 0x0048308C File Offset: 0x0048128C
		public static ICountDangoOverTargetLevel GetRootAsICountDangoOverTargetLevel(ByteBuffer _bb)
		{
			return ICountDangoOverTargetLevel.GetRootAsICountDangoOverTargetLevel(_bb, default(ICountDangoOverTargetLevel));
		}

		// Token: 0x06020842 RID: 133186 RVA: 0x004830A8 File Offset: 0x004812A8
		public static ICountDangoOverTargetLevel GetRootAsICountDangoOverTargetLevel(ByteBuffer _bb, ICountDangoOverTargetLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020843 RID: 133187 RVA: 0x004830C5 File Offset: 0x004812C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020844 RID: 133188 RVA: 0x004830D4 File Offset: 0x004812D4
		public ICountDangoOverTargetLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009456 RID: 37974
		// (get) Token: 0x06020845 RID: 133189 RVA: 0x004830E4 File Offset: 0x004812E4
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

		// Token: 0x17009457 RID: 37975
		// (get) Token: 0x06020846 RID: 133190 RVA: 0x00483120 File Offset: 0x00481320
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

		// Token: 0x17009458 RID: 37976
		// (get) Token: 0x06020847 RID: 133191 RVA: 0x0048315C File Offset: 0x0048135C
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

		// Token: 0x06020848 RID: 133192 RVA: 0x00483198 File Offset: 0x00481398
		public static Offset<ICountDangoOverTargetLevel> CreateICountDangoOverTargetLevel(FlatBufferBuilder builder, ECheckDangoCultivationProgressType Type = ECheckDangoCultivationProgressType.CountDangoOverTargetLevel, int TargetNumber = 0, int TargetLevel = 0)
		{
			builder.StartTable(3);
			ICountDangoOverTargetLevel.AddTargetLevel(builder, TargetLevel);
			ICountDangoOverTargetLevel.AddTargetNumber(builder, TargetNumber);
			ICountDangoOverTargetLevel.AddType(builder, Type);
			return ICountDangoOverTargetLevel.EndICountDangoOverTargetLevel(builder);
		}

		// Token: 0x06020849 RID: 133193 RVA: 0x004831BC File Offset: 0x004813BC
		public static void StartICountDangoOverTargetLevel(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602084A RID: 133194 RVA: 0x004831C5 File Offset: 0x004813C5
		public static void AddType(FlatBufferBuilder builder, ECheckDangoCultivationProgressType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602084B RID: 133195 RVA: 0x004831D0 File Offset: 0x004813D0
		public static void AddTargetNumber(FlatBufferBuilder builder, int targetNumber)
		{
			builder.AddInt(1, targetNumber, 0);
		}

		// Token: 0x0602084C RID: 133196 RVA: 0x004831DB File Offset: 0x004813DB
		public static void AddTargetLevel(FlatBufferBuilder builder, int targetLevel)
		{
			builder.AddInt(2, targetLevel, 0);
		}

		// Token: 0x0602084D RID: 133197 RVA: 0x004831E6 File Offset: 0x004813E6
		public static Offset<ICountDangoOverTargetLevel> EndICountDangoOverTargetLevel(FlatBufferBuilder builder)
		{
			return new Offset<ICountDangoOverTargetLevel>(builder.EndTable());
		}

		// Token: 0x0602084E RID: 133198 RVA: 0x004831F4 File Offset: 0x004813F4
		public ICountDangoOverTargetLevelT UnPack()
		{
			ICountDangoOverTargetLevelT countDangoOverTargetLevelT = new ICountDangoOverTargetLevelT();
			this.UnPackTo(countDangoOverTargetLevelT);
			return countDangoOverTargetLevelT;
		}

		// Token: 0x0602084F RID: 133199 RVA: 0x0048320F File Offset: 0x0048140F
		public void UnPackTo(ICountDangoOverTargetLevelT _o)
		{
			_o.Type = this.Type;
			_o.TargetNumber = this.TargetNumber;
			_o.TargetLevel = this.TargetLevel;
		}

		// Token: 0x06020850 RID: 133200 RVA: 0x00483238 File Offset: 0x00481438
		public static Offset<ICountDangoOverTargetLevel> Pack(FlatBufferBuilder builder, ICountDangoOverTargetLevelT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICountDangoOverTargetLevel>);
			}
			return ICountDangoOverTargetLevel.CreateICountDangoOverTargetLevel(builder, _o.Type, _o.TargetNumber, _o.TargetLevel);
		}

		// Token: 0x0400E090 RID: 57488
		private Table __p;
	}
}
