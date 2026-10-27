using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D16 RID: 15638
	public struct IAtomicProcess : IFlatbufferObject
	{
		// Token: 0x17006B47 RID: 27463
		// (get) Token: 0x0601593B RID: 88379 RVA: 0x0031DBD5 File Offset: 0x0031BDD5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601593C RID: 88380 RVA: 0x0031DBE2 File Offset: 0x0031BDE2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601593D RID: 88381 RVA: 0x0031DBEC File Offset: 0x0031BDEC
		public static IAtomicProcess GetRootAsIAtomicProcess(ByteBuffer _bb)
		{
			return IAtomicProcess.GetRootAsIAtomicProcess(_bb, default(IAtomicProcess));
		}

		// Token: 0x0601593E RID: 88382 RVA: 0x0031DC08 File Offset: 0x0031BE08
		public static IAtomicProcess GetRootAsIAtomicProcess(ByteBuffer _bb, IAtomicProcess obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601593F RID: 88383 RVA: 0x0031DC25 File Offset: 0x0031BE25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015940 RID: 88384 RVA: 0x0031DC34 File Offset: 0x0031BE34
		public IAtomicProcess __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006B48 RID: 27464
		// (get) Token: 0x06015941 RID: 88385 RVA: 0x0031DC44 File Offset: 0x0031BE44
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

		// Token: 0x17006B49 RID: 27465
		// (get) Token: 0x06015942 RID: 88386 RVA: 0x0031DC80 File Offset: 0x0031BE80
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

		// Token: 0x17006B4A RID: 27466
		// (get) Token: 0x06015943 RID: 88387 RVA: 0x0031DCE0 File Offset: 0x0031BEE0
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

		// Token: 0x06015944 RID: 88388 RVA: 0x0031DD3D File Offset: 0x0031BF3D
		public static Offset<IAtomicProcess> CreateIAtomicProcess(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), Offset<IAtomicProcessStoveCoreFall> AtomicProcessTypeOffset = default(Offset<IAtomicProcessStoveCoreFall>))
		{
			builder.StartTable(3);
			IAtomicProcess.AddAtomicProcessType(builder, AtomicProcessTypeOffset);
			IAtomicProcess.AddPreConditions(builder, PreConditionsOffset);
			IAtomicProcess.AddType(builder, Type);
			return IAtomicProcess.EndIAtomicProcess(builder);
		}

		// Token: 0x06015945 RID: 88389 RVA: 0x0031DD61 File Offset: 0x0031BF61
		public static void StartIAtomicProcess(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06015946 RID: 88390 RVA: 0x0031DD6A File Offset: 0x0031BF6A
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015947 RID: 88391 RVA: 0x0031DD75 File Offset: 0x0031BF75
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06015948 RID: 88392 RVA: 0x0031DD85 File Offset: 0x0031BF85
		public static void AddAtomicProcessType(FlatBufferBuilder builder, Offset<IAtomicProcessStoveCoreFall> atomicProcessTypeOffset)
		{
			builder.AddOffset(2, atomicProcessTypeOffset.Value, 0);
		}

		// Token: 0x06015949 RID: 88393 RVA: 0x0031DD95 File Offset: 0x0031BF95
		public static Offset<IAtomicProcess> EndIAtomicProcess(FlatBufferBuilder builder)
		{
			return new Offset<IAtomicProcess>(builder.EndTable());
		}

		// Token: 0x0601594A RID: 88394 RVA: 0x0031DDA4 File Offset: 0x0031BFA4
		public IAtomicProcessT UnPack()
		{
			IAtomicProcessT atomicProcessT = new IAtomicProcessT();
			this.UnPackTo(atomicProcessT);
			return atomicProcessT;
		}

		// Token: 0x0601594B RID: 88395 RVA: 0x0031DDC0 File Offset: 0x0031BFC0
		public void UnPackTo(IAtomicProcessT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.AtomicProcessType = ((this.AtomicProcessType != null) ? this.AtomicProcessType.Value.UnPack() : null);
		}

		// Token: 0x0601594C RID: 88396 RVA: 0x0031DE38 File Offset: 0x0031C038
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

		// Token: 0x0400B5CA RID: 46538
		private Table __p;
	}
}
