using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003A0 RID: 928
	[NetMessage(EMessageId.DeadeyeShootHitRequest)]
	public sealed class DeadeyeShootHitRequest : IMessage<DeadeyeShootHitRequest>, IMessage, IEquatable<DeadeyeShootHitRequest>, IDeepCloneable<DeadeyeShootHitRequest>, IBufferMessage
	{
		// Token: 0x06005BA9 RID: 23465 RVA: 0x000DF247 File Offset: 0x000DD447
		[NullableContext(1)]
		public static DeadeyeShootHitRequest Create()
		{
			return new DeadeyeShootHitRequest();
		}

		// Token: 0x170010F8 RID: 4344
		// (get) Token: 0x06005BAA RID: 23466 RVA: 0x000DF24E File Offset: 0x000DD44E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170010F9 RID: 4345
		// (get) Token: 0x06005BAB RID: 23467 RVA: 0x000DF251 File Offset: 0x000DD451
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DeadeyeShootHitRequest.Descriptor;
			}
		}

		// Token: 0x06005BAC RID: 23468 RVA: 0x000DF258 File Offset: 0x000DD458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeadeyeShootHitRequest()
		{
		}

		// Token: 0x06005BAD RID: 23469 RVA: 0x000DF26B File Offset: 0x000DD46B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeadeyeShootHitRequest(DeadeyeShootHitRequest other) : this()
		{
			this.instId_ = other.instId_;
			this.entityIds_ = other.entityIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005BAE RID: 23470 RVA: 0x000DF2A1 File Offset: 0x000DD4A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeadeyeShootHitRequest Clone()
		{
			return new DeadeyeShootHitRequest(this);
		}

		// Token: 0x170010FA RID: 4346
		// (get) Token: 0x06005BAF RID: 23471 RVA: 0x000DF2A9 File Offset: 0x000DD4A9
		// (set) Token: 0x06005BB0 RID: 23472 RVA: 0x000DF2B1 File Offset: 0x000DD4B1
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

		// Token: 0x170010FB RID: 4347
		// (get) Token: 0x06005BB1 RID: 23473 RVA: 0x000DF2BA File Offset: 0x000DD4BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> EntityIds
		{
			get
			{
				return this.entityIds_;
			}
		}

		// Token: 0x06005BB2 RID: 23474 RVA: 0x000DF2C2 File Offset: 0x000DD4C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DeadeyeShootHitRequest);
		}

		// Token: 0x06005BB3 RID: 23475 RVA: 0x000DF2D0 File Offset: 0x000DD4D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DeadeyeShootHitRequest other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.entityIds_.Equals(other.entityIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005BB4 RID: 23476 RVA: 0x000DF320 File Offset: 0x000DD520
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

		// Token: 0x06005BB5 RID: 23477 RVA: 0x000DF36D File Offset: 0x000DD56D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005BB6 RID: 23478 RVA: 0x000DF37A File Offset: 0x000DD57A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005BB7 RID: 23479 RVA: 0x000DF384 File Offset: 0x000DD584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.InstId);
			}
			this.entityIds_.WriteTo(ref output, DeadeyeShootHitRequest._repeated_entityIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005BB8 RID: 23480 RVA: 0x000DF3D4 File Offset: 0x000DD5D4
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

		// Token: 0x06005BB9 RID: 23481 RVA: 0x000DF428 File Offset: 0x000DD628
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

		// Token: 0x06005BBA RID: 23482 RVA: 0x000DF475 File Offset: 0x000DD675
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005BBB RID: 23483 RVA: 0x000DF480 File Offset: 0x000DD680
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
				if (num != 24U)
				{
					if (num != 32U && num != 34U)
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

		// Token: 0x04003668 RID: 13928
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003669 RID: 13929
		public const int InstIdFieldNumber = 3;

		// Token: 0x0400366A RID: 13930
		private int instId_;

		// Token: 0x0400366B RID: 13931
		public const int EntityIdsFieldNumber = 4;

		// Token: 0x0400366C RID: 13932
		private static readonly FieldCodec<long> _repeated_entityIds_codec = FieldCodec.ForInt64(34U);

		// Token: 0x0400366D RID: 13933
		private readonly RepeatedField<long> entityIds_ = new RepeatedField<long>();
	}
}
