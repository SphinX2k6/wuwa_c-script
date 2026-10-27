using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072DA RID: 29402
	public struct ITalkItemDialog : IFlatbufferObject
	{
		// Token: 0x1700DC26 RID: 56358
		// (get) Token: 0x06034A0D RID: 215565 RVA: 0x0071C040 File Offset: 0x0071A240
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034A0E RID: 215566 RVA: 0x0071C04D File Offset: 0x0071A24D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034A0F RID: 215567 RVA: 0x0071C054 File Offset: 0x0071A254
		public static ITalkItemDialog GetRootAsITalkItemDialog(ByteBuffer _bb)
		{
			return ITalkItemDialog.GetRootAsITalkItemDialog(_bb, default(ITalkItemDialog));
		}

		// Token: 0x06034A10 RID: 215568 RVA: 0x0071C070 File Offset: 0x0071A270
		public static ITalkItemDialog GetRootAsITalkItemDialog(ByteBuffer _bb, ITalkItemDialog obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034A11 RID: 215569 RVA: 0x0071C08D File Offset: 0x0071A28D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034A12 RID: 215570 RVA: 0x0071C09C File Offset: 0x0071A29C
		public ITalkItemDialog __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DC27 RID: 56359
		// (get) Token: 0x06034A13 RID: 215571 RVA: 0x0071C0AC File Offset: 0x0071A2AC
		public ETalkItemType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETalkItemType.Talk;
				}
				return (ETalkItemType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DC28 RID: 56360
		// (get) Token: 0x06034A14 RID: 215572 RVA: 0x0071C0E8 File Offset: 0x0071A2E8
		public int Id
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

		// Token: 0x1700DC29 RID: 56361
		// (get) Token: 0x06034A15 RID: 215573 RVA: 0x0071C124 File Offset: 0x0071A324
		public int PlotLineId
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

		// Token: 0x1700DC2A RID: 56362
		// (get) Token: 0x06034A16 RID: 215574 RVA: 0x0071C160 File Offset: 0x0071A360
		public string PlotLineKey
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06034A17 RID: 215575 RVA: 0x0071C198 File Offset: 0x0071A398
		public Span<byte> GetPlotLineKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06034A18 RID: 215576 RVA: 0x0071C1A8 File Offset: 0x0071A3A8
		public byte[] GetPlotLineKeyArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700DC2B RID: 56363
		// (get) Token: 0x06034A19 RID: 215577 RVA: 0x0071C1B8 File Offset: 0x0071A3B8
		public string Name
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06034A1A RID: 215578 RVA: 0x0071C1F0 File Offset: 0x0071A3F0
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06034A1B RID: 215579 RVA: 0x0071C200 File Offset: 0x0071A400
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700DC2C RID: 56364
		// (get) Token: 0x06034A1C RID: 215580 RVA: 0x0071C210 File Offset: 0x0071A410
		public bool _Folded
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DC2D RID: 56365
		// (get) Token: 0x06034A1D RID: 215581 RVA: 0x0071C250 File Offset: 0x0071A450
		public EEditFlag _EditFlag
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return EEditFlag.Add;
				}
				return (EEditFlag)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DC2E RID: 56366
		// (get) Token: 0x06034A1E RID: 215582 RVA: 0x0071C290 File Offset: 0x0071A490
		public int WhoId
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DC2F RID: 56367
		// (get) Token: 0x06034A1F RID: 215583 RVA: 0x0071C2D0 File Offset: 0x0071A4D0
		public int TextId
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DC30 RID: 56368
		// (get) Token: 0x06034A20 RID: 215584 RVA: 0x0071C310 File Offset: 0x0071A510
		public string TidTalk
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06034A21 RID: 215585 RVA: 0x0071C348 File Offset: 0x0071A548
		public Span<byte> GetTidTalkBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06034A22 RID: 215586 RVA: 0x0071C358 File Offset: 0x0071A558
		public byte[] GetTidTalkArray()
		{
			return this.__p.__vector_as_array<byte>(22);
		}

		// Token: 0x1700DC31 RID: 56369
		// (get) Token: 0x06034A23 RID: 215587 RVA: 0x0071C368 File Offset: 0x0071A568
		public float WaitTime
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DC32 RID: 56370
		// (get) Token: 0x06034A24 RID: 215588 RVA: 0x0071C3AC File Offset: 0x0071A5AC
		public ICaptionParam? CaptionParams
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return new ICaptionParam?(default(ICaptionParam).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06034A25 RID: 215589 RVA: 0x0071C40C File Offset: 0x0071A60C
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DC33 RID: 56371
		// (get) Token: 0x06034A26 RID: 215590 RVA: 0x0071C470 File Offset: 0x0071A670
		public int ActionsLength
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06034A27 RID: 215591 RVA: 0x0071C49C File Offset: 0x0071A69C
		public ITalkOption? Options(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return new ITalkOption?(default(ITalkOption).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DC34 RID: 56372
		// (get) Token: 0x06034A28 RID: 215592 RVA: 0x0071C500 File Offset: 0x0071A700
		public int OptionsLength
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700DC35 RID: 56373
		// (get) Token: 0x06034A29 RID: 215593 RVA: 0x0071C52C File Offset: 0x0071A72C
		public IPlayMontage? Montage
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return new IPlayMontage?(default(IPlayMontage).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700DC36 RID: 56374
		// (get) Token: 0x06034A2A RID: 215594 RVA: 0x0071C58C File Offset: 0x0071A78C
		public ICameraData? CameraData
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return new ICameraData?(default(ICameraData).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700DC37 RID: 56375
		// (get) Token: 0x06034A2B RID: 215595 RVA: 0x0071C5EC File Offset: 0x0071A7EC
		public ISetFlowTemplate? FlowTemplate
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return new ISetFlowTemplate?(default(ISetFlowTemplate).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06034A2C RID: 215596 RVA: 0x0071C64C File Offset: 0x0071A84C
		public ISetFlowTemplate? FlowTemplateList(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return null;
			}
			return new ISetFlowTemplate?(default(ISetFlowTemplate).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DC38 RID: 56376
		// (get) Token: 0x06034A2D RID: 215597 RVA: 0x0071C6B0 File Offset: 0x0071A8B0
		public int FlowTemplateListLength
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06034A2E RID: 215598 RVA: 0x0071C6DC File Offset: 0x0071A8DC
		public IMontageData? ActorMontageArray(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return null;
			}
			return new IMontageData?(default(IMontageData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DC39 RID: 56377
		// (get) Token: 0x06034A2F RID: 215599 RVA: 0x0071C740 File Offset: 0x0071A940
		public int ActorMontageArrayLength
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06034A30 RID: 215600 RVA: 0x0071C76C File Offset: 0x0071A96C
		public IActorFaceExpression? ActorFaceExpressionArray(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return null;
			}
			return new IActorFaceExpression?(default(IActorFaceExpression).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DC3A RID: 56378
		// (get) Token: 0x06034A31 RID: 215601 RVA: 0x0071C7D0 File Offset: 0x0071A9D0
		public int ActorFaceExpressionArrayLength
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06034A32 RID: 215602 RVA: 0x0071C7FC File Offset: 0x0071A9FC
		public IActorLookAt? ActorLookAtArray(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return null;
			}
			return new IActorLookAt?(default(IActorLookAt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DC3B RID: 56379
		// (get) Token: 0x06034A33 RID: 215603 RVA: 0x0071C860 File Offset: 0x0071AA60
		public int ActorLookAtArrayLength
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06034A34 RID: 215604 RVA: 0x0071C88C File Offset: 0x0071AA8C
		public IActorTurnTo? ActorTurnToArray(int j)
		{
			int num = this.__p.__offset(46);
			if (num == 0)
			{
				return null;
			}
			return new IActorTurnTo?(default(IActorTurnTo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DC3C RID: 56380
		// (get) Token: 0x06034A35 RID: 215605 RVA: 0x0071C8F0 File Offset: 0x0071AAF0
		public int ActorTurnToArrayLength
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700DC3D RID: 56381
		// (get) Token: 0x06034A36 RID: 215606 RVA: 0x0071C91C File Offset: 0x0071AB1C
		public TPostAkEvent TalkAkEventType
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return TPostAkEvent.NONE;
				}
				return (TPostAkEvent)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06034A37 RID: 215607 RVA: 0x0071C95C File Offset: 0x0071AB5C
		public TTable? TalkAkEvent<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(50);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06034A38 RID: 215608 RVA: 0x0071C9A4 File Offset: 0x0071ABA4
		public IPostAkEventGlobal TalkAkEventAsIPostAkEventGlobal()
		{
			return this.TalkAkEvent<IPostAkEventGlobal>().Value;
		}

		// Token: 0x06034A39 RID: 215609 RVA: 0x0071C9C0 File Offset: 0x0071ABC0
		public IPostAkEventMap TalkAkEventAsIPostAkEventMap()
		{
			return this.TalkAkEvent<IPostAkEventMap>().Value;
		}

		// Token: 0x06034A3A RID: 215610 RVA: 0x0071C9DC File Offset: 0x0071ABDC
		public IPostAkEventMusicSubtitle TalkAkEventAsIPostAkEventMusicSubtitle()
		{
			return this.TalkAkEvent<IPostAkEventMusicSubtitle>().Value;
		}

		// Token: 0x06034A3B RID: 215611 RVA: 0x0071C9F8 File Offset: 0x0071ABF8
		public IPostAkEventTargeted TalkAkEventAsIPostAkEventTargeted()
		{
			return this.TalkAkEvent<IPostAkEventTargeted>().Value;
		}

		// Token: 0x1700DC3E RID: 56382
		// (get) Token: 0x06034A3C RID: 215612 RVA: 0x0071CA14 File Offset: 0x0071AC14
		public TPostAkEvent TalkEndAkEventType
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return TPostAkEvent.NONE;
				}
				return (TPostAkEvent)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06034A3D RID: 215613 RVA: 0x0071CA54 File Offset: 0x0071AC54
		public TTable? TalkEndAkEvent<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(54);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06034A3E RID: 215614 RVA: 0x0071CA9C File Offset: 0x0071AC9C
		public IPostAkEventGlobal TalkEndAkEventAsIPostAkEventGlobal()
		{
			return this.TalkEndAkEvent<IPostAkEventGlobal>().Value;
		}

		// Token: 0x06034A3F RID: 215615 RVA: 0x0071CAB8 File Offset: 0x0071ACB8
		public IPostAkEventMap TalkEndAkEventAsIPostAkEventMap()
		{
			return this.TalkEndAkEvent<IPostAkEventMap>().Value;
		}

		// Token: 0x06034A40 RID: 215616 RVA: 0x0071CAD4 File Offset: 0x0071ACD4
		public IPostAkEventMusicSubtitle TalkEndAkEventAsIPostAkEventMusicSubtitle()
		{
			return this.TalkEndAkEvent<IPostAkEventMusicSubtitle>().Value;
		}

		// Token: 0x06034A41 RID: 215617 RVA: 0x0071CAF0 File Offset: 0x0071ACF0
		public IPostAkEventTargeted TalkEndAkEventAsIPostAkEventTargeted()
		{
			return this.TalkEndAkEvent<IPostAkEventTargeted>().Value;
		}

		// Token: 0x1700DC3F RID: 56383
		// (get) Token: 0x06034A42 RID: 215618 RVA: 0x0071CB0C File Offset: 0x0071AD0C
		public IUniversalTone? UniversalTone
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return null;
				}
				return new IUniversalTone?(default(IUniversalTone).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700DC40 RID: 56384
		// (get) Token: 0x06034A43 RID: 215619 RVA: 0x0071CB6C File Offset: 0x0071AD6C
		public TTalkBackground BackgroundConfigType
		{
			get
			{
				int num = this.__p.__offset(58);
				if (num == 0)
				{
					return TTalkBackground.NONE;
				}
				return (TTalkBackground)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06034A44 RID: 215620 RVA: 0x0071CBAC File Offset: 0x0071ADAC
		public TTable? BackgroundConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(60);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06034A45 RID: 215621 RVA: 0x0071CBF4 File Offset: 0x0071ADF4
		public ITalkBackgroundClean BackgroundConfigAsITalkBackgroundClean()
		{
			return this.BackgroundConfig<ITalkBackgroundClean>().Value;
		}

		// Token: 0x06034A46 RID: 215622 RVA: 0x0071CC10 File Offset: 0x0071AE10
		public ITalkBackgroundIcon BackgroundConfigAsITalkBackgroundIcon()
		{
			return this.BackgroundConfig<ITalkBackgroundIcon>().Value;
		}

		// Token: 0x06034A47 RID: 215623 RVA: 0x0071CC2C File Offset: 0x0071AE2C
		public ITalkBackgroundImage BackgroundConfigAsITalkBackgroundImage()
		{
			return this.BackgroundConfig<ITalkBackgroundImage>().Value;
		}

		// Token: 0x06034A48 RID: 215624 RVA: 0x0071CC48 File Offset: 0x0071AE48
		public ITalkBackgroundImageByMcGender BackgroundConfigAsITalkBackgroundImageByMcGender()
		{
			return this.BackgroundConfig<ITalkBackgroundImageByMcGender>().Value;
		}

		// Token: 0x06034A49 RID: 215625 RVA: 0x0071CC64 File Offset: 0x0071AE64
		public ITalkBackgroundSpineImage BackgroundConfigAsITalkBackgroundSpineImage()
		{
			return this.BackgroundConfig<ITalkBackgroundSpineImage>().Value;
		}

		// Token: 0x1700DC41 RID: 56385
		// (get) Token: 0x06034A4A RID: 215626 RVA: 0x0071CC80 File Offset: 0x0071AE80
		public bool PlayVoice
		{
			get
			{
				int num = this.__p.__offset(62);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DC42 RID: 56386
		// (get) Token: 0x06034A4B RID: 215627 RVA: 0x0071CCC0 File Offset: 0x0071AEC0
		public ITimeLimitOptionGroup? TimeLimitOptionGroup
		{
			get
			{
				int num = this.__p.__offset(64);
				if (num == 0)
				{
					return null;
				}
				return new ITimeLimitOptionGroup?(default(ITimeLimitOptionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700DC43 RID: 56387
		// (get) Token: 0x06034A4C RID: 215628 RVA: 0x0071CD20 File Offset: 0x0071AF20
		public IGamepadShakeInTalk? GamepadShake
		{
			get
			{
				int num = this.__p.__offset(66);
				if (num == 0)
				{
					return null;
				}
				return new IGamepadShakeInTalk?(default(IGamepadShakeInTalk).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06034A4D RID: 215629 RVA: 0x0071CD80 File Offset: 0x0071AF80
		public IActionInfo? IntroActions(int j)
		{
			int num = this.__p.__offset(68);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DC44 RID: 56388
		// (get) Token: 0x06034A4E RID: 215630 RVA: 0x0071CDE4 File Offset: 0x0071AFE4
		public int IntroActionsLength
		{
			get
			{
				int num = this.__p.__offset(68);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06034A4F RID: 215631 RVA: 0x0071CE10 File Offset: 0x0071B010
		public IActorFxEmote? ActorFxEmoteArray(int j)
		{
			int num = this.__p.__offset(70);
			if (num == 0)
			{
				return null;
			}
			return new IActorFxEmote?(default(IActorFxEmote).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DC45 RID: 56389
		// (get) Token: 0x06034A50 RID: 215632 RVA: 0x0071CE74 File Offset: 0x0071B074
		public int ActorFxEmoteArrayLength
		{
			get
			{
				int num = this.__p.__offset(70);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06034A51 RID: 215633 RVA: 0x0071CEA0 File Offset: 0x0071B0A0
		public TTalkEffectAction TalkEffectArrayType(int j)
		{
			int num = this.__p.__offset(72);
			if (num == 0)
			{
				return TTalkEffectAction.NONE;
			}
			return (TTalkEffectAction)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700DC46 RID: 56390
		// (get) Token: 0x06034A52 RID: 215634 RVA: 0x0071CEE0 File Offset: 0x0071B0E0
		public int TalkEffectArrayTypeLength
		{
			get
			{
				int num = this.__p.__offset(72);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06034A53 RID: 215635 RVA: 0x0071CF0C File Offset: 0x0071B10C
		public Span<TTalkEffectAction> GetTalkEffectArrayTypeBytes()
		{
			return this.__p.__vector_as_span<TTalkEffectAction>(72, 1);
		}

		// Token: 0x06034A54 RID: 215636 RVA: 0x0071CF1C File Offset: 0x0071B11C
		public TTalkEffectAction[] GetTalkEffectArrayTypeArray()
		{
			int num = this.__p.__offset(72);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TTalkEffectAction[] array = new TTalkEffectAction[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TTalkEffectAction)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x06034A55 RID: 215637 RVA: 0x0071CF88 File Offset: 0x0071B188
		public TTable? TalkEffectArray<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(74);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700DC47 RID: 56391
		// (get) Token: 0x06034A56 RID: 215638 RVA: 0x0071CFD0 File Offset: 0x0071B1D0
		public int TalkEffectArrayLength
		{
			get
			{
				int num = this.__p.__offset(74);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06034A57 RID: 215639 RVA: 0x0071CFFC File Offset: 0x0071B1FC
		public IActorVisibility? ActorVisibilityArray(int j)
		{
			int num = this.__p.__offset(76);
			if (num == 0)
			{
				return null;
			}
			return new IActorVisibility?(default(IActorVisibility).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DC48 RID: 56392
		// (get) Token: 0x06034A58 RID: 215640 RVA: 0x0071D060 File Offset: 0x0071B260
		public int ActorVisibilityArrayLength
		{
			get
			{
				int num = this.__p.__offset(76);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700DC49 RID: 56393
		// (get) Token: 0x06034A59 RID: 215641 RVA: 0x0071D08C File Offset: 0x0071B28C
		public TTalkItemStyle StyleType
		{
			get
			{
				int num = this.__p.__offset(78);
				if (num == 0)
				{
					return TTalkItemStyle.NONE;
				}
				return (TTalkItemStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06034A5A RID: 215642 RVA: 0x0071D0CC File Offset: 0x0071B2CC
		public TTable? Style<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(80);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06034A5B RID: 215643 RVA: 0x0071D114 File Offset: 0x0071B314
		public ITalkItemStyleInnerVoice StyleAsITalkItemStyleInnerVoice()
		{
			return this.Style<ITalkItemStyleInnerVoice>().Value;
		}

		// Token: 0x06034A5C RID: 215644 RVA: 0x0071D130 File Offset: 0x0071B330
		public ITalkItemStylePhoneSendError StyleAsITalkItemStylePhoneSendError()
		{
			return this.Style<ITalkItemStylePhoneSendError>().Value;
		}

		// Token: 0x1700DC4A RID: 56394
		// (get) Token: 0x06034A5D RID: 215645 RVA: 0x0071D14C File Offset: 0x0071B34C
		public TShowTalkCameraMotion CameraMotionType
		{
			get
			{
				int num = this.__p.__offset(82);
				if (num == 0)
				{
					return TShowTalkCameraMotion.NONE;
				}
				return (TShowTalkCameraMotion)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06034A5E RID: 215646 RVA: 0x0071D18C File Offset: 0x0071B38C
		public TTable? CameraMotion<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(84);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06034A5F RID: 215647 RVA: 0x0071D1D4 File Offset: 0x0071B3D4
		public IShowTalkCameraMotionPreset CameraMotionAsIShowTalkCameraMotionPreset()
		{
			return this.CameraMotion<IShowTalkCameraMotionPreset>().Value;
		}

		// Token: 0x06034A60 RID: 215648 RVA: 0x0071D1F0 File Offset: 0x0071B3F0
		public IShowTalkCameraMotionTween CameraMotionAsIShowTalkCameraMotionTween()
		{
			return this.CameraMotion<IShowTalkCameraMotionTween>().Value;
		}

		// Token: 0x1700DC4B RID: 56395
		// (get) Token: 0x06034A61 RID: 215649 RVA: 0x0071D20C File Offset: 0x0071B40C
		public ITalkItemAutoPlayConfig? AutoPlayConfig
		{
			get
			{
				int num = this.__p.__offset(86);
				if (num == 0)
				{
					return null;
				}
				return new ITalkItemAutoPlayConfig?(default(ITalkItemAutoPlayConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700DC4C RID: 56396
		// (get) Token: 0x06034A62 RID: 215650 RVA: 0x0071D26C File Offset: 0x0071B46C
		public bool NoMouthAnim
		{
			get
			{
				int num = this.__p.__offset(88);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DC4D RID: 56397
		// (get) Token: 0x06034A63 RID: 215651 RVA: 0x0071D2AC File Offset: 0x0071B4AC
		public float OtherIsTypingDuration
		{
			get
			{
				int num = this.__p.__offset(90);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DC4E RID: 56398
		// (get) Token: 0x06034A64 RID: 215652 RVA: 0x0071D2F0 File Offset: 0x0071B4F0
		public uint NullMask
		{
			get
			{
				int num = this.__p.__offset(92);
				if (num == 0)
				{
					return 0U;
				}
				return this.__p.bb.GetUint(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06034A65 RID: 215653 RVA: 0x0071D330 File Offset: 0x0071B530
		public static Offset<ITalkItemDialog> CreateITalkItemDialog(FlatBufferBuilder builder, ETalkItemType Type = ETalkItemType.Talk, int Id = 0, int PlotLineId = 0, StringOffset PlotLineKeyOffset = default(StringOffset), StringOffset NameOffset = default(StringOffset), bool _folded = false, EEditFlag _editFlag = EEditFlag.Add, int WhoId = 0, int TextId = 0, StringOffset TidTalkOffset = default(StringOffset), float WaitTime = 0f, Offset<ICaptionParam> CaptionParamsOffset = default(Offset<ICaptionParam>), VectorOffset ActionsOffset = default(VectorOffset), VectorOffset OptionsOffset = default(VectorOffset), Offset<IPlayMontage> MontageOffset = default(Offset<IPlayMontage>), Offset<ICameraData> CameraDataOffset = default(Offset<ICameraData>), Offset<ISetFlowTemplate> FlowTemplateOffset = default(Offset<ISetFlowTemplate>), VectorOffset FlowTemplateListOffset = default(VectorOffset), VectorOffset ActorMontageArrayOffset = default(VectorOffset), VectorOffset ActorFaceExpressionArrayOffset = default(VectorOffset), VectorOffset ActorLookAtArrayOffset = default(VectorOffset), VectorOffset ActorTurnToArrayOffset = default(VectorOffset), TPostAkEvent TalkAkEvent_type = TPostAkEvent.NONE, int TalkAkEventOffset = 0, TPostAkEvent TalkEndAkEvent_type = TPostAkEvent.NONE, int TalkEndAkEventOffset = 0, Offset<IUniversalTone> UniversalToneOffset = default(Offset<IUniversalTone>), TTalkBackground BackgroundConfig_type = TTalkBackground.NONE, int BackgroundConfigOffset = 0, bool PlayVoice = false, Offset<ITimeLimitOptionGroup> TimeLimitOptionGroupOffset = default(Offset<ITimeLimitOptionGroup>), Offset<IGamepadShakeInTalk> GamepadShakeOffset = default(Offset<IGamepadShakeInTalk>), VectorOffset IntroActionsOffset = default(VectorOffset), VectorOffset ActorFxEmoteArrayOffset = default(VectorOffset), VectorOffset TalkEffectArray_typeOffset = default(VectorOffset), VectorOffset TalkEffectArrayOffset = default(VectorOffset), VectorOffset ActorVisibilityArrayOffset = default(VectorOffset), TTalkItemStyle Style_type = TTalkItemStyle.NONE, int StyleOffset = 0, TShowTalkCameraMotion CameraMotion_type = TShowTalkCameraMotion.NONE, int CameraMotionOffset = 0, Offset<ITalkItemAutoPlayConfig> AutoPlayConfigOffset = default(Offset<ITalkItemAutoPlayConfig>), bool NoMouthAnim = false, float OtherIsTypingDuration = 0f, uint NullMask = 0U)
		{
			builder.StartTable(45);
			ITalkItemDialog.AddNullMask(builder, NullMask);
			ITalkItemDialog.AddOtherIsTypingDuration(builder, OtherIsTypingDuration);
			ITalkItemDialog.AddAutoPlayConfig(builder, AutoPlayConfigOffset);
			ITalkItemDialog.AddCameraMotion(builder, CameraMotionOffset);
			ITalkItemDialog.AddStyle(builder, StyleOffset);
			ITalkItemDialog.AddActorVisibilityArray(builder, ActorVisibilityArrayOffset);
			ITalkItemDialog.AddTalkEffectArray(builder, TalkEffectArrayOffset);
			ITalkItemDialog.AddTalkEffectArrayType(builder, TalkEffectArray_typeOffset);
			ITalkItemDialog.AddActorFxEmoteArray(builder, ActorFxEmoteArrayOffset);
			ITalkItemDialog.AddIntroActions(builder, IntroActionsOffset);
			ITalkItemDialog.AddGamepadShake(builder, GamepadShakeOffset);
			ITalkItemDialog.AddTimeLimitOptionGroup(builder, TimeLimitOptionGroupOffset);
			ITalkItemDialog.AddBackgroundConfig(builder, BackgroundConfigOffset);
			ITalkItemDialog.AddUniversalTone(builder, UniversalToneOffset);
			ITalkItemDialog.AddTalkEndAkEvent(builder, TalkEndAkEventOffset);
			ITalkItemDialog.AddTalkAkEvent(builder, TalkAkEventOffset);
			ITalkItemDialog.AddActorTurnToArray(builder, ActorTurnToArrayOffset);
			ITalkItemDialog.AddActorLookAtArray(builder, ActorLookAtArrayOffset);
			ITalkItemDialog.AddActorFaceExpressionArray(builder, ActorFaceExpressionArrayOffset);
			ITalkItemDialog.AddActorMontageArray(builder, ActorMontageArrayOffset);
			ITalkItemDialog.AddFlowTemplateList(builder, FlowTemplateListOffset);
			ITalkItemDialog.AddFlowTemplate(builder, FlowTemplateOffset);
			ITalkItemDialog.AddCameraData(builder, CameraDataOffset);
			ITalkItemDialog.AddMontage(builder, MontageOffset);
			ITalkItemDialog.AddOptions(builder, OptionsOffset);
			ITalkItemDialog.AddActions(builder, ActionsOffset);
			ITalkItemDialog.AddCaptionParams(builder, CaptionParamsOffset);
			ITalkItemDialog.AddWaitTime(builder, WaitTime);
			ITalkItemDialog.AddTidTalk(builder, TidTalkOffset);
			ITalkItemDialog.AddTextId(builder, TextId);
			ITalkItemDialog.AddWhoId(builder, WhoId);
			ITalkItemDialog.AddName(builder, NameOffset);
			ITalkItemDialog.AddPlotLineKey(builder, PlotLineKeyOffset);
			ITalkItemDialog.AddPlotLineId(builder, PlotLineId);
			ITalkItemDialog.AddId(builder, Id);
			ITalkItemDialog.AddNoMouthAnim(builder, NoMouthAnim);
			ITalkItemDialog.AddCameraMotionType(builder, CameraMotion_type);
			ITalkItemDialog.AddStyleType(builder, Style_type);
			ITalkItemDialog.AddPlayVoice(builder, PlayVoice);
			ITalkItemDialog.AddBackgroundConfigType(builder, BackgroundConfig_type);
			ITalkItemDialog.AddTalkEndAkEventType(builder, TalkEndAkEvent_type);
			ITalkItemDialog.AddTalkAkEventType(builder, TalkAkEvent_type);
			ITalkItemDialog.Add_EditFlag(builder, _editFlag);
			ITalkItemDialog.Add_Folded(builder, _folded);
			ITalkItemDialog.AddType(builder, Type);
			return ITalkItemDialog.EndITalkItemDialog(builder);
		}

		// Token: 0x06034A66 RID: 215654 RVA: 0x0071D4B0 File Offset: 0x0071B6B0
		public static void StartITalkItemDialog(FlatBufferBuilder builder)
		{
			builder.StartTable(45);
		}

		// Token: 0x06034A67 RID: 215655 RVA: 0x0071D4BA File Offset: 0x0071B6BA
		public static void AddType(FlatBufferBuilder builder, ETalkItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034A68 RID: 215656 RVA: 0x0071D4C5 File Offset: 0x0071B6C5
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06034A69 RID: 215657 RVA: 0x0071D4D0 File Offset: 0x0071B6D0
		public static void AddPlotLineId(FlatBufferBuilder builder, int plotLineId)
		{
			builder.AddInt(2, plotLineId, 0);
		}

		// Token: 0x06034A6A RID: 215658 RVA: 0x0071D4DB File Offset: 0x0071B6DB
		public static void AddPlotLineKey(FlatBufferBuilder builder, StringOffset plotLineKeyOffset)
		{
			builder.AddOffset(3, plotLineKeyOffset.Value, 0);
		}

		// Token: 0x06034A6B RID: 215659 RVA: 0x0071D4EB File Offset: 0x0071B6EB
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(4, nameOffset.Value, 0);
		}

		// Token: 0x06034A6C RID: 215660 RVA: 0x0071D4FB File Offset: 0x0071B6FB
		public static void Add_Folded(FlatBufferBuilder builder, bool _Folded)
		{
			builder.AddBool(5, _Folded, false);
		}

		// Token: 0x06034A6D RID: 215661 RVA: 0x0071D506 File Offset: 0x0071B706
		public static void Add_EditFlag(FlatBufferBuilder builder, EEditFlag _EditFlag)
		{
			builder.AddByte(6, (byte)_EditFlag, 0);
		}

		// Token: 0x06034A6E RID: 215662 RVA: 0x0071D511 File Offset: 0x0071B711
		public static void AddWhoId(FlatBufferBuilder builder, int whoId)
		{
			builder.AddInt(7, whoId, 0);
		}

		// Token: 0x06034A6F RID: 215663 RVA: 0x0071D51C File Offset: 0x0071B71C
		public static void AddTextId(FlatBufferBuilder builder, int textId)
		{
			builder.AddInt(8, textId, 0);
		}

		// Token: 0x06034A70 RID: 215664 RVA: 0x0071D527 File Offset: 0x0071B727
		public static void AddTidTalk(FlatBufferBuilder builder, StringOffset tidTalkOffset)
		{
			builder.AddOffset(9, tidTalkOffset.Value, 0);
		}

		// Token: 0x06034A71 RID: 215665 RVA: 0x0071D538 File Offset: 0x0071B738
		public static void AddWaitTime(FlatBufferBuilder builder, float waitTime)
		{
			builder.AddFloat(10, waitTime, 0.0);
		}

		// Token: 0x06034A72 RID: 215666 RVA: 0x0071D54C File Offset: 0x0071B74C
		public static void AddCaptionParams(FlatBufferBuilder builder, Offset<ICaptionParam> captionParamsOffset)
		{
			builder.AddOffset(11, captionParamsOffset.Value, 0);
		}

		// Token: 0x06034A73 RID: 215667 RVA: 0x0071D55D File Offset: 0x0071B75D
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(12, actionsOffset.Value, 0);
		}

		// Token: 0x06034A74 RID: 215668 RVA: 0x0071D570 File Offset: 0x0071B770
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06034A75 RID: 215669 RVA: 0x0071D5B0 File Offset: 0x0071B7B0
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06034A76 RID: 215670 RVA: 0x0071D5CA File Offset: 0x0071B7CA
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06034A77 RID: 215671 RVA: 0x0071D5E8 File Offset: 0x0071B7E8
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06034A78 RID: 215672 RVA: 0x0071D601 File Offset: 0x0071B801
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06034A79 RID: 215673 RVA: 0x0071D60C File Offset: 0x0071B80C
		public static void AddOptions(FlatBufferBuilder builder, VectorOffset optionsOffset)
		{
			builder.AddOffset(13, optionsOffset.Value, 0);
		}

		// Token: 0x06034A7A RID: 215674 RVA: 0x0071D620 File Offset: 0x0071B820
		public static VectorOffset CreateOptionsVector(FlatBufferBuilder builder, Offset<ITalkOption>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06034A7B RID: 215675 RVA: 0x0071D660 File Offset: 0x0071B860
		public static VectorOffset CreateOptionsVectorBlock(FlatBufferBuilder builder, Offset<ITalkOption>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ITalkOption>>(data);
			return builder.EndVector();
		}

		// Token: 0x06034A7C RID: 215676 RVA: 0x0071D67A File Offset: 0x0071B87A
		public static VectorOffset CreateOptionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ITalkOption>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ITalkOption>>(data);
			return builder.EndVector();
		}

		// Token: 0x06034A7D RID: 215677 RVA: 0x0071D698 File Offset: 0x0071B898
		public static VectorOffset CreateOptionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ITalkOption>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06034A7E RID: 215678 RVA: 0x0071D6B1 File Offset: 0x0071B8B1
		public static void StartOptionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06034A7F RID: 215679 RVA: 0x0071D6BC File Offset: 0x0071B8BC
		public static void AddMontage(FlatBufferBuilder builder, Offset<IPlayMontage> montageOffset)
		{
			builder.AddOffset(14, montageOffset.Value, 0);
		}

		// Token: 0x06034A80 RID: 215680 RVA: 0x0071D6CD File Offset: 0x0071B8CD
		public static void AddCameraData(FlatBufferBuilder builder, Offset<ICameraData> cameraDataOffset)
		{
			builder.AddOffset(15, cameraDataOffset.Value, 0);
		}

		// Token: 0x06034A81 RID: 215681 RVA: 0x0071D6DE File Offset: 0x0071B8DE
		public static void AddFlowTemplate(FlatBufferBuilder builder, Offset<ISetFlowTemplate> flowTemplateOffset)
		{
			builder.AddOffset(16, flowTemplateOffset.Value, 0);
		}

		// Token: 0x06034A82 RID: 215682 RVA: 0x0071D6EF File Offset: 0x0071B8EF
		public static void AddFlowTemplateList(FlatBufferBuilder builder, VectorOffset flowTemplateListOffset)
		{
			builder.AddOffset(17, flowTemplateListOffset.Value, 0);
		}

		// Token: 0x06034A83 RID: 215683 RVA: 0x0071D700 File Offset: 0x0071B900
		public static VectorOffset CreateFlowTemplateListVector(FlatBufferBuilder builder, Offset<ISetFlowTemplate>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06034A84 RID: 215684 RVA: 0x0071D740 File Offset: 0x0071B940
		public static VectorOffset CreateFlowTemplateListVectorBlock(FlatBufferBuilder builder, Offset<ISetFlowTemplate>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISetFlowTemplate>>(data);
			return builder.EndVector();
		}

		// Token: 0x06034A85 RID: 215685 RVA: 0x0071D75A File Offset: 0x0071B95A
		public static VectorOffset CreateFlowTemplateListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISetFlowTemplate>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISetFlowTemplate>>(data);
			return builder.EndVector();
		}

		// Token: 0x06034A86 RID: 215686 RVA: 0x0071D778 File Offset: 0x0071B978
		public static VectorOffset CreateFlowTemplateListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISetFlowTemplate>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06034A87 RID: 215687 RVA: 0x0071D791 File Offset: 0x0071B991
		public static void StartFlowTemplateListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06034A88 RID: 215688 RVA: 0x0071D79C File Offset: 0x0071B99C
		public static void AddActorMontageArray(FlatBufferBuilder builder, VectorOffset actorMontageArrayOffset)
		{
			builder.AddOffset(18, actorMontageArrayOffset.Value, 0);
		}

		// Token: 0x06034A89 RID: 215689 RVA: 0x0071D7B0 File Offset: 0x0071B9B0
		public static VectorOffset CreateActorMontageArrayVector(FlatBufferBuilder builder, Offset<IMontageData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06034A8A RID: 215690 RVA: 0x0071D7F0 File Offset: 0x0071B9F0
		public static VectorOffset CreateActorMontageArrayVectorBlock(FlatBufferBuilder builder, Offset<IMontageData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IMontageData>>(data);
			return builder.EndVector();
		}

		// Token: 0x06034A8B RID: 215691 RVA: 0x0071D80A File Offset: 0x0071BA0A
		public static VectorOffset CreateActorMontageArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IMontageData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IMontageData>>(data);
			return builder.EndVector();
		}

		// Token: 0x06034A8C RID: 215692 RVA: 0x0071D828 File Offset: 0x0071BA28
		public static VectorOffset CreateActorMontageArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IMontageData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06034A8D RID: 215693 RVA: 0x0071D841 File Offset: 0x0071BA41
		public static void StartActorMontageArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06034A8E RID: 215694 RVA: 0x0071D84C File Offset: 0x0071BA4C
		public static void AddActorFaceExpressionArray(FlatBufferBuilder builder, VectorOffset actorFaceExpressionArrayOffset)
		{
			builder.AddOffset(19, actorFaceExpressionArrayOffset.Value, 0);
		}

		// Token: 0x06034A8F RID: 215695 RVA: 0x0071D860 File Offset: 0x0071BA60
		public static VectorOffset CreateActorFaceExpressionArrayVector(FlatBufferBuilder builder, Offset<IActorFaceExpression>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06034A90 RID: 215696 RVA: 0x0071D8A0 File Offset: 0x0071BAA0
		public static VectorOffset CreateActorFaceExpressionArrayVectorBlock(FlatBufferBuilder builder, Offset<IActorFaceExpression>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorFaceExpression>>(data);
			return builder.EndVector();
		}

		// Token: 0x06034A91 RID: 215697 RVA: 0x0071D8BA File Offset: 0x0071BABA
		public static VectorOffset CreateActorFaceExpressionArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorFaceExpression>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorFaceExpression>>(data);
			return builder.EndVector();
		}

		// Token: 0x06034A92 RID: 215698 RVA: 0x0071D8D8 File Offset: 0x0071BAD8
		public static VectorOffset CreateActorFaceExpressionArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorFaceExpression>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06034A93 RID: 215699 RVA: 0x0071D8F1 File Offset: 0x0071BAF1
		public static void StartActorFaceExpressionArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06034A94 RID: 215700 RVA: 0x0071D8FC File Offset: 0x0071BAFC
		public static void AddActorLookAtArray(FlatBufferBuilder builder, VectorOffset actorLookAtArrayOffset)
		{
			builder.AddOffset(20, actorLookAtArrayOffset.Value, 0);
		}

		// Token: 0x06034A95 RID: 215701 RVA: 0x0071D910 File Offset: 0x0071BB10
		public static VectorOffset CreateActorLookAtArrayVector(FlatBufferBuilder builder, Offset<IActorLookAt>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06034A96 RID: 215702 RVA: 0x0071D950 File Offset: 0x0071BB50
		public static VectorOffset CreateActorLookAtArrayVectorBlock(FlatBufferBuilder builder, Offset<IActorLookAt>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorLookAt>>(data);
			return builder.EndVector();
		}

		// Token: 0x06034A97 RID: 215703 RVA: 0x0071D96A File Offset: 0x0071BB6A
		public static VectorOffset CreateActorLookAtArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorLookAt>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorLookAt>>(data);
			return builder.EndVector();
		}

		// Token: 0x06034A98 RID: 215704 RVA: 0x0071D988 File Offset: 0x0071BB88
		public static VectorOffset CreateActorLookAtArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorLookAt>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06034A99 RID: 215705 RVA: 0x0071D9A1 File Offset: 0x0071BBA1
		public static void StartActorLookAtArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06034A9A RID: 215706 RVA: 0x0071D9AC File Offset: 0x0071BBAC
		public static void AddActorTurnToArray(FlatBufferBuilder builder, VectorOffset actorTurnToArrayOffset)
		{
			builder.AddOffset(21, actorTurnToArrayOffset.Value, 0);
		}

		// Token: 0x06034A9B RID: 215707 RVA: 0x0071D9C0 File Offset: 0x0071BBC0
		public static VectorOffset CreateActorTurnToArrayVector(FlatBufferBuilder builder, Offset<IActorTurnTo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06034A9C RID: 215708 RVA: 0x0071DA00 File Offset: 0x0071BC00
		public static VectorOffset CreateActorTurnToArrayVectorBlock(FlatBufferBuilder builder, Offset<IActorTurnTo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorTurnTo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06034A9D RID: 215709 RVA: 0x0071DA1A File Offset: 0x0071BC1A
		public static VectorOffset CreateActorTurnToArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorTurnTo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorTurnTo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06034A9E RID: 215710 RVA: 0x0071DA38 File Offset: 0x0071BC38
		public static VectorOffset CreateActorTurnToArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorTurnTo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06034A9F RID: 215711 RVA: 0x0071DA51 File Offset: 0x0071BC51
		public static void StartActorTurnToArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06034AA0 RID: 215712 RVA: 0x0071DA5C File Offset: 0x0071BC5C
		public static void AddTalkAkEventType(FlatBufferBuilder builder, TPostAkEvent talkAkEventType)
		{
			builder.AddByte(22, (byte)talkAkEventType, 0);
		}

		// Token: 0x06034AA1 RID: 215713 RVA: 0x0071DA68 File Offset: 0x0071BC68
		public static void AddTalkAkEvent(FlatBufferBuilder builder, int talkAkEventOffset)
		{
			builder.AddOffset(23, talkAkEventOffset, 0);
		}

		// Token: 0x06034AA2 RID: 215714 RVA: 0x0071DA74 File Offset: 0x0071BC74
		public static void AddTalkEndAkEventType(FlatBufferBuilder builder, TPostAkEvent talkEndAkEventType)
		{
			builder.AddByte(24, (byte)talkEndAkEventType, 0);
		}

		// Token: 0x06034AA3 RID: 215715 RVA: 0x0071DA80 File Offset: 0x0071BC80
		public static void AddTalkEndAkEvent(FlatBufferBuilder builder, int talkEndAkEventOffset)
		{
			builder.AddOffset(25, talkEndAkEventOffset, 0);
		}

		// Token: 0x06034AA4 RID: 215716 RVA: 0x0071DA8C File Offset: 0x0071BC8C
		public static void AddUniversalTone(FlatBufferBuilder builder, Offset<IUniversalTone> universalToneOffset)
		{
			builder.AddOffset(26, universalToneOffset.Value, 0);
		}

		// Token: 0x06034AA5 RID: 215717 RVA: 0x0071DA9D File Offset: 0x0071BC9D
		public static void AddBackgroundConfigType(FlatBufferBuilder builder, TTalkBackground backgroundConfigType)
		{
			builder.AddByte(27, (byte)backgroundConfigType, 0);
		}

		// Token: 0x06034AA6 RID: 215718 RVA: 0x0071DAA9 File Offset: 0x0071BCA9
		public static void AddBackgroundConfig(FlatBufferBuilder builder, int backgroundConfigOffset)
		{
			builder.AddOffset(28, backgroundConfigOffset, 0);
		}

		// Token: 0x06034AA7 RID: 215719 RVA: 0x0071DAB5 File Offset: 0x0071BCB5
		public static void AddPlayVoice(FlatBufferBuilder builder, bool playVoice)
		{
			builder.AddBool(29, playVoice, false);
		}

		// Token: 0x06034AA8 RID: 215720 RVA: 0x0071DAC1 File Offset: 0x0071BCC1
		public static void AddTimeLimitOptionGroup(FlatBufferBuilder builder, Offset<ITimeLimitOptionGroup> timeLimitOptionGroupOffset)
		{
			builder.AddOffset(30, timeLimitOptionGroupOffset.Value, 0);
		}

		// Token: 0x06034AA9 RID: 215721 RVA: 0x0071DAD2 File Offset: 0x0071BCD2
		public static void AddGamepadShake(FlatBufferBuilder builder, Offset<IGamepadShakeInTalk> gamepadShakeOffset)
		{
			builder.AddOffset(31, gamepadShakeOffset.Value, 0);
		}

		// Token: 0x06034AAA RID: 215722 RVA: 0x0071DAE3 File Offset: 0x0071BCE3
		public static void AddIntroActions(FlatBufferBuilder builder, VectorOffset introActionsOffset)
		{
			builder.AddOffset(32, introActionsOffset.Value, 0);
		}

		// Token: 0x06034AAB RID: 215723 RVA: 0x0071DAF4 File Offset: 0x0071BCF4
		public static VectorOffset CreateIntroActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06034AAC RID: 215724 RVA: 0x0071DB34 File Offset: 0x0071BD34
		public static VectorOffset CreateIntroActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06034AAD RID: 215725 RVA: 0x0071DB4E File Offset: 0x0071BD4E
		public static VectorOffset CreateIntroActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06034AAE RID: 215726 RVA: 0x0071DB6C File Offset: 0x0071BD6C
		public static VectorOffset CreateIntroActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06034AAF RID: 215727 RVA: 0x0071DB85 File Offset: 0x0071BD85
		public static void StartIntroActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06034AB0 RID: 215728 RVA: 0x0071DB90 File Offset: 0x0071BD90
		public static void AddActorFxEmoteArray(FlatBufferBuilder builder, VectorOffset actorFxEmoteArrayOffset)
		{
			builder.AddOffset(33, actorFxEmoteArrayOffset.Value, 0);
		}

		// Token: 0x06034AB1 RID: 215729 RVA: 0x0071DBA4 File Offset: 0x0071BDA4
		public static VectorOffset CreateActorFxEmoteArrayVector(FlatBufferBuilder builder, Offset<IActorFxEmote>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06034AB2 RID: 215730 RVA: 0x0071DBE4 File Offset: 0x0071BDE4
		public static VectorOffset CreateActorFxEmoteArrayVectorBlock(FlatBufferBuilder builder, Offset<IActorFxEmote>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorFxEmote>>(data);
			return builder.EndVector();
		}

		// Token: 0x06034AB3 RID: 215731 RVA: 0x0071DBFE File Offset: 0x0071BDFE
		public static VectorOffset CreateActorFxEmoteArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorFxEmote>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorFxEmote>>(data);
			return builder.EndVector();
		}

		// Token: 0x06034AB4 RID: 215732 RVA: 0x0071DC1C File Offset: 0x0071BE1C
		public static VectorOffset CreateActorFxEmoteArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorFxEmote>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06034AB5 RID: 215733 RVA: 0x0071DC35 File Offset: 0x0071BE35
		public static void StartActorFxEmoteArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06034AB6 RID: 215734 RVA: 0x0071DC40 File Offset: 0x0071BE40
		public static void AddTalkEffectArrayType(FlatBufferBuilder builder, VectorOffset talkEffectArrayTypeOffset)
		{
			builder.AddOffset(34, talkEffectArrayTypeOffset.Value, 0);
		}

		// Token: 0x06034AB7 RID: 215735 RVA: 0x0071DC54 File Offset: 0x0071BE54
		public static VectorOffset CreateTalkEffectArrayTypeVector(FlatBufferBuilder builder, TTalkEffectAction[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06034AB8 RID: 215736 RVA: 0x0071DC8B File Offset: 0x0071BE8B
		public static VectorOffset CreateTalkEffectArrayTypeVectorBlock(FlatBufferBuilder builder, TTalkEffectAction[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TTalkEffectAction>(data);
			return builder.EndVector();
		}

		// Token: 0x06034AB9 RID: 215737 RVA: 0x0071DCA5 File Offset: 0x0071BEA5
		public static VectorOffset CreateTalkEffectArrayTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TTalkEffectAction> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TTalkEffectAction>(data);
			return builder.EndVector();
		}

		// Token: 0x06034ABA RID: 215738 RVA: 0x0071DCC3 File Offset: 0x0071BEC3
		public static VectorOffset CreateTalkEffectArrayTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TTalkEffectAction>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06034ABB RID: 215739 RVA: 0x0071DCDC File Offset: 0x0071BEDC
		public static void StartTalkEffectArrayTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06034ABC RID: 215740 RVA: 0x0071DCE7 File Offset: 0x0071BEE7
		public static void AddTalkEffectArray(FlatBufferBuilder builder, VectorOffset talkEffectArrayOffset)
		{
			builder.AddOffset(35, talkEffectArrayOffset.Value, 0);
		}

		// Token: 0x06034ABD RID: 215741 RVA: 0x0071DCF8 File Offset: 0x0071BEF8
		public static VectorOffset CreateTalkEffectArrayVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06034ABE RID: 215742 RVA: 0x0071DD2F File Offset: 0x0071BF2F
		public static VectorOffset CreateTalkEffectArrayVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06034ABF RID: 215743 RVA: 0x0071DD49 File Offset: 0x0071BF49
		public static VectorOffset CreateTalkEffectArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06034AC0 RID: 215744 RVA: 0x0071DD67 File Offset: 0x0071BF67
		public static VectorOffset CreateTalkEffectArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06034AC1 RID: 215745 RVA: 0x0071DD80 File Offset: 0x0071BF80
		public static void StartTalkEffectArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06034AC2 RID: 215746 RVA: 0x0071DD8B File Offset: 0x0071BF8B
		public static void AddActorVisibilityArray(FlatBufferBuilder builder, VectorOffset actorVisibilityArrayOffset)
		{
			builder.AddOffset(36, actorVisibilityArrayOffset.Value, 0);
		}

		// Token: 0x06034AC3 RID: 215747 RVA: 0x0071DD9C File Offset: 0x0071BF9C
		public static VectorOffset CreateActorVisibilityArrayVector(FlatBufferBuilder builder, Offset<IActorVisibility>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06034AC4 RID: 215748 RVA: 0x0071DDDC File Offset: 0x0071BFDC
		public static VectorOffset CreateActorVisibilityArrayVectorBlock(FlatBufferBuilder builder, Offset<IActorVisibility>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorVisibility>>(data);
			return builder.EndVector();
		}

		// Token: 0x06034AC5 RID: 215749 RVA: 0x0071DDF6 File Offset: 0x0071BFF6
		public static VectorOffset CreateActorVisibilityArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorVisibility>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorVisibility>>(data);
			return builder.EndVector();
		}

		// Token: 0x06034AC6 RID: 215750 RVA: 0x0071DE14 File Offset: 0x0071C014
		public static VectorOffset CreateActorVisibilityArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorVisibility>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06034AC7 RID: 215751 RVA: 0x0071DE2D File Offset: 0x0071C02D
		public static void StartActorVisibilityArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06034AC8 RID: 215752 RVA: 0x0071DE38 File Offset: 0x0071C038
		public static void AddStyleType(FlatBufferBuilder builder, TTalkItemStyle styleType)
		{
			builder.AddByte(37, (byte)styleType, 0);
		}

		// Token: 0x06034AC9 RID: 215753 RVA: 0x0071DE44 File Offset: 0x0071C044
		public static void AddStyle(FlatBufferBuilder builder, int styleOffset)
		{
			builder.AddOffset(38, styleOffset, 0);
		}

		// Token: 0x06034ACA RID: 215754 RVA: 0x0071DE50 File Offset: 0x0071C050
		public static void AddCameraMotionType(FlatBufferBuilder builder, TShowTalkCameraMotion cameraMotionType)
		{
			builder.AddByte(39, (byte)cameraMotionType, 0);
		}

		// Token: 0x06034ACB RID: 215755 RVA: 0x0071DE5C File Offset: 0x0071C05C
		public static void AddCameraMotion(FlatBufferBuilder builder, int cameraMotionOffset)
		{
			builder.AddOffset(40, cameraMotionOffset, 0);
		}

		// Token: 0x06034ACC RID: 215756 RVA: 0x0071DE68 File Offset: 0x0071C068
		public static void AddAutoPlayConfig(FlatBufferBuilder builder, Offset<ITalkItemAutoPlayConfig> autoPlayConfigOffset)
		{
			builder.AddOffset(41, autoPlayConfigOffset.Value, 0);
		}

		// Token: 0x06034ACD RID: 215757 RVA: 0x0071DE79 File Offset: 0x0071C079
		public static void AddNoMouthAnim(FlatBufferBuilder builder, bool noMouthAnim)
		{
			builder.AddBool(42, noMouthAnim, false);
		}

		// Token: 0x06034ACE RID: 215758 RVA: 0x0071DE85 File Offset: 0x0071C085
		public static void AddOtherIsTypingDuration(FlatBufferBuilder builder, float otherIsTypingDuration)
		{
			builder.AddFloat(43, otherIsTypingDuration, 0.0);
		}

		// Token: 0x06034ACF RID: 215759 RVA: 0x0071DE99 File Offset: 0x0071C099
		public static void AddNullMask(FlatBufferBuilder builder, uint nullMask)
		{
			builder.AddUint(44, nullMask, 0U);
		}

		// Token: 0x06034AD0 RID: 215760 RVA: 0x0071DEA5 File Offset: 0x0071C0A5
		public static Offset<ITalkItemDialog> EndITalkItemDialog(FlatBufferBuilder builder)
		{
			return new Offset<ITalkItemDialog>(builder.EndTable());
		}

		// Token: 0x06034AD1 RID: 215761 RVA: 0x0071DEB4 File Offset: 0x0071C0B4
		public ITalkItemDialogT UnPack()
		{
			ITalkItemDialogT talkItemDialogT = new ITalkItemDialogT();
			this.UnPackTo(talkItemDialogT);
			return talkItemDialogT;
		}

		// Token: 0x06034AD2 RID: 215762 RVA: 0x0071DED0 File Offset: 0x0071C0D0
		public void UnPackTo(ITalkItemDialogT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.PlotLineId = this.PlotLineId;
			_o.PlotLineKey = this.PlotLineKey;
			_o.Name = this.Name;
			_o._Folded = this._Folded;
			_o._EditFlag = this._EditFlag;
			_o.WhoId = this.WhoId;
			_o.TextId = this.TextId;
			_o.TidTalk = this.TidTalk;
			_o.WaitTime = this.WaitTime;
			_o.CaptionParams = ((this.CaptionParams != null) ? this.CaptionParams.Value.UnPack() : null);
			_o.Actions = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionsLength; i++)
			{
				_o.Actions.Add((this.Actions(i) != null) ? this.Actions(i).Value.UnPack() : null);
			}
			_o.Options = new List<ITalkOptionT>();
			for (int j = 0; j < this.OptionsLength; j++)
			{
				_o.Options.Add((this.Options(j) != null) ? this.Options(j).Value.UnPack() : null);
			}
			_o.Montage = ((this.Montage != null) ? this.Montage.Value.UnPack() : null);
			_o.CameraData = ((this.CameraData != null) ? this.CameraData.Value.UnPack() : null);
			_o.FlowTemplate = ((this.FlowTemplate != null) ? this.FlowTemplate.Value.UnPack() : null);
			_o.FlowTemplateList = new List<ISetFlowTemplateT>();
			for (int k = 0; k < this.FlowTemplateListLength; k++)
			{
				_o.FlowTemplateList.Add((this.FlowTemplateList(k) != null) ? this.FlowTemplateList(k).Value.UnPack() : null);
			}
			_o.ActorMontageArray = new List<IMontageDataT>();
			for (int l = 0; l < this.ActorMontageArrayLength; l++)
			{
				_o.ActorMontageArray.Add((this.ActorMontageArray(l) != null) ? this.ActorMontageArray(l).Value.UnPack() : null);
			}
			_o.ActorFaceExpressionArray = new List<IActorFaceExpressionT>();
			for (int m = 0; m < this.ActorFaceExpressionArrayLength; m++)
			{
				_o.ActorFaceExpressionArray.Add((this.ActorFaceExpressionArray(m) != null) ? this.ActorFaceExpressionArray(m).Value.UnPack() : null);
			}
			_o.ActorLookAtArray = new List<IActorLookAtT>();
			for (int n = 0; n < this.ActorLookAtArrayLength; n++)
			{
				_o.ActorLookAtArray.Add((this.ActorLookAtArray(n) != null) ? this.ActorLookAtArray(n).Value.UnPack() : null);
			}
			_o.ActorTurnToArray = new List<IActorTurnToT>();
			for (int num = 0; num < this.ActorTurnToArrayLength; num++)
			{
				_o.ActorTurnToArray.Add((this.ActorTurnToArray(num) != null) ? this.ActorTurnToArray(num).Value.UnPack() : null);
			}
			_o.TalkAkEvent = new TPostAkEventUnion();
			_o.TalkAkEvent.Type = this.TalkAkEventType;
			switch (this.TalkAkEventType)
			{
			case TPostAkEvent.IPostAkEventGlobal:
				_o.TalkAkEvent.Value = ((this.TalkAkEvent<IPostAkEventGlobal>() != null) ? this.TalkAkEvent<IPostAkEventGlobal>().Value.UnPack() : null);
				break;
			case TPostAkEvent.IPostAkEventMap:
				_o.TalkAkEvent.Value = ((this.TalkAkEvent<IPostAkEventMap>() != null) ? this.TalkAkEvent<IPostAkEventMap>().Value.UnPack() : null);
				break;
			case TPostAkEvent.IPostAkEventMusicSubtitle:
				_o.TalkAkEvent.Value = ((this.TalkAkEvent<IPostAkEventMusicSubtitle>() != null) ? this.TalkAkEvent<IPostAkEventMusicSubtitle>().Value.UnPack() : null);
				break;
			case TPostAkEvent.IPostAkEventTargeted:
				_o.TalkAkEvent.Value = ((this.TalkAkEvent<IPostAkEventTargeted>() != null) ? this.TalkAkEvent<IPostAkEventTargeted>().Value.UnPack() : null);
				break;
			}
			_o.TalkEndAkEvent = new TPostAkEventUnion();
			_o.TalkEndAkEvent.Type = this.TalkEndAkEventType;
			switch (this.TalkEndAkEventType)
			{
			case TPostAkEvent.IPostAkEventGlobal:
				_o.TalkEndAkEvent.Value = ((this.TalkEndAkEvent<IPostAkEventGlobal>() != null) ? this.TalkEndAkEvent<IPostAkEventGlobal>().Value.UnPack() : null);
				break;
			case TPostAkEvent.IPostAkEventMap:
				_o.TalkEndAkEvent.Value = ((this.TalkEndAkEvent<IPostAkEventMap>() != null) ? this.TalkEndAkEvent<IPostAkEventMap>().Value.UnPack() : null);
				break;
			case TPostAkEvent.IPostAkEventMusicSubtitle:
				_o.TalkEndAkEvent.Value = ((this.TalkEndAkEvent<IPostAkEventMusicSubtitle>() != null) ? this.TalkEndAkEvent<IPostAkEventMusicSubtitle>().Value.UnPack() : null);
				break;
			case TPostAkEvent.IPostAkEventTargeted:
				_o.TalkEndAkEvent.Value = ((this.TalkEndAkEvent<IPostAkEventTargeted>() != null) ? this.TalkEndAkEvent<IPostAkEventTargeted>().Value.UnPack() : null);
				break;
			}
			_o.UniversalTone = ((this.UniversalTone != null) ? this.UniversalTone.Value.UnPack() : null);
			_o.BackgroundConfig = new TTalkBackgroundUnion();
			_o.BackgroundConfig.Type = this.BackgroundConfigType;
			switch (this.BackgroundConfigType)
			{
			case TTalkBackground.ITalkBackgroundClean:
				_o.BackgroundConfig.Value = ((this.BackgroundConfig<ITalkBackgroundClean>() != null) ? this.BackgroundConfig<ITalkBackgroundClean>().Value.UnPack() : null);
				break;
			case TTalkBackground.ITalkBackgroundIcon:
				_o.BackgroundConfig.Value = ((this.BackgroundConfig<ITalkBackgroundIcon>() != null) ? this.BackgroundConfig<ITalkBackgroundIcon>().Value.UnPack() : null);
				break;
			case TTalkBackground.ITalkBackgroundImage:
				_o.BackgroundConfig.Value = ((this.BackgroundConfig<ITalkBackgroundImage>() != null) ? this.BackgroundConfig<ITalkBackgroundImage>().Value.UnPack() : null);
				break;
			case TTalkBackground.ITalkBackgroundImageByMcGender:
				_o.BackgroundConfig.Value = ((this.BackgroundConfig<ITalkBackgroundImageByMcGender>() != null) ? this.BackgroundConfig<ITalkBackgroundImageByMcGender>().Value.UnPack() : null);
				break;
			case TTalkBackground.ITalkBackgroundSpineImage:
				_o.BackgroundConfig.Value = ((this.BackgroundConfig<ITalkBackgroundSpineImage>() != null) ? this.BackgroundConfig<ITalkBackgroundSpineImage>().Value.UnPack() : null);
				break;
			}
			_o.PlayVoice = this.PlayVoice;
			_o.TimeLimitOptionGroup = ((this.TimeLimitOptionGroup != null) ? this.TimeLimitOptionGroup.Value.UnPack() : null);
			_o.GamepadShake = ((this.GamepadShake != null) ? this.GamepadShake.Value.UnPack() : null);
			_o.IntroActions = new List<IActionInfoT>();
			for (int num2 = 0; num2 < this.IntroActionsLength; num2++)
			{
				_o.IntroActions.Add((this.IntroActions(num2) != null) ? this.IntroActions(num2).Value.UnPack() : null);
			}
			_o.ActorFxEmoteArray = new List<IActorFxEmoteT>();
			for (int num3 = 0; num3 < this.ActorFxEmoteArrayLength; num3++)
			{
				_o.ActorFxEmoteArray.Add((this.ActorFxEmoteArray(num3) != null) ? this.ActorFxEmoteArray(num3).Value.UnPack() : null);
			}
			_o.TalkEffectArray = new List<TTalkEffectActionUnion>();
			for (int num4 = 0; num4 < this.TalkEffectArrayLength; num4++)
			{
				TTalkEffectActionUnion ttalkEffectActionUnion = new TTalkEffectActionUnion();
				ttalkEffectActionUnion.Type = this.TalkEffectArrayType(num4);
				TTalkEffectAction ttalkEffectAction = this.TalkEffectArrayType(num4);
				if (ttalkEffectAction != TTalkEffectAction.ITalkEffectPlay)
				{
					if (ttalkEffectAction == TTalkEffectAction.ITalkEffectStop)
					{
						ttalkEffectActionUnion.Value = ((this.TalkEffectArray<ITalkEffectStop>(num4) != null) ? this.TalkEffectArray<ITalkEffectStop>(num4).Value.UnPack() : null);
					}
				}
				else
				{
					ttalkEffectActionUnion.Value = ((this.TalkEffectArray<ITalkEffectPlay>(num4) != null) ? this.TalkEffectArray<ITalkEffectPlay>(num4).Value.UnPack() : null);
				}
				_o.TalkEffectArray.Add(ttalkEffectActionUnion);
			}
			_o.ActorVisibilityArray = new List<IActorVisibilityT>();
			for (int num5 = 0; num5 < this.ActorVisibilityArrayLength; num5++)
			{
				_o.ActorVisibilityArray.Add((this.ActorVisibilityArray(num5) != null) ? this.ActorVisibilityArray(num5).Value.UnPack() : null);
			}
			_o.Style = new TTalkItemStyleUnion();
			_o.Style.Type = this.StyleType;
			TTalkItemStyle styleType = this.StyleType;
			if (styleType != TTalkItemStyle.ITalkItemStyleInnerVoice)
			{
				if (styleType == TTalkItemStyle.ITalkItemStylePhoneSendError)
				{
					_o.Style.Value = ((this.Style<ITalkItemStylePhoneSendError>() != null) ? this.Style<ITalkItemStylePhoneSendError>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.Style.Value = ((this.Style<ITalkItemStyleInnerVoice>() != null) ? this.Style<ITalkItemStyleInnerVoice>().Value.UnPack() : null);
			}
			_o.CameraMotion = new TShowTalkCameraMotionUnion();
			_o.CameraMotion.Type = this.CameraMotionType;
			TShowTalkCameraMotion cameraMotionType = this.CameraMotionType;
			if (cameraMotionType != TShowTalkCameraMotion.IShowTalkCameraMotionPreset)
			{
				if (cameraMotionType == TShowTalkCameraMotion.IShowTalkCameraMotionTween)
				{
					_o.CameraMotion.Value = ((this.CameraMotion<IShowTalkCameraMotionTween>() != null) ? this.CameraMotion<IShowTalkCameraMotionTween>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.CameraMotion.Value = ((this.CameraMotion<IShowTalkCameraMotionPreset>() != null) ? this.CameraMotion<IShowTalkCameraMotionPreset>().Value.UnPack() : null);
			}
			_o.AutoPlayConfig = ((this.AutoPlayConfig != null) ? this.AutoPlayConfig.Value.UnPack() : null);
			_o.NoMouthAnim = this.NoMouthAnim;
			_o.OtherIsTypingDuration = this.OtherIsTypingDuration;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06034AD3 RID: 215763 RVA: 0x0071EA68 File Offset: 0x0071CC68
		public static Offset<ITalkItemDialog> Pack(FlatBufferBuilder builder, ITalkItemDialogT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkItemDialog>);
			}
			StringOffset plotLineKeyOffset = (_o.PlotLineKey == null) ? default(StringOffset) : builder.CreateString(_o.PlotLineKey);
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			StringOffset tidTalkOffset = (_o.TidTalk == null) ? default(StringOffset) : builder.CreateString(_o.TidTalk);
			Offset<ICaptionParam> captionParamsOffset = (_o.CaptionParams == null) ? default(Offset<ICaptionParam>) : ICaptionParam.Pack(builder, _o.CaptionParams);
			VectorOffset actionsOffset = default(VectorOffset);
			if (_o.Actions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.Actions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.Actions[i]);
				}
				actionsOffset = ITalkItemDialog.CreateActionsVector(builder, array);
			}
			VectorOffset optionsOffset = default(VectorOffset);
			if (_o.Options != null)
			{
				Offset<ITalkOption>[] array2 = new Offset<ITalkOption>[_o.Options.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = ITalkOption.Pack(builder, _o.Options[j]);
				}
				optionsOffset = ITalkItemDialog.CreateOptionsVector(builder, array2);
			}
			Offset<IPlayMontage> montageOffset = (_o.Montage == null) ? default(Offset<IPlayMontage>) : IPlayMontage.Pack(builder, _o.Montage);
			Offset<ICameraData> cameraDataOffset = (_o.CameraData == null) ? default(Offset<ICameraData>) : ICameraData.Pack(builder, _o.CameraData);
			Offset<ISetFlowTemplate> flowTemplateOffset = (_o.FlowTemplate == null) ? default(Offset<ISetFlowTemplate>) : ISetFlowTemplate.Pack(builder, _o.FlowTemplate);
			VectorOffset flowTemplateListOffset = default(VectorOffset);
			if (_o.FlowTemplateList != null)
			{
				Offset<ISetFlowTemplate>[] array3 = new Offset<ISetFlowTemplate>[_o.FlowTemplateList.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = ISetFlowTemplate.Pack(builder, _o.FlowTemplateList[k]);
				}
				flowTemplateListOffset = ITalkItemDialog.CreateFlowTemplateListVector(builder, array3);
			}
			VectorOffset actorMontageArrayOffset = default(VectorOffset);
			if (_o.ActorMontageArray != null)
			{
				Offset<IMontageData>[] array4 = new Offset<IMontageData>[_o.ActorMontageArray.Count];
				for (int l = 0; l < array4.Length; l++)
				{
					array4[l] = IMontageData.Pack(builder, _o.ActorMontageArray[l]);
				}
				actorMontageArrayOffset = ITalkItemDialog.CreateActorMontageArrayVector(builder, array4);
			}
			VectorOffset actorFaceExpressionArrayOffset = default(VectorOffset);
			if (_o.ActorFaceExpressionArray != null)
			{
				Offset<IActorFaceExpression>[] array5 = new Offset<IActorFaceExpression>[_o.ActorFaceExpressionArray.Count];
				for (int m = 0; m < array5.Length; m++)
				{
					array5[m] = IActorFaceExpression.Pack(builder, _o.ActorFaceExpressionArray[m]);
				}
				actorFaceExpressionArrayOffset = ITalkItemDialog.CreateActorFaceExpressionArrayVector(builder, array5);
			}
			VectorOffset actorLookAtArrayOffset = default(VectorOffset);
			if (_o.ActorLookAtArray != null)
			{
				Offset<IActorLookAt>[] array6 = new Offset<IActorLookAt>[_o.ActorLookAtArray.Count];
				for (int n = 0; n < array6.Length; n++)
				{
					array6[n] = IActorLookAt.Pack(builder, _o.ActorLookAtArray[n]);
				}
				actorLookAtArrayOffset = ITalkItemDialog.CreateActorLookAtArrayVector(builder, array6);
			}
			VectorOffset actorTurnToArrayOffset = default(VectorOffset);
			if (_o.ActorTurnToArray != null)
			{
				Offset<IActorTurnTo>[] array7 = new Offset<IActorTurnTo>[_o.ActorTurnToArray.Count];
				for (int num = 0; num < array7.Length; num++)
				{
					array7[num] = IActorTurnTo.Pack(builder, _o.ActorTurnToArray[num]);
				}
				actorTurnToArrayOffset = ITalkItemDialog.CreateActorTurnToArrayVector(builder, array7);
			}
			TPostAkEvent talkAkEvent_type = (_o.TalkAkEvent == null) ? TPostAkEvent.NONE : _o.TalkAkEvent.Type;
			int talkAkEventOffset = (_o.TalkAkEvent == null) ? 0 : TPostAkEventUnion.Pack(builder, _o.TalkAkEvent);
			TPostAkEvent talkEndAkEvent_type = (_o.TalkEndAkEvent == null) ? TPostAkEvent.NONE : _o.TalkEndAkEvent.Type;
			int talkEndAkEventOffset = (_o.TalkEndAkEvent == null) ? 0 : TPostAkEventUnion.Pack(builder, _o.TalkEndAkEvent);
			Offset<IUniversalTone> universalToneOffset = (_o.UniversalTone == null) ? default(Offset<IUniversalTone>) : IUniversalTone.Pack(builder, _o.UniversalTone);
			TTalkBackground backgroundConfig_type = (_o.BackgroundConfig == null) ? TTalkBackground.NONE : _o.BackgroundConfig.Type;
			int backgroundConfigOffset = (_o.BackgroundConfig == null) ? 0 : TTalkBackgroundUnion.Pack(builder, _o.BackgroundConfig);
			Offset<ITimeLimitOptionGroup> timeLimitOptionGroupOffset = (_o.TimeLimitOptionGroup == null) ? default(Offset<ITimeLimitOptionGroup>) : ITimeLimitOptionGroup.Pack(builder, _o.TimeLimitOptionGroup);
			Offset<IGamepadShakeInTalk> gamepadShakeOffset = (_o.GamepadShake == null) ? default(Offset<IGamepadShakeInTalk>) : IGamepadShakeInTalk.Pack(builder, _o.GamepadShake);
			VectorOffset introActionsOffset = default(VectorOffset);
			if (_o.IntroActions != null)
			{
				Offset<IActionInfo>[] array8 = new Offset<IActionInfo>[_o.IntroActions.Count];
				for (int num2 = 0; num2 < array8.Length; num2++)
				{
					array8[num2] = IActionInfo.Pack(builder, _o.IntroActions[num2]);
				}
				introActionsOffset = ITalkItemDialog.CreateIntroActionsVector(builder, array8);
			}
			VectorOffset actorFxEmoteArrayOffset = default(VectorOffset);
			if (_o.ActorFxEmoteArray != null)
			{
				Offset<IActorFxEmote>[] array9 = new Offset<IActorFxEmote>[_o.ActorFxEmoteArray.Count];
				for (int num3 = 0; num3 < array9.Length; num3++)
				{
					array9[num3] = IActorFxEmote.Pack(builder, _o.ActorFxEmoteArray[num3]);
				}
				actorFxEmoteArrayOffset = ITalkItemDialog.CreateActorFxEmoteArrayVector(builder, array9);
			}
			VectorOffset talkEffectArray_typeOffset = default(VectorOffset);
			if (_o.TalkEffectArray != null)
			{
				TTalkEffectAction[] array10 = new TTalkEffectAction[_o.TalkEffectArray.Count];
				for (int num4 = 0; num4 < array10.Length; num4++)
				{
					array10[num4] = _o.TalkEffectArray[num4].Type;
				}
				talkEffectArray_typeOffset = ITalkItemDialog.CreateTalkEffectArrayTypeVector(builder, array10);
			}
			VectorOffset talkEffectArrayOffset = default(VectorOffset);
			if (_o.TalkEffectArray != null)
			{
				int[] array11 = new int[_o.TalkEffectArray.Count];
				for (int num5 = 0; num5 < array11.Length; num5++)
				{
					array11[num5] = TTalkEffectActionUnion.Pack(builder, _o.TalkEffectArray[num5]);
				}
				talkEffectArrayOffset = ITalkItemDialog.CreateTalkEffectArrayVector(builder, array11);
			}
			VectorOffset actorVisibilityArrayOffset = default(VectorOffset);
			if (_o.ActorVisibilityArray != null)
			{
				Offset<IActorVisibility>[] array12 = new Offset<IActorVisibility>[_o.ActorVisibilityArray.Count];
				for (int num6 = 0; num6 < array12.Length; num6++)
				{
					array12[num6] = IActorVisibility.Pack(builder, _o.ActorVisibilityArray[num6]);
				}
				actorVisibilityArrayOffset = ITalkItemDialog.CreateActorVisibilityArrayVector(builder, array12);
			}
			TTalkItemStyle style_type = (_o.Style == null) ? TTalkItemStyle.NONE : _o.Style.Type;
			int styleOffset = (_o.Style == null) ? 0 : TTalkItemStyleUnion.Pack(builder, _o.Style);
			TShowTalkCameraMotion cameraMotion_type = (_o.CameraMotion == null) ? TShowTalkCameraMotion.NONE : _o.CameraMotion.Type;
			int cameraMotionOffset = (_o.CameraMotion == null) ? 0 : TShowTalkCameraMotionUnion.Pack(builder, _o.CameraMotion);
			Offset<ITalkItemAutoPlayConfig> autoPlayConfigOffset = (_o.AutoPlayConfig == null) ? default(Offset<ITalkItemAutoPlayConfig>) : ITalkItemAutoPlayConfig.Pack(builder, _o.AutoPlayConfig);
			return ITalkItemDialog.CreateITalkItemDialog(builder, _o.Type, _o.Id, _o.PlotLineId, plotLineKeyOffset, nameOffset, _o._Folded, _o._EditFlag, _o.WhoId, _o.TextId, tidTalkOffset, _o.WaitTime, captionParamsOffset, actionsOffset, optionsOffset, montageOffset, cameraDataOffset, flowTemplateOffset, flowTemplateListOffset, actorMontageArrayOffset, actorFaceExpressionArrayOffset, actorLookAtArrayOffset, actorTurnToArrayOffset, talkAkEvent_type, talkAkEventOffset, talkEndAkEvent_type, talkEndAkEventOffset, universalToneOffset, backgroundConfig_type, backgroundConfigOffset, _o.PlayVoice, timeLimitOptionGroupOffset, gamepadShakeOffset, introActionsOffset, actorFxEmoteArrayOffset, talkEffectArray_typeOffset, talkEffectArrayOffset, actorVisibilityArrayOffset, style_type, styleOffset, cameraMotion_type, cameraMotionOffset, autoPlayConfigOffset, _o.NoMouthAnim, _o.OtherIsTypingDuration, _o.NullMask);
		}

		// Token: 0x04011F05 RID: 73477
		private Table __p;
	}
}
