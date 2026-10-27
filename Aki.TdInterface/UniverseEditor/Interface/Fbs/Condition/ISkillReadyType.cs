using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CC4 RID: 19652
	public struct ISkillReadyType : IFlatbufferObject
	{
		// Token: 0x17008EA9 RID: 36521
		// (get) Token: 0x0601F2E7 RID: 127719 RVA: 0x0045A82D File Offset: 0x00458A2D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F2E8 RID: 127720 RVA: 0x0045A83A File Offset: 0x00458A3A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F2E9 RID: 127721 RVA: 0x0045A844 File Offset: 0x00458A44
		public static ISkillReadyType GetRootAsISkillReadyType(ByteBuffer _bb)
		{
			return ISkillReadyType.GetRootAsISkillReadyType(_bb, default(ISkillReadyType));
		}

		// Token: 0x0601F2EA RID: 127722 RVA: 0x0045A860 File Offset: 0x00458A60
		public static ISkillReadyType GetRootAsISkillReadyType(ByteBuffer _bb, ISkillReadyType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F2EB RID: 127723 RVA: 0x0045A87D File Offset: 0x00458A7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F2EC RID: 127724 RVA: 0x0045A88C File Offset: 0x00458A8C
		public ISkillReadyType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008EAA RID: 36522
		// (get) Token: 0x0601F2ED RID: 127725 RVA: 0x0045A89C File Offset: 0x00458A9C
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

		// Token: 0x0601F2EE RID: 127726 RVA: 0x0045A8D8 File Offset: 0x00458AD8
		public static Offset<ISkillReadyType> CreateISkillReadyType(FlatBufferBuilder builder, ESkillReadyType Type = ESkillReadyType.UltimateSkill)
		{
			builder.StartTable(1);
			ISkillReadyType.AddType(builder, Type);
			return ISkillReadyType.EndISkillReadyType(builder);
		}

		// Token: 0x0601F2EF RID: 127727 RVA: 0x0045A8EE File Offset: 0x00458AEE
		public static void StartISkillReadyType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601F2F0 RID: 127728 RVA: 0x0045A8F7 File Offset: 0x00458AF7
		public static void AddType(FlatBufferBuilder builder, ESkillReadyType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F2F1 RID: 127729 RVA: 0x0045A902 File Offset: 0x00458B02
		public static Offset<ISkillReadyType> EndISkillReadyType(FlatBufferBuilder builder)
		{
			return new Offset<ISkillReadyType>(builder.EndTable());
		}

		// Token: 0x0601F2F2 RID: 127730 RVA: 0x0045A910 File Offset: 0x00458B10
		public ISkillReadyTypeT UnPack()
		{
			ISkillReadyTypeT skillReadyTypeT = new ISkillReadyTypeT();
			this.UnPackTo(skillReadyTypeT);
			return skillReadyTypeT;
		}

		// Token: 0x0601F2F3 RID: 127731 RVA: 0x0045A92B File Offset: 0x00458B2B
		public void UnPackTo(ISkillReadyTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601F2F4 RID: 127732 RVA: 0x0045A93C File Offset: 0x00458B3C
		public static Offset<ISkillReadyType> Pack(FlatBufferBuilder builder, ISkillReadyTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISkillReadyType>);
			}
			return ISkillReadyType.CreateISkillReadyType(builder, _o.Type);
		}

		// Token: 0x0400D688 RID: 54920
		private Table __p;
	}
}
