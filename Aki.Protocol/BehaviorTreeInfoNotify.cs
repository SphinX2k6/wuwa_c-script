using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000197 RID: 407
	[NetMessage(EMessageId.BehaviorTreeInfoNotify)]
	public sealed class BehaviorTreeInfoNotify : IMessage<BehaviorTreeInfoNotify>, IMessage, IEquatable<BehaviorTreeInfoNotify>, IDeepCloneable<BehaviorTreeInfoNotify>, IBufferMessage
	{
		// Token: 0x0600304F RID: 12367 RVA: 0x0007B669 File Offset: 0x00079869
		[NullableContext(1)]
		public static BehaviorTreeInfoNotify Create()
		{
			return new BehaviorTreeInfoNotify();
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x06003050 RID: 12368 RVA: 0x0007B670 File Offset: 0x00079870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x06003051 RID: 12369 RVA: 0x0007B673 File Offset: 0x00079873
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BehaviorTreeInfoNotify.Descriptor;
			}
		}

		// Token: 0x06003052 RID: 12370 RVA: 0x0007B67A File Offset: 0x0007987A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BehaviorTreeInfoNotify()
		{
		}

		// Token: 0x06003053 RID: 12371 RVA: 0x0007B68D File Offset: 0x0007988D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BehaviorTreeInfoNotify(BehaviorTreeInfoNotify other) : this()
		{
			this.treeInfos_ = other.treeInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003054 RID: 12372 RVA: 0x0007B6B7 File Offset: 0x000798B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BehaviorTreeInfoNotify Clone()
		{
			return new BehaviorTreeInfoNotify(this);
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x06003055 RID: 12373 RVA: 0x0007B6BF File Offset: 0x000798BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TreeInfo> TreeInfos
		{
			get
			{
				return this.treeInfos_;
			}
		}

		// Token: 0x06003056 RID: 12374 RVA: 0x0007B6C7 File Offset: 0x000798C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BehaviorTreeInfoNotify);
		}

		// Token: 0x06003057 RID: 12375 RVA: 0x0007B6D5 File Offset: 0x000798D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BehaviorTreeInfoNotify other)
		{
			return other != null && (other == this || (this.treeInfos_.Equals(other.treeInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003058 RID: 12376 RVA: 0x0007B708 File Offset: 0x00079908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.treeInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003059 RID: 12377 RVA: 0x0007B73C File Offset: 0x0007993C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600305A RID: 12378 RVA: 0x0007B749 File Offset: 0x00079949
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600305B RID: 12379 RVA: 0x0007B752 File Offset: 0x00079952
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.treeInfos_.WriteTo(ref output, BehaviorTreeInfoNotify._repeated_treeInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600305C RID: 12380 RVA: 0x0007B77C File Offset: 0x0007997C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.treeInfos_.CalculateSize(BehaviorTreeInfoNotify._repeated_treeInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600305D RID: 12381 RVA: 0x0007B7B5 File Offset: 0x000799B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BehaviorTreeInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.treeInfos_.Add(other.treeInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600305E RID: 12382 RVA: 0x0007B7E3 File Offset: 0x000799E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600305F RID: 12383 RVA: 0x0007B7EC File Offset: 0x000799EC
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
					this.treeInfos_.AddEntriesFrom(ref input, BehaviorTreeInfoNotify._repeated_treeInfos_codec);
				}
			}
		}

		// Token: 0x040028EC RID: 10476
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028ED RID: 10477
		public const int TreeInfosFieldNumber = 9;

		// Token: 0x040028EE RID: 10478
		private static readonly FieldCodec<TreeInfo> _repeated_treeInfos_codec = FieldCodec.ForMessage<TreeInfo>(74U, TreeInfo.Parser);

		// Token: 0x040028EF RID: 10479
		private readonly RepeatedField<TreeInfo> treeInfos_ = new RepeatedField<TreeInfo>();
	}
}
