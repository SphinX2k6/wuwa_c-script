using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200655E RID: 25950
	public struct IDelayRemoveAfterSkillFinish : IFlatbufferObject
	{
		// Token: 0x1700C0DC RID: 49372
		// (get) Token: 0x0602D05E RID: 184414 RVA: 0x0062DD6C File Offset: 0x0062BF6C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D05F RID: 184415 RVA: 0x0062DD79 File Offset: 0x0062BF79
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D060 RID: 184416 RVA: 0x0062DD80 File Offset: 0x0062BF80
		public static IDelayRemoveAfterSkillFinish GetRootAsIDelayRemoveAfterSkillFinish(ByteBuffer _bb)
		{
			return IDelayRemoveAfterSkillFinish.GetRootAsIDelayRemoveAfterSkillFinish(_bb, default(IDelayRemoveAfterSkillFinish));
		}

		// Token: 0x0602D061 RID: 184417 RVA: 0x0062DD9C File Offset: 0x0062BF9C
		public static IDelayRemoveAfterSkillFinish GetRootAsIDelayRemoveAfterSkillFinish(ByteBuffer _bb, IDelayRemoveAfterSkillFinish obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D062 RID: 184418 RVA: 0x0062DDB9 File Offset: 0x0062BFB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D063 RID: 184419 RVA: 0x0062DDC8 File Offset: 0x0062BFC8
		public IDelayRemoveAfterSkillFinish __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C0DD RID: 49373
		// (get) Token: 0x0602D064 RID: 184420 RVA: 0x0062DDD8 File Offset: 0x0062BFD8
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

		// Token: 0x0602D065 RID: 184421 RVA: 0x0062DE14 File Offset: 0x0062C014
		public static Offset<IDelayRemoveAfterSkillFinish> CreateIDelayRemoveAfterSkillFinish(FlatBufferBuilder builder, EDelayRemoveType Type = EDelayRemoveType.DelayRemoveAfterSkillFinish)
		{
			builder.StartTable(1);
			IDelayRemoveAfterSkillFinish.AddType(builder, Type);
			return IDelayRemoveAfterSkillFinish.EndIDelayRemoveAfterSkillFinish(builder);
		}

		// Token: 0x0602D066 RID: 184422 RVA: 0x0062DE2A File Offset: 0x0062C02A
		public static void StartIDelayRemoveAfterSkillFinish(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602D067 RID: 184423 RVA: 0x0062DE33 File Offset: 0x0062C033
		public static void AddType(FlatBufferBuilder builder, EDelayRemoveType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D068 RID: 184424 RVA: 0x0062DE3E File Offset: 0x0062C03E
		public static Offset<IDelayRemoveAfterSkillFinish> EndIDelayRemoveAfterSkillFinish(FlatBufferBuilder builder)
		{
			return new Offset<IDelayRemoveAfterSkillFinish>(builder.EndTable());
		}

		// Token: 0x0602D069 RID: 184425 RVA: 0x0062DE4C File Offset: 0x0062C04C
		public IDelayRemoveAfterSkillFinishT UnPack()
		{
			IDelayRemoveAfterSkillFinishT delayRemoveAfterSkillFinishT = new IDelayRemoveAfterSkillFinishT();
			this.UnPackTo(delayRemoveAfterSkillFinishT);
			return delayRemoveAfterSkillFinishT;
		}

		// Token: 0x0602D06A RID: 184426 RVA: 0x0062DE67 File Offset: 0x0062C067
		public void UnPackTo(IDelayRemoveAfterSkillFinishT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602D06B RID: 184427 RVA: 0x0062DE78 File Offset: 0x0062C078
		public static Offset<IDelayRemoveAfterSkillFinish> Pack(FlatBufferBuilder builder, IDelayRemoveAfterSkillFinishT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDelayRemoveAfterSkillFinish>);
			}
			return IDelayRemoveAfterSkillFinish.CreateIDelayRemoveAfterSkillFinish(builder, _o.Type);
		}

		// Token: 0x04010BB1 RID: 68529
		private Table __p;
	}
}
