using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F4E RID: 28494
	public struct ISeamlessTeleportFinishConfig : IFlatbufferObject
	{
		// Token: 0x1700D3B9 RID: 54201
		// (get) Token: 0x06032569 RID: 206185 RVA: 0x006CC1C4 File Offset: 0x006CA3C4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603256A RID: 206186 RVA: 0x006CC1D1 File Offset: 0x006CA3D1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603256B RID: 206187 RVA: 0x006CC1D8 File Offset: 0x006CA3D8
		public static ISeamlessTeleportFinishConfig GetRootAsISeamlessTeleportFinishConfig(ByteBuffer _bb)
		{
			return ISeamlessTeleportFinishConfig.GetRootAsISeamlessTeleportFinishConfig(_bb, default(ISeamlessTeleportFinishConfig));
		}

		// Token: 0x0603256C RID: 206188 RVA: 0x006CC1F4 File Offset: 0x006CA3F4
		public static ISeamlessTeleportFinishConfig GetRootAsISeamlessTeleportFinishConfig(ByteBuffer _bb, ISeamlessTeleportFinishConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603256D RID: 206189 RVA: 0x006CC211 File Offset: 0x006CA411
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603256E RID: 206190 RVA: 0x006CC220 File Offset: 0x006CA420
		public ISeamlessTeleportFinishConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D3BA RID: 54202
		// (get) Token: 0x0603256F RID: 206191 RVA: 0x006CC230 File Offset: 0x006CA430
		public bool IsNotStopScreenEffect
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D3BB RID: 54203
		// (get) Token: 0x06032570 RID: 206192 RVA: 0x006CC270 File Offset: 0x006CA470
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

		// Token: 0x1700D3BC RID: 54204
		// (get) Token: 0x06032571 RID: 206193 RVA: 0x006CC2AC File Offset: 0x006CA4AC
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

		// Token: 0x06032572 RID: 206194 RVA: 0x006CC2E8 File Offset: 0x006CA4E8
		public static Offset<ISeamlessTeleportFinishConfig> CreateISeamlessTeleportFinishConfig(FlatBufferBuilder builder, bool IsNotStopScreenEffect = false, int EffectExtraState = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			ISeamlessTeleportFinishConfig.AddEffectExtraState(builder, EffectExtraState);
			ISeamlessTeleportFinishConfig.AddNullMask(builder, NullMask);
			ISeamlessTeleportFinishConfig.AddIsNotStopScreenEffect(builder, IsNotStopScreenEffect);
			return ISeamlessTeleportFinishConfig.EndISeamlessTeleportFinishConfig(builder);
		}

		// Token: 0x06032573 RID: 206195 RVA: 0x006CC30C File Offset: 0x006CA50C
		public static void StartISeamlessTeleportFinishConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06032574 RID: 206196 RVA: 0x006CC315 File Offset: 0x006CA515
		public static void AddIsNotStopScreenEffect(FlatBufferBuilder builder, bool isNotStopScreenEffect)
		{
			builder.AddBool(0, isNotStopScreenEffect, false);
		}

		// Token: 0x06032575 RID: 206197 RVA: 0x006CC320 File Offset: 0x006CA520
		public static void AddEffectExtraState(FlatBufferBuilder builder, int effectExtraState)
		{
			builder.AddInt(1, effectExtraState, 0);
		}

		// Token: 0x06032576 RID: 206198 RVA: 0x006CC32B File Offset: 0x006CA52B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06032577 RID: 206199 RVA: 0x006CC336 File Offset: 0x006CA536
		public static Offset<ISeamlessTeleportFinishConfig> EndISeamlessTeleportFinishConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISeamlessTeleportFinishConfig>(builder.EndTable());
		}

		// Token: 0x06032578 RID: 206200 RVA: 0x006CC344 File Offset: 0x006CA544
		public ISeamlessTeleportFinishConfigT UnPack()
		{
			ISeamlessTeleportFinishConfigT seamlessTeleportFinishConfigT = new ISeamlessTeleportFinishConfigT();
			this.UnPackTo(seamlessTeleportFinishConfigT);
			return seamlessTeleportFinishConfigT;
		}

		// Token: 0x06032579 RID: 206201 RVA: 0x006CC35F File Offset: 0x006CA55F
		public void UnPackTo(ISeamlessTeleportFinishConfigT _o)
		{
			_o.IsNotStopScreenEffect = this.IsNotStopScreenEffect;
			_o.EffectExtraState = this.EffectExtraState;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603257A RID: 206202 RVA: 0x006CC388 File Offset: 0x006CA588
		public static Offset<ISeamlessTeleportFinishConfig> Pack(FlatBufferBuilder builder, ISeamlessTeleportFinishConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISeamlessTeleportFinishConfig>);
			}
			return ISeamlessTeleportFinishConfig.CreateISeamlessTeleportFinishConfig(builder, _o.IsNotStopScreenEffect, _o.EffectExtraState, _o.NullMask);
		}

		// Token: 0x04011948 RID: 72008
		private Table __p;
	}
}
