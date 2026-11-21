using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D08 RID: 23816
	public struct IPatrolPositionRefreshOnEntityVisibilityShown : IFlatbufferObject
	{
		// Token: 0x1700AEFB RID: 44795
		// (get) Token: 0x060278E6 RID: 162022 RVA: 0x00569669 File Offset: 0x00567869
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060278E7 RID: 162023 RVA: 0x00569676 File Offset: 0x00567876
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060278E8 RID: 162024 RVA: 0x00569680 File Offset: 0x00567880
		public static IPatrolPositionRefreshOnEntityVisibilityShown GetRootAsIPatrolPositionRefreshOnEntityVisibilityShown(ByteBuffer _bb)
		{
			return IPatrolPositionRefreshOnEntityVisibilityShown.GetRootAsIPatrolPositionRefreshOnEntityVisibilityShown(_bb, default(IPatrolPositionRefreshOnEntityVisibilityShown));
		}

		// Token: 0x060278E9 RID: 162025 RVA: 0x0056969C File Offset: 0x0056789C
		public static IPatrolPositionRefreshOnEntityVisibilityShown GetRootAsIPatrolPositionRefreshOnEntityVisibilityShown(ByteBuffer _bb, IPatrolPositionRefreshOnEntityVisibilityShown obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060278EA RID: 162026 RVA: 0x005696B9 File Offset: 0x005678B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060278EB RID: 162027 RVA: 0x005696C8 File Offset: 0x005678C8
		public IPatrolPositionRefreshOnEntityVisibilityShown __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AEFC RID: 44796
		// (get) Token: 0x060278EC RID: 162028 RVA: 0x005696D8 File Offset: 0x005678D8
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

		// Token: 0x060278ED RID: 162029 RVA: 0x00569714 File Offset: 0x00567914
		public static Offset<IPatrolPositionRefreshOnEntityVisibilityShown> CreateIPatrolPositionRefreshOnEntityVisibilityShown(FlatBufferBuilder builder, EPatrolPositionRefreshTriggerType Type = EPatrolPositionRefreshTriggerType.EntityAwake)
		{
			builder.StartTable(1);
			IPatrolPositionRefreshOnEntityVisibilityShown.AddType(builder, Type);
			return IPatrolPositionRefreshOnEntityVisibilityShown.EndIPatrolPositionRefreshOnEntityVisibilityShown(builder);
		}

		// Token: 0x060278EE RID: 162030 RVA: 0x0056972A File Offset: 0x0056792A
		public static void StartIPatrolPositionRefreshOnEntityVisibilityShown(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060278EF RID: 162031 RVA: 0x00569733 File Offset: 0x00567933
		public static void AddType(FlatBufferBuilder builder, EPatrolPositionRefreshTriggerType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060278F0 RID: 162032 RVA: 0x0056973E File Offset: 0x0056793E
		public static Offset<IPatrolPositionRefreshOnEntityVisibilityShown> EndIPatrolPositionRefreshOnEntityVisibilityShown(FlatBufferBuilder builder)
		{
			return new Offset<IPatrolPositionRefreshOnEntityVisibilityShown>(builder.EndTable());
		}

		// Token: 0x060278F1 RID: 162033 RVA: 0x0056974C File Offset: 0x0056794C
		public IPatrolPositionRefreshOnEntityVisibilityShownT UnPack()
		{
			IPatrolPositionRefreshOnEntityVisibilityShownT patrolPositionRefreshOnEntityVisibilityShownT = new IPatrolPositionRefreshOnEntityVisibilityShownT();
			this.UnPackTo(patrolPositionRefreshOnEntityVisibilityShownT);
			return patrolPositionRefreshOnEntityVisibilityShownT;
		}

		// Token: 0x060278F2 RID: 162034 RVA: 0x00569767 File Offset: 0x00567967
		public void UnPackTo(IPatrolPositionRefreshOnEntityVisibilityShownT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060278F3 RID: 162035 RVA: 0x00569778 File Offset: 0x00567978
		public static Offset<IPatrolPositionRefreshOnEntityVisibilityShown> Pack(FlatBufferBuilder builder, IPatrolPositionRefreshOnEntityVisibilityShownT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPatrolPositionRefreshOnEntityVisibilityShown>);
			}
			return IPatrolPositionRefreshOnEntityVisibilityShown.CreateIPatrolPositionRefreshOnEntityVisibilityShown(builder, _o.Type);
		}

		// Token: 0x0400F842 RID: 63554
		private Table __p;
	}
}
