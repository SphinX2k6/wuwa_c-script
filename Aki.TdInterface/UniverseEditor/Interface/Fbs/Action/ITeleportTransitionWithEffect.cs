using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073B5 RID: 29621
	public struct ITeleportTransitionWithEffect : IFlatbufferObject
	{
		// Token: 0x1700E0E4 RID: 57572
		// (get) Token: 0x06035C7C RID: 220284 RVA: 0x00752094 File Offset: 0x00750294
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035C7D RID: 220285 RVA: 0x007520A1 File Offset: 0x007502A1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035C7E RID: 220286 RVA: 0x007520A8 File Offset: 0x007502A8
		public static ITeleportTransitionWithEffect GetRootAsITeleportTransitionWithEffect(ByteBuffer _bb)
		{
			return ITeleportTransitionWithEffect.GetRootAsITeleportTransitionWithEffect(_bb, default(ITeleportTransitionWithEffect));
		}

		// Token: 0x06035C7F RID: 220287 RVA: 0x007520C4 File Offset: 0x007502C4
		public static ITeleportTransitionWithEffect GetRootAsITeleportTransitionWithEffect(ByteBuffer _bb, ITeleportTransitionWithEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035C80 RID: 220288 RVA: 0x007520E1 File Offset: 0x007502E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035C81 RID: 220289 RVA: 0x007520F0 File Offset: 0x007502F0
		public ITeleportTransitionWithEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E0E5 RID: 57573
		// (get) Token: 0x06035C82 RID: 220290 RVA: 0x00752100 File Offset: 0x00750300
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

		// Token: 0x1700E0E6 RID: 57574
		// (get) Token: 0x06035C83 RID: 220291 RVA: 0x0075213C File Offset: 0x0075033C
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

		// Token: 0x06035C84 RID: 220292 RVA: 0x00752173 File Offset: 0x00750373
		public Span<byte> GetEffectDaPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06035C85 RID: 220293 RVA: 0x00752182 File Offset: 0x00750382
		public byte[] GetEffectDaPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06035C86 RID: 220294 RVA: 0x00752190 File Offset: 0x00750390
		public static Offset<ITeleportTransitionWithEffect> CreateITeleportTransitionWithEffect(FlatBufferBuilder builder, ETeleportTransitionType Type = ETeleportTransitionType.PlayMp4, StringOffset EffectDaPathOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ITeleportTransitionWithEffect.AddEffectDaPath(builder, EffectDaPathOffset);
			ITeleportTransitionWithEffect.AddType(builder, Type);
			return ITeleportTransitionWithEffect.EndITeleportTransitionWithEffect(builder);
		}

		// Token: 0x06035C87 RID: 220295 RVA: 0x007521AD File Offset: 0x007503AD
		public static void StartITeleportTransitionWithEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06035C88 RID: 220296 RVA: 0x007521B6 File Offset: 0x007503B6
		public static void AddType(FlatBufferBuilder builder, ETeleportTransitionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035C89 RID: 220297 RVA: 0x007521C1 File Offset: 0x007503C1
		public static void AddEffectDaPath(FlatBufferBuilder builder, StringOffset effectDaPathOffset)
		{
			builder.AddOffset(1, effectDaPathOffset.Value, 0);
		}

		// Token: 0x06035C8A RID: 220298 RVA: 0x007521D1 File Offset: 0x007503D1
		public static Offset<ITeleportTransitionWithEffect> EndITeleportTransitionWithEffect(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportTransitionWithEffect>(builder.EndTable());
		}

		// Token: 0x06035C8B RID: 220299 RVA: 0x007521E0 File Offset: 0x007503E0
		public ITeleportTransitionWithEffectT UnPack()
		{
			ITeleportTransitionWithEffectT teleportTransitionWithEffectT = new ITeleportTransitionWithEffectT();
			this.UnPackTo(teleportTransitionWithEffectT);
			return teleportTransitionWithEffectT;
		}

		// Token: 0x06035C8C RID: 220300 RVA: 0x007521FB File Offset: 0x007503FB
		public void UnPackTo(ITeleportTransitionWithEffectT _o)
		{
			_o.Type = this.Type;
			_o.EffectDaPath = this.EffectDaPath;
		}

		// Token: 0x06035C8D RID: 220301 RVA: 0x00752218 File Offset: 0x00750418
		public static Offset<ITeleportTransitionWithEffect> Pack(FlatBufferBuilder builder, ITeleportTransitionWithEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportTransitionWithEffect>);
			}
			StringOffset effectDaPathOffset = (_o.EffectDaPath == null) ? default(StringOffset) : builder.CreateString(_o.EffectDaPath);
			return ITeleportTransitionWithEffect.CreateITeleportTransitionWithEffect(builder, _o.Type, effectDaPathOffset);
		}

		// Token: 0x040121EF RID: 74223
		private Table __p;
	}
}
