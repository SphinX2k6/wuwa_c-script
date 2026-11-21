using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B03 RID: 27395
	public struct ICommonTipFirstComplete : IFlatbufferObject
	{
		// Token: 0x1700C930 RID: 51504
		// (get) Token: 0x0602F190 RID: 192912 RVA: 0x0066C7F1 File Offset: 0x0066A9F1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F191 RID: 192913 RVA: 0x0066C7FE File Offset: 0x0066A9FE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F192 RID: 192914 RVA: 0x0066C808 File Offset: 0x0066AA08
		public static ICommonTipFirstComplete GetRootAsICommonTipFirstComplete(ByteBuffer _bb)
		{
			return ICommonTipFirstComplete.GetRootAsICommonTipFirstComplete(_bb, default(ICommonTipFirstComplete));
		}

		// Token: 0x0602F193 RID: 192915 RVA: 0x0066C824 File Offset: 0x0066AA24
		public static ICommonTipFirstComplete GetRootAsICommonTipFirstComplete(ByteBuffer _bb, ICommonTipFirstComplete obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F194 RID: 192916 RVA: 0x0066C841 File Offset: 0x0066AA41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F195 RID: 192917 RVA: 0x0066C850 File Offset: 0x0066AA50
		public ICommonTipFirstComplete __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C931 RID: 51505
		// (get) Token: 0x0602F196 RID: 192918 RVA: 0x0066C860 File Offset: 0x0066AA60
		public ECommonTipType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECommonTipType.ChallengeCondition;
				}
				return (ECommonTipType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C932 RID: 51506
		// (get) Token: 0x0602F197 RID: 192919 RVA: 0x0066C89C File Offset: 0x0066AA9C
		public string TidText
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

		// Token: 0x0602F198 RID: 192920 RVA: 0x0066C8D3 File Offset: 0x0066AAD3
		public Span<byte> GetTidTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602F199 RID: 192921 RVA: 0x0066C8E2 File Offset: 0x0066AAE2
		public byte[] GetTidTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602F19A RID: 192922 RVA: 0x0066C8F0 File Offset: 0x0066AAF0
		public static Offset<ICommonTipFirstComplete> CreateICommonTipFirstComplete(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, StringOffset TidTextOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ICommonTipFirstComplete.AddTidText(builder, TidTextOffset);
			ICommonTipFirstComplete.AddType(builder, Type);
			return ICommonTipFirstComplete.EndICommonTipFirstComplete(builder);
		}

		// Token: 0x0602F19B RID: 192923 RVA: 0x0066C90D File Offset: 0x0066AB0D
		public static void StartICommonTipFirstComplete(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602F19C RID: 192924 RVA: 0x0066C916 File Offset: 0x0066AB16
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F19D RID: 192925 RVA: 0x0066C921 File Offset: 0x0066AB21
		public static void AddTidText(FlatBufferBuilder builder, StringOffset tidTextOffset)
		{
			builder.AddOffset(1, tidTextOffset.Value, 0);
		}

		// Token: 0x0602F19E RID: 192926 RVA: 0x0066C931 File Offset: 0x0066AB31
		public static Offset<ICommonTipFirstComplete> EndICommonTipFirstComplete(FlatBufferBuilder builder)
		{
			return new Offset<ICommonTipFirstComplete>(builder.EndTable());
		}

		// Token: 0x0602F19F RID: 192927 RVA: 0x0066C940 File Offset: 0x0066AB40
		public ICommonTipFirstCompleteT UnPack()
		{
			ICommonTipFirstCompleteT commonTipFirstCompleteT = new ICommonTipFirstCompleteT();
			this.UnPackTo(commonTipFirstCompleteT);
			return commonTipFirstCompleteT;
		}

		// Token: 0x0602F1A0 RID: 192928 RVA: 0x0066C95B File Offset: 0x0066AB5B
		public void UnPackTo(ICommonTipFirstCompleteT _o)
		{
			_o.Type = this.Type;
			_o.TidText = this.TidText;
		}

		// Token: 0x0602F1A1 RID: 192929 RVA: 0x0066C978 File Offset: 0x0066AB78
		public static Offset<ICommonTipFirstComplete> Pack(FlatBufferBuilder builder, ICommonTipFirstCompleteT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonTipFirstComplete>);
			}
			StringOffset tidTextOffset = (_o.TidText == null) ? default(StringOffset) : builder.CreateString(_o.TidText);
			return ICommonTipFirstComplete.CreateICommonTipFirstComplete(builder, _o.Type, tidTextOffset);
		}

		// Token: 0x040118B6 RID: 71862
		private Table __p;
	}
}
