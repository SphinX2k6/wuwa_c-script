using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072DD RID: 29405
	public struct ITalkItemDisableAutoSelectOptionGroup : IFlatbufferObject
	{
		// Token: 0x1700DC76 RID: 56438
		// (get) Token: 0x06034B24 RID: 215844 RVA: 0x0071FAD5 File Offset: 0x0071DCD5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034B25 RID: 215845 RVA: 0x0071FAE2 File Offset: 0x0071DCE2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034B26 RID: 215846 RVA: 0x0071FAEC File Offset: 0x0071DCEC
		public static ITalkItemDisableAutoSelectOptionGroup GetRootAsITalkItemDisableAutoSelectOptionGroup(ByteBuffer _bb)
		{
			return ITalkItemDisableAutoSelectOptionGroup.GetRootAsITalkItemDisableAutoSelectOptionGroup(_bb, default(ITalkItemDisableAutoSelectOptionGroup));
		}

		// Token: 0x06034B27 RID: 215847 RVA: 0x0071FB08 File Offset: 0x0071DD08
		public static ITalkItemDisableAutoSelectOptionGroup GetRootAsITalkItemDisableAutoSelectOptionGroup(ByteBuffer _bb, ITalkItemDisableAutoSelectOptionGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034B28 RID: 215848 RVA: 0x0071FB25 File Offset: 0x0071DD25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034B29 RID: 215849 RVA: 0x0071FB34 File Offset: 0x0071DD34
		public ITalkItemDisableAutoSelectOptionGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DC77 RID: 56439
		// (get) Token: 0x06034B2A RID: 215850 RVA: 0x0071FB44 File Offset: 0x0071DD44
		public string TextKey
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06034B2B RID: 215851 RVA: 0x0071FB7B File Offset: 0x0071DD7B
		public Span<byte> GetTextKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06034B2C RID: 215852 RVA: 0x0071FB8A File Offset: 0x0071DD8A
		public byte[] GetTextKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700DC78 RID: 56440
		// (get) Token: 0x06034B2D RID: 215853 RVA: 0x0071FB98 File Offset: 0x0071DD98
		public int IconId
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

		// Token: 0x1700DC79 RID: 56441
		// (get) Token: 0x06034B2E RID: 215854 RVA: 0x0071FBD4 File Offset: 0x0071DDD4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06034B2F RID: 215855 RVA: 0x0071FC10 File Offset: 0x0071DE10
		public static Offset<ITalkItemDisableAutoSelectOptionGroup> CreateITalkItemDisableAutoSelectOptionGroup(FlatBufferBuilder builder, StringOffset TextKeyOffset = default(StringOffset), int IconId = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			ITalkItemDisableAutoSelectOptionGroup.AddIconId(builder, IconId);
			ITalkItemDisableAutoSelectOptionGroup.AddTextKey(builder, TextKeyOffset);
			ITalkItemDisableAutoSelectOptionGroup.AddNullMask(builder, NullMask);
			return ITalkItemDisableAutoSelectOptionGroup.EndITalkItemDisableAutoSelectOptionGroup(builder);
		}

		// Token: 0x06034B30 RID: 215856 RVA: 0x0071FC34 File Offset: 0x0071DE34
		public static void StartITalkItemDisableAutoSelectOptionGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06034B31 RID: 215857 RVA: 0x0071FC3D File Offset: 0x0071DE3D
		public static void AddTextKey(FlatBufferBuilder builder, StringOffset textKeyOffset)
		{
			builder.AddOffset(0, textKeyOffset.Value, 0);
		}

		// Token: 0x06034B32 RID: 215858 RVA: 0x0071FC4D File Offset: 0x0071DE4D
		public static void AddIconId(FlatBufferBuilder builder, int iconId)
		{
			builder.AddInt(1, iconId, 0);
		}

		// Token: 0x06034B33 RID: 215859 RVA: 0x0071FC58 File Offset: 0x0071DE58
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06034B34 RID: 215860 RVA: 0x0071FC63 File Offset: 0x0071DE63
		public static Offset<ITalkItemDisableAutoSelectOptionGroup> EndITalkItemDisableAutoSelectOptionGroup(FlatBufferBuilder builder)
		{
			return new Offset<ITalkItemDisableAutoSelectOptionGroup>(builder.EndTable());
		}

		// Token: 0x06034B35 RID: 215861 RVA: 0x0071FC70 File Offset: 0x0071DE70
		public ITalkItemDisableAutoSelectOptionGroupT UnPack()
		{
			ITalkItemDisableAutoSelectOptionGroupT talkItemDisableAutoSelectOptionGroupT = new ITalkItemDisableAutoSelectOptionGroupT();
			this.UnPackTo(talkItemDisableAutoSelectOptionGroupT);
			return talkItemDisableAutoSelectOptionGroupT;
		}

		// Token: 0x06034B36 RID: 215862 RVA: 0x0071FC8B File Offset: 0x0071DE8B
		public void UnPackTo(ITalkItemDisableAutoSelectOptionGroupT _o)
		{
			_o.TextKey = this.TextKey;
			_o.IconId = this.IconId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06034B37 RID: 215863 RVA: 0x0071FCB4 File Offset: 0x0071DEB4
		public static Offset<ITalkItemDisableAutoSelectOptionGroup> Pack(FlatBufferBuilder builder, ITalkItemDisableAutoSelectOptionGroupT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkItemDisableAutoSelectOptionGroup>);
			}
			StringOffset textKeyOffset = (_o.TextKey == null) ? default(StringOffset) : builder.CreateString(_o.TextKey);
			return ITalkItemDisableAutoSelectOptionGroup.CreateITalkItemDisableAutoSelectOptionGroup(builder, textKeyOffset, _o.IconId, _o.NullMask);
		}

		// Token: 0x04011F2D RID: 73517
		private Table __p;
	}
}
