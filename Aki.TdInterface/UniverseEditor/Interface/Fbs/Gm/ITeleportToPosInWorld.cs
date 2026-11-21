using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004B2E RID: 19246
	public struct ITeleportToPosInWorld : IFlatbufferObject
	{
		// Token: 0x170086FC RID: 34556
		// (get) Token: 0x0601D080 RID: 118912 RVA: 0x00414940 File Offset: 0x00412B40
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D081 RID: 118913 RVA: 0x0041494D File Offset: 0x00412B4D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D082 RID: 118914 RVA: 0x00414954 File Offset: 0x00412B54
		public static ITeleportToPosInWorld GetRootAsITeleportToPosInWorld(ByteBuffer _bb)
		{
			return ITeleportToPosInWorld.GetRootAsITeleportToPosInWorld(_bb, default(ITeleportToPosInWorld));
		}

		// Token: 0x0601D083 RID: 118915 RVA: 0x00414970 File Offset: 0x00412B70
		public static ITeleportToPosInWorld GetRootAsITeleportToPosInWorld(ByteBuffer _bb, ITeleportToPosInWorld obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D084 RID: 118916 RVA: 0x0041498D File Offset: 0x00412B8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D085 RID: 118917 RVA: 0x0041499C File Offset: 0x00412B9C
		public ITeleportToPosInWorld __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170086FD RID: 34557
		// (get) Token: 0x0601D086 RID: 118918 RVA: 0x004149AC File Offset: 0x00412BAC
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

		// Token: 0x170086FE RID: 34558
		// (get) Token: 0x0601D087 RID: 118919 RVA: 0x004149E8 File Offset: 0x00412BE8
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

		// Token: 0x170086FF RID: 34559
		// (get) Token: 0x0601D088 RID: 118920 RVA: 0x00414A48 File Offset: 0x00412C48
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

		// Token: 0x17008700 RID: 34560
		// (get) Token: 0x0601D089 RID: 118921 RVA: 0x00414A84 File Offset: 0x00412C84
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

		// Token: 0x0601D08A RID: 118922 RVA: 0x00414AC1 File Offset: 0x00412CC1
		public static Offset<ITeleportToPosInWorld> CreateITeleportToPosInWorld(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, Offset<IPosA> PosOffset = default(Offset<IPosA>), int DungeonId = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			ITeleportToPosInWorld.AddDungeonId(builder, DungeonId);
			ITeleportToPosInWorld.AddPos(builder, PosOffset);
			ITeleportToPosInWorld.AddNullMask(builder, NullMask);
			ITeleportToPosInWorld.AddType(builder, Type);
			return ITeleportToPosInWorld.EndITeleportToPosInWorld(builder);
		}

		// Token: 0x0601D08B RID: 118923 RVA: 0x00414AED File Offset: 0x00412CED
		public static void StartITeleportToPosInWorld(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601D08C RID: 118924 RVA: 0x00414AF6 File Offset: 0x00412CF6
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D08D RID: 118925 RVA: 0x00414B01 File Offset: 0x00412D01
		public static void AddPos(FlatBufferBuilder builder, Offset<IPosA> posOffset)
		{
			builder.AddOffset(1, posOffset.Value, 0);
		}

		// Token: 0x0601D08E RID: 118926 RVA: 0x00414B11 File Offset: 0x00412D11
		public static void AddDungeonId(FlatBufferBuilder builder, int dungeonId)
		{
			builder.AddInt(2, dungeonId, 0);
		}

		// Token: 0x0601D08F RID: 118927 RVA: 0x00414B1C File Offset: 0x00412D1C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0601D090 RID: 118928 RVA: 0x00414B27 File Offset: 0x00412D27
		public static Offset<ITeleportToPosInWorld> EndITeleportToPosInWorld(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportToPosInWorld>(builder.EndTable());
		}

		// Token: 0x0601D091 RID: 118929 RVA: 0x00414B34 File Offset: 0x00412D34
		public ITeleportToPosInWorldT UnPack()
		{
			ITeleportToPosInWorldT teleportToPosInWorldT = new ITeleportToPosInWorldT();
			this.UnPackTo(teleportToPosInWorldT);
			return teleportToPosInWorldT;
		}

		// Token: 0x0601D092 RID: 118930 RVA: 0x00414B50 File Offset: 0x00412D50
		public void UnPackTo(ITeleportToPosInWorldT _o)
		{
			_o.Type = this.Type;
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
			_o.DungeonId = this.DungeonId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601D093 RID: 118931 RVA: 0x00414BB0 File Offset: 0x00412DB0
		public static Offset<ITeleportToPosInWorld> Pack(FlatBufferBuilder builder, ITeleportToPosInWorldT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportToPosInWorld>);
			}
			Offset<IPosA> posOffset = (_o.Pos == null) ? default(Offset<IPosA>) : IPosA.Pack(builder, _o.Pos);
			return ITeleportToPosInWorld.CreateITeleportToPosInWorld(builder, _o.Type, posOffset, _o.DungeonId, _o.NullMask);
		}

		// Token: 0x0400D2C7 RID: 53959
		private Table __p;
	}
}
