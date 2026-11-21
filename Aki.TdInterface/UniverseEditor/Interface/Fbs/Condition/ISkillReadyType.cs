using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051C0 RID: 20928
	public struct ISkillReadyType : IFlatbufferObject
	{
		// Token: 0x170095E2 RID: 38370
		// (get) Token: 0x06020F2B RID: 134955 RVA: 0x0048E725 File Offset: 0x0048C925
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020F2C RID: 134956 RVA: 0x0048E732 File Offset: 0x0048C932
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020F2D RID: 134957 RVA: 0x0048E73C File Offset: 0x0048C93C
		public static ISkillReadyType GetRootAsISkillReadyType(ByteBuffer _bb)
		{
			return ISkillReadyType.GetRootAsISkillReadyType(_bb, default(ISkillReadyType));
		}

		// Token: 0x06020F2E RID: 134958 RVA: 0x0048E758 File Offset: 0x0048C958
		public static ISkillReadyType GetRootAsISkillReadyType(ByteBuffer _bb, ISkillReadyType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020F2F RID: 134959 RVA: 0x0048E775 File Offset: 0x0048C975
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020F30 RID: 134960 RVA: 0x0048E784 File Offset: 0x0048C984
		public ISkillReadyType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170095E3 RID: 38371
		// (get) Token: 0x06020F31 RID: 134961 RVA: 0x0048E794 File Offset: 0x0048C994
		public ESkillReadyType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESkillReadyType.UltimateSkill;
				}
				return (ESkillReadyType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020F32 RID: 134962 RVA: 0x0048E7D0 File Offset: 0x0048C9D0
		public static Offset<ISkillReadyType> CreateISkillReadyType(FlatBufferBuilder builder, ESkillReadyType Type = ESkillReadyType.UltimateSkill)
		{
			builder.StartTable(1);
			ISkillReadyType.AddType(builder, Type);
			return ISkillReadyType.EndISkillReadyType(builder);
		}

		// Token: 0x06020F33 RID: 134963 RVA: 0x0048E7E6 File Offset: 0x0048C9E6
		public static void StartISkillReadyType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06020F34 RID: 134964 RVA: 0x0048E7EF File Offset: 0x0048C9EF
		public static void AddType(FlatBufferBuilder builder, ESkillReadyType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020F35 RID: 134965 RVA: 0x0048E7FA File Offset: 0x0048C9FA
		public static Offset<ISkillReadyType> EndISkillReadyType(FlatBufferBuilder builder)
		{
			return new Offset<ISkillReadyType>(builder.EndTable());
		}

		// Token: 0x06020F36 RID: 134966 RVA: 0x0048E808 File Offset: 0x0048CA08
		public ISkillReadyTypeT UnPack()
		{
			ISkillReadyTypeT skillReadyTypeT = new ISkillReadyTypeT();
			this.UnPackTo(skillReadyTypeT);
			return skillReadyTypeT;
		}

		// Token: 0x06020F37 RID: 134967 RVA: 0x0048E823 File Offset: 0x0048CA23
		public void UnPackTo(ISkillReadyTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06020F38 RID: 134968 RVA: 0x0048E834 File Offset: 0x0048CA34
		public static Offset<ISkillReadyType> Pack(FlatBufferBuilder builder, ISkillReadyTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISkillReadyType>);
			}
			return ISkillReadyType.CreateISkillReadyType(builder, _o.Type);
		}

		// Token: 0x0400E1B5 RID: 57781
		private Table __p;
	}
}
