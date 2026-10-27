using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C8B RID: 19595
	public struct IPlayerEntity : IFlatbufferObject
	{
		// Token: 0x17008E48 RID: 36424
		// (get) Token: 0x0601F13D RID: 127293 RVA: 0x00457D04 File Offset: 0x00455F04
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F13E RID: 127294 RVA: 0x00457D11 File Offset: 0x00455F11
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F13F RID: 127295 RVA: 0x00457D18 File Offset: 0x00455F18
		public static IPlayerEntity GetRootAsIPlayerEntity(ByteBuffer _bb)
		{
			return IPlayerEntity.GetRootAsIPlayerEntity(_bb, default(IPlayerEntity));
		}

		// Token: 0x0601F140 RID: 127296 RVA: 0x00457D34 File Offset: 0x00455F34
		public static IPlayerEntity GetRootAsIPlayerEntity(ByteBuffer _bb, IPlayerEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F141 RID: 127297 RVA: 0x00457D51 File Offset: 0x00455F51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F142 RID: 127298 RVA: 0x00457D60 File Offset: 0x00455F60
		public IPlayerEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008E49 RID: 36425
		// (get) Token: 0x0601F143 RID: 127299 RVA: 0x00457D70 File Offset: 0x00455F70
		public ETargetEntityType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETargetEntityType.Target;
				}
				return (ETargetEntityType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F144 RID: 127300 RVA: 0x00457DAC File Offset: 0x00455FAC
		public static Offset<IPlayerEntity> CreateIPlayerEntity(FlatBufferBuilder builder, ETargetEntityType Type = ETargetEntityType.Target)
		{
			builder.StartTable(1);
			IPlayerEntity.AddType(builder, Type);
			return IPlayerEntity.EndIPlayerEntity(builder);
		}

		// Token: 0x0601F145 RID: 127301 RVA: 0x00457DC2 File Offset: 0x00455FC2
		public static void StartIPlayerEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601F146 RID: 127302 RVA: 0x00457DCB File Offset: 0x00455FCB
		public static void AddType(FlatBufferBuilder builder, ETargetEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F147 RID: 127303 RVA: 0x00457DD6 File Offset: 0x00455FD6
		public static Offset<IPlayerEntity> EndIPlayerEntity(FlatBufferBuilder builder)
		{
			return new Offset<IPlayerEntity>(builder.EndTable());
		}

		// Token: 0x0601F148 RID: 127304 RVA: 0x00457DE4 File Offset: 0x00455FE4
		public IPlayerEntityT UnPack()
		{
			IPlayerEntityT playerEntityT = new IPlayerEntityT();
			this.UnPackTo(playerEntityT);
			return playerEntityT;
		}

		// Token: 0x0601F149 RID: 127305 RVA: 0x00457DFF File Offset: 0x00455FFF
		public void UnPackTo(IPlayerEntityT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601F14A RID: 127306 RVA: 0x00457E10 File Offset: 0x00456010
		public static Offset<IPlayerEntity> Pack(FlatBufferBuilder builder, IPlayerEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayerEntity>);
			}
			return IPlayerEntity.CreateIPlayerEntity(builder, _o.Type);
		}

		// Token: 0x0400D645 RID: 54853
		private Table __p;
	}
}
