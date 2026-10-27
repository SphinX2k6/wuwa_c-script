using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x0200490E RID: 18702
	public struct ILoopTeleportClientPlayEffectLogic : IFlatbufferObject
	{
		// Token: 0x17008796 RID: 34710
		// (get) Token: 0x0601D3C2 RID: 119746 RVA: 0x0041FB8C File Offset: 0x0041DD8C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D3C3 RID: 119747 RVA: 0x0041FB99 File Offset: 0x0041DD99
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D3C4 RID: 119748 RVA: 0x0041FBA0 File Offset: 0x0041DDA0
		public static ILoopTeleportClientPlayEffectLogic GetRootAsILoopTeleportClientPlayEffectLogic(ByteBuffer _bb)
		{
			return ILoopTeleportClientPlayEffectLogic.GetRootAsILoopTeleportClientPlayEffectLogic(_bb, default(ILoopTeleportClientPlayEffectLogic));
		}

		// Token: 0x0601D3C5 RID: 119749 RVA: 0x0041FBBC File Offset: 0x0041DDBC
		public static ILoopTeleportClientPlayEffectLogic GetRootAsILoopTeleportClientPlayEffectLogic(ByteBuffer _bb, ILoopTeleportClientPlayEffectLogic obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D3C6 RID: 119750 RVA: 0x0041FBD9 File Offset: 0x0041DDD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D3C7 RID: 119751 RVA: 0x0041FBE8 File Offset: 0x0041DDE8
		public ILoopTeleportClientPlayEffectLogic __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008797 RID: 34711
		// (get) Token: 0x0601D3C8 RID: 119752 RVA: 0x0041FBF8 File Offset: 0x0041DDF8
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

		// Token: 0x17008798 RID: 34712
		// (get) Token: 0x0601D3C9 RID: 119753 RVA: 0x0041FC34 File Offset: 0x0041DE34
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

		// Token: 0x0601D3CA RID: 119754 RVA: 0x0041FC70 File Offset: 0x0041DE70
		public TTable? EffectConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601D3CB RID: 119755 RVA: 0x0041FCB4 File Offset: 0x0041DEB4
		public ILoopTeleportClientMpcEffect EffectConfigAsILoopTeleportClientMpcEffect()
		{
			return this.EffectConfig<ILoopTeleportClientMpcEffect>().Value;
		}

		// Token: 0x0601D3CC RID: 119756 RVA: 0x0041FCD0 File Offset: 0x0041DED0
		public ILoopTeleportClientScreenEffect EffectConfigAsILoopTeleportClientScreenEffect()
		{
			return this.EffectConfig<ILoopTeleportClientScreenEffect>().Value;
		}

		// Token: 0x0601D3CD RID: 119757 RVA: 0x0041FCEB File Offset: 0x0041DEEB
		public static Offset<ILoopTeleportClientPlayEffectLogic> CreateILoopTeleportClientPlayEffectLogic(FlatBufferBuilder builder, ELoopTeleportClientLogicType Type = ELoopTeleportClientLogicType.PlayEffect, TLoopTeleportClientPlayEffect EffectConfig_type = TLoopTeleportClientPlayEffect.NONE, int EffectConfigOffset = 0)
		{
			builder.StartTable(3);
			ILoopTeleportClientPlayEffectLogic.AddEffectConfig(builder, EffectConfigOffset);
			ILoopTeleportClientPlayEffectLogic.AddEffectConfigType(builder, EffectConfig_type);
			ILoopTeleportClientPlayEffectLogic.AddType(builder, Type);
			return ILoopTeleportClientPlayEffectLogic.EndILoopTeleportClientPlayEffectLogic(builder);
		}

		// Token: 0x0601D3CE RID: 119758 RVA: 0x0041FD0F File Offset: 0x0041DF0F
		public static void StartILoopTeleportClientPlayEffectLogic(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601D3CF RID: 119759 RVA: 0x0041FD18 File Offset: 0x0041DF18
		public static void AddType(FlatBufferBuilder builder, ELoopTeleportClientLogicType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D3D0 RID: 119760 RVA: 0x0041FD23 File Offset: 0x0041DF23
		public static void AddEffectConfigType(FlatBufferBuilder builder, TLoopTeleportClientPlayEffect effectConfigType)
		{
			builder.AddByte(1, (byte)effectConfigType, 0);
		}

		// Token: 0x0601D3D1 RID: 119761 RVA: 0x0041FD2E File Offset: 0x0041DF2E
		public static void AddEffectConfig(FlatBufferBuilder builder, int effectConfigOffset)
		{
			builder.AddOffset(2, effectConfigOffset, 0);
		}

		// Token: 0x0601D3D2 RID: 119762 RVA: 0x0041FD39 File Offset: 0x0041DF39
		public static Offset<ILoopTeleportClientPlayEffectLogic> EndILoopTeleportClientPlayEffectLogic(FlatBufferBuilder builder)
		{
			return new Offset<ILoopTeleportClientPlayEffectLogic>(builder.EndTable());
		}

		// Token: 0x0601D3D3 RID: 119763 RVA: 0x0041FD48 File Offset: 0x0041DF48
		public ILoopTeleportClientPlayEffectLogicT UnPack()
		{
			ILoopTeleportClientPlayEffectLogicT loopTeleportClientPlayEffectLogicT = new ILoopTeleportClientPlayEffectLogicT();
			this.UnPackTo(loopTeleportClientPlayEffectLogicT);
			return loopTeleportClientPlayEffectLogicT;
		}

		// Token: 0x0601D3D4 RID: 119764 RVA: 0x0041FD64 File Offset: 0x0041DF64
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

		// Token: 0x0601D3D5 RID: 119765 RVA: 0x0041FE14 File Offset: 0x0041E014
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

		// Token: 0x0400CF82 RID: 53122
		private Table __p;
	}
}
