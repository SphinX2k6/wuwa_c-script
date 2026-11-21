using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Physics
{
	// Token: 0x020047A1 RID: 18337
	public struct IAcmLimited : IFlatbufferObject
	{
		// Token: 0x17007FC2 RID: 32706
		// (get) Token: 0x0601AFE7 RID: 110567 RVA: 0x003D33A1 File Offset: 0x003D15A1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AFE8 RID: 110568 RVA: 0x003D33AE File Offset: 0x003D15AE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AFE9 RID: 110569 RVA: 0x003D33B8 File Offset: 0x003D15B8
		public static IAcmLimited GetRootAsIAcmLimited(ByteBuffer _bb)
		{
			return IAcmLimited.GetRootAsIAcmLimited(_bb, default(IAcmLimited));
		}

		// Token: 0x0601AFEA RID: 110570 RVA: 0x003D33D4 File Offset: 0x003D15D4
		public static IAcmLimited GetRootAsIAcmLimited(ByteBuffer _bb, IAcmLimited obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AFEB RID: 110571 RVA: 0x003D33F1 File Offset: 0x003D15F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AFEC RID: 110572 RVA: 0x003D3400 File Offset: 0x003D1600
		public IAcmLimited __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007FC3 RID: 32707
		// (get) Token: 0x0601AFED RID: 110573 RVA: 0x003D3410 File Offset: 0x003D1610
		public EAngularConstraintMotion Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAngularConstraintMotion.ACM_Free;
				}
				return (EAngularConstraintMotion)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007FC4 RID: 32708
		// (get) Token: 0x0601AFEE RID: 110574 RVA: 0x003D344C File Offset: 0x003D164C
		public int LimitValue
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

		// Token: 0x0601AFEF RID: 110575 RVA: 0x003D3488 File Offset: 0x003D1688
		public static Offset<IAcmLimited> CreateIAcmLimited(FlatBufferBuilder builder, EAngularConstraintMotion Type = EAngularConstraintMotion.ACM_Free, int LimitValue = 0)
		{
			builder.StartTable(2);
			IAcmLimited.AddLimitValue(builder, LimitValue);
			IAcmLimited.AddType(builder, Type);
			return IAcmLimited.EndIAcmLimited(builder);
		}

		// Token: 0x0601AFF0 RID: 110576 RVA: 0x003D34A5 File Offset: 0x003D16A5
		public static void StartIAcmLimited(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601AFF1 RID: 110577 RVA: 0x003D34AE File Offset: 0x003D16AE
		public static void AddType(FlatBufferBuilder builder, EAngularConstraintMotion type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601AFF2 RID: 110578 RVA: 0x003D34B9 File Offset: 0x003D16B9
		public static void AddLimitValue(FlatBufferBuilder builder, int limitValue)
		{
			builder.AddInt(1, limitValue, 0);
		}

		// Token: 0x0601AFF3 RID: 110579 RVA: 0x003D34C4 File Offset: 0x003D16C4
		public static Offset<IAcmLimited> EndIAcmLimited(FlatBufferBuilder builder)
		{
			return new Offset<IAcmLimited>(builder.EndTable());
		}

		// Token: 0x0601AFF4 RID: 110580 RVA: 0x003D34D4 File Offset: 0x003D16D4
		public IAcmLimitedT UnPack()
		{
			IAcmLimitedT acmLimitedT = new IAcmLimitedT();
			this.UnPackTo(acmLimitedT);
			return acmLimitedT;
		}

		// Token: 0x0601AFF5 RID: 110581 RVA: 0x003D34EF File Offset: 0x003D16EF
		public void UnPackTo(IAcmLimitedT _o)
		{
			_o.Type = this.Type;
			_o.LimitValue = this.LimitValue;
		}

		// Token: 0x0601AFF6 RID: 110582 RVA: 0x003D350C File Offset: 0x003D170C
		public static Offset<IAcmLimited> Pack(FlatBufferBuilder builder, IAcmLimitedT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAcmLimited>);
			}
			return IAcmLimited.CreateIAcmLimited(builder, _o.Type, _o.LimitValue);
		}

		// Token: 0x0400CB37 RID: 52023
		private Table __p;
	}
}
