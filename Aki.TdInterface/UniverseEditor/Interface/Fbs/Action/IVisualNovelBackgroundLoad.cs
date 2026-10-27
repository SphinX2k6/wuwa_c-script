using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007562 RID: 30050
	public struct IVisualNovelBackgroundLoad : IFlatbufferObject
	{
		// Token: 0x1700E3EE RID: 58350
		// (get) Token: 0x06036AAC RID: 223916 RVA: 0x0076CA49 File Offset: 0x0076AC49
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036AAD RID: 223917 RVA: 0x0076CA56 File Offset: 0x0076AC56
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036AAE RID: 223918 RVA: 0x0076CA60 File Offset: 0x0076AC60
		public static IVisualNovelBackgroundLoad GetRootAsIVisualNovelBackgroundLoad(ByteBuffer _bb)
		{
			return IVisualNovelBackgroundLoad.GetRootAsIVisualNovelBackgroundLoad(_bb, default(IVisualNovelBackgroundLoad));
		}

		// Token: 0x06036AAF RID: 223919 RVA: 0x0076CA7C File Offset: 0x0076AC7C
		public static IVisualNovelBackgroundLoad GetRootAsIVisualNovelBackgroundLoad(ByteBuffer _bb, IVisualNovelBackgroundLoad obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036AB0 RID: 223920 RVA: 0x0076CA99 File Offset: 0x0076AC99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036AB1 RID: 223921 RVA: 0x0076CAA8 File Offset: 0x0076ACA8
		public IVisualNovelBackgroundLoad __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E3EF RID: 58351
		// (get) Token: 0x06036AB2 RID: 223922 RVA: 0x0076CAB8 File Offset: 0x0076ACB8
		public EVisualNovelBackgroundType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVisualNovelBackgroundType.Load;
				}
				return (EVisualNovelBackgroundType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E3F0 RID: 58352
		// (get) Token: 0x06036AB3 RID: 223923 RVA: 0x0076CAF4 File Offset: 0x0076ACF4
		public int BackgroundId
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

		// Token: 0x06036AB4 RID: 223924 RVA: 0x0076CB30 File Offset: 0x0076AD30
		public static Offset<IVisualNovelBackgroundLoad> CreateIVisualNovelBackgroundLoad(FlatBufferBuilder builder, EVisualNovelBackgroundType Type = EVisualNovelBackgroundType.Load, int BackgroundId = 0)
		{
			builder.StartTable(2);
			IVisualNovelBackgroundLoad.AddBackgroundId(builder, BackgroundId);
			IVisualNovelBackgroundLoad.AddType(builder, Type);
			return IVisualNovelBackgroundLoad.EndIVisualNovelBackgroundLoad(builder);
		}

		// Token: 0x06036AB5 RID: 223925 RVA: 0x0076CB4D File Offset: 0x0076AD4D
		public static void StartIVisualNovelBackgroundLoad(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06036AB6 RID: 223926 RVA: 0x0076CB56 File Offset: 0x0076AD56
		public static void AddType(FlatBufferBuilder builder, EVisualNovelBackgroundType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036AB7 RID: 223927 RVA: 0x0076CB61 File Offset: 0x0076AD61
		public static void AddBackgroundId(FlatBufferBuilder builder, int backgroundId)
		{
			builder.AddInt(1, backgroundId, 0);
		}

		// Token: 0x06036AB8 RID: 223928 RVA: 0x0076CB6C File Offset: 0x0076AD6C
		public static Offset<IVisualNovelBackgroundLoad> EndIVisualNovelBackgroundLoad(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelBackgroundLoad>(builder.EndTable());
		}

		// Token: 0x06036AB9 RID: 223929 RVA: 0x0076CB7C File Offset: 0x0076AD7C
		public IVisualNovelBackgroundLoadT UnPack()
		{
			IVisualNovelBackgroundLoadT visualNovelBackgroundLoadT = new IVisualNovelBackgroundLoadT();
			this.UnPackTo(visualNovelBackgroundLoadT);
			return visualNovelBackgroundLoadT;
		}

		// Token: 0x06036ABA RID: 223930 RVA: 0x0076CB97 File Offset: 0x0076AD97
		public void UnPackTo(IVisualNovelBackgroundLoadT _o)
		{
			_o.Type = this.Type;
			_o.BackgroundId = this.BackgroundId;
		}

		// Token: 0x06036ABB RID: 223931 RVA: 0x0076CBB4 File Offset: 0x0076ADB4
		public static Offset<IVisualNovelBackgroundLoad> Pack(FlatBufferBuilder builder, IVisualNovelBackgroundLoadT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelBackgroundLoad>);
			}
			return IVisualNovelBackgroundLoad.CreateIVisualNovelBackgroundLoad(builder, _o.Type, _o.BackgroundId);
		}

		// Token: 0x0401245E RID: 74846
		private Table __p;
	}
}
