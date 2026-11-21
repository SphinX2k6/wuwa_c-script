using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004DA9 RID: 19881
	public struct ILoopTeleportClientPlayEffectLogic : IFlatbufferObject
	{
		// Token: 0x17008E39 RID: 36409
		// (get) Token: 0x0601ED5B RID: 126299 RVA: 0x0044F2EC File Offset: 0x0044D4EC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601ED5C RID: 126300 RVA: 0x0044F2F9 File Offset: 0x0044D4F9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601ED5D RID: 126301 RVA: 0x0044F300 File Offset: 0x0044D500
		public static ILoopTeleportClientPlayEffectLogic GetRootAsILoopTeleportClientPlayEffectLogic(ByteBuffer _bb)
		{
			return ILoopTeleportClientPlayEffectLogic.GetRootAsILoopTeleportClientPlayEffectLogic(_bb, default(ILoopTeleportClientPlayEffectLogic));
		}

		// Token: 0x0601ED5E RID: 126302 RVA: 0x0044F31C File Offset: 0x0044D51C
		public static ILoopTeleportClientPlayEffectLogic GetRootAsILoopTeleportClientPlayEffectLogic(ByteBuffer _bb, ILoopTeleportClientPlayEffectLogic obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601ED5F RID: 126303 RVA: 0x0044F339 File Offset: 0x0044D539
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601ED60 RID: 126304 RVA: 0x0044F348 File Offset: 0x0044D548
		public ILoopTeleportClientPlayEffectLogic __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008E3A RID: 36410
		// (get) Token: 0x0601ED61 RID: 126305 RVA: 0x0044F358 File Offset: 0x0044D558
		public ELoopTeleportClientLogicType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELoopTeleportClientLogicType.PlayEffect;
				}
				return (ELoopTeleportClientLogicType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008E3B RID: 36411
		// (get) Token: 0x0601ED62 RID: 126306 RVA: 0x0044F394 File Offset: 0x0044D594
		public TLoopTeleportClientPlayEffect EffectConfigType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TLoopTeleportClientPlayEffect.NONE;
				}
				return (TLoopTeleportClientPlayEffect)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601ED63 RID: 126307 RVA: 0x0044F3D0 File Offset: 0x0044D5D0
		public TTable? EffectConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601ED64 RID: 126308 RVA: 0x0044F414 File Offset: 0x0044D614
		public ILoopTeleportClientMpcEffect EffectConfigAsILoopTeleportClientMpcEffect()
		{
			return this.EffectConfig<ILoopTeleportClientMpcEffect>().Value;
		}

		// Token: 0x0601ED65 RID: 126309 RVA: 0x0044F430 File Offset: 0x0044D630
		public ILoopTeleportClientScreenEffect EffectConfigAsILoopTeleportClientScreenEffect()
		{
			return this.EffectConfig<ILoopTeleportClientScreenEffect>().Value;
		}

		// Token: 0x0601ED66 RID: 126310 RVA: 0x0044F44B File Offset: 0x0044D64B
		public static Offset<ILoopTeleportClientPlayEffectLogic> CreateILoopTeleportClientPlayEffectLogic(FlatBufferBuilder builder, ELoopTeleportClientLogicType Type = ELoopTeleportClientLogicType.PlayEffect, TLoopTeleportClientPlayEffect EffectConfig_type = TLoopTeleportClientPlayEffect.NONE, int EffectConfigOffset = 0)
		{
			builder.StartTable(3);
			ILoopTeleportClientPlayEffectLogic.AddEffectConfig(builder, EffectConfigOffset);
			ILoopTeleportClientPlayEffectLogic.AddEffectConfigType(builder, EffectConfig_type);
			ILoopTeleportClientPlayEffectLogic.AddType(builder, Type);
			return ILoopTeleportClientPlayEffectLogic.EndILoopTeleportClientPlayEffectLogic(builder);
		}

		// Token: 0x0601ED67 RID: 126311 RVA: 0x0044F46F File Offset: 0x0044D66F
		public static void StartILoopTeleportClientPlayEffectLogic(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601ED68 RID: 126312 RVA: 0x0044F478 File Offset: 0x0044D678
		public static void AddType(FlatBufferBuilder builder, ELoopTeleportClientLogicType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601ED69 RID: 126313 RVA: 0x0044F483 File Offset: 0x0044D683
		public static void AddEffectConfigType(FlatBufferBuilder builder, TLoopTeleportClientPlayEffect effectConfigType)
		{
			builder.AddByte(1, (byte)effectConfigType, 0);
		}

		// Token: 0x0601ED6A RID: 126314 RVA: 0x0044F48E File Offset: 0x0044D68E
		public static void AddEffectConfig(FlatBufferBuilder builder, int effectConfigOffset)
		{
			builder.AddOffset(2, effectConfigOffset, 0);
		}

		// Token: 0x0601ED6B RID: 126315 RVA: 0x0044F499 File Offset: 0x0044D699
		public static Offset<ILoopTeleportClientPlayEffectLogic> EndILoopTeleportClientPlayEffectLogic(FlatBufferBuilder builder)
		{
			return new Offset<ILoopTeleportClientPlayEffectLogic>(builder.EndTable());
		}

		// Token: 0x0601ED6C RID: 126316 RVA: 0x0044F4A8 File Offset: 0x0044D6A8
		public ILoopTeleportClientPlayEffectLogicT UnPack()
		{
			ILoopTeleportClientPlayEffectLogicT loopTeleportClientPlayEffectLogicT = new ILoopTeleportClientPlayEffectLogicT();
			this.UnPackTo(loopTeleportClientPlayEffectLogicT);
			return loopTeleportClientPlayEffectLogicT;
		}

		// Token: 0x0601ED6D RID: 126317 RVA: 0x0044F4C4 File Offset: 0x0044D6C4
		public void UnPackTo(ILoopTeleportClientPlayEffectLogicT _o)
		{
			_o.Type = this.Type;
			_o.EffectConfig = new TLoopTeleportClientPlayEffectUnion();
			_o.EffectConfig.Type = this.EffectConfigType;
			TLoopTeleportClientPlayEffect effectConfigType = this.EffectConfigType;
			if (effectConfigType == TLoopTeleportClientPlayEffect.ILoopTeleportClientMpcEffect)
			{
				_o.EffectConfig.Value = ((this.EffectConfig<ILoopTeleportClientMpcEffect>() != null) ? this.EffectConfig<ILoopTeleportClientMpcEffect>().Value.UnPack() : null);
				return;
			}
			if (effectConfigType != TLoopTeleportClientPlayEffect.ILoopTeleportClientScreenEffect)
			{
				return;
			}
			_o.EffectConfig.Value = ((this.EffectConfig<ILoopTeleportClientScreenEffect>() != null) ? this.EffectConfig<ILoopTeleportClientScreenEffect>().Value.UnPack() : null);
		}

		// Token: 0x0601ED6E RID: 126318 RVA: 0x0044F574 File Offset: 0x0044D774
		public static Offset<ILoopTeleportClientPlayEffectLogic> Pack(FlatBufferBuilder builder, ILoopTeleportClientPlayEffectLogicT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILoopTeleportClientPlayEffectLogic>);
			}
			TLoopTeleportClientPlayEffect effectConfig_type = (_o.EffectConfig == null) ? TLoopTeleportClientPlayEffect.NONE : _o.EffectConfig.Type;
			int effectConfigOffset = (_o.EffectConfig == null) ? 0 : TLoopTeleportClientPlayEffectUnion.Pack(builder, _o.EffectConfig);
			return ILoopTeleportClientPlayEffectLogic.CreateILoopTeleportClientPlayEffectLogic(builder, _o.Type, effectConfig_type, effectConfigOffset);
		}

		// Token: 0x0400DA0D RID: 55821
		private Table __p;
	}
}
