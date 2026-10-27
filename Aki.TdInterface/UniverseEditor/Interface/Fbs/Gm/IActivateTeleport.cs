using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x0200462A RID: 17962
	public struct IActivateTeleport : IFlatbufferObject
	{
		// Token: 0x17007F7C RID: 32636
		// (get) Token: 0x0601B33B RID: 111419 RVA: 0x003DFA06 File Offset: 0x003DDC06
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B33C RID: 111420 RVA: 0x003DFA13 File Offset: 0x003DDC13
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B33D RID: 111421 RVA: 0x003DFA1C File Offset: 0x003DDC1C
		public static IActivateTeleport GetRootAsIActivateTeleport(ByteBuffer _bb)
		{
			return IActivateTeleport.GetRootAsIActivateTeleport(_bb, default(IActivateTeleport));
		}

		// Token: 0x0601B33E RID: 111422 RVA: 0x003DFA38 File Offset: 0x003DDC38
		public static IActivateTeleport GetRootAsIActivateTeleport(ByteBuffer _bb, IActivateTeleport obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B33F RID: 111423 RVA: 0x003DFA55 File Offset: 0x003DDC55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B340 RID: 111424 RVA: 0x003DFA64 File Offset: 0x003DDC64
		public IActivateTeleport __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007F7D RID: 32637
		// (get) Token: 0x0601B341 RID: 111425 RVA: 0x003DFA74 File Offset: 0x003DDC74
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

		// Token: 0x17007F7E RID: 32638
		// (get) Token: 0x0601B342 RID: 111426 RVA: 0x003DFAB0 File Offset: 0x003DDCB0
		public int TeleportId
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

		// Token: 0x0601B343 RID: 111427 RVA: 0x003DFAEC File Offset: 0x003DDCEC
		public static Offset<IActivateTeleport> CreateIActivateTeleport(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, int TeleportId = 0)
		{
			builder.StartTable(2);
			IActivateTeleport.AddTeleportId(builder, TeleportId);
			IActivateTeleport.AddType(builder, Type);
			return IActivateTeleport.EndIActivateTeleport(builder);
		}

		// Token: 0x0601B344 RID: 111428 RVA: 0x003DFB09 File Offset: 0x003DDD09
		public static void StartIActivateTeleport(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601B345 RID: 111429 RVA: 0x003DFB12 File Offset: 0x003DDD12
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B346 RID: 111430 RVA: 0x003DFB1D File Offset: 0x003DDD1D
		public static void AddTeleportId(FlatBufferBuilder builder, int teleportId)
		{
			builder.AddInt(1, teleportId, 0);
		}

		// Token: 0x0601B347 RID: 111431 RVA: 0x003DFB28 File Offset: 0x003DDD28
		public static Offset<IActivateTeleport> EndIActivateTeleport(FlatBufferBuilder builder)
		{
			return new Offset<IActivateTeleport>(builder.EndTable());
		}

		// Token: 0x0601B348 RID: 111432 RVA: 0x003DFB38 File Offset: 0x003DDD38
		public IActivateTeleportT UnPack()
		{
			IActivateTeleportT activateTeleportT = new IActivateTeleportT();
			this.UnPackTo(activateTeleportT);
			return activateTeleportT;
		}

		// Token: 0x0601B349 RID: 111433 RVA: 0x003DFB53 File Offset: 0x003DDD53
		public void UnPackTo(IActivateTeleportT _o)
		{
			_o.Type = this.Type;
			_o.TeleportId = this.TeleportId;
		}

		// Token: 0x0601B34A RID: 111434 RVA: 0x003DFB70 File Offset: 0x003DDD70
		public static Offset<IActivateTeleport> Pack(FlatBufferBuilder builder, IActivateTeleportT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActivateTeleport>);
			}
			return IActivateTeleport.CreateIActivateTeleport(builder, _o.Type, _o.TeleportId);
		}

		// Token: 0x0400C7A3 RID: 51107
		private Table __p;
	}
}
