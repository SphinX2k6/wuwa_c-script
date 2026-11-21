using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AE9 RID: 2793
	[NetMessage(EMessageId.NewbieAdventureRoleRewardResponse)]
	public sealed class NewbieAdventureRoleRewardResponse : IMessage<NewbieAdventureRoleRewardResponse>, IMessage, IEquatable<NewbieAdventureRoleRewardResponse>, IDeepCloneable<NewbieAdventureRoleRewardResponse>, IBufferMessage
	{
		// Token: 0x0600F335 RID: 62261 RVA: 0x00238923 File Offset: 0x00236B23
		[NullableContext(1)]
		public static NewbieAdventureRoleRewardResponse Create()
		{
			return new NewbieAdventureRoleRewardResponse();
		}

		// Token: 0x17003186 RID: 12678
		// (get) Token: 0x0600F336 RID: 62262 RVA: 0x0023892A File Offset: 0x00236B2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003187 RID: 12679
		// (get) Token: 0x0600F337 RID: 62263 RVA: 0x0023892D File Offset: 0x00236B2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewbieAdventureRoleRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600F338 RID: 62264 RVA: 0x00238934 File Offset: 0x00236B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieAdventureRoleRewardResponse()
		{
		}

		// Token: 0x0600F339 RID: 62265 RVA: 0x0023893C File Offset: 0x00236B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieAdventureRoleRewardResponse(NewbieAdventureRoleRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F33A RID: 62266 RVA: 0x00238961 File Offset: 0x00236B61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieAdventureRoleRewardResponse Clone()
		{
			return new NewbieAdventureRoleRewardResponse(this);
		}

		// Token: 0x17003188 RID: 12680
		// (get) Token: 0x0600F33B RID: 62267 RVA: 0x00238969 File Offset: 0x00236B69
		// (set) Token: 0x0600F33C RID: 62268 RVA: 0x00238971 File Offset: 0x00236B71
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

		// Token: 0x0600F33D RID: 62269 RVA: 0x0023897A File Offset: 0x00236B7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewbieAdventureRoleRewardResponse);
		}

		// Token: 0x0600F33E RID: 62270 RVA: 0x00238988 File Offset: 0x00236B88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewbieAdventureRoleRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F33F RID: 62271 RVA: 0x002389B8 File Offset: 0x00236BB8
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

		// Token: 0x0600F340 RID: 62272 RVA: 0x002389FD File Offset: 0x00236BFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F341 RID: 62273 RVA: 0x00238A0A File Offset: 0x00236C0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F342 RID: 62274 RVA: 0x00238A13 File Offset: 0x00236C13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F343 RID: 62275 RVA: 0x00238A48 File Offset: 0x00236C48
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

		// Token: 0x0600F344 RID: 62276 RVA: 0x00238A86 File Offset: 0x00236C86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewbieAdventureRoleRewardResponse other)
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

		// Token: 0x0600F345 RID: 62277 RVA: 0x00238AB7 File Offset: 0x00236CB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F346 RID: 62278 RVA: 0x00238AC0 File Offset: 0x00236CC0
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400626D RID: 25197
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400626E RID: 25198
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x0400626F RID: 25199
		private ErrorCode errorCode_;
	}
}
