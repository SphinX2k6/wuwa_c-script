using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EEE RID: 28398
	public struct IRogueSelectRoom : IFlatbufferObject
	{
		// Token: 0x1700D344 RID: 54084
		// (get) Token: 0x060322ED RID: 205549 RVA: 0x006C81E5 File Offset: 0x006C63E5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060322EE RID: 205550 RVA: 0x006C81F2 File Offset: 0x006C63F2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060322EF RID: 205551 RVA: 0x006C81FC File Offset: 0x006C63FC
		public static IRogueSelectRoom GetRootAsIRogueSelectRoom(ByteBuffer _bb)
		{
			return IRogueSelectRoom.GetRootAsIRogueSelectRoom(_bb, default(IRogueSelectRoom));
		}

		// Token: 0x060322F0 RID: 205552 RVA: 0x006C8218 File Offset: 0x006C6418
		public static IRogueSelectRoom GetRootAsIRogueSelectRoom(ByteBuffer _bb, IRogueSelectRoom obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060322F1 RID: 205553 RVA: 0x006C8235 File Offset: 0x006C6435
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060322F2 RID: 205554 RVA: 0x006C8244 File Offset: 0x006C6444
		public IRogueSelectRoom __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D345 RID: 54085
		// (get) Token: 0x060322F3 RID: 205555 RVA: 0x006C8254 File Offset: 0x006C6454
		public IRogueRoleSelectRoom? Config
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IRogueRoleSelectRoom?(default(IRogueRoleSelectRoom).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060322F4 RID: 205556 RVA: 0x006C82B1 File Offset: 0x006C64B1
		public static Offset<IRogueSelectRoom> CreateIRogueSelectRoom(FlatBufferBuilder builder, Offset<IRogueRoleSelectRoom> ConfigOffset = default(Offset<IRogueRoleSelectRoom>))
		{
			builder.StartTable(1);
			IRogueSelectRoom.AddConfig(builder, ConfigOffset);
			return IRogueSelectRoom.EndIRogueSelectRoom(builder);
		}

		// Token: 0x060322F5 RID: 205557 RVA: 0x006C82C7 File Offset: 0x006C64C7
		public static void StartIRogueSelectRoom(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060322F6 RID: 205558 RVA: 0x006C82D0 File Offset: 0x006C64D0
		public static void AddConfig(FlatBufferBuilder builder, Offset<IRogueRoleSelectRoom> configOffset)
		{
			builder.AddOffset(0, configOffset.Value, 0);
		}

		// Token: 0x060322F7 RID: 205559 RVA: 0x006C82E0 File Offset: 0x006C64E0
		public static Offset<IRogueSelectRoom> EndIRogueSelectRoom(FlatBufferBuilder builder)
		{
			return new Offset<IRogueSelectRoom>(builder.EndTable());
		}

		// Token: 0x060322F8 RID: 205560 RVA: 0x006C82F0 File Offset: 0x006C64F0
		public IRogueSelectRoomT UnPack()
		{
			IRogueSelectRoomT rogueSelectRoomT = new IRogueSelectRoomT();
			this.UnPackTo(rogueSelectRoomT);
			return rogueSelectRoomT;
		}

		// Token: 0x060322F9 RID: 205561 RVA: 0x006C830C File Offset: 0x006C650C
		public void UnPackTo(IRogueSelectRoomT _o)
		{
			_o.Config = ((this.Config != null) ? this.Config.Value.UnPack() : null);
		}

		// Token: 0x060322FA RID: 205562 RVA: 0x006C8348 File Offset: 0x006C6548
		public static Offset<IRogueSelectRoom> Pack(FlatBufferBuilder builder, IRogueSelectRoomT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRogueSelectRoom>);
			}
			Offset<IRogueRoleSelectRoom> configOffset = (_o.Config == null) ? default(Offset<IRogueRoleSelectRoom>) : IRogueRoleSelectRoom.Pack(builder, _o.Config);
			return IRogueSelectRoom.CreateIRogueSelectRoom(builder, configOffset);
		}

		// Token: 0x040118E2 RID: 71906
		private Table __p;
	}
}
