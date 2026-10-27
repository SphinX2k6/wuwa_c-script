using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075AA RID: 30122
	public struct IVisualNovelPerformanceExit : IFlatbufferObject
	{
		// Token: 0x1700E488 RID: 58504
		// (get) Token: 0x06036D26 RID: 224550 RVA: 0x0077124F File Offset: 0x0076F44F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036D27 RID: 224551 RVA: 0x0077125C File Offset: 0x0076F45C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036D28 RID: 224552 RVA: 0x00771264 File Offset: 0x0076F464
		public static IVisualNovelPerformanceExit GetRootAsIVisualNovelPerformanceExit(ByteBuffer _bb)
		{
			return IVisualNovelPerformanceExit.GetRootAsIVisualNovelPerformanceExit(_bb, default(IVisualNovelPerformanceExit));
		}

		// Token: 0x06036D29 RID: 224553 RVA: 0x00771280 File Offset: 0x0076F480
		public static IVisualNovelPerformanceExit GetRootAsIVisualNovelPerformanceExit(ByteBuffer _bb, IVisualNovelPerformanceExit obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036D2A RID: 224554 RVA: 0x0077129D File Offset: 0x0076F49D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036D2B RID: 224555 RVA: 0x007712AC File Offset: 0x0076F4AC
		public IVisualNovelPerformanceExit __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E489 RID: 58505
		// (get) Token: 0x06036D2C RID: 224556 RVA: 0x007712BC File Offset: 0x0076F4BC
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

		// Token: 0x1700E48A RID: 58506
		// (get) Token: 0x06036D2D RID: 224557 RVA: 0x007712F8 File Offset: 0x0076F4F8
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

		// Token: 0x1700E48B RID: 58507
		// (get) Token: 0x06036D2E RID: 224558 RVA: 0x00771338 File Offset: 0x0076F538
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

		// Token: 0x1700E48C RID: 58508
		// (get) Token: 0x06036D2F RID: 224559 RVA: 0x00771374 File Offset: 0x0076F574
		public bool AllExit
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E48D RID: 58509
		// (get) Token: 0x06036D30 RID: 224560 RVA: 0x007713B4 File Offset: 0x0076F5B4
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

		// Token: 0x1700E48E RID: 58510
		// (get) Token: 0x06036D31 RID: 224561 RVA: 0x007713F8 File Offset: 0x0076F5F8
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

		// Token: 0x1700E48F RID: 58511
		// (get) Token: 0x06036D32 RID: 224562 RVA: 0x00771458 File Offset: 0x0076F658
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

		// Token: 0x06036D33 RID: 224563 RVA: 0x00771498 File Offset: 0x0076F698
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

		// Token: 0x06036D34 RID: 224564 RVA: 0x007714E7 File Offset: 0x0076F6E7
		public static void StartIVisualNovelPerformanceExit(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06036D35 RID: 224565 RVA: 0x007714F0 File Offset: 0x0076F6F0
		public static void AddType(FlatBufferBuilder builder, EVisualNovelPerformanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036D36 RID: 224566 RVA: 0x007714FB File Offset: 0x0076F6FB
		public static void AddStartTime(FlatBufferBuilder builder, float startTime)
		{
			builder.AddFloat(1, startTime, 0.0);
		}

		// Token: 0x06036D37 RID: 224567 RVA: 0x0077150E File Offset: 0x0076F70E
		public static void AddWhoId(FlatBufferBuilder builder, int whoId)
		{
			builder.AddInt(2, whoId, 0);
		}

		// Token: 0x06036D38 RID: 224568 RVA: 0x00771519 File Offset: 0x0076F719
		public static void AddAllExit(FlatBufferBuilder builder, bool allExit)
		{
			builder.AddBool(3, allExit, false);
		}

		// Token: 0x06036D39 RID: 224569 RVA: 0x00771524 File Offset: 0x0076F724
		public static void AddFadeOutTime(FlatBufferBuilder builder, float fadeOutTime)
		{
			builder.AddFloat(4, fadeOutTime, 0.0);
		}

		// Token: 0x06036D3A RID: 224570 RVA: 0x00771537 File Offset: 0x0076F737
		public static void AddRoleConfig(FlatBufferBuilder builder, Offset<IVisualNovelRoleConfig> roleConfigOffset)
		{
			builder.AddOffset(5, roleConfigOffset.Value, 0);
		}

		// Token: 0x06036D3B RID: 224571 RVA: 0x00771547 File Offset: 0x0076F747
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06036D3C RID: 224572 RVA: 0x00771552 File Offset: 0x0076F752
		public static Offset<IVisualNovelPerformanceExit> EndIVisualNovelPerformanceExit(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelPerformanceExit>(builder.EndTable());
		}

		// Token: 0x06036D3D RID: 224573 RVA: 0x00771560 File Offset: 0x0076F760
		public IVisualNovelPerformanceExitT UnPack()
		{
			IVisualNovelPerformanceExitT visualNovelPerformanceExitT = new IVisualNovelPerformanceExitT();
			this.UnPackTo(visualNovelPerformanceExitT);
			return visualNovelPerformanceExitT;
		}

		// Token: 0x06036D3E RID: 224574 RVA: 0x0077157C File Offset: 0x0076F77C
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

		// Token: 0x06036D3F RID: 224575 RVA: 0x00771600 File Offset: 0x0076F800
		public static Offset<IVisualNovelPerformanceExit> Pack(FlatBufferBuilder builder, IVisualNovelPerformanceExitT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelPerformanceExit>);
			}
			Offset<IVisualNovelRoleConfig> roleConfigOffset = (_o.RoleConfig == null) ? default(Offset<IVisualNovelRoleConfig>) : IVisualNovelRoleConfig.Pack(builder, _o.RoleConfig);
			return IVisualNovelPerformanceExit.CreateIVisualNovelPerformanceExit(builder, _o.Type, _o.StartTime, _o.WhoId, _o.AllExit, _o.FadeOutTime, roleConfigOffset, _o.NullMask);
		}

		// Token: 0x040124DD RID: 74973
		private Table __p;
	}
}
