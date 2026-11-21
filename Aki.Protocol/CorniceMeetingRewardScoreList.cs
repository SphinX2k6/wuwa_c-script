using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000310 RID: 784
	public sealed class CorniceMeetingRewardScoreList : IMessage<CorniceMeetingRewardScoreList>, IMessage, IEquatable<CorniceMeetingRewardScoreList>, IDeepCloneable<CorniceMeetingRewardScoreList>, IBufferMessage
	{
		// Token: 0x06004F31 RID: 20273 RVA: 0x000C07DD File Offset: 0x000BE9DD
		[NullableContext(1)]
		public static CorniceMeetingRewardScoreList Create()
		{
			return new CorniceMeetingRewardScoreList();
		}

		// Token: 0x17000E10 RID: 3600
		// (get) Token: 0x06004F32 RID: 20274 RVA: 0x000C07E4 File Offset: 0x000BE9E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CorniceMeetingRewardScoreList> Parser
		{
			get
			{
				return CorniceMeetingRewardScoreList._parser;
			}
		}

		// Token: 0x17000E11 RID: 3601
		// (get) Token: 0x06004F33 RID: 20275 RVA: 0x000C07EB File Offset: 0x000BE9EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E12 RID: 3602
		// (get) Token: 0x06004F34 RID: 20276 RVA: 0x000C07EE File Offset: 0x000BE9EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CorniceMeetingRewardScoreList.Descriptor;
			}
		}

		// Token: 0x06004F35 RID: 20277 RVA: 0x000C07F5 File Offset: 0x000BE9F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CorniceMeetingRewardScoreList()
		{
		}

		// Token: 0x06004F36 RID: 20278 RVA: 0x000C0808 File Offset: 0x000BEA08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CorniceMeetingRewardScoreList(CorniceMeetingRewardScoreList other) : this()
		{
			this.scoreIndexes_ = other.scoreIndexes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004F37 RID: 20279 RVA: 0x000C0832 File Offset: 0x000BEA32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CorniceMeetingRewardScoreList Clone()
		{
			return new CorniceMeetingRewardScoreList(this);
		}

		// Token: 0x17000E13 RID: 3603
		// (get) Token: 0x06004F38 RID: 20280 RVA: 0x000C083A File Offset: 0x000BEA3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ScoreIndexes
		{
			get
			{
				return this.scoreIndexes_;
			}
		}

		// Token: 0x06004F39 RID: 20281 RVA: 0x000C0842 File Offset: 0x000BEA42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CorniceMeetingRewardScoreList);
		}

		// Token: 0x06004F3A RID: 20282 RVA: 0x000C0850 File Offset: 0x000BEA50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CorniceMeetingRewardScoreList other)
		{
			return other != null && (other == this || (this.scoreIndexes_.Equals(other.scoreIndexes_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004F3B RID: 20283 RVA: 0x000C0884 File Offset: 0x000BEA84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.scoreIndexes_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004F3C RID: 20284 RVA: 0x000C08B8 File Offset: 0x000BEAB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004F3D RID: 20285 RVA: 0x000C08C5 File Offset: 0x000BEAC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004F3E RID: 20286 RVA: 0x000C08CE File Offset: 0x000BEACE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.scoreIndexes_.WriteTo(ref output, CorniceMeetingRewardScoreList._repeated_scoreIndexes_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004F3F RID: 20287 RVA: 0x000C08F8 File Offset: 0x000BEAF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.scoreIndexes_.CalculateSize(CorniceMeetingRewardScoreList._repeated_scoreIndexes_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004F40 RID: 20288 RVA: 0x000C0931 File Offset: 0x000BEB31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CorniceMeetingRewardScoreList other)
		{
			if (other == null)
			{
				return;
			}
			this.scoreIndexes_.Add(other.scoreIndexes_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004F41 RID: 20289 RVA: 0x000C095F File Offset: 0x000BEB5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004F42 RID: 20290 RVA: 0x000C0968 File Offset: 0x000BEB68
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
				if (num != 8U && num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.scoreIndexes_.AddEntriesFrom(ref input, CorniceMeetingRewardScoreList._repeated_scoreIndexes_codec);
				}
			}
		}

		// Token: 0x04003225 RID: 12837
		private static readonly MessageParser<CorniceMeetingRewardScoreList> _parser = new MessageParser<CorniceMeetingRewardScoreList>(() => new CorniceMeetingRewardScoreList());

		// Token: 0x04003226 RID: 12838
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003227 RID: 12839
		public const int ScoreIndexesFieldNumber = 1;

		// Token: 0x04003228 RID: 12840
		private static readonly FieldCodec<int> _repeated_scoreIndexes_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04003229 RID: 12841
		private readonly RepeatedField<int> scoreIndexes_ = new RepeatedField<int>();
	}
}
