using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042D4 RID: 17108
	public struct IHealthAttributeToTarget : IFlatbufferObject
	{
		// Token: 0x17007529 RID: 29993
		// (get) Token: 0x0601802D RID: 98349 RVA: 0x0036D7D2 File Offset: 0x0036B9D2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601802E RID: 98350 RVA: 0x0036D7DF File Offset: 0x0036B9DF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601802F RID: 98351 RVA: 0x0036D7E8 File Offset: 0x0036B9E8
		public static IHealthAttributeToTarget GetRootAsIHealthAttributeToTarget(ByteBuffer _bb)
		{
			return IHealthAttributeToTarget.GetRootAsIHealthAttributeToTarget(_bb, default(IHealthAttributeToTarget));
		}

		// Token: 0x06018030 RID: 98352 RVA: 0x0036D804 File Offset: 0x0036BA04
		public static IHealthAttributeToTarget GetRootAsIHealthAttributeToTarget(ByteBuffer _bb, IHealthAttributeToTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018031 RID: 98353 RVA: 0x0036D821 File Offset: 0x0036BA21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018032 RID: 98354 RVA: 0x0036D830 File Offset: 0x0036BA30
		public IHealthAttributeToTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700752A RID: 29994
		// (get) Token: 0x06018033 RID: 98355 RVA: 0x0036D840 File Offset: 0x0036BA40
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

		// Token: 0x1700752B RID: 29995
		// (get) Token: 0x06018034 RID: 98356 RVA: 0x0036D87C File Offset: 0x0036BA7C
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

		// Token: 0x1700752C RID: 29996
		// (get) Token: 0x06018035 RID: 98357 RVA: 0x0036D8BC File Offset: 0x0036BABC
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

		// Token: 0x1700752D RID: 29997
		// (get) Token: 0x06018036 RID: 98358 RVA: 0x0036D8FC File Offset: 0x0036BAFC
		public bool ZeroHealthOnDeath
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700752E RID: 29998
		// (get) Token: 0x06018037 RID: 98359 RVA: 0x0036D93C File Offset: 0x0036BB3C
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

		// Token: 0x06018038 RID: 98360 RVA: 0x0036D979 File Offset: 0x0036BB79
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

		// Token: 0x06018039 RID: 98361 RVA: 0x0036D9AD File Offset: 0x0036BBAD
		public static void StartIHealthAttributeToTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601803A RID: 98362 RVA: 0x0036D9B6 File Offset: 0x0036BBB6
		public static void AddType(FlatBufferBuilder builder, EAttributeToTarget type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601803B RID: 98363 RVA: 0x0036D9C1 File Offset: 0x0036BBC1
		public static void AddMin(FlatBufferBuilder builder, float min)
		{
			builder.AddFloat(1, min, 0.0);
		}

		// Token: 0x0601803C RID: 98364 RVA: 0x0036D9D4 File Offset: 0x0036BBD4
		public static void AddMax(FlatBufferBuilder builder, float max)
		{
			builder.AddFloat(2, max, 0.0);
		}

		// Token: 0x0601803D RID: 98365 RVA: 0x0036D9E7 File Offset: 0x0036BBE7
		public static void AddZeroHealthOnDeath(FlatBufferBuilder builder, bool zeroHealthOnDeath)
		{
			builder.AddBool(3, zeroHealthOnDeath, false);
		}

		// Token: 0x0601803E RID: 98366 RVA: 0x0036D9F2 File Offset: 0x0036BBF2
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0601803F RID: 98367 RVA: 0x0036D9FD File Offset: 0x0036BBFD
		public static Offset<IHealthAttributeToTarget> EndIHealthAttributeToTarget(FlatBufferBuilder builder)
		{
			return new Offset<IHealthAttributeToTarget>(builder.EndTable());
		}

		// Token: 0x06018040 RID: 98368 RVA: 0x0036DA0C File Offset: 0x0036BC0C
		public IHealthAttributeToTargetT UnPack()
		{
			IHealthAttributeToTargetT healthAttributeToTargetT = new IHealthAttributeToTargetT();
			this.UnPackTo(healthAttributeToTargetT);
			return healthAttributeToTargetT;
		}

		// Token: 0x06018041 RID: 98369 RVA: 0x0036DA27 File Offset: 0x0036BC27
		public void UnPackTo(IHealthAttributeToTargetT _o)
		{
			_o.Type = this.Type;
			_o.Min = this.Min;
			_o.Max = this.Max;
			_o.ZeroHealthOnDeath = this.ZeroHealthOnDeath;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06018042 RID: 98370 RVA: 0x0036DA68 File Offset: 0x0036BC68
		public static Offset<IHealthAttributeToTarget> Pack(FlatBufferBuilder builder, IHealthAttributeToTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHealthAttributeToTarget>);
			}
			return IHealthAttributeToTarget.CreateIHealthAttributeToTarget(builder, _o.Type, _o.Min, _o.Max, _o.ZeroHealthOnDeath, _o.NullMask);
		}

		// Token: 0x0400C23A RID: 49722
		private Table __p;
	}
}
