using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BCF RID: 27599
	public struct IDelayRemoveAfterSkillFinish : IFlatbufferObject
	{
		// Token: 0x1700CA77 RID: 51831
		// (get) Token: 0x0602F81A RID: 194586 RVA: 0x0067A530 File Offset: 0x00678730
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F81B RID: 194587 RVA: 0x0067A53D File Offset: 0x0067873D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F81C RID: 194588 RVA: 0x0067A544 File Offset: 0x00678744
		public static IDelayRemoveAfterSkillFinish GetRootAsIDelayRemoveAfterSkillFinish(ByteBuffer _bb)
		{
			return IDelayRemoveAfterSkillFinish.GetRootAsIDelayRemoveAfterSkillFinish(_bb, default(IDelayRemoveAfterSkillFinish));
		}

		// Token: 0x0602F81D RID: 194589 RVA: 0x0067A560 File Offset: 0x00678760
		public static IDelayRemoveAfterSkillFinish GetRootAsIDelayRemoveAfterSkillFinish(ByteBuffer _bb, IDelayRemoveAfterSkillFinish obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F81E RID: 194590 RVA: 0x0067A57D File Offset: 0x0067877D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F81F RID: 194591 RVA: 0x0067A58C File Offset: 0x0067878C
		public IDelayRemoveAfterSkillFinish __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CA78 RID: 51832
		// (get) Token: 0x0602F820 RID: 194592 RVA: 0x0067A59C File Offset: 0x0067879C
		public EDelayRemoveType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDelayRemoveType.DelayRemoveAfterSkillFinish;
				}
				return (EDelayRemoveType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F821 RID: 194593 RVA: 0x0067A5D8 File Offset: 0x006787D8
		public static Offset<IDelayRemoveAfterSkillFinish> CreateIDelayRemoveAfterSkillFinish(FlatBufferBuilder builder, EDelayRemoveType Type = EDelayRemoveType.DelayRemoveAfterSkillFinish)
		{
			builder.StartTable(1);
			IDelayRemoveAfterSkillFinish.AddType(builder, Type);
			return IDelayRemoveAfterSkillFinish.EndIDelayRemoveAfterSkillFinish(builder);
		}

		// Token: 0x0602F822 RID: 194594 RVA: 0x0067A5EE File Offset: 0x006787EE
		public static void StartIDelayRemoveAfterSkillFinish(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602F823 RID: 194595 RVA: 0x0067A5F7 File Offset: 0x006787F7
		public static void AddType(FlatBufferBuilder builder, EDelayRemoveType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F824 RID: 194596 RVA: 0x0067A602 File Offset: 0x00678802
		public static Offset<IDelayRemoveAfterSkillFinish> EndIDelayRemoveAfterSkillFinish(FlatBufferBuilder builder)
		{
			return new Offset<IDelayRemoveAfterSkillFinish>(builder.EndTable());
		}

		// Token: 0x0602F825 RID: 194597 RVA: 0x0067A610 File Offset: 0x00678810
		public IDelayRemoveAfterSkillFinishT UnPack()
		{
			IDelayRemoveAfterSkillFinishT delayRemoveAfterSkillFinishT = new IDelayRemoveAfterSkillFinishT();
			this.UnPackTo(delayRemoveAfterSkillFinishT);
			return delayRemoveAfterSkillFinishT;
		}

		// Token: 0x0602F826 RID: 194598 RVA: 0x0067A62B File Offset: 0x0067882B
		public void UnPackTo(IDelayRemoveAfterSkillFinishT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602F827 RID: 194599 RVA: 0x0067A63C File Offset: 0x0067883C
		public static Offset<IDelayRemoveAfterSkillFinish> Pack(FlatBufferBuilder builder, IDelayRemoveAfterSkillFinishT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDelayRemoveAfterSkillFinish>);
			}
			return IDelayRemoveAfterSkillFinish.CreateIDelayRemoveAfterSkillFinish(builder, _o.Type);
		}

		// Token: 0x040119CF RID: 72143
		private Table __p;
	}
}
