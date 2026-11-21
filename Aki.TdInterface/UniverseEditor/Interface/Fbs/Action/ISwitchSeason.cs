using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A3D RID: 31293
	public struct ISwitchSeason : IFlatbufferObject
	{
		// Token: 0x1700E545 RID: 58693
		// (get) Token: 0x0603724E RID: 225870 RVA: 0x0075DFDD File Offset: 0x0075C1DD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603724F RID: 225871 RVA: 0x0075DFEA File Offset: 0x0075C1EA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06037250 RID: 225872 RVA: 0x0075DFF4 File Offset: 0x0075C1F4
		public static ISwitchSeason GetRootAsISwitchSeason(ByteBuffer _bb)
		{
			return ISwitchSeason.GetRootAsISwitchSeason(_bb, default(ISwitchSeason));
		}

		// Token: 0x06037251 RID: 225873 RVA: 0x0075E010 File Offset: 0x0075C210
		public static ISwitchSeason GetRootAsISwitchSeason(ByteBuffer _bb, ISwitchSeason obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06037252 RID: 225874 RVA: 0x0075E02D File Offset: 0x0075C22D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06037253 RID: 225875 RVA: 0x0075E03C File Offset: 0x0075C23C
		public ISwitchSeason __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E546 RID: 58694
		// (get) Token: 0x06037254 RID: 225876 RVA: 0x0075E04C File Offset: 0x0075C24C
		public EClientSetSeasonStateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EClientSetSeasonStateType.SwitchSeason;
				}
				return (EClientSetSeasonStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E547 RID: 58695
		// (get) Token: 0x06037255 RID: 225877 RVA: 0x0075E088 File Offset: 0x0075C288
		public ESeason Season
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ESeason.Spring;
				}
				return (ESeason)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E548 RID: 58696
		// (get) Token: 0x06037256 RID: 225878 RVA: 0x0075E0C4 File Offset: 0x0075C2C4
		public float TransitionSpeed
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06037257 RID: 225879 RVA: 0x0075E104 File Offset: 0x0075C304
		public static Offset<ISwitchSeason> CreateISwitchSeason(FlatBufferBuilder builder, EClientSetSeasonStateType Type = EClientSetSeasonStateType.SwitchSeason, ESeason Season = ESeason.Spring, float TransitionSpeed = 0f)
		{
			builder.StartTable(3);
			ISwitchSeason.AddTransitionSpeed(builder, TransitionSpeed);
			ISwitchSeason.AddSeason(builder, Season);
			ISwitchSeason.AddType(builder, Type);
			return ISwitchSeason.EndISwitchSeason(builder);
		}

		// Token: 0x06037258 RID: 225880 RVA: 0x0075E128 File Offset: 0x0075C328
		public static void StartISwitchSeason(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06037259 RID: 225881 RVA: 0x0075E131 File Offset: 0x0075C331
		public static void AddType(FlatBufferBuilder builder, EClientSetSeasonStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603725A RID: 225882 RVA: 0x0075E13C File Offset: 0x0075C33C
		public static void AddSeason(FlatBufferBuilder builder, ESeason season)
		{
			builder.AddByte(1, (byte)season, 0);
		}

		// Token: 0x0603725B RID: 225883 RVA: 0x0075E147 File Offset: 0x0075C347
		public static void AddTransitionSpeed(FlatBufferBuilder builder, float transitionSpeed)
		{
			builder.AddFloat(2, transitionSpeed, 0.0);
		}

		// Token: 0x0603725C RID: 225884 RVA: 0x0075E15A File Offset: 0x0075C35A
		public static Offset<ISwitchSeason> EndISwitchSeason(FlatBufferBuilder builder)
		{
			return new Offset<ISwitchSeason>(builder.EndTable());
		}

		// Token: 0x0603725D RID: 225885 RVA: 0x0075E168 File Offset: 0x0075C368
		public ISwitchSeasonT UnPack()
		{
			ISwitchSeasonT switchSeasonT = new ISwitchSeasonT();
			this.UnPackTo(switchSeasonT);
			return switchSeasonT;
		}

		// Token: 0x0603725E RID: 225886 RVA: 0x0075E183 File Offset: 0x0075C383
		public void UnPackTo(ISwitchSeasonT _o)
		{
			_o.Type = this.Type;
			_o.Season = this.Season;
			_o.TransitionSpeed = this.TransitionSpeed;
		}

		// Token: 0x0603725F RID: 225887 RVA: 0x0075E1AC File Offset: 0x0075C3AC
		public static Offset<ISwitchSeason> Pack(FlatBufferBuilder builder, ISwitchSeasonT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISwitchSeason>);
			}
			return ISwitchSeason.CreateISwitchSeason(builder, _o.Type, _o.Season, _o.TransitionSpeed);
		}

		// Token: 0x04012D67 RID: 77159
		private Table __p;
	}
}
