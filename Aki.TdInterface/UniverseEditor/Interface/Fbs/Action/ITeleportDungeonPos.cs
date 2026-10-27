using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007382 RID: 29570
	public struct ITeleportDungeonPos : IFlatbufferObject
	{
		// Token: 0x1700E084 RID: 57476
		// (get) Token: 0x06035AD3 RID: 219859 RVA: 0x0074EFDA File Offset: 0x0074D1DA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035AD4 RID: 219860 RVA: 0x0074EFE7 File Offset: 0x0074D1E7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035AD5 RID: 219861 RVA: 0x0074EFF0 File Offset: 0x0074D1F0
		public static ITeleportDungeonPos GetRootAsITeleportDungeonPos(ByteBuffer _bb)
		{
			return ITeleportDungeonPos.GetRootAsITeleportDungeonPos(_bb, default(ITeleportDungeonPos));
		}

		// Token: 0x06035AD6 RID: 219862 RVA: 0x0074F00C File Offset: 0x0074D20C
		public static ITeleportDungeonPos GetRootAsITeleportDungeonPos(ByteBuffer _bb, ITeleportDungeonPos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035AD7 RID: 219863 RVA: 0x0074F029 File Offset: 0x0074D229
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035AD8 RID: 219864 RVA: 0x0074F038 File Offset: 0x0074D238
		public ITeleportDungeonPos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E085 RID: 57477
		// (get) Token: 0x06035AD9 RID: 219865 RVA: 0x0074F048 File Offset: 0x0074D248
		public int DungeonId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E086 RID: 57478
		// (get) Token: 0x06035ADA RID: 219866 RVA: 0x0074F084 File Offset: 0x0074D284
		public IVectorInfo? TeleportPos
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06035ADB RID: 219867 RVA: 0x0074F0E1 File Offset: 0x0074D2E1
		public static Offset<ITeleportDungeonPos> CreateITeleportDungeonPos(FlatBufferBuilder builder, int DungeonId = 0, Offset<IVectorInfo> TeleportPosOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			ITeleportDungeonPos.AddTeleportPos(builder, TeleportPosOffset);
			ITeleportDungeonPos.AddDungeonId(builder, DungeonId);
			return ITeleportDungeonPos.EndITeleportDungeonPos(builder);
		}

		// Token: 0x06035ADC RID: 219868 RVA: 0x0074F0FE File Offset: 0x0074D2FE
		public static void StartITeleportDungeonPos(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06035ADD RID: 219869 RVA: 0x0074F107 File Offset: 0x0074D307
		public static void AddDungeonId(FlatBufferBuilder builder, int dungeonId)
		{
			builder.AddInt(0, dungeonId, 0);
		}

		// Token: 0x06035ADE RID: 219870 RVA: 0x0074F112 File Offset: 0x0074D312
		public static void AddTeleportPos(FlatBufferBuilder builder, Offset<IVectorInfo> teleportPosOffset)
		{
			builder.AddOffset(1, teleportPosOffset.Value, 0);
		}

		// Token: 0x06035ADF RID: 219871 RVA: 0x0074F122 File Offset: 0x0074D322
		public static Offset<ITeleportDungeonPos> EndITeleportDungeonPos(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportDungeonPos>(builder.EndTable());
		}

		// Token: 0x06035AE0 RID: 219872 RVA: 0x0074F130 File Offset: 0x0074D330
		public ITeleportDungeonPosT UnPack()
		{
			ITeleportDungeonPosT teleportDungeonPosT = new ITeleportDungeonPosT();
			this.UnPackTo(teleportDungeonPosT);
			return teleportDungeonPosT;
		}

		// Token: 0x06035AE1 RID: 219873 RVA: 0x0074F14C File Offset: 0x0074D34C
		public void UnPackTo(ITeleportDungeonPosT _o)
		{
			_o.DungeonId = this.DungeonId;
			_o.TeleportPos = ((this.TeleportPos != null) ? this.TeleportPos.Value.UnPack() : null);
		}

		// Token: 0x06035AE2 RID: 219874 RVA: 0x0074F194 File Offset: 0x0074D394
		public static Offset<ITeleportDungeonPos> Pack(FlatBufferBuilder builder, ITeleportDungeonPosT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportDungeonPos>);
			}
			Offset<IVectorInfo> teleportPosOffset = (_o.TeleportPos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.TeleportPos);
			return ITeleportDungeonPos.CreateITeleportDungeonPos(builder, _o.DungeonId, teleportPosOffset);
		}

		// Token: 0x0401219F RID: 74143
		private Table __p;
	}
}
