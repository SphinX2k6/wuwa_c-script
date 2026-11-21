using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044AE RID: 17582
	public struct IReadMailCondition : IFlatbufferObject
	{
		// Token: 0x17007A5D RID: 31325
		// (get) Token: 0x06019618 RID: 103960 RVA: 0x0039F753 File Offset: 0x0039D953
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019619 RID: 103961 RVA: 0x0039F760 File Offset: 0x0039D960
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601961A RID: 103962 RVA: 0x0039F768 File Offset: 0x0039D968
		public static IReadMailCondition GetRootAsIReadMailCondition(ByteBuffer _bb)
		{
			return IReadMailCondition.GetRootAsIReadMailCondition(_bb, default(IReadMailCondition));
		}

		// Token: 0x0601961B RID: 103963 RVA: 0x0039F784 File Offset: 0x0039D984
		public static IReadMailCondition GetRootAsIReadMailCondition(ByteBuffer _bb, IReadMailCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601961C RID: 103964 RVA: 0x0039F7A1 File Offset: 0x0039D9A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601961D RID: 103965 RVA: 0x0039F7B0 File Offset: 0x0039D9B0
		public IReadMailCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007A5E RID: 31326
		// (get) Token: 0x0601961E RID: 103966 RVA: 0x0039F7C0 File Offset: 0x0039D9C0
		public EChildQuest Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EChildQuest.DoInteract;
				}
				return (EChildQuest)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007A5F RID: 31327
		// (get) Token: 0x0601961F RID: 103967 RVA: 0x0039F7FC File Offset: 0x0039D9FC
		public IConditionGroup? PreConditions
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007A60 RID: 31328
		// (get) Token: 0x06019620 RID: 103968 RVA: 0x0039F85C File Offset: 0x0039DA5C
		public int MailId
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

		// Token: 0x06019621 RID: 103969 RVA: 0x0039F898 File Offset: 0x0039DA98
		public static Offset<IReadMailCondition> CreateIReadMailCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), int MailId = 0)
		{
			builder.StartTable(3);
			IReadMailCondition.AddMailId(builder, MailId);
			IReadMailCondition.AddPreConditions(builder, PreConditionsOffset);
			IReadMailCondition.AddType(builder, Type);
			return IReadMailCondition.EndIReadMailCondition(builder);
		}

		// Token: 0x06019622 RID: 103970 RVA: 0x0039F8BC File Offset: 0x0039DABC
		public static void StartIReadMailCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06019623 RID: 103971 RVA: 0x0039F8C5 File Offset: 0x0039DAC5
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019624 RID: 103972 RVA: 0x0039F8D0 File Offset: 0x0039DAD0
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06019625 RID: 103973 RVA: 0x0039F8E0 File Offset: 0x0039DAE0
		public static void AddMailId(FlatBufferBuilder builder, int mailId)
		{
			builder.AddInt(2, mailId, 0);
		}

		// Token: 0x06019626 RID: 103974 RVA: 0x0039F8EB File Offset: 0x0039DAEB
		public static Offset<IReadMailCondition> EndIReadMailCondition(FlatBufferBuilder builder)
		{
			return new Offset<IReadMailCondition>(builder.EndTable());
		}

		// Token: 0x06019627 RID: 103975 RVA: 0x0039F8F8 File Offset: 0x0039DAF8
		public IReadMailConditionT UnPack()
		{
			IReadMailConditionT readMailConditionT = new IReadMailConditionT();
			this.UnPackTo(readMailConditionT);
			return readMailConditionT;
		}

		// Token: 0x06019628 RID: 103976 RVA: 0x0039F914 File Offset: 0x0039DB14
		public void UnPackTo(IReadMailConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.MailId = this.MailId;
		}

		// Token: 0x06019629 RID: 103977 RVA: 0x0039F968 File Offset: 0x0039DB68
		public static Offset<IReadMailCondition> Pack(FlatBufferBuilder builder, IReadMailConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IReadMailCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			return IReadMailCondition.CreateIReadMailCondition(builder, _o.Type, preConditionsOffset, _o.MailId);
		}

		// Token: 0x0400C5CC RID: 50636
		private Table __p;
	}
}
