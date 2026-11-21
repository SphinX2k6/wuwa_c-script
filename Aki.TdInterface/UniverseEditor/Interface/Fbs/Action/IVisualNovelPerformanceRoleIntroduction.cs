using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DB5 RID: 32181
	public struct IVisualNovelPerformanceRoleIntroduction : IFlatbufferObject
	{
		// Token: 0x1700F103 RID: 61699
		// (get) Token: 0x0603A245 RID: 238149 RVA: 0x007D6950 File Offset: 0x007D4B50
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603A246 RID: 238150 RVA: 0x007D695D File Offset: 0x007D4B5D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603A247 RID: 238151 RVA: 0x007D6964 File Offset: 0x007D4B64
		public static IVisualNovelPerformanceRoleIntroduction GetRootAsIVisualNovelPerformanceRoleIntroduction(ByteBuffer _bb)
		{
			return IVisualNovelPerformanceRoleIntroduction.GetRootAsIVisualNovelPerformanceRoleIntroduction(_bb, default(IVisualNovelPerformanceRoleIntroduction));
		}

		// Token: 0x0603A248 RID: 238152 RVA: 0x007D6980 File Offset: 0x007D4B80
		public static IVisualNovelPerformanceRoleIntroduction GetRootAsIVisualNovelPerformanceRoleIntroduction(ByteBuffer _bb, IVisualNovelPerformanceRoleIntroduction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603A249 RID: 238153 RVA: 0x007D699D File Offset: 0x007D4B9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603A24A RID: 238154 RVA: 0x007D69AC File Offset: 0x007D4BAC
		public IVisualNovelPerformanceRoleIntroduction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F104 RID: 61700
		// (get) Token: 0x0603A24B RID: 238155 RVA: 0x007D69BC File Offset: 0x007D4BBC
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

		// Token: 0x1700F105 RID: 61701
		// (get) Token: 0x0603A24C RID: 238156 RVA: 0x007D69F8 File Offset: 0x007D4BF8
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

		// Token: 0x1700F106 RID: 61702
		// (get) Token: 0x0603A24D RID: 238157 RVA: 0x007D6A38 File Offset: 0x007D4C38
		public IVisualNovelRoleIntroductionSolarSchool? RoleIntroductionConfig
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVisualNovelRoleIntroductionSolarSchool?(default(IVisualNovelRoleIntroductionSolarSchool).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700F107 RID: 61703
		// (get) Token: 0x0603A24E RID: 238158 RVA: 0x007D6A98 File Offset: 0x007D4C98
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603A24F RID: 238159 RVA: 0x007D6AD5 File Offset: 0x007D4CD5
		public static Offset<IVisualNovelPerformanceRoleIntroduction> CreateIVisualNovelPerformanceRoleIntroduction(FlatBufferBuilder builder, EVisualNovelPerformanceType Type = EVisualNovelPerformanceType.Enter, float StartTime = 0f, Offset<IVisualNovelRoleIntroductionSolarSchool> RoleIntroductionConfigOffset = default(Offset<IVisualNovelRoleIntroductionSolarSchool>), byte NullMask = 0)
		{
			builder.StartTable(4);
			IVisualNovelPerformanceRoleIntroduction.AddRoleIntroductionConfig(builder, RoleIntroductionConfigOffset);
			IVisualNovelPerformanceRoleIntroduction.AddStartTime(builder, StartTime);
			IVisualNovelPerformanceRoleIntroduction.AddNullMask(builder, NullMask);
			IVisualNovelPerformanceRoleIntroduction.AddType(builder, Type);
			return IVisualNovelPerformanceRoleIntroduction.EndIVisualNovelPerformanceRoleIntroduction(builder);
		}

		// Token: 0x0603A250 RID: 238160 RVA: 0x007D6B01 File Offset: 0x007D4D01
		public static void StartIVisualNovelPerformanceRoleIntroduction(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0603A251 RID: 238161 RVA: 0x007D6B0A File Offset: 0x007D4D0A
		public static void AddType(FlatBufferBuilder builder, EVisualNovelPerformanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603A252 RID: 238162 RVA: 0x007D6B15 File Offset: 0x007D4D15
		public static void AddStartTime(FlatBufferBuilder builder, float startTime)
		{
			builder.AddFloat(1, startTime, 0.0);
		}

		// Token: 0x0603A253 RID: 238163 RVA: 0x007D6B28 File Offset: 0x007D4D28
		public static void AddRoleIntroductionConfig(FlatBufferBuilder builder, Offset<IVisualNovelRoleIntroductionSolarSchool> roleIntroductionConfigOffset)
		{
			builder.AddOffset(2, roleIntroductionConfigOffset.Value, 0);
		}

		// Token: 0x0603A254 RID: 238164 RVA: 0x007D6B38 File Offset: 0x007D4D38
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0603A255 RID: 238165 RVA: 0x007D6B43 File Offset: 0x007D4D43
		public static Offset<IVisualNovelPerformanceRoleIntroduction> EndIVisualNovelPerformanceRoleIntroduction(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelPerformanceRoleIntroduction>(builder.EndTable());
		}

		// Token: 0x0603A256 RID: 238166 RVA: 0x007D6B50 File Offset: 0x007D4D50
		public IVisualNovelPerformanceRoleIntroductionT UnPack()
		{
			IVisualNovelPerformanceRoleIntroductionT visualNovelPerformanceRoleIntroductionT = new IVisualNovelPerformanceRoleIntroductionT();
			this.UnPackTo(visualNovelPerformanceRoleIntroductionT);
			return visualNovelPerformanceRoleIntroductionT;
		}

		// Token: 0x0603A257 RID: 238167 RVA: 0x007D6B6C File Offset: 0x007D4D6C
		public void UnPackTo(IVisualNovelPerformanceRoleIntroductionT _o)
		{
			_o.Type = this.Type;
			_o.StartTime = this.StartTime;
			_o.RoleIntroductionConfig = ((this.RoleIntroductionConfig != null) ? this.RoleIntroductionConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603A258 RID: 238168 RVA: 0x007D6BCC File Offset: 0x007D4DCC
		public static Offset<IVisualNovelPerformanceRoleIntroduction> Pack(FlatBufferBuilder builder, IVisualNovelPerformanceRoleIntroductionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelPerformanceRoleIntroduction>);
			}
			Offset<IVisualNovelRoleIntroductionSolarSchool> roleIntroductionConfigOffset = (_o.RoleIntroductionConfig == null) ? default(Offset<IVisualNovelRoleIntroductionSolarSchool>) : IVisualNovelRoleIntroductionSolarSchool.Pack(builder, _o.RoleIntroductionConfig);
			return IVisualNovelPerformanceRoleIntroduction.CreateIVisualNovelPerformanceRoleIntroduction(builder, _o.Type, _o.StartTime, roleIntroductionConfigOffset, _o.NullMask);
		}

		// Token: 0x0401353A RID: 79162
		private Table __p;
	}
}
