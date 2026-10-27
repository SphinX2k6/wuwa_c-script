using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C6A RID: 19562
	public struct IOpenDateConditon : IFlatbufferObject
	{
		// Token: 0x17008E12 RID: 36370
		// (get) Token: 0x0601F03D RID: 127037 RVA: 0x004561DC File Offset: 0x004543DC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F03E RID: 127038 RVA: 0x004561E9 File Offset: 0x004543E9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F03F RID: 127039 RVA: 0x004561F0 File Offset: 0x004543F0
		public static IOpenDateConditon GetRootAsIOpenDateConditon(ByteBuffer _bb)
		{
			return IOpenDateConditon.GetRootAsIOpenDateConditon(_bb, default(IOpenDateConditon));
		}

		// Token: 0x0601F040 RID: 127040 RVA: 0x0045620C File Offset: 0x0045440C
		public static IOpenDateConditon GetRootAsIOpenDateConditon(ByteBuffer _bb, IOpenDateConditon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F041 RID: 127041 RVA: 0x00456229 File Offset: 0x00454429
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F042 RID: 127042 RVA: 0x00456238 File Offset: 0x00454438
		public IOpenDateConditon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008E13 RID: 36371
		// (get) Token: 0x0601F043 RID: 127043 RVA: 0x00456248 File Offset: 0x00454448
		public EAccessQuestCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAccessQuestCondition.ExploreLevel;
				}
				return (EAccessQuestCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008E14 RID: 36372
		// (get) Token: 0x0601F044 RID: 127044 RVA: 0x00456284 File Offset: 0x00454484
		public int DateId
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

		// Token: 0x17008E15 RID: 36373
		// (get) Token: 0x0601F045 RID: 127045 RVA: 0x004562C0 File Offset: 0x004544C0
		public EQuestOpenDateType OpenType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return EQuestOpenDateType.AfterBeginTime;
				}
				return (EQuestOpenDateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008E16 RID: 36374
		// (get) Token: 0x0601F046 RID: 127046 RVA: 0x004562FC File Offset: 0x004544FC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F047 RID: 127047 RVA: 0x00456339 File Offset: 0x00454539
		public static Offset<IOpenDateConditon> CreateIOpenDateConditon(FlatBufferBuilder builder, EAccessQuestCondition Type = EAccessQuestCondition.ExploreLevel, int DateId = 0, EQuestOpenDateType OpenType = EQuestOpenDateType.AfterBeginTime, byte NullMask = 0)
		{
			builder.StartTable(4);
			IOpenDateConditon.AddDateId(builder, DateId);
			IOpenDateConditon.AddNullMask(builder, NullMask);
			IOpenDateConditon.AddOpenType(builder, OpenType);
			IOpenDateConditon.AddType(builder, Type);
			return IOpenDateConditon.EndIOpenDateConditon(builder);
		}

		// Token: 0x0601F048 RID: 127048 RVA: 0x00456365 File Offset: 0x00454565
		public static void StartIOpenDateConditon(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601F049 RID: 127049 RVA: 0x0045636E File Offset: 0x0045456E
		public static void AddType(FlatBufferBuilder builder, EAccessQuestCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F04A RID: 127050 RVA: 0x00456379 File Offset: 0x00454579
		public static void AddDateId(FlatBufferBuilder builder, int dateId)
		{
			builder.AddInt(1, dateId, 0);
		}

		// Token: 0x0601F04B RID: 127051 RVA: 0x00456384 File Offset: 0x00454584
		public static void AddOpenType(FlatBufferBuilder builder, EQuestOpenDateType openType)
		{
			builder.AddByte(2, (byte)openType, 0);
		}

		// Token: 0x0601F04C RID: 127052 RVA: 0x0045638F File Offset: 0x0045458F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0601F04D RID: 127053 RVA: 0x0045639A File Offset: 0x0045459A
		public static Offset<IOpenDateConditon> EndIOpenDateConditon(FlatBufferBuilder builder)
		{
			return new Offset<IOpenDateConditon>(builder.EndTable());
		}

		// Token: 0x0601F04E RID: 127054 RVA: 0x004563A8 File Offset: 0x004545A8
		public IOpenDateConditonT UnPack()
		{
			IOpenDateConditonT openDateConditonT = new IOpenDateConditonT();
			this.UnPackTo(openDateConditonT);
			return openDateConditonT;
		}

		// Token: 0x0601F04F RID: 127055 RVA: 0x004563C3 File Offset: 0x004545C3
		public void UnPackTo(IOpenDateConditonT _o)
		{
			_o.Type = this.Type;
			_o.DateId = this.DateId;
			_o.OpenType = this.OpenType;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601F050 RID: 127056 RVA: 0x004563F8 File Offset: 0x004545F8
		public static Offset<IOpenDateConditon> Pack(FlatBufferBuilder builder, IOpenDateConditonT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOpenDateConditon>);
			}
			return IOpenDateConditon.CreateIOpenDateConditon(builder, _o.Type, _o.DateId, _o.OpenType, _o.NullMask);
		}

		// Token: 0x0400D619 RID: 54809
		private Table __p;
	}
}
