using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200654C RID: 25932
	public struct IDeadEyeEffectConfig : IFlatbufferObject
	{
		// Token: 0x1700C0C3 RID: 49347
		// (get) Token: 0x0602CFDE RID: 184286 RVA: 0x0062D1C8 File Offset: 0x0062B3C8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CFDF RID: 184287 RVA: 0x0062D1D5 File Offset: 0x0062B3D5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CFE0 RID: 184288 RVA: 0x0062D1DC File Offset: 0x0062B3DC
		public static IDeadEyeEffectConfig GetRootAsIDeadEyeEffectConfig(ByteBuffer _bb)
		{
			return IDeadEyeEffectConfig.GetRootAsIDeadEyeEffectConfig(_bb, default(IDeadEyeEffectConfig));
		}

		// Token: 0x0602CFE1 RID: 184289 RVA: 0x0062D1F8 File Offset: 0x0062B3F8
		public static IDeadEyeEffectConfig GetRootAsIDeadEyeEffectConfig(ByteBuffer _bb, IDeadEyeEffectConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CFE2 RID: 184290 RVA: 0x0062D215 File Offset: 0x0062B415
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CFE3 RID: 184291 RVA: 0x0062D224 File Offset: 0x0062B424
		public IDeadEyeEffectConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C0C4 RID: 49348
		// (get) Token: 0x0602CFE4 RID: 184292 RVA: 0x0062D234 File Offset: 0x0062B434
		public string FilterEffect
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602CFE5 RID: 184293 RVA: 0x0062D26B File Offset: 0x0062B46B
		public Span<byte> GetFilterEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602CFE6 RID: 184294 RVA: 0x0062D27A File Offset: 0x0062B47A
		public byte[] GetFilterEffectArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700C0C5 RID: 49349
		// (get) Token: 0x0602CFE7 RID: 184295 RVA: 0x0062D288 File Offset: 0x0062B488
		public string TargetIdleMaterialDa
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602CFE8 RID: 184296 RVA: 0x0062D2BF File Offset: 0x0062B4BF
		public Span<byte> GetTargetIdleMaterialDaBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602CFE9 RID: 184297 RVA: 0x0062D2CE File Offset: 0x0062B4CE
		public byte[] GetTargetIdleMaterialDaArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700C0C6 RID: 49350
		// (get) Token: 0x0602CFEA RID: 184298 RVA: 0x0062D2DC File Offset: 0x0062B4DC
		public string TargetLockedMaterialDa
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602CFEB RID: 184299 RVA: 0x0062D313 File Offset: 0x0062B513
		public Span<byte> GetTargetLockedMaterialDaBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602CFEC RID: 184300 RVA: 0x0062D322 File Offset: 0x0062B522
		public byte[] GetTargetLockedMaterialDaArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0602CFED RID: 184301 RVA: 0x0062D330 File Offset: 0x0062B530
		public static Offset<IDeadEyeEffectConfig> CreateIDeadEyeEffectConfig(FlatBufferBuilder builder, StringOffset FilterEffectOffset = default(StringOffset), StringOffset TargetIdleMaterialDaOffset = default(StringOffset), StringOffset TargetLockedMaterialDaOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IDeadEyeEffectConfig.AddTargetLockedMaterialDa(builder, TargetLockedMaterialDaOffset);
			IDeadEyeEffectConfig.AddTargetIdleMaterialDa(builder, TargetIdleMaterialDaOffset);
			IDeadEyeEffectConfig.AddFilterEffect(builder, FilterEffectOffset);
			return IDeadEyeEffectConfig.EndIDeadEyeEffectConfig(builder);
		}

		// Token: 0x0602CFEE RID: 184302 RVA: 0x0062D354 File Offset: 0x0062B554
		public static void StartIDeadEyeEffectConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602CFEF RID: 184303 RVA: 0x0062D35D File Offset: 0x0062B55D
		public static void AddFilterEffect(FlatBufferBuilder builder, StringOffset filterEffectOffset)
		{
			builder.AddOffset(0, filterEffectOffset.Value, 0);
		}

		// Token: 0x0602CFF0 RID: 184304 RVA: 0x0062D36D File Offset: 0x0062B56D
		public static void AddTargetIdleMaterialDa(FlatBufferBuilder builder, StringOffset targetIdleMaterialDaOffset)
		{
			builder.AddOffset(1, targetIdleMaterialDaOffset.Value, 0);
		}

		// Token: 0x0602CFF1 RID: 184305 RVA: 0x0062D37D File Offset: 0x0062B57D
		public static void AddTargetLockedMaterialDa(FlatBufferBuilder builder, StringOffset targetLockedMaterialDaOffset)
		{
			builder.AddOffset(2, targetLockedMaterialDaOffset.Value, 0);
		}

		// Token: 0x0602CFF2 RID: 184306 RVA: 0x0062D38D File Offset: 0x0062B58D
		public static Offset<IDeadEyeEffectConfig> EndIDeadEyeEffectConfig(FlatBufferBuilder builder)
		{
			return new Offset<IDeadEyeEffectConfig>(builder.EndTable());
		}

		// Token: 0x0602CFF3 RID: 184307 RVA: 0x0062D39C File Offset: 0x0062B59C
		public IDeadEyeEffectConfigT UnPack()
		{
			IDeadEyeEffectConfigT deadEyeEffectConfigT = new IDeadEyeEffectConfigT();
			this.UnPackTo(deadEyeEffectConfigT);
			return deadEyeEffectConfigT;
		}

		// Token: 0x0602CFF4 RID: 184308 RVA: 0x0062D3B7 File Offset: 0x0062B5B7
		public void UnPackTo(IDeadEyeEffectConfigT _o)
		{
			_o.FilterEffect = this.FilterEffect;
			_o.TargetIdleMaterialDa = this.TargetIdleMaterialDa;
			_o.TargetLockedMaterialDa = this.TargetLockedMaterialDa;
		}

		// Token: 0x0602CFF5 RID: 184309 RVA: 0x0062D3E0 File Offset: 0x0062B5E0
		public static Offset<IDeadEyeEffectConfig> Pack(FlatBufferBuilder builder, IDeadEyeEffectConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDeadEyeEffectConfig>);
			}
			StringOffset filterEffectOffset = (_o.FilterEffect == null) ? default(StringOffset) : builder.CreateString(_o.FilterEffect);
			StringOffset targetIdleMaterialDaOffset = (_o.TargetIdleMaterialDa == null) ? default(StringOffset) : builder.CreateString(_o.TargetIdleMaterialDa);
			StringOffset targetLockedMaterialDaOffset = (_o.TargetLockedMaterialDa == null) ? default(StringOffset) : builder.CreateString(_o.TargetLockedMaterialDa);
			return IDeadEyeEffectConfig.CreateIDeadEyeEffectConfig(builder, filterEffectOffset, targetIdleMaterialDaOffset, targetLockedMaterialDaOffset);
		}

		// Token: 0x04010B9C RID: 68508
		private Table __p;
	}
}
