using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007268 RID: 29288
	public struct ISwitchSeason : IFlatbufferObject
	{
		// Token: 0x1700D94C RID: 55628
		// (get) Token: 0x06033F4C RID: 212812 RVA: 0x006FCC7D File Offset: 0x006FAE7D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033F4D RID: 212813 RVA: 0x006FCC8A File Offset: 0x006FAE8A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033F4E RID: 212814 RVA: 0x006FCC94 File Offset: 0x006FAE94
		public static ISwitchSeason GetRootAsISwitchSeason(ByteBuffer _bb)
		{
			return ISwitchSeason.GetRootAsISwitchSeason(_bb, default(ISwitchSeason));
		}

		// Token: 0x06033F4F RID: 212815 RVA: 0x006FCCB0 File Offset: 0x006FAEB0
		public static ISwitchSeason GetRootAsISwitchSeason(ByteBuffer _bb, ISwitchSeason obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033F50 RID: 212816 RVA: 0x006FCCCD File Offset: 0x006FAECD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033F51 RID: 212817 RVA: 0x006FCCDC File Offset: 0x006FAEDC
		public ISwitchSeason __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D94D RID: 55629
		// (get) Token: 0x06033F52 RID: 212818 RVA: 0x006FCCEC File Offset: 0x006FAEEC
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

		// Token: 0x1700D94E RID: 55630
		// (get) Token: 0x06033F53 RID: 212819 RVA: 0x006FCD28 File Offset: 0x006FAF28
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

		// Token: 0x1700D94F RID: 55631
		// (get) Token: 0x06033F54 RID: 212820 RVA: 0x006FCD64 File Offset: 0x006FAF64
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

		// Token: 0x06033F55 RID: 212821 RVA: 0x006FCDA4 File Offset: 0x006FAFA4
		public static Offset<ISwitchSeason> CreateISwitchSeason(FlatBufferBuilder builder, EClientSetSeasonStateType Type = EClientSetSeasonStateType.SwitchSeason, ESeason Season = ESeason.Spring, float TransitionSpeed = 0f)
		{
			builder.StartTable(3);
			ISwitchSeason.AddTransitionSpeed(builder, TransitionSpeed);
			ISwitchSeason.AddSeason(builder, Season);
			ISwitchSeason.AddType(builder, Type);
			return ISwitchSeason.EndISwitchSeason(builder);
		}

		// Token: 0x06033F56 RID: 212822 RVA: 0x006FCDC8 File Offset: 0x006FAFC8
		public static void StartISwitchSeason(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06033F57 RID: 212823 RVA: 0x006FCDD1 File Offset: 0x006FAFD1
		public static void AddType(FlatBufferBuilder builder, EClientSetSeasonStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033F58 RID: 212824 RVA: 0x006FCDDC File Offset: 0x006FAFDC
		public static void AddSeason(FlatBufferBuilder builder, ESeason season)
		{
			builder.AddByte(1, (byte)season, 0);
		}

		// Token: 0x06033F59 RID: 212825 RVA: 0x006FCDE7 File Offset: 0x006FAFE7
		public static void AddTransitionSpeed(FlatBufferBuilder builder, float transitionSpeed)
		{
			builder.AddFloat(2, transitionSpeed, 0.0);
		}

		// Token: 0x06033F5A RID: 212826 RVA: 0x006FCDFA File Offset: 0x006FAFFA
		public static Offset<ISwitchSeason> EndISwitchSeason(FlatBufferBuilder builder)
		{
			return new Offset<ISwitchSeason>(builder.EndTable());
		}

		// Token: 0x06033F5B RID: 212827 RVA: 0x006FCE08 File Offset: 0x006FB008
		public ISwitchSeasonT UnPack()
		{
			ISwitchSeasonT switchSeasonT = new ISwitchSeasonT();
			this.UnPackTo(switchSeasonT);
			return switchSeasonT;
		}

		// Token: 0x06033F5C RID: 212828 RVA: 0x006FCE23 File Offset: 0x006FB023
		public void UnPackTo(ISwitchSeasonT _o)
		{
			_o.Type = this.Type;
			_o.Season = this.Season;
			_o.TransitionSpeed = this.TransitionSpeed;
		}

		// Token: 0x06033F5D RID: 212829 RVA: 0x006FCE4C File Offset: 0x006FB04C
		public static Offset<ISwitchSeason> Pack(FlatBufferBuilder builder, ISwitchSeasonT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISwitchSeason>);
			}
			return ISwitchSeason.CreateISwitchSeason(builder, _o.Type, _o.Season, _o.TransitionSpeed);
		}

		// Token: 0x04011D65 RID: 73061
		private Table __p;
	}
}
