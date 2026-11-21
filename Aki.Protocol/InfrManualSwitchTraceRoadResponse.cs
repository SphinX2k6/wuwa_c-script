using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007D3 RID: 2003
	[NetMessage(EMessageId.InfrManualSwitchTraceRoadResponse)]
	public sealed class InfrManualSwitchTraceRoadResponse : IMessage<InfrManualSwitchTraceRoadResponse>, IMessage, IEquatable<InfrManualSwitchTraceRoadResponse>, IDeepCloneable<InfrManualSwitchTraceRoadResponse>, IBufferMessage
	{
		// Token: 0x0600B421 RID: 46113 RVA: 0x001AEB49 File Offset: 0x001ACD49
		[NullableContext(1)]
		public static InfrManualSwitchTraceRoadResponse Create()
		{
			return new InfrManualSwitchTraceRoadResponse();
		}

		// Token: 0x1700244B RID: 9291
		// (get) Token: 0x0600B422 RID: 46114 RVA: 0x001AEB50 File Offset: 0x001ACD50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700244C RID: 9292
		// (get) Token: 0x0600B423 RID: 46115 RVA: 0x001AEB53 File Offset: 0x001ACD53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrManualSwitchTraceRoadResponse.Descriptor;
			}
		}

		// Token: 0x0600B424 RID: 46116 RVA: 0x001AEB5A File Offset: 0x001ACD5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrManualSwitchTraceRoadResponse()
		{
		}

		// Token: 0x0600B425 RID: 46117 RVA: 0x001AEB62 File Offset: 0x001ACD62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrManualSwitchTraceRoadResponse(InfrManualSwitchTraceRoadResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B426 RID: 46118 RVA: 0x001AEB87 File Offset: 0x001ACD87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrManualSwitchTraceRoadResponse Clone()
		{
			return new InfrManualSwitchTraceRoadResponse(this);
		}

		// Token: 0x1700244D RID: 9293
		// (get) Token: 0x0600B427 RID: 46119 RVA: 0x001AEB8F File Offset: 0x001ACD8F
		// (set) Token: 0x0600B428 RID: 46120 RVA: 0x001AEB97 File Offset: 0x001ACD97
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

		// Token: 0x0600B429 RID: 46121 RVA: 0x001AEBA0 File Offset: 0x001ACDA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrManualSwitchTraceRoadResponse);
		}

		// Token: 0x0600B42A RID: 46122 RVA: 0x001AEBAE File Offset: 0x001ACDAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrManualSwitchTraceRoadResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B42B RID: 46123 RVA: 0x001AEBDC File Offset: 0x001ACDDC
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

		// Token: 0x0600B42C RID: 46124 RVA: 0x001AEC21 File Offset: 0x001ACE21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B42D RID: 46125 RVA: 0x001AEC2E File Offset: 0x001ACE2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B42E RID: 46126 RVA: 0x001AEC37 File Offset: 0x001ACE37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B42F RID: 46127 RVA: 0x001AEC6C File Offset: 0x001ACE6C
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

		// Token: 0x0600B430 RID: 46128 RVA: 0x001AECAA File Offset: 0x001ACEAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrManualSwitchTraceRoadResponse other)
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

		// Token: 0x0600B431 RID: 46129 RVA: 0x001AECDB File Offset: 0x001ACEDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B432 RID: 46130 RVA: 0x001AECE4 File Offset: 0x001ACEE4
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400507E RID: 20606
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400507F RID: 20607
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04005080 RID: 20608
		private ErrorCode errorCode_;
	}
}
