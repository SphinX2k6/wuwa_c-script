using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A2F RID: 27183
	public struct ILinearOverRangeCameraShake : IFlatbufferObject
	{
		// Token: 0x1700C99D RID: 51613
		// (get) Token: 0x0602F918 RID: 194840 RVA: 0x00679A95 File Offset: 0x00677C95
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F919 RID: 194841 RVA: 0x00679AA2 File Offset: 0x00677CA2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F91A RID: 194842 RVA: 0x00679AAC File Offset: 0x00677CAC
		public static ILinearOverRangeCameraShake GetRootAsILinearOverRangeCameraShake(ByteBuffer _bb)
		{
			return ILinearOverRangeCameraShake.GetRootAsILinearOverRangeCameraShake(_bb, default(ILinearOverRangeCameraShake));
		}

		// Token: 0x0602F91B RID: 194843 RVA: 0x00679AC8 File Offset: 0x00677CC8
		public static ILinearOverRangeCameraShake GetRootAsILinearOverRangeCameraShake(ByteBuffer _bb, ILinearOverRangeCameraShake obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F91C RID: 194844 RVA: 0x00679AE5 File Offset: 0x00677CE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F91D RID: 194845 RVA: 0x00679AF4 File Offset: 0x00677CF4
		public ILinearOverRangeCameraShake __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C99E RID: 51614
		// (get) Token: 0x0602F91E RID: 194846 RVA: 0x00679B04 File Offset: 0x00677D04
		public ECameraShakeType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECameraShakeType.Constant;
				}
				return (ECameraShakeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C99F RID: 51615
		// (get) Token: 0x0602F91F RID: 194847 RVA: 0x00679B40 File Offset: 0x00677D40
		public int CenterEntityId
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

		// Token: 0x1700C9A0 RID: 51616
		// (get) Token: 0x0602F920 RID: 194848 RVA: 0x00679B7C File Offset: 0x00677D7C
		public int MinRange
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

		// Token: 0x1700C9A1 RID: 51617
		// (get) Token: 0x0602F921 RID: 194849 RVA: 0x00679BB8 File Offset: 0x00677DB8
		public int MaxRange
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

		// Token: 0x0602F922 RID: 194850 RVA: 0x00679BF5 File Offset: 0x00677DF5
		public static Offset<ILinearOverRangeCameraShake> CreateILinearOverRangeCameraShake(FlatBufferBuilder builder, ECameraShakeType Type = ECameraShakeType.Constant, int CenterEntityId = 0, int MinRange = 0, int MaxRange = 0)
		{
			builder.StartTable(4);
			ILinearOverRangeCameraShake.AddMaxRange(builder, MaxRange);
			ILinearOverRangeCameraShake.AddMinRange(builder, MinRange);
			ILinearOverRangeCameraShake.AddCenterEntityId(builder, CenterEntityId);
			ILinearOverRangeCameraShake.AddType(builder, Type);
			return ILinearOverRangeCameraShake.EndILinearOverRangeCameraShake(builder);
		}

		// Token: 0x0602F923 RID: 194851 RVA: 0x00679C21 File Offset: 0x00677E21
		public static void StartILinearOverRangeCameraShake(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602F924 RID: 194852 RVA: 0x00679C2A File Offset: 0x00677E2A
		public static void AddType(FlatBufferBuilder builder, ECameraShakeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F925 RID: 194853 RVA: 0x00679C35 File Offset: 0x00677E35
		public static void AddCenterEntityId(FlatBufferBuilder builder, int centerEntityId)
		{
			builder.AddInt(1, centerEntityId, 0);
		}

		// Token: 0x0602F926 RID: 194854 RVA: 0x00679C40 File Offset: 0x00677E40
		public static void AddMinRange(FlatBufferBuilder builder, int minRange)
		{
			builder.AddInt(2, minRange, 0);
		}

		// Token: 0x0602F927 RID: 194855 RVA: 0x00679C4B File Offset: 0x00677E4B
		public static void AddMaxRange(FlatBufferBuilder builder, int maxRange)
		{
			builder.AddInt(3, maxRange, 0);
		}

		// Token: 0x0602F928 RID: 194856 RVA: 0x00679C56 File Offset: 0x00677E56
		public static Offset<ILinearOverRangeCameraShake> EndILinearOverRangeCameraShake(FlatBufferBuilder builder)
		{
			return new Offset<ILinearOverRangeCameraShake>(builder.EndTable());
		}

		// Token: 0x0602F929 RID: 194857 RVA: 0x00679C64 File Offset: 0x00677E64
		public ILinearOverRangeCameraShakeT UnPack()
		{
			ILinearOverRangeCameraShakeT linearOverRangeCameraShakeT = new ILinearOverRangeCameraShakeT();
			this.UnPackTo(linearOverRangeCameraShakeT);
			return linearOverRangeCameraShakeT;
		}

		// Token: 0x0602F92A RID: 194858 RVA: 0x00679C7F File Offset: 0x00677E7F
		public void UnPackTo(ILinearOverRangeCameraShakeT _o)
		{
			_o.Type = this.Type;
			_o.CenterEntityId = this.CenterEntityId;
			_o.MinRange = this.MinRange;
			_o.MaxRange = this.MaxRange;
		}

		// Token: 0x0602F92B RID: 194859 RVA: 0x00679CB4 File Offset: 0x00677EB4
		public static Offset<ILinearOverRangeCameraShake> Pack(FlatBufferBuilder builder, ILinearOverRangeCameraShakeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILinearOverRangeCameraShake>);
			}
			return ILinearOverRangeCameraShake.CreateILinearOverRangeCameraShake(builder, _o.Type, _o.CenterEntityId, _o.MinRange, _o.MaxRange);
		}

		// Token: 0x0401123D RID: 70205
		private Table __p;
	}
}
