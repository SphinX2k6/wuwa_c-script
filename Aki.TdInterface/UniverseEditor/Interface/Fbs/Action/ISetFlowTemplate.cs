using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077B8 RID: 30648
	public struct ISetFlowTemplate : IFlatbufferObject
	{
		// Token: 0x1700E09A RID: 57498
		// (get) Token: 0x06035D14 RID: 220436 RVA: 0x00735993 File Offset: 0x00733B93
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035D15 RID: 220437 RVA: 0x007359A0 File Offset: 0x00733BA0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035D16 RID: 220438 RVA: 0x007359A8 File Offset: 0x00733BA8
		public static ISetFlowTemplate GetRootAsISetFlowTemplate(ByteBuffer _bb)
		{
			return ISetFlowTemplate.GetRootAsISetFlowTemplate(_bb, default(ISetFlowTemplate));
		}

		// Token: 0x06035D17 RID: 220439 RVA: 0x007359C4 File Offset: 0x00733BC4
		public static ISetFlowTemplate GetRootAsISetFlowTemplate(ByteBuffer _bb, ISetFlowTemplate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035D18 RID: 220440 RVA: 0x007359E1 File Offset: 0x00733BE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035D19 RID: 220441 RVA: 0x007359F0 File Offset: 0x00733BF0
		public ISetFlowTemplate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E09B RID: 57499
		// (get) Token: 0x06035D1A RID: 220442 RVA: 0x00735A00 File Offset: 0x00733C00
		public bool _Folded
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E09C RID: 57500
		// (get) Token: 0x06035D1B RID: 220443 RVA: 0x00735A40 File Offset: 0x00733C40
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

		// Token: 0x1700E09D RID: 57501
		// (get) Token: 0x06035D1C RID: 220444 RVA: 0x00735AA0 File Offset: 0x00733CA0
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

		// Token: 0x1700E09E RID: 57502
		// (get) Token: 0x06035D1D RID: 220445 RVA: 0x00735B00 File Offset: 0x00733D00
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

		// Token: 0x1700E09F RID: 57503
		// (get) Token: 0x06035D1E RID: 220446 RVA: 0x00735B60 File Offset: 0x00733D60
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

		// Token: 0x1700E0A0 RID: 57504
		// (get) Token: 0x06035D1F RID: 220447 RVA: 0x00735BC0 File Offset: 0x00733DC0
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

		// Token: 0x1700E0A1 RID: 57505
		// (get) Token: 0x06035D20 RID: 220448 RVA: 0x00735C20 File Offset: 0x00733E20
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

		// Token: 0x1700E0A2 RID: 57506
		// (get) Token: 0x06035D21 RID: 220449 RVA: 0x00735C80 File Offset: 0x00733E80
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

		// Token: 0x1700E0A3 RID: 57507
		// (get) Token: 0x06035D22 RID: 220450 RVA: 0x00735CE0 File Offset: 0x00733EE0
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

		// Token: 0x06035D23 RID: 220451 RVA: 0x00735D20 File Offset: 0x00733F20
		public TTable? CameraMotion<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06035D24 RID: 220452 RVA: 0x00735D68 File Offset: 0x00733F68
		public IShowTalkCameraMotionPreset CameraMotionAsIShowTalkCameraMotionPreset()
		{
			return this.CameraMotion<IShowTalkCameraMotionPreset>().Value;
		}

		// Token: 0x06035D25 RID: 220453 RVA: 0x00735D84 File Offset: 0x00733F84
		public IShowTalkCameraMotionTween CameraMotionAsIShowTalkCameraMotionTween()
		{
			return this.CameraMotion<IShowTalkCameraMotionTween>().Value;
		}

		// Token: 0x1700E0A4 RID: 57508
		// (get) Token: 0x06035D26 RID: 220454 RVA: 0x00735DA0 File Offset: 0x00733FA0
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

		// Token: 0x06035D27 RID: 220455 RVA: 0x00735E00 File Offset: 0x00734000
		public IFlowActorIndexData? ActorIndexArray(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return new IFlowActorIndexData?(default(IFlowActorIndexData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700E0A5 RID: 57509
		// (get) Token: 0x06035D28 RID: 220456 RVA: 0x00735E64 File Offset: 0x00734064
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

		// Token: 0x06035D29 RID: 220457 RVA: 0x00735E90 File Offset: 0x00734090
		public IFlowTemplateInitialLookAt? InitialLookAtArray(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return new IFlowTemplateInitialLookAt?(default(IFlowTemplateInitialLookAt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700E0A6 RID: 57510
		// (get) Token: 0x06035D2A RID: 220458 RVA: 0x00735EF4 File Offset: 0x007340F4
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

		// Token: 0x06035D2B RID: 220459 RVA: 0x00735F20 File Offset: 0x00734120
		public IActorVisibility? ActorVisibilityArray(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return new IActorVisibility?(default(IActorVisibility).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700E0A7 RID: 57511
		// (get) Token: 0x06035D2C RID: 220460 RVA: 0x00735F84 File Offset: 0x00734184
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

		// Token: 0x1700E0A8 RID: 57512
		// (get) Token: 0x06035D2D RID: 220461 RVA: 0x00735FB0 File Offset: 0x007341B0
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

		// Token: 0x1700E0A9 RID: 57513
		// (get) Token: 0x06035D2E RID: 220462 RVA: 0x00735FF4 File Offset: 0x007341F4
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

		// Token: 0x06035D2F RID: 220463 RVA: 0x00736034 File Offset: 0x00734234
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

		// Token: 0x06035D30 RID: 220464 RVA: 0x007360CC File Offset: 0x007342CC
		public static void StartISetFlowTemplate(FlatBufferBuilder builder)
		{
			builder.StartTable(16);
		}

		// Token: 0x06035D31 RID: 220465 RVA: 0x007360D6 File Offset: 0x007342D6
		public static void Add_Folded(FlatBufferBuilder builder, bool _Folded)
		{
			builder.AddBool(0, _Folded, false);
		}

		// Token: 0x06035D32 RID: 220466 RVA: 0x007360E1 File Offset: 0x007342E1
		public static void AddTemplateMode(FlatBufferBuilder builder, Offset<IFlowTemplateMode> templateModeOffset)
		{
			builder.AddOffset(1, templateModeOffset.Value, 0);
		}

		// Token: 0x06035D33 RID: 220467 RVA: 0x007360F1 File Offset: 0x007342F1
		public static void AddTargetPos(FlatBufferBuilder builder, Offset<IPosAndRot> targetPosOffset)
		{
			builder.AddOffset(2, targetPosOffset.Value, 0);
		}

		// Token: 0x06035D34 RID: 220468 RVA: 0x00736101 File Offset: 0x00734301
		public static void AddCameraAnim(FlatBufferBuilder builder, Offset<ISetCameraAnim> cameraAnimOffset)
		{
			builder.AddOffset(3, cameraAnimOffset.Value, 0);
		}

		// Token: 0x06035D35 RID: 220469 RVA: 0x00736111 File Offset: 0x00734311
		public static void AddCameraOffset(FlatBufferBuilder builder, Offset<IVectorInfo> cameraOffsetOffset)
		{
			builder.AddOffset(4, cameraOffsetOffset.Value, 0);
		}

		// Token: 0x06035D36 RID: 220470 RVA: 0x00736121 File Offset: 0x00734321
		public static void AddCameraRotate(FlatBufferBuilder builder, Offset<IVectorInfo> cameraRotateOffset)
		{
			builder.AddOffset(5, cameraRotateOffset.Value, 0);
		}

		// Token: 0x06035D37 RID: 220471 RVA: 0x00736131 File Offset: 0x00734331
		public static void AddCameraPosAndRot(FlatBufferBuilder builder, Offset<ICameraPosAndRot> cameraPosAndRotOffset)
		{
			builder.AddOffset(6, cameraPosAndRotOffset.Value, 0);
		}

		// Token: 0x06035D38 RID: 220472 RVA: 0x00736141 File Offset: 0x00734341
		public static void AddCameraSetting(FlatBufferBuilder builder, Offset<ICameraSetting> cameraSettingOffset)
		{
			builder.AddOffset(7, cameraSettingOffset.Value, 0);
		}

		// Token: 0x06035D39 RID: 220473 RVA: 0x00736151 File Offset: 0x00734351
		public static void AddCameraMotionType(FlatBufferBuilder builder, TShowTalkCameraMotion cameraMotionType)
		{
			builder.AddByte(8, (byte)cameraMotionType, 0);
		}

		// Token: 0x06035D3A RID: 220474 RVA: 0x0073615C File Offset: 0x0073435C
		public static void AddCameraMotion(FlatBufferBuilder builder, int cameraMotionOffset)
		{
			builder.AddOffset(9, cameraMotionOffset, 0);
		}

		// Token: 0x06035D3B RID: 220475 RVA: 0x00736168 File Offset: 0x00734368
		public static void AddTransitionEffect(FlatBufferBuilder builder, Offset<IFlowTemplateBlurTransitionEffect> transitionEffectOffset)
		{
			builder.AddOffset(10, transitionEffectOffset.Value, 0);
		}

		// Token: 0x06035D3C RID: 220476 RVA: 0x00736179 File Offset: 0x00734379
		public static void AddActorIndexArray(FlatBufferBuilder builder, VectorOffset actorIndexArrayOffset)
		{
			builder.AddOffset(11, actorIndexArrayOffset.Value, 0);
		}

		// Token: 0x06035D3D RID: 220477 RVA: 0x0073618C File Offset: 0x0073438C
		public static VectorOffset CreateActorIndexArrayVector(FlatBufferBuilder builder, Offset<IFlowActorIndexData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06035D3E RID: 220478 RVA: 0x007361CC File Offset: 0x007343CC
		public static VectorOffset CreateActorIndexArrayVectorBlock(FlatBufferBuilder builder, Offset<IFlowActorIndexData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IFlowActorIndexData>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035D3F RID: 220479 RVA: 0x007361E6 File Offset: 0x007343E6
		public static VectorOffset CreateActorIndexArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IFlowActorIndexData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IFlowActorIndexData>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035D40 RID: 220480 RVA: 0x00736204 File Offset: 0x00734404
		public static VectorOffset CreateActorIndexArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IFlowActorIndexData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06035D41 RID: 220481 RVA: 0x0073621D File Offset: 0x0073441D
		public static void StartActorIndexArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06035D42 RID: 220482 RVA: 0x00736228 File Offset: 0x00734428
		public static void AddInitialLookAtArray(FlatBufferBuilder builder, VectorOffset initialLookAtArrayOffset)
		{
			builder.AddOffset(12, initialLookAtArrayOffset.Value, 0);
		}

		// Token: 0x06035D43 RID: 220483 RVA: 0x0073623C File Offset: 0x0073443C
		public static VectorOffset CreateInitialLookAtArrayVector(FlatBufferBuilder builder, Offset<IFlowTemplateInitialLookAt>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06035D44 RID: 220484 RVA: 0x0073627C File Offset: 0x0073447C
		public static VectorOffset CreateInitialLookAtArrayVectorBlock(FlatBufferBuilder builder, Offset<IFlowTemplateInitialLookAt>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IFlowTemplateInitialLookAt>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035D45 RID: 220485 RVA: 0x00736296 File Offset: 0x00734496
		public static VectorOffset CreateInitialLookAtArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IFlowTemplateInitialLookAt>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IFlowTemplateInitialLookAt>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035D46 RID: 220486 RVA: 0x007362B4 File Offset: 0x007344B4
		public static VectorOffset CreateInitialLookAtArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IFlowTemplateInitialLookAt>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06035D47 RID: 220487 RVA: 0x007362CD File Offset: 0x007344CD
		public static void StartInitialLookAtArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06035D48 RID: 220488 RVA: 0x007362D8 File Offset: 0x007344D8
		public static void AddActorVisibilityArray(FlatBufferBuilder builder, VectorOffset actorVisibilityArrayOffset)
		{
			builder.AddOffset(13, actorVisibilityArrayOffset.Value, 0);
		}

		// Token: 0x06035D49 RID: 220489 RVA: 0x007362EC File Offset: 0x007344EC
		public static VectorOffset CreateActorVisibilityArrayVector(FlatBufferBuilder builder, Offset<IActorVisibility>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06035D4A RID: 220490 RVA: 0x0073632C File Offset: 0x0073452C
		public static VectorOffset CreateActorVisibilityArrayVectorBlock(FlatBufferBuilder builder, Offset<IActorVisibility>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorVisibility>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035D4B RID: 220491 RVA: 0x00736346 File Offset: 0x00734546
		public static VectorOffset CreateActorVisibilityArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorVisibility>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorVisibility>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035D4C RID: 220492 RVA: 0x00736364 File Offset: 0x00734564
		public static VectorOffset CreateActorVisibilityArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorVisibility>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06035D4D RID: 220493 RVA: 0x0073637D File Offset: 0x0073457D
		public static void StartActorVisibilityArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06035D4E RID: 220494 RVA: 0x00736388 File Offset: 0x00734588
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(14, delayTime, 0.0);
		}

		// Token: 0x06035D4F RID: 220495 RVA: 0x0073639C File Offset: 0x0073459C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(15, nullMask, 0);
		}

		// Token: 0x06035D50 RID: 220496 RVA: 0x007363A8 File Offset: 0x007345A8
		public static Offset<ISetFlowTemplate> EndISetFlowTemplate(FlatBufferBuilder builder)
		{
			return new Offset<ISetFlowTemplate>(builder.EndTable());
		}

		// Token: 0x06035D51 RID: 220497 RVA: 0x007363B8 File Offset: 0x007345B8
		public ISetFlowTemplateT UnPack()
		{
			ISetFlowTemplateT setFlowTemplateT = new ISetFlowTemplateT();
			this.UnPackTo(setFlowTemplateT);
			return setFlowTemplateT;
		}

		// Token: 0x06035D52 RID: 220498 RVA: 0x007363D4 File Offset: 0x007345D4
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

		// Token: 0x06035D53 RID: 220499 RVA: 0x00736740 File Offset: 0x00734940
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

		// Token: 0x040129E8 RID: 76264
		private Table __p;
	}
}
