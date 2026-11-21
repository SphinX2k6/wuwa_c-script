using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200103F RID: 4159
	[NetMessage(EMessageId.RogueWhiteCatLimitedRewardRequest)]
	public sealed class RogueWhiteCatLimitedRewardRequest : IMessage<RogueWhiteCatLimitedRewardRequest>, IMessage, IEquatable<RogueWhiteCatLimitedRewardRequest>, IDeepCloneable<RogueWhiteCatLimitedRewardRequest>, IBufferMessage
	{
		// Token: 0x06016415 RID: 91157 RVA: 0x0033CAB7 File Offset: 0x0033ACB7
		[NullableContext(1)]
		public static RogueWhiteCatLimitedRewardRequest Create()
		{
			return new RogueWhiteCatLimitedRewardRequest();
		}

		// Token: 0x17004A78 RID: 19064
		// (get) Token: 0x06016416 RID: 91158 RVA: 0x0033CABE File Offset: 0x0033ACBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A79 RID: 19065
		// (get) Token: 0x06016417 RID: 91159 RVA: 0x0033CAC1 File Offset: 0x0033ACC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWhiteCatLimitedRewardRequest.Descriptor;
			}
		}

		// Token: 0x06016418 RID: 91160 RVA: 0x0033CAC8 File Offset: 0x0033ACC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWhiteCatLimitedRewardRequest()
		{
		}

		// Token: 0x06016419 RID: 91161 RVA: 0x0033CAD0 File Offset: 0x0033ACD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWhiteCatLimitedRewardRequest(RogueWhiteCatLimitedRewardRequest other) : this()
		{
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601641A RID: 91162 RVA: 0x0033CAF5 File Offset: 0x0033ACF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWhiteCatLimitedRewardRequest Clone()
		{
			return new RogueWhiteCatLimitedRewardRequest(this);
		}

		// Token: 0x17004A7A RID: 19066
		// (get) Token: 0x0601641B RID: 91163 RVA: 0x0033CAFD File Offset: 0x0033ACFD
		// (set) Token: 0x0601641C RID: 91164 RVA: 0x0033CB05 File Offset: 0x0033AD05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x0601641D RID: 91165 RVA: 0x0033CB0E File Offset: 0x0033AD0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWhiteCatLimitedRewardRequest);
		}

		// Token: 0x0601641E RID: 91166 RVA: 0x0033CB1C File Offset: 0x0033AD1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWhiteCatLimitedRewardRequest other)
		{
			return other != null && (other == this || (this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601641F RID: 91167 RVA: 0x0033CB4C File Offset: 0x0033AD4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016420 RID: 91168 RVA: 0x0033CB8B File Offset: 0x0033AD8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016421 RID: 91169 RVA: 0x0033CB98 File Offset: 0x0033AD98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016422 RID: 91170 RVA: 0x0033CBA1 File Offset: 0x0033ADA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Index != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.Index);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016423 RID: 91171 RVA: 0x0033CBD4 File Offset: 0x0033ADD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016424 RID: 91172 RVA: 0x0033CC12 File Offset: 0x0033AE12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWhiteCatLimitedRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016425 RID: 91173 RVA: 0x0033CC43 File Offset: 0x0033AE43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016426 RID: 91174 RVA: 0x0033CC4C File Offset: 0x0033AE4C
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Index = input.ReadInt32();
				}
			}
		}

		// Token: 0x040085AC RID: 34220
		private UnknownFieldSet _unknownFields;

		// Token: 0x040085AD RID: 34221
		public const int IndexFieldNumber = 9;

		// Token: 0x040085AE RID: 34222
		private int index_;
	}
}
