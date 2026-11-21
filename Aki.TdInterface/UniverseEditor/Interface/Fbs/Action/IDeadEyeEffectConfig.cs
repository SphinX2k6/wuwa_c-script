using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BBD RID: 27581
	public struct IDeadEyeEffectConfig : IFlatbufferObject
	{
		// Token: 0x1700CA5E RID: 51806
		// (get) Token: 0x0602F79A RID: 194458 RVA: 0x0067998C File Offset: 0x00677B8C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F79B RID: 194459 RVA: 0x00679999 File Offset: 0x00677B99
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F79C RID: 194460 RVA: 0x006799A0 File Offset: 0x00677BA0
		public static IDeadEyeEffectConfig GetRootAsIDeadEyeEffectConfig(ByteBuffer _bb)
		{
			return IDeadEyeEffectConfig.GetRootAsIDeadEyeEffectConfig(_bb, default(IDeadEyeEffectConfig));
		}

		// Token: 0x0602F79D RID: 194461 RVA: 0x006799BC File Offset: 0x00677BBC
		public static IDeadEyeEffectConfig GetRootAsIDeadEyeEffectConfig(ByteBuffer _bb, IDeadEyeEffectConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F79E RID: 194462 RVA: 0x006799D9 File Offset: 0x00677BD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F79F RID: 194463 RVA: 0x006799E8 File Offset: 0x00677BE8
		public IDeadEyeEffectConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CA5F RID: 51807
		// (get) Token: 0x0602F7A0 RID: 194464 RVA: 0x006799F8 File Offset: 0x00677BF8
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

		// Token: 0x0602F7A1 RID: 194465 RVA: 0x00679A2F File Offset: 0x00677C2F
		public Span<byte> GetFilterEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602F7A2 RID: 194466 RVA: 0x00679A3E File Offset: 0x00677C3E
		public byte[] GetFilterEffectArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700CA60 RID: 51808
		// (get) Token: 0x0602F7A3 RID: 194467 RVA: 0x00679A4C File Offset: 0x00677C4C
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

		// Token: 0x0602F7A4 RID: 194468 RVA: 0x00679A83 File Offset: 0x00677C83
		public Span<byte> GetTargetIdleMaterialDaBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602F7A5 RID: 194469 RVA: 0x00679A92 File Offset: 0x00677C92
		public byte[] GetTargetIdleMaterialDaArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700CA61 RID: 51809
		// (get) Token: 0x0602F7A6 RID: 194470 RVA: 0x00679AA0 File Offset: 0x00677CA0
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

		// Token: 0x0602F7A7 RID: 194471 RVA: 0x00679AD7 File Offset: 0x00677CD7
		public Span<byte> GetTargetLockedMaterialDaBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602F7A8 RID: 194472 RVA: 0x00679AE6 File Offset: 0x00677CE6
		public byte[] GetTargetLockedMaterialDaArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0602F7A9 RID: 194473 RVA: 0x00679AF4 File Offset: 0x00677CF4
		public static Offset<IDeadEyeEffectConfig> CreateIDeadEyeEffectConfig(FlatBufferBuilder builder, StringOffset FilterEffectOffset = default(StringOffset), StringOffset TargetIdleMaterialDaOffset = default(StringOffset), StringOffset TargetLockedMaterialDaOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IDeadEyeEffectConfig.AddTargetLockedMaterialDa(builder, TargetLockedMaterialDaOffset);
			IDeadEyeEffectConfig.AddTargetIdleMaterialDa(builder, TargetIdleMaterialDaOffset);
			IDeadEyeEffectConfig.AddFilterEffect(builder, FilterEffectOffset);
			return IDeadEyeEffectConfig.EndIDeadEyeEffectConfig(builder);
		}

		// Token: 0x0602F7AA RID: 194474 RVA: 0x00679B18 File Offset: 0x00677D18
		public static void StartIDeadEyeEffectConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602F7AB RID: 194475 RVA: 0x00679B21 File Offset: 0x00677D21
		public static void AddFilterEffect(FlatBufferBuilder builder, StringOffset filterEffectOffset)
		{
			builder.AddOffset(0, filterEffectOffset.Value, 0);
		}

		// Token: 0x0602F7AC RID: 194476 RVA: 0x00679B31 File Offset: 0x00677D31
		public static void AddTargetIdleMaterialDa(FlatBufferBuilder builder, StringOffset targetIdleMaterialDaOffset)
		{
			builder.AddOffset(1, targetIdleMaterialDaOffset.Value, 0);
		}

		// Token: 0x0602F7AD RID: 194477 RVA: 0x00679B41 File Offset: 0x00677D41
		public static void AddTargetLockedMaterialDa(FlatBufferBuilder builder, StringOffset targetLockedMaterialDaOffset)
		{
			builder.AddOffset(2, targetLockedMaterialDaOffset.Value, 0);
		}

		// Token: 0x0602F7AE RID: 194478 RVA: 0x00679B51 File Offset: 0x00677D51
		public static Offset<IDeadEyeEffectConfig> EndIDeadEyeEffectConfig(FlatBufferBuilder builder)
		{
			return new Offset<IDeadEyeEffectConfig>(builder.EndTable());
		}

		// Token: 0x0602F7AF RID: 194479 RVA: 0x00679B60 File Offset: 0x00677D60
		public IDeadEyeEffectConfigT UnPack()
		{
			IDeadEyeEffectConfigT deadEyeEffectConfigT = new IDeadEyeEffectConfigT();
			this.UnPackTo(deadEyeEffectConfigT);
			return deadEyeEffectConfigT;
		}

		// Token: 0x0602F7B0 RID: 194480 RVA: 0x00679B7B File Offset: 0x00677D7B
		public void UnPackTo(IDeadEyeEffectConfigT _o)
		{
			_o.FilterEffect = this.FilterEffect;
			_o.TargetIdleMaterialDa = this.TargetIdleMaterialDa;
			_o.TargetLockedMaterialDa = this.TargetLockedMaterialDa;
		}

		// Token: 0x0602F7B1 RID: 194481 RVA: 0x00679BA4 File Offset: 0x00677DA4
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

		// Token: 0x040119BA RID: 72122
		private Table __p;
	}
}
