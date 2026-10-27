using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C70 RID: 19568
	public struct IPhotographCameraCheckAspectRatioType : IFlatbufferObject
	{
		// Token: 0x17008E20 RID: 36384
		// (get) Token: 0x0601F075 RID: 127093 RVA: 0x00456870 File Offset: 0x00454A70
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F076 RID: 127094 RVA: 0x0045687D File Offset: 0x00454A7D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F077 RID: 127095 RVA: 0x00456884 File Offset: 0x00454A84
		public static IPhotographCameraCheckAspectRatioType GetRootAsIPhotographCameraCheckAspectRatioType(ByteBuffer _bb)
		{
			return IPhotographCameraCheckAspectRatioType.GetRootAsIPhotographCameraCheckAspectRatioType(_bb, default(IPhotographCameraCheckAspectRatioType));
		}

		// Token: 0x0601F078 RID: 127096 RVA: 0x004568A0 File Offset: 0x00454AA0
		public static IPhotographCameraCheckAspectRatioType GetRootAsIPhotographCameraCheckAspectRatioType(ByteBuffer _bb, IPhotographCameraCheckAspectRatioType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F079 RID: 127097 RVA: 0x004568BD File Offset: 0x00454ABD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F07A RID: 127098 RVA: 0x004568CC File Offset: 0x00454ACC
		public IPhotographCameraCheckAspectRatioType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008E21 RID: 36385
		// (get) Token: 0x0601F07B RID: 127099 RVA: 0x004568DC File Offset: 0x00454ADC
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

		// Token: 0x17008E22 RID: 36386
		// (get) Token: 0x0601F07C RID: 127100 RVA: 0x00456918 File Offset: 0x00454B18
		public int AspectRatioTypeId
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

		// Token: 0x0601F07D RID: 127101 RVA: 0x00456954 File Offset: 0x00454B54
		public static Offset<IPhotographCameraCheckAspectRatioType> CreateIPhotographCameraCheckAspectRatioType(FlatBufferBuilder builder, EPhotographCameraCheckType Type = EPhotographCameraCheckType.CameraTemplate, int AspectRatioTypeId = 0)
		{
			builder.StartTable(2);
			IPhotographCameraCheckAspectRatioType.AddAspectRatioTypeId(builder, AspectRatioTypeId);
			IPhotographCameraCheckAspectRatioType.AddType(builder, Type);
			return IPhotographCameraCheckAspectRatioType.EndIPhotographCameraCheckAspectRatioType(builder);
		}

		// Token: 0x0601F07E RID: 127102 RVA: 0x00456971 File Offset: 0x00454B71
		public static void StartIPhotographCameraCheckAspectRatioType(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601F07F RID: 127103 RVA: 0x0045697A File Offset: 0x00454B7A
		public static void AddType(FlatBufferBuilder builder, EPhotographCameraCheckType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F080 RID: 127104 RVA: 0x00456985 File Offset: 0x00454B85
		public static void AddAspectRatioTypeId(FlatBufferBuilder builder, int aspectRatioTypeId)
		{
			builder.AddInt(1, aspectRatioTypeId, 0);
		}

		// Token: 0x0601F081 RID: 127105 RVA: 0x00456990 File Offset: 0x00454B90
		public static Offset<IPhotographCameraCheckAspectRatioType> EndIPhotographCameraCheckAspectRatioType(FlatBufferBuilder builder)
		{
			return new Offset<IPhotographCameraCheckAspectRatioType>(builder.EndTable());
		}

		// Token: 0x0601F082 RID: 127106 RVA: 0x004569A0 File Offset: 0x00454BA0
		public IPhotographCameraCheckAspectRatioTypeT UnPack()
		{
			IPhotographCameraCheckAspectRatioTypeT photographCameraCheckAspectRatioTypeT = new IPhotographCameraCheckAspectRatioTypeT();
			this.UnPackTo(photographCameraCheckAspectRatioTypeT);
			return photographCameraCheckAspectRatioTypeT;
		}

		// Token: 0x0601F083 RID: 127107 RVA: 0x004569BB File Offset: 0x00454BBB
		public void UnPackTo(IPhotographCameraCheckAspectRatioTypeT _o)
		{
			_o.Type = this.Type;
			_o.AspectRatioTypeId = this.AspectRatioTypeId;
		}

		// Token: 0x0601F084 RID: 127108 RVA: 0x004569D8 File Offset: 0x00454BD8
		public static Offset<IPhotographCameraCheckAspectRatioType> Pack(FlatBufferBuilder builder, IPhotographCameraCheckAspectRatioTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhotographCameraCheckAspectRatioType>);
			}
			return IPhotographCameraCheckAspectRatioType.CreateIPhotographCameraCheckAspectRatioType(builder, _o.Type, _o.AspectRatioTypeId);
		}

		// Token: 0x0400D621 RID: 54817
		private Table __p;
	}
}
