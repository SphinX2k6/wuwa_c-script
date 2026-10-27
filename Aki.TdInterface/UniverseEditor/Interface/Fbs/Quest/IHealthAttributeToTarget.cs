using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E96 RID: 16022
	public struct IHealthAttributeToTarget : IFlatbufferObject
	{
		// Token: 0x17006F3C RID: 28476
		// (get) Token: 0x060169E0 RID: 92640 RVA: 0x00344849 File Offset: 0x00342A49
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060169E1 RID: 92641 RVA: 0x00344856 File Offset: 0x00342A56
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060169E2 RID: 92642 RVA: 0x00344860 File Offset: 0x00342A60
		public static IHealthAttributeToTarget GetRootAsIHealthAttributeToTarget(ByteBuffer _bb)
		{
			return IHealthAttributeToTarget.GetRootAsIHealthAttributeToTarget(_bb, default(IHealthAttributeToTarget));
		}

		// Token: 0x060169E3 RID: 92643 RVA: 0x0034487C File Offset: 0x00342A7C
		public static IHealthAttributeToTarget GetRootAsIHealthAttributeToTarget(ByteBuffer _bb, IHealthAttributeToTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060169E4 RID: 92644 RVA: 0x00344899 File Offset: 0x00342A99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060169E5 RID: 92645 RVA: 0x003448A8 File Offset: 0x00342AA8
		public IHealthAttributeToTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006F3D RID: 28477
		// (get) Token: 0x060169E6 RID: 92646 RVA: 0x003448B8 File Offset: 0x00342AB8
		public EAttributeToTarget Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAttributeToTarget.Health;
				}
				return (EAttributeToTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006F3E RID: 28478
		// (get) Token: 0x060169E7 RID: 92647 RVA: 0x003448F4 File Offset: 0x00342AF4
		public float Min
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006F3F RID: 28479
		// (get) Token: 0x060169E8 RID: 92648 RVA: 0x00344934 File Offset: 0x00342B34
		public float Max
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006F40 RID: 28480
		// (get) Token: 0x060169E9 RID: 92649 RVA: 0x00344974 File Offset: 0x00342B74
		public bool ZeroHealthOnDeath
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006F41 RID: 28481
		// (get) Token: 0x060169EA RID: 92650 RVA: 0x003449B4 File Offset: 0x00342BB4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060169EB RID: 92651 RVA: 0x003449F1 File Offset: 0x00342BF1
		public static Offset<IHealthAttributeToTarget> CreateIHealthAttributeToTarget(FlatBufferBuilder builder, EAttributeToTarget Type = EAttributeToTarget.Health, float Min = 0f, float Max = 0f, bool ZeroHealthOnDeath = false, byte NullMask = 0)
		{
			builder.StartTable(5);
			IHealthAttributeToTarget.AddMax(builder, Max);
			IHealthAttributeToTarget.AddMin(builder, Min);
			IHealthAttributeToTarget.AddNullMask(builder, NullMask);
			IHealthAttributeToTarget.AddZeroHealthOnDeath(builder, ZeroHealthOnDeath);
			IHealthAttributeToTarget.AddType(builder, Type);
			return IHealthAttributeToTarget.EndIHealthAttributeToTarget(builder);
		}

		// Token: 0x060169EC RID: 92652 RVA: 0x00344A25 File Offset: 0x00342C25
		public static void StartIHealthAttributeToTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060169ED RID: 92653 RVA: 0x00344A2E File Offset: 0x00342C2E
		public static void AddType(FlatBufferBuilder builder, EAttributeToTarget type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060169EE RID: 92654 RVA: 0x00344A39 File Offset: 0x00342C39
		public static void AddMin(FlatBufferBuilder builder, float min)
		{
			builder.AddFloat(1, min, 0.0);
		}

		// Token: 0x060169EF RID: 92655 RVA: 0x00344A4C File Offset: 0x00342C4C
		public static void AddMax(FlatBufferBuilder builder, float max)
		{
			builder.AddFloat(2, max, 0.0);
		}

		// Token: 0x060169F0 RID: 92656 RVA: 0x00344A5F File Offset: 0x00342C5F
		public static void AddZeroHealthOnDeath(FlatBufferBuilder builder, bool zeroHealthOnDeath)
		{
			builder.AddBool(3, zeroHealthOnDeath, false);
		}

		// Token: 0x060169F1 RID: 92657 RVA: 0x00344A6A File Offset: 0x00342C6A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060169F2 RID: 92658 RVA: 0x00344A75 File Offset: 0x00342C75
		public static Offset<IHealthAttributeToTarget> EndIHealthAttributeToTarget(FlatBufferBuilder builder)
		{
			return new Offset<IHealthAttributeToTarget>(builder.EndTable());
		}

		// Token: 0x060169F3 RID: 92659 RVA: 0x00344A84 File Offset: 0x00342C84
		public IHealthAttributeToTargetT UnPack()
		{
			IHealthAttributeToTargetT healthAttributeToTargetT = new IHealthAttributeToTargetT();
			this.UnPackTo(healthAttributeToTargetT);
			return healthAttributeToTargetT;
		}

		// Token: 0x060169F4 RID: 92660 RVA: 0x00344A9F File Offset: 0x00342C9F
		public void UnPackTo(IHealthAttributeToTargetT _o)
		{
			_o.Type = this.Type;
			_o.Min = this.Min;
			_o.Max = this.Max;
			_o.ZeroHealthOnDeath = this.ZeroHealthOnDeath;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060169F5 RID: 92661 RVA: 0x00344AE0 File Offset: 0x00342CE0
		public static Offset<IHealthAttributeToTarget> Pack(FlatBufferBuilder builder, IHealthAttributeToTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHealthAttributeToTarget>);
			}
			return IHealthAttributeToTarget.CreateIHealthAttributeToTarget(builder, _o.Type, _o.Min, _o.Max, _o.ZeroHealthOnDeath, _o.NullMask);
		}

		// Token: 0x0400B85E RID: 47198
		private Table __p;
	}
}
