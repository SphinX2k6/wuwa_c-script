using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B9C RID: 31644
	public struct ITeleportTransitionWithEffect : IFlatbufferObject
	{
		// Token: 0x1700ECF4 RID: 60660
		// (get) Token: 0x06039017 RID: 233495 RVA: 0x007B45D4 File Offset: 0x007B27D4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039018 RID: 233496 RVA: 0x007B45E1 File Offset: 0x007B27E1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039019 RID: 233497 RVA: 0x007B45E8 File Offset: 0x007B27E8
		public static ITeleportTransitionWithEffect GetRootAsITeleportTransitionWithEffect(ByteBuffer _bb)
		{
			return ITeleportTransitionWithEffect.GetRootAsITeleportTransitionWithEffect(_bb, default(ITeleportTransitionWithEffect));
		}

		// Token: 0x0603901A RID: 233498 RVA: 0x007B4604 File Offset: 0x007B2804
		public static ITeleportTransitionWithEffect GetRootAsITeleportTransitionWithEffect(ByteBuffer _bb, ITeleportTransitionWithEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603901B RID: 233499 RVA: 0x007B4621 File Offset: 0x007B2821
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603901C RID: 233500 RVA: 0x007B4630 File Offset: 0x007B2830
		public ITeleportTransitionWithEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ECF5 RID: 60661
		// (get) Token: 0x0603901D RID: 233501 RVA: 0x007B4640 File Offset: 0x007B2840
		public ETeleportTransitionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETeleportTransitionType.PlayMp4;
				}
				return (ETeleportTransitionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700ECF6 RID: 60662
		// (get) Token: 0x0603901E RID: 233502 RVA: 0x007B467C File Offset: 0x007B287C
		public string EffectDaPath
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

		// Token: 0x0603901F RID: 233503 RVA: 0x007B46B3 File Offset: 0x007B28B3
		public Span<byte> GetEffectDaPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06039020 RID: 233504 RVA: 0x007B46C2 File Offset: 0x007B28C2
		public byte[] GetEffectDaPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06039021 RID: 233505 RVA: 0x007B46D0 File Offset: 0x007B28D0
		public static Offset<ITeleportTransitionWithEffect> CreateITeleportTransitionWithEffect(FlatBufferBuilder builder, ETeleportTransitionType Type = ETeleportTransitionType.PlayMp4, StringOffset EffectDaPathOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ITeleportTransitionWithEffect.AddEffectDaPath(builder, EffectDaPathOffset);
			ITeleportTransitionWithEffect.AddType(builder, Type);
			return ITeleportTransitionWithEffect.EndITeleportTransitionWithEffect(builder);
		}

		// Token: 0x06039022 RID: 233506 RVA: 0x007B46ED File Offset: 0x007B28ED
		public static void StartITeleportTransitionWithEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06039023 RID: 233507 RVA: 0x007B46F6 File Offset: 0x007B28F6
		public static void AddType(FlatBufferBuilder builder, ETeleportTransitionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06039024 RID: 233508 RVA: 0x007B4701 File Offset: 0x007B2901
		public static void AddEffectDaPath(FlatBufferBuilder builder, StringOffset effectDaPathOffset)
		{
			builder.AddOffset(1, effectDaPathOffset.Value, 0);
		}

		// Token: 0x06039025 RID: 233509 RVA: 0x007B4711 File Offset: 0x007B2911
		public static Offset<ITeleportTransitionWithEffect> EndITeleportTransitionWithEffect(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportTransitionWithEffect>(builder.EndTable());
		}

		// Token: 0x06039026 RID: 233510 RVA: 0x007B4720 File Offset: 0x007B2920
		public ITeleportTransitionWithEffectT UnPack()
		{
			ITeleportTransitionWithEffectT teleportTransitionWithEffectT = new ITeleportTransitionWithEffectT();
			this.UnPackTo(teleportTransitionWithEffectT);
			return teleportTransitionWithEffectT;
		}

		// Token: 0x06039027 RID: 233511 RVA: 0x007B473B File Offset: 0x007B293B
		public void UnPackTo(ITeleportTransitionWithEffectT _o)
		{
			_o.Type = this.Type;
			_o.EffectDaPath = this.EffectDaPath;
		}

		// Token: 0x06039028 RID: 233512 RVA: 0x007B4758 File Offset: 0x007B2958
		public static Offset<ITeleportTransitionWithEffect> Pack(FlatBufferBuilder builder, ITeleportTransitionWithEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportTransitionWithEffect>);
			}
			StringOffset effectDaPathOffset = (_o.EffectDaPath == null) ? default(StringOffset) : builder.CreateString(_o.EffectDaPath);
			return ITeleportTransitionWithEffect.CreateITeleportTransitionWithEffect(builder, _o.Type, effectDaPathOffset);
		}

		// Token: 0x04013208 RID: 78344
		private Table __p;
	}
}
