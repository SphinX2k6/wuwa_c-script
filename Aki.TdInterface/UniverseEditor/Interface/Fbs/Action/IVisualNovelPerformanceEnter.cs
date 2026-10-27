using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075A4 RID: 30116
	public struct IVisualNovelPerformanceEnter : IFlatbufferObject
	{
		// Token: 0x1700E46C RID: 58476
		// (get) Token: 0x06036CD2 RID: 224466 RVA: 0x0077066B File Offset: 0x0076E86B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036CD3 RID: 224467 RVA: 0x00770678 File Offset: 0x0076E878
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036CD4 RID: 224468 RVA: 0x00770680 File Offset: 0x0076E880
		public static IVisualNovelPerformanceEnter GetRootAsIVisualNovelPerformanceEnter(ByteBuffer _bb)
		{
			return IVisualNovelPerformanceEnter.GetRootAsIVisualNovelPerformanceEnter(_bb, default(IVisualNovelPerformanceEnter));
		}

		// Token: 0x06036CD5 RID: 224469 RVA: 0x0077069C File Offset: 0x0076E89C
		public static IVisualNovelPerformanceEnter GetRootAsIVisualNovelPerformanceEnter(ByteBuffer _bb, IVisualNovelPerformanceEnter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036CD6 RID: 224470 RVA: 0x007706B9 File Offset: 0x0076E8B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036CD7 RID: 224471 RVA: 0x007706C8 File Offset: 0x0076E8C8
		public IVisualNovelPerformanceEnter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E46D RID: 58477
		// (get) Token: 0x06036CD8 RID: 224472 RVA: 0x007706D8 File Offset: 0x0076E8D8
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

		// Token: 0x1700E46E RID: 58478
		// (get) Token: 0x06036CD9 RID: 224473 RVA: 0x00770714 File Offset: 0x0076E914
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

		// Token: 0x1700E46F RID: 58479
		// (get) Token: 0x06036CDA RID: 224474 RVA: 0x00770754 File Offset: 0x0076E954
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

		// Token: 0x1700E470 RID: 58480
		// (get) Token: 0x06036CDB RID: 224475 RVA: 0x00770790 File Offset: 0x0076E990
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

		// Token: 0x1700E471 RID: 58481
		// (get) Token: 0x06036CDC RID: 224476 RVA: 0x007707F0 File Offset: 0x0076E9F0
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

		// Token: 0x1700E472 RID: 58482
		// (get) Token: 0x06036CDD RID: 224477 RVA: 0x00770834 File Offset: 0x0076EA34
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

		// Token: 0x1700E473 RID: 58483
		// (get) Token: 0x06036CDE RID: 224478 RVA: 0x00770894 File Offset: 0x0076EA94
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

		// Token: 0x06036CDF RID: 224479 RVA: 0x007708D4 File Offset: 0x0076EAD4
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

		// Token: 0x06036CE0 RID: 224480 RVA: 0x00770923 File Offset: 0x0076EB23
		public static void StartIVisualNovelPerformanceEnter(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06036CE1 RID: 224481 RVA: 0x0077092C File Offset: 0x0076EB2C
		public static void AddType(FlatBufferBuilder builder, EVisualNovelPerformanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036CE2 RID: 224482 RVA: 0x00770937 File Offset: 0x0076EB37
		public static void AddStartTime(FlatBufferBuilder builder, float startTime)
		{
			builder.AddFloat(1, startTime, 0.0);
		}

		// Token: 0x06036CE3 RID: 224483 RVA: 0x0077094A File Offset: 0x0076EB4A
		public static void AddWhoId(FlatBufferBuilder builder, int whoId)
		{
			builder.AddInt(2, whoId, 0);
		}

		// Token: 0x06036CE4 RID: 224484 RVA: 0x00770955 File Offset: 0x0076EB55
		public static void AddTransform(FlatBufferBuilder builder, Offset<IVisualNovelPortraitTransform> transformOffset)
		{
			builder.AddOffset(3, transformOffset.Value, 0);
		}

		// Token: 0x06036CE5 RID: 224485 RVA: 0x00770965 File Offset: 0x0076EB65
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(4, fadeInTime, 0.0);
		}

		// Token: 0x06036CE6 RID: 224486 RVA: 0x00770978 File Offset: 0x0076EB78
		public static void AddRoleConfig(FlatBufferBuilder builder, Offset<IVisualNovelRoleConfig> roleConfigOffset)
		{
			builder.AddOffset(5, roleConfigOffset.Value, 0);
		}

		// Token: 0x06036CE7 RID: 224487 RVA: 0x00770988 File Offset: 0x0076EB88
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06036CE8 RID: 224488 RVA: 0x00770993 File Offset: 0x0076EB93
		public static Offset<IVisualNovelPerformanceEnter> EndIVisualNovelPerformanceEnter(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelPerformanceEnter>(builder.EndTable());
		}

		// Token: 0x06036CE9 RID: 224489 RVA: 0x007709A0 File Offset: 0x0076EBA0
		public IVisualNovelPerformanceEnterT UnPack()
		{
			IVisualNovelPerformanceEnterT visualNovelPerformanceEnterT = new IVisualNovelPerformanceEnterT();
			this.UnPackTo(visualNovelPerformanceEnterT);
			return visualNovelPerformanceEnterT;
		}

		// Token: 0x06036CEA RID: 224490 RVA: 0x007709BC File Offset: 0x0076EBBC
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

		// Token: 0x06036CEB RID: 224491 RVA: 0x00770A64 File Offset: 0x0076EC64
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

		// Token: 0x040124CE RID: 74958
		private Table __p;
	}
}
