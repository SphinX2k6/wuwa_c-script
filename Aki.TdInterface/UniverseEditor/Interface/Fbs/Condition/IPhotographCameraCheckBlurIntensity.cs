using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C73 RID: 19571
	public struct IPhotographCameraCheckBlurIntensity : IFlatbufferObject
	{
		// Token: 0x17008E25 RID: 36389
		// (get) Token: 0x0601F08B RID: 127115 RVA: 0x00456A6E File Offset: 0x00454C6E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F08C RID: 127116 RVA: 0x00456A7B File Offset: 0x00454C7B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F08D RID: 127117 RVA: 0x00456A84 File Offset: 0x00454C84
		public static IPhotographCameraCheckBlurIntensity GetRootAsIPhotographCameraCheckBlurIntensity(ByteBuffer _bb)
		{
			return IPhotographCameraCheckBlurIntensity.GetRootAsIPhotographCameraCheckBlurIntensity(_bb, default(IPhotographCameraCheckBlurIntensity));
		}

		// Token: 0x0601F08E RID: 127118 RVA: 0x00456AA0 File Offset: 0x00454CA0
		public static IPhotographCameraCheckBlurIntensity GetRootAsIPhotographCameraCheckBlurIntensity(ByteBuffer _bb, IPhotographCameraCheckBlurIntensity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F08F RID: 127119 RVA: 0x00456ABD File Offset: 0x00454CBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F090 RID: 127120 RVA: 0x00456ACC File Offset: 0x00454CCC
		public IPhotographCameraCheckBlurIntensity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008E26 RID: 36390
		// (get) Token: 0x0601F091 RID: 127121 RVA: 0x00456ADC File Offset: 0x00454CDC
		public EPhotographCameraCheckType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPhotographCameraCheckType.CameraTemplate;
				}
				return (EPhotographCameraCheckType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008E27 RID: 36391
		// (get) Token: 0x0601F092 RID: 127122 RVA: 0x00456B18 File Offset: 0x00454D18
		public int MinBlurIntensity
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

		// Token: 0x17008E28 RID: 36392
		// (get) Token: 0x0601F093 RID: 127123 RVA: 0x00456B54 File Offset: 0x00454D54
		public int MaxBlurIntensity
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

		// Token: 0x0601F094 RID: 127124 RVA: 0x00456B90 File Offset: 0x00454D90
		public static Offset<IPhotographCameraCheckBlurIntensity> CreateIPhotographCameraCheckBlurIntensity(FlatBufferBuilder builder, EPhotographCameraCheckType Type = EPhotographCameraCheckType.CameraTemplate, int MinBlurIntensity = 0, int MaxBlurIntensity = 0)
		{
			builder.StartTable(3);
			IPhotographCameraCheckBlurIntensity.AddMaxBlurIntensity(builder, MaxBlurIntensity);
			IPhotographCameraCheckBlurIntensity.AddMinBlurIntensity(builder, MinBlurIntensity);
			IPhotographCameraCheckBlurIntensity.AddType(builder, Type);
			return IPhotographCameraCheckBlurIntensity.EndIPhotographCameraCheckBlurIntensity(builder);
		}

		// Token: 0x0601F095 RID: 127125 RVA: 0x00456BB4 File Offset: 0x00454DB4
		public static void StartIPhotographCameraCheckBlurIntensity(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601F096 RID: 127126 RVA: 0x00456BBD File Offset: 0x00454DBD
		public static void AddType(FlatBufferBuilder builder, EPhotographCameraCheckType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F097 RID: 127127 RVA: 0x00456BC8 File Offset: 0x00454DC8
		public static void AddMinBlurIntensity(FlatBufferBuilder builder, int minBlurIntensity)
		{
			builder.AddInt(1, minBlurIntensity, 0);
		}

		// Token: 0x0601F098 RID: 127128 RVA: 0x00456BD3 File Offset: 0x00454DD3
		public static void AddMaxBlurIntensity(FlatBufferBuilder builder, int maxBlurIntensity)
		{
			builder.AddInt(2, maxBlurIntensity, 0);
		}

		// Token: 0x0601F099 RID: 127129 RVA: 0x00456BDE File Offset: 0x00454DDE
		public static Offset<IPhotographCameraCheckBlurIntensity> EndIPhotographCameraCheckBlurIntensity(FlatBufferBuilder builder)
		{
			return new Offset<IPhotographCameraCheckBlurIntensity>(builder.EndTable());
		}

		// Token: 0x0601F09A RID: 127130 RVA: 0x00456BEC File Offset: 0x00454DEC
		public IPhotographCameraCheckBlurIntensityT UnPack()
		{
			IPhotographCameraCheckBlurIntensityT photographCameraCheckBlurIntensityT = new IPhotographCameraCheckBlurIntensityT();
			this.UnPackTo(photographCameraCheckBlurIntensityT);
			return photographCameraCheckBlurIntensityT;
		}

		// Token: 0x0601F09B RID: 127131 RVA: 0x00456C07 File Offset: 0x00454E07
		public void UnPackTo(IPhotographCameraCheckBlurIntensityT _o)
		{
			_o.Type = this.Type;
			_o.MinBlurIntensity = this.MinBlurIntensity;
			_o.MaxBlurIntensity = this.MaxBlurIntensity;
		}

		// Token: 0x0601F09C RID: 127132 RVA: 0x00456C30 File Offset: 0x00454E30
		public static Offset<IPhotographCameraCheckBlurIntensity> Pack(FlatBufferBuilder builder, IPhotographCameraCheckBlurIntensityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhotographCameraCheckBlurIntensity>);
			}
			return IPhotographCameraCheckBlurIntensity.CreateIPhotographCameraCheckBlurIntensity(builder, _o.Type, _o.MinBlurIntensity, _o.MaxBlurIntensity);
		}

		// Token: 0x0400D624 RID: 54820
		private Table __p;
	}
}
