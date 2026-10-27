using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003EB RID: 1003
	[NetMessage(EMessageId.DollGarbInsertCoinResponse)]
	public sealed class DollGarbInsertCoinResponse : IMessage<DollGarbInsertCoinResponse>, IMessage, IEquatable<DollGarbInsertCoinResponse>, IDeepCloneable<DollGarbInsertCoinResponse>, IBufferMessage
	{
		// Token: 0x0600614D RID: 24909 RVA: 0x000EAE35 File Offset: 0x000E9035
		[NullableContext(1)]
		public static DollGarbInsertCoinResponse Create()
		{
			return new DollGarbInsertCoinResponse();
		}

		// Token: 0x17001222 RID: 4642
		// (get) Token: 0x0600614E RID: 24910 RVA: 0x000EAE3C File Offset: 0x000E903C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001223 RID: 4643
		// (get) Token: 0x0600614F RID: 24911 RVA: 0x000EAE3F File Offset: 0x000E903F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DollGarbInsertCoinResponse.Descriptor;
			}
		}

		// Token: 0x06006150 RID: 24912 RVA: 0x000EAE46 File Offset: 0x000E9046
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGarbInsertCoinResponse()
		{
		}

		// Token: 0x06006151 RID: 24913 RVA: 0x000EAE4E File Offset: 0x000E904E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGarbInsertCoinResponse(DollGarbInsertCoinResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006152 RID: 24914 RVA: 0x000EAE73 File Offset: 0x000E9073
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGarbInsertCoinResponse Clone()
		{
			return new DollGarbInsertCoinResponse(this);
		}

		// Token: 0x17001224 RID: 4644
		// (get) Token: 0x06006153 RID: 24915 RVA: 0x000EAE7B File Offset: 0x000E907B
		// (set) Token: 0x06006154 RID: 24916 RVA: 0x000EAE83 File Offset: 0x000E9083
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

		// Token: 0x06006155 RID: 24917 RVA: 0x000EAE8C File Offset: 0x000E908C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DollGarbInsertCoinResponse);
		}

		// Token: 0x06006156 RID: 24918 RVA: 0x000EAE9A File Offset: 0x000E909A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DollGarbInsertCoinResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006157 RID: 24919 RVA: 0x000EAEC8 File Offset: 0x000E90C8
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

		// Token: 0x06006158 RID: 24920 RVA: 0x000EAF0D File Offset: 0x000E910D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006159 RID: 24921 RVA: 0x000EAF1A File Offset: 0x000E911A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600615A RID: 24922 RVA: 0x000EAF23 File Offset: 0x000E9123
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

		// Token: 0x0600615B RID: 24923 RVA: 0x000EAF58 File Offset: 0x000E9158
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

		// Token: 0x0600615C RID: 24924 RVA: 0x000EAF96 File Offset: 0x000E9196
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DollGarbInsertCoinResponse other)
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

		// Token: 0x0600615D RID: 24925 RVA: 0x000EAFC7 File Offset: 0x000E91C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600615E RID: 24926 RVA: 0x000EAFD0 File Offset: 0x000E91D0
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

		// Token: 0x04003797 RID: 14231
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003798 RID: 14232
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04003799 RID: 14233
		private ErrorCode errorCode_;
	}
}
