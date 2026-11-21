using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068D7 RID: 26839
	public struct IBvbUseFieldCardSkill : IFlatbufferObject
	{
		// Token: 0x1700C53E RID: 50494
		// (get) Token: 0x0602DEC7 RID: 188103 RVA: 0x00646BF1 File Offset: 0x00644DF1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DEC8 RID: 188104 RVA: 0x00646BFE File Offset: 0x00644DFE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DEC9 RID: 188105 RVA: 0x00646C08 File Offset: 0x00644E08
		public static IBvbUseFieldCardSkill GetRootAsIBvbUseFieldCardSkill(ByteBuffer _bb)
		{
			return IBvbUseFieldCardSkill.GetRootAsIBvbUseFieldCardSkill(_bb, default(IBvbUseFieldCardSkill));
		}

		// Token: 0x0602DECA RID: 188106 RVA: 0x00646C24 File Offset: 0x00644E24
		public static IBvbUseFieldCardSkill GetRootAsIBvbUseFieldCardSkill(ByteBuffer _bb, IBvbUseFieldCardSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DECB RID: 188107 RVA: 0x00646C41 File Offset: 0x00644E41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DECC RID: 188108 RVA: 0x00646C50 File Offset: 0x00644E50
		public IBvbUseFieldCardSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C53F RID: 50495
		// (get) Token: 0x0602DECD RID: 188109 RVA: 0x00646C60 File Offset: 0x00644E60
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

		// Token: 0x0602DECE RID: 188110 RVA: 0x00646C9C File Offset: 0x00644E9C
		public static Offset<IBvbUseFieldCardSkill> CreateIBvbUseFieldCardSkill(FlatBufferBuilder builder, EBvbPlayerOperationType Type = EBvbPlayerOperationType.BvbDeploy)
		{
			builder.StartTable(1);
			IBvbUseFieldCardSkill.AddType(builder, Type);
			return IBvbUseFieldCardSkill.EndIBvbUseFieldCardSkill(builder);
		}

		// Token: 0x0602DECF RID: 188111 RVA: 0x00646CB2 File Offset: 0x00644EB2
		public static void StartIBvbUseFieldCardSkill(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602DED0 RID: 188112 RVA: 0x00646CBB File Offset: 0x00644EBB
		public static void AddType(FlatBufferBuilder builder, EBvbPlayerOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DED1 RID: 188113 RVA: 0x00646CC6 File Offset: 0x00644EC6
		public static Offset<IBvbUseFieldCardSkill> EndIBvbUseFieldCardSkill(FlatBufferBuilder builder)
		{
			return new Offset<IBvbUseFieldCardSkill>(builder.EndTable());
		}

		// Token: 0x0602DED2 RID: 188114 RVA: 0x00646CD4 File Offset: 0x00644ED4
		public IBvbUseFieldCardSkillT UnPack()
		{
			IBvbUseFieldCardSkillT bvbUseFieldCardSkillT = new IBvbUseFieldCardSkillT();
			this.UnPackTo(bvbUseFieldCardSkillT);
			return bvbUseFieldCardSkillT;
		}

		// Token: 0x0602DED3 RID: 188115 RVA: 0x00646CEF File Offset: 0x00644EEF
		public void UnPackTo(IBvbUseFieldCardSkillT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602DED4 RID: 188116 RVA: 0x00646D00 File Offset: 0x00644F00
		public static Offset<IBvbUseFieldCardSkill> Pack(FlatBufferBuilder builder, IBvbUseFieldCardSkillT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbUseFieldCardSkill>);
			}
			return IBvbUseFieldCardSkill.CreateIBvbUseFieldCardSkill(builder, _o.Type);
		}

		// Token: 0x040115D5 RID: 71125
		private Table __p;
	}
}
