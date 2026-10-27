using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B74 RID: 27508
	public struct IMovingCameraTimeParams : IFlatbufferObject
	{
		// Token: 0x1700CC77 RID: 52343
		// (get) Token: 0x060304DE RID: 197854 RVA: 0x00690438 File Offset: 0x0068E638
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060304DF RID: 197855 RVA: 0x00690445 File Offset: 0x0068E645
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060304E0 RID: 197856 RVA: 0x0069044C File Offset: 0x0068E64C
		public static IMovingCameraTimeParams GetRootAsIMovingCameraTimeParams(ByteBuffer _bb)
		{
			return IMovingCameraTimeParams.GetRootAsIMovingCameraTimeParams(_bb, default(IMovingCameraTimeParams));
		}

		// Token: 0x060304E1 RID: 197857 RVA: 0x00690468 File Offset: 0x0068E668
		public static IMovingCameraTimeParams GetRootAsIMovingCameraTimeParams(ByteBuffer _bb, IMovingCameraTimeParams obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060304E2 RID: 197858 RVA: 0x00690485 File Offset: 0x0068E685
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060304E3 RID: 197859 RVA: 0x00690494 File Offset: 0x0068E694
		public IMovingCameraTimeParams __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CC78 RID: 52344
		// (get) Token: 0x060304E4 RID: 197860 RVA: 0x006904A4 File Offset: 0x0068E6A4
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

		// Token: 0x1700CC79 RID: 52345
		// (get) Token: 0x060304E5 RID: 197861 RVA: 0x006904E4 File Offset: 0x0068E6E4
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

		// Token: 0x1700CC7A RID: 52346
		// (get) Token: 0x060304E6 RID: 197862 RVA: 0x00690524 File Offset: 0x0068E724
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

		// Token: 0x1700CC7B RID: 52347
		// (get) Token: 0x060304E7 RID: 197863 RVA: 0x00690564 File Offset: 0x0068E764
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

		// Token: 0x060304E8 RID: 197864 RVA: 0x006905A5 File Offset: 0x0068E7A5
		public static Offset<IMovingCameraTimeParams> CreateIMovingCameraTimeParams(FlatBufferBuilder builder, float FadeInTime = 0f, float AfterFadeInStayTime = 0f, float FadeOutTime = 0f, float BeforeFadeOutStayTime = 0f)
		{
			builder.StartTable(4);
			IMovingCameraTimeParams.AddBeforeFadeOutStayTime(builder, BeforeFadeOutStayTime);
			IMovingCameraTimeParams.AddFadeOutTime(builder, FadeOutTime);
			IMovingCameraTimeParams.AddAfterFadeInStayTime(builder, AfterFadeInStayTime);
			IMovingCameraTimeParams.AddFadeInTime(builder, FadeInTime);
			return IMovingCameraTimeParams.EndIMovingCameraTimeParams(builder);
		}

		// Token: 0x060304E9 RID: 197865 RVA: 0x006905D1 File Offset: 0x0068E7D1
		public static void StartIMovingCameraTimeParams(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060304EA RID: 197866 RVA: 0x006905DA File Offset: 0x0068E7DA
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(0, fadeInTime, 0.0);
		}

		// Token: 0x060304EB RID: 197867 RVA: 0x006905ED File Offset: 0x0068E7ED
		public static void AddAfterFadeInStayTime(FlatBufferBuilder builder, float afterFadeInStayTime)
		{
			builder.AddFloat(1, afterFadeInStayTime, 0.0);
		}

		// Token: 0x060304EC RID: 197868 RVA: 0x00690600 File Offset: 0x0068E800
		public static void AddFadeOutTime(FlatBufferBuilder builder, float fadeOutTime)
		{
			builder.AddFloat(2, fadeOutTime, 0.0);
		}

		// Token: 0x060304ED RID: 197869 RVA: 0x00690613 File Offset: 0x0068E813
		public static void AddBeforeFadeOutStayTime(FlatBufferBuilder builder, float beforeFadeOutStayTime)
		{
			builder.AddFloat(3, beforeFadeOutStayTime, 0.0);
		}

		// Token: 0x060304EE RID: 197870 RVA: 0x00690626 File Offset: 0x0068E826
		public static Offset<IMovingCameraTimeParams> EndIMovingCameraTimeParams(FlatBufferBuilder builder)
		{
			return new Offset<IMovingCameraTimeParams>(builder.EndTable());
		}

		// Token: 0x060304EF RID: 197871 RVA: 0x00690634 File Offset: 0x0068E834
		public IMovingCameraTimeParamsT UnPack()
		{
			IMovingCameraTimeParamsT movingCameraTimeParamsT = new IMovingCameraTimeParamsT();
			this.UnPackTo(movingCameraTimeParamsT);
			return movingCameraTimeParamsT;
		}

		// Token: 0x060304F0 RID: 197872 RVA: 0x0069064F File Offset: 0x0068E84F
		public void UnPackTo(IMovingCameraTimeParamsT _o)
		{
			_o.FadeInTime = this.FadeInTime;
			_o.AfterFadeInStayTime = this.AfterFadeInStayTime;
			_o.FadeOutTime = this.FadeOutTime;
			_o.BeforeFadeOutStayTime = this.BeforeFadeOutStayTime;
		}

		// Token: 0x060304F1 RID: 197873 RVA: 0x00690684 File Offset: 0x0068E884
		public static Offset<IMovingCameraTimeParams> Pack(FlatBufferBuilder builder, IMovingCameraTimeParamsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMovingCameraTimeParams>);
			}
			return IMovingCameraTimeParams.CreateIMovingCameraTimeParams(builder, _o.FadeInTime, _o.AfterFadeInStayTime, _o.FadeOutTime, _o.BeforeFadeOutStayTime);
		}

		// Token: 0x0401142E RID: 70702
		private Table __p;
	}
}
