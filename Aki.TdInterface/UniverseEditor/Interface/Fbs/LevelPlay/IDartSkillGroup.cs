using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200448B RID: 17547
	public struct IDartSkillGroup : IFlatbufferObject
	{
		// Token: 0x17007BD2 RID: 31698
		// (get) Token: 0x0601A2B6 RID: 107190 RVA: 0x003BCF9E File Offset: 0x003BB19E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A2B7 RID: 107191 RVA: 0x003BCFAB File Offset: 0x003BB1AB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A2B8 RID: 107192 RVA: 0x003BCFB4 File Offset: 0x003BB1B4
		public static IDartSkillGroup GetRootAsIDartSkillGroup(ByteBuffer _bb)
		{
			return IDartSkillGroup.GetRootAsIDartSkillGroup(_bb, default(IDartSkillGroup));
		}

		// Token: 0x0601A2B9 RID: 107193 RVA: 0x003BCFD0 File Offset: 0x003BB1D0
		public static IDartSkillGroup GetRootAsIDartSkillGroup(ByteBuffer _bb, IDartSkillGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A2BA RID: 107194 RVA: 0x003BCFED File Offset: 0x003BB1ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A2BB RID: 107195 RVA: 0x003BCFFC File Offset: 0x003BB1FC
		public IDartSkillGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601A2BC RID: 107196 RVA: 0x003BD00C File Offset: 0x003BB20C
		public IDartSkill? Skills(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IDartSkill?(default(IDartSkill).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007BD3 RID: 31699
		// (get) Token: 0x0601A2BD RID: 107197 RVA: 0x003BD06C File Offset: 0x003BB26C
		public int SkillsLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601A2BE RID: 107198 RVA: 0x003BD097 File Offset: 0x003BB297
		public static Offset<IDartSkillGroup> CreateIDartSkillGroup(FlatBufferBuilder builder, VectorOffset SkillsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IDartSkillGroup.AddSkills(builder, SkillsOffset);
			return IDartSkillGroup.EndIDartSkillGroup(builder);
		}

		// Token: 0x0601A2BF RID: 107199 RVA: 0x003BD0AD File Offset: 0x003BB2AD
		public static void StartIDartSkillGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601A2C0 RID: 107200 RVA: 0x003BD0B6 File Offset: 0x003BB2B6
		public static void AddSkills(FlatBufferBuilder builder, VectorOffset skillsOffset)
		{
			builder.AddOffset(0, skillsOffset.Value, 0);
		}

		// Token: 0x0601A2C1 RID: 107201 RVA: 0x003BD0C8 File Offset: 0x003BB2C8
		public static VectorOffset CreateSkillsVector(FlatBufferBuilder builder, Offset<IDartSkill>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A2C2 RID: 107202 RVA: 0x003BD108 File Offset: 0x003BB308
		public static VectorOffset CreateSkillsVectorBlock(FlatBufferBuilder builder, Offset<IDartSkill>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IDartSkill>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A2C3 RID: 107203 RVA: 0x003BD122 File Offset: 0x003BB322
		public static VectorOffset CreateSkillsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IDartSkill>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IDartSkill>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A2C4 RID: 107204 RVA: 0x003BD140 File Offset: 0x003BB340
		public static VectorOffset CreateSkillsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IDartSkill>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A2C5 RID: 107205 RVA: 0x003BD159 File Offset: 0x003BB359
		public static void StartSkillsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601A2C6 RID: 107206 RVA: 0x003BD164 File Offset: 0x003BB364
		public static Offset<IDartSkillGroup> EndIDartSkillGroup(FlatBufferBuilder builder)
		{
			return new Offset<IDartSkillGroup>(builder.EndTable());
		}

		// Token: 0x0601A2C7 RID: 107207 RVA: 0x003BD174 File Offset: 0x003BB374
		public IDartSkillGroupT UnPack()
		{
			IDartSkillGroupT dartSkillGroupT = new IDartSkillGroupT();
			this.UnPackTo(dartSkillGroupT);
			return dartSkillGroupT;
		}

		// Token: 0x0601A2C8 RID: 107208 RVA: 0x003BD190 File Offset: 0x003BB390
		public void UnPackTo(IDartSkillGroupT _o)
		{
			_o.Skills = new List<IDartSkillT>();
			for (int i = 0; i < this.SkillsLength; i++)
			{
				_o.Skills.Add((this.Skills(i) != null) ? this.Skills(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601A2C9 RID: 107209 RVA: 0x003BD1F0 File Offset: 0x003BB3F0
		public static Offset<IDartSkillGroup> Pack(FlatBufferBuilder builder, IDartSkillGroupT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDartSkillGroup>);
			}
			VectorOffset skillsOffset = default(VectorOffset);
			if (_o.Skills != null)
			{
				Offset<IDartSkill>[] array = new Offset<IDartSkill>[_o.Skills.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IDartSkill.Pack(builder, _o.Skills[i]);
				}
				skillsOffset = IDartSkillGroup.CreateSkillsVector(builder, array);
			}
			return IDartSkillGroup.CreateIDartSkillGroup(builder, skillsOffset);
		}

		// Token: 0x0400C489 RID: 50313
		private Table __p;
	}
}
