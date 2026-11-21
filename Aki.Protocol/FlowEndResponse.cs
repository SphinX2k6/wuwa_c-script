using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005E4 RID: 1508
	[NetMessage(EMessageId.FlowEndResponse)]
	public sealed class FlowEndResponse : IMessage<FlowEndResponse>, IMessage, IEquatable<FlowEndResponse>, IDeepCloneable<FlowEndResponse>, IBufferMessage
	{
		// Token: 0x06008C20 RID: 35872 RVA: 0x0015485F File Offset: 0x00152A5F
		[NullableContext(1)]
		public static FlowEndResponse Create()
		{
			return new FlowEndResponse();
		}

		// Token: 0x17001BC4 RID: 7108
		// (get) Token: 0x06008C21 RID: 35873 RVA: 0x00154866 File Offset: 0x00152A66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001BC5 RID: 7109
		// (get) Token: 0x06008C22 RID: 35874 RVA: 0x00154869 File Offset: 0x00152A69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlowEndResponse.Descriptor;
			}
		}

		// Token: 0x06008C23 RID: 35875 RVA: 0x00154870 File Offset: 0x00152A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowEndResponse()
		{
		}

		// Token: 0x06008C24 RID: 35876 RVA: 0x00154878 File Offset: 0x00152A78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowEndResponse(FlowEndResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008C25 RID: 35877 RVA: 0x0015489D File Offset: 0x00152A9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowEndResponse Clone()
		{
			return new FlowEndResponse(this);
		}

		// Token: 0x17001BC6 RID: 7110
		// (get) Token: 0x06008C26 RID: 35878 RVA: 0x001548A5 File Offset: 0x00152AA5
		// (set) Token: 0x06008C27 RID: 35879 RVA: 0x001548AD File Offset: 0x00152AAD
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

		// Token: 0x06008C28 RID: 35880 RVA: 0x001548B6 File Offset: 0x00152AB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlowEndResponse);
		}

		// Token: 0x06008C29 RID: 35881 RVA: 0x001548C4 File Offset: 0x00152AC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlowEndResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008C2A RID: 35882 RVA: 0x001548F4 File Offset: 0x00152AF4
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

		// Token: 0x06008C2B RID: 35883 RVA: 0x00154939 File Offset: 0x00152B39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008C2C RID: 35884 RVA: 0x00154946 File Offset: 0x00152B46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008C2D RID: 35885 RVA: 0x0015494F File Offset: 0x00152B4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008C2E RID: 35886 RVA: 0x00154984 File Offset: 0x00152B84
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

		// Token: 0x06008C2F RID: 35887 RVA: 0x001549C2 File Offset: 0x00152BC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlowEndResponse other)
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

		// Token: 0x06008C30 RID: 35888 RVA: 0x001549F3 File Offset: 0x00152BF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008C31 RID: 35889 RVA: 0x001549FC File Offset: 0x00152BFC
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400450D RID: 17677
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400450E RID: 17678
		public const int CodeFieldNumber = 8;

		// Token: 0x0400450F RID: 17679
		private ErrorCode code_;
	}
}
