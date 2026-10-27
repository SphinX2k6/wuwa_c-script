using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000554 RID: 1364
	[NetMessage(EMessageId.FishingEntrustRefreshRequest)]
	public sealed class FishingEntrustRefreshRequest : IMessage<FishingEntrustRefreshRequest>, IMessage, IEquatable<FishingEntrustRefreshRequest>, IDeepCloneable<FishingEntrustRefreshRequest>, IBufferMessage
	{
		// Token: 0x06007F63 RID: 32611 RVA: 0x001341CD File Offset: 0x001323CD
		[NullableContext(1)]
		public static FishingEntrustRefreshRequest Create()
		{
			return new FishingEntrustRefreshRequest();
		}

		// Token: 0x170018CC RID: 6348
		// (get) Token: 0x06007F64 RID: 32612 RVA: 0x001341D4 File Offset: 0x001323D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170018CD RID: 6349
		// (get) Token: 0x06007F65 RID: 32613 RVA: 0x001341D7 File Offset: 0x001323D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingEntrustRefreshRequest.Descriptor;
			}
		}

		// Token: 0x06007F66 RID: 32614 RVA: 0x001341DE File Offset: 0x001323DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingEntrustRefreshRequest()
		{
		}

		// Token: 0x06007F67 RID: 32615 RVA: 0x001341E6 File Offset: 0x001323E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingEntrustRefreshRequest(FishingEntrustRefreshRequest other) : this()
		{
			this.entrustId_ = other.entrustId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007F68 RID: 32616 RVA: 0x0013420B File Offset: 0x0013240B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingEntrustRefreshRequest Clone()
		{
			return new FishingEntrustRefreshRequest(this);
		}

		// Token: 0x170018CE RID: 6350
		// (get) Token: 0x06007F69 RID: 32617 RVA: 0x00134213 File Offset: 0x00132413
		// (set) Token: 0x06007F6A RID: 32618 RVA: 0x0013421B File Offset: 0x0013241B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntrustId
		{
			get
			{
				return this.entrustId_;
			}
			set
			{
				this.entrustId_ = value;
			}
		}

		// Token: 0x06007F6B RID: 32619 RVA: 0x00134224 File Offset: 0x00132424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingEntrustRefreshRequest);
		}

		// Token: 0x06007F6C RID: 32620 RVA: 0x00134232 File Offset: 0x00132432
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingEntrustRefreshRequest other)
		{
			return other != null && (other == this || (this.EntrustId == other.EntrustId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007F6D RID: 32621 RVA: 0x00134260 File Offset: 0x00132460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntrustId != 0)
			{
				num ^= this.EntrustId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007F6E RID: 32622 RVA: 0x0013429F File Offset: 0x0013249F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007F6F RID: 32623 RVA: 0x001342AC File Offset: 0x001324AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007F70 RID: 32624 RVA: 0x001342B5 File Offset: 0x001324B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntrustId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.EntrustId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007F71 RID: 32625 RVA: 0x001342E8 File Offset: 0x001324E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntrustId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntrustId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007F72 RID: 32626 RVA: 0x00134326 File Offset: 0x00132526
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingEntrustRefreshRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntrustId != 0)
			{
				this.EntrustId = other.EntrustId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007F73 RID: 32627 RVA: 0x00134357 File Offset: 0x00132557
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007F74 RID: 32628 RVA: 0x00134360 File Offset: 0x00132560
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntrustId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400405E RID: 16478
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400405F RID: 16479
		public const int EntrustIdFieldNumber = 13;

		// Token: 0x04004060 RID: 16480
		private int entrustId_;
	}
}
