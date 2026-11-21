using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D0B RID: 23819
	public struct IPatrolPositionRefreshTrigger : IFlatbufferObject
	{
		// Token: 0x1700AEFE RID: 44798
		// (get) Token: 0x060278F8 RID: 162040 RVA: 0x005697E1 File Offset: 0x005679E1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060278F9 RID: 162041 RVA: 0x005697EE File Offset: 0x005679EE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060278FA RID: 162042 RVA: 0x005697F8 File Offset: 0x005679F8
		public static IPatrolPositionRefreshTrigger GetRootAsIPatrolPositionRefreshTrigger(ByteBuffer _bb)
		{
			return IPatrolPositionRefreshTrigger.GetRootAsIPatrolPositionRefreshTrigger(_bb, default(IPatrolPositionRefreshTrigger));
		}

		// Token: 0x060278FB RID: 162043 RVA: 0x00569814 File Offset: 0x00567A14
		public static IPatrolPositionRefreshTrigger GetRootAsIPatrolPositionRefreshTrigger(ByteBuffer _bb, IPatrolPositionRefreshTrigger obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060278FC RID: 162044 RVA: 0x00569831 File Offset: 0x00567A31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060278FD RID: 162045 RVA: 0x00569840 File Offset: 0x00567A40
		public IPatrolPositionRefreshTrigger __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AEFF RID: 44799
		// (get) Token: 0x060278FE RID: 162046 RVA: 0x00569850 File Offset: 0x00567A50
		public EPatrolPositionRefreshTriggerType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPatrolPositionRefreshTriggerType.EntityAwake;
				}
				return (EPatrolPositionRefreshTriggerType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060278FF RID: 162047 RVA: 0x0056988C File Offset: 0x00567A8C
		public static Offset<IPatrolPositionRefreshTrigger> CreateIPatrolPositionRefreshTrigger(FlatBufferBuilder builder, EPatrolPositionRefreshTriggerType Type = EPatrolPositionRefreshTriggerType.EntityAwake)
		{
			builder.StartTable(1);
			IPatrolPositionRefreshTrigger.AddType(builder, Type);
			return IPatrolPositionRefreshTrigger.EndIPatrolPositionRefreshTrigger(builder);
		}

		// Token: 0x06027900 RID: 162048 RVA: 0x005698A2 File Offset: 0x00567AA2
		public static void StartIPatrolPositionRefreshTrigger(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06027901 RID: 162049 RVA: 0x005698AB File Offset: 0x00567AAB
		public static void AddType(FlatBufferBuilder builder, EPatrolPositionRefreshTriggerType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027902 RID: 162050 RVA: 0x005698B6 File Offset: 0x00567AB6
		public static Offset<IPatrolPositionRefreshTrigger> EndIPatrolPositionRefreshTrigger(FlatBufferBuilder builder)
		{
			return new Offset<IPatrolPositionRefreshTrigger>(builder.EndTable());
		}

		// Token: 0x06027903 RID: 162051 RVA: 0x005698C4 File Offset: 0x00567AC4
		public IPatrolPositionRefreshTriggerT UnPack()
		{
			IPatrolPositionRefreshTriggerT patrolPositionRefreshTriggerT = new IPatrolPositionRefreshTriggerT();
			this.UnPackTo(patrolPositionRefreshTriggerT);
			return patrolPositionRefreshTriggerT;
		}

		// Token: 0x06027904 RID: 162052 RVA: 0x005698DF File Offset: 0x00567ADF
		public void UnPackTo(IPatrolPositionRefreshTriggerT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06027905 RID: 162053 RVA: 0x005698F0 File Offset: 0x00567AF0
		public static Offset<IPatrolPositionRefreshTrigger> Pack(FlatBufferBuilder builder, IPatrolPositionRefreshTriggerT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPatrolPositionRefreshTrigger>);
			}
			return IPatrolPositionRefreshTrigger.CreateIPatrolPositionRefreshTrigger(builder, _o.Type);
		}

		// Token: 0x0400F844 RID: 63556
		private Table __p;
	}
}
