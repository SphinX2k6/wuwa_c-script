using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D88 RID: 32136
	public struct IVisualNovelOptionGroupFullScreen : IFlatbufferObject
	{
		// Token: 0x1700F063 RID: 61539
		// (get) Token: 0x0603A01E RID: 237598 RVA: 0x007D1EB4 File Offset: 0x007D00B4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603A01F RID: 237599 RVA: 0x007D1EC1 File Offset: 0x007D00C1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603A020 RID: 237600 RVA: 0x007D1EC8 File Offset: 0x007D00C8
		public static IVisualNovelOptionGroupFullScreen GetRootAsIVisualNovelOptionGroupFullScreen(ByteBuffer _bb)
		{
			return IVisualNovelOptionGroupFullScreen.GetRootAsIVisualNovelOptionGroupFullScreen(_bb, default(IVisualNovelOptionGroupFullScreen));
		}

		// Token: 0x0603A021 RID: 237601 RVA: 0x007D1EE4 File Offset: 0x007D00E4
		public static IVisualNovelOptionGroupFullScreen GetRootAsIVisualNovelOptionGroupFullScreen(ByteBuffer _bb, IVisualNovelOptionGroupFullScreen obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603A022 RID: 237602 RVA: 0x007D1F01 File Offset: 0x007D0101
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603A023 RID: 237603 RVA: 0x007D1F10 File Offset: 0x007D0110
		public IVisualNovelOptionGroupFullScreen __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F064 RID: 61540
		// (get) Token: 0x0603A024 RID: 237604 RVA: 0x007D1F20 File Offset: 0x007D0120
		public EVisualNovelOptionGroupType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVisualNovelOptionGroupType.Normal;
				}
				return (EVisualNovelOptionGroupType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603A025 RID: 237605 RVA: 0x007D1F5C File Offset: 0x007D015C
		public static Offset<IVisualNovelOptionGroupFullScreen> CreateIVisualNovelOptionGroupFullScreen(FlatBufferBuilder builder, EVisualNovelOptionGroupType Type = EVisualNovelOptionGroupType.Normal)
		{
			builder.StartTable(1);
			IVisualNovelOptionGroupFullScreen.AddType(builder, Type);
			return IVisualNovelOptionGroupFullScreen.EndIVisualNovelOptionGroupFullScreen(builder);
		}

		// Token: 0x0603A026 RID: 237606 RVA: 0x007D1F72 File Offset: 0x007D0172
		public static void StartIVisualNovelOptionGroupFullScreen(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603A027 RID: 237607 RVA: 0x007D1F7B File Offset: 0x007D017B
		public static void AddType(FlatBufferBuilder builder, EVisualNovelOptionGroupType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603A028 RID: 237608 RVA: 0x007D1F86 File Offset: 0x007D0186
		public static Offset<IVisualNovelOptionGroupFullScreen> EndIVisualNovelOptionGroupFullScreen(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelOptionGroupFullScreen>(builder.EndTable());
		}

		// Token: 0x0603A029 RID: 237609 RVA: 0x007D1F94 File Offset: 0x007D0194
		public IVisualNovelOptionGroupFullScreenT UnPack()
		{
			IVisualNovelOptionGroupFullScreenT visualNovelOptionGroupFullScreenT = new IVisualNovelOptionGroupFullScreenT();
			this.UnPackTo(visualNovelOptionGroupFullScreenT);
			return visualNovelOptionGroupFullScreenT;
		}

		// Token: 0x0603A02A RID: 237610 RVA: 0x007D1FAF File Offset: 0x007D01AF
		public void UnPackTo(IVisualNovelOptionGroupFullScreenT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603A02B RID: 237611 RVA: 0x007D1FC0 File Offset: 0x007D01C0
		public static Offset<IVisualNovelOptionGroupFullScreen> Pack(FlatBufferBuilder builder, IVisualNovelOptionGroupFullScreenT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelOptionGroupFullScreen>);
			}
			return IVisualNovelOptionGroupFullScreen.CreateIVisualNovelOptionGroupFullScreen(builder, _o.Type);
		}

		// Token: 0x040134CF RID: 79055
		private Table __p;
	}
}
