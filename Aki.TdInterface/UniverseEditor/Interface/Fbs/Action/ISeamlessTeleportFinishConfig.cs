using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007708 RID: 30472
	public struct ISeamlessTeleportFinishConfig : IFlatbufferObject
	{
		// Token: 0x1700DF78 RID: 57208
		// (get) Token: 0x06035769 RID: 218985 RVA: 0x0072B480 File Offset: 0x00729680
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603576A RID: 218986 RVA: 0x0072B48D File Offset: 0x0072968D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603576B RID: 218987 RVA: 0x0072B494 File Offset: 0x00729694
		public static ISeamlessTeleportFinishConfig GetRootAsISeamlessTeleportFinishConfig(ByteBuffer _bb)
		{
			return ISeamlessTeleportFinishConfig.GetRootAsISeamlessTeleportFinishConfig(_bb, default(ISeamlessTeleportFinishConfig));
		}

		// Token: 0x0603576C RID: 218988 RVA: 0x0072B4B0 File Offset: 0x007296B0
		public static ISeamlessTeleportFinishConfig GetRootAsISeamlessTeleportFinishConfig(ByteBuffer _bb, ISeamlessTeleportFinishConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603576D RID: 218989 RVA: 0x0072B4CD File Offset: 0x007296CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603576E RID: 218990 RVA: 0x0072B4DC File Offset: 0x007296DC
		public ISeamlessTeleportFinishConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DF79 RID: 57209
		// (get) Token: 0x0603576F RID: 218991 RVA: 0x0072B4EC File Offset: 0x007296EC
		public bool IsNotStopScreenEffect
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DF7A RID: 57210
		// (get) Token: 0x06035770 RID: 218992 RVA: 0x0072B52C File Offset: 0x0072972C
		public int EffectExtraState
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

		// Token: 0x1700DF7B RID: 57211
		// (get) Token: 0x06035771 RID: 218993 RVA: 0x0072B568 File Offset: 0x00729768
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035772 RID: 218994 RVA: 0x0072B5A4 File Offset: 0x007297A4
		public static Offset<ISeamlessTeleportFinishConfig> CreateISeamlessTeleportFinishConfig(FlatBufferBuilder builder, bool IsNotStopScreenEffect = false, int EffectExtraState = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			ISeamlessTeleportFinishConfig.AddEffectExtraState(builder, EffectExtraState);
			ISeamlessTeleportFinishConfig.AddNullMask(builder, NullMask);
			ISeamlessTeleportFinishConfig.AddIsNotStopScreenEffect(builder, IsNotStopScreenEffect);
			return ISeamlessTeleportFinishConfig.EndISeamlessTeleportFinishConfig(builder);
		}

		// Token: 0x06035773 RID: 218995 RVA: 0x0072B5C8 File Offset: 0x007297C8
		public static void StartISeamlessTeleportFinishConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06035774 RID: 218996 RVA: 0x0072B5D1 File Offset: 0x007297D1
		public static void AddIsNotStopScreenEffect(FlatBufferBuilder builder, bool isNotStopScreenEffect)
		{
			builder.AddBool(0, isNotStopScreenEffect, false);
		}

		// Token: 0x06035775 RID: 218997 RVA: 0x0072B5DC File Offset: 0x007297DC
		public static void AddEffectExtraState(FlatBufferBuilder builder, int effectExtraState)
		{
			builder.AddInt(1, effectExtraState, 0);
		}

		// Token: 0x06035776 RID: 218998 RVA: 0x0072B5E7 File Offset: 0x007297E7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06035777 RID: 218999 RVA: 0x0072B5F2 File Offset: 0x007297F2
		public static Offset<ISeamlessTeleportFinishConfig> EndISeamlessTeleportFinishConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISeamlessTeleportFinishConfig>(builder.EndTable());
		}

		// Token: 0x06035778 RID: 219000 RVA: 0x0072B600 File Offset: 0x00729800
		public ISeamlessTeleportFinishConfigT UnPack()
		{
			ISeamlessTeleportFinishConfigT seamlessTeleportFinishConfigT = new ISeamlessTeleportFinishConfigT();
			this.UnPackTo(seamlessTeleportFinishConfigT);
			return seamlessTeleportFinishConfigT;
		}

		// Token: 0x06035779 RID: 219001 RVA: 0x0072B61B File Offset: 0x0072981B
		public void UnPackTo(ISeamlessTeleportFinishConfigT _o)
		{
			_o.IsNotStopScreenEffect = this.IsNotStopScreenEffect;
			_o.EffectExtraState = this.EffectExtraState;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603577A RID: 219002 RVA: 0x0072B644 File Offset: 0x00729844
		public static Offset<ISeamlessTeleportFinishConfig> Pack(FlatBufferBuilder builder, ISeamlessTeleportFinishConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISeamlessTeleportFinishConfig>);
			}
			return ISeamlessTeleportFinishConfig.CreateISeamlessTeleportFinishConfig(builder, _o.IsNotStopScreenEffect, _o.EffectExtraState, _o.NullMask);
		}

		// Token: 0x04012920 RID: 76064
		private Table __p;
	}
}
