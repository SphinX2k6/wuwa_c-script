using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007CD RID: 1997
	[NetMessage(EMessageId.InfrLevelUpResponse)]
	public sealed class InfrLevelUpResponse : IMessage<InfrLevelUpResponse>, IMessage, IEquatable<InfrLevelUpResponse>, IDeepCloneable<InfrLevelUpResponse>, IBufferMessage
	{
		// Token: 0x0600B3B4 RID: 46004 RVA: 0x001ADE82 File Offset: 0x001AC082
		[NullableContext(1)]
		public static InfrLevelUpResponse Create()
		{
			return new InfrLevelUpResponse();
		}

		// Token: 0x17002437 RID: 9271
		// (get) Token: 0x0600B3B5 RID: 46005 RVA: 0x001ADE89 File Offset: 0x001AC089
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002438 RID: 9272
		// (get) Token: 0x0600B3B6 RID: 46006 RVA: 0x001ADE8C File Offset: 0x001AC08C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrLevelUpResponse.Descriptor;
			}
		}

		// Token: 0x0600B3B7 RID: 46007 RVA: 0x001ADE93 File Offset: 0x001AC093
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrLevelUpResponse()
		{
		}

		// Token: 0x0600B3B8 RID: 46008 RVA: 0x001ADE9B File Offset: 0x001AC09B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrLevelUpResponse(InfrLevelUpResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B3B9 RID: 46009 RVA: 0x001ADEC0 File Offset: 0x001AC0C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrLevelUpResponse Clone()
		{
			return new InfrLevelUpResponse(this);
		}

		// Token: 0x17002439 RID: 9273
		// (get) Token: 0x0600B3BA RID: 46010 RVA: 0x001ADEC8 File Offset: 0x001AC0C8
		// (set) Token: 0x0600B3BB RID: 46011 RVA: 0x001ADED0 File Offset: 0x001AC0D0
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

		// Token: 0x0600B3BC RID: 46012 RVA: 0x001ADED9 File Offset: 0x001AC0D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrLevelUpResponse);
		}

		// Token: 0x0600B3BD RID: 46013 RVA: 0x001ADEE7 File Offset: 0x001AC0E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrLevelUpResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B3BE RID: 46014 RVA: 0x001ADF18 File Offset: 0x001AC118
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

		// Token: 0x0600B3BF RID: 46015 RVA: 0x001ADF5D File Offset: 0x001AC15D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B3C0 RID: 46016 RVA: 0x001ADF6A File Offset: 0x001AC16A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B3C1 RID: 46017 RVA: 0x001ADF73 File Offset: 0x001AC173
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B3C2 RID: 46018 RVA: 0x001ADFA8 File Offset: 0x001AC1A8
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

		// Token: 0x0600B3C3 RID: 46019 RVA: 0x001ADFE6 File Offset: 0x001AC1E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrLevelUpResponse other)
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

		// Token: 0x0600B3C4 RID: 46020 RVA: 0x001AE017 File Offset: 0x001AC217
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B3C5 RID: 46021 RVA: 0x001AE020 File Offset: 0x001AC220
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005063 RID: 20579
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005064 RID: 20580
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04005065 RID: 20581
		private ErrorCode errorCode_;
	}
}
