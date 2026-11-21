using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D05 RID: 23813
	public struct IPatrolPositionRefreshOnEntityAwake : IFlatbufferObject
	{
		// Token: 0x1700AEF8 RID: 44792
		// (get) Token: 0x060278D4 RID: 162004 RVA: 0x005694F2 File Offset: 0x005676F2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060278D5 RID: 162005 RVA: 0x005694FF File Offset: 0x005676FF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060278D6 RID: 162006 RVA: 0x00569508 File Offset: 0x00567708
		public static IPatrolPositionRefreshOnEntityAwake GetRootAsIPatrolPositionRefreshOnEntityAwake(ByteBuffer _bb)
		{
			return IPatrolPositionRefreshOnEntityAwake.GetRootAsIPatrolPositionRefreshOnEntityAwake(_bb, default(IPatrolPositionRefreshOnEntityAwake));
		}

		// Token: 0x060278D7 RID: 162007 RVA: 0x00569524 File Offset: 0x00567724
		public static IPatrolPositionRefreshOnEntityAwake GetRootAsIPatrolPositionRefreshOnEntityAwake(ByteBuffer _bb, IPatrolPositionRefreshOnEntityAwake obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060278D8 RID: 162008 RVA: 0x00569541 File Offset: 0x00567741
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060278D9 RID: 162009 RVA: 0x00569550 File Offset: 0x00567750
		public IPatrolPositionRefreshOnEntityAwake __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AEF9 RID: 44793
		// (get) Token: 0x060278DA RID: 162010 RVA: 0x00569560 File Offset: 0x00567760
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

		// Token: 0x060278DB RID: 162011 RVA: 0x0056959C File Offset: 0x0056779C
		public static Offset<IPatrolPositionRefreshOnEntityAwake> CreateIPatrolPositionRefreshOnEntityAwake(FlatBufferBuilder builder, EPatrolPositionRefreshTriggerType Type = EPatrolPositionRefreshTriggerType.EntityAwake)
		{
			builder.StartTable(1);
			IPatrolPositionRefreshOnEntityAwake.AddType(builder, Type);
			return IPatrolPositionRefreshOnEntityAwake.EndIPatrolPositionRefreshOnEntityAwake(builder);
		}

		// Token: 0x060278DC RID: 162012 RVA: 0x005695B2 File Offset: 0x005677B2
		public static void StartIPatrolPositionRefreshOnEntityAwake(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060278DD RID: 162013 RVA: 0x005695BB File Offset: 0x005677BB
		public static void AddType(FlatBufferBuilder builder, EPatrolPositionRefreshTriggerType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060278DE RID: 162014 RVA: 0x005695C6 File Offset: 0x005677C6
		public static Offset<IPatrolPositionRefreshOnEntityAwake> EndIPatrolPositionRefreshOnEntityAwake(FlatBufferBuilder builder)
		{
			return new Offset<IPatrolPositionRefreshOnEntityAwake>(builder.EndTable());
		}

		// Token: 0x060278DF RID: 162015 RVA: 0x005695D4 File Offset: 0x005677D4
		public IPatrolPositionRefreshOnEntityAwakeT UnPack()
		{
			IPatrolPositionRefreshOnEntityAwakeT patrolPositionRefreshOnEntityAwakeT = new IPatrolPositionRefreshOnEntityAwakeT();
			this.UnPackTo(patrolPositionRefreshOnEntityAwakeT);
			return patrolPositionRefreshOnEntityAwakeT;
		}

		// Token: 0x060278E0 RID: 162016 RVA: 0x005695EF File Offset: 0x005677EF
		public void UnPackTo(IPatrolPositionRefreshOnEntityAwakeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060278E1 RID: 162017 RVA: 0x00569600 File Offset: 0x00567800
		public static Offset<IPatrolPositionRefreshOnEntityAwake> Pack(FlatBufferBuilder builder, IPatrolPositionRefreshOnEntityAwakeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPatrolPositionRefreshOnEntityAwake>);
			}
			return IPatrolPositionRefreshOnEntityAwake.CreateIPatrolPositionRefreshOnEntityAwake(builder, _o.Type);
		}

		// Token: 0x0400F840 RID: 63552
		private Table __p;
	}
}
