using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071A7 RID: 29095
	public struct IMechExecute : IFlatbufferObject
	{
		// Token: 0x1700D51E RID: 54558
		// (get) Token: 0x060329B6 RID: 207286 RVA: 0x006D6B19 File Offset: 0x006D4D19
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060329B7 RID: 207287 RVA: 0x006D6B26 File Offset: 0x006D4D26
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060329B8 RID: 207288 RVA: 0x006D6B30 File Offset: 0x006D4D30
		public static IMechExecute GetRootAsIMechExecute(ByteBuffer _bb)
		{
			return IMechExecute.GetRootAsIMechExecute(_bb, default(IMechExecute));
		}

		// Token: 0x060329B9 RID: 207289 RVA: 0x006D6B4C File Offset: 0x006D4D4C
		public static IMechExecute GetRootAsIMechExecute(ByteBuffer _bb, IMechExecute obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060329BA RID: 207290 RVA: 0x006D6B69 File Offset: 0x006D4D69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060329BB RID: 207291 RVA: 0x006D6B78 File Offset: 0x006D4D78
		public IMechExecute __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D51F RID: 54559
		// (get) Token: 0x060329BC RID: 207292 RVA: 0x006D6B88 File Offset: 0x006D4D88
		public EExecClientBattleActionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EExecClientBattleActionType.SendTagEventToControlCharacter;
				}
				return (EExecClientBattleActionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D520 RID: 54560
		// (get) Token: 0x060329BD RID: 207293 RVA: 0x006D6BC4 File Offset: 0x006D4DC4
		public int EntityId
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

		// Token: 0x060329BE RID: 207294 RVA: 0x006D6C00 File Offset: 0x006D4E00
		public static Offset<IMechExecute> CreateIMechExecute(FlatBufferBuilder builder, EExecClientBattleActionType Type = EExecClientBattleActionType.SendTagEventToControlCharacter, int EntityId = 0)
		{
			builder.StartTable(2);
			IMechExecute.AddEntityId(builder, EntityId);
			IMechExecute.AddType(builder, Type);
			return IMechExecute.EndIMechExecute(builder);
		}

		// Token: 0x060329BF RID: 207295 RVA: 0x006D6C1D File Offset: 0x006D4E1D
		public static void StartIMechExecute(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060329C0 RID: 207296 RVA: 0x006D6C26 File Offset: 0x006D4E26
		public static void AddType(FlatBufferBuilder builder, EExecClientBattleActionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060329C1 RID: 207297 RVA: 0x006D6C31 File Offset: 0x006D4E31
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x060329C2 RID: 207298 RVA: 0x006D6C3C File Offset: 0x006D4E3C
		public static Offset<IMechExecute> EndIMechExecute(FlatBufferBuilder builder)
		{
			return new Offset<IMechExecute>(builder.EndTable());
		}

		// Token: 0x060329C3 RID: 207299 RVA: 0x006D6C4C File Offset: 0x006D4E4C
		public IMechExecuteT UnPack()
		{
			IMechExecuteT mechExecuteT = new IMechExecuteT();
			this.UnPackTo(mechExecuteT);
			return mechExecuteT;
		}

		// Token: 0x060329C4 RID: 207300 RVA: 0x006D6C67 File Offset: 0x006D4E67
		public void UnPackTo(IMechExecuteT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x060329C5 RID: 207301 RVA: 0x006D6C84 File Offset: 0x006D4E84
		public static Offset<IMechExecute> Pack(FlatBufferBuilder builder, IMechExecuteT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMechExecute>);
			}
			return IMechExecute.CreateIMechExecute(builder, _o.Type, _o.EntityId);
		}

		// Token: 0x040121B6 RID: 74166
		private Table __p;
	}
}
