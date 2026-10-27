using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006549 RID: 25929
	public struct IDeadeyeCameraConfig : IFlatbufferObject
	{
		// Token: 0x1700C0BA RID: 49338
		// (get) Token: 0x0602CFC0 RID: 184256 RVA: 0x0062CE9E File Offset: 0x0062B09E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CFC1 RID: 184257 RVA: 0x0062CEAB File Offset: 0x0062B0AB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CFC2 RID: 184258 RVA: 0x0062CEB4 File Offset: 0x0062B0B4
		public static IDeadeyeCameraConfig GetRootAsIDeadeyeCameraConfig(ByteBuffer _bb)
		{
			return IDeadeyeCameraConfig.GetRootAsIDeadeyeCameraConfig(_bb, default(IDeadeyeCameraConfig));
		}

		// Token: 0x0602CFC3 RID: 184259 RVA: 0x0062CED0 File Offset: 0x0062B0D0
		public static IDeadeyeCameraConfig GetRootAsIDeadeyeCameraConfig(ByteBuffer _bb, IDeadeyeCameraConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CFC4 RID: 184260 RVA: 0x0062CEED File Offset: 0x0062B0ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CFC5 RID: 184261 RVA: 0x0062CEFC File Offset: 0x0062B0FC
		public IDeadeyeCameraConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C0BB RID: 49339
		// (get) Token: 0x0602CFC6 RID: 184262 RVA: 0x0062CF0C File Offset: 0x0062B10C
		public int LookAtPointId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C0BC RID: 49340
		// (get) Token: 0x0602CFC7 RID: 184263 RVA: 0x0062CF48 File Offset: 0x0062B148
		public int SubLensTag
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

		// Token: 0x1700C0BD RID: 49341
		// (get) Token: 0x0602CFC8 RID: 184264 RVA: 0x0062CF84 File Offset: 0x0062B184
		public float TransitionTime
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

		// Token: 0x1700C0BE RID: 49342
		// (get) Token: 0x0602CFC9 RID: 184265 RVA: 0x0062CFC4 File Offset: 0x0062B1C4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602CFCA RID: 184266 RVA: 0x0062D001 File Offset: 0x0062B201
		public static Offset<IDeadeyeCameraConfig> CreateIDeadeyeCameraConfig(FlatBufferBuilder builder, int LookAtPointId = 0, int SubLensTag = 0, float TransitionTime = 0f, byte NullMask = 0)
		{
			builder.StartTable(4);
			IDeadeyeCameraConfig.AddTransitionTime(builder, TransitionTime);
			IDeadeyeCameraConfig.AddSubLensTag(builder, SubLensTag);
			IDeadeyeCameraConfig.AddLookAtPointId(builder, LookAtPointId);
			IDeadeyeCameraConfig.AddNullMask(builder, NullMask);
			return IDeadeyeCameraConfig.EndIDeadeyeCameraConfig(builder);
		}

		// Token: 0x0602CFCB RID: 184267 RVA: 0x0062D02D File Offset: 0x0062B22D
		public static void StartIDeadeyeCameraConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602CFCC RID: 184268 RVA: 0x0062D036 File Offset: 0x0062B236
		public static void AddLookAtPointId(FlatBufferBuilder builder, int lookAtPointId)
		{
			builder.AddInt(0, lookAtPointId, 0);
		}

		// Token: 0x0602CFCD RID: 184269 RVA: 0x0062D041 File Offset: 0x0062B241
		public static void AddSubLensTag(FlatBufferBuilder builder, int subLensTag)
		{
			builder.AddInt(1, subLensTag, 0);
		}

		// Token: 0x0602CFCE RID: 184270 RVA: 0x0062D04C File Offset: 0x0062B24C
		public static void AddTransitionTime(FlatBufferBuilder builder, float transitionTime)
		{
			builder.AddFloat(2, transitionTime, 0.0);
		}

		// Token: 0x0602CFCF RID: 184271 RVA: 0x0062D05F File Offset: 0x0062B25F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602CFD0 RID: 184272 RVA: 0x0062D06A File Offset: 0x0062B26A
		public static Offset<IDeadeyeCameraConfig> EndIDeadeyeCameraConfig(FlatBufferBuilder builder)
		{
			return new Offset<IDeadeyeCameraConfig>(builder.EndTable());
		}

		// Token: 0x0602CFD1 RID: 184273 RVA: 0x0062D078 File Offset: 0x0062B278
		public IDeadeyeCameraConfigT UnPack()
		{
			IDeadeyeCameraConfigT deadeyeCameraConfigT = new IDeadeyeCameraConfigT();
			this.UnPackTo(deadeyeCameraConfigT);
			return deadeyeCameraConfigT;
		}

		// Token: 0x0602CFD2 RID: 184274 RVA: 0x0062D093 File Offset: 0x0062B293
		public void UnPackTo(IDeadeyeCameraConfigT _o)
		{
			_o.LookAtPointId = this.LookAtPointId;
			_o.SubLensTag = this.SubLensTag;
			_o.TransitionTime = this.TransitionTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602CFD3 RID: 184275 RVA: 0x0062D0C8 File Offset: 0x0062B2C8
		public static Offset<IDeadeyeCameraConfig> Pack(FlatBufferBuilder builder, IDeadeyeCameraConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDeadeyeCameraConfig>);
			}
			return IDeadeyeCameraConfig.CreateIDeadeyeCameraConfig(builder, _o.LookAtPointId, _o.SubLensTag, _o.TransitionTime, _o.NullMask);
		}

		// Token: 0x04010B97 RID: 68503
		private Table __p;
	}
}
