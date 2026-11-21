using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Physics
{
	// Token: 0x020047A4 RID: 18340
	public struct IAcmLocked : IFlatbufferObject
	{
		// Token: 0x17007FC7 RID: 32711
		// (get) Token: 0x0601AFFD RID: 110589 RVA: 0x003D35A2 File Offset: 0x003D17A2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AFFE RID: 110590 RVA: 0x003D35AF File Offset: 0x003D17AF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AFFF RID: 110591 RVA: 0x003D35B8 File Offset: 0x003D17B8
		public static IAcmLocked GetRootAsIAcmLocked(ByteBuffer _bb)
		{
			return IAcmLocked.GetRootAsIAcmLocked(_bb, default(IAcmLocked));
		}

		// Token: 0x0601B000 RID: 110592 RVA: 0x003D35D4 File Offset: 0x003D17D4
		public static IAcmLocked GetRootAsIAcmLocked(ByteBuffer _bb, IAcmLocked obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B001 RID: 110593 RVA: 0x003D35F1 File Offset: 0x003D17F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B002 RID: 110594 RVA: 0x003D3600 File Offset: 0x003D1800
		public IAcmLocked __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007FC8 RID: 32712
		// (get) Token: 0x0601B003 RID: 110595 RVA: 0x003D3610 File Offset: 0x003D1810
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

		// Token: 0x0601B004 RID: 110596 RVA: 0x003D364C File Offset: 0x003D184C
		public static Offset<IAcmLocked> CreateIAcmLocked(FlatBufferBuilder builder, EAngularConstraintMotion Type = EAngularConstraintMotion.ACM_Free)
		{
			builder.StartTable(1);
			IAcmLocked.AddType(builder, Type);
			return IAcmLocked.EndIAcmLocked(builder);
		}

		// Token: 0x0601B005 RID: 110597 RVA: 0x003D3662 File Offset: 0x003D1862
		public static void StartIAcmLocked(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601B006 RID: 110598 RVA: 0x003D366B File Offset: 0x003D186B
		public static void AddType(FlatBufferBuilder builder, EAngularConstraintMotion type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B007 RID: 110599 RVA: 0x003D3676 File Offset: 0x003D1876
		public static Offset<IAcmLocked> EndIAcmLocked(FlatBufferBuilder builder)
		{
			return new Offset<IAcmLocked>(builder.EndTable());
		}

		// Token: 0x0601B008 RID: 110600 RVA: 0x003D3684 File Offset: 0x003D1884
		public IAcmLockedT UnPack()
		{
			IAcmLockedT acmLockedT = new IAcmLockedT();
			this.UnPackTo(acmLockedT);
			return acmLockedT;
		}

		// Token: 0x0601B009 RID: 110601 RVA: 0x003D369F File Offset: 0x003D189F
		public void UnPackTo(IAcmLockedT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601B00A RID: 110602 RVA: 0x003D36B0 File Offset: 0x003D18B0
		public static Offset<IAcmLocked> Pack(FlatBufferBuilder builder, IAcmLockedT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAcmLocked>);
			}
			return IAcmLocked.CreateIAcmLocked(builder, _o.Type);
		}

		// Token: 0x0400CB3A RID: 52026
		private Table __p;
	}
}
