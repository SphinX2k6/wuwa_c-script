using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B0E RID: 19214
	public struct ICheckRogueAbilitySelectCondition : IFlatbufferObject
	{
		// Token: 0x17008B62 RID: 35682
		// (get) Token: 0x0601E37C RID: 123772 RVA: 0x0043CA94 File Offset: 0x0043AC94
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E37D RID: 123773 RVA: 0x0043CAA1 File Offset: 0x0043ACA1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E37E RID: 123774 RVA: 0x0043CAA8 File Offset: 0x0043ACA8
		public static ICheckRogueAbilitySelectCondition GetRootAsICheckRogueAbilitySelectCondition(ByteBuffer _bb)
		{
			return ICheckRogueAbilitySelectCondition.GetRootAsICheckRogueAbilitySelectCondition(_bb, default(ICheckRogueAbilitySelectCondition));
		}

		// Token: 0x0601E37F RID: 123775 RVA: 0x0043CAC4 File Offset: 0x0043ACC4
		public static ICheckRogueAbilitySelectCondition GetRootAsICheckRogueAbilitySelectCondition(ByteBuffer _bb, ICheckRogueAbilitySelectCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E380 RID: 123776 RVA: 0x0043CAE1 File Offset: 0x0043ACE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E381 RID: 123777 RVA: 0x0043CAF0 File Offset: 0x0043ACF0
		public ICheckRogueAbilitySelectCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008B63 RID: 35683
		// (get) Token: 0x0601E382 RID: 123778 RVA: 0x0043CB00 File Offset: 0x0043AD00
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008B64 RID: 35684
		// (get) Token: 0x0601E383 RID: 123779 RVA: 0x0043CB3C File Offset: 0x0043AD3C
		public int BoardId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008B65 RID: 35685
		// (get) Token: 0x0601E384 RID: 123780 RVA: 0x0043CB78 File Offset: 0x0043AD78
		public bool IsReceived
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601E385 RID: 123781 RVA: 0x0043CBB7 File Offset: 0x0043ADB7
		public static Offset<ICheckRogueAbilitySelectCondition> CreateICheckRogueAbilitySelectCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int BoardId = 0, bool IsReceived = false)
		{
			builder.StartTable(3);
			ICheckRogueAbilitySelectCondition.AddBoardId(builder, BoardId);
			ICheckRogueAbilitySelectCondition.AddIsReceived(builder, IsReceived);
			ICheckRogueAbilitySelectCondition.AddType(builder, Type);
			return ICheckRogueAbilitySelectCondition.EndICheckRogueAbilitySelectCondition(builder);
		}

		// Token: 0x0601E386 RID: 123782 RVA: 0x0043CBDB File Offset: 0x0043ADDB
		public static void StartICheckRogueAbilitySelectCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601E387 RID: 123783 RVA: 0x0043CBE4 File Offset: 0x0043ADE4
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E388 RID: 123784 RVA: 0x0043CBEF File Offset: 0x0043ADEF
		public static void AddBoardId(FlatBufferBuilder builder, int boardId)
		{
			builder.AddInt(1, boardId, 0);
		}

		// Token: 0x0601E389 RID: 123785 RVA: 0x0043CBFA File Offset: 0x0043ADFA
		public static void AddIsReceived(FlatBufferBuilder builder, bool isReceived)
		{
			builder.AddBool(2, isReceived, false);
		}

		// Token: 0x0601E38A RID: 123786 RVA: 0x0043CC05 File Offset: 0x0043AE05
		public static Offset<ICheckRogueAbilitySelectCondition> EndICheckRogueAbilitySelectCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckRogueAbilitySelectCondition>(builder.EndTable());
		}

		// Token: 0x0601E38B RID: 123787 RVA: 0x0043CC14 File Offset: 0x0043AE14
		public ICheckRogueAbilitySelectConditionT UnPack()
		{
			ICheckRogueAbilitySelectConditionT checkRogueAbilitySelectConditionT = new ICheckRogueAbilitySelectConditionT();
			this.UnPackTo(checkRogueAbilitySelectConditionT);
			return checkRogueAbilitySelectConditionT;
		}

		// Token: 0x0601E38C RID: 123788 RVA: 0x0043CC2F File Offset: 0x0043AE2F
		public void UnPackTo(ICheckRogueAbilitySelectConditionT _o)
		{
			_o.Type = this.Type;
			_o.BoardId = this.BoardId;
			_o.IsReceived = this.IsReceived;
		}

		// Token: 0x0601E38D RID: 123789 RVA: 0x0043CC58 File Offset: 0x0043AE58
		public static Offset<ICheckRogueAbilitySelectCondition> Pack(FlatBufferBuilder builder, ICheckRogueAbilitySelectConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckRogueAbilitySelectCondition>);
			}
			return ICheckRogueAbilitySelectCondition.CreateICheckRogueAbilitySelectCondition(builder, _o.Type, _o.BoardId, _o.IsReceived);
		}

		// Token: 0x0400D3AA RID: 54186
		private Table __p;
	}
}
