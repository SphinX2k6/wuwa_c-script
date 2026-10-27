using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040BE RID: 16574
	public struct IRoleTowerChallengeTitleCurrentFloor : IFlatbufferObject
	{
		// Token: 0x170074F4 RID: 29940
		// (get) Token: 0x0601825C RID: 98908 RVA: 0x0037B025 File Offset: 0x00379225
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601825D RID: 98909 RVA: 0x0037B032 File Offset: 0x00379232
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601825E RID: 98910 RVA: 0x0037B03C File Offset: 0x0037923C
		public static IRoleTowerChallengeTitleCurrentFloor GetRootAsIRoleTowerChallengeTitleCurrentFloor(ByteBuffer _bb)
		{
			return IRoleTowerChallengeTitleCurrentFloor.GetRootAsIRoleTowerChallengeTitleCurrentFloor(_bb, default(IRoleTowerChallengeTitleCurrentFloor));
		}

		// Token: 0x0601825F RID: 98911 RVA: 0x0037B058 File Offset: 0x00379258
		public static IRoleTowerChallengeTitleCurrentFloor GetRootAsIRoleTowerChallengeTitleCurrentFloor(ByteBuffer _bb, IRoleTowerChallengeTitleCurrentFloor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018260 RID: 98912 RVA: 0x0037B075 File Offset: 0x00379275
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018261 RID: 98913 RVA: 0x0037B084 File Offset: 0x00379284
		public IRoleTowerChallengeTitleCurrentFloor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170074F5 RID: 29941
		// (get) Token: 0x06018262 RID: 98914 RVA: 0x0037B094 File Offset: 0x00379294
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

		// Token: 0x06018263 RID: 98915 RVA: 0x0037B0D0 File Offset: 0x003792D0
		public static Offset<IRoleTowerChallengeTitleCurrentFloor> CreateIRoleTowerChallengeTitleCurrentFloor(FlatBufferBuilder builder, ERoleTowerChallengeTitleType Type = ERoleTowerChallengeTitleType.KillProgress)
		{
			builder.StartTable(1);
			IRoleTowerChallengeTitleCurrentFloor.AddType(builder, Type);
			return IRoleTowerChallengeTitleCurrentFloor.EndIRoleTowerChallengeTitleCurrentFloor(builder);
		}

		// Token: 0x06018264 RID: 98916 RVA: 0x0037B0E6 File Offset: 0x003792E6
		public static void StartIRoleTowerChallengeTitleCurrentFloor(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06018265 RID: 98917 RVA: 0x0037B0EF File Offset: 0x003792EF
		public static void AddType(FlatBufferBuilder builder, ERoleTowerChallengeTitleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018266 RID: 98918 RVA: 0x0037B0FA File Offset: 0x003792FA
		public static Offset<IRoleTowerChallengeTitleCurrentFloor> EndIRoleTowerChallengeTitleCurrentFloor(FlatBufferBuilder builder)
		{
			return new Offset<IRoleTowerChallengeTitleCurrentFloor>(builder.EndTable());
		}

		// Token: 0x06018267 RID: 98919 RVA: 0x0037B108 File Offset: 0x00379308
		public IRoleTowerChallengeTitleCurrentFloorT UnPack()
		{
			IRoleTowerChallengeTitleCurrentFloorT roleTowerChallengeTitleCurrentFloorT = new IRoleTowerChallengeTitleCurrentFloorT();
			this.UnPackTo(roleTowerChallengeTitleCurrentFloorT);
			return roleTowerChallengeTitleCurrentFloorT;
		}

		// Token: 0x06018268 RID: 98920 RVA: 0x0037B123 File Offset: 0x00379323
		public void UnPackTo(IRoleTowerChallengeTitleCurrentFloorT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06018269 RID: 98921 RVA: 0x0037B134 File Offset: 0x00379334
		public static Offset<IRoleTowerChallengeTitleCurrentFloor> Pack(FlatBufferBuilder builder, IRoleTowerChallengeTitleCurrentFloorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoleTowerChallengeTitleCurrentFloor>);
			}
			return IRoleTowerChallengeTitleCurrentFloor.CreateIRoleTowerChallengeTitleCurrentFloor(builder, _o.Type);
		}

		// Token: 0x0400BC54 RID: 48212
		private Table __p;
	}
}
