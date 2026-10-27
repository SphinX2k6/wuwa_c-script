using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E46 RID: 28230
	public struct IRemoveEffectBase : IFlatbufferObject
	{
		// Token: 0x1700D255 RID: 53845
		// (get) Token: 0x06031E28 RID: 204328 RVA: 0x006C0267 File Offset: 0x006BE467
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031E29 RID: 204329 RVA: 0x006C0274 File Offset: 0x006BE474
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031E2A RID: 204330 RVA: 0x006C027C File Offset: 0x006BE47C
		public static IRemoveEffectBase GetRootAsIRemoveEffectBase(ByteBuffer _bb)
		{
			return IRemoveEffectBase.GetRootAsIRemoveEffectBase(_bb, default(IRemoveEffectBase));
		}

		// Token: 0x06031E2B RID: 204331 RVA: 0x006C0298 File Offset: 0x006BE498
		public static IRemoveEffectBase GetRootAsIRemoveEffectBase(ByteBuffer _bb, IRemoveEffectBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031E2C RID: 204332 RVA: 0x006C02B5 File Offset: 0x006BE4B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031E2D RID: 204333 RVA: 0x006C02C4 File Offset: 0x006BE4C4
		public IRemoveEffectBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D256 RID: 53846
		// (get) Token: 0x06031E2E RID: 204334 RVA: 0x006C02D4 File Offset: 0x006BE4D4
		public EEffectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEffectType.Effect;
				}
				return (EEffectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D257 RID: 53847
		// (get) Token: 0x06031E2F RID: 204335 RVA: 0x006C0310 File Offset: 0x006BE510
		public string Path
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

		// Token: 0x06031E30 RID: 204336 RVA: 0x006C0347 File Offset: 0x006BE547
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06031E31 RID: 204337 RVA: 0x006C0356 File Offset: 0x006BE556
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06031E32 RID: 204338 RVA: 0x006C0364 File Offset: 0x006BE564
		public static Offset<IRemoveEffectBase> CreateIRemoveEffectBase(FlatBufferBuilder builder, EEffectType Type = EEffectType.Effect, StringOffset PathOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IRemoveEffectBase.AddPath(builder, PathOffset);
			IRemoveEffectBase.AddType(builder, Type);
			return IRemoveEffectBase.EndIRemoveEffectBase(builder);
		}

		// Token: 0x06031E33 RID: 204339 RVA: 0x006C0381 File Offset: 0x006BE581
		public static void StartIRemoveEffectBase(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031E34 RID: 204340 RVA: 0x006C038A File Offset: 0x006BE58A
		public static void AddType(FlatBufferBuilder builder, EEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031E35 RID: 204341 RVA: 0x006C0395 File Offset: 0x006BE595
		public static void AddPath(FlatBufferBuilder builder, StringOffset pathOffset)
		{
			builder.AddOffset(1, pathOffset.Value, 0);
		}

		// Token: 0x06031E36 RID: 204342 RVA: 0x006C03A5 File Offset: 0x006BE5A5
		public static Offset<IRemoveEffectBase> EndIRemoveEffectBase(FlatBufferBuilder builder)
		{
			return new Offset<IRemoveEffectBase>(builder.EndTable());
		}

		// Token: 0x06031E37 RID: 204343 RVA: 0x006C03B4 File Offset: 0x006BE5B4
		public IRemoveEffectBaseT UnPack()
		{
			IRemoveEffectBaseT removeEffectBaseT = new IRemoveEffectBaseT();
			this.UnPackTo(removeEffectBaseT);
			return removeEffectBaseT;
		}

		// Token: 0x06031E38 RID: 204344 RVA: 0x006C03CF File Offset: 0x006BE5CF
		public void UnPackTo(IRemoveEffectBaseT _o)
		{
			_o.Type = this.Type;
			_o.Path = this.Path;
		}

		// Token: 0x06031E39 RID: 204345 RVA: 0x006C03EC File Offset: 0x006BE5EC
		public static Offset<IRemoveEffectBase> Pack(FlatBufferBuilder builder, IRemoveEffectBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRemoveEffectBase>);
			}
			StringOffset pathOffset = (_o.Path == null) ? default(StringOffset) : builder.CreateString(_o.Path);
			return IRemoveEffectBase.CreateIRemoveEffectBase(builder, _o.Type, pathOffset);
		}

		// Token: 0x04011829 RID: 71721
		private Table __p;
	}
}
