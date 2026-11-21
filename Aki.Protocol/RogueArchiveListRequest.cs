using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F6C RID: 3948
	[NetMessage(EMessageId.RogueArchiveListRequest)]
	public sealed class RogueArchiveListRequest : IMessage<RogueArchiveListRequest>, IMessage, IEquatable<RogueArchiveListRequest>, IDeepCloneable<RogueArchiveListRequest>, IBufferMessage
	{
		// Token: 0x06015233 RID: 86579 RVA: 0x003114DA File Offset: 0x0030F6DA
		[NullableContext(1)]
		public static RogueArchiveListRequest Create()
		{
			return new RogueArchiveListRequest();
		}

		// Token: 0x1700465C RID: 18012
		// (get) Token: 0x06015234 RID: 86580 RVA: 0x003114E1 File Offset: 0x0030F6E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700465D RID: 18013
		// (get) Token: 0x06015235 RID: 86581 RVA: 0x003114E4 File Offset: 0x0030F6E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueArchiveListRequest.Descriptor;
			}
		}

		// Token: 0x06015236 RID: 86582 RVA: 0x003114EB File Offset: 0x0030F6EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArchiveListRequest()
		{
		}

		// Token: 0x06015237 RID: 86583 RVA: 0x003114F3 File Offset: 0x0030F6F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArchiveListRequest(RogueArchiveListRequest other) : this()
		{
			this.seasonId_ = other.seasonId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015238 RID: 86584 RVA: 0x00311518 File Offset: 0x0030F718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArchiveListRequest Clone()
		{
			return new RogueArchiveListRequest(this);
		}

		// Token: 0x1700465E RID: 18014
		// (get) Token: 0x06015239 RID: 86585 RVA: 0x00311520 File Offset: 0x0030F720
		// (set) Token: 0x0601523A RID: 86586 RVA: 0x00311528 File Offset: 0x0030F728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SeasonId
		{
			get
			{
				return this.seasonId_;
			}
			set
			{
				this.seasonId_ = value;
			}
		}

		// Token: 0x0601523B RID: 86587 RVA: 0x00311531 File Offset: 0x0030F731
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueArchiveListRequest);
		}

		// Token: 0x0601523C RID: 86588 RVA: 0x0031153F File Offset: 0x0030F73F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueArchiveListRequest other)
		{
			return other != null && (other == this || (this.SeasonId == other.SeasonId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601523D RID: 86589 RVA: 0x00311570 File Offset: 0x0030F770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SeasonId != 0)
			{
				num ^= this.SeasonId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601523E RID: 86590 RVA: 0x003115AF File Offset: 0x0030F7AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601523F RID: 86591 RVA: 0x003115BC File Offset: 0x0030F7BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015240 RID: 86592 RVA: 0x003115C5 File Offset: 0x0030F7C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SeasonId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.SeasonId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015241 RID: 86593 RVA: 0x003115F8 File Offset: 0x0030F7F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SeasonId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SeasonId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015242 RID: 86594 RVA: 0x00311636 File Offset: 0x0030F836
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueArchiveListRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SeasonId != 0)
			{
				this.SeasonId = other.SeasonId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015243 RID: 86595 RVA: 0x00311667 File Offset: 0x0030F867
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015244 RID: 86596 RVA: 0x00311670 File Offset: 0x0030F870
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SeasonId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007FA2 RID: 32674
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007FA3 RID: 32675
		public const int SeasonIdFieldNumber = 10;

		// Token: 0x04007FA4 RID: 32676
		private int seasonId_;
	}
}
