using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FEF RID: 28655
	public struct ISetFlowTemplate : IFlatbufferObject
	{
		// Token: 0x1700D4C6 RID: 54470
		// (get) Token: 0x06032AAE RID: 207534 RVA: 0x006D5D4F File Offset: 0x006D3F4F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032AAF RID: 207535 RVA: 0x006D5D5C File Offset: 0x006D3F5C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032AB0 RID: 207536 RVA: 0x006D5D64 File Offset: 0x006D3F64
		public static ISetFlowTemplate GetRootAsISetFlowTemplate(ByteBuffer _bb)
		{
			return ISetFlowTemplate.GetRootAsISetFlowTemplate(_bb, default(ISetFlowTemplate));
		}

		// Token: 0x06032AB1 RID: 207537 RVA: 0x006D5D80 File Offset: 0x006D3F80
		public static ISetFlowTemplate GetRootAsISetFlowTemplate(ByteBuffer _bb, ISetFlowTemplate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032AB2 RID: 207538 RVA: 0x006D5D9D File Offset: 0x006D3F9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032AB3 RID: 207539 RVA: 0x006D5DAC File Offset: 0x006D3FAC
		public ISetFlowTemplate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D4C7 RID: 54471
		// (get) Token: 0x06032AB4 RID: 207540 RVA: 0x006D5DBC File Offset: 0x006D3FBC
		public bool _Folded
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D4C8 RID: 54472
		// (get) Token: 0x06032AB5 RID: 207541 RVA: 0x006D5DFC File Offset: 0x006D3FFC
		public IFlowTemplateMode? TemplateMode
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IFlowTemplateMode?(default(IFlowTemplateMode).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D4C9 RID: 54473
		// (get) Token: 0x06032AB6 RID: 207542 RVA: 0x006D5E5C File Offset: 0x006D405C
		public IPosAndRot? TargetPos
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IPosAndRot?(default(IPosAndRot).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D4CA RID: 54474
		// (get) Token: 0x06032AB7 RID: 207543 RVA: 0x006D5EBC File Offset: 0x006D40BC
		public ISetCameraAnim? CameraAnim
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new ISetCameraAnim?(default(ISetCameraAnim).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D4CB RID: 54475
		// (get) Token: 0x06032AB8 RID: 207544 RVA: 0x006D5F1C File Offset: 0x006D411C
		public IVectorInfo? CameraOffset
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D4CC RID: 54476
		// (get) Token: 0x06032AB9 RID: 207545 RVA: 0x006D5F7C File Offset: 0x006D417C
		public IVectorInfo? CameraRotate
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D4CD RID: 54477
		// (get) Token: 0x06032ABA RID: 207546 RVA: 0x006D5FDC File Offset: 0x006D41DC
		public ICameraPosAndRot? CameraPosAndRot
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new ICameraPosAndRot?(default(ICameraPosAndRot).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D4CE RID: 54478
		// (get) Token: 0x06032ABB RID: 207547 RVA: 0x006D603C File Offset: 0x006D423C
		public ICameraSetting? CameraSetting
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return new ICameraSetting?(default(ICameraSetting).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D4CF RID: 54479
		// (get) Token: 0x06032ABC RID: 207548 RVA: 0x006D609C File Offset: 0x006D429C
		public TShowTalkCameraMotion CameraMotionType
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return TShowTalkCameraMotion.NONE;
				}
				return (TShowTalkCameraMotion)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032ABD RID: 207549 RVA: 0x006D60DC File Offset: 0x006D42DC
		public TTable? CameraMotion<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06032ABE RID: 207550 RVA: 0x006D6124 File Offset: 0x006D4324
		public IShowTalkCameraMotionPreset CameraMotionAsIShowTalkCameraMotionPreset()
		{
			return this.CameraMotion<IShowTalkCameraMotionPreset>().Value;
		}

		// Token: 0x06032ABF RID: 207551 RVA: 0x006D6140 File Offset: 0x006D4340
		public IShowTalkCameraMotionTween CameraMotionAsIShowTalkCameraMotionTween()
		{
			return this.CameraMotion<IShowTalkCameraMotionTween>().Value;
		}

		// Token: 0x1700D4D0 RID: 54480
		// (get) Token: 0x06032AC0 RID: 207552 RVA: 0x006D615C File Offset: 0x006D435C
		public IFlowTemplateBlurTransitionEffect? TransitionEffect
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return new IFlowTemplateBlurTransitionEffect?(default(IFlowTemplateBlurTransitionEffect).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06032AC1 RID: 207553 RVA: 0x006D61BC File Offset: 0x006D43BC
		public IFlowActorIndexData? ActorIndexArray(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return new IFlowActorIndexData?(default(IFlowActorIndexData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D4D1 RID: 54481
		// (get) Token: 0x06032AC2 RID: 207554 RVA: 0x006D6220 File Offset: 0x006D4420
		public int ActorIndexArrayLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06032AC3 RID: 207555 RVA: 0x006D624C File Offset: 0x006D444C
		public IFlowTemplateInitialLookAt? InitialLookAtArray(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return new IFlowTemplateInitialLookAt?(default(IFlowTemplateInitialLookAt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D4D2 RID: 54482
		// (get) Token: 0x06032AC4 RID: 207556 RVA: 0x006D62B0 File Offset: 0x006D44B0
		public int InitialLookAtArrayLength
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

		// Token: 0x06032AC5 RID: 207557 RVA: 0x006D62DC File Offset: 0x006D44DC
		public IActorVisibility? ActorVisibilityArray(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return new IActorVisibility?(default(IActorVisibility).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D4D3 RID: 54483
		// (get) Token: 0x06032AC6 RID: 207558 RVA: 0x006D6340 File Offset: 0x006D4540
		public int ActorVisibilityArrayLength
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

		// Token: 0x1700D4D4 RID: 54484
		// (get) Token: 0x06032AC7 RID: 207559 RVA: 0x006D636C File Offset: 0x006D456C
		public float DelayTime
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D4D5 RID: 54485
		// (get) Token: 0x06032AC8 RID: 207560 RVA: 0x006D63B0 File Offset: 0x006D45B0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032AC9 RID: 207561 RVA: 0x006D63F0 File Offset: 0x006D45F0
		public static Offset<ISetFlowTemplate> CreateISetFlowTemplate(FlatBufferBuilder builder, bool _folded = false, Offset<IFlowTemplateMode> TemplateModeOffset = default(Offset<IFlowTemplateMode>), Offset<IPosAndRot> TargetPosOffset = default(Offset<IPosAndRot>), Offset<ISetCameraAnim> CameraAnimOffset = default(Offset<ISetCameraAnim>), Offset<IVectorInfo> CameraOffsetOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> CameraRotateOffset = default(Offset<IVectorInfo>), Offset<ICameraPosAndRot> CameraPosAndRotOffset = default(Offset<ICameraPosAndRot>), Offset<ICameraSetting> CameraSettingOffset = default(Offset<ICameraSetting>), TShowTalkCameraMotion CameraMotion_type = TShowTalkCameraMotion.NONE, int CameraMotionOffset = 0, Offset<IFlowTemplateBlurTransitionEffect> TransitionEffectOffset = default(Offset<IFlowTemplateBlurTransitionEffect>), VectorOffset ActorIndexArrayOffset = default(VectorOffset), VectorOffset InitialLookAtArrayOffset = default(VectorOffset), VectorOffset ActorVisibilityArrayOffset = default(VectorOffset), float DelayTime = 0f, byte NullMask = 0)
		{
			builder.StartTable(16);
			ISetFlowTemplate.AddDelayTime(builder, DelayTime);
			ISetFlowTemplate.AddActorVisibilityArray(builder, ActorVisibilityArrayOffset);
			ISetFlowTemplate.AddInitialLookAtArray(builder, InitialLookAtArrayOffset);
			ISetFlowTemplate.AddActorIndexArray(builder, ActorIndexArrayOffset);
			ISetFlowTemplate.AddTransitionEffect(builder, TransitionEffectOffset);
			ISetFlowTemplate.AddCameraMotion(builder, CameraMotionOffset);
			ISetFlowTemplate.AddCameraSetting(builder, CameraSettingOffset);
			ISetFlowTemplate.AddCameraPosAndRot(builder, CameraPosAndRotOffset);
			ISetFlowTemplate.AddCameraRotate(builder, CameraRotateOffset);
			ISetFlowTemplate.AddCameraOffset(builder, CameraOffsetOffset);
			ISetFlowTemplate.AddCameraAnim(builder, CameraAnimOffset);
			ISetFlowTemplate.AddTargetPos(builder, TargetPosOffset);
			ISetFlowTemplate.AddTemplateMode(builder, TemplateModeOffset);
			ISetFlowTemplate.AddNullMask(builder, NullMask);
			ISetFlowTemplate.AddCameraMotionType(builder, CameraMotion_type);
			ISetFlowTemplate.Add_Folded(builder, _folded);
			return ISetFlowTemplate.EndISetFlowTemplate(builder);
		}

		// Token: 0x06032ACA RID: 207562 RVA: 0x006D6488 File Offset: 0x006D4688
		public static void StartISetFlowTemplate(FlatBufferBuilder builder)
		{
			builder.StartTable(16);
		}

		// Token: 0x06032ACB RID: 207563 RVA: 0x006D6492 File Offset: 0x006D4692
		public static void Add_Folded(FlatBufferBuilder builder, bool _Folded)
		{
			builder.AddBool(0, _Folded, false);
		}

		// Token: 0x06032ACC RID: 207564 RVA: 0x006D649D File Offset: 0x006D469D
		public static void AddTemplateMode(FlatBufferBuilder builder, Offset<IFlowTemplateMode> templateModeOffset)
		{
			builder.AddOffset(1, templateModeOffset.Value, 0);
		}

		// Token: 0x06032ACD RID: 207565 RVA: 0x006D64AD File Offset: 0x006D46AD
		public static void AddTargetPos(FlatBufferBuilder builder, Offset<IPosAndRot> targetPosOffset)
		{
			builder.AddOffset(2, targetPosOffset.Value, 0);
		}

		// Token: 0x06032ACE RID: 207566 RVA: 0x006D64BD File Offset: 0x006D46BD
		public static void AddCameraAnim(FlatBufferBuilder builder, Offset<ISetCameraAnim> cameraAnimOffset)
		{
			builder.AddOffset(3, cameraAnimOffset.Value, 0);
		}

		// Token: 0x06032ACF RID: 207567 RVA: 0x006D64CD File Offset: 0x006D46CD
		public static void AddCameraOffset(FlatBufferBuilder builder, Offset<IVectorInfo> cameraOffsetOffset)
		{
			builder.AddOffset(4, cameraOffsetOffset.Value, 0);
		}

		// Token: 0x06032AD0 RID: 207568 RVA: 0x006D64DD File Offset: 0x006D46DD
		public static void AddCameraRotate(FlatBufferBuilder builder, Offset<IVectorInfo> cameraRotateOffset)
		{
			builder.AddOffset(5, cameraRotateOffset.Value, 0);
		}

		// Token: 0x06032AD1 RID: 207569 RVA: 0x006D64ED File Offset: 0x006D46ED
		public static void AddCameraPosAndRot(FlatBufferBuilder builder, Offset<ICameraPosAndRot> cameraPosAndRotOffset)
		{
			builder.AddOffset(6, cameraPosAndRotOffset.Value, 0);
		}

		// Token: 0x06032AD2 RID: 207570 RVA: 0x006D64FD File Offset: 0x006D46FD
		public static void AddCameraSetting(FlatBufferBuilder builder, Offset<ICameraSetting> cameraSettingOffset)
		{
			builder.AddOffset(7, cameraSettingOffset.Value, 0);
		}

		// Token: 0x06032AD3 RID: 207571 RVA: 0x006D650D File Offset: 0x006D470D
		public static void AddCameraMotionType(FlatBufferBuilder builder, TShowTalkCameraMotion cameraMotionType)
		{
			builder.AddByte(8, (byte)cameraMotionType, 0);
		}

		// Token: 0x06032AD4 RID: 207572 RVA: 0x006D6518 File Offset: 0x006D4718
		public static void AddCameraMotion(FlatBufferBuilder builder, int cameraMotionOffset)
		{
			builder.AddOffset(9, cameraMotionOffset, 0);
		}

		// Token: 0x06032AD5 RID: 207573 RVA: 0x006D6524 File Offset: 0x006D4724
		public static void AddTransitionEffect(FlatBufferBuilder builder, Offset<IFlowTemplateBlurTransitionEffect> transitionEffectOffset)
		{
			builder.AddOffset(10, transitionEffectOffset.Value, 0);
		}

		// Token: 0x06032AD6 RID: 207574 RVA: 0x006D6535 File Offset: 0x006D4735
		public static void AddActorIndexArray(FlatBufferBuilder builder, VectorOffset actorIndexArrayOffset)
		{
			builder.AddOffset(11, actorIndexArrayOffset.Value, 0);
		}

		// Token: 0x06032AD7 RID: 207575 RVA: 0x006D6548 File Offset: 0x006D4748
		public static VectorOffset CreateActorIndexArrayVector(FlatBufferBuilder builder, Offset<IFlowActorIndexData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06032AD8 RID: 207576 RVA: 0x006D6588 File Offset: 0x006D4788
		public static VectorOffset CreateActorIndexArrayVectorBlock(FlatBufferBuilder builder, Offset<IFlowActorIndexData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IFlowActorIndexData>>(data);
			return builder.EndVector();
		}

		// Token: 0x06032AD9 RID: 207577 RVA: 0x006D65A2 File Offset: 0x006D47A2
		public static VectorOffset CreateActorIndexArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IFlowActorIndexData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IFlowActorIndexData>>(data);
			return builder.EndVector();
		}

		// Token: 0x06032ADA RID: 207578 RVA: 0x006D65C0 File Offset: 0x006D47C0
		public static VectorOffset CreateActorIndexArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IFlowActorIndexData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06032ADB RID: 207579 RVA: 0x006D65D9 File Offset: 0x006D47D9
		public static void StartActorIndexArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06032ADC RID: 207580 RVA: 0x006D65E4 File Offset: 0x006D47E4
		public static void AddInitialLookAtArray(FlatBufferBuilder builder, VectorOffset initialLookAtArrayOffset)
		{
			builder.AddOffset(12, initialLookAtArrayOffset.Value, 0);
		}

		// Token: 0x06032ADD RID: 207581 RVA: 0x006D65F8 File Offset: 0x006D47F8
		public static VectorOffset CreateInitialLookAtArrayVector(FlatBufferBuilder builder, Offset<IFlowTemplateInitialLookAt>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06032ADE RID: 207582 RVA: 0x006D6638 File Offset: 0x006D4838
		public static VectorOffset CreateInitialLookAtArrayVectorBlock(FlatBufferBuilder builder, Offset<IFlowTemplateInitialLookAt>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IFlowTemplateInitialLookAt>>(data);
			return builder.EndVector();
		}

		// Token: 0x06032ADF RID: 207583 RVA: 0x006D6652 File Offset: 0x006D4852
		public static VectorOffset CreateInitialLookAtArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IFlowTemplateInitialLookAt>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IFlowTemplateInitialLookAt>>(data);
			return builder.EndVector();
		}

		// Token: 0x06032AE0 RID: 207584 RVA: 0x006D6670 File Offset: 0x006D4870
		public static VectorOffset CreateInitialLookAtArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IFlowTemplateInitialLookAt>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06032AE1 RID: 207585 RVA: 0x006D6689 File Offset: 0x006D4889
		public static void StartInitialLookAtArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06032AE2 RID: 207586 RVA: 0x006D6694 File Offset: 0x006D4894
		public static void AddActorVisibilityArray(FlatBufferBuilder builder, VectorOffset actorVisibilityArrayOffset)
		{
			builder.AddOffset(13, actorVisibilityArrayOffset.Value, 0);
		}

		// Token: 0x06032AE3 RID: 207587 RVA: 0x006D66A8 File Offset: 0x006D48A8
		public static VectorOffset CreateActorVisibilityArrayVector(FlatBufferBuilder builder, Offset<IActorVisibility>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06032AE4 RID: 207588 RVA: 0x006D66E8 File Offset: 0x006D48E8
		public static VectorOffset CreateActorVisibilityArrayVectorBlock(FlatBufferBuilder builder, Offset<IActorVisibility>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorVisibility>>(data);
			return builder.EndVector();
		}

		// Token: 0x06032AE5 RID: 207589 RVA: 0x006D6702 File Offset: 0x006D4902
		public static VectorOffset CreateActorVisibilityArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorVisibility>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorVisibility>>(data);
			return builder.EndVector();
		}

		// Token: 0x06032AE6 RID: 207590 RVA: 0x006D6720 File Offset: 0x006D4920
		public static VectorOffset CreateActorVisibilityArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorVisibility>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06032AE7 RID: 207591 RVA: 0x006D6739 File Offset: 0x006D4939
		public static void StartActorVisibilityArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06032AE8 RID: 207592 RVA: 0x006D6744 File Offset: 0x006D4944
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(14, delayTime, 0.0);
		}

		// Token: 0x06032AE9 RID: 207593 RVA: 0x006D6758 File Offset: 0x006D4958
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(15, nullMask, 0);
		}

		// Token: 0x06032AEA RID: 207594 RVA: 0x006D6764 File Offset: 0x006D4964
		public static Offset<ISetFlowTemplate> EndISetFlowTemplate(FlatBufferBuilder builder)
		{
			return new Offset<ISetFlowTemplate>(builder.EndTable());
		}

		// Token: 0x06032AEB RID: 207595 RVA: 0x006D6774 File Offset: 0x006D4974
		public ISetFlowTemplateT UnPack()
		{
			ISetFlowTemplateT setFlowTemplateT = new ISetFlowTemplateT();
			this.UnPackTo(setFlowTemplateT);
			return setFlowTemplateT;
		}

		// Token: 0x06032AEC RID: 207596 RVA: 0x006D6790 File Offset: 0x006D4990
		public void UnPackTo(ISetFlowTemplateT _o)
		{
			_o._Folded = this._Folded;
			_o.TemplateMode = ((this.TemplateMode != null) ? this.TemplateMode.Value.UnPack() : null);
			_o.TargetPos = ((this.TargetPos != null) ? this.TargetPos.Value.UnPack() : null);
			_o.CameraAnim = ((this.CameraAnim != null) ? this.CameraAnim.Value.UnPack() : null);
			_o.CameraOffset = ((this.CameraOffset != null) ? this.CameraOffset.Value.UnPack() : null);
			_o.CameraRotate = ((this.CameraRotate != null) ? this.CameraRotate.Value.UnPack() : null);
			_o.CameraPosAndRot = ((this.CameraPosAndRot != null) ? this.CameraPosAndRot.Value.UnPack() : null);
			_o.CameraSetting = ((this.CameraSetting != null) ? this.CameraSetting.Value.UnPack() : null);
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
			_o.TransitionEffect = ((this.TransitionEffect != null) ? this.TransitionEffect.Value.UnPack() : null);
			_o.ActorIndexArray = new List<IFlowActorIndexDataT>();
			for (int i = 0; i < this.ActorIndexArrayLength; i++)
			{
				_o.ActorIndexArray.Add((this.ActorIndexArray(i) != null) ? this.ActorIndexArray(i).Value.UnPack() : null);
			}
			_o.InitialLookAtArray = new List<IFlowTemplateInitialLookAtT>();
			for (int j = 0; j < this.InitialLookAtArrayLength; j++)
			{
				_o.InitialLookAtArray.Add((this.InitialLookAtArray(j) != null) ? this.InitialLookAtArray(j).Value.UnPack() : null);
			}
			_o.ActorVisibilityArray = new List<IActorVisibilityT>();
			for (int k = 0; k < this.ActorVisibilityArrayLength; k++)
			{
				_o.ActorVisibilityArray.Add((this.ActorVisibilityArray(k) != null) ? this.ActorVisibilityArray(k).Value.UnPack() : null);
			}
			_o.DelayTime = this.DelayTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06032AED RID: 207597 RVA: 0x006D6AFC File Offset: 0x006D4CFC
		public static Offset<ISetFlowTemplate> Pack(FlatBufferBuilder builder, ISetFlowTemplateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetFlowTemplate>);
			}
			Offset<IFlowTemplateMode> templateModeOffset = (_o.TemplateMode == null) ? default(Offset<IFlowTemplateMode>) : IFlowTemplateMode.Pack(builder, _o.TemplateMode);
			Offset<IPosAndRot> targetPosOffset = (_o.TargetPos == null) ? default(Offset<IPosAndRot>) : IPosAndRot.Pack(builder, _o.TargetPos);
			Offset<ISetCameraAnim> cameraAnimOffset = (_o.CameraAnim == null) ? default(Offset<ISetCameraAnim>) : ISetCameraAnim.Pack(builder, _o.CameraAnim);
			Offset<IVectorInfo> cameraOffsetOffset = (_o.CameraOffset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.CameraOffset);
			Offset<IVectorInfo> cameraRotateOffset = (_o.CameraRotate == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.CameraRotate);
			Offset<ICameraPosAndRot> cameraPosAndRotOffset = (_o.CameraPosAndRot == null) ? default(Offset<ICameraPosAndRot>) : ICameraPosAndRot.Pack(builder, _o.CameraPosAndRot);
			Offset<ICameraSetting> cameraSettingOffset = (_o.CameraSetting == null) ? default(Offset<ICameraSetting>) : ICameraSetting.Pack(builder, _o.CameraSetting);
			TShowTalkCameraMotion cameraMotion_type = (_o.CameraMotion == null) ? TShowTalkCameraMotion.NONE : _o.CameraMotion.Type;
			int cameraMotionOffset = (_o.CameraMotion == null) ? 0 : TShowTalkCameraMotionUnion.Pack(builder, _o.CameraMotion);
			Offset<IFlowTemplateBlurTransitionEffect> transitionEffectOffset = (_o.TransitionEffect == null) ? default(Offset<IFlowTemplateBlurTransitionEffect>) : IFlowTemplateBlurTransitionEffect.Pack(builder, _o.TransitionEffect);
			VectorOffset actorIndexArrayOffset = default(VectorOffset);
			if (_o.ActorIndexArray != null)
			{
				Offset<IFlowActorIndexData>[] array = new Offset<IFlowActorIndexData>[_o.ActorIndexArray.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IFlowActorIndexData.Pack(builder, _o.ActorIndexArray[i]);
				}
				actorIndexArrayOffset = ISetFlowTemplate.CreateActorIndexArrayVector(builder, array);
			}
			VectorOffset initialLookAtArrayOffset = default(VectorOffset);
			if (_o.InitialLookAtArray != null)
			{
				Offset<IFlowTemplateInitialLookAt>[] array2 = new Offset<IFlowTemplateInitialLookAt>[_o.InitialLookAtArray.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IFlowTemplateInitialLookAt.Pack(builder, _o.InitialLookAtArray[j]);
				}
				initialLookAtArrayOffset = ISetFlowTemplate.CreateInitialLookAtArrayVector(builder, array2);
			}
			VectorOffset actorVisibilityArrayOffset = default(VectorOffset);
			if (_o.ActorVisibilityArray != null)
			{
				Offset<IActorVisibility>[] array3 = new Offset<IActorVisibility>[_o.ActorVisibilityArray.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IActorVisibility.Pack(builder, _o.ActorVisibilityArray[k]);
				}
				actorVisibilityArrayOffset = ISetFlowTemplate.CreateActorVisibilityArrayVector(builder, array3);
			}
			return ISetFlowTemplate.CreateISetFlowTemplate(builder, _o._Folded, templateModeOffset, targetPosOffset, cameraAnimOffset, cameraOffsetOffset, cameraRotateOffset, cameraPosAndRotOffset, cameraSettingOffset, cameraMotion_type, cameraMotionOffset, transitionEffectOffset, actorIndexArrayOffset, initialLookAtArrayOffset, actorVisibilityArrayOffset, _o.DelayTime, _o.NullMask);
		}

		// Token: 0x04011A03 RID: 72195
		private Table __p;
	}
}
