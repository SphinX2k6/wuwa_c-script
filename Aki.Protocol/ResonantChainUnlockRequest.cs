using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F2B RID: 3883
	[NetMessage(EMessageId.ResonantChainUnlockRequest)]
	public sealed class ResonantChainUnlockRequest : IMessage<ResonantChainUnlockRequest>, IMessage, IEquatable<ResonantChainUnlockRequest>, IDeepCloneable<ResonantChainUnlockRequest>, IBufferMessage
	{
		// Token: 0x06014C6C RID: 85100 RVA: 0x003039D0 File Offset: 0x00301BD0
		[NullableContext(1)]
		public static ResonantChainUnlockRequest Create()
		{
			return new ResonantChainUnlockRequest();
		}

		// Token: 0x1700450B RID: 17675
		// (get) Token: 0x06014C6D RID: 85101 RVA: 0x003039D7 File Offset: 0x00301BD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700450C RID: 17676
		// (get) Token: 0x06014C6E RID: 85102 RVA: 0x003039DA File Offset: 0x00301BDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ResonantChainUnlockRequest.Descriptor;
			}
		}

		// Token: 0x06014C6F RID: 85103 RVA: 0x003039E1 File Offset: 0x00301BE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResonantChainUnlockRequest()
		{
		}

		// Token: 0x06014C70 RID: 85104 RVA: 0x003039E9 File Offset: 0x00301BE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResonantChainUnlockRequest(ResonantChainUnlockRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014C71 RID: 85105 RVA: 0x00303A0E File Offset: 0x00301C0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResonantChainUnlockRequest Clone()
		{
			return new ResonantChainUnlockRequest(this);
		}

		// Token: 0x1700450D RID: 17677
		// (get) Token: 0x06014C72 RID: 85106 RVA: 0x00303A16 File Offset: 0x00301C16
		// (set) Token: 0x06014C73 RID: 85107 RVA: 0x00303A1E File Offset: 0x00301C1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x06014C74 RID: 85108 RVA: 0x00303A27 File Offset: 0x00301C27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ResonantChainUnlockRequest);
		}

		// Token: 0x06014C75 RID: 85109 RVA: 0x00303A35 File Offset: 0x00301C35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ResonantChainUnlockRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014C76 RID: 85110 RVA: 0x00303A64 File Offset: 0x00301C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014C77 RID: 85111 RVA: 0x00303AA3 File Offset: 0x00301CA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014C78 RID: 85112 RVA: 0x00303AB0 File Offset: 0x00301CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014C79 RID: 85113 RVA: 0x00303AB9 File Offset: 0x00301CB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014C7A RID: 85114 RVA: 0x00303AEC File Offset: 0x00301CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014C7B RID: 85115 RVA: 0x00303B2A File Offset: 0x00301D2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ResonantChainUnlockRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014C7C RID: 85116 RVA: 0x00303B5B File Offset: 0x00301D5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014C7D RID: 85117 RVA: 0x00303B64 File Offset: 0x00301D64
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007D67 RID: 32103
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D68 RID: 32104
		public const int RoleIdFieldNumber = 9;

		// Token: 0x04007D69 RID: 32105
		private int roleId_;
	}
}
