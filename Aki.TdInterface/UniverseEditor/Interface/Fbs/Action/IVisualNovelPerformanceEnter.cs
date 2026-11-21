using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D9D RID: 32157
	public struct IVisualNovelPerformanceEnter : IFlatbufferObject
	{
		// Token: 0x1700F099 RID: 61593
		// (get) Token: 0x0603A100 RID: 237824 RVA: 0x007D3BEB File Offset: 0x007D1DEB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603A101 RID: 237825 RVA: 0x007D3BF8 File Offset: 0x007D1DF8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603A102 RID: 237826 RVA: 0x007D3C00 File Offset: 0x007D1E00
		public static IVisualNovelPerformanceEnter GetRootAsIVisualNovelPerformanceEnter(ByteBuffer _bb)
		{
			return IVisualNovelPerformanceEnter.GetRootAsIVisualNovelPerformanceEnter(_bb, default(IVisualNovelPerformanceEnter));
		}

		// Token: 0x0603A103 RID: 237827 RVA: 0x007D3C1C File Offset: 0x007D1E1C
		public static IVisualNovelPerformanceEnter GetRootAsIVisualNovelPerformanceEnter(ByteBuffer _bb, IVisualNovelPerformanceEnter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603A104 RID: 237828 RVA: 0x007D3C39 File Offset: 0x007D1E39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603A105 RID: 237829 RVA: 0x007D3C48 File Offset: 0x007D1E48
		public IVisualNovelPerformanceEnter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F09A RID: 61594
		// (get) Token: 0x0603A106 RID: 237830 RVA: 0x007D3C58 File Offset: 0x007D1E58
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

		// Token: 0x1700F09B RID: 61595
		// (get) Token: 0x0603A107 RID: 237831 RVA: 0x007D3C94 File Offset: 0x007D1E94
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

		// Token: 0x1700F09C RID: 61596
		// (get) Token: 0x0603A108 RID: 237832 RVA: 0x007D3CD4 File Offset: 0x007D1ED4
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

		// Token: 0x1700F09D RID: 61597
		// (get) Token: 0x0603A109 RID: 237833 RVA: 0x007D3D10 File Offset: 0x007D1F10
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

		// Token: 0x1700F09E RID: 61598
		// (get) Token: 0x0603A10A RID: 237834 RVA: 0x007D3D70 File Offset: 0x007D1F70
		public float FadeInTime
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

		// Token: 0x1700F09F RID: 61599
		// (get) Token: 0x0603A10B RID: 237835 RVA: 0x007D3DB4 File Offset: 0x007D1FB4
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

		// Token: 0x1700F0A0 RID: 61600
		// (get) Token: 0x0603A10C RID: 237836 RVA: 0x007D3E14 File Offset: 0x007D2014
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

		// Token: 0x0603A10D RID: 237837 RVA: 0x007D3E54 File Offset: 0x007D2054
		public static Offset<IVisualNovelPerformanceEnter> CreateIVisualNovelPerformanceEnter(FlatBufferBuilder builder, EVisualNovelPerformanceType Type = EVisualNovelPerformanceType.Enter, float StartTime = 0f, int WhoId = 0, Offset<IVisualNovelPortraitTransform> TransformOffset = default(Offset<IVisualNovelPortraitTransform>), float FadeInTime = 0f, Offset<IVisualNovelRoleConfig> RoleConfigOffset = default(Offset<IVisualNovelRoleConfig>), byte NullMask = 0)
		{
			builder.StartTable(7);
			IVisualNovelPerformanceEnter.AddRoleConfig(builder, RoleConfigOffset);
			IVisualNovelPerformanceEnter.AddFadeInTime(builder, FadeInTime);
			IVisualNovelPerformanceEnter.AddTransform(builder, TransformOffset);
			IVisualNovelPerformanceEnter.AddWhoId(builder, WhoId);
			IVisualNovelPerformanceEnter.AddStartTime(builder, StartTime);
			IVisualNovelPerformanceEnter.AddNullMask(builder, NullMask);
			IVisualNovelPerformanceEnter.AddType(builder, Type);
			return IVisualNovelPerformanceEnter.EndIVisualNovelPerformanceEnter(builder);
		}

		// Token: 0x0603A10E RID: 237838 RVA: 0x007D3EA3 File Offset: 0x007D20A3
		public static void StartIVisualNovelPerformanceEnter(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0603A10F RID: 237839 RVA: 0x007D3EAC File Offset: 0x007D20AC
		public static void AddType(FlatBufferBuilder builder, EVisualNovelPerformanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603A110 RID: 237840 RVA: 0x007D3EB7 File Offset: 0x007D20B7
		public static void AddStartTime(FlatBufferBuilder builder, float startTime)
		{
			builder.AddFloat(1, startTime, 0.0);
		}

		// Token: 0x0603A111 RID: 237841 RVA: 0x007D3ECA File Offset: 0x007D20CA
		public static void AddWhoId(FlatBufferBuilder builder, int whoId)
		{
			builder.AddInt(2, whoId, 0);
		}

		// Token: 0x0603A112 RID: 237842 RVA: 0x007D3ED5 File Offset: 0x007D20D5
		public static void AddTransform(FlatBufferBuilder builder, Offset<IVisualNovelPortraitTransform> transformOffset)
		{
			builder.AddOffset(3, transformOffset.Value, 0);
		}

		// Token: 0x0603A113 RID: 237843 RVA: 0x007D3EE5 File Offset: 0x007D20E5
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(4, fadeInTime, 0.0);
		}

		// Token: 0x0603A114 RID: 237844 RVA: 0x007D3EF8 File Offset: 0x007D20F8
		public static void AddRoleConfig(FlatBufferBuilder builder, Offset<IVisualNovelRoleConfig> roleConfigOffset)
		{
			builder.AddOffset(5, roleConfigOffset.Value, 0);
		}

		// Token: 0x0603A115 RID: 237845 RVA: 0x007D3F08 File Offset: 0x007D2108
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0603A116 RID: 237846 RVA: 0x007D3F13 File Offset: 0x007D2113
		public static Offset<IVisualNovelPerformanceEnter> EndIVisualNovelPerformanceEnter(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelPerformanceEnter>(builder.EndTable());
		}

		// Token: 0x0603A117 RID: 237847 RVA: 0x007D3F20 File Offset: 0x007D2120
		public IVisualNovelPerformanceEnterT UnPack()
		{
			IVisualNovelPerformanceEnterT visualNovelPerformanceEnterT = new IVisualNovelPerformanceEnterT();
			this.UnPackTo(visualNovelPerformanceEnterT);
			return visualNovelPerformanceEnterT;
		}

		// Token: 0x0603A118 RID: 237848 RVA: 0x007D3F3C File Offset: 0x007D213C
		public void UnPackTo(IVisualNovelPerformanceEnterT _o)
		{
			_o.Type = this.Type;
			_o.StartTime = this.StartTime;
			_o.WhoId = this.WhoId;
			_o.Transform = ((this.Transform != null) ? this.Transform.Value.UnPack() : null);
			_o.FadeInTime = this.FadeInTime;
			_o.RoleConfig = ((this.RoleConfig != null) ? this.RoleConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603A119 RID: 237849 RVA: 0x007D3FE4 File Offset: 0x007D21E4
		public static Offset<IVisualNovelPerformanceEnter> Pack(FlatBufferBuilder builder, IVisualNovelPerformanceEnterT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelPerformanceEnter>);
			}
			Offset<IVisualNovelPortraitTransform> transformOffset = (_o.Transform == null) ? default(Offset<IVisualNovelPortraitTransform>) : IVisualNovelPortraitTransform.Pack(builder, _o.Transform);
			Offset<IVisualNovelRoleConfig> roleConfigOffset = (_o.RoleConfig == null) ? default(Offset<IVisualNovelRoleConfig>) : IVisualNovelRoleConfig.Pack(builder, _o.RoleConfig);
			return IVisualNovelPerformanceEnter.CreateIVisualNovelPerformanceEnter(builder, _o.Type, _o.StartTime, _o.WhoId, transformOffset, _o.FadeInTime, roleConfigOffset, _o.NullMask);
		}

		// Token: 0x04013501 RID: 79105
		private Table __p;
	}
}
