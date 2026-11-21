using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078C0 RID: 30912
	public struct IShowTalkCameraMotionTween : IFlatbufferObject
	{
		// Token: 0x1700E2D3 RID: 58067
		// (get) Token: 0x060366AD RID: 222893 RVA: 0x00749783 File Offset: 0x00747983
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060366AE RID: 222894 RVA: 0x00749790 File Offset: 0x00747990
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060366AF RID: 222895 RVA: 0x00749798 File Offset: 0x00747998
		public static IShowTalkCameraMotionTween GetRootAsIShowTalkCameraMotionTween(ByteBuffer _bb)
		{
			return IShowTalkCameraMotionTween.GetRootAsIShowTalkCameraMotionTween(_bb, default(IShowTalkCameraMotionTween));
		}

		// Token: 0x060366B0 RID: 222896 RVA: 0x007497B4 File Offset: 0x007479B4
		public static IShowTalkCameraMotionTween GetRootAsIShowTalkCameraMotionTween(ByteBuffer _bb, IShowTalkCameraMotionTween obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060366B1 RID: 222897 RVA: 0x007497D1 File Offset: 0x007479D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060366B2 RID: 222898 RVA: 0x007497E0 File Offset: 0x007479E0
		public IShowTalkCameraMotionTween __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E2D4 RID: 58068
		// (get) Token: 0x060366B3 RID: 222899 RVA: 0x007497F0 File Offset: 0x007479F0
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

		// Token: 0x1700E2D5 RID: 58069
		// (get) Token: 0x060366B4 RID: 222900 RVA: 0x0074982C File Offset: 0x00747A2C
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

		// Token: 0x1700E2D6 RID: 58070
		// (get) Token: 0x060366B5 RID: 222901 RVA: 0x0074988C File Offset: 0x00747A8C
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

		// Token: 0x1700E2D7 RID: 58071
		// (get) Token: 0x060366B6 RID: 222902 RVA: 0x007498EC File Offset: 0x00747AEC
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

		// Token: 0x1700E2D8 RID: 58072
		// (get) Token: 0x060366B7 RID: 222903 RVA: 0x00749930 File Offset: 0x00747B30
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

		// Token: 0x1700E2D9 RID: 58073
		// (get) Token: 0x060366B8 RID: 222904 RVA: 0x00749970 File Offset: 0x00747B70
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

		// Token: 0x1700E2DA RID: 58074
		// (get) Token: 0x060366B9 RID: 222905 RVA: 0x007499D0 File Offset: 0x00747BD0
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

		// Token: 0x060366BA RID: 222906 RVA: 0x00749A10 File Offset: 0x00747C10
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

		// Token: 0x060366BB RID: 222907 RVA: 0x00749A5F File Offset: 0x00747C5F
		public static void StartIShowTalkCameraMotionTween(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x060366BC RID: 222908 RVA: 0x00749A68 File Offset: 0x00747C68
		public static void AddType(FlatBufferBuilder builder, EShowTalkCameraMotionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060366BD RID: 222909 RVA: 0x00749A73 File Offset: 0x00747C73
		public static void AddStart(FlatBufferBuilder builder, Offset<ICameraParams> startOffset)
		{
			builder.AddOffset(1, startOffset.Value, 0);
		}

		// Token: 0x060366BE RID: 222910 RVA: 0x00749A83 File Offset: 0x00747C83
		public static void AddEnd(FlatBufferBuilder builder, Offset<ICameraParams> endOffset)
		{
			builder.AddOffset(2, endOffset.Value, 0);
		}

		// Token: 0x060366BF RID: 222911 RVA: 0x00749A93 File Offset: 0x00747C93
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(3, duration, 0.0);
		}

		// Token: 0x060366C0 RID: 222912 RVA: 0x00749AA6 File Offset: 0x00747CA6
		public static void AddEaseType(FlatBufferBuilder builder, EEaseType easeType)
		{
			builder.AddByte(4, (byte)easeType, 0);
		}

		// Token: 0x060366C1 RID: 222913 RVA: 0x00749AB1 File Offset: 0x00747CB1
		public static void AddCamShake(FlatBufferBuilder builder, Offset<IFlowCameraShake> camShakeOffset)
		{
			builder.AddOffset(5, camShakeOffset.Value, 0);
		}

		// Token: 0x060366C2 RID: 222914 RVA: 0x00749AC1 File Offset: 0x00747CC1
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x060366C3 RID: 222915 RVA: 0x00749ACC File Offset: 0x00747CCC
		public static Offset<IShowTalkCameraMotionTween> EndIShowTalkCameraMotionTween(FlatBufferBuilder builder)
		{
			return new Offset<IShowTalkCameraMotionTween>(builder.EndTable());
		}

		// Token: 0x060366C4 RID: 222916 RVA: 0x00749ADC File Offset: 0x00747CDC
		public IShowTalkCameraMotionTweenT UnPack()
		{
			IShowTalkCameraMotionTweenT showTalkCameraMotionTweenT = new IShowTalkCameraMotionTweenT();
			this.UnPackTo(showTalkCameraMotionTweenT);
			return showTalkCameraMotionTweenT;
		}

		// Token: 0x060366C5 RID: 222917 RVA: 0x00749AF8 File Offset: 0x00747CF8
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

		// Token: 0x060366C6 RID: 222918 RVA: 0x00749BC4 File Offset: 0x00747DC4
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

		// Token: 0x04012B67 RID: 76647
		private Table __p;
	}
}
