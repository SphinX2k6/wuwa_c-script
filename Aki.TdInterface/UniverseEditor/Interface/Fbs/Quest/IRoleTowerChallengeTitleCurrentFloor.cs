using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044FF RID: 17663
	public struct IRoleTowerChallengeTitleCurrentFloor : IFlatbufferObject
	{
		// Token: 0x17007AFA RID: 31482
		// (get) Token: 0x060198FD RID: 104701 RVA: 0x003A4F75 File Offset: 0x003A3175
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060198FE RID: 104702 RVA: 0x003A4F82 File Offset: 0x003A3182
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060198FF RID: 104703 RVA: 0x003A4F8C File Offset: 0x003A318C
		public static IRoleTowerChallengeTitleCurrentFloor GetRootAsIRoleTowerChallengeTitleCurrentFloor(ByteBuffer _bb)
		{
			return IRoleTowerChallengeTitleCurrentFloor.GetRootAsIRoleTowerChallengeTitleCurrentFloor(_bb, default(IRoleTowerChallengeTitleCurrentFloor));
		}

		// Token: 0x06019900 RID: 104704 RVA: 0x003A4FA8 File Offset: 0x003A31A8
		public static IRoleTowerChallengeTitleCurrentFloor GetRootAsIRoleTowerChallengeTitleCurrentFloor(ByteBuffer _bb, IRoleTowerChallengeTitleCurrentFloor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019901 RID: 104705 RVA: 0x003A4FC5 File Offset: 0x003A31C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019902 RID: 104706 RVA: 0x003A4FD4 File Offset: 0x003A31D4
		public IRoleTowerChallengeTitleCurrentFloor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007AFB RID: 31483
		// (get) Token: 0x06019903 RID: 104707 RVA: 0x003A4FE4 File Offset: 0x003A31E4
		public ERoleTowerChallengeTitleType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERoleTowerChallengeTitleType.KillProgress;
				}
				return (ERoleTowerChallengeTitleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06019904 RID: 104708 RVA: 0x003A5020 File Offset: 0x003A3220
		public static Offset<IRoleTowerChallengeTitleCurrentFloor> CreateIRoleTowerChallengeTitleCurrentFloor(FlatBufferBuilder builder, ERoleTowerChallengeTitleType Type = ERoleTowerChallengeTitleType.KillProgress)
		{
			builder.StartTable(1);
			IRoleTowerChallengeTitleCurrentFloor.AddType(builder, Type);
			return IRoleTowerChallengeTitleCurrentFloor.EndIRoleTowerChallengeTitleCurrentFloor(builder);
		}

		// Token: 0x06019905 RID: 104709 RVA: 0x003A5036 File Offset: 0x003A3236
		public static void StartIRoleTowerChallengeTitleCurrentFloor(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06019906 RID: 104710 RVA: 0x003A503F File Offset: 0x003A323F
		public static void AddType(FlatBufferBuilder builder, ERoleTowerChallengeTitleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019907 RID: 104711 RVA: 0x003A504A File Offset: 0x003A324A
		public static Offset<IRoleTowerChallengeTitleCurrentFloor> EndIRoleTowerChallengeTitleCurrentFloor(FlatBufferBuilder builder)
		{
			return new Offset<IRoleTowerChallengeTitleCurrentFloor>(builder.EndTable());
		}

		// Token: 0x06019908 RID: 104712 RVA: 0x003A5058 File Offset: 0x003A3258
		public IRoleTowerChallengeTitleCurrentFloorT UnPack()
		{
			IRoleTowerChallengeTitleCurrentFloorT roleTowerChallengeTitleCurrentFloorT = new IRoleTowerChallengeTitleCurrentFloorT();
			this.UnPackTo(roleTowerChallengeTitleCurrentFloorT);
			return roleTowerChallengeTitleCurrentFloorT;
		}

		// Token: 0x06019909 RID: 104713 RVA: 0x003A5073 File Offset: 0x003A3273
		public void UnPackTo(IRoleTowerChallengeTitleCurrentFloorT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601990A RID: 104714 RVA: 0x003A5084 File Offset: 0x003A3284
		public static Offset<IRoleTowerChallengeTitleCurrentFloor> Pack(FlatBufferBuilder builder, IRoleTowerChallengeTitleCurrentFloorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoleTowerChallengeTitleCurrentFloor>);
			}
			return IRoleTowerChallengeTitleCurrentFloor.CreateIRoleTowerChallengeTitleCurrentFloor(builder, _o.Type);
		}

		// Token: 0x0400C63D RID: 50749
		private Table __p;
	}
}
