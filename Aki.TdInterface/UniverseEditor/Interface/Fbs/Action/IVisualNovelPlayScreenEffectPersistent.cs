using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DD0 RID: 32208
	public struct IVisualNovelPlayScreenEffectPersistent : IFlatbufferObject
	{
		// Token: 0x1700F145 RID: 61765
		// (get) Token: 0x0603A339 RID: 238393 RVA: 0x007D847D File Offset: 0x007D667D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603A33A RID: 238394 RVA: 0x007D848A File Offset: 0x007D668A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603A33B RID: 238395 RVA: 0x007D8494 File Offset: 0x007D6694
		public static IVisualNovelPlayScreenEffectPersistent GetRootAsIVisualNovelPlayScreenEffectPersistent(ByteBuffer _bb)
		{
			return IVisualNovelPlayScreenEffectPersistent.GetRootAsIVisualNovelPlayScreenEffectPersistent(_bb, default(IVisualNovelPlayScreenEffectPersistent));
		}

		// Token: 0x0603A33C RID: 238396 RVA: 0x007D84B0 File Offset: 0x007D66B0
		public static IVisualNovelPlayScreenEffectPersistent GetRootAsIVisualNovelPlayScreenEffectPersistent(ByteBuffer _bb, IVisualNovelPlayScreenEffectPersistent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603A33D RID: 238397 RVA: 0x007D84CD File Offset: 0x007D66CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603A33E RID: 238398 RVA: 0x007D84DC File Offset: 0x007D66DC
		public IVisualNovelPlayScreenEffectPersistent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F146 RID: 61766
		// (get) Token: 0x0603A33F RID: 238399 RVA: 0x007D84EC File Offset: 0x007D66EC
		public EVisualNovelScreenEffectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVisualNovelScreenEffectType.OneShot;
				}
				return (EVisualNovelScreenEffectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700F147 RID: 61767
		// (get) Token: 0x0603A340 RID: 238400 RVA: 0x007D8528 File Offset: 0x007D6728
		public string PersistentEffectPath
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

		// Token: 0x0603A341 RID: 238401 RVA: 0x007D855F File Offset: 0x007D675F
		public Span<byte> GetPersistentEffectPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0603A342 RID: 238402 RVA: 0x007D856E File Offset: 0x007D676E
		public byte[] GetPersistentEffectPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0603A343 RID: 238403 RVA: 0x007D857C File Offset: 0x007D677C
		public static Offset<IVisualNovelPlayScreenEffectPersistent> CreateIVisualNovelPlayScreenEffectPersistent(FlatBufferBuilder builder, EVisualNovelScreenEffectType Type = EVisualNovelScreenEffectType.OneShot, StringOffset PersistentEffectPathOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IVisualNovelPlayScreenEffectPersistent.AddPersistentEffectPath(builder, PersistentEffectPathOffset);
			IVisualNovelPlayScreenEffectPersistent.AddType(builder, Type);
			return IVisualNovelPlayScreenEffectPersistent.EndIVisualNovelPlayScreenEffectPersistent(builder);
		}

		// Token: 0x0603A344 RID: 238404 RVA: 0x007D8599 File Offset: 0x007D6799
		public static void StartIVisualNovelPlayScreenEffectPersistent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603A345 RID: 238405 RVA: 0x007D85A2 File Offset: 0x007D67A2
		public static void AddType(FlatBufferBuilder builder, EVisualNovelScreenEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603A346 RID: 238406 RVA: 0x007D85AD File Offset: 0x007D67AD
		public static void AddPersistentEffectPath(FlatBufferBuilder builder, StringOffset persistentEffectPathOffset)
		{
			builder.AddOffset(1, persistentEffectPathOffset.Value, 0);
		}

		// Token: 0x0603A347 RID: 238407 RVA: 0x007D85BD File Offset: 0x007D67BD
		public static Offset<IVisualNovelPlayScreenEffectPersistent> EndIVisualNovelPlayScreenEffectPersistent(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelPlayScreenEffectPersistent>(builder.EndTable());
		}

		// Token: 0x0603A348 RID: 238408 RVA: 0x007D85CC File Offset: 0x007D67CC
		public IVisualNovelPlayScreenEffectPersistentT UnPack()
		{
			IVisualNovelPlayScreenEffectPersistentT visualNovelPlayScreenEffectPersistentT = new IVisualNovelPlayScreenEffectPersistentT();
			this.UnPackTo(visualNovelPlayScreenEffectPersistentT);
			return visualNovelPlayScreenEffectPersistentT;
		}

		// Token: 0x0603A349 RID: 238409 RVA: 0x007D85E7 File Offset: 0x007D67E7
		public void UnPackTo(IVisualNovelPlayScreenEffectPersistentT _o)
		{
			_o.Type = this.Type;
			_o.PersistentEffectPath = this.PersistentEffectPath;
		}

		// Token: 0x0603A34A RID: 238410 RVA: 0x007D8604 File Offset: 0x007D6804
		public static Offset<IVisualNovelPlayScreenEffectPersistent> Pack(FlatBufferBuilder builder, IVisualNovelPlayScreenEffectPersistentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelPlayScreenEffectPersistent>);
			}
			StringOffset persistentEffectPathOffset = (_o.PersistentEffectPath == null) ? default(StringOffset) : builder.CreateString(_o.PersistentEffectPath);
			return IVisualNovelPlayScreenEffectPersistent.CreateIVisualNovelPlayScreenEffectPersistent(builder, _o.Type, persistentEffectPathOffset);
		}

		// Token: 0x04013566 RID: 79206
		private Table __p;
	}
}
