using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FEC RID: 4076
	[NetMessage(EMessageId.RogueResOpDoneRequest)]
	public sealed class RogueResOpDoneRequest : IMessage<RogueResOpDoneRequest>, IMessage, IEquatable<RogueResOpDoneRequest>, IDeepCloneable<RogueResOpDoneRequest>, IBufferMessage
	{
		// Token: 0x06015D19 RID: 89369 RVA: 0x0032C4E6 File Offset: 0x0032A6E6
		[NullableContext(1)]
		public static RogueResOpDoneRequest Create()
		{
			return new RogueResOpDoneRequest();
		}

		// Token: 0x170048E2 RID: 18658
		// (get) Token: 0x06015D1A RID: 89370 RVA: 0x0032C4ED File Offset: 0x0032A6ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170048E3 RID: 18659
		// (get) Token: 0x06015D1B RID: 89371 RVA: 0x0032C4F0 File Offset: 0x0032A6F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResOpDoneRequest.Descriptor;
			}
		}

		// Token: 0x06015D1C RID: 89372 RVA: 0x0032C4F7 File Offset: 0x0032A6F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResOpDoneRequest()
		{
		}

		// Token: 0x06015D1D RID: 89373 RVA: 0x0032C50C File Offset: 0x0032A70C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResOpDoneRequest(RogueResOpDoneRequest other) : this()
		{
			this.incId_ = other.incId_;
			this.clientSelectId_ = other.clientSelectId_;
			this.clientSelectIds_ = other.clientSelectIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015D1E RID: 89374 RVA: 0x0032C559 File Offset: 0x0032A759
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResOpDoneRequest Clone()
		{
			return new RogueResOpDoneRequest(this);
		}

		// Token: 0x170048E4 RID: 18660
		// (get) Token: 0x06015D1F RID: 89375 RVA: 0x0032C561 File Offset: 0x0032A761
		// (set) Token: 0x06015D20 RID: 89376 RVA: 0x0032C569 File Offset: 0x0032A769
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x170048E5 RID: 18661
		// (get) Token: 0x06015D21 RID: 89377 RVA: 0x0032C572 File Offset: 0x0032A772
		// (set) Token: 0x06015D22 RID: 89378 RVA: 0x0032C57A File Offset: 0x0032A77A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ClientSelectId
		{
			get
			{
				return this.clientSelectId_;
			}
			set
			{
				this.clientSelectId_ = value;
			}
		}

		// Token: 0x170048E6 RID: 18662
		// (get) Token: 0x06015D23 RID: 89379 RVA: 0x0032C583 File Offset: 0x0032A783
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ClientSelectIds
		{
			get
			{
				return this.clientSelectIds_;
			}
		}

		// Token: 0x06015D24 RID: 89380 RVA: 0x0032C58B File Offset: 0x0032A78B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResOpDoneRequest);
		}

		// Token: 0x06015D25 RID: 89381 RVA: 0x0032C59C File Offset: 0x0032A79C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResOpDoneRequest other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && this.ClientSelectId == other.ClientSelectId && this.clientSelectIds_.Equals(other.clientSelectIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015D26 RID: 89382 RVA: 0x0032C5FC File Offset: 0x0032A7FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this.ClientSelectId != 0)
			{
				num ^= this.ClientSelectId.GetHashCode();
			}
			num ^= this.clientSelectIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015D27 RID: 89383 RVA: 0x0032C662 File Offset: 0x0032A862
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015D28 RID: 89384 RVA: 0x0032C66F File Offset: 0x0032A86F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015D29 RID: 89385 RVA: 0x0032C678 File Offset: 0x0032A878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.IncId);
			}
			if (this.ClientSelectId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ClientSelectId);
			}
			this.clientSelectIds_.WriteTo(ref output, RogueResOpDoneRequest._repeated_clientSelectIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015D2A RID: 89386 RVA: 0x0032C6E4 File Offset: 0x0032A8E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this.ClientSelectId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ClientSelectId);
			}
			num += this.clientSelectIds_.CalculateSize(RogueResOpDoneRequest._repeated_clientSelectIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015D2B RID: 89387 RVA: 0x0032C750 File Offset: 0x0032A950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResOpDoneRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			if (other.ClientSelectId != 0)
			{
				this.ClientSelectId = other.ClientSelectId;
			}
			this.clientSelectIds_.Add(other.clientSelectIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015D2C RID: 89388 RVA: 0x0032C7B1 File Offset: 0x0032A9B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015D2D RID: 89389 RVA: 0x0032C7BC File Offset: 0x0032A9BC
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
				if (num <= 96U)
				{
					if (num == 48U)
					{
						this.IncId = input.ReadInt32();
						continue;
					}
					if (num == 96U)
					{
						this.ClientSelectId = input.ReadInt32();
						continue;
					}
				}
				else if (num == 104U || num == 106U)
				{
					this.clientSelectIds_.AddEntriesFrom(ref input, RogueResOpDoneRequest._repeated_clientSelectIds_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400835E RID: 33630
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400835F RID: 33631
		public const int IncIdFieldNumber = 6;

		// Token: 0x04008360 RID: 33632
		private int incId_;

		// Token: 0x04008361 RID: 33633
		public const int ClientSelectIdFieldNumber = 12;

		// Token: 0x04008362 RID: 33634
		private int clientSelectId_;

		// Token: 0x04008363 RID: 33635
		public const int ClientSelectIdsFieldNumber = 13;

		// Token: 0x04008364 RID: 33636
		private static readonly FieldCodec<int> _repeated_clientSelectIds_codec = FieldCodec.ForInt32(106U);

		// Token: 0x04008365 RID: 33637
		private readonly RepeatedField<int> clientSelectIds_ = new RepeatedField<int>();
	}
}
