using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072BA RID: 29370
	public struct IMovingCameraTimeParams : IFlatbufferObject
	{
		// Token: 0x1700D75C RID: 55132
		// (get) Token: 0x06033336 RID: 209718 RVA: 0x006E8A58 File Offset: 0x006E6C58
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033337 RID: 209719 RVA: 0x006E8A65 File Offset: 0x006E6C65
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033338 RID: 209720 RVA: 0x006E8A6C File Offset: 0x006E6C6C
		public static IMovingCameraTimeParams GetRootAsIMovingCameraTimeParams(ByteBuffer _bb)
		{
			return IMovingCameraTimeParams.GetRootAsIMovingCameraTimeParams(_bb, default(IMovingCameraTimeParams));
		}

		// Token: 0x06033339 RID: 209721 RVA: 0x006E8A88 File Offset: 0x006E6C88
		public static IMovingCameraTimeParams GetRootAsIMovingCameraTimeParams(ByteBuffer _bb, IMovingCameraTimeParams obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603333A RID: 209722 RVA: 0x006E8AA5 File Offset: 0x006E6CA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603333B RID: 209723 RVA: 0x006E8AB4 File Offset: 0x006E6CB4
		public IMovingCameraTimeParams __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D75D RID: 55133
		// (get) Token: 0x0603333C RID: 209724 RVA: 0x006E8AC4 File Offset: 0x006E6CC4
		public float FadeInTime
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D75E RID: 55134
		// (get) Token: 0x0603333D RID: 209725 RVA: 0x006E8B04 File Offset: 0x006E6D04
		public float AfterFadeInStayTime
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D75F RID: 55135
		// (get) Token: 0x0603333E RID: 209726 RVA: 0x006E8B44 File Offset: 0x006E6D44
		public float FadeOutTime
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D760 RID: 55136
		// (get) Token: 0x0603333F RID: 209727 RVA: 0x006E8B84 File Offset: 0x006E6D84
		public float BeforeFadeOutStayTime
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

		// Token: 0x06033340 RID: 209728 RVA: 0x006E8BC5 File Offset: 0x006E6DC5
		public static Offset<IMovingCameraTimeParams> CreateIMovingCameraTimeParams(FlatBufferBuilder builder, float FadeInTime = 0f, float AfterFadeInStayTime = 0f, float FadeOutTime = 0f, float BeforeFadeOutStayTime = 0f)
		{
			builder.StartTable(4);
			IMovingCameraTimeParams.AddBeforeFadeOutStayTime(builder, BeforeFadeOutStayTime);
			IMovingCameraTimeParams.AddFadeOutTime(builder, FadeOutTime);
			IMovingCameraTimeParams.AddAfterFadeInStayTime(builder, AfterFadeInStayTime);
			IMovingCameraTimeParams.AddFadeInTime(builder, FadeInTime);
			return IMovingCameraTimeParams.EndIMovingCameraTimeParams(builder);
		}

		// Token: 0x06033341 RID: 209729 RVA: 0x006E8BF1 File Offset: 0x006E6DF1
		public static void StartIMovingCameraTimeParams(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06033342 RID: 209730 RVA: 0x006E8BFA File Offset: 0x006E6DFA
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(0, fadeInTime, 0.0);
		}

		// Token: 0x06033343 RID: 209731 RVA: 0x006E8C0D File Offset: 0x006E6E0D
		public static void AddAfterFadeInStayTime(FlatBufferBuilder builder, float afterFadeInStayTime)
		{
			builder.AddFloat(1, afterFadeInStayTime, 0.0);
		}

		// Token: 0x06033344 RID: 209732 RVA: 0x006E8C20 File Offset: 0x006E6E20
		public static void AddFadeOutTime(FlatBufferBuilder builder, float fadeOutTime)
		{
			builder.AddFloat(2, fadeOutTime, 0.0);
		}

		// Token: 0x06033345 RID: 209733 RVA: 0x006E8C33 File Offset: 0x006E6E33
		public static void AddBeforeFadeOutStayTime(FlatBufferBuilder builder, float beforeFadeOutStayTime)
		{
			builder.AddFloat(3, beforeFadeOutStayTime, 0.0);
		}

		// Token: 0x06033346 RID: 209734 RVA: 0x006E8C46 File Offset: 0x006E6E46
		public static Offset<IMovingCameraTimeParams> EndIMovingCameraTimeParams(FlatBufferBuilder builder)
		{
			return new Offset<IMovingCameraTimeParams>(builder.EndTable());
		}

		// Token: 0x06033347 RID: 209735 RVA: 0x006E8C54 File Offset: 0x006E6E54
		public IMovingCameraTimeParamsT UnPack()
		{
			IMovingCameraTimeParamsT movingCameraTimeParamsT = new IMovingCameraTimeParamsT();
			this.UnPackTo(movingCameraTimeParamsT);
			return movingCameraTimeParamsT;
		}

		// Token: 0x06033348 RID: 209736 RVA: 0x006E8C6F File Offset: 0x006E6E6F
		public void UnPackTo(IMovingCameraTimeParamsT _o)
		{
			_o.FadeInTime = this.FadeInTime;
			_o.AfterFadeInStayTime = this.AfterFadeInStayTime;
			_o.FadeOutTime = this.FadeOutTime;
			_o.BeforeFadeOutStayTime = this.BeforeFadeOutStayTime;
		}

		// Token: 0x06033349 RID: 209737 RVA: 0x006E8CA4 File Offset: 0x006E6EA4
		public static Offset<IMovingCameraTimeParams> Pack(FlatBufferBuilder builder, IMovingCameraTimeParamsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMovingCameraTimeParams>);
			}
			return IMovingCameraTimeParams.CreateIMovingCameraTimeParams(builder, _o.FadeInTime, _o.AfterFadeInStayTime, _o.FadeOutTime, _o.BeforeFadeOutStayTime);
		}

		// Token: 0x04012357 RID: 74583
		private Table __p;
	}
}
