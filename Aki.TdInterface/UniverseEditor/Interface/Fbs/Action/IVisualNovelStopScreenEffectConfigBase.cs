using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DE5 RID: 32229
	public struct IVisualNovelStopScreenEffectConfigBase : IFlatbufferObject
	{
		// Token: 0x1700F175 RID: 61813
		// (get) Token: 0x0603A3ED RID: 238573 RVA: 0x007D9674 File Offset: 0x007D7874
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603A3EE RID: 238574 RVA: 0x007D9681 File Offset: 0x007D7881
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603A3EF RID: 238575 RVA: 0x007D9688 File Offset: 0x007D7888
		public static IVisualNovelStopScreenEffectConfigBase GetRootAsIVisualNovelStopScreenEffectConfigBase(ByteBuffer _bb)
		{
			return IVisualNovelStopScreenEffectConfigBase.GetRootAsIVisualNovelStopScreenEffectConfigBase(_bb, default(IVisualNovelStopScreenEffectConfigBase));
		}

		// Token: 0x0603A3F0 RID: 238576 RVA: 0x007D96A4 File Offset: 0x007D78A4
		public static IVisualNovelStopScreenEffectConfigBase GetRootAsIVisualNovelStopScreenEffectConfigBase(ByteBuffer _bb, IVisualNovelStopScreenEffectConfigBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603A3F1 RID: 238577 RVA: 0x007D96C1 File Offset: 0x007D78C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603A3F2 RID: 238578 RVA: 0x007D96D0 File Offset: 0x007D78D0
		public IVisualNovelStopScreenEffectConfigBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F176 RID: 61814
		// (get) Token: 0x0603A3F3 RID: 238579 RVA: 0x007D96E0 File Offset: 0x007D78E0
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

		// Token: 0x0603A3F4 RID: 238580 RVA: 0x007D971C File Offset: 0x007D791C
		public static Offset<IVisualNovelStopScreenEffectConfigBase> CreateIVisualNovelStopScreenEffectConfigBase(FlatBufferBuilder builder, EVisualNovelStopScreenEffectType Type = EVisualNovelStopScreenEffectType.Persistent)
		{
			builder.StartTable(1);
			IVisualNovelStopScreenEffectConfigBase.AddType(builder, Type);
			return IVisualNovelStopScreenEffectConfigBase.EndIVisualNovelStopScreenEffectConfigBase(builder);
		}

		// Token: 0x0603A3F5 RID: 238581 RVA: 0x007D9732 File Offset: 0x007D7932
		public static void StartIVisualNovelStopScreenEffectConfigBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603A3F6 RID: 238582 RVA: 0x007D973B File Offset: 0x007D793B
		public static void AddType(FlatBufferBuilder builder, EVisualNovelStopScreenEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603A3F7 RID: 238583 RVA: 0x007D9746 File Offset: 0x007D7946
		public static Offset<IVisualNovelStopScreenEffectConfigBase> EndIVisualNovelStopScreenEffectConfigBase(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelStopScreenEffectConfigBase>(builder.EndTable());
		}

		// Token: 0x0603A3F8 RID: 238584 RVA: 0x007D9754 File Offset: 0x007D7954
		public IVisualNovelStopScreenEffectConfigBaseT UnPack()
		{
			IVisualNovelStopScreenEffectConfigBaseT visualNovelStopScreenEffectConfigBaseT = new IVisualNovelStopScreenEffectConfigBaseT();
			this.UnPackTo(visualNovelStopScreenEffectConfigBaseT);
			return visualNovelStopScreenEffectConfigBaseT;
		}

		// Token: 0x0603A3F9 RID: 238585 RVA: 0x007D976F File Offset: 0x007D796F
		public void UnPackTo(IVisualNovelStopScreenEffectConfigBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603A3FA RID: 238586 RVA: 0x007D9780 File Offset: 0x007D7980
		public static Offset<IVisualNovelStopScreenEffectConfigBase> Pack(FlatBufferBuilder builder, IVisualNovelStopScreenEffectConfigBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelStopScreenEffectConfigBase>);
			}
			return IVisualNovelStopScreenEffectConfigBase.CreateIVisualNovelStopScreenEffectConfigBase(builder, _o.Type);
		}

		// Token: 0x04013586 RID: 79238
		private Table __p;
	}
}
