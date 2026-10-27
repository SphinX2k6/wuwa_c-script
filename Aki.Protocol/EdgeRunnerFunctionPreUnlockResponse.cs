using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000422 RID: 1058
	[NetMessage(EMessageId.EdgeRunnerFunctionPreUnlockResponse)]
	public sealed class EdgeRunnerFunctionPreUnlockResponse : IMessage<EdgeRunnerFunctionPreUnlockResponse>, IMessage, IEquatable<EdgeRunnerFunctionPreUnlockResponse>, IDeepCloneable<EdgeRunnerFunctionPreUnlockResponse>, IBufferMessage
	{
		// Token: 0x060065B9 RID: 26041 RVA: 0x000F4DC1 File Offset: 0x000F2FC1
		[NullableContext(1)]
		public static EdgeRunnerFunctionPreUnlockResponse Create()
		{
			return new EdgeRunnerFunctionPreUnlockResponse();
		}

		// Token: 0x17001317 RID: 4887
		// (get) Token: 0x060065BA RID: 26042 RVA: 0x000F4DC8 File Offset: 0x000F2FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001318 RID: 4888
		// (get) Token: 0x060065BB RID: 26043 RVA: 0x000F4DCB File Offset: 0x000F2FCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EdgeRunnerFunctionPreUnlockResponse.Descriptor;
			}
		}

		// Token: 0x060065BC RID: 26044 RVA: 0x000F4DD2 File Offset: 0x000F2FD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerFunctionPreUnlockResponse()
		{
		}

		// Token: 0x060065BD RID: 26045 RVA: 0x000F4DDA File Offset: 0x000F2FDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerFunctionPreUnlockResponse(EdgeRunnerFunctionPreUnlockResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060065BE RID: 26046 RVA: 0x000F4DFF File Offset: 0x000F2FFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerFunctionPreUnlockResponse Clone()
		{
			return new EdgeRunnerFunctionPreUnlockResponse(this);
		}

		// Token: 0x17001319 RID: 4889
		// (get) Token: 0x060065BF RID: 26047 RVA: 0x000F4E07 File Offset: 0x000F3007
		// (set) Token: 0x060065C0 RID: 26048 RVA: 0x000F4E0F File Offset: 0x000F300F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x060065C1 RID: 26049 RVA: 0x000F4E18 File Offset: 0x000F3018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EdgeRunnerFunctionPreUnlockResponse);
		}

		// Token: 0x060065C2 RID: 26050 RVA: 0x000F4E26 File Offset: 0x000F3026
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EdgeRunnerFunctionPreUnlockResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060065C3 RID: 26051 RVA: 0x000F4E54 File Offset: 0x000F3054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060065C4 RID: 26052 RVA: 0x000F4E99 File Offset: 0x000F3099
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060065C5 RID: 26053 RVA: 0x000F4EA6 File Offset: 0x000F30A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060065C6 RID: 26054 RVA: 0x000F4EAF File Offset: 0x000F30AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060065C7 RID: 26055 RVA: 0x000F4EE4 File Offset: 0x000F30E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060065C8 RID: 26056 RVA: 0x000F4F22 File Offset: 0x000F3122
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EdgeRunnerFunctionPreUnlockResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060065C9 RID: 26057 RVA: 0x000F4F53 File Offset: 0x000F3153
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060065CA RID: 26058 RVA: 0x000F4F5C File Offset: 0x000F315C
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040038F3 RID: 14579
		private UnknownFieldSet _unknownFields;

		// Token: 0x040038F4 RID: 14580
		public const int ErrCodeFieldNumber = 2;

		// Token: 0x040038F5 RID: 14581
		private ErrorCode errCode_;
	}
}
