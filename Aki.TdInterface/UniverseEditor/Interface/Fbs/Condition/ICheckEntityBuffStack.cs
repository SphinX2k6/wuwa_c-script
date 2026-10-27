using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049FA RID: 18938
	public struct ICheckEntityBuffStack : IFlatbufferObject
	{
		// Token: 0x170088F8 RID: 35064
		// (get) Token: 0x0601D982 RID: 121218 RVA: 0x0042A296 File Offset: 0x00428496
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D983 RID: 121219 RVA: 0x0042A2A3 File Offset: 0x004284A3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D984 RID: 121220 RVA: 0x0042A2AC File Offset: 0x004284AC
		public static ICheckEntityBuffStack GetRootAsICheckEntityBuffStack(ByteBuffer _bb)
		{
			return ICheckEntityBuffStack.GetRootAsICheckEntityBuffStack(_bb, default(ICheckEntityBuffStack));
		}

		// Token: 0x0601D985 RID: 121221 RVA: 0x0042A2C8 File Offset: 0x004284C8
		public static ICheckEntityBuffStack GetRootAsICheckEntityBuffStack(ByteBuffer _bb, ICheckEntityBuffStack obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D986 RID: 121222 RVA: 0x0042A2E5 File Offset: 0x004284E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D987 RID: 121223 RVA: 0x0042A2F4 File Offset: 0x004284F4
		public ICheckEntityBuffStack __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170088F9 RID: 35065
		// (get) Token: 0x0601D988 RID: 121224 RVA: 0x0042A304 File Offset: 0x00428504
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

		// Token: 0x170088FA RID: 35066
		// (get) Token: 0x0601D989 RID: 121225 RVA: 0x0042A340 File Offset: 0x00428540
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

		// Token: 0x170088FB RID: 35067
		// (get) Token: 0x0601D98A RID: 121226 RVA: 0x0042A3A0 File Offset: 0x004285A0
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

		// Token: 0x170088FC RID: 35068
		// (get) Token: 0x0601D98B RID: 121227 RVA: 0x0042A3E0 File Offset: 0x004285E0
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

		// Token: 0x170088FD RID: 35069
		// (get) Token: 0x0601D98C RID: 121228 RVA: 0x0042A420 File Offset: 0x00428620
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

		// Token: 0x0601D98D RID: 121229 RVA: 0x0042A45D File Offset: 0x0042865D
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

		// Token: 0x0601D98E RID: 121230 RVA: 0x0042A491 File Offset: 0x00428691
		public static void StartICheckEntityBuffStack(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601D98F RID: 121231 RVA: 0x0042A49A File Offset: 0x0042869A
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D990 RID: 121232 RVA: 0x0042A4A5 File Offset: 0x004286A5
		public static void AddTarget(FlatBufferBuilder builder, Offset<IMonsterBuffContainer> targetOffset)
		{
			builder.AddOffset(1, targetOffset.Value, 0);
		}

		// Token: 0x0601D991 RID: 121233 RVA: 0x0042A4B5 File Offset: 0x004286B5
		public static void AddBuffId(FlatBufferBuilder builder, long buffId)
		{
			builder.AddLong(2, buffId, 0L);
		}

		// Token: 0x0601D992 RID: 121234 RVA: 0x0042A4C1 File Offset: 0x004286C1
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(3, (byte)compare, 0);
		}

		// Token: 0x0601D993 RID: 121235 RVA: 0x0042A4CC File Offset: 0x004286CC
		public static void AddStack(FlatBufferBuilder builder, int stack)
		{
			builder.AddInt(4, stack, 0);
		}

		// Token: 0x0601D994 RID: 121236 RVA: 0x0042A4D7 File Offset: 0x004286D7
		public static Offset<ICheckEntityBuffStack> EndICheckEntityBuffStack(FlatBufferBuilder builder)
		{
			return new Offset<ICheckEntityBuffStack>(builder.EndTable());
		}

		// Token: 0x0601D995 RID: 121237 RVA: 0x0042A4E4 File Offset: 0x004286E4
		public ICheckEntityBuffStackT UnPack()
		{
			ICheckEntityBuffStackT checkEntityBuffStackT = new ICheckEntityBuffStackT();
			this.UnPackTo(checkEntityBuffStackT);
			return checkEntityBuffStackT;
		}

		// Token: 0x0601D996 RID: 121238 RVA: 0x0042A500 File Offset: 0x00428700
		public void UnPackTo(ICheckEntityBuffStackT _o)
		{
			_o.Type = this.Type;
			_o.Target = ((this.Target != null) ? this.Target.Value.UnPack() : null);
			_o.BuffId = this.BuffId;
			_o.Compare = this.Compare;
			_o.Stack = this.Stack;
		}

		// Token: 0x0601D997 RID: 121239 RVA: 0x0042A56C File Offset: 0x0042876C
		public static Offset<ICheckEntityBuffStack> Pack(FlatBufferBuilder builder, ICheckEntityBuffStackT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckEntityBuffStack>);
			}
			Offset<IMonsterBuffContainer> targetOffset = (_o.Target == null) ? default(Offset<IMonsterBuffContainer>) : IMonsterBuffContainer.Pack(builder, _o.Target);
			return ICheckEntityBuffStack.CreateICheckEntityBuffStack(builder, _o.Type, targetOffset, _o.BuffId, _o.Compare, _o.Stack);
		}

		// Token: 0x0400D233 RID: 53811
		private Table __p;
	}
}
