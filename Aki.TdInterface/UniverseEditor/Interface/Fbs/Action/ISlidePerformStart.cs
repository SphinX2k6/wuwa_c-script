using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200790E RID: 30990
	public struct ISlidePerformStart : IFlatbufferObject
	{
		// Token: 0x1700E353 RID: 58195
		// (get) Token: 0x06036908 RID: 223496 RVA: 0x0074D97E File Offset: 0x0074BB7E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036909 RID: 223497 RVA: 0x0074D98B File Offset: 0x0074BB8B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603690A RID: 223498 RVA: 0x0074D994 File Offset: 0x0074BB94
		public static ISlidePerformStart GetRootAsISlidePerformStart(ByteBuffer _bb)
		{
			return ISlidePerformStart.GetRootAsISlidePerformStart(_bb, default(ISlidePerformStart));
		}

		// Token: 0x0603690B RID: 223499 RVA: 0x0074D9B0 File Offset: 0x0074BBB0
		public static ISlidePerformStart GetRootAsISlidePerformStart(ByteBuffer _bb, ISlidePerformStart obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603690C RID: 223500 RVA: 0x0074D9CD File Offset: 0x0074BBCD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603690D RID: 223501 RVA: 0x0074D9DC File Offset: 0x0074BBDC
		public ISlidePerformStart __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E354 RID: 58196
		// (get) Token: 0x0603690E RID: 223502 RVA: 0x0074D9EC File Offset: 0x0074BBEC
		public TCommonTarget SlideTargetType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TCommonTarget.NONE;
				}
				return (TCommonTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603690F RID: 223503 RVA: 0x0074DA28 File Offset: 0x0074BC28
		public TTable? SlideTarget<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06036910 RID: 223504 RVA: 0x0074DA6C File Offset: 0x0074BC6C
		public IAssistCharacterTarget SlideTargetAsIAssistCharacterTarget()
		{
			return this.SlideTarget<IAssistCharacterTarget>().Value;
		}

		// Token: 0x06036911 RID: 223505 RVA: 0x0074DA88 File Offset: 0x0074BC88
		public IPlayerTarget SlideTargetAsIPlayerTarget()
		{
			return this.SlideTarget<IPlayerTarget>().Value;
		}

		// Token: 0x1700E355 RID: 58197
		// (get) Token: 0x06036912 RID: 223506 RVA: 0x0074DAA4 File Offset: 0x0074BCA4
		public int SlideEntityId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E356 RID: 58198
		// (get) Token: 0x06036913 RID: 223507 RVA: 0x0074DAE0 File Offset: 0x0074BCE0
		public ISlopeSlidePerformStart? SlidePerformConfig
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new ISlopeSlidePerformStart?(default(ISlopeSlidePerformStart).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06036914 RID: 223508 RVA: 0x0074DB3E File Offset: 0x0074BD3E
		public static Offset<ISlidePerformStart> CreateISlidePerformStart(FlatBufferBuilder builder, TCommonTarget SlideTarget_type = TCommonTarget.NONE, int SlideTargetOffset = 0, int SlideEntityId = 0, Offset<ISlopeSlidePerformStart> SlidePerformConfigOffset = default(Offset<ISlopeSlidePerformStart>))
		{
			builder.StartTable(4);
			ISlidePerformStart.AddSlidePerformConfig(builder, SlidePerformConfigOffset);
			ISlidePerformStart.AddSlideEntityId(builder, SlideEntityId);
			ISlidePerformStart.AddSlideTarget(builder, SlideTargetOffset);
			ISlidePerformStart.AddSlideTargetType(builder, SlideTarget_type);
			return ISlidePerformStart.EndISlidePerformStart(builder);
		}

		// Token: 0x06036915 RID: 223509 RVA: 0x0074DB6A File Offset: 0x0074BD6A
		public static void StartISlidePerformStart(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06036916 RID: 223510 RVA: 0x0074DB73 File Offset: 0x0074BD73
		public static void AddSlideTargetType(FlatBufferBuilder builder, TCommonTarget slideTargetType)
		{
			builder.AddByte(0, (byte)slideTargetType, 0);
		}

		// Token: 0x06036917 RID: 223511 RVA: 0x0074DB7E File Offset: 0x0074BD7E
		public static void AddSlideTarget(FlatBufferBuilder builder, int slideTargetOffset)
		{
			builder.AddOffset(1, slideTargetOffset, 0);
		}

		// Token: 0x06036918 RID: 223512 RVA: 0x0074DB89 File Offset: 0x0074BD89
		public static void AddSlideEntityId(FlatBufferBuilder builder, int slideEntityId)
		{
			builder.AddInt(2, slideEntityId, 0);
		}

		// Token: 0x06036919 RID: 223513 RVA: 0x0074DB94 File Offset: 0x0074BD94
		public static void AddSlidePerformConfig(FlatBufferBuilder builder, Offset<ISlopeSlidePerformStart> slidePerformConfigOffset)
		{
			builder.AddOffset(3, slidePerformConfigOffset.Value, 0);
		}

		// Token: 0x0603691A RID: 223514 RVA: 0x0074DBA4 File Offset: 0x0074BDA4
		public static Offset<ISlidePerformStart> EndISlidePerformStart(FlatBufferBuilder builder)
		{
			return new Offset<ISlidePerformStart>(builder.EndTable());
		}

		// Token: 0x0603691B RID: 223515 RVA: 0x0074DBB4 File Offset: 0x0074BDB4
		public ISlidePerformStartT UnPack()
		{
			ISlidePerformStartT slidePerformStartT = new ISlidePerformStartT();
			this.UnPackTo(slidePerformStartT);
			return slidePerformStartT;
		}

		// Token: 0x0603691C RID: 223516 RVA: 0x0074DBD0 File Offset: 0x0074BDD0
		public void UnPackTo(ISlidePerformStartT _o)
		{
			_o.SlideTarget = new TCommonTargetUnion();
			_o.SlideTarget.Type = this.SlideTargetType;
			TCommonTarget slideTargetType = this.SlideTargetType;
			if (slideTargetType != TCommonTarget.IAssistCharacterTarget)
			{
				if (slideTargetType == TCommonTarget.IPlayerTarget)
				{
					_o.SlideTarget.Value = ((this.SlideTarget<IPlayerTarget>() != null) ? this.SlideTarget<IPlayerTarget>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.SlideTarget.Value = ((this.SlideTarget<IAssistCharacterTarget>() != null) ? this.SlideTarget<IAssistCharacterTarget>().Value.UnPack() : null);
			}
			_o.SlideEntityId = this.SlideEntityId;
			_o.SlidePerformConfig = ((this.SlidePerformConfig != null) ? this.SlidePerformConfig.Value.UnPack() : null);
		}

		// Token: 0x0603691D RID: 223517 RVA: 0x0074DCB4 File Offset: 0x0074BEB4
		public static Offset<ISlidePerformStart> Pack(FlatBufferBuilder builder, ISlidePerformStartT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISlidePerformStart>);
			}
			TCommonTarget slideTarget_type = (_o.SlideTarget == null) ? TCommonTarget.NONE : _o.SlideTarget.Type;
			int slideTargetOffset = (_o.SlideTarget == null) ? 0 : TCommonTargetUnion.Pack(builder, _o.SlideTarget);
			Offset<ISlopeSlidePerformStart> slidePerformConfigOffset = (_o.SlidePerformConfig == null) ? default(Offset<ISlopeSlidePerformStart>) : ISlopeSlidePerformStart.Pack(builder, _o.SlidePerformConfig);
			return ISlidePerformStart.CreateISlidePerformStart(builder, slideTarget_type, slideTargetOffset, _o.SlideEntityId, slidePerformConfigOffset);
		}

		// Token: 0x04012BCB RID: 76747
		private Table __p;
	}
}
