using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E72 RID: 20082
	public struct ICheckDangoCultivationProgress : IFlatbufferObject
	{
		// Token: 0x17008F3A RID: 36666
		// (get) Token: 0x0601F1A7 RID: 127399 RVA: 0x0045709E File Offset: 0x0045529E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F1A8 RID: 127400 RVA: 0x004570AB File Offset: 0x004552AB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F1A9 RID: 127401 RVA: 0x004570B4 File Offset: 0x004552B4
		public static ICheckDangoCultivationProgress GetRootAsICheckDangoCultivationProgress(ByteBuffer _bb)
		{
			return ICheckDangoCultivationProgress.GetRootAsICheckDangoCultivationProgress(_bb, default(ICheckDangoCultivationProgress));
		}

		// Token: 0x0601F1AA RID: 127402 RVA: 0x004570D0 File Offset: 0x004552D0
		public static ICheckDangoCultivationProgress GetRootAsICheckDangoCultivationProgress(ByteBuffer _bb, ICheckDangoCultivationProgress obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F1AB RID: 127403 RVA: 0x004570ED File Offset: 0x004552ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F1AC RID: 127404 RVA: 0x004570FC File Offset: 0x004552FC
		public ICheckDangoCultivationProgress __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008F3B RID: 36667
		// (get) Token: 0x0601F1AD RID: 127405 RVA: 0x0045710C File Offset: 0x0045530C
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

		// Token: 0x17008F3C RID: 36668
		// (get) Token: 0x0601F1AE RID: 127406 RVA: 0x00457148 File Offset: 0x00455348
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

		// Token: 0x0601F1AF RID: 127407 RVA: 0x004571A5 File Offset: 0x004553A5
		public static Offset<ICheckDangoCultivationProgress> CreateICheckDangoCultivationProgress(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, Offset<ICountDangoOverTargetLevel> CheckTypeOffset = default(Offset<ICountDangoOverTargetLevel>))
		{
			builder.StartTable(2);
			ICheckDangoCultivationProgress.AddCheckType(builder, CheckTypeOffset);
			ICheckDangoCultivationProgress.AddType(builder, Type);
			return ICheckDangoCultivationProgress.EndICheckDangoCultivationProgress(builder);
		}

		// Token: 0x0601F1B0 RID: 127408 RVA: 0x004571C2 File Offset: 0x004553C2
		public static void StartICheckDangoCultivationProgress(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601F1B1 RID: 127409 RVA: 0x004571CB File Offset: 0x004553CB
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F1B2 RID: 127410 RVA: 0x004571D6 File Offset: 0x004553D6
		public static void AddCheckType(FlatBufferBuilder builder, Offset<ICountDangoOverTargetLevel> checkTypeOffset)
		{
			builder.AddOffset(1, checkTypeOffset.Value, 0);
		}

		// Token: 0x0601F1B3 RID: 127411 RVA: 0x004571E6 File Offset: 0x004553E6
		public static Offset<ICheckDangoCultivationProgress> EndICheckDangoCultivationProgress(FlatBufferBuilder builder)
		{
			return new Offset<ICheckDangoCultivationProgress>(builder.EndTable());
		}

		// Token: 0x0601F1B4 RID: 127412 RVA: 0x004571F4 File Offset: 0x004553F4
		public ICheckDangoCultivationProgressT UnPack()
		{
			ICheckDangoCultivationProgressT checkDangoCultivationProgressT = new ICheckDangoCultivationProgressT();
			this.UnPackTo(checkDangoCultivationProgressT);
			return checkDangoCultivationProgressT;
		}

		// Token: 0x0601F1B5 RID: 127413 RVA: 0x00457210 File Offset: 0x00455410
		public void UnPackTo(ICheckDangoCultivationProgressT _o)
		{
			_o.Type = this.Type;
			_o.CheckType = ((this.CheckType != null) ? this.CheckType.Value.UnPack() : null);
		}

		// Token: 0x0601F1B6 RID: 127414 RVA: 0x00457258 File Offset: 0x00455458
		public static Offset<ICheckDangoCultivationProgress> Pack(FlatBufferBuilder builder, ICheckDangoCultivationProgressT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckDangoCultivationProgress>);
			}
			Offset<ICountDangoOverTargetLevel> checkTypeOffset = (_o.CheckType == null) ? default(Offset<ICountDangoOverTargetLevel>) : ICountDangoOverTargetLevel.Pack(builder, _o.CheckType);
			return ICheckDangoCultivationProgress.CreateICheckDangoCultivationProgress(builder, _o.Type, checkTypeOffset);
		}

		// Token: 0x0400DCAA RID: 56490
		private Table __p;
	}
}
