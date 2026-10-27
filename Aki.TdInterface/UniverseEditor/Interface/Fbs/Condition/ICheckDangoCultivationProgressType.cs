using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049BB RID: 18875
	public struct ICheckDangoCultivationProgressType : IFlatbufferObject
	{
		// Token: 0x1700887D RID: 34941
		// (get) Token: 0x0601D77E RID: 120702 RVA: 0x00426BE4 File Offset: 0x00424DE4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D77F RID: 120703 RVA: 0x00426BF1 File Offset: 0x00424DF1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D780 RID: 120704 RVA: 0x00426BF8 File Offset: 0x00424DF8
		public static ICheckDangoCultivationProgressType GetRootAsICheckDangoCultivationProgressType(ByteBuffer _bb)
		{
			return ICheckDangoCultivationProgressType.GetRootAsICheckDangoCultivationProgressType(_bb, default(ICheckDangoCultivationProgressType));
		}

		// Token: 0x0601D781 RID: 120705 RVA: 0x00426C14 File Offset: 0x00424E14
		public static ICheckDangoCultivationProgressType GetRootAsICheckDangoCultivationProgressType(ByteBuffer _bb, ICheckDangoCultivationProgressType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D782 RID: 120706 RVA: 0x00426C31 File Offset: 0x00424E31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D783 RID: 120707 RVA: 0x00426C40 File Offset: 0x00424E40
		public ICheckDangoCultivationProgressType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700887E RID: 34942
		// (get) Token: 0x0601D784 RID: 120708 RVA: 0x00426C50 File Offset: 0x00424E50
		public ECheckDangoCultivationProgressType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckDangoCultivationProgressType.CountDangoOverTargetLevel;
				}
				return (ECheckDangoCultivationProgressType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601D785 RID: 120709 RVA: 0x00426C8C File Offset: 0x00424E8C
		public static Offset<ICheckDangoCultivationProgressType> CreateICheckDangoCultivationProgressType(FlatBufferBuilder builder, ECheckDangoCultivationProgressType Type = ECheckDangoCultivationProgressType.CountDangoOverTargetLevel)
		{
			builder.StartTable(1);
			ICheckDangoCultivationProgressType.AddType(builder, Type);
			return ICheckDangoCultivationProgressType.EndICheckDangoCultivationProgressType(builder);
		}

		// Token: 0x0601D786 RID: 120710 RVA: 0x00426CA2 File Offset: 0x00424EA2
		public static void StartICheckDangoCultivationProgressType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601D787 RID: 120711 RVA: 0x00426CAB File Offset: 0x00424EAB
		public static void AddType(FlatBufferBuilder builder, ECheckDangoCultivationProgressType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D788 RID: 120712 RVA: 0x00426CB6 File Offset: 0x00424EB6
		public static Offset<ICheckDangoCultivationProgressType> EndICheckDangoCultivationProgressType(FlatBufferBuilder builder)
		{
			return new Offset<ICheckDangoCultivationProgressType>(builder.EndTable());
		}

		// Token: 0x0601D789 RID: 120713 RVA: 0x00426CC4 File Offset: 0x00424EC4
		public ICheckDangoCultivationProgressTypeT UnPack()
		{
			ICheckDangoCultivationProgressTypeT checkDangoCultivationProgressTypeT = new ICheckDangoCultivationProgressTypeT();
			this.UnPackTo(checkDangoCultivationProgressTypeT);
			return checkDangoCultivationProgressTypeT;
		}

		// Token: 0x0601D78A RID: 120714 RVA: 0x00426CDF File Offset: 0x00424EDF
		public void UnPackTo(ICheckDangoCultivationProgressTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601D78B RID: 120715 RVA: 0x00426CF0 File Offset: 0x00424EF0
		public static Offset<ICheckDangoCultivationProgressType> Pack(FlatBufferBuilder builder, ICheckDangoCultivationProgressTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckDangoCultivationProgressType>);
			}
			return ICheckDangoCultivationProgressType.CreateICheckDangoCultivationProgressType(builder, _o.Type);
		}

		// Token: 0x0400D1E1 RID: 53729
		private Table __p;
	}
}
