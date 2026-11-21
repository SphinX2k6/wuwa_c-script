using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FDA RID: 4058
	[NetMessage(EMessageId.RogueResIllustrationUpdateNotify)]
	public sealed class RogueResIllustrationUpdateNotify : IMessage<RogueResIllustrationUpdateNotify>, IMessage, IEquatable<RogueResIllustrationUpdateNotify>, IDeepCloneable<RogueResIllustrationUpdateNotify>, IBufferMessage
	{
		// Token: 0x06015B86 RID: 88966 RVA: 0x003280A8 File Offset: 0x003262A8
		[NullableContext(1)]
		public static RogueResIllustrationUpdateNotify Create()
		{
			return new RogueResIllustrationUpdateNotify();
		}

		// Token: 0x17004882 RID: 18562
		// (get) Token: 0x06015B87 RID: 88967 RVA: 0x003280AF File Offset: 0x003262AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004883 RID: 18563
		// (get) Token: 0x06015B88 RID: 88968 RVA: 0x003280B2 File Offset: 0x003262B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResIllustrationUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06015B89 RID: 88969 RVA: 0x003280B9 File Offset: 0x003262B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResIllustrationUpdateNotify()
		{
		}

		// Token: 0x06015B8A RID: 88970 RVA: 0x003280CC File Offset: 0x003262CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResIllustrationUpdateNotify(RogueResIllustrationUpdateNotify other) : this()
		{
			this.dict_ = other.dict_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015B8B RID: 88971 RVA: 0x003280F6 File Offset: 0x003262F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResIllustrationUpdateNotify Clone()
		{
			return new RogueResIllustrationUpdateNotify(this);
		}

		// Token: 0x17004884 RID: 18564
		// (get) Token: 0x06015B8C RID: 88972 RVA: 0x003280FE File Offset: 0x003262FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, SignState> Dict
		{
			get
			{
				return this.dict_;
			}
		}

		// Token: 0x06015B8D RID: 88973 RVA: 0x00328106 File Offset: 0x00326306
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResIllustrationUpdateNotify);
		}

		// Token: 0x06015B8E RID: 88974 RVA: 0x00328114 File Offset: 0x00326314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResIllustrationUpdateNotify other)
		{
			return other != null && (other == this || (this.Dict.Equals(other.Dict) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015B8F RID: 88975 RVA: 0x00328148 File Offset: 0x00326348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.Dict.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015B90 RID: 88976 RVA: 0x0032817C File Offset: 0x0032637C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015B91 RID: 88977 RVA: 0x00328189 File Offset: 0x00326389
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015B92 RID: 88978 RVA: 0x00328192 File Offset: 0x00326392
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.dict_.WriteTo(ref output, RogueResIllustrationUpdateNotify._map_dict_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015B93 RID: 88979 RVA: 0x003281BC File Offset: 0x003263BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.dict_.CalculateSize(RogueResIllustrationUpdateNotify._map_dict_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015B94 RID: 88980 RVA: 0x003281F5 File Offset: 0x003263F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResIllustrationUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.dict_.MergeFrom(other.dict_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015B95 RID: 88981 RVA: 0x00328223 File Offset: 0x00326423
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015B96 RID: 88982 RVA: 0x0032822C File Offset: 0x0032642C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.dict_.AddEntriesFrom(ref input, RogueResIllustrationUpdateNotify._map_dict_codec);
				}
			}
		}

		// Token: 0x040082D4 RID: 33492
		private UnknownFieldSet _unknownFields;

		// Token: 0x040082D5 RID: 33493
		public const int DictFieldNumber = 9;

		// Token: 0x040082D6 RID: 33494
		private static readonly MapField<int, SignState>.Codec _map_dict_codec = new MapField<int, SignState>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForEnum<SignState>(16U, (SignState x) => (int)x, (int x) => (SignState)x, SignState.Lock), 74U);

		// Token: 0x040082D7 RID: 33495
		private readonly MapField<int, SignState> dict_ = new MapField<int, SignState>();
	}
}
