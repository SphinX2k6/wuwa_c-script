using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200412D RID: 16685
	public struct IAtomicProcess : IFlatbufferObject
	{
		// Token: 0x17007101 RID: 28929
		// (get) Token: 0x06016E73 RID: 93811 RVA: 0x00344E4D File Offset: 0x0034304D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016E74 RID: 93812 RVA: 0x00344E5A File Offset: 0x0034305A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016E75 RID: 93813 RVA: 0x00344E64 File Offset: 0x00343064
		public static IAtomicProcess GetRootAsIAtomicProcess(ByteBuffer _bb)
		{
			return IAtomicProcess.GetRootAsIAtomicProcess(_bb, default(IAtomicProcess));
		}

		// Token: 0x06016E76 RID: 93814 RVA: 0x00344E80 File Offset: 0x00343080
		public static IAtomicProcess GetRootAsIAtomicProcess(ByteBuffer _bb, IAtomicProcess obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016E77 RID: 93815 RVA: 0x00344E9D File Offset: 0x0034309D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016E78 RID: 93816 RVA: 0x00344EAC File Offset: 0x003430AC
		public IAtomicProcess __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007102 RID: 28930
		// (get) Token: 0x06016E79 RID: 93817 RVA: 0x00344EBC File Offset: 0x003430BC
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

		// Token: 0x17007103 RID: 28931
		// (get) Token: 0x06016E7A RID: 93818 RVA: 0x00344EF8 File Offset: 0x003430F8
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

		// Token: 0x17007104 RID: 28932
		// (get) Token: 0x06016E7B RID: 93819 RVA: 0x00344F58 File Offset: 0x00343158
		public IAtomicProcessStoveCoreFall? AtomicProcessType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IAtomicProcessStoveCoreFall?(default(IAtomicProcessStoveCoreFall).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06016E7C RID: 93820 RVA: 0x00344FB5 File Offset: 0x003431B5
		public static Offset<IAtomicProcess> CreateIAtomicProcess(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), Offset<IAtomicProcessStoveCoreFall> AtomicProcessTypeOffset = default(Offset<IAtomicProcessStoveCoreFall>))
		{
			builder.StartTable(3);
			IAtomicProcess.AddAtomicProcessType(builder, AtomicProcessTypeOffset);
			IAtomicProcess.AddPreConditions(builder, PreConditionsOffset);
			IAtomicProcess.AddType(builder, Type);
			return IAtomicProcess.EndIAtomicProcess(builder);
		}

		// Token: 0x06016E7D RID: 93821 RVA: 0x00344FD9 File Offset: 0x003431D9
		public static void StartIAtomicProcess(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06016E7E RID: 93822 RVA: 0x00344FE2 File Offset: 0x003431E2
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016E7F RID: 93823 RVA: 0x00344FED File Offset: 0x003431ED
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06016E80 RID: 93824 RVA: 0x00344FFD File Offset: 0x003431FD
		public static void AddAtomicProcessType(FlatBufferBuilder builder, Offset<IAtomicProcessStoveCoreFall> atomicProcessTypeOffset)
		{
			builder.AddOffset(2, atomicProcessTypeOffset.Value, 0);
		}

		// Token: 0x06016E81 RID: 93825 RVA: 0x0034500D File Offset: 0x0034320D
		public static Offset<IAtomicProcess> EndIAtomicProcess(FlatBufferBuilder builder)
		{
			return new Offset<IAtomicProcess>(builder.EndTable());
		}

		// Token: 0x06016E82 RID: 93826 RVA: 0x0034501C File Offset: 0x0034321C
		public IAtomicProcessT UnPack()
		{
			IAtomicProcessT atomicProcessT = new IAtomicProcessT();
			this.UnPackTo(atomicProcessT);
			return atomicProcessT;
		}

		// Token: 0x06016E83 RID: 93827 RVA: 0x00345038 File Offset: 0x00343238
		public void UnPackTo(IAtomicProcessT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.AtomicProcessType = ((this.AtomicProcessType != null) ? this.AtomicProcessType.Value.UnPack() : null);
		}

		// Token: 0x06016E84 RID: 93828 RVA: 0x003450B0 File Offset: 0x003432B0
		public static Offset<IAtomicProcess> Pack(FlatBufferBuilder builder, IAtomicProcessT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAtomicProcess>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			Offset<IAtomicProcessStoveCoreFall> atomicProcessTypeOffset = (_o.AtomicProcessType == null) ? default(Offset<IAtomicProcessStoveCoreFall>) : IAtomicProcessStoveCoreFall.Pack(builder, _o.AtomicProcessType);
			return IAtomicProcess.CreateIAtomicProcess(builder, _o.Type, preConditionsOffset, atomicProcessTypeOffset);
		}

		// Token: 0x0400BF77 RID: 49015
		private Table __p;
	}
}
