using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004E7 RID: 1255
	[NetMessage(EMessageId.ExecuteQteResponse)]
	public sealed class ExecuteQteResponse : IMessage<ExecuteQteResponse>, IMessage, IEquatable<ExecuteQteResponse>, IDeepCloneable<ExecuteQteResponse>, IBufferMessage
	{
		// Token: 0x060076DD RID: 30429 RVA: 0x001227E7 File Offset: 0x001209E7
		[NullableContext(1)]
		public static ExecuteQteResponse Create()
		{
			return new ExecuteQteResponse();
		}

		// Token: 0x17001710 RID: 5904
		// (get) Token: 0x060076DE RID: 30430 RVA: 0x001227EE File Offset: 0x001209EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001711 RID: 5905
		// (get) Token: 0x060076DF RID: 30431 RVA: 0x001227F1 File Offset: 0x001209F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExecuteQteResponse.Descriptor;
			}
		}

		// Token: 0x060076E0 RID: 30432 RVA: 0x001227F8 File Offset: 0x001209F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExecuteQteResponse()
		{
		}

		// Token: 0x060076E1 RID: 30433 RVA: 0x00122800 File Offset: 0x00120A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExecuteQteResponse(ExecuteQteResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060076E2 RID: 30434 RVA: 0x00122825 File Offset: 0x00120A25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExecuteQteResponse Clone()
		{
			return new ExecuteQteResponse(this);
		}

		// Token: 0x17001712 RID: 5906
		// (get) Token: 0x060076E3 RID: 30435 RVA: 0x0012282D File Offset: 0x00120A2D
		// (set) Token: 0x060076E4 RID: 30436 RVA: 0x00122835 File Offset: 0x00120A35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x060076E5 RID: 30437 RVA: 0x0012283E File Offset: 0x00120A3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExecuteQteResponse);
		}

		// Token: 0x060076E6 RID: 30438 RVA: 0x0012284C File Offset: 0x00120A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExecuteQteResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060076E7 RID: 30439 RVA: 0x0012287C File Offset: 0x00120A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060076E8 RID: 30440 RVA: 0x001228C1 File Offset: 0x00120AC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060076E9 RID: 30441 RVA: 0x001228CE File Offset: 0x00120ACE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060076EA RID: 30442 RVA: 0x001228D7 File Offset: 0x00120AD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060076EB RID: 30443 RVA: 0x0012290C File Offset: 0x00120B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060076EC RID: 30444 RVA: 0x0012294A File Offset: 0x00120B4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExecuteQteResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060076ED RID: 30445 RVA: 0x0012297B File Offset: 0x00120B7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060076EE RID: 30446 RVA: 0x00122984 File Offset: 0x00120B84
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003E15 RID: 15893
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E16 RID: 15894
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04003E17 RID: 15895
		private ErrorCode errorCode_;
	}
}
