using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D67 RID: 32103
	public struct IVisualNovelCgLoadPrefab : IFlatbufferObject
	{
		// Token: 0x1700F02A RID: 61482
		// (get) Token: 0x06039F22 RID: 237346 RVA: 0x007D056E File Offset: 0x007CE76E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039F23 RID: 237347 RVA: 0x007D057B File Offset: 0x007CE77B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039F24 RID: 237348 RVA: 0x007D0584 File Offset: 0x007CE784
		public static IVisualNovelCgLoadPrefab GetRootAsIVisualNovelCgLoadPrefab(ByteBuffer _bb)
		{
			return IVisualNovelCgLoadPrefab.GetRootAsIVisualNovelCgLoadPrefab(_bb, default(IVisualNovelCgLoadPrefab));
		}

		// Token: 0x06039F25 RID: 237349 RVA: 0x007D05A0 File Offset: 0x007CE7A0
		public static IVisualNovelCgLoadPrefab GetRootAsIVisualNovelCgLoadPrefab(ByteBuffer _bb, IVisualNovelCgLoadPrefab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039F26 RID: 237350 RVA: 0x007D05BD File Offset: 0x007CE7BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039F27 RID: 237351 RVA: 0x007D05CC File Offset: 0x007CE7CC
		public IVisualNovelCgLoadPrefab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F02B RID: 61483
		// (get) Token: 0x06039F28 RID: 237352 RVA: 0x007D05DC File Offset: 0x007CE7DC
		public EVisualNovelCgType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVisualNovelCgType.LoadPrefab;
				}
				return (EVisualNovelCgType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700F02C RID: 61484
		// (get) Token: 0x06039F29 RID: 237353 RVA: 0x007D0618 File Offset: 0x007CE818
		public int PrefabId
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

		// Token: 0x1700F02D RID: 61485
		// (get) Token: 0x06039F2A RID: 237354 RVA: 0x007D0654 File Offset: 0x007CE854
		public string AnimationName
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

		// Token: 0x06039F2B RID: 237355 RVA: 0x007D068B File Offset: 0x007CE88B
		public Span<byte> GetAnimationNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06039F2C RID: 237356 RVA: 0x007D069A File Offset: 0x007CE89A
		public byte[] GetAnimationNameArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x06039F2D RID: 237357 RVA: 0x007D06A8 File Offset: 0x007CE8A8
		public static Offset<IVisualNovelCgLoadPrefab> CreateIVisualNovelCgLoadPrefab(FlatBufferBuilder builder, EVisualNovelCgType Type = EVisualNovelCgType.LoadPrefab, int PrefabId = 0, StringOffset AnimationNameOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IVisualNovelCgLoadPrefab.AddAnimationName(builder, AnimationNameOffset);
			IVisualNovelCgLoadPrefab.AddPrefabId(builder, PrefabId);
			IVisualNovelCgLoadPrefab.AddType(builder, Type);
			return IVisualNovelCgLoadPrefab.EndIVisualNovelCgLoadPrefab(builder);
		}

		// Token: 0x06039F2E RID: 237358 RVA: 0x007D06CC File Offset: 0x007CE8CC
		public static void StartIVisualNovelCgLoadPrefab(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06039F2F RID: 237359 RVA: 0x007D06D5 File Offset: 0x007CE8D5
		public static void AddType(FlatBufferBuilder builder, EVisualNovelCgType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06039F30 RID: 237360 RVA: 0x007D06E0 File Offset: 0x007CE8E0
		public static void AddPrefabId(FlatBufferBuilder builder, int prefabId)
		{
			builder.AddInt(1, prefabId, 0);
		}

		// Token: 0x06039F31 RID: 237361 RVA: 0x007D06EB File Offset: 0x007CE8EB
		public static void AddAnimationName(FlatBufferBuilder builder, StringOffset animationNameOffset)
		{
			builder.AddOffset(2, animationNameOffset.Value, 0);
		}

		// Token: 0x06039F32 RID: 237362 RVA: 0x007D06FB File Offset: 0x007CE8FB
		public static Offset<IVisualNovelCgLoadPrefab> EndIVisualNovelCgLoadPrefab(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelCgLoadPrefab>(builder.EndTable());
		}

		// Token: 0x06039F33 RID: 237363 RVA: 0x007D0708 File Offset: 0x007CE908
		public IVisualNovelCgLoadPrefabT UnPack()
		{
			IVisualNovelCgLoadPrefabT visualNovelCgLoadPrefabT = new IVisualNovelCgLoadPrefabT();
			this.UnPackTo(visualNovelCgLoadPrefabT);
			return visualNovelCgLoadPrefabT;
		}

		// Token: 0x06039F34 RID: 237364 RVA: 0x007D0723 File Offset: 0x007CE923
		public void UnPackTo(IVisualNovelCgLoadPrefabT _o)
		{
			_o.Type = this.Type;
			_o.PrefabId = this.PrefabId;
			_o.AnimationName = this.AnimationName;
		}

		// Token: 0x06039F35 RID: 237365 RVA: 0x007D074C File Offset: 0x007CE94C
		public static Offset<IVisualNovelCgLoadPrefab> Pack(FlatBufferBuilder builder, IVisualNovelCgLoadPrefabT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelCgLoadPrefab>);
			}
			StringOffset animationNameOffset = (_o.AnimationName == null) ? default(StringOffset) : builder.CreateString(_o.AnimationName);
			return IVisualNovelCgLoadPrefab.CreateIVisualNovelCgLoadPrefab(builder, _o.Type, _o.PrefabId, animationNameOffset);
		}

		// Token: 0x040134A1 RID: 79009
		private Table __p;
	}
}
