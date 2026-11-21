using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001544 RID: 5444
	[NetMessage(EMessageId.VehicleFinishResponse)]
	public sealed class VehicleFinishResponse : IMessage<VehicleFinishResponse>, IMessage, IEquatable<VehicleFinishResponse>, IDeepCloneable<VehicleFinishResponse>, IBufferMessage
	{
		// Token: 0x0601CD6C RID: 118124 RVA: 0x0042DD5D File Offset: 0x0042BF5D
		[NullableContext(1)]
		public static VehicleFinishResponse Create()
		{
			return new VehicleFinishResponse();
		}

		// Token: 0x17006194 RID: 24980
		// (get) Token: 0x0601CD6D RID: 118125 RVA: 0x0042DD64 File Offset: 0x0042BF64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006195 RID: 24981
		// (get) Token: 0x0601CD6E RID: 118126 RVA: 0x0042DD67 File Offset: 0x0042BF67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VehicleFinishResponse.Descriptor;
			}
		}

		// Token: 0x0601CD6F RID: 118127 RVA: 0x0042DD6E File Offset: 0x0042BF6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleFinishResponse()
		{
		}

		// Token: 0x0601CD70 RID: 118128 RVA: 0x0042DD76 File Offset: 0x0042BF76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleFinishResponse(VehicleFinishResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CD71 RID: 118129 RVA: 0x0042DD9B File Offset: 0x0042BF9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleFinishResponse Clone()
		{
			return new VehicleFinishResponse(this);
		}

		// Token: 0x17006196 RID: 24982
		// (get) Token: 0x0601CD72 RID: 118130 RVA: 0x0042DDA3 File Offset: 0x0042BFA3
		// (set) Token: 0x0601CD73 RID: 118131 RVA: 0x0042DDAB File Offset: 0x0042BFAB
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

		// Token: 0x0601CD74 RID: 118132 RVA: 0x0042DDB4 File Offset: 0x0042BFB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VehicleFinishResponse);
		}

		// Token: 0x0601CD75 RID: 118133 RVA: 0x0042DDC2 File Offset: 0x0042BFC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VehicleFinishResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CD76 RID: 118134 RVA: 0x0042DDF0 File Offset: 0x0042BFF0
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

		// Token: 0x0601CD77 RID: 118135 RVA: 0x0042DE35 File Offset: 0x0042C035
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CD78 RID: 118136 RVA: 0x0042DE42 File Offset: 0x0042C042
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CD79 RID: 118137 RVA: 0x0042DE4B File Offset: 0x0042C04B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CD7A RID: 118138 RVA: 0x0042DE80 File Offset: 0x0042C080
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

		// Token: 0x0601CD7B RID: 118139 RVA: 0x0042DEBE File Offset: 0x0042C0BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(VehicleFinishResponse other)
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

		// Token: 0x0601CD7C RID: 118140 RVA: 0x0042DEEF File Offset: 0x0042C0EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CD7D RID: 118141 RVA: 0x0042DEF8 File Offset: 0x0042C0F8
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A5EA RID: 42474
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A5EB RID: 42475
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x0400A5EC RID: 42476
		private ErrorCode errorCode_;
	}
}
