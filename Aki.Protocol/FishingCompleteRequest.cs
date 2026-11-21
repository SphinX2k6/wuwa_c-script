using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000539 RID: 1337
	[NetMessage(EMessageId.FishingCompleteRequest)]
	public sealed class FishingCompleteRequest : IMessage<FishingCompleteRequest>, IMessage, IEquatable<FishingCompleteRequest>, IDeepCloneable<FishingCompleteRequest>, IBufferMessage
	{
		// Token: 0x06007D85 RID: 32133 RVA: 0x0013062F File Offset: 0x0012E82F
		[NullableContext(1)]
		public static FishingCompleteRequest Create()
		{
			return new FishingCompleteRequest();
		}

		// Token: 0x17001867 RID: 6247
		// (get) Token: 0x06007D86 RID: 32134 RVA: 0x00130636 File Offset: 0x0012E836
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001868 RID: 6248
		// (get) Token: 0x06007D87 RID: 32135 RVA: 0x00130639 File Offset: 0x0012E839
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingCompleteRequest.Descriptor;
			}
		}

		// Token: 0x06007D88 RID: 32136 RVA: 0x00130640 File Offset: 0x0012E840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingCompleteRequest()
		{
		}

		// Token: 0x06007D89 RID: 32137 RVA: 0x00130648 File Offset: 0x0012E848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingCompleteRequest(FishingCompleteRequest other) : this()
		{
			this.interactId_ = other.interactId_;
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007D8A RID: 32138 RVA: 0x00130679 File Offset: 0x0012E879
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingCompleteRequest Clone()
		{
			return new FishingCompleteRequest(this);
		}

		// Token: 0x17001869 RID: 6249
		// (get) Token: 0x06007D8B RID: 32139 RVA: 0x00130681 File Offset: 0x0012E881
		// (set) Token: 0x06007D8C RID: 32140 RVA: 0x00130689 File Offset: 0x0012E889
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

		// Token: 0x1700186A RID: 6250
		// (get) Token: 0x06007D8D RID: 32141 RVA: 0x00130692 File Offset: 0x0012E892
		// (set) Token: 0x06007D8E RID: 32142 RVA: 0x0013069A File Offset: 0x0012E89A
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

		// Token: 0x06007D8F RID: 32143 RVA: 0x001306A3 File Offset: 0x0012E8A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingCompleteRequest);
		}

		// Token: 0x06007D90 RID: 32144 RVA: 0x001306B1 File Offset: 0x0012E8B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingCompleteRequest other)
		{
			return other != null && (other == this || (this.InteractId == other.InteractId && this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007D91 RID: 32145 RVA: 0x001306F0 File Offset: 0x0012E8F0
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

		// Token: 0x06007D92 RID: 32146 RVA: 0x00130748 File Offset: 0x0012E948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007D93 RID: 32147 RVA: 0x00130755 File Offset: 0x0012E955
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007D94 RID: 32148 RVA: 0x00130760 File Offset: 0x0012E960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(72);
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

		// Token: 0x06007D95 RID: 32149 RVA: 0x001307BC File Offset: 0x0012E9BC
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

		// Token: 0x06007D96 RID: 32150 RVA: 0x00130814 File Offset: 0x0012EA14
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

		// Token: 0x06007D97 RID: 32151 RVA: 0x00130864 File Offset: 0x0012EA64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007D98 RID: 32152 RVA: 0x00130870 File Offset: 0x0012EA70
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

		// Token: 0x04004032 RID: 16434
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004033 RID: 16435
		public const int InteractIdFieldNumber = 11;

		// Token: 0x04004034 RID: 16436
		private int interactId_;

		// Token: 0x04004035 RID: 16437
		public const int EntityIdFieldNumber = 9;

		// Token: 0x04004036 RID: 16438
		private long entityId_;
	}
}
