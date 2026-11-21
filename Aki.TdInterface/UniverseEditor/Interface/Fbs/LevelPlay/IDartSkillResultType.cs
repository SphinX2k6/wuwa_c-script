using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048F6 RID: 18678
	public struct IDartSkillResultType : IFlatbufferObject
	{
		// Token: 0x17008214 RID: 33300
		// (get) Token: 0x0601BA9F RID: 113311 RVA: 0x003E94C7 File Offset: 0x003E76C7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BAA0 RID: 113312 RVA: 0x003E94D4 File Offset: 0x003E76D4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BAA1 RID: 113313 RVA: 0x003E94DC File Offset: 0x003E76DC
		public static IDartSkillResultType GetRootAsIDartSkillResultType(ByteBuffer _bb)
		{
			return IDartSkillResultType.GetRootAsIDartSkillResultType(_bb, default(IDartSkillResultType));
		}

		// Token: 0x0601BAA2 RID: 113314 RVA: 0x003E94F8 File Offset: 0x003E76F8
		public static IDartSkillResultType GetRootAsIDartSkillResultType(ByteBuffer _bb, IDartSkillResultType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BAA3 RID: 113315 RVA: 0x003E9515 File Offset: 0x003E7715
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BAA4 RID: 113316 RVA: 0x003E9524 File Offset: 0x003E7724
		public IDartSkillResultType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008215 RID: 33301
		// (get) Token: 0x0601BAA5 RID: 113317 RVA: 0x003E9534 File Offset: 0x003E7734
		public EDartSkillResultType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDartSkillResultType.NoBust;
				}
				return (EDartSkillResultType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BAA6 RID: 113318 RVA: 0x003E9570 File Offset: 0x003E7770
		public static Offset<IDartSkillResultType> CreateIDartSkillResultType(FlatBufferBuilder builder, EDartSkillResultType Type = EDartSkillResultType.NoBust)
		{
			builder.StartTable(1);
			IDartSkillResultType.AddType(builder, Type);
			return IDartSkillResultType.EndIDartSkillResultType(builder);
		}

		// Token: 0x0601BAA7 RID: 113319 RVA: 0x003E9586 File Offset: 0x003E7786
		public static void StartIDartSkillResultType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601BAA8 RID: 113320 RVA: 0x003E958F File Offset: 0x003E778F
		public static void AddType(FlatBufferBuilder builder, EDartSkillResultType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601BAA9 RID: 113321 RVA: 0x003E959A File Offset: 0x003E779A
		public static Offset<IDartSkillResultType> EndIDartSkillResultType(FlatBufferBuilder builder)
		{
			return new Offset<IDartSkillResultType>(builder.EndTable());
		}

		// Token: 0x0601BAAA RID: 113322 RVA: 0x003E95A8 File Offset: 0x003E77A8
		public IDartSkillResultTypeT UnPack()
		{
			IDartSkillResultTypeT dartSkillResultTypeT = new IDartSkillResultTypeT();
			this.UnPackTo(dartSkillResultTypeT);
			return dartSkillResultTypeT;
		}

		// Token: 0x0601BAAB RID: 113323 RVA: 0x003E95C3 File Offset: 0x003E77C3
		public void UnPackTo(IDartSkillResultTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601BAAC RID: 113324 RVA: 0x003E95D4 File Offset: 0x003E77D4
		public static Offset<IDartSkillResultType> Pack(FlatBufferBuilder builder, IDartSkillResultTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDartSkillResultType>);
			}
			return IDartSkillResultType.CreateIDartSkillResultType(builder, _o.Type);
		}

		// Token: 0x0400CEB9 RID: 52921
		private Table __p;
	}
}
