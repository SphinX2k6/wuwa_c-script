using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F1C RID: 3868
	[NetMessage(EMessageId.ResonantChainUnlockResponse)]
	public sealed class ResonantChainUnlockResponse : IMessage<ResonantChainUnlockResponse>, IMessage, IEquatable<ResonantChainUnlockResponse>, IDeepCloneable<ResonantChainUnlockResponse>, IBufferMessage
	{
		// Token: 0x06014B99 RID: 84889 RVA: 0x003024EC File Offset: 0x003006EC
		[NullableContext(1)]
		public static ResonantChainUnlockResponse Create()
		{
			return new ResonantChainUnlockResponse();
		}

		// Token: 0x170044E4 RID: 17636
		// (get) Token: 0x06014B9A RID: 84890 RVA: 0x003024F3 File Offset: 0x003006F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170044E5 RID: 17637
		// (get) Token: 0x06014B9B RID: 84891 RVA: 0x003024F6 File Offset: 0x003006F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ResonantChainUnlockResponse.Descriptor;
			}
		}

		// Token: 0x06014B9C RID: 84892 RVA: 0x003024FD File Offset: 0x003006FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResonantChainUnlockResponse()
		{
		}

		// Token: 0x06014B9D RID: 84893 RVA: 0x00302505 File Offset: 0x00300705
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResonantChainUnlockResponse(ResonantChainUnlockResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this.roleId_ = other.roleId_;
			this.resonantChainGroupIndex_ = other.resonantChainGroupIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014B9E RID: 84894 RVA: 0x00302542 File Offset: 0x00300742
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResonantChainUnlockResponse Clone()
		{
			return new ResonantChainUnlockResponse(this);
		}

		// Token: 0x170044E6 RID: 17638
		// (get) Token: 0x06014B9F RID: 84895 RVA: 0x0030254A File Offset: 0x0030074A
		// (set) Token: 0x06014BA0 RID: 84896 RVA: 0x00302552 File Offset: 0x00300752
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

		// Token: 0x170044E7 RID: 17639
		// (get) Token: 0x06014BA1 RID: 84897 RVA: 0x0030255B File Offset: 0x0030075B
		// (set) Token: 0x06014BA2 RID: 84898 RVA: 0x00302563 File Offset: 0x00300763
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

		// Token: 0x170044E8 RID: 17640
		// (get) Token: 0x06014BA3 RID: 84899 RVA: 0x0030256C File Offset: 0x0030076C
		// (set) Token: 0x06014BA4 RID: 84900 RVA: 0x00302574 File Offset: 0x00300774
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

		// Token: 0x06014BA5 RID: 84901 RVA: 0x0030257D File Offset: 0x0030077D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ResonantChainUnlockResponse);
		}

		// Token: 0x06014BA6 RID: 84902 RVA: 0x0030258C File Offset: 0x0030078C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ResonantChainUnlockResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && this.RoleId == other.RoleId && this.ResonantChainGroupIndex == other.ResonantChainGroupIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014BA7 RID: 84903 RVA: 0x003025E8 File Offset: 0x003007E8
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

		// Token: 0x06014BA8 RID: 84904 RVA: 0x0030265F File Offset: 0x0030085F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014BA9 RID: 84905 RVA: 0x0030266C File Offset: 0x0030086C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014BAA RID: 84906 RVA: 0x00302678 File Offset: 0x00300878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.RoleId);
			}
			if (this.ResonantChainGroupIndex != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ResonantChainGroupIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014BAB RID: 84907 RVA: 0x003026F0 File Offset: 0x003008F0
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

		// Token: 0x06014BAC RID: 84908 RVA: 0x00302760 File Offset: 0x00300960
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

		// Token: 0x06014BAD RID: 84909 RVA: 0x003027C4 File Offset: 0x003009C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014BAE RID: 84910 RVA: 0x003027D0 File Offset: 0x003009D0
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
					if (num != 80U)
					{
						if (num != 88U)
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

		// Token: 0x04007D94 RID: 32148
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D95 RID: 32149
		public const int ErrCodeFieldNumber = 7;

		// Token: 0x04007D96 RID: 32150
		private ErrorCode errCode_;

		// Token: 0x04007D97 RID: 32151
		public const int RoleIdFieldNumber = 10;

		// Token: 0x04007D98 RID: 32152
		private int roleId_;

		// Token: 0x04007D99 RID: 32153
		public const int ResonantChainGroupIndexFieldNumber = 11;

		// Token: 0x04007D9A RID: 32154
		private int resonantChainGroupIndex_;
	}
}
