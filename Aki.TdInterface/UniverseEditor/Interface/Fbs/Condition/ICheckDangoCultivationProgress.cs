using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049B8 RID: 18872
	public struct ICheckDangoCultivationProgress : IFlatbufferObject
	{
		// Token: 0x17008878 RID: 34936
		// (get) Token: 0x0601D768 RID: 120680 RVA: 0x00426956 File Offset: 0x00424B56
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D769 RID: 120681 RVA: 0x00426963 File Offset: 0x00424B63
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D76A RID: 120682 RVA: 0x0042696C File Offset: 0x00424B6C
		public static ICheckDangoCultivationProgress GetRootAsICheckDangoCultivationProgress(ByteBuffer _bb)
		{
			return ICheckDangoCultivationProgress.GetRootAsICheckDangoCultivationProgress(_bb, default(ICheckDangoCultivationProgress));
		}

		// Token: 0x0601D76B RID: 120683 RVA: 0x00426988 File Offset: 0x00424B88
		public static ICheckDangoCultivationProgress GetRootAsICheckDangoCultivationProgress(ByteBuffer _bb, ICheckDangoCultivationProgress obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D76C RID: 120684 RVA: 0x004269A5 File Offset: 0x00424BA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D76D RID: 120685 RVA: 0x004269B4 File Offset: 0x00424BB4
		public ICheckDangoCultivationProgress __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008879 RID: 34937
		// (get) Token: 0x0601D76E RID: 120686 RVA: 0x004269C4 File Offset: 0x00424BC4
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700887A RID: 34938
		// (get) Token: 0x0601D76F RID: 120687 RVA: 0x00426A00 File Offset: 0x00424C00
		public ICountDangoOverTargetLevel? CheckType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ICountDangoOverTargetLevel?(default(ICountDangoOverTargetLevel).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601D770 RID: 120688 RVA: 0x00426A5D File Offset: 0x00424C5D
		public static Offset<ICheckDangoCultivationProgress> CreateICheckDangoCultivationProgress(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, Offset<ICountDangoOverTargetLevel> CheckTypeOffset = default(Offset<ICountDangoOverTargetLevel>))
		{
			builder.StartTable(2);
			ICheckDangoCultivationProgress.AddCheckType(builder, CheckTypeOffset);
			ICheckDangoCultivationProgress.AddType(builder, Type);
			return ICheckDangoCultivationProgress.EndICheckDangoCultivationProgress(builder);
		}

		// Token: 0x0601D771 RID: 120689 RVA: 0x00426A7A File Offset: 0x00424C7A
		public static void StartICheckDangoCultivationProgress(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601D772 RID: 120690 RVA: 0x00426A83 File Offset: 0x00424C83
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D773 RID: 120691 RVA: 0x00426A8E File Offset: 0x00424C8E
		public static void AddCheckType(FlatBufferBuilder builder, Offset<ICountDangoOverTargetLevel> checkTypeOffset)
		{
			builder.AddOffset(1, checkTypeOffset.Value, 0);
		}

		// Token: 0x0601D774 RID: 120692 RVA: 0x00426A9E File Offset: 0x00424C9E
		public static Offset<ICheckDangoCultivationProgress> EndICheckDangoCultivationProgress(FlatBufferBuilder builder)
		{
			return new Offset<ICheckDangoCultivationProgress>(builder.EndTable());
		}

		// Token: 0x0601D775 RID: 120693 RVA: 0x00426AAC File Offset: 0x00424CAC
		public ICheckDangoCultivationProgressT UnPack()
		{
			ICheckDangoCultivationProgressT checkDangoCultivationProgressT = new ICheckDangoCultivationProgressT();
			this.UnPackTo(checkDangoCultivationProgressT);
			return checkDangoCultivationProgressT;
		}

		// Token: 0x0601D776 RID: 120694 RVA: 0x00426AC8 File Offset: 0x00424CC8
		public void UnPackTo(ICheckDangoCultivationProgressT _o)
		{
			_o.Type = this.Type;
			_o.CheckType = ((this.CheckType != null) ? this.CheckType.Value.UnPack() : null);
		}

		// Token: 0x0601D777 RID: 120695 RVA: 0x00426B10 File Offset: 0x00424D10
		public static Offset<ICheckDangoCultivationProgress> Pack(FlatBufferBuilder builder, ICheckDangoCultivationProgressT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckDangoCultivationProgress>);
			}
			Offset<ICountDangoOverTargetLevel> checkTypeOffset = (_o.CheckType == null) ? default(Offset<ICountDangoOverTargetLevel>) : ICountDangoOverTargetLevel.Pack(builder, _o.CheckType);
			return ICheckDangoCultivationProgress.CreateICheckDangoCultivationProgress(builder, _o.Type, checkTypeOffset);
		}

		// Token: 0x0400D1DE RID: 53726
		private Table __p;
	}
}
