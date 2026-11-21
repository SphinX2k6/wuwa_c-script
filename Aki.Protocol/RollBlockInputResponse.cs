using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001118 RID: 4376
	[NetMessage(EMessageId.RollBlockInputResponse)]
	public sealed class RollBlockInputResponse : IMessage<RollBlockInputResponse>, IMessage, IEquatable<RollBlockInputResponse>, IDeepCloneable<RollBlockInputResponse>, IBufferMessage
	{
		// Token: 0x06017636 RID: 95798 RVA: 0x003673B7 File Offset: 0x003655B7
		[NullableContext(1)]
		public static RollBlockInputResponse Create()
		{
			return new RollBlockInputResponse();
		}

		// Token: 0x17004E99 RID: 20121
		// (get) Token: 0x06017637 RID: 95799 RVA: 0x003673BE File Offset: 0x003655BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E9A RID: 20122
		// (get) Token: 0x06017638 RID: 95800 RVA: 0x003673C1 File Offset: 0x003655C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RollBlockInputResponse.Descriptor;
			}
		}

		// Token: 0x06017639 RID: 95801 RVA: 0x003673C8 File Offset: 0x003655C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockInputResponse()
		{
		}

		// Token: 0x0601763A RID: 95802 RVA: 0x003673D0 File Offset: 0x003655D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockInputResponse(RollBlockInputResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601763B RID: 95803 RVA: 0x003673F5 File Offset: 0x003655F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockInputResponse Clone()
		{
			return new RollBlockInputResponse(this);
		}

		// Token: 0x17004E9B RID: 20123
		// (get) Token: 0x0601763C RID: 95804 RVA: 0x003673FD File Offset: 0x003655FD
		// (set) Token: 0x0601763D RID: 95805 RVA: 0x00367405 File Offset: 0x00365605
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x0601763E RID: 95806 RVA: 0x0036740E File Offset: 0x0036560E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RollBlockInputResponse);
		}

		// Token: 0x0601763F RID: 95807 RVA: 0x0036741C File Offset: 0x0036561C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RollBlockInputResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017640 RID: 95808 RVA: 0x0036744C File Offset: 0x0036564C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017641 RID: 95809 RVA: 0x00367491 File Offset: 0x00365691
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017642 RID: 95810 RVA: 0x0036749E File Offset: 0x0036569E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017643 RID: 95811 RVA: 0x003674A7 File Offset: 0x003656A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017644 RID: 95812 RVA: 0x003674DC File Offset: 0x003656DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017645 RID: 95813 RVA: 0x0036751A File Offset: 0x0036571A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RollBlockInputResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017646 RID: 95814 RVA: 0x0036754B File Offset: 0x0036574B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017647 RID: 95815 RVA: 0x00367554 File Offset: 0x00365754
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
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008BB7 RID: 35767
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008BB8 RID: 35768
		public const int CodeFieldNumber = 3;

		// Token: 0x04008BB9 RID: 35769
		private ErrorCode code_;
	}
}
