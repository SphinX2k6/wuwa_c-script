using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DA3 RID: 32163
	public struct IVisualNovelPerformanceExit : IFlatbufferObject
	{
		// Token: 0x1700F0B5 RID: 61621
		// (get) Token: 0x0603A154 RID: 237908 RVA: 0x007D47CF File Offset: 0x007D29CF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603A155 RID: 237909 RVA: 0x007D47DC File Offset: 0x007D29DC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603A156 RID: 237910 RVA: 0x007D47E4 File Offset: 0x007D29E4
		public static IVisualNovelPerformanceExit GetRootAsIVisualNovelPerformanceExit(ByteBuffer _bb)
		{
			return IVisualNovelPerformanceExit.GetRootAsIVisualNovelPerformanceExit(_bb, default(IVisualNovelPerformanceExit));
		}

		// Token: 0x0603A157 RID: 237911 RVA: 0x007D4800 File Offset: 0x007D2A00
		public static IVisualNovelPerformanceExit GetRootAsIVisualNovelPerformanceExit(ByteBuffer _bb, IVisualNovelPerformanceExit obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603A158 RID: 237912 RVA: 0x007D481D File Offset: 0x007D2A1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603A159 RID: 237913 RVA: 0x007D482C File Offset: 0x007D2A2C
		public IVisualNovelPerformanceExit __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F0B6 RID: 61622
		// (get) Token: 0x0603A15A RID: 237914 RVA: 0x007D483C File Offset: 0x007D2A3C
		public EVisualNovelPerformanceType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVisualNovelPerformanceType.Enter;
				}
				return (EVisualNovelPerformanceType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700F0B7 RID: 61623
		// (get) Token: 0x0603A15B RID: 237915 RVA: 0x007D4878 File Offset: 0x007D2A78
		public float StartTime
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700F0B8 RID: 61624
		// (get) Token: 0x0603A15C RID: 237916 RVA: 0x007D48B8 File Offset: 0x007D2AB8
		public int WhoId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700F0B9 RID: 61625
		// (get) Token: 0x0603A15D RID: 237917 RVA: 0x007D48F4 File Offset: 0x007D2AF4
		public bool AllExit
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700F0BA RID: 61626
		// (get) Token: 0x0603A15E RID: 237918 RVA: 0x007D4934 File Offset: 0x007D2B34
		public float FadeOutTime
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700F0BB RID: 61627
		// (get) Token: 0x0603A15F RID: 237919 RVA: 0x007D4978 File Offset: 0x007D2B78
		public IVisualNovelRoleConfig? RoleConfig
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new IVisualNovelRoleConfig?(default(IVisualNovelRoleConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700F0BC RID: 61628
		// (get) Token: 0x0603A160 RID: 237920 RVA: 0x007D49D8 File Offset: 0x007D2BD8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603A161 RID: 237921 RVA: 0x007D4A18 File Offset: 0x007D2C18
		public static Offset<IVisualNovelPerformanceExit> CreateIVisualNovelPerformanceExit(FlatBufferBuilder builder, EVisualNovelPerformanceType Type = EVisualNovelPerformanceType.Enter, float StartTime = 0f, int WhoId = 0, bool AllExit = false, float FadeOutTime = 0f, Offset<IVisualNovelRoleConfig> RoleConfigOffset = default(Offset<IVisualNovelRoleConfig>), byte NullMask = 0)
		{
			builder.StartTable(7);
			IVisualNovelPerformanceExit.AddRoleConfig(builder, RoleConfigOffset);
			IVisualNovelPerformanceExit.AddFadeOutTime(builder, FadeOutTime);
			IVisualNovelPerformanceExit.AddWhoId(builder, WhoId);
			IVisualNovelPerformanceExit.AddStartTime(builder, StartTime);
			IVisualNovelPerformanceExit.AddNullMask(builder, NullMask);
			IVisualNovelPerformanceExit.AddAllExit(builder, AllExit);
			IVisualNovelPerformanceExit.AddType(builder, Type);
			return IVisualNovelPerformanceExit.EndIVisualNovelPerformanceExit(builder);
		}

		// Token: 0x0603A162 RID: 237922 RVA: 0x007D4A67 File Offset: 0x007D2C67
		public static void StartIVisualNovelPerformanceExit(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0603A163 RID: 237923 RVA: 0x007D4A70 File Offset: 0x007D2C70
		public static void AddType(FlatBufferBuilder builder, EVisualNovelPerformanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603A164 RID: 237924 RVA: 0x007D4A7B File Offset: 0x007D2C7B
		public static void AddStartTime(FlatBufferBuilder builder, float startTime)
		{
			builder.AddFloat(1, startTime, 0.0);
		}

		// Token: 0x0603A165 RID: 237925 RVA: 0x007D4A8E File Offset: 0x007D2C8E
		public static void AddWhoId(FlatBufferBuilder builder, int whoId)
		{
			builder.AddInt(2, whoId, 0);
		}

		// Token: 0x0603A166 RID: 237926 RVA: 0x007D4A99 File Offset: 0x007D2C99
		public static void AddAllExit(FlatBufferBuilder builder, bool allExit)
		{
			builder.AddBool(3, allExit, false);
		}

		// Token: 0x0603A167 RID: 237927 RVA: 0x007D4AA4 File Offset: 0x007D2CA4
		public static void AddFadeOutTime(FlatBufferBuilder builder, float fadeOutTime)
		{
			builder.AddFloat(4, fadeOutTime, 0.0);
		}

		// Token: 0x0603A168 RID: 237928 RVA: 0x007D4AB7 File Offset: 0x007D2CB7
		public static void AddRoleConfig(FlatBufferBuilder builder, Offset<IVisualNovelRoleConfig> roleConfigOffset)
		{
			builder.AddOffset(5, roleConfigOffset.Value, 0);
		}

		// Token: 0x0603A169 RID: 237929 RVA: 0x007D4AC7 File Offset: 0x007D2CC7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0603A16A RID: 237930 RVA: 0x007D4AD2 File Offset: 0x007D2CD2
		public static Offset<IVisualNovelPerformanceExit> EndIVisualNovelPerformanceExit(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelPerformanceExit>(builder.EndTable());
		}

		// Token: 0x0603A16B RID: 237931 RVA: 0x007D4AE0 File Offset: 0x007D2CE0
		public IVisualNovelPerformanceExitT UnPack()
		{
			IVisualNovelPerformanceExitT visualNovelPerformanceExitT = new IVisualNovelPerformanceExitT();
			this.UnPackTo(visualNovelPerformanceExitT);
			return visualNovelPerformanceExitT;
		}

		// Token: 0x0603A16C RID: 237932 RVA: 0x007D4AFC File Offset: 0x007D2CFC
		public void UnPackTo(IVisualNovelPerformanceExitT _o)
		{
			_o.Type = this.Type;
			_o.StartTime = this.StartTime;
			_o.WhoId = this.WhoId;
			_o.AllExit = this.AllExit;
			_o.FadeOutTime = this.FadeOutTime;
			_o.RoleConfig = ((this.RoleConfig != null) ? this.RoleConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603A16D RID: 237933 RVA: 0x007D4B80 File Offset: 0x007D2D80
		public static Offset<IVisualNovelPerformanceExit> Pack(FlatBufferBuilder builder, IVisualNovelPerformanceExitT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelPerformanceExit>);
			}
			Offset<IVisualNovelRoleConfig> roleConfigOffset = (_o.RoleConfig == null) ? default(Offset<IVisualNovelRoleConfig>) : IVisualNovelRoleConfig.Pack(builder, _o.RoleConfig);
			return IVisualNovelPerformanceExit.CreateIVisualNovelPerformanceExit(builder, _o.Type, _o.StartTime, _o.WhoId, _o.AllExit, _o.FadeOutTime, roleConfigOffset, _o.NullMask);
		}

		// Token: 0x04013510 RID: 79120
		private Table __p;
	}
}
