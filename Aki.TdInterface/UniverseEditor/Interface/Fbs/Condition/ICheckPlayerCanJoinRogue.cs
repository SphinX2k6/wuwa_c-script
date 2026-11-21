using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FB6 RID: 20406
	public struct ICheckPlayerCanJoinRogue : IFlatbufferObject
	{
		// Token: 0x170091EF RID: 37359
		// (get) Token: 0x0601FCD5 RID: 130261 RVA: 0x0046B012 File Offset: 0x00469212
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FCD6 RID: 130262 RVA: 0x0046B01F File Offset: 0x0046921F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FCD7 RID: 130263 RVA: 0x0046B028 File Offset: 0x00469228
		public static ICheckPlayerCanJoinRogue GetRootAsICheckPlayerCanJoinRogue(ByteBuffer _bb)
		{
			return ICheckPlayerCanJoinRogue.GetRootAsICheckPlayerCanJoinRogue(_bb, default(ICheckPlayerCanJoinRogue));
		}

		// Token: 0x0601FCD8 RID: 130264 RVA: 0x0046B044 File Offset: 0x00469244
		public static ICheckPlayerCanJoinRogue GetRootAsICheckPlayerCanJoinRogue(ByteBuffer _bb, ICheckPlayerCanJoinRogue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FCD9 RID: 130265 RVA: 0x0046B061 File Offset: 0x00469261
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FCDA RID: 130266 RVA: 0x0046B070 File Offset: 0x00469270
		public ICheckPlayerCanJoinRogue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170091F0 RID: 37360
		// (get) Token: 0x0601FCDB RID: 130267 RVA: 0x0046B080 File Offset: 0x00469280
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

		// Token: 0x170091F1 RID: 37361
		// (get) Token: 0x0601FCDC RID: 130268 RVA: 0x0046B0BC File Offset: 0x004692BC
		public bool CanJoin
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170091F2 RID: 37362
		// (get) Token: 0x0601FCDD RID: 130269 RVA: 0x0046B0FC File Offset: 0x004692FC
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

		// Token: 0x0601FCDE RID: 130270 RVA: 0x0046B138 File Offset: 0x00469338
		public static Offset<ICheckPlayerCanJoinRogue> CreateICheckPlayerCanJoinRogue(FlatBufferBuilder builder, ECheckPlayerCanJoinActivityType Type = ECheckPlayerCanJoinActivityType.Rogue, bool CanJoin = false, ERogueThemeType RogueType = ERogueThemeType.ZhongQu)
		{
			builder.StartTable(3);
			ICheckPlayerCanJoinRogue.AddRogueType(builder, RogueType);
			ICheckPlayerCanJoinRogue.AddCanJoin(builder, CanJoin);
			ICheckPlayerCanJoinRogue.AddType(builder, Type);
			return ICheckPlayerCanJoinRogue.EndICheckPlayerCanJoinRogue(builder);
		}

		// Token: 0x0601FCDF RID: 130271 RVA: 0x0046B15C File Offset: 0x0046935C
		public static void StartICheckPlayerCanJoinRogue(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601FCE0 RID: 130272 RVA: 0x0046B165 File Offset: 0x00469365
		public static void AddType(FlatBufferBuilder builder, ECheckPlayerCanJoinActivityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FCE1 RID: 130273 RVA: 0x0046B170 File Offset: 0x00469370
		public static void AddCanJoin(FlatBufferBuilder builder, bool canJoin)
		{
			builder.AddBool(1, canJoin, false);
		}

		// Token: 0x0601FCE2 RID: 130274 RVA: 0x0046B17B File Offset: 0x0046937B
		public static void AddRogueType(FlatBufferBuilder builder, ERogueThemeType rogueType)
		{
			builder.AddByte(2, (byte)rogueType, 0);
		}

		// Token: 0x0601FCE3 RID: 130275 RVA: 0x0046B186 File Offset: 0x00469386
		public static Offset<ICheckPlayerCanJoinRogue> EndICheckPlayerCanJoinRogue(FlatBufferBuilder builder)
		{
			return new Offset<ICheckPlayerCanJoinRogue>(builder.EndTable());
		}

		// Token: 0x0601FCE4 RID: 130276 RVA: 0x0046B194 File Offset: 0x00469394
		public ICheckPlayerCanJoinRogueT UnPack()
		{
			ICheckPlayerCanJoinRogueT checkPlayerCanJoinRogueT = new ICheckPlayerCanJoinRogueT();
			this.UnPackTo(checkPlayerCanJoinRogueT);
			return checkPlayerCanJoinRogueT;
		}

		// Token: 0x0601FCE5 RID: 130277 RVA: 0x0046B1AF File Offset: 0x004693AF
		public void UnPackTo(ICheckPlayerCanJoinRogueT _o)
		{
			_o.Type = this.Type;
			_o.CanJoin = this.CanJoin;
			_o.RogueType = this.RogueType;
		}

		// Token: 0x0601FCE6 RID: 130278 RVA: 0x0046B1D8 File Offset: 0x004693D8
		public static Offset<ICheckPlayerCanJoinRogue> Pack(FlatBufferBuilder builder, ICheckPlayerCanJoinRogueT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckPlayerCanJoinRogue>);
			}
			return ICheckPlayerCanJoinRogue.CreateICheckPlayerCanJoinRogue(builder, _o.Type, _o.CanJoin, _o.RogueType);
		}

		// Token: 0x0400DE59 RID: 56921
		private Table __p;
	}
}
