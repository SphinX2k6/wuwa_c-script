using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EBA RID: 20154
	public struct ICheckEntityBuffStack : IFlatbufferObject
	{
		// Token: 0x17008FC8 RID: 36808
		// (get) Token: 0x0601F3F5 RID: 127989 RVA: 0x0045AF02 File Offset: 0x00459102
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F3F6 RID: 127990 RVA: 0x0045AF0F File Offset: 0x0045910F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F3F7 RID: 127991 RVA: 0x0045AF18 File Offset: 0x00459118
		public static ICheckEntityBuffStack GetRootAsICheckEntityBuffStack(ByteBuffer _bb)
		{
			return ICheckEntityBuffStack.GetRootAsICheckEntityBuffStack(_bb, default(ICheckEntityBuffStack));
		}

		// Token: 0x0601F3F8 RID: 127992 RVA: 0x0045AF34 File Offset: 0x00459134
		public static ICheckEntityBuffStack GetRootAsICheckEntityBuffStack(ByteBuffer _bb, ICheckEntityBuffStack obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F3F9 RID: 127993 RVA: 0x0045AF51 File Offset: 0x00459151
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F3FA RID: 127994 RVA: 0x0045AF60 File Offset: 0x00459160
		public ICheckEntityBuffStack __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008FC9 RID: 36809
		// (get) Token: 0x0601F3FB RID: 127995 RVA: 0x0045AF70 File Offset: 0x00459170
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

		// Token: 0x17008FCA RID: 36810
		// (get) Token: 0x0601F3FC RID: 127996 RVA: 0x0045AFAC File Offset: 0x004591AC
		public IMonsterBuffContainer? Target
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IMonsterBuffContainer?(default(IMonsterBuffContainer).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17008FCB RID: 36811
		// (get) Token: 0x0601F3FD RID: 127997 RVA: 0x0045B00C File Offset: 0x0045920C
		public long BuffId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0L;
				}
				return this.__p.bb.GetLong(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008FCC RID: 36812
		// (get) Token: 0x0601F3FE RID: 127998 RVA: 0x0045B04C File Offset: 0x0045924C
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008FCD RID: 36813
		// (get) Token: 0x0601F3FF RID: 127999 RVA: 0x0045B08C File Offset: 0x0045928C
		public int Stack
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F400 RID: 128000 RVA: 0x0045B0C9 File Offset: 0x004592C9
		public static Offset<ICheckEntityBuffStack> CreateICheckEntityBuffStack(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, Offset<IMonsterBuffContainer> TargetOffset = default(Offset<IMonsterBuffContainer>), long BuffId = 0L, ECompare Compare = ECompare.Eq, int Stack = 0)
		{
			builder.StartTable(5);
			ICheckEntityBuffStack.AddBuffId(builder, BuffId);
			ICheckEntityBuffStack.AddStack(builder, Stack);
			ICheckEntityBuffStack.AddTarget(builder, TargetOffset);
			ICheckEntityBuffStack.AddCompare(builder, Compare);
			ICheckEntityBuffStack.AddType(builder, Type);
			return ICheckEntityBuffStack.EndICheckEntityBuffStack(builder);
		}

		// Token: 0x0601F401 RID: 128001 RVA: 0x0045B0FD File Offset: 0x004592FD
		public static void StartICheckEntityBuffStack(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601F402 RID: 128002 RVA: 0x0045B106 File Offset: 0x00459306
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F403 RID: 128003 RVA: 0x0045B111 File Offset: 0x00459311
		public static void AddTarget(FlatBufferBuilder builder, Offset<IMonsterBuffContainer> targetOffset)
		{
			builder.AddOffset(1, targetOffset.Value, 0);
		}

		// Token: 0x0601F404 RID: 128004 RVA: 0x0045B121 File Offset: 0x00459321
		public static void AddBuffId(FlatBufferBuilder builder, long buffId)
		{
			builder.AddLong(2, buffId, 0L);
		}

		// Token: 0x0601F405 RID: 128005 RVA: 0x0045B12D File Offset: 0x0045932D
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(3, (byte)compare, 0);
		}

		// Token: 0x0601F406 RID: 128006 RVA: 0x0045B138 File Offset: 0x00459338
		public static void AddStack(FlatBufferBuilder builder, int stack)
		{
			builder.AddInt(4, stack, 0);
		}

		// Token: 0x0601F407 RID: 128007 RVA: 0x0045B143 File Offset: 0x00459343
		public static Offset<ICheckEntityBuffStack> EndICheckEntityBuffStack(FlatBufferBuilder builder)
		{
			return new Offset<ICheckEntityBuffStack>(builder.EndTable());
		}

		// Token: 0x0601F408 RID: 128008 RVA: 0x0045B150 File Offset: 0x00459350
		public ICheckEntityBuffStackT UnPack()
		{
			ICheckEntityBuffStackT checkEntityBuffStackT = new ICheckEntityBuffStackT();
			this.UnPackTo(checkEntityBuffStackT);
			return checkEntityBuffStackT;
		}

		// Token: 0x0601F409 RID: 128009 RVA: 0x0045B16C File Offset: 0x0045936C
		public void UnPackTo(ICheckEntityBuffStackT _o)
		{
			_o.Type = this.Type;
			_o.Target = ((this.Target != null) ? this.Target.Value.UnPack() : null);
			_o.BuffId = this.BuffId;
			_o.Compare = this.Compare;
			_o.Stack = this.Stack;
		}

		// Token: 0x0601F40A RID: 128010 RVA: 0x0045B1D8 File Offset: 0x004593D8
		public static Offset<ICheckEntityBuffStack> Pack(FlatBufferBuilder builder, ICheckEntityBuffStackT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckEntityBuffStack>);
			}
			Offset<IMonsterBuffContainer> targetOffset = (_o.Target == null) ? default(Offset<IMonsterBuffContainer>) : IMonsterBuffContainer.Pack(builder, _o.Target);
			return ICheckEntityBuffStack.CreateICheckEntityBuffStack(builder, _o.Type, targetOffset, _o.BuffId, _o.Compare, _o.Stack);
		}

		// Token: 0x0400DD07 RID: 56583
		private Table __p;
	}
}
