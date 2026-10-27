using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D3D RID: 3389
	[NetMessage(EMessageId.PilotThrowOperationRequest)]
	public sealed class PilotThrowOperationRequest : IMessage<PilotThrowOperationRequest>, IMessage, IEquatable<PilotThrowOperationRequest>, IDeepCloneable<PilotThrowOperationRequest>, IBufferMessage
	{
		// Token: 0x0601249F RID: 74911 RVA: 0x002AB511 File Offset: 0x002A9711
		[NullableContext(1)]
		public static PilotThrowOperationRequest Create()
		{
			return new PilotThrowOperationRequest();
		}

		// Token: 0x17003C98 RID: 15512
		// (get) Token: 0x060124A0 RID: 74912 RVA: 0x002AB518 File Offset: 0x002A9718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C99 RID: 15513
		// (get) Token: 0x060124A1 RID: 74913 RVA: 0x002AB51B File Offset: 0x002A971B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PilotThrowOperationRequest.Descriptor;
			}
		}

		// Token: 0x060124A2 RID: 74914 RVA: 0x002AB522 File Offset: 0x002A9722
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PilotThrowOperationRequest()
		{
		}

		// Token: 0x060124A3 RID: 74915 RVA: 0x002AB52A File Offset: 0x002A972A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PilotThrowOperationRequest(PilotThrowOperationRequest other) : this()
		{
			this.opType_ = other.opType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060124A4 RID: 74916 RVA: 0x002AB54F File Offset: 0x002A974F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PilotThrowOperationRequest Clone()
		{
			return new PilotThrowOperationRequest(this);
		}

		// Token: 0x17003C9A RID: 15514
		// (get) Token: 0x060124A5 RID: 74917 RVA: 0x002AB557 File Offset: 0x002A9757
		// (set) Token: 0x060124A6 RID: 74918 RVA: 0x002AB55F File Offset: 0x002A975F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PilotThrowOperationType OpType
		{
			get
			{
				return this.opType_;
			}
			set
			{
				this.opType_ = value;
			}
		}

		// Token: 0x060124A7 RID: 74919 RVA: 0x002AB568 File Offset: 0x002A9768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PilotThrowOperationRequest);
		}

		// Token: 0x060124A8 RID: 74920 RVA: 0x002AB576 File Offset: 0x002A9776
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PilotThrowOperationRequest other)
		{
			return other != null && (other == this || (this.OpType == other.OpType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060124A9 RID: 74921 RVA: 0x002AB5A4 File Offset: 0x002A97A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.OpType != PilotThrowOperationType.Ptothrow)
			{
				num ^= this.OpType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060124AA RID: 74922 RVA: 0x002AB5E9 File Offset: 0x002A97E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060124AB RID: 74923 RVA: 0x002AB5F6 File Offset: 0x002A97F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060124AC RID: 74924 RVA: 0x002AB5FF File Offset: 0x002A97FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OpType != PilotThrowOperationType.Ptothrow)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.OpType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060124AD RID: 74925 RVA: 0x002AB634 File Offset: 0x002A9834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.OpType != PilotThrowOperationType.Ptothrow)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.OpType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060124AE RID: 74926 RVA: 0x002AB672 File Offset: 0x002A9872
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PilotThrowOperationRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.OpType != PilotThrowOperationType.Ptothrow)
			{
				this.OpType = other.OpType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060124AF RID: 74927 RVA: 0x002AB6A3 File Offset: 0x002A98A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060124B0 RID: 74928 RVA: 0x002AB6AC File Offset: 0x002A98AC
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.OpType = (PilotThrowOperationType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007208 RID: 29192
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007209 RID: 29193
		public const int OpTypeFieldNumber = 13;

		// Token: 0x0400720A RID: 29194
		private PilotThrowOperationType opType_;
	}
}
