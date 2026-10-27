using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000309 RID: 777
	public sealed class CorniceMeetingRewardScoreList : IMessage<CorniceMeetingRewardScoreList>, IMessage, IEquatable<CorniceMeetingRewardScoreList>, IDeepCloneable<CorniceMeetingRewardScoreList>, IBufferMessage
	{
		// Token: 0x06004E58 RID: 20056 RVA: 0x000BE3F1 File Offset: 0x000BC5F1
		[NullableContext(1)]
		public static CorniceMeetingRewardScoreList Create()
		{
			return new CorniceMeetingRewardScoreList();
		}

		// Token: 0x17000DE3 RID: 3555
		// (get) Token: 0x06004E59 RID: 20057 RVA: 0x000BE3F8 File Offset: 0x000BC5F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CorniceMeetingRewardScoreList> Parser
		{
			get
			{
				return CorniceMeetingRewardScoreList._parser;
			}
		}

		// Token: 0x17000DE4 RID: 3556
		// (get) Token: 0x06004E5A RID: 20058 RVA: 0x000BE3FF File Offset: 0x000BC5FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000DE5 RID: 3557
		// (get) Token: 0x06004E5B RID: 20059 RVA: 0x000BE402 File Offset: 0x000BC602
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CorniceMeetingRewardScoreList.Descriptor;
			}
		}

		// Token: 0x06004E5C RID: 20060 RVA: 0x000BE409 File Offset: 0x000BC609
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CorniceMeetingRewardScoreList()
		{
		}

		// Token: 0x06004E5D RID: 20061 RVA: 0x000BE41C File Offset: 0x000BC61C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CorniceMeetingRewardScoreList(CorniceMeetingRewardScoreList other) : this()
		{
			this.scoreIndexes_ = other.scoreIndexes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004E5E RID: 20062 RVA: 0x000BE446 File Offset: 0x000BC646
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CorniceMeetingRewardScoreList Clone()
		{
			return new CorniceMeetingRewardScoreList(this);
		}

		// Token: 0x17000DE6 RID: 3558
		// (get) Token: 0x06004E5F RID: 20063 RVA: 0x000BE44E File Offset: 0x000BC64E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ScoreIndexes
		{
			get
			{
				return this.scoreIndexes_;
			}
		}

		// Token: 0x06004E60 RID: 20064 RVA: 0x000BE456 File Offset: 0x000BC656
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CorniceMeetingRewardScoreList);
		}

		// Token: 0x06004E61 RID: 20065 RVA: 0x000BE464 File Offset: 0x000BC664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CorniceMeetingRewardScoreList other)
		{
			return other != null && (other == this || (this.scoreIndexes_.Equals(other.scoreIndexes_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004E62 RID: 20066 RVA: 0x000BE498 File Offset: 0x000BC698
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

		// Token: 0x06004E63 RID: 20067 RVA: 0x000BE4CC File Offset: 0x000BC6CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004E64 RID: 20068 RVA: 0x000BE4D9 File Offset: 0x000BC6D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004E65 RID: 20069 RVA: 0x000BE4E2 File Offset: 0x000BC6E2
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

		// Token: 0x06004E66 RID: 20070 RVA: 0x000BE50C File Offset: 0x000BC70C
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

		// Token: 0x06004E67 RID: 20071 RVA: 0x000BE545 File Offset: 0x000BC745
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

		// Token: 0x06004E68 RID: 20072 RVA: 0x000BE573 File Offset: 0x000BC773
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004E69 RID: 20073 RVA: 0x000BE57C File Offset: 0x000BC77C
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

		// Token: 0x0400318E RID: 12686
		private static readonly MessageParser<CorniceMeetingRewardScoreList> _parser = new MessageParser<CorniceMeetingRewardScoreList>(() => new CorniceMeetingRewardScoreList());

		// Token: 0x0400318F RID: 12687
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003190 RID: 12688
		public const int ScoreIndexesFieldNumber = 1;

		// Token: 0x04003191 RID: 12689
		private static readonly FieldCodec<int> _repeated_scoreIndexes_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04003192 RID: 12690
		private readonly RepeatedField<int> scoreIndexes_ = new RepeatedField<int>();
	}
}
