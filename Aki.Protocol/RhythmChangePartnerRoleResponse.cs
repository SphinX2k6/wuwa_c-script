using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F39 RID: 3897
	[NetMessage(EMessageId.RhythmChangePartnerRoleResponse)]
	public sealed class RhythmChangePartnerRoleResponse : IMessage<RhythmChangePartnerRoleResponse>, IMessage, IEquatable<RhythmChangePartnerRoleResponse>, IDeepCloneable<RhythmChangePartnerRoleResponse>, IBufferMessage
	{
		// Token: 0x06014DA8 RID: 85416 RVA: 0x003068F9 File Offset: 0x00304AF9
		[NullableContext(1)]
		public static RhythmChangePartnerRoleResponse Create()
		{
			return new RhythmChangePartnerRoleResponse();
		}

		// Token: 0x17004557 RID: 17751
		// (get) Token: 0x06014DA9 RID: 85417 RVA: 0x00306900 File Offset: 0x00304B00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004558 RID: 17752
		// (get) Token: 0x06014DAA RID: 85418 RVA: 0x00306903 File Offset: 0x00304B03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmChangePartnerRoleResponse.Descriptor;
			}
		}

		// Token: 0x06014DAB RID: 85419 RVA: 0x0030690A File Offset: 0x00304B0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmChangePartnerRoleResponse()
		{
		}

		// Token: 0x06014DAC RID: 85420 RVA: 0x00306912 File Offset: 0x00304B12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmChangePartnerRoleResponse(RhythmChangePartnerRoleResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014DAD RID: 85421 RVA: 0x00306937 File Offset: 0x00304B37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmChangePartnerRoleResponse Clone()
		{
			return new RhythmChangePartnerRoleResponse(this);
		}

		// Token: 0x17004559 RID: 17753
		// (get) Token: 0x06014DAE RID: 85422 RVA: 0x0030693F File Offset: 0x00304B3F
		// (set) Token: 0x06014DAF RID: 85423 RVA: 0x00306947 File Offset: 0x00304B47
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

		// Token: 0x06014DB0 RID: 85424 RVA: 0x00306950 File Offset: 0x00304B50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmChangePartnerRoleResponse);
		}

		// Token: 0x06014DB1 RID: 85425 RVA: 0x0030695E File Offset: 0x00304B5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmChangePartnerRoleResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014DB2 RID: 85426 RVA: 0x0030698C File Offset: 0x00304B8C
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

		// Token: 0x06014DB3 RID: 85427 RVA: 0x003069D1 File Offset: 0x00304BD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014DB4 RID: 85428 RVA: 0x003069DE File Offset: 0x00304BDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014DB5 RID: 85429 RVA: 0x003069E7 File Offset: 0x00304BE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014DB6 RID: 85430 RVA: 0x00306A1C File Offset: 0x00304C1C
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

		// Token: 0x06014DB7 RID: 85431 RVA: 0x00306A5A File Offset: 0x00304C5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RhythmChangePartnerRoleResponse other)
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

		// Token: 0x06014DB8 RID: 85432 RVA: 0x00306A8B File Offset: 0x00304C8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014DB9 RID: 85433 RVA: 0x00306A94 File Offset: 0x00304C94
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007DD6 RID: 32214
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007DD7 RID: 32215
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04007DD8 RID: 32216
		private ErrorCode errorCode_;
	}
}
