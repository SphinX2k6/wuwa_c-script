using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048A5 RID: 18597
	public struct IBlockFinishRouteResult : IFlatbufferObject
	{
		// Token: 0x17008154 RID: 33108
		// (get) Token: 0x0601B79D RID: 112541 RVA: 0x003E33CA File Offset: 0x003E15CA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B79E RID: 112542 RVA: 0x003E33D7 File Offset: 0x003E15D7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B79F RID: 112543 RVA: 0x003E33E0 File Offset: 0x003E15E0
		public static IBlockFinishRouteResult GetRootAsIBlockFinishRouteResult(ByteBuffer _bb)
		{
			return IBlockFinishRouteResult.GetRootAsIBlockFinishRouteResult(_bb, default(IBlockFinishRouteResult));
		}

		// Token: 0x0601B7A0 RID: 112544 RVA: 0x003E33FC File Offset: 0x003E15FC
		public static IBlockFinishRouteResult GetRootAsIBlockFinishRouteResult(ByteBuffer _bb, IBlockFinishRouteResult obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B7A1 RID: 112545 RVA: 0x003E3419 File Offset: 0x003E1619
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B7A2 RID: 112546 RVA: 0x003E3428 File Offset: 0x003E1628
		public IBlockFinishRouteResult __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008155 RID: 33109
		// (get) Token: 0x0601B7A3 RID: 112547 RVA: 0x003E3438 File Offset: 0x003E1638
		public EDartSkillResultType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDartSkillResultType.NoBust;
				}
				return (EDartSkillResultType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008156 RID: 33110
		// (get) Token: 0x0601B7A4 RID: 112548 RVA: 0x003E3474 File Offset: 0x003E1674
		public int ZoneCount
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

		// Token: 0x0601B7A5 RID: 112549 RVA: 0x003E34B0 File Offset: 0x003E16B0
		public static Offset<IBlockFinishRouteResult> CreateIBlockFinishRouteResult(FlatBufferBuilder builder, EDartSkillResultType Type = EDartSkillResultType.NoBust, int ZoneCount = 0)
		{
			builder.StartTable(2);
			IBlockFinishRouteResult.AddZoneCount(builder, ZoneCount);
			IBlockFinishRouteResult.AddType(builder, Type);
			return IBlockFinishRouteResult.EndIBlockFinishRouteResult(builder);
		}

		// Token: 0x0601B7A6 RID: 112550 RVA: 0x003E34CD File Offset: 0x003E16CD
		public static void StartIBlockFinishRouteResult(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601B7A7 RID: 112551 RVA: 0x003E34D6 File Offset: 0x003E16D6
		public static void AddType(FlatBufferBuilder builder, EDartSkillResultType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B7A8 RID: 112552 RVA: 0x003E34E1 File Offset: 0x003E16E1
		public static void AddZoneCount(FlatBufferBuilder builder, int zoneCount)
		{
			builder.AddInt(1, zoneCount, 0);
		}

		// Token: 0x0601B7A9 RID: 112553 RVA: 0x003E34EC File Offset: 0x003E16EC
		public static Offset<IBlockFinishRouteResult> EndIBlockFinishRouteResult(FlatBufferBuilder builder)
		{
			return new Offset<IBlockFinishRouteResult>(builder.EndTable());
		}

		// Token: 0x0601B7AA RID: 112554 RVA: 0x003E34FC File Offset: 0x003E16FC
		public IBlockFinishRouteResultT UnPack()
		{
			IBlockFinishRouteResultT blockFinishRouteResultT = new IBlockFinishRouteResultT();
			this.UnPackTo(blockFinishRouteResultT);
			return blockFinishRouteResultT;
		}

		// Token: 0x0601B7AB RID: 112555 RVA: 0x003E3517 File Offset: 0x003E1717
		public void UnPackTo(IBlockFinishRouteResultT _o)
		{
			_o.Type = this.Type;
			_o.ZoneCount = this.ZoneCount;
		}

		// Token: 0x0601B7AC RID: 112556 RVA: 0x003E3534 File Offset: 0x003E1734
		public static Offset<IBlockFinishRouteResult> Pack(FlatBufferBuilder builder, IBlockFinishRouteResultT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBlockFinishRouteResult>);
			}
			return IBlockFinishRouteResult.CreateIBlockFinishRouteResult(builder, _o.Type, _o.ZoneCount);
		}

		// Token: 0x0400CE39 RID: 52793
		private Table __p;
	}
}
