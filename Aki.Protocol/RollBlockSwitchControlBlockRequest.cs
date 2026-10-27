using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010E6 RID: 4326
	[NetMessage(EMessageId.RollBlockSwitchControlBlockRequest)]
	public sealed class RollBlockSwitchControlBlockRequest : IMessage<RollBlockSwitchControlBlockRequest>, IMessage, IEquatable<RollBlockSwitchControlBlockRequest>, IDeepCloneable<RollBlockSwitchControlBlockRequest>, IBufferMessage
	{
		// Token: 0x06017129 RID: 94505 RVA: 0x003591A9 File Offset: 0x003573A9
		[NullableContext(1)]
		public static RollBlockSwitchControlBlockRequest Create()
		{
			return new RollBlockSwitchControlBlockRequest();
		}

		// Token: 0x17004D47 RID: 19783
		// (get) Token: 0x0601712A RID: 94506 RVA: 0x003591B0 File Offset: 0x003573B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D48 RID: 19784
		// (get) Token: 0x0601712B RID: 94507 RVA: 0x003591B3 File Offset: 0x003573B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RollBlockSwitchControlBlockRequest.Descriptor;
			}
		}

		// Token: 0x0601712C RID: 94508 RVA: 0x003591BA File Offset: 0x003573BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockSwitchControlBlockRequest()
		{
		}

		// Token: 0x0601712D RID: 94509 RVA: 0x003591C2 File Offset: 0x003573C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockSwitchControlBlockRequest(RollBlockSwitchControlBlockRequest other) : this()
		{
			this.incId_ = other.incId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601712E RID: 94510 RVA: 0x003591E7 File Offset: 0x003573E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockSwitchControlBlockRequest Clone()
		{
			return new RollBlockSwitchControlBlockRequest(this);
		}

		// Token: 0x17004D49 RID: 19785
		// (get) Token: 0x0601712F RID: 94511 RVA: 0x003591EF File Offset: 0x003573EF
		// (set) Token: 0x06017130 RID: 94512 RVA: 0x003591F7 File Offset: 0x003573F7
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

		// Token: 0x06017131 RID: 94513 RVA: 0x00359200 File Offset: 0x00357400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RollBlockSwitchControlBlockRequest);
		}

		// Token: 0x06017132 RID: 94514 RVA: 0x0035920E File Offset: 0x0035740E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RollBlockSwitchControlBlockRequest other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017133 RID: 94515 RVA: 0x0035923C File Offset: 0x0035743C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017134 RID: 94516 RVA: 0x0035927B File Offset: 0x0035747B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017135 RID: 94517 RVA: 0x00359288 File Offset: 0x00357488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017136 RID: 94518 RVA: 0x00359291 File Offset: 0x00357491
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.IncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017137 RID: 94519 RVA: 0x003592C4 File Offset: 0x003574C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017138 RID: 94520 RVA: 0x00359302 File Offset: 0x00357502
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RollBlockSwitchControlBlockRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017139 RID: 94521 RVA: 0x00359333 File Offset: 0x00357533
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601713A RID: 94522 RVA: 0x0035933C File Offset: 0x0035753C
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.IncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008940 RID: 35136
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008941 RID: 35137
		public const int IncIdFieldNumber = 3;

		// Token: 0x04008942 RID: 35138
		private int incId_;
	}
}
