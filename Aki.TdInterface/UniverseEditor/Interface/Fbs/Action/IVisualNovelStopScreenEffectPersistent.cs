using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DEB RID: 32235
	public struct IVisualNovelStopScreenEffectPersistent : IFlatbufferObject
	{
		// Token: 0x1700F17A RID: 61818
		// (get) Token: 0x0603A40B RID: 238603 RVA: 0x007D98E6 File Offset: 0x007D7AE6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603A40C RID: 238604 RVA: 0x007D98F3 File Offset: 0x007D7AF3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603A40D RID: 238605 RVA: 0x007D98FC File Offset: 0x007D7AFC
		public static IVisualNovelStopScreenEffectPersistent GetRootAsIVisualNovelStopScreenEffectPersistent(ByteBuffer _bb)
		{
			return IVisualNovelStopScreenEffectPersistent.GetRootAsIVisualNovelStopScreenEffectPersistent(_bb, default(IVisualNovelStopScreenEffectPersistent));
		}

		// Token: 0x0603A40E RID: 238606 RVA: 0x007D9918 File Offset: 0x007D7B18
		public static IVisualNovelStopScreenEffectPersistent GetRootAsIVisualNovelStopScreenEffectPersistent(ByteBuffer _bb, IVisualNovelStopScreenEffectPersistent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603A40F RID: 238607 RVA: 0x007D9935 File Offset: 0x007D7B35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603A410 RID: 238608 RVA: 0x007D9944 File Offset: 0x007D7B44
		public IVisualNovelStopScreenEffectPersistent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F17B RID: 61819
		// (get) Token: 0x0603A411 RID: 238609 RVA: 0x007D9954 File Offset: 0x007D7B54
		public EVisualNovelStopScreenEffectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVisualNovelStopScreenEffectType.Persistent;
				}
				return (EVisualNovelStopScreenEffectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700F17C RID: 61820
		// (get) Token: 0x0603A412 RID: 238610 RVA: 0x007D9990 File Offset: 0x007D7B90
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

		// Token: 0x0603A413 RID: 238611 RVA: 0x007D99C7 File Offset: 0x007D7BC7
		public Span<byte> GetPersistentEffectPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0603A414 RID: 238612 RVA: 0x007D99D6 File Offset: 0x007D7BD6
		public byte[] GetPersistentEffectPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0603A415 RID: 238613 RVA: 0x007D99E4 File Offset: 0x007D7BE4
		public static Offset<IVisualNovelStopScreenEffectPersistent> CreateIVisualNovelStopScreenEffectPersistent(FlatBufferBuilder builder, EVisualNovelStopScreenEffectType Type = EVisualNovelStopScreenEffectType.Persistent, StringOffset PersistentEffectPathOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IVisualNovelStopScreenEffectPersistent.AddPersistentEffectPath(builder, PersistentEffectPathOffset);
			IVisualNovelStopScreenEffectPersistent.AddType(builder, Type);
			return IVisualNovelStopScreenEffectPersistent.EndIVisualNovelStopScreenEffectPersistent(builder);
		}

		// Token: 0x0603A416 RID: 238614 RVA: 0x007D9A01 File Offset: 0x007D7C01
		public static void StartIVisualNovelStopScreenEffectPersistent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603A417 RID: 238615 RVA: 0x007D9A0A File Offset: 0x007D7C0A
		public static void AddType(FlatBufferBuilder builder, EVisualNovelStopScreenEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603A418 RID: 238616 RVA: 0x007D9A15 File Offset: 0x007D7C15
		public static void AddPersistentEffectPath(FlatBufferBuilder builder, StringOffset persistentEffectPathOffset)
		{
			builder.AddOffset(1, persistentEffectPathOffset.Value, 0);
		}

		// Token: 0x0603A419 RID: 238617 RVA: 0x007D9A25 File Offset: 0x007D7C25
		public static Offset<IVisualNovelStopScreenEffectPersistent> EndIVisualNovelStopScreenEffectPersistent(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelStopScreenEffectPersistent>(builder.EndTable());
		}

		// Token: 0x0603A41A RID: 238618 RVA: 0x007D9A34 File Offset: 0x007D7C34
		public IVisualNovelStopScreenEffectPersistentT UnPack()
		{
			IVisualNovelStopScreenEffectPersistentT visualNovelStopScreenEffectPersistentT = new IVisualNovelStopScreenEffectPersistentT();
			this.UnPackTo(visualNovelStopScreenEffectPersistentT);
			return visualNovelStopScreenEffectPersistentT;
		}

		// Token: 0x0603A41B RID: 238619 RVA: 0x007D9A4F File Offset: 0x007D7C4F
		public void UnPackTo(IVisualNovelStopScreenEffectPersistentT _o)
		{
			_o.Type = this.Type;
			_o.PersistentEffectPath = this.PersistentEffectPath;
		}

		// Token: 0x0603A41C RID: 238620 RVA: 0x007D9A6C File Offset: 0x007D7C6C
		public static Offset<IVisualNovelStopScreenEffectPersistent> Pack(FlatBufferBuilder builder, IVisualNovelStopScreenEffectPersistentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelStopScreenEffectPersistent>);
			}
			StringOffset persistentEffectPathOffset = (_o.PersistentEffectPath == null) ? default(StringOffset) : builder.CreateString(_o.PersistentEffectPath);
			return IVisualNovelStopScreenEffectPersistent.CreateIVisualNovelStopScreenEffectPersistent(builder, _o.Type, persistentEffectPathOffset);
		}

		// Token: 0x0401358E RID: 79246
		private Table __p;
	}
}
