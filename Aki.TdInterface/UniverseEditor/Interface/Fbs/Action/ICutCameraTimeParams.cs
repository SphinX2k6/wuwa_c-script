using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200651F RID: 25887
	public struct ICutCameraTimeParams : IFlatbufferObject
	{
		// Token: 0x1700C07B RID: 49275
		// (get) Token: 0x0602CE7F RID: 183935 RVA: 0x0062AC71 File Offset: 0x00628E71
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CE80 RID: 183936 RVA: 0x0062AC7E File Offset: 0x00628E7E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CE81 RID: 183937 RVA: 0x0062AC88 File Offset: 0x00628E88
		public static ICutCameraTimeParams GetRootAsICutCameraTimeParams(ByteBuffer _bb)
		{
			return ICutCameraTimeParams.GetRootAsICutCameraTimeParams(_bb, default(ICutCameraTimeParams));
		}

		// Token: 0x0602CE82 RID: 183938 RVA: 0x0062ACA4 File Offset: 0x00628EA4
		public static ICutCameraTimeParams GetRootAsICutCameraTimeParams(ByteBuffer _bb, ICutCameraTimeParams obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CE83 RID: 183939 RVA: 0x0062ACC1 File Offset: 0x00628EC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CE84 RID: 183940 RVA: 0x0062ACD0 File Offset: 0x00628ED0
		public ICutCameraTimeParams __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C07C RID: 49276
		// (get) Token: 0x0602CE85 RID: 183941 RVA: 0x0062ACE0 File Offset: 0x00628EE0
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

		// Token: 0x0602CE86 RID: 183942 RVA: 0x0062AD20 File Offset: 0x00628F20
		public static Offset<ICutCameraTimeParams> CreateICutCameraTimeParams(FlatBufferBuilder builder, float CutStayTime = 0f)
		{
			builder.StartTable(1);
			ICutCameraTimeParams.AddCutStayTime(builder, CutStayTime);
			return ICutCameraTimeParams.EndICutCameraTimeParams(builder);
		}

		// Token: 0x0602CE87 RID: 183943 RVA: 0x0062AD36 File Offset: 0x00628F36
		public static void StartICutCameraTimeParams(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602CE88 RID: 183944 RVA: 0x0062AD3F File Offset: 0x00628F3F
		public static void AddCutStayTime(FlatBufferBuilder builder, float cutStayTime)
		{
			builder.AddFloat(0, cutStayTime, 0.0);
		}

		// Token: 0x0602CE89 RID: 183945 RVA: 0x0062AD52 File Offset: 0x00628F52
		public static Offset<ICutCameraTimeParams> EndICutCameraTimeParams(FlatBufferBuilder builder)
		{
			return new Offset<ICutCameraTimeParams>(builder.EndTable());
		}

		// Token: 0x0602CE8A RID: 183946 RVA: 0x0062AD60 File Offset: 0x00628F60
		public ICutCameraTimeParamsT UnPack()
		{
			ICutCameraTimeParamsT cutCameraTimeParamsT = new ICutCameraTimeParamsT();
			this.UnPackTo(cutCameraTimeParamsT);
			return cutCameraTimeParamsT;
		}

		// Token: 0x0602CE8B RID: 183947 RVA: 0x0062AD7B File Offset: 0x00628F7B
		public void UnPackTo(ICutCameraTimeParamsT _o)
		{
			_o.CutStayTime = this.CutStayTime;
		}

		// Token: 0x0602CE8C RID: 183948 RVA: 0x0062AD8C File Offset: 0x00628F8C
		public static Offset<ICutCameraTimeParams> Pack(FlatBufferBuilder builder, ICutCameraTimeParamsT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICutCameraTimeParams>);
			}
			return ICutCameraTimeParams.CreateICutCameraTimeParams(builder, _o.CutStayTime);
		}

		// Token: 0x04010B6A RID: 68458
		private Table __p;
	}
}
