using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DC4 RID: 32196
	public struct IVisualNovelPlayScreenEffectConfigBase : IFlatbufferObject
	{
		// Token: 0x1700F136 RID: 61750
		// (get) Token: 0x0603A2E9 RID: 238313 RVA: 0x007D7D47 File Offset: 0x007D5F47
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603A2EA RID: 238314 RVA: 0x007D7D54 File Offset: 0x007D5F54
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603A2EB RID: 238315 RVA: 0x007D7D5C File Offset: 0x007D5F5C
		public static IVisualNovelPlayScreenEffectConfigBase GetRootAsIVisualNovelPlayScreenEffectConfigBase(ByteBuffer _bb)
		{
			return IVisualNovelPlayScreenEffectConfigBase.GetRootAsIVisualNovelPlayScreenEffectConfigBase(_bb, default(IVisualNovelPlayScreenEffectConfigBase));
		}

		// Token: 0x0603A2EC RID: 238316 RVA: 0x007D7D78 File Offset: 0x007D5F78
		public static IVisualNovelPlayScreenEffectConfigBase GetRootAsIVisualNovelPlayScreenEffectConfigBase(ByteBuffer _bb, IVisualNovelPlayScreenEffectConfigBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603A2ED RID: 238317 RVA: 0x007D7D95 File Offset: 0x007D5F95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603A2EE RID: 238318 RVA: 0x007D7DA4 File Offset: 0x007D5FA4
		public IVisualNovelPlayScreenEffectConfigBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F137 RID: 61751
		// (get) Token: 0x0603A2EF RID: 238319 RVA: 0x007D7DB4 File Offset: 0x007D5FB4
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

		// Token: 0x0603A2F0 RID: 238320 RVA: 0x007D7DF0 File Offset: 0x007D5FF0
		public static Offset<IVisualNovelPlayScreenEffectConfigBase> CreateIVisualNovelPlayScreenEffectConfigBase(FlatBufferBuilder builder, EVisualNovelScreenEffectType Type = EVisualNovelScreenEffectType.OneShot)
		{
			builder.StartTable(1);
			IVisualNovelPlayScreenEffectConfigBase.AddType(builder, Type);
			return IVisualNovelPlayScreenEffectConfigBase.EndIVisualNovelPlayScreenEffectConfigBase(builder);
		}

		// Token: 0x0603A2F1 RID: 238321 RVA: 0x007D7E06 File Offset: 0x007D6006
		public static void StartIVisualNovelPlayScreenEffectConfigBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603A2F2 RID: 238322 RVA: 0x007D7E0F File Offset: 0x007D600F
		public static void AddType(FlatBufferBuilder builder, EVisualNovelScreenEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603A2F3 RID: 238323 RVA: 0x007D7E1A File Offset: 0x007D601A
		public static Offset<IVisualNovelPlayScreenEffectConfigBase> EndIVisualNovelPlayScreenEffectConfigBase(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelPlayScreenEffectConfigBase>(builder.EndTable());
		}

		// Token: 0x0603A2F4 RID: 238324 RVA: 0x007D7E28 File Offset: 0x007D6028
		public IVisualNovelPlayScreenEffectConfigBaseT UnPack()
		{
			IVisualNovelPlayScreenEffectConfigBaseT visualNovelPlayScreenEffectConfigBaseT = new IVisualNovelPlayScreenEffectConfigBaseT();
			this.UnPackTo(visualNovelPlayScreenEffectConfigBaseT);
			return visualNovelPlayScreenEffectConfigBaseT;
		}

		// Token: 0x0603A2F5 RID: 238325 RVA: 0x007D7E43 File Offset: 0x007D6043
		public void UnPackTo(IVisualNovelPlayScreenEffectConfigBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603A2F6 RID: 238326 RVA: 0x007D7E54 File Offset: 0x007D6054
		public static Offset<IVisualNovelPlayScreenEffectConfigBase> Pack(FlatBufferBuilder builder, IVisualNovelPlayScreenEffectConfigBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelPlayScreenEffectConfigBase>);
			}
			return IVisualNovelPlayScreenEffectConfigBase.CreateIVisualNovelPlayScreenEffectConfigBase(builder, _o.Type);
		}

		// Token: 0x04013556 RID: 79190
		private Table __p;
	}
}
