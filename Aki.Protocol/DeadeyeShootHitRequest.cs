using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003B7 RID: 951
	[NetMessage(EMessageId.DeadeyeShootHitRequest)]
	public sealed class DeadeyeShootHitRequest : IMessage<DeadeyeShootHitRequest>, IMessage, IEquatable<DeadeyeShootHitRequest>, IDeepCloneable<DeadeyeShootHitRequest>, IBufferMessage
	{
		// Token: 0x06005D3B RID: 23867 RVA: 0x000E2488 File Offset: 0x000E0688
		[NullableContext(1)]
		public static DeadeyeShootHitRequest Create()
		{
			return new DeadeyeShootHitRequest();
		}

		// Token: 0x1700114E RID: 4430
		// (get) Token: 0x06005D3C RID: 23868 RVA: 0x000E248F File Offset: 0x000E068F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700114F RID: 4431
		// (get) Token: 0x06005D3D RID: 23869 RVA: 0x000E2492 File Offset: 0x000E0692
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DeadeyeShootHitRequest.Descriptor;
			}
		}

		// Token: 0x06005D3E RID: 23870 RVA: 0x000E2499 File Offset: 0x000E0699
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeadeyeShootHitRequest()
		{
		}

		// Token: 0x06005D3F RID: 23871 RVA: 0x000E24AC File Offset: 0x000E06AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeadeyeShootHitRequest(DeadeyeShootHitRequest other) : this()
		{
			this.instId_ = other.instId_;
			this.entityIds_ = other.entityIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005D40 RID: 23872 RVA: 0x000E24E2 File Offset: 0x000E06E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeadeyeShootHitRequest Clone()
		{
			return new DeadeyeShootHitRequest(this);
		}

		// Token: 0x17001150 RID: 4432
		// (get) Token: 0x06005D41 RID: 23873 RVA: 0x000E24EA File Offset: 0x000E06EA
		// (set) Token: 0x06005D42 RID: 23874 RVA: 0x000E24F2 File Offset: 0x000E06F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x17001151 RID: 4433
		// (get) Token: 0x06005D43 RID: 23875 RVA: 0x000E24FB File Offset: 0x000E06FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> EntityIds
		{
			get
			{
				return this.entityIds_;
			}
		}

		// Token: 0x06005D44 RID: 23876 RVA: 0x000E2503 File Offset: 0x000E0703
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DeadeyeShootHitRequest);
		}

		// Token: 0x06005D45 RID: 23877 RVA: 0x000E2514 File Offset: 0x000E0714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DeadeyeShootHitRequest other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.entityIds_.Equals(other.entityIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005D46 RID: 23878 RVA: 0x000E2564 File Offset: 0x000E0764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			num ^= this.entityIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005D47 RID: 23879 RVA: 0x000E25B1 File Offset: 0x000E07B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005D48 RID: 23880 RVA: 0x000E25BE File Offset: 0x000E07BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005D49 RID: 23881 RVA: 0x000E25C8 File Offset: 0x000E07C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.InstId);
			}
			this.entityIds_.WriteTo(ref output, DeadeyeShootHitRequest._repeated_entityIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005D4A RID: 23882 RVA: 0x000E2618 File Offset: 0x000E0818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			num += this.entityIds_.CalculateSize(DeadeyeShootHitRequest._repeated_entityIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005D4B RID: 23883 RVA: 0x000E266C File Offset: 0x000E086C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DeadeyeShootHitRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			this.entityIds_.Add(other.entityIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005D4C RID: 23884 RVA: 0x000E26B9 File Offset: 0x000E08B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005D4D RID: 23885 RVA: 0x000E26C4 File Offset: 0x000E08C4
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
				if (num != 16U)
				{
					if (num != 56U && num != 58U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.entityIds_.AddEntriesFrom(ref input, DeadeyeShootHitRequest._repeated_entityIds_codec);
					}
				}
				else
				{
					this.InstId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400367D RID: 13949
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400367E RID: 13950
		public const int InstIdFieldNumber = 2;

		// Token: 0x0400367F RID: 13951
		private int instId_;

		// Token: 0x04003680 RID: 13952
		public const int EntityIdsFieldNumber = 7;

		// Token: 0x04003681 RID: 13953
		private static readonly FieldCodec<long> _repeated_entityIds_codec = FieldCodec.ForInt64(58U);

		// Token: 0x04003682 RID: 13954
		private readonly RepeatedField<long> entityIds_ = new RepeatedField<long>();
	}
}
