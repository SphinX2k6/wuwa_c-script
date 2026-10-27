using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005347 RID: 21319
	public struct IGroupAiPatrol : IFlatbufferObject
	{
		// Token: 0x17009C9A RID: 40090
		// (get) Token: 0x06022DD8 RID: 142808 RVA: 0x004D4756 File Offset: 0x004D2956
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022DD9 RID: 142809 RVA: 0x004D4763 File Offset: 0x004D2963
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022DDA RID: 142810 RVA: 0x004D476C File Offset: 0x004D296C
		public static IGroupAiPatrol GetRootAsIGroupAiPatrol(ByteBuffer _bb)
		{
			return IGroupAiPatrol.GetRootAsIGroupAiPatrol(_bb, default(IGroupAiPatrol));
		}

		// Token: 0x06022DDB RID: 142811 RVA: 0x004D4788 File Offset: 0x004D2988
		public static IGroupAiPatrol GetRootAsIGroupAiPatrol(ByteBuffer _bb, IGroupAiPatrol obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022DDC RID: 142812 RVA: 0x004D47A5 File Offset: 0x004D29A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022DDD RID: 142813 RVA: 0x004D47B4 File Offset: 0x004D29B4
		public IGroupAiPatrol __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009C9B RID: 40091
		// (get) Token: 0x06022DDE RID: 142814 RVA: 0x004D47C4 File Offset: 0x004D29C4
		public EGroupAiMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGroupAiMode.Default;
				}
				return (EGroupAiMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009C9C RID: 40092
		// (get) Token: 0x06022DDF RID: 142815 RVA: 0x004D4800 File Offset: 0x004D2A00
		public int Leader
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

		// Token: 0x17009C9D RID: 40093
		// (get) Token: 0x06022DE0 RID: 142816 RVA: 0x004D483C File Offset: 0x004D2A3C
		public int SplineEntityId
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

		// Token: 0x17009C9E RID: 40094
		// (get) Token: 0x06022DE1 RID: 142817 RVA: 0x004D4878 File Offset: 0x004D2A78
		public int PlayerPlaceholderEntityId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009C9F RID: 40095
		// (get) Token: 0x06022DE2 RID: 142818 RVA: 0x004D48B8 File Offset: 0x004D2AB8
		public EGroupAiFormationBasis FormationBasis
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return EGroupAiFormationBasis.Spline;
				}
				return (EGroupAiFormationBasis)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009CA0 RID: 40096
		// (get) Token: 0x06022DE3 RID: 142819 RVA: 0x004D48F8 File Offset: 0x004D2AF8
		public bool IsPreciseFormation
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009CA1 RID: 40097
		// (get) Token: 0x06022DE4 RID: 142820 RVA: 0x004D4938 File Offset: 0x004D2B38
		public IGroupAiEcologyGameplayAbp? EcologyGameplayAbp
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new IGroupAiEcologyGameplayAbp?(default(IGroupAiEcologyGameplayAbp).__assign(num + this.__p.bb_pos, this.__p.bb));
			}
		}

		// Token: 0x17009CA2 RID: 40098
		// (get) Token: 0x06022DE5 RID: 142821 RVA: 0x004D498C File Offset: 0x004D2B8C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022DE6 RID: 142822 RVA: 0x004D49CC File Offset: 0x004D2BCC
		public static Offset<IGroupAiPatrol> CreateIGroupAiPatrol(FlatBufferBuilder builder, EGroupAiMode Type = EGroupAiMode.Default, int Leader = 0, int SplineEntityId = 0, int PlayerPlaceholderEntityId = 0, EGroupAiFormationBasis FormationBasis = EGroupAiFormationBasis.Spline, bool IsPreciseFormation = false, IGroupAiEcologyGameplayAbpT EcologyGameplayAbp = null, byte NullMask = 0)
		{
			builder.StartTable(8);
			IGroupAiPatrol.AddEcologyGameplayAbp(builder, IGroupAiEcologyGameplayAbp.Pack(builder, EcologyGameplayAbp));
			IGroupAiPatrol.AddPlayerPlaceholderEntityId(builder, PlayerPlaceholderEntityId);
			IGroupAiPatrol.AddSplineEntityId(builder, SplineEntityId);
			IGroupAiPatrol.AddLeader(builder, Leader);
			IGroupAiPatrol.AddNullMask(builder, NullMask);
			IGroupAiPatrol.AddIsPreciseFormation(builder, IsPreciseFormation);
			IGroupAiPatrol.AddFormationBasis(builder, FormationBasis);
			IGroupAiPatrol.AddType(builder, Type);
			return IGroupAiPatrol.EndIGroupAiPatrol(builder);
		}

		// Token: 0x06022DE7 RID: 142823 RVA: 0x004D4A29 File Offset: 0x004D2C29
		public static void StartIGroupAiPatrol(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06022DE8 RID: 142824 RVA: 0x004D4A32 File Offset: 0x004D2C32
		public static void AddType(FlatBufferBuilder builder, EGroupAiMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022DE9 RID: 142825 RVA: 0x004D4A3D File Offset: 0x004D2C3D
		public static void AddLeader(FlatBufferBuilder builder, int leader)
		{
			builder.AddInt(1, leader, 0);
		}

		// Token: 0x06022DEA RID: 142826 RVA: 0x004D4A48 File Offset: 0x004D2C48
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(2, splineEntityId, 0);
		}

		// Token: 0x06022DEB RID: 142827 RVA: 0x004D4A53 File Offset: 0x004D2C53
		public static void AddPlayerPlaceholderEntityId(FlatBufferBuilder builder, int playerPlaceholderEntityId)
		{
			builder.AddInt(3, playerPlaceholderEntityId, 0);
		}

		// Token: 0x06022DEC RID: 142828 RVA: 0x004D4A5E File Offset: 0x004D2C5E
		public static void AddFormationBasis(FlatBufferBuilder builder, EGroupAiFormationBasis formationBasis)
		{
			builder.AddByte(4, (byte)formationBasis, 0);
		}

		// Token: 0x06022DED RID: 142829 RVA: 0x004D4A69 File Offset: 0x004D2C69
		public static void AddIsPreciseFormation(FlatBufferBuilder builder, bool isPreciseFormation)
		{
			builder.AddBool(5, isPreciseFormation, false);
		}

		// Token: 0x06022DEE RID: 142830 RVA: 0x004D4A74 File Offset: 0x004D2C74
		public static void AddEcologyGameplayAbp(FlatBufferBuilder builder, Offset<IGroupAiEcologyGameplayAbp> ecologyGameplayAbpOffset)
		{
			builder.AddStruct(6, ecologyGameplayAbpOffset.Value, 0);
		}

		// Token: 0x06022DEF RID: 142831 RVA: 0x004D4A84 File Offset: 0x004D2C84
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06022DF0 RID: 142832 RVA: 0x004D4A8F File Offset: 0x004D2C8F
		public static Offset<IGroupAiPatrol> EndIGroupAiPatrol(FlatBufferBuilder builder)
		{
			return new Offset<IGroupAiPatrol>(builder.EndTable());
		}

		// Token: 0x06022DF1 RID: 142833 RVA: 0x004D4A9C File Offset: 0x004D2C9C
		public IGroupAiPatrolT UnPack()
		{
			IGroupAiPatrolT groupAiPatrolT = new IGroupAiPatrolT();
			this.UnPackTo(groupAiPatrolT);
			return groupAiPatrolT;
		}

		// Token: 0x06022DF2 RID: 142834 RVA: 0x004D4AB8 File Offset: 0x004D2CB8
		public void UnPackTo(IGroupAiPatrolT _o)
		{
			_o.Type = this.Type;
			_o.Leader = this.Leader;
			_o.SplineEntityId = this.SplineEntityId;
			_o.PlayerPlaceholderEntityId = this.PlayerPlaceholderEntityId;
			_o.FormationBasis = this.FormationBasis;
			_o.IsPreciseFormation = this.IsPreciseFormation;
			_o.EcologyGameplayAbp = ((this.EcologyGameplayAbp != null) ? this.EcologyGameplayAbp.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06022DF3 RID: 142835 RVA: 0x004D4B48 File Offset: 0x004D2D48
		public static Offset<IGroupAiPatrol> Pack(FlatBufferBuilder builder, IGroupAiPatrolT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGroupAiPatrol>);
			}
			return IGroupAiPatrol.CreateIGroupAiPatrol(builder, _o.Type, _o.Leader, _o.SplineEntityId, _o.PlayerPlaceholderEntityId, _o.FormationBasis, _o.IsPreciseFormation, _o.EcologyGameplayAbp, _o.NullMask);
		}

		// Token: 0x0400E514 RID: 58644
		private Table __p;
	}
}
