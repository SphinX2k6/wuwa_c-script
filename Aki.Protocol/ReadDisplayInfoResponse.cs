using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E89 RID: 3721
	[NetMessage(EMessageId.ReadDisplayInfoResponse)]
	public sealed class ReadDisplayInfoResponse : IMessage<ReadDisplayInfoResponse>, IMessage, IEquatable<ReadDisplayInfoResponse>, IDeepCloneable<ReadDisplayInfoResponse>, IBufferMessage
	{
		// Token: 0x0601401B RID: 81947 RVA: 0x002EA41C File Offset: 0x002E861C
		[NullableContext(1)]
		public static ReadDisplayInfoResponse Create()
		{
			return new ReadDisplayInfoResponse();
		}

		// Token: 0x17004290 RID: 17040
		// (get) Token: 0x0601401C RID: 81948 RVA: 0x002EA423 File Offset: 0x002E8623
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004291 RID: 17041
		// (get) Token: 0x0601401D RID: 81949 RVA: 0x002EA426 File Offset: 0x002E8626
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReadDisplayInfoResponse.Descriptor;
			}
		}

		// Token: 0x0601401E RID: 81950 RVA: 0x002EA42D File Offset: 0x002E862D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReadDisplayInfoResponse()
		{
		}

		// Token: 0x0601401F RID: 81951 RVA: 0x002EA435 File Offset: 0x002E8635
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReadDisplayInfoResponse(ReadDisplayInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014020 RID: 81952 RVA: 0x002EA45A File Offset: 0x002E865A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReadDisplayInfoResponse Clone()
		{
			return new ReadDisplayInfoResponse(this);
		}

		// Token: 0x17004292 RID: 17042
		// (get) Token: 0x06014021 RID: 81953 RVA: 0x002EA462 File Offset: 0x002E8662
		// (set) Token: 0x06014022 RID: 81954 RVA: 0x002EA46A File Offset: 0x002E866A
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

		// Token: 0x06014023 RID: 81955 RVA: 0x002EA473 File Offset: 0x002E8673
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReadDisplayInfoResponse);
		}

		// Token: 0x06014024 RID: 81956 RVA: 0x002EA481 File Offset: 0x002E8681
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReadDisplayInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014025 RID: 81957 RVA: 0x002EA4B0 File Offset: 0x002E86B0
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

		// Token: 0x06014026 RID: 81958 RVA: 0x002EA4F5 File Offset: 0x002E86F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014027 RID: 81959 RVA: 0x002EA502 File Offset: 0x002E8702
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014028 RID: 81960 RVA: 0x002EA50B File Offset: 0x002E870B
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

		// Token: 0x06014029 RID: 81961 RVA: 0x002EA540 File Offset: 0x002E8740
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

		// Token: 0x0601402A RID: 81962 RVA: 0x002EA57E File Offset: 0x002E877E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ReadDisplayInfoResponse other)
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

		// Token: 0x0601402B RID: 81963 RVA: 0x002EA5AF File Offset: 0x002E87AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601402C RID: 81964 RVA: 0x002EA5B8 File Offset: 0x002E87B8
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

		// Token: 0x04007A87 RID: 31367
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007A88 RID: 31368
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04007A89 RID: 31369
		private ErrorCode errorCode_;
	}
}
