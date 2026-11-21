using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E06 RID: 24070
	public struct IRangeConstraint : IFlatbufferObject
	{
		// Token: 0x1700B172 RID: 45426
		// (get) Token: 0x06028313 RID: 164627 RVA: 0x0057F506 File Offset: 0x0057D706
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028314 RID: 164628 RVA: 0x0057F513 File Offset: 0x0057D713
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028315 RID: 164629 RVA: 0x0057F51C File Offset: 0x0057D71C
		public static IRangeConstraint GetRootAsIRangeConstraint(ByteBuffer _bb)
		{
			return IRangeConstraint.GetRootAsIRangeConstraint(_bb, default(IRangeConstraint));
		}

		// Token: 0x06028316 RID: 164630 RVA: 0x0057F538 File Offset: 0x0057D738
		public static IRangeConstraint GetRootAsIRangeConstraint(ByteBuffer _bb, IRangeConstraint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028317 RID: 164631 RVA: 0x0057F555 File Offset: 0x0057D755
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028318 RID: 164632 RVA: 0x0057F564 File Offset: 0x0057D764
		public IRangeConstraint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B173 RID: 45427
		// (get) Token: 0x06028319 RID: 164633 RVA: 0x0057F574 File Offset: 0x0057D774
		public ERangeConstraint Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERangeConstraint.SearchSpawnMonsterPoint;
				}
				return (ERangeConstraint)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602831A RID: 164634 RVA: 0x0057F5B0 File Offset: 0x0057D7B0
		public static Offset<IRangeConstraint> CreateIRangeConstraint(FlatBufferBuilder builder, ERangeConstraint Type = ERangeConstraint.SearchSpawnMonsterPoint)
		{
			builder.StartTable(1);
			IRangeConstraint.AddType(builder, Type);
			return IRangeConstraint.EndIRangeConstraint(builder);
		}

		// Token: 0x0602831B RID: 164635 RVA: 0x0057F5C6 File Offset: 0x0057D7C6
		public static void StartIRangeConstraint(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602831C RID: 164636 RVA: 0x0057F5CF File Offset: 0x0057D7CF
		public static void AddType(FlatBufferBuilder builder, ERangeConstraint type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602831D RID: 164637 RVA: 0x0057F5DA File Offset: 0x0057D7DA
		public static Offset<IRangeConstraint> EndIRangeConstraint(FlatBufferBuilder builder)
		{
			return new Offset<IRangeConstraint>(builder.EndTable());
		}

		// Token: 0x0602831E RID: 164638 RVA: 0x0057F5E8 File Offset: 0x0057D7E8
		public IRangeConstraintT UnPack()
		{
			IRangeConstraintT rangeConstraintT = new IRangeConstraintT();
			this.UnPackTo(rangeConstraintT);
			return rangeConstraintT;
		}

		// Token: 0x0602831F RID: 164639 RVA: 0x0057F603 File Offset: 0x0057D803
		public void UnPackTo(IRangeConstraintT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06028320 RID: 164640 RVA: 0x0057F614 File Offset: 0x0057D814
		public static Offset<IRangeConstraint> Pack(FlatBufferBuilder builder, IRangeConstraintT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRangeConstraint>);
			}
			return IRangeConstraint.CreateIRangeConstraint(builder, _o.Type);
		}

		// Token: 0x0400F9E5 RID: 63973
		private Table __p;
	}
}
