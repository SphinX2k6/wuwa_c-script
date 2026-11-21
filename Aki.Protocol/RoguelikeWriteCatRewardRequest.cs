using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FBC RID: 4028
	[NetMessage(EMessageId.RoguelikeWriteCatRewardRequest)]
	public sealed class RoguelikeWriteCatRewardRequest : IMessage<RoguelikeWriteCatRewardRequest>, IMessage, IEquatable<RoguelikeWriteCatRewardRequest>, IDeepCloneable<RoguelikeWriteCatRewardRequest>, IBufferMessage
	{
		// Token: 0x060158FB RID: 88315 RVA: 0x00321C89 File Offset: 0x0031FE89
		[NullableContext(1)]
		public static RoguelikeWriteCatRewardRequest Create()
		{
			return new RoguelikeWriteCatRewardRequest();
		}

		// Token: 0x170047EC RID: 18412
		// (get) Token: 0x060158FC RID: 88316 RVA: 0x00321C90 File Offset: 0x0031FE90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170047ED RID: 18413
		// (get) Token: 0x060158FD RID: 88317 RVA: 0x00321C93 File Offset: 0x0031FE93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeWriteCatRewardRequest.Descriptor;
			}
		}

		// Token: 0x060158FE RID: 88318 RVA: 0x00321C9A File Offset: 0x0031FE9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeWriteCatRewardRequest()
		{
		}

		// Token: 0x060158FF RID: 88319 RVA: 0x00321CA2 File Offset: 0x0031FEA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeWriteCatRewardRequest(RoguelikeWriteCatRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015900 RID: 88320 RVA: 0x00321CD3 File Offset: 0x0031FED3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeWriteCatRewardRequest Clone()
		{
			return new RoguelikeWriteCatRewardRequest(this);
		}

		// Token: 0x170047EE RID: 18414
		// (get) Token: 0x06015901 RID: 88321 RVA: 0x00321CDB File Offset: 0x0031FEDB
		// (set) Token: 0x06015902 RID: 88322 RVA: 0x00321CE3 File Offset: 0x0031FEE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x170047EF RID: 18415
		// (get) Token: 0x06015903 RID: 88323 RVA: 0x00321CEC File Offset: 0x0031FEEC
		// (set) Token: 0x06015904 RID: 88324 RVA: 0x00321CF4 File Offset: 0x0031FEF4
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

		// Token: 0x06015905 RID: 88325 RVA: 0x00321CFD File Offset: 0x0031FEFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeWriteCatRewardRequest);
		}

		// Token: 0x06015906 RID: 88326 RVA: 0x00321D0B File Offset: 0x0031FF0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeWriteCatRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015907 RID: 88327 RVA: 0x00321D4C File Offset: 0x0031FF4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
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

		// Token: 0x06015908 RID: 88328 RVA: 0x00321DA4 File Offset: 0x0031FFA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015909 RID: 88329 RVA: 0x00321DB1 File Offset: 0x0031FFB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601590A RID: 88330 RVA: 0x00321DBC File Offset: 0x0031FFBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ActivityId);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.Index);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601590B RID: 88331 RVA: 0x00321E18 File Offset: 0x00320018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
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

		// Token: 0x0601590C RID: 88332 RVA: 0x00321E70 File Offset: 0x00320070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeWriteCatRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601590D RID: 88333 RVA: 0x00321EC0 File Offset: 0x003200C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601590E RID: 88334 RVA: 0x00321ECC File Offset: 0x003200CC
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
				if (num != 48U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Index = input.ReadInt32();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040081FC RID: 33276
		private UnknownFieldSet _unknownFields;

		// Token: 0x040081FD RID: 33277
		public const int ActivityIdFieldNumber = 6;

		// Token: 0x040081FE RID: 33278
		private int activityId_;

		// Token: 0x040081FF RID: 33279
		public const int IndexFieldNumber = 15;

		// Token: 0x04008200 RID: 33280
		private int index_;
	}
}
