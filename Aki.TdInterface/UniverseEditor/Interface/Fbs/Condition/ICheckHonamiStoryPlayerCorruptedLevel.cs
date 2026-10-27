using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A60 RID: 19040
	public struct ICheckHonamiStoryPlayerCorruptedLevel : IFlatbufferObject
	{
		// Token: 0x170089DA RID: 35290
		// (get) Token: 0x0601DD2E RID: 122158 RVA: 0x00430EA8 File Offset: 0x0042F0A8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DD2F RID: 122159 RVA: 0x00430EB5 File Offset: 0x0042F0B5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DD30 RID: 122160 RVA: 0x00430EBC File Offset: 0x0042F0BC
		public static ICheckHonamiStoryPlayerCorruptedLevel GetRootAsICheckHonamiStoryPlayerCorruptedLevel(ByteBuffer _bb)
		{
			return ICheckHonamiStoryPlayerCorruptedLevel.GetRootAsICheckHonamiStoryPlayerCorruptedLevel(_bb, default(ICheckHonamiStoryPlayerCorruptedLevel));
		}

		// Token: 0x0601DD31 RID: 122161 RVA: 0x00430ED8 File Offset: 0x0042F0D8
		public static ICheckHonamiStoryPlayerCorruptedLevel GetRootAsICheckHonamiStoryPlayerCorruptedLevel(ByteBuffer _bb, ICheckHonamiStoryPlayerCorruptedLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DD32 RID: 122162 RVA: 0x00430EF5 File Offset: 0x0042F0F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DD33 RID: 122163 RVA: 0x00430F04 File Offset: 0x0042F104
		public ICheckHonamiStoryPlayerCorruptedLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170089DB RID: 35291
		// (get) Token: 0x0601DD34 RID: 122164 RVA: 0x00430F14 File Offset: 0x0042F114
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170089DC RID: 35292
		// (get) Token: 0x0601DD35 RID: 122165 RVA: 0x00430F50 File Offset: 0x0042F150
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170089DD RID: 35293
		// (get) Token: 0x0601DD36 RID: 122166 RVA: 0x00430F8C File Offset: 0x0042F18C
		public int Level
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

		// Token: 0x0601DD37 RID: 122167 RVA: 0x00430FC8 File Offset: 0x0042F1C8
		public static Offset<ICheckHonamiStoryPlayerCorruptedLevel> CreateICheckHonamiStoryPlayerCorruptedLevel(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, ECompare Compare = ECompare.Eq, int Level = 0)
		{
			builder.StartTable(3);
			ICheckHonamiStoryPlayerCorruptedLevel.AddLevel(builder, Level);
			ICheckHonamiStoryPlayerCorruptedLevel.AddCompare(builder, Compare);
			ICheckHonamiStoryPlayerCorruptedLevel.AddType(builder, Type);
			return ICheckHonamiStoryPlayerCorruptedLevel.EndICheckHonamiStoryPlayerCorruptedLevel(builder);
		}

		// Token: 0x0601DD38 RID: 122168 RVA: 0x00430FEC File Offset: 0x0042F1EC
		public static void StartICheckHonamiStoryPlayerCorruptedLevel(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601DD39 RID: 122169 RVA: 0x00430FF5 File Offset: 0x0042F1F5
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DD3A RID: 122170 RVA: 0x00431000 File Offset: 0x0042F200
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x0601DD3B RID: 122171 RVA: 0x0043100B File Offset: 0x0042F20B
		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
			builder.AddInt(2, level, 0);
		}

		// Token: 0x0601DD3C RID: 122172 RVA: 0x00431016 File Offset: 0x0042F216
		public static Offset<ICheckHonamiStoryPlayerCorruptedLevel> EndICheckHonamiStoryPlayerCorruptedLevel(FlatBufferBuilder builder)
		{
			return new Offset<ICheckHonamiStoryPlayerCorruptedLevel>(builder.EndTable());
		}

		// Token: 0x0601DD3D RID: 122173 RVA: 0x00431024 File Offset: 0x0042F224
		public ICheckHonamiStoryPlayerCorruptedLevelT UnPack()
		{
			ICheckHonamiStoryPlayerCorruptedLevelT checkHonamiStoryPlayerCorruptedLevelT = new ICheckHonamiStoryPlayerCorruptedLevelT();
			this.UnPackTo(checkHonamiStoryPlayerCorruptedLevelT);
			return checkHonamiStoryPlayerCorruptedLevelT;
		}

		// Token: 0x0601DD3E RID: 122174 RVA: 0x0043103F File Offset: 0x0042F23F
		public void UnPackTo(ICheckHonamiStoryPlayerCorruptedLevelT _o)
		{
			_o.Type = this.Type;
			_o.Compare = this.Compare;
			_o.Level = this.Level;
		}

		// Token: 0x0601DD3F RID: 122175 RVA: 0x00431068 File Offset: 0x0042F268
		public static Offset<ICheckHonamiStoryPlayerCorruptedLevel> Pack(FlatBufferBuilder builder, ICheckHonamiStoryPlayerCorruptedLevelT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckHonamiStoryPlayerCorruptedLevel>);
			}
			return ICheckHonamiStoryPlayerCorruptedLevel.CreateICheckHonamiStoryPlayerCorruptedLevel(builder, _o.Type, _o.Compare, _o.Level);
		}

		// Token: 0x0400D2C0 RID: 53952
		private Table __p;
	}
}
