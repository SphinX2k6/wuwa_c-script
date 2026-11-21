using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200040A RID: 1034
	[NetMessage(EMessageId.EdgeRunnerFunctionPreUnlockRequest)]
	public sealed class EdgeRunnerFunctionPreUnlockRequest : IMessage<EdgeRunnerFunctionPreUnlockRequest>, IMessage, IEquatable<EdgeRunnerFunctionPreUnlockRequest>, IDeepCloneable<EdgeRunnerFunctionPreUnlockRequest>, IBufferMessage
	{
		// Token: 0x06006417 RID: 25623 RVA: 0x000F1A72 File Offset: 0x000EFC72
		[NullableContext(1)]
		public static EdgeRunnerFunctionPreUnlockRequest Create()
		{
			return new EdgeRunnerFunctionPreUnlockRequest();
		}

		// Token: 0x170012BF RID: 4799
		// (get) Token: 0x06006418 RID: 25624 RVA: 0x000F1A79 File Offset: 0x000EFC79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170012C0 RID: 4800
		// (get) Token: 0x06006419 RID: 25625 RVA: 0x000F1A7C File Offset: 0x000EFC7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EdgeRunnerFunctionPreUnlockRequest.Descriptor;
			}
		}

		// Token: 0x0600641A RID: 25626 RVA: 0x000F1A83 File Offset: 0x000EFC83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerFunctionPreUnlockRequest()
		{
		}

		// Token: 0x0600641B RID: 25627 RVA: 0x000F1A8B File Offset: 0x000EFC8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerFunctionPreUnlockRequest(EdgeRunnerFunctionPreUnlockRequest other) : this()
		{
			this.funcId_ = other.funcId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600641C RID: 25628 RVA: 0x000F1AB0 File Offset: 0x000EFCB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerFunctionPreUnlockRequest Clone()
		{
			return new EdgeRunnerFunctionPreUnlockRequest(this);
		}

		// Token: 0x170012C1 RID: 4801
		// (get) Token: 0x0600641D RID: 25629 RVA: 0x000F1AB8 File Offset: 0x000EFCB8
		// (set) Token: 0x0600641E RID: 25630 RVA: 0x000F1AC0 File Offset: 0x000EFCC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FuncId
		{
			get
			{
				return this.funcId_;
			}
			set
			{
				this.funcId_ = value;
			}
		}

		// Token: 0x0600641F RID: 25631 RVA: 0x000F1AC9 File Offset: 0x000EFCC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EdgeRunnerFunctionPreUnlockRequest);
		}

		// Token: 0x06006420 RID: 25632 RVA: 0x000F1AD7 File Offset: 0x000EFCD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EdgeRunnerFunctionPreUnlockRequest other)
		{
			return other != null && (other == this || (this.FuncId == other.FuncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006421 RID: 25633 RVA: 0x000F1B08 File Offset: 0x000EFD08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FuncId != 0)
			{
				num ^= this.FuncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006422 RID: 25634 RVA: 0x000F1B47 File Offset: 0x000EFD47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006423 RID: 25635 RVA: 0x000F1B54 File Offset: 0x000EFD54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006424 RID: 25636 RVA: 0x000F1B5D File Offset: 0x000EFD5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FuncId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.FuncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006425 RID: 25637 RVA: 0x000F1B90 File Offset: 0x000EFD90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FuncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FuncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006426 RID: 25638 RVA: 0x000F1BCE File Offset: 0x000EFDCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EdgeRunnerFunctionPreUnlockRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FuncId != 0)
			{
				this.FuncId = other.FuncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006427 RID: 25639 RVA: 0x000F1BFF File Offset: 0x000EFDFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006428 RID: 25640 RVA: 0x000F1C08 File Offset: 0x000EFE08
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
					this.FuncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040038DD RID: 14557
		private UnknownFieldSet _unknownFields;

		// Token: 0x040038DE RID: 14558
		public const int FuncIdFieldNumber = 9;

		// Token: 0x040038DF RID: 14559
		private int funcId_;
	}
}
