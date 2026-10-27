using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005258 RID: 21080
	public struct IFireBoxFishEffect : IFlatbufferObject
	{
		// Token: 0x17009A66 RID: 39526
		// (get) Token: 0x0602249F RID: 140447 RVA: 0x004C12C0 File Offset: 0x004BF4C0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060224A0 RID: 140448 RVA: 0x004C12CD File Offset: 0x004BF4CD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060224A1 RID: 140449 RVA: 0x004C12D4 File Offset: 0x004BF4D4
		public static IFireBoxFishEffect GetRootAsIFireBoxFishEffect(ByteBuffer _bb)
		{
			return IFireBoxFishEffect.GetRootAsIFireBoxFishEffect(_bb, default(IFireBoxFishEffect));
		}

		// Token: 0x060224A2 RID: 140450 RVA: 0x004C12F0 File Offset: 0x004BF4F0
		public static IFireBoxFishEffect GetRootAsIFireBoxFishEffect(ByteBuffer _bb, IFireBoxFishEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060224A3 RID: 140451 RVA: 0x004C130D File Offset: 0x004BF50D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060224A4 RID: 140452 RVA: 0x004C131C File Offset: 0x004BF51C
		public IFireBoxFishEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009A67 RID: 39527
		// (get) Token: 0x060224A5 RID: 140453 RVA: 0x004C132C File Offset: 0x004BF52C
		public EGraph3dEffectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGraph3dEffectType.FireBoxFish;
				}
				return (EGraph3dEffectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009A68 RID: 39528
		// (get) Token: 0x060224A6 RID: 140454 RVA: 0x004C1368 File Offset: 0x004BF568
		public string Effect
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

		// Token: 0x060224A7 RID: 140455 RVA: 0x004C139F File Offset: 0x004BF59F
		public Span<byte> GetEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060224A8 RID: 140456 RVA: 0x004C13AE File Offset: 0x004BF5AE
		public byte[] GetEffectArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060224A9 RID: 140457 RVA: 0x004C13BC File Offset: 0x004BF5BC
		public static Offset<IFireBoxFishEffect> CreateIFireBoxFishEffect(FlatBufferBuilder builder, EGraph3dEffectType Type = EGraph3dEffectType.FireBoxFish, StringOffset EffectOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IFireBoxFishEffect.AddEffect(builder, EffectOffset);
			IFireBoxFishEffect.AddType(builder, Type);
			return IFireBoxFishEffect.EndIFireBoxFishEffect(builder);
		}

		// Token: 0x060224AA RID: 140458 RVA: 0x004C13D9 File Offset: 0x004BF5D9
		public static void StartIFireBoxFishEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060224AB RID: 140459 RVA: 0x004C13E2 File Offset: 0x004BF5E2
		public static void AddType(FlatBufferBuilder builder, EGraph3dEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060224AC RID: 140460 RVA: 0x004C13ED File Offset: 0x004BF5ED
		public static void AddEffect(FlatBufferBuilder builder, StringOffset effectOffset)
		{
			builder.AddOffset(1, effectOffset.Value, 0);
		}

		// Token: 0x060224AD RID: 140461 RVA: 0x004C13FD File Offset: 0x004BF5FD
		public static Offset<IFireBoxFishEffect> EndIFireBoxFishEffect(FlatBufferBuilder builder)
		{
			return new Offset<IFireBoxFishEffect>(builder.EndTable());
		}

		// Token: 0x060224AE RID: 140462 RVA: 0x004C140C File Offset: 0x004BF60C
		public IFireBoxFishEffectT UnPack()
		{
			IFireBoxFishEffectT fireBoxFishEffectT = new IFireBoxFishEffectT();
			this.UnPackTo(fireBoxFishEffectT);
			return fireBoxFishEffectT;
		}

		// Token: 0x060224AF RID: 140463 RVA: 0x004C1427 File Offset: 0x004BF627
		public void UnPackTo(IFireBoxFishEffectT _o)
		{
			_o.Type = this.Type;
			_o.Effect = this.Effect;
		}

		// Token: 0x060224B0 RID: 140464 RVA: 0x004C1444 File Offset: 0x004BF644
		public static Offset<IFireBoxFishEffect> Pack(FlatBufferBuilder builder, IFireBoxFishEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFireBoxFishEffect>);
			}
			StringOffset effectOffset = (_o.Effect == null) ? default(StringOffset) : builder.CreateString(_o.Effect);
			return IFireBoxFishEffect.CreateIFireBoxFishEffect(builder, _o.Type, effectOffset);
		}

		// Token: 0x0400E3A9 RID: 58281
		private Table __p;
	}
}
