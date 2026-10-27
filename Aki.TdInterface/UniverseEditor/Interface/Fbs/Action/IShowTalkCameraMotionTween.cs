using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070F4 RID: 28916
	public struct IShowTalkCameraMotionTween : IFlatbufferObject
	{
		// Token: 0x1700D6F0 RID: 55024
		// (get) Token: 0x0603340B RID: 209931 RVA: 0x006E9177 File Offset: 0x006E7377
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603340C RID: 209932 RVA: 0x006E9184 File Offset: 0x006E7384
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603340D RID: 209933 RVA: 0x006E918C File Offset: 0x006E738C
		public static IShowTalkCameraMotionTween GetRootAsIShowTalkCameraMotionTween(ByteBuffer _bb)
		{
			return IShowTalkCameraMotionTween.GetRootAsIShowTalkCameraMotionTween(_bb, default(IShowTalkCameraMotionTween));
		}

		// Token: 0x0603340E RID: 209934 RVA: 0x006E91A8 File Offset: 0x006E73A8
		public static IShowTalkCameraMotionTween GetRootAsIShowTalkCameraMotionTween(ByteBuffer _bb, IShowTalkCameraMotionTween obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603340F RID: 209935 RVA: 0x006E91C5 File Offset: 0x006E73C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033410 RID: 209936 RVA: 0x006E91D4 File Offset: 0x006E73D4
		public IShowTalkCameraMotionTween __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D6F1 RID: 55025
		// (get) Token: 0x06033411 RID: 209937 RVA: 0x006E91E4 File Offset: 0x006E73E4
		public EShowTalkCameraMotionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EShowTalkCameraMotionType.Preset;
				}
				return (EShowTalkCameraMotionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D6F2 RID: 55026
		// (get) Token: 0x06033412 RID: 209938 RVA: 0x006E9220 File Offset: 0x006E7420
		public ICameraParams? Start
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ICameraParams?(default(ICameraParams).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D6F3 RID: 55027
		// (get) Token: 0x06033413 RID: 209939 RVA: 0x006E9280 File Offset: 0x006E7480
		public ICameraParams? End
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new ICameraParams?(default(ICameraParams).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D6F4 RID: 55028
		// (get) Token: 0x06033414 RID: 209940 RVA: 0x006E92E0 File Offset: 0x006E74E0
		public float Duration
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D6F5 RID: 55029
		// (get) Token: 0x06033415 RID: 209941 RVA: 0x006E9324 File Offset: 0x006E7524
		public EEaseType EaseType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return EEaseType.Linear;
				}
				return (EEaseType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D6F6 RID: 55030
		// (get) Token: 0x06033416 RID: 209942 RVA: 0x006E9364 File Offset: 0x006E7564
		public IFlowCameraShake? CamShake
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new IFlowCameraShake?(default(IFlowCameraShake).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D6F7 RID: 55031
		// (get) Token: 0x06033417 RID: 209943 RVA: 0x006E93C4 File Offset: 0x006E75C4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033418 RID: 209944 RVA: 0x006E9404 File Offset: 0x006E7604
		public static Offset<IShowTalkCameraMotionTween> CreateIShowTalkCameraMotionTween(FlatBufferBuilder builder, EShowTalkCameraMotionType Type = EShowTalkCameraMotionType.Preset, Offset<ICameraParams> StartOffset = default(Offset<ICameraParams>), Offset<ICameraParams> EndOffset = default(Offset<ICameraParams>), float Duration = 0f, EEaseType EaseType = EEaseType.Linear, Offset<IFlowCameraShake> CamShakeOffset = default(Offset<IFlowCameraShake>), byte NullMask = 0)
		{
			builder.StartTable(7);
			IShowTalkCameraMotionTween.AddCamShake(builder, CamShakeOffset);
			IShowTalkCameraMotionTween.AddDuration(builder, Duration);
			IShowTalkCameraMotionTween.AddEnd(builder, EndOffset);
			IShowTalkCameraMotionTween.AddStart(builder, StartOffset);
			IShowTalkCameraMotionTween.AddNullMask(builder, NullMask);
			IShowTalkCameraMotionTween.AddEaseType(builder, EaseType);
			IShowTalkCameraMotionTween.AddType(builder, Type);
			return IShowTalkCameraMotionTween.EndIShowTalkCameraMotionTween(builder);
		}

		// Token: 0x06033419 RID: 209945 RVA: 0x006E9453 File Offset: 0x006E7653
		public static void StartIShowTalkCameraMotionTween(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0603341A RID: 209946 RVA: 0x006E945C File Offset: 0x006E765C
		public static void AddType(FlatBufferBuilder builder, EShowTalkCameraMotionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603341B RID: 209947 RVA: 0x006E9467 File Offset: 0x006E7667
		public static void AddStart(FlatBufferBuilder builder, Offset<ICameraParams> startOffset)
		{
			builder.AddOffset(1, startOffset.Value, 0);
		}

		// Token: 0x0603341C RID: 209948 RVA: 0x006E9477 File Offset: 0x006E7677
		public static void AddEnd(FlatBufferBuilder builder, Offset<ICameraParams> endOffset)
		{
			builder.AddOffset(2, endOffset.Value, 0);
		}

		// Token: 0x0603341D RID: 209949 RVA: 0x006E9487 File Offset: 0x006E7687
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(3, duration, 0.0);
		}

		// Token: 0x0603341E RID: 209950 RVA: 0x006E949A File Offset: 0x006E769A
		public static void AddEaseType(FlatBufferBuilder builder, EEaseType easeType)
		{
			builder.AddByte(4, (byte)easeType, 0);
		}

		// Token: 0x0603341F RID: 209951 RVA: 0x006E94A5 File Offset: 0x006E76A5
		public static void AddCamShake(FlatBufferBuilder builder, Offset<IFlowCameraShake> camShakeOffset)
		{
			builder.AddOffset(5, camShakeOffset.Value, 0);
		}

		// Token: 0x06033420 RID: 209952 RVA: 0x006E94B5 File Offset: 0x006E76B5
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06033421 RID: 209953 RVA: 0x006E94C0 File Offset: 0x006E76C0
		public static Offset<IShowTalkCameraMotionTween> EndIShowTalkCameraMotionTween(FlatBufferBuilder builder)
		{
			return new Offset<IShowTalkCameraMotionTween>(builder.EndTable());
		}

		// Token: 0x06033422 RID: 209954 RVA: 0x006E94D0 File Offset: 0x006E76D0
		public IShowTalkCameraMotionTweenT UnPack()
		{
			IShowTalkCameraMotionTweenT showTalkCameraMotionTweenT = new IShowTalkCameraMotionTweenT();
			this.UnPackTo(showTalkCameraMotionTweenT);
			return showTalkCameraMotionTweenT;
		}

		// Token: 0x06033423 RID: 209955 RVA: 0x006E94EC File Offset: 0x006E76EC
		public void UnPackTo(IShowTalkCameraMotionTweenT _o)
		{
			_o.Type = this.Type;
			_o.Start = ((this.Start != null) ? this.Start.Value.UnPack() : null);
			_o.End = ((this.End != null) ? this.End.Value.UnPack() : null);
			_o.Duration = this.Duration;
			_o.EaseType = this.EaseType;
			_o.CamShake = ((this.CamShake != null) ? this.CamShake.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06033424 RID: 209956 RVA: 0x006E95B8 File Offset: 0x006E77B8
		public static Offset<IShowTalkCameraMotionTween> Pack(FlatBufferBuilder builder, IShowTalkCameraMotionTweenT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowTalkCameraMotionTween>);
			}
			Offset<ICameraParams> startOffset = (_o.Start == null) ? default(Offset<ICameraParams>) : ICameraParams.Pack(builder, _o.Start);
			Offset<ICameraParams> endOffset = (_o.End == null) ? default(Offset<ICameraParams>) : ICameraParams.Pack(builder, _o.End);
			Offset<IFlowCameraShake> camShakeOffset = (_o.CamShake == null) ? default(Offset<IFlowCameraShake>) : IFlowCameraShake.Pack(builder, _o.CamShake);
			return IShowTalkCameraMotionTween.CreateIShowTalkCameraMotionTween(builder, _o.Type, startOffset, endOffset, _o.Duration, _o.EaseType, camShakeOffset, _o.NullMask);
		}

		// Token: 0x04011B79 RID: 72569
		private Table __p;
	}
}
