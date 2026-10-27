using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009E4 RID: 2532
	[NetMessage(EMessageId.MobileButtonSettingUpdateResponse)]
	public sealed class MobileButtonSettingUpdateResponse : IMessage<MobileButtonSettingUpdateResponse>, IMessage, IEquatable<MobileButtonSettingUpdateResponse>, IDeepCloneable<MobileButtonSettingUpdateResponse>, IBufferMessage
	{
		// Token: 0x0600DDDF RID: 56799 RVA: 0x00208B75 File Offset: 0x00206D75
		[NullableContext(1)]
		public static MobileButtonSettingUpdateResponse Create()
		{
			return new MobileButtonSettingUpdateResponse();
		}

		// Token: 0x17002CF9 RID: 11513
		// (get) Token: 0x0600DDE0 RID: 56800 RVA: 0x00208B7C File Offset: 0x00206D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002CFA RID: 11514
		// (get) Token: 0x0600DDE1 RID: 56801 RVA: 0x00208B7F File Offset: 0x00206D7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MobileButtonSettingUpdateResponse.Descriptor;
			}
		}

		// Token: 0x0600DDE2 RID: 56802 RVA: 0x00208B86 File Offset: 0x00206D86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MobileButtonSettingUpdateResponse()
		{
		}

		// Token: 0x0600DDE3 RID: 56803 RVA: 0x00208B8E File Offset: 0x00206D8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MobileButtonSettingUpdateResponse(MobileButtonSettingUpdateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DDE4 RID: 56804 RVA: 0x00208BB3 File Offset: 0x00206DB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MobileButtonSettingUpdateResponse Clone()
		{
			return new MobileButtonSettingUpdateResponse(this);
		}

		// Token: 0x17002CFB RID: 11515
		// (get) Token: 0x0600DDE5 RID: 56805 RVA: 0x00208BBB File Offset: 0x00206DBB
		// (set) Token: 0x0600DDE6 RID: 56806 RVA: 0x00208BC3 File Offset: 0x00206DC3
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

		// Token: 0x0600DDE7 RID: 56807 RVA: 0x00208BCC File Offset: 0x00206DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MobileButtonSettingUpdateResponse);
		}

		// Token: 0x0600DDE8 RID: 56808 RVA: 0x00208BDA File Offset: 0x00206DDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MobileButtonSettingUpdateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DDE9 RID: 56809 RVA: 0x00208C08 File Offset: 0x00206E08
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

		// Token: 0x0600DDEA RID: 56810 RVA: 0x00208C4D File Offset: 0x00206E4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DDEB RID: 56811 RVA: 0x00208C5A File Offset: 0x00206E5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DDEC RID: 56812 RVA: 0x00208C63 File Offset: 0x00206E63
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

		// Token: 0x0600DDED RID: 56813 RVA: 0x00208C98 File Offset: 0x00206E98
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

		// Token: 0x0600DDEE RID: 56814 RVA: 0x00208CD6 File Offset: 0x00206ED6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MobileButtonSettingUpdateResponse other)
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

		// Token: 0x0600DDEF RID: 56815 RVA: 0x00208D07 File Offset: 0x00206F07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DDF0 RID: 56816 RVA: 0x00208D10 File Offset: 0x00206F10
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

		// Token: 0x04005BB2 RID: 23474
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005BB3 RID: 23475
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04005BB4 RID: 23476
		private ErrorCode errorCode_;
	}
}
