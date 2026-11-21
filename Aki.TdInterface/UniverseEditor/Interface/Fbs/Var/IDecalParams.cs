using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E6E RID: 15982
	public struct IDecalParams : IFlatbufferObject
	{
		// Token: 0x17006BE9 RID: 27625
		// (get) Token: 0x060158A0 RID: 88224 RVA: 0x0031B0B4 File Offset: 0x003192B4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060158A1 RID: 88225 RVA: 0x0031B0C1 File Offset: 0x003192C1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060158A2 RID: 88226 RVA: 0x0031B0C8 File Offset: 0x003192C8
		public static IDecalParams GetRootAsIDecalParams(ByteBuffer _bb)
		{
			return IDecalParams.GetRootAsIDecalParams(_bb, default(IDecalParams));
		}

		// Token: 0x060158A3 RID: 88227 RVA: 0x0031B0E4 File Offset: 0x003192E4
		public static IDecalParams GetRootAsIDecalParams(ByteBuffer _bb, IDecalParams obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060158A4 RID: 88228 RVA: 0x0031B101 File Offset: 0x00319301
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060158A5 RID: 88229 RVA: 0x0031B110 File Offset: 0x00319310
		public IDecalParams __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006BEA RID: 27626
		// (get) Token: 0x060158A6 RID: 88230 RVA: 0x0031B120 File Offset: 0x00319320
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

		// Token: 0x17006BEB RID: 27627
		// (get) Token: 0x060158A7 RID: 88231 RVA: 0x0031B15C File Offset: 0x0031935C
		public float SpreadRadius
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

		// Token: 0x17006BEC RID: 27628
		// (get) Token: 0x060158A8 RID: 88232 RVA: 0x0031B19C File Offset: 0x0031939C
		public float SpreadTime
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

		// Token: 0x060158A9 RID: 88233 RVA: 0x0031B1DC File Offset: 0x003193DC
		public static Offset<IDecalParams> CreateIDecalParams(FlatBufferBuilder builder, EParamsPreset Type = EParamsPreset.Decal, float SpreadRadius = 0f, float SpreadTime = 0f)
		{
			builder.StartTable(3);
			IDecalParams.AddSpreadTime(builder, SpreadTime);
			IDecalParams.AddSpreadRadius(builder, SpreadRadius);
			IDecalParams.AddType(builder, Type);
			return IDecalParams.EndIDecalParams(builder);
		}

		// Token: 0x060158AA RID: 88234 RVA: 0x0031B200 File Offset: 0x00319400
		public static void StartIDecalParams(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060158AB RID: 88235 RVA: 0x0031B209 File Offset: 0x00319409
		public static void AddType(FlatBufferBuilder builder, EParamsPreset type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060158AC RID: 88236 RVA: 0x0031B214 File Offset: 0x00319414
		public static void AddSpreadRadius(FlatBufferBuilder builder, float spreadRadius)
		{
			builder.AddFloat(1, spreadRadius, 0.0);
		}

		// Token: 0x060158AD RID: 88237 RVA: 0x0031B227 File Offset: 0x00319427
		public static void AddSpreadTime(FlatBufferBuilder builder, float spreadTime)
		{
			builder.AddFloat(2, spreadTime, 0.0);
		}

		// Token: 0x060158AE RID: 88238 RVA: 0x0031B23A File Offset: 0x0031943A
		public static Offset<IDecalParams> EndIDecalParams(FlatBufferBuilder builder)
		{
			return new Offset<IDecalParams>(builder.EndTable());
		}

		// Token: 0x060158AF RID: 88239 RVA: 0x0031B248 File Offset: 0x00319448
		public IDecalParamsT UnPack()
		{
			IDecalParamsT decalParamsT = new IDecalParamsT();
			this.UnPackTo(decalParamsT);
			return decalParamsT;
		}

		// Token: 0x060158B0 RID: 88240 RVA: 0x0031B263 File Offset: 0x00319463
		public void UnPackTo(IDecalParamsT _o)
		{
			_o.Type = this.Type;
			_o.SpreadRadius = this.SpreadRadius;
			_o.SpreadTime = this.SpreadTime;
		}

		// Token: 0x060158B1 RID: 88241 RVA: 0x0031B28C File Offset: 0x0031948C
		public static Offset<IDecalParams> Pack(FlatBufferBuilder builder, IDecalParamsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDecalParams>);
			}
			return IDecalParams.CreateIDecalParams(builder, _o.Type, _o.SpreadRadius, _o.SpreadTime);
		}

		// Token: 0x0400B834 RID: 47156
		private Table __p;
	}
}
