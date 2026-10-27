using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FC4 RID: 4036
	[NetMessage(EMessageId.RoguelikeTokenReceiveRequest)]
	public sealed class RoguelikeTokenReceiveRequest : IMessage<RoguelikeTokenReceiveRequest>, IMessage, IEquatable<RoguelikeTokenReceiveRequest>, IDeepCloneable<RoguelikeTokenReceiveRequest>, IBufferMessage
	{
		// Token: 0x0601593A RID: 88378 RVA: 0x00321B93 File Offset: 0x0031FD93
		[NullableContext(1)]
		public static RoguelikeTokenReceiveRequest Create()
		{
			return new RoguelikeTokenReceiveRequest();
		}

		// Token: 0x170047F2 RID: 18418
		// (get) Token: 0x0601593B RID: 88379 RVA: 0x00321B9A File Offset: 0x0031FD9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170047F3 RID: 18419
		// (get) Token: 0x0601593C RID: 88380 RVA: 0x00321B9D File Offset: 0x0031FD9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeTokenReceiveRequest.Descriptor;
			}
		}

		// Token: 0x0601593D RID: 88381 RVA: 0x00321BA4 File Offset: 0x0031FDA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeTokenReceiveRequest()
		{
		}

		// Token: 0x0601593E RID: 88382 RVA: 0x00321BAC File Offset: 0x0031FDAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeTokenReceiveRequest(RoguelikeTokenReceiveRequest other) : this()
		{
			this.seasonId_ = other.seasonId_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601593F RID: 88383 RVA: 0x00321BDD File Offset: 0x0031FDDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeTokenReceiveRequest Clone()
		{
			return new RoguelikeTokenReceiveRequest(this);
		}

		// Token: 0x170047F4 RID: 18420
		// (get) Token: 0x06015940 RID: 88384 RVA: 0x00321BE5 File Offset: 0x0031FDE5
		// (set) Token: 0x06015941 RID: 88385 RVA: 0x00321BED File Offset: 0x0031FDED
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

		// Token: 0x170047F5 RID: 18421
		// (get) Token: 0x06015942 RID: 88386 RVA: 0x00321BF6 File Offset: 0x0031FDF6
		// (set) Token: 0x06015943 RID: 88387 RVA: 0x00321BFE File Offset: 0x0031FDFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x06015944 RID: 88388 RVA: 0x00321C07 File Offset: 0x0031FE07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeTokenReceiveRequest);
		}

		// Token: 0x06015945 RID: 88389 RVA: 0x00321C15 File Offset: 0x0031FE15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeTokenReceiveRequest other)
		{
			return other != null && (other == this || (this.SeasonId == other.SeasonId && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015946 RID: 88390 RVA: 0x00321C54 File Offset: 0x0031FE54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SeasonId != 0)
			{
				num ^= this.SeasonId.GetHashCode();
			}
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015947 RID: 88391 RVA: 0x00321CAC File Offset: 0x0031FEAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015948 RID: 88392 RVA: 0x00321CB9 File Offset: 0x0031FEB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015949 RID: 88393 RVA: 0x00321CC4 File Offset: 0x0031FEC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SeasonId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SeasonId);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601594A RID: 88394 RVA: 0x00321D20 File Offset: 0x0031FF20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SeasonId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SeasonId);
			}
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601594B RID: 88395 RVA: 0x00321D78 File Offset: 0x0031FF78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeTokenReceiveRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SeasonId != 0)
			{
				this.SeasonId = other.SeasonId;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601594C RID: 88396 RVA: 0x00321DC8 File Offset: 0x0031FFC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601594D RID: 88397 RVA: 0x00321DD4 File Offset: 0x0031FFD4
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
					if (num != 32U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadInt32();
					}
				}
				else
				{
					this.SeasonId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400819D RID: 33181
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400819E RID: 33182
		public const int SeasonIdFieldNumber = 3;

		// Token: 0x0400819F RID: 33183
		private int seasonId_;

		// Token: 0x040081A0 RID: 33184
		public const int IdFieldNumber = 4;

		// Token: 0x040081A1 RID: 33185
		private int id_;
	}
}
