using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001111 RID: 4369
	[NetMessage(EMessageId.RollBlockExitGamePlayRequest)]
	public sealed class RollBlockExitGamePlayRequest : IMessage<RollBlockExitGamePlayRequest>, IMessage, IEquatable<RollBlockExitGamePlayRequest>, IDeepCloneable<RollBlockExitGamePlayRequest>, IBufferMessage
	{
		// Token: 0x06017599 RID: 95641 RVA: 0x00365A49 File Offset: 0x00363C49
		[NullableContext(1)]
		public static RollBlockExitGamePlayRequest Create()
		{
			return new RollBlockExitGamePlayRequest();
		}

		// Token: 0x17004E73 RID: 20083
		// (get) Token: 0x0601759A RID: 95642 RVA: 0x00365A50 File Offset: 0x00363C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E74 RID: 20084
		// (get) Token: 0x0601759B RID: 95643 RVA: 0x00365A53 File Offset: 0x00363C53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RollBlockExitGamePlayRequest.Descriptor;
			}
		}

		// Token: 0x0601759C RID: 95644 RVA: 0x00365A5A File Offset: 0x00363C5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockExitGamePlayRequest()
		{
		}

		// Token: 0x0601759D RID: 95645 RVA: 0x00365A62 File Offset: 0x00363C62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockExitGamePlayRequest(RollBlockExitGamePlayRequest other) : this()
		{
			this.incId_ = other.incId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601759E RID: 95646 RVA: 0x00365A87 File Offset: 0x00363C87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockExitGamePlayRequest Clone()
		{
			return new RollBlockExitGamePlayRequest(this);
		}

		// Token: 0x17004E75 RID: 20085
		// (get) Token: 0x0601759F RID: 95647 RVA: 0x00365A8F File Offset: 0x00363C8F
		// (set) Token: 0x060175A0 RID: 95648 RVA: 0x00365A97 File Offset: 0x00363C97
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

		// Token: 0x060175A1 RID: 95649 RVA: 0x00365AA0 File Offset: 0x00363CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RollBlockExitGamePlayRequest);
		}

		// Token: 0x060175A2 RID: 95650 RVA: 0x00365AAE File Offset: 0x00363CAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RollBlockExitGamePlayRequest other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060175A3 RID: 95651 RVA: 0x00365ADC File Offset: 0x00363CDC
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

		// Token: 0x060175A4 RID: 95652 RVA: 0x00365B1B File Offset: 0x00363D1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060175A5 RID: 95653 RVA: 0x00365B28 File Offset: 0x00363D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060175A6 RID: 95654 RVA: 0x00365B31 File Offset: 0x00363D31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.IncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060175A7 RID: 95655 RVA: 0x00365B64 File Offset: 0x00363D64
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

		// Token: 0x060175A8 RID: 95656 RVA: 0x00365BA2 File Offset: 0x00363DA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RollBlockExitGamePlayRequest other)
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

		// Token: 0x060175A9 RID: 95657 RVA: 0x00365BD3 File Offset: 0x00363DD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060175AA RID: 95658 RVA: 0x00365BDC File Offset: 0x00363DDC
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.IncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008B7E RID: 35710
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008B7F RID: 35711
		public const int IncIdFieldNumber = 9;

		// Token: 0x04008B80 RID: 35712
		private int incId_;
	}
}
