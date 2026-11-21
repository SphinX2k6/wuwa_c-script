using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Physics
{
	// Token: 0x0200479E RID: 18334
	public struct IAcmFree : IFlatbufferObject
	{
		// Token: 0x17007FBF RID: 32703
		// (get) Token: 0x0601AFD5 RID: 110549 RVA: 0x003D322A File Offset: 0x003D142A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AFD6 RID: 110550 RVA: 0x003D3237 File Offset: 0x003D1437
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AFD7 RID: 110551 RVA: 0x003D3240 File Offset: 0x003D1440
		public static IAcmFree GetRootAsIAcmFree(ByteBuffer _bb)
		{
			return IAcmFree.GetRootAsIAcmFree(_bb, default(IAcmFree));
		}

		// Token: 0x0601AFD8 RID: 110552 RVA: 0x003D325C File Offset: 0x003D145C
		public static IAcmFree GetRootAsIAcmFree(ByteBuffer _bb, IAcmFree obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AFD9 RID: 110553 RVA: 0x003D3279 File Offset: 0x003D1479
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AFDA RID: 110554 RVA: 0x003D3288 File Offset: 0x003D1488
		public IAcmFree __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007FC0 RID: 32704
		// (get) Token: 0x0601AFDB RID: 110555 RVA: 0x003D3298 File Offset: 0x003D1498
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

		// Token: 0x0601AFDC RID: 110556 RVA: 0x003D32D4 File Offset: 0x003D14D4
		public static Offset<IAcmFree> CreateIAcmFree(FlatBufferBuilder builder, EAngularConstraintMotion Type = EAngularConstraintMotion.ACM_Free)
		{
			builder.StartTable(1);
			IAcmFree.AddType(builder, Type);
			return IAcmFree.EndIAcmFree(builder);
		}

		// Token: 0x0601AFDD RID: 110557 RVA: 0x003D32EA File Offset: 0x003D14EA
		public static void StartIAcmFree(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601AFDE RID: 110558 RVA: 0x003D32F3 File Offset: 0x003D14F3
		public static void AddType(FlatBufferBuilder builder, EAngularConstraintMotion type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601AFDF RID: 110559 RVA: 0x003D32FE File Offset: 0x003D14FE
		public static Offset<IAcmFree> EndIAcmFree(FlatBufferBuilder builder)
		{
			return new Offset<IAcmFree>(builder.EndTable());
		}

		// Token: 0x0601AFE0 RID: 110560 RVA: 0x003D330C File Offset: 0x003D150C
		public IAcmFreeT UnPack()
		{
			IAcmFreeT acmFreeT = new IAcmFreeT();
			this.UnPackTo(acmFreeT);
			return acmFreeT;
		}

		// Token: 0x0601AFE1 RID: 110561 RVA: 0x003D3327 File Offset: 0x003D1527
		public void UnPackTo(IAcmFreeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601AFE2 RID: 110562 RVA: 0x003D3338 File Offset: 0x003D1538
		public static Offset<IAcmFree> Pack(FlatBufferBuilder builder, IAcmFreeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAcmFree>);
			}
			return IAcmFree.CreateIAcmFree(builder, _o.Type);
		}

		// Token: 0x0400CB35 RID: 52021
		private Table __p;
	}
}
