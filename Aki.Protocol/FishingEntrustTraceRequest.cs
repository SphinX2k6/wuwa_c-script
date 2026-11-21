using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000541 RID: 1345
	[NetMessage(EMessageId.FishingEntrustTraceRequest)]
	public sealed class FishingEntrustTraceRequest : IMessage<FishingEntrustTraceRequest>, IMessage, IEquatable<FishingEntrustTraceRequest>, IDeepCloneable<FishingEntrustTraceRequest>, IBufferMessage
	{
		// Token: 0x06007E21 RID: 32289 RVA: 0x00131A44 File Offset: 0x0012FC44
		[NullableContext(1)]
		public static FishingEntrustTraceRequest Create()
		{
			return new FishingEntrustTraceRequest();
		}

		// Token: 0x17001886 RID: 6278
		// (get) Token: 0x06007E22 RID: 32290 RVA: 0x00131A4B File Offset: 0x0012FC4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001887 RID: 6279
		// (get) Token: 0x06007E23 RID: 32291 RVA: 0x00131A4E File Offset: 0x0012FC4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingEntrustTraceRequest.Descriptor;
			}
		}

		// Token: 0x06007E24 RID: 32292 RVA: 0x00131A55 File Offset: 0x0012FC55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingEntrustTraceRequest()
		{
		}

		// Token: 0x06007E25 RID: 32293 RVA: 0x00131A5D File Offset: 0x0012FC5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingEntrustTraceRequest(FishingEntrustTraceRequest other) : this()
		{
			this.entrustId_ = other.entrustId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007E26 RID: 32294 RVA: 0x00131A82 File Offset: 0x0012FC82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingEntrustTraceRequest Clone()
		{
			return new FishingEntrustTraceRequest(this);
		}

		// Token: 0x17001888 RID: 6280
		// (get) Token: 0x06007E27 RID: 32295 RVA: 0x00131A8A File Offset: 0x0012FC8A
		// (set) Token: 0x06007E28 RID: 32296 RVA: 0x00131A92 File Offset: 0x0012FC92
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

		// Token: 0x06007E29 RID: 32297 RVA: 0x00131A9B File Offset: 0x0012FC9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingEntrustTraceRequest);
		}

		// Token: 0x06007E2A RID: 32298 RVA: 0x00131AA9 File Offset: 0x0012FCA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingEntrustTraceRequest other)
		{
			return other != null && (other == this || (this.EntrustId == other.EntrustId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007E2B RID: 32299 RVA: 0x00131AD8 File Offset: 0x0012FCD8
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

		// Token: 0x06007E2C RID: 32300 RVA: 0x00131B17 File Offset: 0x0012FD17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007E2D RID: 32301 RVA: 0x00131B24 File Offset: 0x0012FD24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007E2E RID: 32302 RVA: 0x00131B2D File Offset: 0x0012FD2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntrustId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.EntrustId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007E2F RID: 32303 RVA: 0x00131B60 File Offset: 0x0012FD60
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

		// Token: 0x06007E30 RID: 32304 RVA: 0x00131B9E File Offset: 0x0012FD9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingEntrustTraceRequest other)
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

		// Token: 0x06007E31 RID: 32305 RVA: 0x00131BCF File Offset: 0x0012FDCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007E32 RID: 32306 RVA: 0x00131BD8 File Offset: 0x0012FDD8
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntrustId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400405C RID: 16476
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400405D RID: 16477
		public const int EntrustIdFieldNumber = 15;

		// Token: 0x0400405E RID: 16478
		private int entrustId_;
	}
}
