using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DCD RID: 32205
	public struct IVisualNovelPlayScreenEffectOneShot : IFlatbufferObject
	{
		// Token: 0x1700F140 RID: 61760
		// (get) Token: 0x0603A321 RID: 238369 RVA: 0x007D824A File Offset: 0x007D644A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603A322 RID: 238370 RVA: 0x007D8257 File Offset: 0x007D6457
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603A323 RID: 238371 RVA: 0x007D8260 File Offset: 0x007D6460
		public static IVisualNovelPlayScreenEffectOneShot GetRootAsIVisualNovelPlayScreenEffectOneShot(ByteBuffer _bb)
		{
			return IVisualNovelPlayScreenEffectOneShot.GetRootAsIVisualNovelPlayScreenEffectOneShot(_bb, default(IVisualNovelPlayScreenEffectOneShot));
		}

		// Token: 0x0603A324 RID: 238372 RVA: 0x007D827C File Offset: 0x007D647C
		public static IVisualNovelPlayScreenEffectOneShot GetRootAsIVisualNovelPlayScreenEffectOneShot(ByteBuffer _bb, IVisualNovelPlayScreenEffectOneShot obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603A325 RID: 238373 RVA: 0x007D8299 File Offset: 0x007D6499
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603A326 RID: 238374 RVA: 0x007D82A8 File Offset: 0x007D64A8
		public IVisualNovelPlayScreenEffectOneShot __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F141 RID: 61761
		// (get) Token: 0x0603A327 RID: 238375 RVA: 0x007D82B8 File Offset: 0x007D64B8
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

		// Token: 0x1700F142 RID: 61762
		// (get) Token: 0x0603A328 RID: 238376 RVA: 0x007D82F4 File Offset: 0x007D64F4
		public string OneShotEffectPath
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

		// Token: 0x0603A329 RID: 238377 RVA: 0x007D832B File Offset: 0x007D652B
		public Span<byte> GetOneShotEffectPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0603A32A RID: 238378 RVA: 0x007D833A File Offset: 0x007D653A
		public byte[] GetOneShotEffectPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0603A32B RID: 238379 RVA: 0x007D8348 File Offset: 0x007D6548
		public static Offset<IVisualNovelPlayScreenEffectOneShot> CreateIVisualNovelPlayScreenEffectOneShot(FlatBufferBuilder builder, EVisualNovelScreenEffectType Type = EVisualNovelScreenEffectType.OneShot, StringOffset OneShotEffectPathOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IVisualNovelPlayScreenEffectOneShot.AddOneShotEffectPath(builder, OneShotEffectPathOffset);
			IVisualNovelPlayScreenEffectOneShot.AddType(builder, Type);
			return IVisualNovelPlayScreenEffectOneShot.EndIVisualNovelPlayScreenEffectOneShot(builder);
		}

		// Token: 0x0603A32C RID: 238380 RVA: 0x007D8365 File Offset: 0x007D6565
		public static void StartIVisualNovelPlayScreenEffectOneShot(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603A32D RID: 238381 RVA: 0x007D836E File Offset: 0x007D656E
		public static void AddType(FlatBufferBuilder builder, EVisualNovelScreenEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603A32E RID: 238382 RVA: 0x007D8379 File Offset: 0x007D6579
		public static void AddOneShotEffectPath(FlatBufferBuilder builder, StringOffset oneShotEffectPathOffset)
		{
			builder.AddOffset(1, oneShotEffectPathOffset.Value, 0);
		}

		// Token: 0x0603A32F RID: 238383 RVA: 0x007D8389 File Offset: 0x007D6589
		public static Offset<IVisualNovelPlayScreenEffectOneShot> EndIVisualNovelPlayScreenEffectOneShot(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelPlayScreenEffectOneShot>(builder.EndTable());
		}

		// Token: 0x0603A330 RID: 238384 RVA: 0x007D8398 File Offset: 0x007D6598
		public IVisualNovelPlayScreenEffectOneShotT UnPack()
		{
			IVisualNovelPlayScreenEffectOneShotT visualNovelPlayScreenEffectOneShotT = new IVisualNovelPlayScreenEffectOneShotT();
			this.UnPackTo(visualNovelPlayScreenEffectOneShotT);
			return visualNovelPlayScreenEffectOneShotT;
		}

		// Token: 0x0603A331 RID: 238385 RVA: 0x007D83B3 File Offset: 0x007D65B3
		public void UnPackTo(IVisualNovelPlayScreenEffectOneShotT _o)
		{
			_o.Type = this.Type;
			_o.OneShotEffectPath = this.OneShotEffectPath;
		}

		// Token: 0x0603A332 RID: 238386 RVA: 0x007D83D0 File Offset: 0x007D65D0
		public static Offset<IVisualNovelPlayScreenEffectOneShot> Pack(FlatBufferBuilder builder, IVisualNovelPlayScreenEffectOneShotT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelPlayScreenEffectOneShot>);
			}
			StringOffset oneShotEffectPathOffset = (_o.OneShotEffectPath == null) ? default(StringOffset) : builder.CreateString(_o.OneShotEffectPath);
			return IVisualNovelPlayScreenEffectOneShot.CreateIVisualNovelPlayScreenEffectOneShot(builder, _o.Type, oneShotEffectPathOffset);
		}

		// Token: 0x04013563 RID: 79203
		private Table __p;
	}
}
