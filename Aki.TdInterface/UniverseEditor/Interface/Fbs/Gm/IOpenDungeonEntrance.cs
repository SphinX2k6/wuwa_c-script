using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AE0 RID: 19168
	public struct IOpenDungeonEntrance : IFlatbufferObject
	{
		// Token: 0x1700865C RID: 34396
		// (get) Token: 0x0601CE00 RID: 118272 RVA: 0x00410A35 File Offset: 0x0040EC35
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CE01 RID: 118273 RVA: 0x00410A42 File Offset: 0x0040EC42
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CE02 RID: 118274 RVA: 0x00410A4C File Offset: 0x0040EC4C
		public static IOpenDungeonEntrance GetRootAsIOpenDungeonEntrance(ByteBuffer _bb)
		{
			return IOpenDungeonEntrance.GetRootAsIOpenDungeonEntrance(_bb, default(IOpenDungeonEntrance));
		}

		// Token: 0x0601CE03 RID: 118275 RVA: 0x00410A68 File Offset: 0x0040EC68
		public static IOpenDungeonEntrance GetRootAsIOpenDungeonEntrance(ByteBuffer _bb, IOpenDungeonEntrance obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CE04 RID: 118276 RVA: 0x00410A85 File Offset: 0x0040EC85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CE05 RID: 118277 RVA: 0x00410A94 File Offset: 0x0040EC94
		public IOpenDungeonEntrance __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700865D RID: 34397
		// (get) Token: 0x0601CE06 RID: 118278 RVA: 0x00410AA4 File Offset: 0x0040ECA4
		public EGmCommand Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGmCommand.SkipToLevelPlayNode;
				}
				return (EGmCommand)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700865E RID: 34398
		// (get) Token: 0x0601CE07 RID: 118279 RVA: 0x00410AE0 File Offset: 0x0040ECE0
		public int EntranceId
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

		// Token: 0x0601CE08 RID: 118280 RVA: 0x00410B1C File Offset: 0x0040ED1C
		public static Offset<IOpenDungeonEntrance> CreateIOpenDungeonEntrance(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, int EntranceId = 0)
		{
			builder.StartTable(2);
			IOpenDungeonEntrance.AddEntranceId(builder, EntranceId);
			IOpenDungeonEntrance.AddType(builder, Type);
			return IOpenDungeonEntrance.EndIOpenDungeonEntrance(builder);
		}

		// Token: 0x0601CE09 RID: 118281 RVA: 0x00410B39 File Offset: 0x0040ED39
		public static void StartIOpenDungeonEntrance(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601CE0A RID: 118282 RVA: 0x00410B42 File Offset: 0x0040ED42
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601CE0B RID: 118283 RVA: 0x00410B4D File Offset: 0x0040ED4D
		public static void AddEntranceId(FlatBufferBuilder builder, int entranceId)
		{
			builder.AddInt(1, entranceId, 0);
		}

		// Token: 0x0601CE0C RID: 118284 RVA: 0x00410B58 File Offset: 0x0040ED58
		public static Offset<IOpenDungeonEntrance> EndIOpenDungeonEntrance(FlatBufferBuilder builder)
		{
			return new Offset<IOpenDungeonEntrance>(builder.EndTable());
		}

		// Token: 0x0601CE0D RID: 118285 RVA: 0x00410B68 File Offset: 0x0040ED68
		public IOpenDungeonEntranceT UnPack()
		{
			IOpenDungeonEntranceT openDungeonEntranceT = new IOpenDungeonEntranceT();
			this.UnPackTo(openDungeonEntranceT);
			return openDungeonEntranceT;
		}

		// Token: 0x0601CE0E RID: 118286 RVA: 0x00410B83 File Offset: 0x0040ED83
		public void UnPackTo(IOpenDungeonEntranceT _o)
		{
			_o.Type = this.Type;
			_o.EntranceId = this.EntranceId;
		}

		// Token: 0x0601CE0F RID: 118287 RVA: 0x00410BA0 File Offset: 0x0040EDA0
		public static Offset<IOpenDungeonEntrance> Pack(FlatBufferBuilder builder, IOpenDungeonEntranceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOpenDungeonEntrance>);
			}
			return IOpenDungeonEntrance.CreateIOpenDungeonEntrance(builder, _o.Type, _o.EntranceId);
		}

		// Token: 0x0400D26A RID: 53866
		private Table __p;
	}
}
