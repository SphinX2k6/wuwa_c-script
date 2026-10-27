using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006266 RID: 25190
	public struct IBvbUseFieldCardSkill : IFlatbufferObject
	{
		// Token: 0x1700BBB6 RID: 48054
		// (get) Token: 0x0602B766 RID: 178022 RVA: 0x005FBDE9 File Offset: 0x005F9FE9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B767 RID: 178023 RVA: 0x005FBDF6 File Offset: 0x005F9FF6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B768 RID: 178024 RVA: 0x005FBE00 File Offset: 0x005FA000
		public static IBvbUseFieldCardSkill GetRootAsIBvbUseFieldCardSkill(ByteBuffer _bb)
		{
			return IBvbUseFieldCardSkill.GetRootAsIBvbUseFieldCardSkill(_bb, default(IBvbUseFieldCardSkill));
		}

		// Token: 0x0602B769 RID: 178025 RVA: 0x005FBE1C File Offset: 0x005FA01C
		public static IBvbUseFieldCardSkill GetRootAsIBvbUseFieldCardSkill(ByteBuffer _bb, IBvbUseFieldCardSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B76A RID: 178026 RVA: 0x005FBE39 File Offset: 0x005FA039
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B76B RID: 178027 RVA: 0x005FBE48 File Offset: 0x005FA048
		public IBvbUseFieldCardSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BBB7 RID: 48055
		// (get) Token: 0x0602B76C RID: 178028 RVA: 0x005FBE58 File Offset: 0x005FA058
		public EBvbPlayerOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBvbPlayerOperationType.BvbDeploy;
				}
				return (EBvbPlayerOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602B76D RID: 178029 RVA: 0x005FBE94 File Offset: 0x005FA094
		public static Offset<IBvbUseFieldCardSkill> CreateIBvbUseFieldCardSkill(FlatBufferBuilder builder, EBvbPlayerOperationType Type = EBvbPlayerOperationType.BvbDeploy)
		{
			builder.StartTable(1);
			IBvbUseFieldCardSkill.AddType(builder, Type);
			return IBvbUseFieldCardSkill.EndIBvbUseFieldCardSkill(builder);
		}

		// Token: 0x0602B76E RID: 178030 RVA: 0x005FBEAA File Offset: 0x005FA0AA
		public static void StartIBvbUseFieldCardSkill(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602B76F RID: 178031 RVA: 0x005FBEB3 File Offset: 0x005FA0B3
		public static void AddType(FlatBufferBuilder builder, EBvbPlayerOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B770 RID: 178032 RVA: 0x005FBEBE File Offset: 0x005FA0BE
		public static Offset<IBvbUseFieldCardSkill> EndIBvbUseFieldCardSkill(FlatBufferBuilder builder)
		{
			return new Offset<IBvbUseFieldCardSkill>(builder.EndTable());
		}

		// Token: 0x0602B771 RID: 178033 RVA: 0x005FBECC File Offset: 0x005FA0CC
		public IBvbUseFieldCardSkillT UnPack()
		{
			IBvbUseFieldCardSkillT bvbUseFieldCardSkillT = new IBvbUseFieldCardSkillT();
			this.UnPackTo(bvbUseFieldCardSkillT);
			return bvbUseFieldCardSkillT;
		}

		// Token: 0x0602B772 RID: 178034 RVA: 0x005FBEE7 File Offset: 0x005FA0E7
		public void UnPackTo(IBvbUseFieldCardSkillT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602B773 RID: 178035 RVA: 0x005FBEF8 File Offset: 0x005FA0F8
		public static Offset<IBvbUseFieldCardSkill> Pack(FlatBufferBuilder builder, IBvbUseFieldCardSkillT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbUseFieldCardSkill>);
			}
			return IBvbUseFieldCardSkill.CreateIBvbUseFieldCardSkill(builder, _o.Type);
		}

		// Token: 0x040107C0 RID: 67520
		private Table __p;
	}
}
