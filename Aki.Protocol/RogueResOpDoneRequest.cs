using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FFC RID: 4092
	[NetMessage(EMessageId.RogueResOpDoneRequest)]
	public sealed class RogueResOpDoneRequest : IMessage<RogueResOpDoneRequest>, IMessage, IEquatable<RogueResOpDoneRequest>, IDeepCloneable<RogueResOpDoneRequest>, IBufferMessage
	{
		// Token: 0x06015DFE RID: 89598 RVA: 0x0032DBAA File Offset: 0x0032BDAA
		[NullableContext(1)]
		public static RogueResOpDoneRequest Create()
		{
			return new RogueResOpDoneRequest();
		}

		// Token: 0x1700490C RID: 18700
		// (get) Token: 0x06015DFF RID: 89599 RVA: 0x0032DBB1 File Offset: 0x0032BDB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700490D RID: 18701
		// (get) Token: 0x06015E00 RID: 89600 RVA: 0x0032DBB4 File Offset: 0x0032BDB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResOpDoneRequest.Descriptor;
			}
		}

		// Token: 0x06015E01 RID: 89601 RVA: 0x0032DBBB File Offset: 0x0032BDBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResOpDoneRequest()
		{
		}

		// Token: 0x06015E02 RID: 89602 RVA: 0x0032DBD0 File Offset: 0x0032BDD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResOpDoneRequest(RogueResOpDoneRequest other) : this()
		{
			this.incId_ = other.incId_;
			this.clientSelectId_ = other.clientSelectId_;
			this.clientSelectIds_ = other.clientSelectIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015E03 RID: 89603 RVA: 0x0032DC1D File Offset: 0x0032BE1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResOpDoneRequest Clone()
		{
			return new RogueResOpDoneRequest(this);
		}

		// Token: 0x1700490E RID: 18702
		// (get) Token: 0x06015E04 RID: 89604 RVA: 0x0032DC25 File Offset: 0x0032BE25
		// (set) Token: 0x06015E05 RID: 89605 RVA: 0x0032DC2D File Offset: 0x0032BE2D
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

		// Token: 0x1700490F RID: 18703
		// (get) Token: 0x06015E06 RID: 89606 RVA: 0x0032DC36 File Offset: 0x0032BE36
		// (set) Token: 0x06015E07 RID: 89607 RVA: 0x0032DC3E File Offset: 0x0032BE3E
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

		// Token: 0x17004910 RID: 18704
		// (get) Token: 0x06015E08 RID: 89608 RVA: 0x0032DC47 File Offset: 0x0032BE47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ClientSelectIds
		{
			get
			{
				return this.clientSelectIds_;
			}
		}

		// Token: 0x06015E09 RID: 89609 RVA: 0x0032DC4F File Offset: 0x0032BE4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResOpDoneRequest);
		}

		// Token: 0x06015E0A RID: 89610 RVA: 0x0032DC60 File Offset: 0x0032BE60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResOpDoneRequest other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && this.ClientSelectId == other.ClientSelectId && this.clientSelectIds_.Equals(other.clientSelectIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015E0B RID: 89611 RVA: 0x0032DCC0 File Offset: 0x0032BEC0
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

		// Token: 0x06015E0C RID: 89612 RVA: 0x0032DD26 File Offset: 0x0032BF26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015E0D RID: 89613 RVA: 0x0032DD33 File Offset: 0x0032BF33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015E0E RID: 89614 RVA: 0x0032DD3C File Offset: 0x0032BF3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ClientSelectId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ClientSelectId);
			}
			this.clientSelectIds_.WriteTo(ref output, RogueResOpDoneRequest._repeated_clientSelectIds_codec);
			if (this.IncId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.IncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015E0F RID: 89615 RVA: 0x0032DDA8 File Offset: 0x0032BFA8
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

		// Token: 0x06015E10 RID: 89616 RVA: 0x0032DE14 File Offset: 0x0032C014
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

		// Token: 0x06015E11 RID: 89617 RVA: 0x0032DE75 File Offset: 0x0032C075
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015E12 RID: 89618 RVA: 0x0032DE80 File Offset: 0x0032C080
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.ClientSelectId = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						goto IL_45;
					}
				}
				else
				{
					if (num == 26U)
					{
						goto IL_45;
					}
					if (num == 88U)
					{
						this.IncId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_45:
				this.clientSelectIds_.AddEntriesFrom(ref input, RogueResOpDoneRequest._repeated_clientSelectIds_codec);
			}
		}

		// Token: 0x04008334 RID: 33588
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008335 RID: 33589
		public const int IncIdFieldNumber = 11;

		// Token: 0x04008336 RID: 33590
		private int incId_;

		// Token: 0x04008337 RID: 33591
		public const int ClientSelectIdFieldNumber = 1;

		// Token: 0x04008338 RID: 33592
		private int clientSelectId_;

		// Token: 0x04008339 RID: 33593
		public const int ClientSelectIdsFieldNumber = 3;

		// Token: 0x0400833A RID: 33594
		private static readonly FieldCodec<int> _repeated_clientSelectIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x0400833B RID: 33595
		private readonly RepeatedField<int> clientSelectIds_ = new RepeatedField<int>();
	}
}
