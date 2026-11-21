using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004D1 RID: 1233
	[NetMessage(EMessageId.ExecuteQteResponse)]
	public sealed class ExecuteQteResponse : IMessage<ExecuteQteResponse>, IMessage, IEquatable<ExecuteQteResponse>, IDeepCloneable<ExecuteQteResponse>, IBufferMessage
	{
		// Token: 0x06007561 RID: 30049 RVA: 0x0011F95E File Offset: 0x0011DB5E
		[NullableContext(1)]
		public static ExecuteQteResponse Create()
		{
			return new ExecuteQteResponse();
		}

		// Token: 0x170016BF RID: 5823
		// (get) Token: 0x06007562 RID: 30050 RVA: 0x0011F965 File Offset: 0x0011DB65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016C0 RID: 5824
		// (get) Token: 0x06007563 RID: 30051 RVA: 0x0011F968 File Offset: 0x0011DB68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExecuteQteResponse.Descriptor;
			}
		}

		// Token: 0x06007564 RID: 30052 RVA: 0x0011F96F File Offset: 0x0011DB6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExecuteQteResponse()
		{
		}

		// Token: 0x06007565 RID: 30053 RVA: 0x0011F977 File Offset: 0x0011DB77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExecuteQteResponse(ExecuteQteResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007566 RID: 30054 RVA: 0x0011F99C File Offset: 0x0011DB9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExecuteQteResponse Clone()
		{
			return new ExecuteQteResponse(this);
		}

		// Token: 0x170016C1 RID: 5825
		// (get) Token: 0x06007567 RID: 30055 RVA: 0x0011F9A4 File Offset: 0x0011DBA4
		// (set) Token: 0x06007568 RID: 30056 RVA: 0x0011F9AC File Offset: 0x0011DBAC
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

		// Token: 0x06007569 RID: 30057 RVA: 0x0011F9B5 File Offset: 0x0011DBB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExecuteQteResponse);
		}

		// Token: 0x0600756A RID: 30058 RVA: 0x0011F9C3 File Offset: 0x0011DBC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExecuteQteResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600756B RID: 30059 RVA: 0x0011F9F4 File Offset: 0x0011DBF4
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

		// Token: 0x0600756C RID: 30060 RVA: 0x0011FA39 File Offset: 0x0011DC39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600756D RID: 30061 RVA: 0x0011FA46 File Offset: 0x0011DC46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600756E RID: 30062 RVA: 0x0011FA4F File Offset: 0x0011DC4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600756F RID: 30063 RVA: 0x0011FA80 File Offset: 0x0011DC80
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

		// Token: 0x06007570 RID: 30064 RVA: 0x0011FABE File Offset: 0x0011DCBE
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

		// Token: 0x06007571 RID: 30065 RVA: 0x0011FAEF File Offset: 0x0011DCEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007572 RID: 30066 RVA: 0x0011FAF8 File Offset: 0x0011DCF8
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003E06 RID: 15878
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E07 RID: 15879
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04003E08 RID: 15880
		private ErrorCode errorCode_;
	}
}
