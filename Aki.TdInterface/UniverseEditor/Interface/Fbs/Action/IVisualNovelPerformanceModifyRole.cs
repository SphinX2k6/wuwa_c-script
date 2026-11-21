using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DA9 RID: 32169
	public struct IVisualNovelPerformanceModifyRole : IFlatbufferObject
	{
		// Token: 0x1700F0CF RID: 61647
		// (get) Token: 0x0603A1A4 RID: 237988 RVA: 0x007D5298 File Offset: 0x007D3498
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603A1A5 RID: 237989 RVA: 0x007D52A5 File Offset: 0x007D34A5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603A1A6 RID: 237990 RVA: 0x007D52AC File Offset: 0x007D34AC
		public static IVisualNovelPerformanceModifyRole GetRootAsIVisualNovelPerformanceModifyRole(ByteBuffer _bb)
		{
			return IVisualNovelPerformanceModifyRole.GetRootAsIVisualNovelPerformanceModifyRole(_bb, default(IVisualNovelPerformanceModifyRole));
		}

		// Token: 0x0603A1A7 RID: 237991 RVA: 0x007D52C8 File Offset: 0x007D34C8
		public static IVisualNovelPerformanceModifyRole GetRootAsIVisualNovelPerformanceModifyRole(ByteBuffer _bb, IVisualNovelPerformanceModifyRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603A1A8 RID: 237992 RVA: 0x007D52E5 File Offset: 0x007D34E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603A1A9 RID: 237993 RVA: 0x007D52F4 File Offset: 0x007D34F4
		public IVisualNovelPerformanceModifyRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F0D0 RID: 61648
		// (get) Token: 0x0603A1AA RID: 237994 RVA: 0x007D5304 File Offset: 0x007D3504
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

		// Token: 0x1700F0D1 RID: 61649
		// (get) Token: 0x0603A1AB RID: 237995 RVA: 0x007D5340 File Offset: 0x007D3540
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

		// Token: 0x1700F0D2 RID: 61650
		// (get) Token: 0x0603A1AC RID: 237996 RVA: 0x007D5380 File Offset: 0x007D3580
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

		// Token: 0x1700F0D3 RID: 61651
		// (get) Token: 0x0603A1AD RID: 237997 RVA: 0x007D53BC File Offset: 0x007D35BC
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

		// Token: 0x1700F0D4 RID: 61652
		// (get) Token: 0x0603A1AE RID: 237998 RVA: 0x007D541C File Offset: 0x007D361C
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

		// Token: 0x1700F0D5 RID: 61653
		// (get) Token: 0x0603A1AF RID: 237999 RVA: 0x007D547C File Offset: 0x007D367C
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

		// Token: 0x0603A1B0 RID: 238000 RVA: 0x007D54B9 File Offset: 0x007D36B9
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

		// Token: 0x0603A1B1 RID: 238001 RVA: 0x007D54F5 File Offset: 0x007D36F5
		public static void StartIVisualNovelPerformanceModifyRole(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0603A1B2 RID: 238002 RVA: 0x007D54FE File Offset: 0x007D36FE
		public static void AddType(FlatBufferBuilder builder, EVisualNovelPerformanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603A1B3 RID: 238003 RVA: 0x007D5509 File Offset: 0x007D3709
		public static void AddStartTime(FlatBufferBuilder builder, float startTime)
		{
			builder.AddFloat(1, startTime, 0.0);
		}

		// Token: 0x0603A1B4 RID: 238004 RVA: 0x007D551C File Offset: 0x007D371C
		public static void AddWhoId(FlatBufferBuilder builder, int whoId)
		{
			builder.AddInt(2, whoId, 0);
		}

		// Token: 0x0603A1B5 RID: 238005 RVA: 0x007D5527 File Offset: 0x007D3727
		public static void AddTransform(FlatBufferBuilder builder, Offset<IVisualNovelPortraitTransform> transformOffset)
		{
			builder.AddOffset(3, transformOffset.Value, 0);
		}

		// Token: 0x0603A1B6 RID: 238006 RVA: 0x007D5537 File Offset: 0x007D3737
		public static void AddRoleConfig(FlatBufferBuilder builder, Offset<IVisualNovelRoleConfig> roleConfigOffset)
		{
			builder.AddOffset(4, roleConfigOffset.Value, 0);
		}

		// Token: 0x0603A1B7 RID: 238007 RVA: 0x007D5547 File Offset: 0x007D3747
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0603A1B8 RID: 238008 RVA: 0x007D5552 File Offset: 0x007D3752
		public static Offset<IVisualNovelPerformanceModifyRole> EndIVisualNovelPerformanceModifyRole(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelPerformanceModifyRole>(builder.EndTable());
		}

		// Token: 0x0603A1B9 RID: 238009 RVA: 0x007D5560 File Offset: 0x007D3760
		public IVisualNovelPerformanceModifyRoleT UnPack()
		{
			IVisualNovelPerformanceModifyRoleT visualNovelPerformanceModifyRoleT = new IVisualNovelPerformanceModifyRoleT();
			this.UnPackTo(visualNovelPerformanceModifyRoleT);
			return visualNovelPerformanceModifyRoleT;
		}

		// Token: 0x0603A1BA RID: 238010 RVA: 0x007D557C File Offset: 0x007D377C
		public void UnPackTo(IVisualNovelPerformanceModifyRoleT _o)
		{
			_o.Type = this.Type;
			_o.StartTime = this.StartTime;
			_o.WhoId = this.WhoId;
			_o.Transform = ((this.Transform != null) ? this.Transform.Value.UnPack() : null);
			_o.RoleConfig = ((this.RoleConfig != null) ? this.RoleConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603A1BB RID: 238011 RVA: 0x007D5618 File Offset: 0x007D3818
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

		// Token: 0x0401351E RID: 79134
		private Table __p;
	}
}
