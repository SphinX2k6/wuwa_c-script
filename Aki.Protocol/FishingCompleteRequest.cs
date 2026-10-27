using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200054E RID: 1358
	[NetMessage(EMessageId.FishingCompleteRequest)]
	public sealed class FishingCompleteRequest : IMessage<FishingCompleteRequest>, IMessage, IEquatable<FishingCompleteRequest>, IDeepCloneable<FishingCompleteRequest>, IBufferMessage
	{
		// Token: 0x06007EED RID: 32493 RVA: 0x00133233 File Offset: 0x00131433
		[NullableContext(1)]
		public static FishingCompleteRequest Create()
		{
			return new FishingCompleteRequest();
		}

		// Token: 0x170018B4 RID: 6324
		// (get) Token: 0x06007EEE RID: 32494 RVA: 0x0013323A File Offset: 0x0013143A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170018B5 RID: 6325
		// (get) Token: 0x06007EEF RID: 32495 RVA: 0x0013323D File Offset: 0x0013143D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingCompleteRequest.Descriptor;
			}
		}

		// Token: 0x06007EF0 RID: 32496 RVA: 0x00133244 File Offset: 0x00131444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingCompleteRequest()
		{
		}

		// Token: 0x06007EF1 RID: 32497 RVA: 0x0013324C File Offset: 0x0013144C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingCompleteRequest(FishingCompleteRequest other) : this()
		{
			this.interactId_ = other.interactId_;
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007EF2 RID: 32498 RVA: 0x0013327D File Offset: 0x0013147D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingCompleteRequest Clone()
		{
			return new FishingCompleteRequest(this);
		}

		// Token: 0x170018B6 RID: 6326
		// (get) Token: 0x06007EF3 RID: 32499 RVA: 0x00133285 File Offset: 0x00131485
		// (set) Token: 0x06007EF4 RID: 32500 RVA: 0x0013328D File Offset: 0x0013148D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InteractId
		{
			get
			{
				return this.interactId_;
			}
			set
			{
				this.interactId_ = value;
			}
		}

		// Token: 0x170018B7 RID: 6327
		// (get) Token: 0x06007EF5 RID: 32501 RVA: 0x00133296 File Offset: 0x00131496
		// (set) Token: 0x06007EF6 RID: 32502 RVA: 0x0013329E File Offset: 0x0013149E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x06007EF7 RID: 32503 RVA: 0x001332A7 File Offset: 0x001314A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingCompleteRequest);
		}

		// Token: 0x06007EF8 RID: 32504 RVA: 0x001332B5 File Offset: 0x001314B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingCompleteRequest other)
		{
			return other != null && (other == this || (this.InteractId == other.InteractId && this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007EF9 RID: 32505 RVA: 0x001332F4 File Offset: 0x001314F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InteractId != 0)
			{
				num ^= this.InteractId.GetHashCode();
			}
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007EFA RID: 32506 RVA: 0x0013334C File Offset: 0x0013154C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007EFB RID: 32507 RVA: 0x00133359 File Offset: 0x00131559
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007EFC RID: 32508 RVA: 0x00133364 File Offset: 0x00131564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.EntityId);
			}
			if (this.InteractId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.InteractId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007EFD RID: 32509 RVA: 0x001333C0 File Offset: 0x001315C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InteractId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InteractId);
			}
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007EFE RID: 32510 RVA: 0x00133418 File Offset: 0x00131618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingCompleteRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InteractId != 0)
			{
				this.InteractId = other.InteractId;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007EFF RID: 32511 RVA: 0x00133468 File Offset: 0x00131668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007F00 RID: 32512 RVA: 0x00133474 File Offset: 0x00131674
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
				if (num != 40U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.InteractId = input.ReadInt32();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400403C RID: 16444
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400403D RID: 16445
		public const int InteractIdFieldNumber = 11;

		// Token: 0x0400403E RID: 16446
		private int interactId_;

		// Token: 0x0400403F RID: 16447
		public const int EntityIdFieldNumber = 5;

		// Token: 0x04004040 RID: 16448
		private long entityId_;
	}
}
