using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007621 RID: 30241
	public struct IResetPlayerPosWithPresentation : IFlatbufferObject
	{
		// Token: 0x1700DE2B RID: 56875
		// (get) Token: 0x060350F9 RID: 217337 RVA: 0x007207FC File Offset: 0x0071E9FC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060350FA RID: 217338 RVA: 0x00720809 File Offset: 0x0071EA09
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060350FB RID: 217339 RVA: 0x00720810 File Offset: 0x0071EA10
		public static IResetPlayerPosWithPresentation GetRootAsIResetPlayerPosWithPresentation(ByteBuffer _bb)
		{
			return IResetPlayerPosWithPresentation.GetRootAsIResetPlayerPosWithPresentation(_bb, default(IResetPlayerPosWithPresentation));
		}

		// Token: 0x060350FC RID: 217340 RVA: 0x0072082C File Offset: 0x0071EA2C
		public static IResetPlayerPosWithPresentation GetRootAsIResetPlayerPosWithPresentation(ByteBuffer _bb, IResetPlayerPosWithPresentation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060350FD RID: 217341 RVA: 0x00720849 File Offset: 0x0071EA49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060350FE RID: 217342 RVA: 0x00720858 File Offset: 0x0071EA58
		public IResetPlayerPosWithPresentation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DE2C RID: 56876
		// (get) Token: 0x060350FF RID: 217343 RVA: 0x00720868 File Offset: 0x0071EA68
		public IResetPresentationFailure? Presentation
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IResetPresentationFailure?(default(IResetPresentationFailure).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700DE2D RID: 56877
		// (get) Token: 0x06035100 RID: 217344 RVA: 0x007208C8 File Offset: 0x0071EAC8
		public TResetPosType ResetPosConfigType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TResetPosType.NONE;
				}
				return (TResetPosType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035101 RID: 217345 RVA: 0x00720904 File Offset: 0x0071EB04
		public TTable? ResetPosConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06035102 RID: 217346 RVA: 0x00720948 File Offset: 0x0071EB48
		public IResetPosByPosEntity ResetPosConfigAsIResetPosByPosEntity()
		{
			return this.ResetPosConfig<IResetPosByPosEntity>().Value;
		}

		// Token: 0x06035103 RID: 217347 RVA: 0x00720964 File Offset: 0x0071EB64
		public IResetPosByResetPoint ResetPosConfigAsIResetPosByResetPoint()
		{
			return this.ResetPosConfig<IResetPosByResetPoint>().Value;
		}

		// Token: 0x1700DE2E RID: 56878
		// (get) Token: 0x06035104 RID: 217348 RVA: 0x00720980 File Offset: 0x0071EB80
		public bool NeedWaitResetPos
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DE2F RID: 56879
		// (get) Token: 0x06035105 RID: 217349 RVA: 0x007209C0 File Offset: 0x0071EBC0
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

		// Token: 0x06035106 RID: 217350 RVA: 0x007209FD File Offset: 0x0071EBFD
		public static Offset<IResetPlayerPosWithPresentation> CreateIResetPlayerPosWithPresentation(FlatBufferBuilder builder, Offset<IResetPresentationFailure> PresentationOffset = default(Offset<IResetPresentationFailure>), TResetPosType ResetPosConfig_type = TResetPosType.NONE, int ResetPosConfigOffset = 0, bool NeedWaitResetPos = false, byte NullMask = 0)
		{
			builder.StartTable(5);
			IResetPlayerPosWithPresentation.AddResetPosConfig(builder, ResetPosConfigOffset);
			IResetPlayerPosWithPresentation.AddPresentation(builder, PresentationOffset);
			IResetPlayerPosWithPresentation.AddNullMask(builder, NullMask);
			IResetPlayerPosWithPresentation.AddNeedWaitResetPos(builder, NeedWaitResetPos);
			IResetPlayerPosWithPresentation.AddResetPosConfigType(builder, ResetPosConfig_type);
			return IResetPlayerPosWithPresentation.EndIResetPlayerPosWithPresentation(builder);
		}

		// Token: 0x06035107 RID: 217351 RVA: 0x00720A31 File Offset: 0x0071EC31
		public static void StartIResetPlayerPosWithPresentation(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06035108 RID: 217352 RVA: 0x00720A3A File Offset: 0x0071EC3A
		public static void AddPresentation(FlatBufferBuilder builder, Offset<IResetPresentationFailure> presentationOffset)
		{
			builder.AddOffset(0, presentationOffset.Value, 0);
		}

		// Token: 0x06035109 RID: 217353 RVA: 0x00720A4A File Offset: 0x0071EC4A
		public static void AddResetPosConfigType(FlatBufferBuilder builder, TResetPosType resetPosConfigType)
		{
			builder.AddByte(1, (byte)resetPosConfigType, 0);
		}

		// Token: 0x0603510A RID: 217354 RVA: 0x00720A55 File Offset: 0x0071EC55
		public static void AddResetPosConfig(FlatBufferBuilder builder, int resetPosConfigOffset)
		{
			builder.AddOffset(2, resetPosConfigOffset, 0);
		}

		// Token: 0x0603510B RID: 217355 RVA: 0x00720A60 File Offset: 0x0071EC60
		public static void AddNeedWaitResetPos(FlatBufferBuilder builder, bool needWaitResetPos)
		{
			builder.AddBool(3, needWaitResetPos, false);
		}

		// Token: 0x0603510C RID: 217356 RVA: 0x00720A6B File Offset: 0x0071EC6B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0603510D RID: 217357 RVA: 0x00720A76 File Offset: 0x0071EC76
		public static Offset<IResetPlayerPosWithPresentation> EndIResetPlayerPosWithPresentation(FlatBufferBuilder builder)
		{
			return new Offset<IResetPlayerPosWithPresentation>(builder.EndTable());
		}

		// Token: 0x0603510E RID: 217358 RVA: 0x00720A84 File Offset: 0x0071EC84
		public IResetPlayerPosWithPresentationT UnPack()
		{
			IResetPlayerPosWithPresentationT resetPlayerPosWithPresentationT = new IResetPlayerPosWithPresentationT();
			this.UnPackTo(resetPlayerPosWithPresentationT);
			return resetPlayerPosWithPresentationT;
		}

		// Token: 0x0603510F RID: 217359 RVA: 0x00720AA0 File Offset: 0x0071ECA0
		public void UnPackTo(IResetPlayerPosWithPresentationT _o)
		{
			_o.Presentation = ((this.Presentation != null) ? this.Presentation.Value.UnPack() : null);
			_o.ResetPosConfig = new TResetPosTypeUnion();
			_o.ResetPosConfig.Type = this.ResetPosConfigType;
			TResetPosType resetPosConfigType = this.ResetPosConfigType;
			if (resetPosConfigType != TResetPosType.IResetPosByPosEntity)
			{
				if (resetPosConfigType == TResetPosType.IResetPosByResetPoint)
				{
					_o.ResetPosConfig.Value = ((this.ResetPosConfig<IResetPosByResetPoint>() != null) ? this.ResetPosConfig<IResetPosByResetPoint>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.ResetPosConfig.Value = ((this.ResetPosConfig<IResetPosByPosEntity>() != null) ? this.ResetPosConfig<IResetPosByPosEntity>().Value.UnPack() : null);
			}
			_o.NeedWaitResetPos = this.NeedWaitResetPos;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06035110 RID: 217360 RVA: 0x00720B90 File Offset: 0x0071ED90
		public static Offset<IResetPlayerPosWithPresentation> Pack(FlatBufferBuilder builder, IResetPlayerPosWithPresentationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IResetPlayerPosWithPresentation>);
			}
			Offset<IResetPresentationFailure> presentationOffset = (_o.Presentation == null) ? default(Offset<IResetPresentationFailure>) : IResetPresentationFailure.Pack(builder, _o.Presentation);
			TResetPosType resetPosConfig_type = (_o.ResetPosConfig == null) ? TResetPosType.NONE : _o.ResetPosConfig.Type;
			int resetPosConfigOffset = (_o.ResetPosConfig == null) ? 0 : TResetPosTypeUnion.Pack(builder, _o.ResetPosConfig);
			return IResetPlayerPosWithPresentation.CreateIResetPlayerPosWithPresentation(builder, presentationOffset, resetPosConfig_type, resetPosConfigOffset, _o.NeedWaitResetPos, _o.NullMask);
		}

		// Token: 0x04012813 RID: 75795
		private Table __p;
	}
}
