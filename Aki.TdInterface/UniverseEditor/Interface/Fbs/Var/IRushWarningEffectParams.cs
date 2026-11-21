using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EC2 RID: 16066
	public struct IRushWarningEffectParams : IFlatbufferObject
	{
		// Token: 0x17006CC8 RID: 27848
		// (get) Token: 0x06015BE4 RID: 89060 RVA: 0x00321206 File Offset: 0x0031F406
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015BE5 RID: 89061 RVA: 0x00321213 File Offset: 0x0031F413
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015BE6 RID: 89062 RVA: 0x0032121C File Offset: 0x0031F41C
		public static IRushWarningEffectParams GetRootAsIRushWarningEffectParams(ByteBuffer _bb)
		{
			return IRushWarningEffectParams.GetRootAsIRushWarningEffectParams(_bb, default(IRushWarningEffectParams));
		}

		// Token: 0x06015BE7 RID: 89063 RVA: 0x00321238 File Offset: 0x0031F438
		public static IRushWarningEffectParams GetRootAsIRushWarningEffectParams(ByteBuffer _bb, IRushWarningEffectParams obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015BE8 RID: 89064 RVA: 0x00321255 File Offset: 0x0031F455
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015BE9 RID: 89065 RVA: 0x00321264 File Offset: 0x0031F464
		public IRushWarningEffectParams __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006CC9 RID: 27849
		// (get) Token: 0x06015BEA RID: 89066 RVA: 0x00321274 File Offset: 0x0031F474
		public EParamsPreset Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EParamsPreset.Decal;
				}
				return (EParamsPreset)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006CCA RID: 27850
		// (get) Token: 0x06015BEB RID: 89067 RVA: 0x003212B0 File Offset: 0x0031F4B0
		public int Length
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

		// Token: 0x17006CCB RID: 27851
		// (get) Token: 0x06015BEC RID: 89068 RVA: 0x003212EC File Offset: 0x0031F4EC
		public int Width
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

		// Token: 0x17006CCC RID: 27852
		// (get) Token: 0x06015BED RID: 89069 RVA: 0x00321328 File Offset: 0x0031F528
		public float Time
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

		// Token: 0x06015BEE RID: 89070 RVA: 0x00321369 File Offset: 0x0031F569
		public static Offset<IRushWarningEffectParams> CreateIRushWarningEffectParams(FlatBufferBuilder builder, EParamsPreset Type = EParamsPreset.Decal, int Length = 0, int Width = 0, float Time = 0f)
		{
			builder.StartTable(4);
			IRushWarningEffectParams.AddTime(builder, Time);
			IRushWarningEffectParams.AddWidth(builder, Width);
			IRushWarningEffectParams.AddLength(builder, Length);
			IRushWarningEffectParams.AddType(builder, Type);
			return IRushWarningEffectParams.EndIRushWarningEffectParams(builder);
		}

		// Token: 0x06015BEF RID: 89071 RVA: 0x00321395 File Offset: 0x0031F595
		public static void StartIRushWarningEffectParams(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06015BF0 RID: 89072 RVA: 0x0032139E File Offset: 0x0031F59E
		public static void AddType(FlatBufferBuilder builder, EParamsPreset type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015BF1 RID: 89073 RVA: 0x003213A9 File Offset: 0x0031F5A9
		public static void AddLength(FlatBufferBuilder builder, int length)
		{
			builder.AddInt(1, length, 0);
		}

		// Token: 0x06015BF2 RID: 89074 RVA: 0x003213B4 File Offset: 0x0031F5B4
		public static void AddWidth(FlatBufferBuilder builder, int width)
		{
			builder.AddInt(2, width, 0);
		}

		// Token: 0x06015BF3 RID: 89075 RVA: 0x003213BF File Offset: 0x0031F5BF
		public static void AddTime(FlatBufferBuilder builder, float time)
		{
			builder.AddFloat(3, time, 0.0);
		}

		// Token: 0x06015BF4 RID: 89076 RVA: 0x003213D2 File Offset: 0x0031F5D2
		public static Offset<IRushWarningEffectParams> EndIRushWarningEffectParams(FlatBufferBuilder builder)
		{
			return new Offset<IRushWarningEffectParams>(builder.EndTable());
		}

		// Token: 0x06015BF5 RID: 89077 RVA: 0x003213E0 File Offset: 0x0031F5E0
		public IRushWarningEffectParamsT UnPack()
		{
			IRushWarningEffectParamsT rushWarningEffectParamsT = new IRushWarningEffectParamsT();
			this.UnPackTo(rushWarningEffectParamsT);
			return rushWarningEffectParamsT;
		}

		// Token: 0x06015BF6 RID: 89078 RVA: 0x003213FB File Offset: 0x0031F5FB
		public void UnPackTo(IRushWarningEffectParamsT _o)
		{
			_o.Type = this.Type;
			_o.Length = this.Length;
			_o.Width = this.Width;
			_o.Time = this.Time;
		}

		// Token: 0x06015BF7 RID: 89079 RVA: 0x00321430 File Offset: 0x0031F630
		public static Offset<IRushWarningEffectParams> Pack(FlatBufferBuilder builder, IRushWarningEffectParamsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRushWarningEffectParams>);
			}
			return IRushWarningEffectParams.CreateIRushWarningEffectParams(builder, _o.Type, _o.Length, _o.Width, _o.Time);
		}

		// Token: 0x0400B8CB RID: 47307
		private Table __p;
	}
}
