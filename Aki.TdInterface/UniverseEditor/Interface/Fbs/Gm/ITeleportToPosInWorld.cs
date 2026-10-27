using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x020046C6 RID: 18118
	public struct ITeleportToPosInWorld : IFlatbufferObject
	{
		// Token: 0x170080BB RID: 32955
		// (get) Token: 0x0601B8AB RID: 112811 RVA: 0x003E86A4 File Offset: 0x003E68A4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B8AC RID: 112812 RVA: 0x003E86B1 File Offset: 0x003E68B1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B8AD RID: 112813 RVA: 0x003E86B8 File Offset: 0x003E68B8
		public static ITeleportToPosInWorld GetRootAsITeleportToPosInWorld(ByteBuffer _bb)
		{
			return ITeleportToPosInWorld.GetRootAsITeleportToPosInWorld(_bb, default(ITeleportToPosInWorld));
		}

		// Token: 0x0601B8AE RID: 112814 RVA: 0x003E86D4 File Offset: 0x003E68D4
		public static ITeleportToPosInWorld GetRootAsITeleportToPosInWorld(ByteBuffer _bb, ITeleportToPosInWorld obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B8AF RID: 112815 RVA: 0x003E86F1 File Offset: 0x003E68F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B8B0 RID: 112816 RVA: 0x003E8700 File Offset: 0x003E6900
		public ITeleportToPosInWorld __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170080BC RID: 32956
		// (get) Token: 0x0601B8B1 RID: 112817 RVA: 0x003E8710 File Offset: 0x003E6910
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

		// Token: 0x170080BD RID: 32957
		// (get) Token: 0x0601B8B2 RID: 112818 RVA: 0x003E874C File Offset: 0x003E694C
		public IPosA? Pos
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IPosA?(default(IPosA).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170080BE RID: 32958
		// (get) Token: 0x0601B8B3 RID: 112819 RVA: 0x003E87AC File Offset: 0x003E69AC
		public int DungeonId
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

		// Token: 0x170080BF RID: 32959
		// (get) Token: 0x0601B8B4 RID: 112820 RVA: 0x003E87E8 File Offset: 0x003E69E8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B8B5 RID: 112821 RVA: 0x003E8825 File Offset: 0x003E6A25
		public static Offset<ITeleportToPosInWorld> CreateITeleportToPosInWorld(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, Offset<IPosA> PosOffset = default(Offset<IPosA>), int DungeonId = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			ITeleportToPosInWorld.AddDungeonId(builder, DungeonId);
			ITeleportToPosInWorld.AddPos(builder, PosOffset);
			ITeleportToPosInWorld.AddNullMask(builder, NullMask);
			ITeleportToPosInWorld.AddType(builder, Type);
			return ITeleportToPosInWorld.EndITeleportToPosInWorld(builder);
		}

		// Token: 0x0601B8B6 RID: 112822 RVA: 0x003E8851 File Offset: 0x003E6A51
		public static void StartITeleportToPosInWorld(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601B8B7 RID: 112823 RVA: 0x003E885A File Offset: 0x003E6A5A
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B8B8 RID: 112824 RVA: 0x003E8865 File Offset: 0x003E6A65
		public static void AddPos(FlatBufferBuilder builder, Offset<IPosA> posOffset)
		{
			builder.AddOffset(1, posOffset.Value, 0);
		}

		// Token: 0x0601B8B9 RID: 112825 RVA: 0x003E8875 File Offset: 0x003E6A75
		public static void AddDungeonId(FlatBufferBuilder builder, int dungeonId)
		{
			builder.AddInt(2, dungeonId, 0);
		}

		// Token: 0x0601B8BA RID: 112826 RVA: 0x003E8880 File Offset: 0x003E6A80
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0601B8BB RID: 112827 RVA: 0x003E888B File Offset: 0x003E6A8B
		public static Offset<ITeleportToPosInWorld> EndITeleportToPosInWorld(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportToPosInWorld>(builder.EndTable());
		}

		// Token: 0x0601B8BC RID: 112828 RVA: 0x003E8898 File Offset: 0x003E6A98
		public ITeleportToPosInWorldT UnPack()
		{
			ITeleportToPosInWorldT teleportToPosInWorldT = new ITeleportToPosInWorldT();
			this.UnPackTo(teleportToPosInWorldT);
			return teleportToPosInWorldT;
		}

		// Token: 0x0601B8BD RID: 112829 RVA: 0x003E88B4 File Offset: 0x003E6AB4
		public void UnPackTo(ITeleportToPosInWorldT _o)
		{
			_o.Type = this.Type;
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
			_o.DungeonId = this.DungeonId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601B8BE RID: 112830 RVA: 0x003E8914 File Offset: 0x003E6B14
		public static Offset<ITeleportToPosInWorld> Pack(FlatBufferBuilder builder, ITeleportToPosInWorldT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportToPosInWorld>);
			}
			Offset<IPosA> posOffset = (_o.Pos == null) ? default(Offset<IPosA>) : IPosA.Pack(builder, _o.Pos);
			return ITeleportToPosInWorld.CreateITeleportToPosInWorld(builder, _o.Type, posOffset, _o.DungeonId, _o.NullMask);
		}

		// Token: 0x0400C898 RID: 51352
		private Table __p;
	}
}
