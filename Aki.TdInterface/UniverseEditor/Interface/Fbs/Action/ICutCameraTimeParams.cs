using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B8D RID: 27533
	public struct ICutCameraTimeParams : IFlatbufferObject
	{
		// Token: 0x1700CA0D RID: 51725
		// (get) Token: 0x0602F61D RID: 194077 RVA: 0x0067711D File Offset: 0x0067531D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F61E RID: 194078 RVA: 0x0067712A File Offset: 0x0067532A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F61F RID: 194079 RVA: 0x00677134 File Offset: 0x00675334
		public static ICutCameraTimeParams GetRootAsICutCameraTimeParams(ByteBuffer _bb)
		{
			return ICutCameraTimeParams.GetRootAsICutCameraTimeParams(_bb, default(ICutCameraTimeParams));
		}

		// Token: 0x0602F620 RID: 194080 RVA: 0x00677150 File Offset: 0x00675350
		public static ICutCameraTimeParams GetRootAsICutCameraTimeParams(ByteBuffer _bb, ICutCameraTimeParams obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F621 RID: 194081 RVA: 0x0067716D File Offset: 0x0067536D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F622 RID: 194082 RVA: 0x0067717C File Offset: 0x0067537C
		public ICutCameraTimeParams __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CA0E RID: 51726
		// (get) Token: 0x0602F623 RID: 194083 RVA: 0x0067718C File Offset: 0x0067538C
		public float CutStayTime
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

		// Token: 0x0602F624 RID: 194084 RVA: 0x006771CC File Offset: 0x006753CC
		public static Offset<ICutCameraTimeParams> CreateICutCameraTimeParams(FlatBufferBuilder builder, float CutStayTime = 0f)
		{
			builder.StartTable(1);
			ICutCameraTimeParams.AddCutStayTime(builder, CutStayTime);
			return ICutCameraTimeParams.EndICutCameraTimeParams(builder);
		}

		// Token: 0x0602F625 RID: 194085 RVA: 0x006771E2 File Offset: 0x006753E2
		public static void StartICutCameraTimeParams(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602F626 RID: 194086 RVA: 0x006771EB File Offset: 0x006753EB
		public static void AddCutStayTime(FlatBufferBuilder builder, float cutStayTime)
		{
			builder.AddFloat(0, cutStayTime, 0.0);
		}

		// Token: 0x0602F627 RID: 194087 RVA: 0x006771FE File Offset: 0x006753FE
		public static Offset<ICutCameraTimeParams> EndICutCameraTimeParams(FlatBufferBuilder builder)
		{
			return new Offset<ICutCameraTimeParams>(builder.EndTable());
		}

		// Token: 0x0602F628 RID: 194088 RVA: 0x0067720C File Offset: 0x0067540C
		public ICutCameraTimeParamsT UnPack()
		{
			ICutCameraTimeParamsT cutCameraTimeParamsT = new ICutCameraTimeParamsT();
			this.UnPackTo(cutCameraTimeParamsT);
			return cutCameraTimeParamsT;
		}

		// Token: 0x0602F629 RID: 194089 RVA: 0x00677227 File Offset: 0x00675427
		public void UnPackTo(ICutCameraTimeParamsT _o)
		{
			_o.CutStayTime = this.CutStayTime;
		}

		// Token: 0x0602F62A RID: 194090 RVA: 0x00677238 File Offset: 0x00675438
		public static Offset<ICutCameraTimeParams> Pack(FlatBufferBuilder builder, ICutCameraTimeParamsT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICutCameraTimeParams>);
			}
			return ICutCameraTimeParams.CreateICutCameraTimeParams(builder, _o.CutStayTime);
		}

		// Token: 0x04011983 RID: 72067
		private Table __p;
	}
}
