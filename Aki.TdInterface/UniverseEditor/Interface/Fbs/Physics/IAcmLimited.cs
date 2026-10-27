using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Physics
{
	// Token: 0x0200433F RID: 17215
	public struct IAcmLimited : IFlatbufferObject
	{
		// Token: 0x1700798D RID: 31117
		// (get) Token: 0x06019859 RID: 104537 RVA: 0x003A7979 File Offset: 0x003A5B79
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601985A RID: 104538 RVA: 0x003A7986 File Offset: 0x003A5B86
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601985B RID: 104539 RVA: 0x003A7990 File Offset: 0x003A5B90
		public static IAcmLimited GetRootAsIAcmLimited(ByteBuffer _bb)
		{
			return IAcmLimited.GetRootAsIAcmLimited(_bb, default(IAcmLimited));
		}

		// Token: 0x0601985C RID: 104540 RVA: 0x003A79AC File Offset: 0x003A5BAC
		public static IAcmLimited GetRootAsIAcmLimited(ByteBuffer _bb, IAcmLimited obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601985D RID: 104541 RVA: 0x003A79C9 File Offset: 0x003A5BC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601985E RID: 104542 RVA: 0x003A79D8 File Offset: 0x003A5BD8
		public IAcmLimited __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700798E RID: 31118
		// (get) Token: 0x0601985F RID: 104543 RVA: 0x003A79E8 File Offset: 0x003A5BE8
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

		// Token: 0x1700798F RID: 31119
		// (get) Token: 0x06019860 RID: 104544 RVA: 0x003A7A24 File Offset: 0x003A5C24
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

		// Token: 0x06019861 RID: 104545 RVA: 0x003A7A60 File Offset: 0x003A5C60
		public static Offset<IAcmLimited> CreateIAcmLimited(FlatBufferBuilder builder, EAngularConstraintMotion Type = EAngularConstraintMotion.ACM_Free, int LimitValue = 0)
		{
			builder.StartTable(2);
			IAcmLimited.AddLimitValue(builder, LimitValue);
			IAcmLimited.AddType(builder, Type);
			return IAcmLimited.EndIAcmLimited(builder);
		}

		// Token: 0x06019862 RID: 104546 RVA: 0x003A7A7D File Offset: 0x003A5C7D
		public static void StartIAcmLimited(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06019863 RID: 104547 RVA: 0x003A7A86 File Offset: 0x003A5C86
		public static void AddType(FlatBufferBuilder builder, EAngularConstraintMotion type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019864 RID: 104548 RVA: 0x003A7A91 File Offset: 0x003A5C91
		public static void AddLimitValue(FlatBufferBuilder builder, int limitValue)
		{
			builder.AddInt(1, limitValue, 0);
		}

		// Token: 0x06019865 RID: 104549 RVA: 0x003A7A9C File Offset: 0x003A5C9C
		public static Offset<IAcmLimited> EndIAcmLimited(FlatBufferBuilder builder)
		{
			return new Offset<IAcmLimited>(builder.EndTable());
		}

		// Token: 0x06019866 RID: 104550 RVA: 0x003A7AAC File Offset: 0x003A5CAC
		public IAcmLimitedT UnPack()
		{
			IAcmLimitedT acmLimitedT = new IAcmLimitedT();
			this.UnPackTo(acmLimitedT);
			return acmLimitedT;
		}

		// Token: 0x06019867 RID: 104551 RVA: 0x003A7AC7 File Offset: 0x003A5CC7
		public void UnPackTo(IAcmLimitedT _o)
		{
			_o.Type = this.Type;
			_o.LimitValue = this.LimitValue;
		}

		// Token: 0x06019868 RID: 104552 RVA: 0x003A7AE4 File Offset: 0x003A5CE4
		public static Offset<IAcmLimited> Pack(FlatBufferBuilder builder, IAcmLimitedT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAcmLimited>);
			}
			return IAcmLimited.CreateIAcmLimited(builder, _o.Type, _o.LimitValue);
		}

		// Token: 0x0400C119 RID: 49433
		private Table __p;
	}
}
