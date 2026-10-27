using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F2C RID: 3884
	[NetMessage(EMessageId.ResonantChainUnlockResponse)]
	public sealed class ResonantChainUnlockResponse : IMessage<ResonantChainUnlockResponse>, IMessage, IEquatable<ResonantChainUnlockResponse>, IDeepCloneable<ResonantChainUnlockResponse>, IBufferMessage
	{
		// Token: 0x06014C7E RID: 85118 RVA: 0x00303BA9 File Offset: 0x00301DA9
		[NullableContext(1)]
		public static ResonantChainUnlockResponse Create()
		{
			return new ResonantChainUnlockResponse();
		}

		// Token: 0x1700450E RID: 17678
		// (get) Token: 0x06014C7F RID: 85119 RVA: 0x00303BB0 File Offset: 0x00301DB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700450F RID: 17679
		// (get) Token: 0x06014C80 RID: 85120 RVA: 0x00303BB3 File Offset: 0x00301DB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ResonantChainUnlockResponse.Descriptor;
			}
		}

		// Token: 0x06014C81 RID: 85121 RVA: 0x00303BBA File Offset: 0x00301DBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResonantChainUnlockResponse()
		{
		}

		// Token: 0x06014C82 RID: 85122 RVA: 0x00303BC2 File Offset: 0x00301DC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResonantChainUnlockResponse(ResonantChainUnlockResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this.roleId_ = other.roleId_;
			this.resonantChainGroupIndex_ = other.resonantChainGroupIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014C83 RID: 85123 RVA: 0x00303BFF File Offset: 0x00301DFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResonantChainUnlockResponse Clone()
		{
			return new ResonantChainUnlockResponse(this);
		}

		// Token: 0x17004510 RID: 17680
		// (get) Token: 0x06014C84 RID: 85124 RVA: 0x00303C07 File Offset: 0x00301E07
		// (set) Token: 0x06014C85 RID: 85125 RVA: 0x00303C0F File Offset: 0x00301E0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x17004511 RID: 17681
		// (get) Token: 0x06014C86 RID: 85126 RVA: 0x00303C18 File Offset: 0x00301E18
		// (set) Token: 0x06014C87 RID: 85127 RVA: 0x00303C20 File Offset: 0x00301E20
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

		// Token: 0x17004512 RID: 17682
		// (get) Token: 0x06014C88 RID: 85128 RVA: 0x00303C29 File Offset: 0x00301E29
		// (set) Token: 0x06014C89 RID: 85129 RVA: 0x00303C31 File Offset: 0x00301E31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ResonantChainGroupIndex
		{
			get
			{
				return this.resonantChainGroupIndex_;
			}
			set
			{
				this.resonantChainGroupIndex_ = value;
			}
		}

		// Token: 0x06014C8A RID: 85130 RVA: 0x00303C3A File Offset: 0x00301E3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ResonantChainUnlockResponse);
		}

		// Token: 0x06014C8B RID: 85131 RVA: 0x00303C48 File Offset: 0x00301E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ResonantChainUnlockResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && this.RoleId == other.RoleId && this.ResonantChainGroupIndex == other.ResonantChainGroupIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014C8C RID: 85132 RVA: 0x00303CA4 File Offset: 0x00301EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.ResonantChainGroupIndex != 0)
			{
				num ^= this.ResonantChainGroupIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014C8D RID: 85133 RVA: 0x00303D1B File Offset: 0x00301F1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014C8E RID: 85134 RVA: 0x00303D28 File Offset: 0x00301F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014C8F RID: 85135 RVA: 0x00303D34 File Offset: 0x00301F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.RoleId);
			}
			if (this.ResonantChainGroupIndex != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ResonantChainGroupIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014C90 RID: 85136 RVA: 0x00303DAC File Offset: 0x00301FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.ResonantChainGroupIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ResonantChainGroupIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014C91 RID: 85137 RVA: 0x00303E1C File Offset: 0x0030201C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ResonantChainUnlockResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.ResonantChainGroupIndex != 0)
			{
				this.ResonantChainGroupIndex = other.ResonantChainGroupIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014C92 RID: 85138 RVA: 0x00303E80 File Offset: 0x00302080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014C93 RID: 85139 RVA: 0x00303E8C File Offset: 0x0030208C
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
				if (num != 24U)
				{
					if (num != 32U)
					{
						if (num != 48U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ResonantChainGroupIndex = input.ReadInt32();
						}
					}
					else
					{
						this.RoleId = input.ReadInt32();
					}
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007D6A RID: 32106
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D6B RID: 32107
		public const int ErrCodeFieldNumber = 3;

		// Token: 0x04007D6C RID: 32108
		private ErrorCode errCode_;

		// Token: 0x04007D6D RID: 32109
		public const int RoleIdFieldNumber = 4;

		// Token: 0x04007D6E RID: 32110
		private int roleId_;

		// Token: 0x04007D6F RID: 32111
		public const int ResonantChainGroupIndexFieldNumber = 6;

		// Token: 0x04007D70 RID: 32112
		private int resonantChainGroupIndex_;
	}
}
