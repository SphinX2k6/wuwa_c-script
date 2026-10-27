using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075B0 RID: 30128
	public struct IVisualNovelPerformanceModifyRole : IFlatbufferObject
	{
		// Token: 0x1700E4A2 RID: 58530
		// (get) Token: 0x06036D76 RID: 224630 RVA: 0x00771D18 File Offset: 0x0076FF18
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036D77 RID: 224631 RVA: 0x00771D25 File Offset: 0x0076FF25
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036D78 RID: 224632 RVA: 0x00771D2C File Offset: 0x0076FF2C
		public static IVisualNovelPerformanceModifyRole GetRootAsIVisualNovelPerformanceModifyRole(ByteBuffer _bb)
		{
			return IVisualNovelPerformanceModifyRole.GetRootAsIVisualNovelPerformanceModifyRole(_bb, default(IVisualNovelPerformanceModifyRole));
		}

		// Token: 0x06036D79 RID: 224633 RVA: 0x00771D48 File Offset: 0x0076FF48
		public static IVisualNovelPerformanceModifyRole GetRootAsIVisualNovelPerformanceModifyRole(ByteBuffer _bb, IVisualNovelPerformanceModifyRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036D7A RID: 224634 RVA: 0x00771D65 File Offset: 0x0076FF65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036D7B RID: 224635 RVA: 0x00771D74 File Offset: 0x0076FF74
		public IVisualNovelPerformanceModifyRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E4A3 RID: 58531
		// (get) Token: 0x06036D7C RID: 224636 RVA: 0x00771D84 File Offset: 0x0076FF84
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

		// Token: 0x1700E4A4 RID: 58532
		// (get) Token: 0x06036D7D RID: 224637 RVA: 0x00771DC0 File Offset: 0x0076FFC0
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

		// Token: 0x1700E4A5 RID: 58533
		// (get) Token: 0x06036D7E RID: 224638 RVA: 0x00771E00 File Offset: 0x00770000
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

		// Token: 0x1700E4A6 RID: 58534
		// (get) Token: 0x06036D7F RID: 224639 RVA: 0x00771E3C File Offset: 0x0077003C
		public IVisualNovelPortraitTransform? Transform
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IVisualNovelPortraitTransform?(default(IVisualNovelPortraitTransform).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700E4A7 RID: 58535
		// (get) Token: 0x06036D80 RID: 224640 RVA: 0x00771E9C File Offset: 0x0077009C
		public IVisualNovelRoleConfig? RoleConfig
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IVisualNovelRoleConfig?(default(IVisualNovelRoleConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700E4A8 RID: 58536
		// (get) Token: 0x06036D81 RID: 224641 RVA: 0x00771EFC File Offset: 0x007700FC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036D82 RID: 224642 RVA: 0x00771F39 File Offset: 0x00770139
		public static Offset<IVisualNovelPerformanceModifyRole> CreateIVisualNovelPerformanceModifyRole(FlatBufferBuilder builder, EVisualNovelPerformanceType Type = EVisualNovelPerformanceType.Enter, float StartTime = 0f, int WhoId = 0, Offset<IVisualNovelPortraitTransform> TransformOffset = default(Offset<IVisualNovelPortraitTransform>), Offset<IVisualNovelRoleConfig> RoleConfigOffset = default(Offset<IVisualNovelRoleConfig>), byte NullMask = 0)
		{
			builder.StartTable(6);
			IVisualNovelPerformanceModifyRole.AddRoleConfig(builder, RoleConfigOffset);
			IVisualNovelPerformanceModifyRole.AddTransform(builder, TransformOffset);
			IVisualNovelPerformanceModifyRole.AddWhoId(builder, WhoId);
			IVisualNovelPerformanceModifyRole.AddStartTime(builder, StartTime);
			IVisualNovelPerformanceModifyRole.AddNullMask(builder, NullMask);
			IVisualNovelPerformanceModifyRole.AddType(builder, Type);
			return IVisualNovelPerformanceModifyRole.EndIVisualNovelPerformanceModifyRole(builder);
		}

		// Token: 0x06036D83 RID: 224643 RVA: 0x00771F75 File Offset: 0x00770175
		public static void StartIVisualNovelPerformanceModifyRole(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06036D84 RID: 224644 RVA: 0x00771F7E File Offset: 0x0077017E
		public static void AddType(FlatBufferBuilder builder, EVisualNovelPerformanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036D85 RID: 224645 RVA: 0x00771F89 File Offset: 0x00770189
		public static void AddStartTime(FlatBufferBuilder builder, float startTime)
		{
			builder.AddFloat(1, startTime, 0.0);
		}

		// Token: 0x06036D86 RID: 224646 RVA: 0x00771F9C File Offset: 0x0077019C
		public static void AddWhoId(FlatBufferBuilder builder, int whoId)
		{
			builder.AddInt(2, whoId, 0);
		}

		// Token: 0x06036D87 RID: 224647 RVA: 0x00771FA7 File Offset: 0x007701A7
		public static void AddTransform(FlatBufferBuilder builder, Offset<IVisualNovelPortraitTransform> transformOffset)
		{
			builder.AddOffset(3, transformOffset.Value, 0);
		}

		// Token: 0x06036D88 RID: 224648 RVA: 0x00771FB7 File Offset: 0x007701B7
		public static void AddRoleConfig(FlatBufferBuilder builder, Offset<IVisualNovelRoleConfig> roleConfigOffset)
		{
			builder.AddOffset(4, roleConfigOffset.Value, 0);
		}

		// Token: 0x06036D89 RID: 224649 RVA: 0x00771FC7 File Offset: 0x007701C7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06036D8A RID: 224650 RVA: 0x00771FD2 File Offset: 0x007701D2
		public static Offset<IVisualNovelPerformanceModifyRole> EndIVisualNovelPerformanceModifyRole(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelPerformanceModifyRole>(builder.EndTable());
		}

		// Token: 0x06036D8B RID: 224651 RVA: 0x00771FE0 File Offset: 0x007701E0
		public IVisualNovelPerformanceModifyRoleT UnPack()
		{
			IVisualNovelPerformanceModifyRoleT visualNovelPerformanceModifyRoleT = new IVisualNovelPerformanceModifyRoleT();
			this.UnPackTo(visualNovelPerformanceModifyRoleT);
			return visualNovelPerformanceModifyRoleT;
		}

		// Token: 0x06036D8C RID: 224652 RVA: 0x00771FFC File Offset: 0x007701FC
		public void UnPackTo(IVisualNovelPerformanceModifyRoleT _o)
		{
			_o.Type = this.Type;
			_o.StartTime = this.StartTime;
			_o.WhoId = this.WhoId;
			_o.Transform = ((this.Transform != null) ? this.Transform.Value.UnPack() : null);
			_o.RoleConfig = ((this.RoleConfig != null) ? this.RoleConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06036D8D RID: 224653 RVA: 0x00772098 File Offset: 0x00770298
		public static Offset<IVisualNovelPerformanceModifyRole> Pack(FlatBufferBuilder builder, IVisualNovelPerformanceModifyRoleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelPerformanceModifyRole>);
			}
			Offset<IVisualNovelPortraitTransform> transformOffset = (_o.Transform == null) ? default(Offset<IVisualNovelPortraitTransform>) : IVisualNovelPortraitTransform.Pack(builder, _o.Transform);
			Offset<IVisualNovelRoleConfig> roleConfigOffset = (_o.RoleConfig == null) ? default(Offset<IVisualNovelRoleConfig>) : IVisualNovelRoleConfig.Pack(builder, _o.RoleConfig);
			return IVisualNovelPerformanceModifyRole.CreateIVisualNovelPerformanceModifyRole(builder, _o.Type, _o.StartTime, _o.WhoId, transformOffset, roleConfigOffset, _o.NullMask);
		}

		// Token: 0x040124EB RID: 74987
		private Table __p;
	}
}
