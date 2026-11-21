using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B69 RID: 31593
	public struct ITeleportDungeonPos : IFlatbufferObject
	{
		// Token: 0x1700EC94 RID: 60564
		// (get) Token: 0x06038E6E RID: 233070 RVA: 0x007B151A File Offset: 0x007AF71A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06038E6F RID: 233071 RVA: 0x007B1527 File Offset: 0x007AF727
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06038E70 RID: 233072 RVA: 0x007B1530 File Offset: 0x007AF730
		public static ITeleportDungeonPos GetRootAsITeleportDungeonPos(ByteBuffer _bb)
		{
			return ITeleportDungeonPos.GetRootAsITeleportDungeonPos(_bb, default(ITeleportDungeonPos));
		}

		// Token: 0x06038E71 RID: 233073 RVA: 0x007B154C File Offset: 0x007AF74C
		public static ITeleportDungeonPos GetRootAsITeleportDungeonPos(ByteBuffer _bb, ITeleportDungeonPos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06038E72 RID: 233074 RVA: 0x007B1569 File Offset: 0x007AF769
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06038E73 RID: 233075 RVA: 0x007B1578 File Offset: 0x007AF778
		public ITeleportDungeonPos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EC95 RID: 60565
		// (get) Token: 0x06038E74 RID: 233076 RVA: 0x007B1588 File Offset: 0x007AF788
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

		// Token: 0x1700EC96 RID: 60566
		// (get) Token: 0x06038E75 RID: 233077 RVA: 0x007B15C4 File Offset: 0x007AF7C4
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

		// Token: 0x06038E76 RID: 233078 RVA: 0x007B1621 File Offset: 0x007AF821
		public static Offset<ITeleportDungeonPos> CreateITeleportDungeonPos(FlatBufferBuilder builder, int DungeonId = 0, Offset<IVectorInfo> TeleportPosOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			ITeleportDungeonPos.AddTeleportPos(builder, TeleportPosOffset);
			ITeleportDungeonPos.AddDungeonId(builder, DungeonId);
			return ITeleportDungeonPos.EndITeleportDungeonPos(builder);
		}

		// Token: 0x06038E77 RID: 233079 RVA: 0x007B163E File Offset: 0x007AF83E
		public static void StartITeleportDungeonPos(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06038E78 RID: 233080 RVA: 0x007B1647 File Offset: 0x007AF847
		public static void AddDungeonId(FlatBufferBuilder builder, int dungeonId)
		{
			builder.AddInt(0, dungeonId, 0);
		}

		// Token: 0x06038E79 RID: 233081 RVA: 0x007B1652 File Offset: 0x007AF852
		public static void AddTeleportPos(FlatBufferBuilder builder, Offset<IVectorInfo> teleportPosOffset)
		{
			builder.AddOffset(1, teleportPosOffset.Value, 0);
		}

		// Token: 0x06038E7A RID: 233082 RVA: 0x007B1662 File Offset: 0x007AF862
		public static Offset<ITeleportDungeonPos> EndITeleportDungeonPos(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportDungeonPos>(builder.EndTable());
		}

		// Token: 0x06038E7B RID: 233083 RVA: 0x007B1670 File Offset: 0x007AF870
		public ITeleportDungeonPosT UnPack()
		{
			ITeleportDungeonPosT teleportDungeonPosT = new ITeleportDungeonPosT();
			this.UnPackTo(teleportDungeonPosT);
			return teleportDungeonPosT;
		}

		// Token: 0x06038E7C RID: 233084 RVA: 0x007B168C File Offset: 0x007AF88C
		public void UnPackTo(ITeleportDungeonPosT _o)
		{
			_o.DungeonId = this.DungeonId;
			_o.TeleportPos = ((this.TeleportPos != null) ? this.TeleportPos.Value.UnPack() : null);
		}

		// Token: 0x06038E7D RID: 233085 RVA: 0x007B16D4 File Offset: 0x007AF8D4
		public static Offset<ITeleportDungeonPos> Pack(FlatBufferBuilder builder, ITeleportDungeonPosT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportDungeonPos>);
			}
			Offset<IVectorInfo> teleportPosOffset = (_o.TeleportPos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.TeleportPos);
			return ITeleportDungeonPos.CreateITeleportDungeonPos(builder, _o.DungeonId, teleportPosOffset);
		}

		// Token: 0x040131B8 RID: 78264
		private Table __p;
	}
}
