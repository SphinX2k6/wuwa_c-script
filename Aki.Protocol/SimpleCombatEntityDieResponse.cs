using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001226 RID: 4646
	[NetMessage(EMessageId.SimpleCombatEntityDieResponse)]
	public sealed class SimpleCombatEntityDieResponse : IMessage<SimpleCombatEntityDieResponse>, IMessage, IEquatable<SimpleCombatEntityDieResponse>, IDeepCloneable<SimpleCombatEntityDieResponse>, IBufferMessage
	{
		// Token: 0x06018C31 RID: 101425 RVA: 0x0039A8AC File Offset: 0x00398AAC
		[NullableContext(1)]
		public static SimpleCombatEntityDieResponse Create()
		{
			return new SimpleCombatEntityDieResponse();
		}

		// Token: 0x17005377 RID: 21367
		// (get) Token: 0x06018C32 RID: 101426 RVA: 0x0039A8B3 File Offset: 0x00398AB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005378 RID: 21368
		// (get) Token: 0x06018C33 RID: 101427 RVA: 0x0039A8B6 File Offset: 0x00398AB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SimpleCombatEntityDieResponse.Descriptor;
			}
		}

		// Token: 0x06018C34 RID: 101428 RVA: 0x0039A8BD File Offset: 0x00398ABD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntityDieResponse()
		{
		}

		// Token: 0x06018C35 RID: 101429 RVA: 0x0039A8C5 File Offset: 0x00398AC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntityDieResponse(SimpleCombatEntityDieResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018C36 RID: 101430 RVA: 0x0039A8EA File Offset: 0x00398AEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntityDieResponse Clone()
		{
			return new SimpleCombatEntityDieResponse(this);
		}

		// Token: 0x17005379 RID: 21369
		// (get) Token: 0x06018C37 RID: 101431 RVA: 0x0039A8F2 File Offset: 0x00398AF2
		// (set) Token: 0x06018C38 RID: 101432 RVA: 0x0039A8FA File Offset: 0x00398AFA
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

		// Token: 0x06018C39 RID: 101433 RVA: 0x0039A903 File Offset: 0x00398B03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SimpleCombatEntityDieResponse);
		}

		// Token: 0x06018C3A RID: 101434 RVA: 0x0039A911 File Offset: 0x00398B11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SimpleCombatEntityDieResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018C3B RID: 101435 RVA: 0x0039A940 File Offset: 0x00398B40
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

		// Token: 0x06018C3C RID: 101436 RVA: 0x0039A985 File Offset: 0x00398B85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018C3D RID: 101437 RVA: 0x0039A992 File Offset: 0x00398B92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018C3E RID: 101438 RVA: 0x0039A99B File Offset: 0x00398B9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018C3F RID: 101439 RVA: 0x0039A9D0 File Offset: 0x00398BD0
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

		// Token: 0x06018C40 RID: 101440 RVA: 0x0039AA0E File Offset: 0x00398C0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SimpleCombatEntityDieResponse other)
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

		// Token: 0x06018C41 RID: 101441 RVA: 0x0039AA3F File Offset: 0x00398C3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018C42 RID: 101442 RVA: 0x0039AA48 File Offset: 0x00398C48
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009225 RID: 37413
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009226 RID: 37414
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04009227 RID: 37415
		private ErrorCode errorCode_;
	}
}
