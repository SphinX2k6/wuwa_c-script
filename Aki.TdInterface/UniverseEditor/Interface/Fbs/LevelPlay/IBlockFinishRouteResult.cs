using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200443D RID: 17469
	public struct IBlockFinishRouteResult : IFlatbufferObject
	{
		// Token: 0x17007B15 RID: 31509
		// (get) Token: 0x06019FCC RID: 106444 RVA: 0x003B71BE File Offset: 0x003B53BE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019FCD RID: 106445 RVA: 0x003B71CB File Offset: 0x003B53CB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019FCE RID: 106446 RVA: 0x003B71D4 File Offset: 0x003B53D4
		public static IBlockFinishRouteResult GetRootAsIBlockFinishRouteResult(ByteBuffer _bb)
		{
			return IBlockFinishRouteResult.GetRootAsIBlockFinishRouteResult(_bb, default(IBlockFinishRouteResult));
		}

		// Token: 0x06019FCF RID: 106447 RVA: 0x003B71F0 File Offset: 0x003B53F0
		public static IBlockFinishRouteResult GetRootAsIBlockFinishRouteResult(ByteBuffer _bb, IBlockFinishRouteResult obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019FD0 RID: 106448 RVA: 0x003B720D File Offset: 0x003B540D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019FD1 RID: 106449 RVA: 0x003B721C File Offset: 0x003B541C
		public IBlockFinishRouteResult __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007B16 RID: 31510
		// (get) Token: 0x06019FD2 RID: 106450 RVA: 0x003B722C File Offset: 0x003B542C
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

		// Token: 0x17007B17 RID: 31511
		// (get) Token: 0x06019FD3 RID: 106451 RVA: 0x003B7268 File Offset: 0x003B5468
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

		// Token: 0x06019FD4 RID: 106452 RVA: 0x003B72A4 File Offset: 0x003B54A4
		public static Offset<IBlockFinishRouteResult> CreateIBlockFinishRouteResult(FlatBufferBuilder builder, EDartSkillResultType Type = EDartSkillResultType.NoBust, int ZoneCount = 0)
		{
			builder.StartTable(2);
			IBlockFinishRouteResult.AddZoneCount(builder, ZoneCount);
			IBlockFinishRouteResult.AddType(builder, Type);
			return IBlockFinishRouteResult.EndIBlockFinishRouteResult(builder);
		}

		// Token: 0x06019FD5 RID: 106453 RVA: 0x003B72C1 File Offset: 0x003B54C1
		public static void StartIBlockFinishRouteResult(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06019FD6 RID: 106454 RVA: 0x003B72CA File Offset: 0x003B54CA
		public static void AddType(FlatBufferBuilder builder, EDartSkillResultType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019FD7 RID: 106455 RVA: 0x003B72D5 File Offset: 0x003B54D5
		public static void AddZoneCount(FlatBufferBuilder builder, int zoneCount)
		{
			builder.AddInt(1, zoneCount, 0);
		}

		// Token: 0x06019FD8 RID: 106456 RVA: 0x003B72E0 File Offset: 0x003B54E0
		public static Offset<IBlockFinishRouteResult> EndIBlockFinishRouteResult(FlatBufferBuilder builder)
		{
			return new Offset<IBlockFinishRouteResult>(builder.EndTable());
		}

		// Token: 0x06019FD9 RID: 106457 RVA: 0x003B72F0 File Offset: 0x003B54F0
		public IBlockFinishRouteResultT UnPack()
		{
			IBlockFinishRouteResultT blockFinishRouteResultT = new IBlockFinishRouteResultT();
			this.UnPackTo(blockFinishRouteResultT);
			return blockFinishRouteResultT;
		}

		// Token: 0x06019FDA RID: 106458 RVA: 0x003B730B File Offset: 0x003B550B
		public void UnPackTo(IBlockFinishRouteResultT _o)
		{
			_o.Type = this.Type;
			_o.ZoneCount = this.ZoneCount;
		}

		// Token: 0x06019FDB RID: 106459 RVA: 0x003B7328 File Offset: 0x003B5528
		public static Offset<IBlockFinishRouteResult> Pack(FlatBufferBuilder builder, IBlockFinishRouteResultT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBlockFinishRouteResult>);
			}
			return IBlockFinishRouteResult.CreateIBlockFinishRouteResult(builder, _o.Type, _o.ZoneCount);
		}

		// Token: 0x0400C40B RID: 50187
		private Table __p;
	}
}
