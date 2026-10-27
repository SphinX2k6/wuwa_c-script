using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E9D RID: 28317
	public struct IResetPlayerPosWithPresentation : IFlatbufferObject
	{
		// Token: 0x1700D2D4 RID: 53972
		// (get) Token: 0x060320B9 RID: 204985 RVA: 0x006C4AC8 File Offset: 0x006C2CC8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060320BA RID: 204986 RVA: 0x006C4AD5 File Offset: 0x006C2CD5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060320BB RID: 204987 RVA: 0x006C4ADC File Offset: 0x006C2CDC
		public static IResetPlayerPosWithPresentation GetRootAsIResetPlayerPosWithPresentation(ByteBuffer _bb)
		{
			return IResetPlayerPosWithPresentation.GetRootAsIResetPlayerPosWithPresentation(_bb, default(IResetPlayerPosWithPresentation));
		}

		// Token: 0x060320BC RID: 204988 RVA: 0x006C4AF8 File Offset: 0x006C2CF8
		public static IResetPlayerPosWithPresentation GetRootAsIResetPlayerPosWithPresentation(ByteBuffer _bb, IResetPlayerPosWithPresentation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060320BD RID: 204989 RVA: 0x006C4B15 File Offset: 0x006C2D15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060320BE RID: 204990 RVA: 0x006C4B24 File Offset: 0x006C2D24
		public IResetPlayerPosWithPresentation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D2D5 RID: 53973
		// (get) Token: 0x060320BF RID: 204991 RVA: 0x006C4B34 File Offset: 0x006C2D34
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

		// Token: 0x1700D2D6 RID: 53974
		// (get) Token: 0x060320C0 RID: 204992 RVA: 0x006C4B94 File Offset: 0x006C2D94
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

		// Token: 0x060320C1 RID: 204993 RVA: 0x006C4BD0 File Offset: 0x006C2DD0
		public TTable? ResetPosConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060320C2 RID: 204994 RVA: 0x006C4C14 File Offset: 0x006C2E14
		public IResetPosByPosEntity ResetPosConfigAsIResetPosByPosEntity()
		{
			return this.ResetPosConfig<IResetPosByPosEntity>().Value;
		}

		// Token: 0x060320C3 RID: 204995 RVA: 0x006C4C30 File Offset: 0x006C2E30
		public IResetPosByResetPoint ResetPosConfigAsIResetPosByResetPoint()
		{
			return this.ResetPosConfig<IResetPosByResetPoint>().Value;
		}

		// Token: 0x1700D2D7 RID: 53975
		// (get) Token: 0x060320C4 RID: 204996 RVA: 0x006C4C4C File Offset: 0x006C2E4C
		public bool NeedWaitResetPos
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D2D8 RID: 53976
		// (get) Token: 0x060320C5 RID: 204997 RVA: 0x006C4C8C File Offset: 0x006C2E8C
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

		// Token: 0x060320C6 RID: 204998 RVA: 0x006C4CC9 File Offset: 0x006C2EC9
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

		// Token: 0x060320C7 RID: 204999 RVA: 0x006C4CFD File Offset: 0x006C2EFD
		public static void StartIResetPlayerPosWithPresentation(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060320C8 RID: 205000 RVA: 0x006C4D06 File Offset: 0x006C2F06
		public static void AddPresentation(FlatBufferBuilder builder, Offset<IResetPresentationFailure> presentationOffset)
		{
			builder.AddOffset(0, presentationOffset.Value, 0);
		}

		// Token: 0x060320C9 RID: 205001 RVA: 0x006C4D16 File Offset: 0x006C2F16
		public static void AddResetPosConfigType(FlatBufferBuilder builder, TResetPosType resetPosConfigType)
		{
			builder.AddByte(1, (byte)resetPosConfigType, 0);
		}

		// Token: 0x060320CA RID: 205002 RVA: 0x006C4D21 File Offset: 0x006C2F21
		public static void AddResetPosConfig(FlatBufferBuilder builder, int resetPosConfigOffset)
		{
			builder.AddOffset(2, resetPosConfigOffset, 0);
		}

		// Token: 0x060320CB RID: 205003 RVA: 0x006C4D2C File Offset: 0x006C2F2C
		public static void AddNeedWaitResetPos(FlatBufferBuilder builder, bool needWaitResetPos)
		{
			builder.AddBool(3, needWaitResetPos, false);
		}

		// Token: 0x060320CC RID: 205004 RVA: 0x006C4D37 File Offset: 0x006C2F37
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060320CD RID: 205005 RVA: 0x006C4D42 File Offset: 0x006C2F42
		public static Offset<IResetPlayerPosWithPresentation> EndIResetPlayerPosWithPresentation(FlatBufferBuilder builder)
		{
			return new Offset<IResetPlayerPosWithPresentation>(builder.EndTable());
		}

		// Token: 0x060320CE RID: 205006 RVA: 0x006C4D50 File Offset: 0x006C2F50
		public IResetPlayerPosWithPresentationT UnPack()
		{
			IResetPlayerPosWithPresentationT resetPlayerPosWithPresentationT = new IResetPlayerPosWithPresentationT();
			this.UnPackTo(resetPlayerPosWithPresentationT);
			return resetPlayerPosWithPresentationT;
		}

		// Token: 0x060320CF RID: 205007 RVA: 0x006C4D6C File Offset: 0x006C2F6C
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

		// Token: 0x060320D0 RID: 205008 RVA: 0x006C4E5C File Offset: 0x006C305C
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

		// Token: 0x0401188E RID: 71822
		private Table __p;
	}
}
