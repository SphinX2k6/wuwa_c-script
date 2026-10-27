using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010D2 RID: 4306
	[NetMessage(EMessageId.RoleUpdateDevelopTargetResponse)]
	public sealed class RoleUpdateDevelopTargetResponse : IMessage<RoleUpdateDevelopTargetResponse>, IMessage, IEquatable<RoleUpdateDevelopTargetResponse>, IDeepCloneable<RoleUpdateDevelopTargetResponse>, IBufferMessage
	{
		// Token: 0x06016F96 RID: 94102 RVA: 0x00355BF1 File Offset: 0x00353DF1
		[NullableContext(1)]
		public static RoleUpdateDevelopTargetResponse Create()
		{
			return new RoleUpdateDevelopTargetResponse();
		}

		// Token: 0x17004CF4 RID: 19700
		// (get) Token: 0x06016F97 RID: 94103 RVA: 0x00355BF8 File Offset: 0x00353DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004CF5 RID: 19701
		// (get) Token: 0x06016F98 RID: 94104 RVA: 0x00355BFB File Offset: 0x00353DFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleUpdateDevelopTargetResponse.Descriptor;
			}
		}

		// Token: 0x06016F99 RID: 94105 RVA: 0x00355C02 File Offset: 0x00353E02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleUpdateDevelopTargetResponse()
		{
		}

		// Token: 0x06016F9A RID: 94106 RVA: 0x00355C0A File Offset: 0x00353E0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleUpdateDevelopTargetResponse(RoleUpdateDevelopTargetResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016F9B RID: 94107 RVA: 0x00355C2F File Offset: 0x00353E2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleUpdateDevelopTargetResponse Clone()
		{
			return new RoleUpdateDevelopTargetResponse(this);
		}

		// Token: 0x17004CF6 RID: 19702
		// (get) Token: 0x06016F9C RID: 94108 RVA: 0x00355C37 File Offset: 0x00353E37
		// (set) Token: 0x06016F9D RID: 94109 RVA: 0x00355C3F File Offset: 0x00353E3F
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

		// Token: 0x06016F9E RID: 94110 RVA: 0x00355C48 File Offset: 0x00353E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleUpdateDevelopTargetResponse);
		}

		// Token: 0x06016F9F RID: 94111 RVA: 0x00355C56 File Offset: 0x00353E56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleUpdateDevelopTargetResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016FA0 RID: 94112 RVA: 0x00355C84 File Offset: 0x00353E84
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

		// Token: 0x06016FA1 RID: 94113 RVA: 0x00355CC9 File Offset: 0x00353EC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016FA2 RID: 94114 RVA: 0x00355CD6 File Offset: 0x00353ED6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016FA3 RID: 94115 RVA: 0x00355CDF File Offset: 0x00353EDF
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

		// Token: 0x06016FA4 RID: 94116 RVA: 0x00355D14 File Offset: 0x00353F14
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

		// Token: 0x06016FA5 RID: 94117 RVA: 0x00355D52 File Offset: 0x00353F52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleUpdateDevelopTargetResponse other)
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

		// Token: 0x06016FA6 RID: 94118 RVA: 0x00355D83 File Offset: 0x00353F83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016FA7 RID: 94119 RVA: 0x00355D8C File Offset: 0x00353F8C
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

		// Token: 0x040088D6 RID: 35030
		private UnknownFieldSet _unknownFields;

		// Token: 0x040088D7 RID: 35031
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x040088D8 RID: 35032
		private ErrorCode errorCode_;
	}
}
