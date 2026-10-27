using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A13 RID: 2579
	[NetMessage(EMessageId.MoonPhaseRewardResponse)]
	public sealed class MoonPhaseRewardResponse : IMessage<MoonPhaseRewardResponse>, IMessage, IEquatable<MoonPhaseRewardResponse>, IDeepCloneable<MoonPhaseRewardResponse>, IBufferMessage
	{
		// Token: 0x0600E192 RID: 57746 RVA: 0x0021093E File Offset: 0x0020EB3E
		[NullableContext(1)]
		public static MoonPhaseRewardResponse Create()
		{
			return new MoonPhaseRewardResponse();
		}

		// Token: 0x17002DBA RID: 11706
		// (get) Token: 0x0600E193 RID: 57747 RVA: 0x00210945 File Offset: 0x0020EB45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002DBB RID: 11707
		// (get) Token: 0x0600E194 RID: 57748 RVA: 0x00210948 File Offset: 0x0020EB48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MoonPhaseRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600E195 RID: 57749 RVA: 0x0021094F File Offset: 0x0020EB4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoonPhaseRewardResponse()
		{
		}

		// Token: 0x0600E196 RID: 57750 RVA: 0x00210957 File Offset: 0x0020EB57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoonPhaseRewardResponse(MoonPhaseRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E197 RID: 57751 RVA: 0x0021097C File Offset: 0x0020EB7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoonPhaseRewardResponse Clone()
		{
			return new MoonPhaseRewardResponse(this);
		}

		// Token: 0x17002DBC RID: 11708
		// (get) Token: 0x0600E198 RID: 57752 RVA: 0x00210984 File Offset: 0x0020EB84
		// (set) Token: 0x0600E199 RID: 57753 RVA: 0x0021098C File Offset: 0x0020EB8C
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

		// Token: 0x0600E19A RID: 57754 RVA: 0x00210995 File Offset: 0x0020EB95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MoonPhaseRewardResponse);
		}

		// Token: 0x0600E19B RID: 57755 RVA: 0x002109A3 File Offset: 0x0020EBA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MoonPhaseRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E19C RID: 57756 RVA: 0x002109D4 File Offset: 0x0020EBD4
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

		// Token: 0x0600E19D RID: 57757 RVA: 0x00210A19 File Offset: 0x0020EC19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E19E RID: 57758 RVA: 0x00210A26 File Offset: 0x0020EC26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E19F RID: 57759 RVA: 0x00210A2F File Offset: 0x0020EC2F
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

		// Token: 0x0600E1A0 RID: 57760 RVA: 0x00210A64 File Offset: 0x0020EC64
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

		// Token: 0x0600E1A1 RID: 57761 RVA: 0x00210AA2 File Offset: 0x0020ECA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MoonPhaseRewardResponse other)
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

		// Token: 0x0600E1A2 RID: 57762 RVA: 0x00210AD3 File Offset: 0x0020ECD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E1A3 RID: 57763 RVA: 0x00210ADC File Offset: 0x0020ECDC
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

		// Token: 0x04005CAE RID: 23726
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005CAF RID: 23727
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04005CB0 RID: 23728
		private ErrorCode errorCode_;
	}
}
