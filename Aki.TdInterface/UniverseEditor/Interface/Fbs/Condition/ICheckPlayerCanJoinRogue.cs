using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AE1 RID: 19169
	public struct ICheckPlayerCanJoinRogue : IFlatbufferObject
	{
		// Token: 0x17008AF8 RID: 35576
		// (get) Token: 0x0601E1C0 RID: 123328 RVA: 0x00439366 File Offset: 0x00437566
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E1C1 RID: 123329 RVA: 0x00439373 File Offset: 0x00437573
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E1C2 RID: 123330 RVA: 0x0043937C File Offset: 0x0043757C
		public static ICheckPlayerCanJoinRogue GetRootAsICheckPlayerCanJoinRogue(ByteBuffer _bb)
		{
			return ICheckPlayerCanJoinRogue.GetRootAsICheckPlayerCanJoinRogue(_bb, default(ICheckPlayerCanJoinRogue));
		}

		// Token: 0x0601E1C3 RID: 123331 RVA: 0x00439398 File Offset: 0x00437598
		public static ICheckPlayerCanJoinRogue GetRootAsICheckPlayerCanJoinRogue(ByteBuffer _bb, ICheckPlayerCanJoinRogue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E1C4 RID: 123332 RVA: 0x004393B5 File Offset: 0x004375B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E1C5 RID: 123333 RVA: 0x004393C4 File Offset: 0x004375C4
		public ICheckPlayerCanJoinRogue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008AF9 RID: 35577
		// (get) Token: 0x0601E1C6 RID: 123334 RVA: 0x004393D4 File Offset: 0x004375D4
		public ECheckPlayerCanJoinActivityType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckPlayerCanJoinActivityType.Rogue;
				}
				return (ECheckPlayerCanJoinActivityType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008AFA RID: 35578
		// (get) Token: 0x0601E1C7 RID: 123335 RVA: 0x00439410 File Offset: 0x00437610
		public bool CanJoin
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008AFB RID: 35579
		// (get) Token: 0x0601E1C8 RID: 123336 RVA: 0x00439450 File Offset: 0x00437650
		public ERogueThemeType RogueType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ERogueThemeType.ZhongQu;
				}
				return (ERogueThemeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E1C9 RID: 123337 RVA: 0x0043948C File Offset: 0x0043768C
		public static Offset<ICheckPlayerCanJoinRogue> CreateICheckPlayerCanJoinRogue(FlatBufferBuilder builder, ECheckPlayerCanJoinActivityType Type = ECheckPlayerCanJoinActivityType.Rogue, bool CanJoin = false, ERogueThemeType RogueType = ERogueThemeType.ZhongQu)
		{
			builder.StartTable(3);
			ICheckPlayerCanJoinRogue.AddRogueType(builder, RogueType);
			ICheckPlayerCanJoinRogue.AddCanJoin(builder, CanJoin);
			ICheckPlayerCanJoinRogue.AddType(builder, Type);
			return ICheckPlayerCanJoinRogue.EndICheckPlayerCanJoinRogue(builder);
		}

		// Token: 0x0601E1CA RID: 123338 RVA: 0x004394B0 File Offset: 0x004376B0
		public static void StartICheckPlayerCanJoinRogue(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601E1CB RID: 123339 RVA: 0x004394B9 File Offset: 0x004376B9
		public static void AddType(FlatBufferBuilder builder, ECheckPlayerCanJoinActivityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E1CC RID: 123340 RVA: 0x004394C4 File Offset: 0x004376C4
		public static void AddCanJoin(FlatBufferBuilder builder, bool canJoin)
		{
			builder.AddBool(1, canJoin, false);
		}

		// Token: 0x0601E1CD RID: 123341 RVA: 0x004394CF File Offset: 0x004376CF
		public static void AddRogueType(FlatBufferBuilder builder, ERogueThemeType rogueType)
		{
			builder.AddByte(2, (byte)rogueType, 0);
		}

		// Token: 0x0601E1CE RID: 123342 RVA: 0x004394DA File Offset: 0x004376DA
		public static Offset<ICheckPlayerCanJoinRogue> EndICheckPlayerCanJoinRogue(FlatBufferBuilder builder)
		{
			return new Offset<ICheckPlayerCanJoinRogue>(builder.EndTable());
		}

		// Token: 0x0601E1CF RID: 123343 RVA: 0x004394E8 File Offset: 0x004376E8
		public ICheckPlayerCanJoinRogueT UnPack()
		{
			ICheckPlayerCanJoinRogueT checkPlayerCanJoinRogueT = new ICheckPlayerCanJoinRogueT();
			this.UnPackTo(checkPlayerCanJoinRogueT);
			return checkPlayerCanJoinRogueT;
		}

		// Token: 0x0601E1D0 RID: 123344 RVA: 0x00439503 File Offset: 0x00437703
		public void UnPackTo(ICheckPlayerCanJoinRogueT _o)
		{
			_o.Type = this.Type;
			_o.CanJoin = this.CanJoin;
			_o.RogueType = this.RogueType;
		}

		// Token: 0x0601E1D1 RID: 123345 RVA: 0x0043952C File Offset: 0x0043772C
		public static Offset<ICheckPlayerCanJoinRogue> Pack(FlatBufferBuilder builder, ICheckPlayerCanJoinRogueT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckPlayerCanJoinRogue>);
			}
			return ICheckPlayerCanJoinRogue.CreateICheckPlayerCanJoinRogue(builder, _o.Type, _o.CanJoin, _o.RogueType);
		}

		// Token: 0x0400D36E RID: 54126
		private Table __p;
	}
}
