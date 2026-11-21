using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048F3 RID: 18675
	public struct IDartSkillGroup : IFlatbufferObject
	{
		// Token: 0x17008211 RID: 33297
		// (get) Token: 0x0601BA87 RID: 113287 RVA: 0x003E91AA File Offset: 0x003E73AA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BA88 RID: 113288 RVA: 0x003E91B7 File Offset: 0x003E73B7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BA89 RID: 113289 RVA: 0x003E91C0 File Offset: 0x003E73C0
		public static IDartSkillGroup GetRootAsIDartSkillGroup(ByteBuffer _bb)
		{
			return IDartSkillGroup.GetRootAsIDartSkillGroup(_bb, default(IDartSkillGroup));
		}

		// Token: 0x0601BA8A RID: 113290 RVA: 0x003E91DC File Offset: 0x003E73DC
		public static IDartSkillGroup GetRootAsIDartSkillGroup(ByteBuffer _bb, IDartSkillGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BA8B RID: 113291 RVA: 0x003E91F9 File Offset: 0x003E73F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BA8C RID: 113292 RVA: 0x003E9208 File Offset: 0x003E7408
		public IDartSkillGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601BA8D RID: 113293 RVA: 0x003E9218 File Offset: 0x003E7418
		public IDartSkill? Skills(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IDartSkill?(default(IDartSkill).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008212 RID: 33298
		// (get) Token: 0x0601BA8E RID: 113294 RVA: 0x003E9278 File Offset: 0x003E7478
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

		// Token: 0x0601BA8F RID: 113295 RVA: 0x003E92A3 File Offset: 0x003E74A3
		public static Offset<IDartSkillGroup> CreateIDartSkillGroup(FlatBufferBuilder builder, VectorOffset SkillsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IDartSkillGroup.AddSkills(builder, SkillsOffset);
			return IDartSkillGroup.EndIDartSkillGroup(builder);
		}

		// Token: 0x0601BA90 RID: 113296 RVA: 0x003E92B9 File Offset: 0x003E74B9
		public static void StartIDartSkillGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601BA91 RID: 113297 RVA: 0x003E92C2 File Offset: 0x003E74C2
		public static void AddSkills(FlatBufferBuilder builder, VectorOffset skillsOffset)
		{
			builder.AddOffset(0, skillsOffset.Value, 0);
		}

		// Token: 0x0601BA92 RID: 113298 RVA: 0x003E92D4 File Offset: 0x003E74D4
		public static VectorOffset CreateSkillsVector(FlatBufferBuilder builder, Offset<IDartSkill>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BA93 RID: 113299 RVA: 0x003E9314 File Offset: 0x003E7514
		public static VectorOffset CreateSkillsVectorBlock(FlatBufferBuilder builder, Offset<IDartSkill>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IDartSkill>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BA94 RID: 113300 RVA: 0x003E932E File Offset: 0x003E752E
		public static VectorOffset CreateSkillsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IDartSkill>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IDartSkill>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BA95 RID: 113301 RVA: 0x003E934C File Offset: 0x003E754C
		public static VectorOffset CreateSkillsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IDartSkill>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BA96 RID: 113302 RVA: 0x003E9365 File Offset: 0x003E7565
		public static void StartSkillsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BA97 RID: 113303 RVA: 0x003E9370 File Offset: 0x003E7570
		public static Offset<IDartSkillGroup> EndIDartSkillGroup(FlatBufferBuilder builder)
		{
			return new Offset<IDartSkillGroup>(builder.EndTable());
		}

		// Token: 0x0601BA98 RID: 113304 RVA: 0x003E9380 File Offset: 0x003E7580
		public IDartSkillGroupT UnPack()
		{
			IDartSkillGroupT dartSkillGroupT = new IDartSkillGroupT();
			this.UnPackTo(dartSkillGroupT);
			return dartSkillGroupT;
		}

		// Token: 0x0601BA99 RID: 113305 RVA: 0x003E939C File Offset: 0x003E759C
		public void UnPackTo(IDartSkillGroupT _o)
		{
			_o.Skills = new List<IDartSkillT>();
			for (int i = 0; i < this.SkillsLength; i++)
			{
				_o.Skills.Add((this.Skills(i) != null) ? this.Skills(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601BA9A RID: 113306 RVA: 0x003E93FC File Offset: 0x003E75FC
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

		// Token: 0x0400CEB7 RID: 52919
		private Table __p;
	}
}
