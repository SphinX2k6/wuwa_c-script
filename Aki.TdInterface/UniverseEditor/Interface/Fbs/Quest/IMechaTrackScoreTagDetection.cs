using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F2F RID: 16175
	public struct IMechaTrackScoreTagDetection : IFlatbufferObject
	{
		// Token: 0x17007074 RID: 28788
		// (get) Token: 0x06016F8A RID: 94090 RVA: 0x003505ED File Offset: 0x0034E7ED
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016F8B RID: 94091 RVA: 0x003505FA File Offset: 0x0034E7FA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016F8C RID: 94092 RVA: 0x00350604 File Offset: 0x0034E804
		public static IMechaTrackScoreTagDetection GetRootAsIMechaTrackScoreTagDetection(ByteBuffer _bb)
		{
			return IMechaTrackScoreTagDetection.GetRootAsIMechaTrackScoreTagDetection(_bb, default(IMechaTrackScoreTagDetection));
		}

		// Token: 0x06016F8D RID: 94093 RVA: 0x00350620 File Offset: 0x0034E820
		public static IMechaTrackScoreTagDetection GetRootAsIMechaTrackScoreTagDetection(ByteBuffer _bb, IMechaTrackScoreTagDetection obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016F8E RID: 94094 RVA: 0x0035063D File Offset: 0x0034E83D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016F8F RID: 94095 RVA: 0x0035064C File Offset: 0x0034E84C
		public IMechaTrackScoreTagDetection __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007075 RID: 28789
		// (get) Token: 0x06016F90 RID: 94096 RVA: 0x0035065C File Offset: 0x0034E85C
		public EMechaTrackScoreDetectionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMechaTrackScoreDetectionType.StuntAction;
				}
				return (EMechaTrackScoreDetectionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06016F91 RID: 94097 RVA: 0x00350698 File Offset: 0x0034E898
		public static Offset<IMechaTrackScoreTagDetection> CreateIMechaTrackScoreTagDetection(FlatBufferBuilder builder, EMechaTrackScoreDetectionType Type = EMechaTrackScoreDetectionType.StuntAction)
		{
			builder.StartTable(1);
			IMechaTrackScoreTagDetection.AddType(builder, Type);
			return IMechaTrackScoreTagDetection.EndIMechaTrackScoreTagDetection(builder);
		}

		// Token: 0x06016F92 RID: 94098 RVA: 0x003506AE File Offset: 0x0034E8AE
		public static void StartIMechaTrackScoreTagDetection(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06016F93 RID: 94099 RVA: 0x003506B7 File Offset: 0x0034E8B7
		public static void AddType(FlatBufferBuilder builder, EMechaTrackScoreDetectionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016F94 RID: 94100 RVA: 0x003506C2 File Offset: 0x0034E8C2
		public static Offset<IMechaTrackScoreTagDetection> EndIMechaTrackScoreTagDetection(FlatBufferBuilder builder)
		{
			return new Offset<IMechaTrackScoreTagDetection>(builder.EndTable());
		}

		// Token: 0x06016F95 RID: 94101 RVA: 0x003506D0 File Offset: 0x0034E8D0
		public IMechaTrackScoreTagDetectionT UnPack()
		{
			IMechaTrackScoreTagDetectionT mechaTrackScoreTagDetectionT = new IMechaTrackScoreTagDetectionT();
			this.UnPackTo(mechaTrackScoreTagDetectionT);
			return mechaTrackScoreTagDetectionT;
		}

		// Token: 0x06016F96 RID: 94102 RVA: 0x003506EB File Offset: 0x0034E8EB
		public void UnPackTo(IMechaTrackScoreTagDetectionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06016F97 RID: 94103 RVA: 0x003506FC File Offset: 0x0034E8FC
		public static Offset<IMechaTrackScoreTagDetection> Pack(FlatBufferBuilder builder, IMechaTrackScoreTagDetectionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMechaTrackScoreTagDetection>);
			}
			return IMechaTrackScoreTagDetection.CreateIMechaTrackScoreTagDetection(builder, _o.Type);
		}

		// Token: 0x0400B93A RID: 47418
		private Table __p;
	}
}
