using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D6A RID: 3434
	[NetMessage(EMessageId.PlayerAccessCasketResponse)]
	public sealed class PlayerAccessCasketResponse : IMessage<PlayerAccessCasketResponse>, IMessage, IEquatable<PlayerAccessCasketResponse>, IDeepCloneable<PlayerAccessCasketResponse>, IBufferMessage
	{
		// Token: 0x06012894 RID: 75924 RVA: 0x002B4BC5 File Offset: 0x002B2DC5
		[NullableContext(1)]
		public static PlayerAccessCasketResponse Create()
		{
			return new PlayerAccessCasketResponse();
		}

		// Token: 0x17003D72 RID: 15730
		// (get) Token: 0x06012895 RID: 75925 RVA: 0x002B4BCC File Offset: 0x002B2DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D73 RID: 15731
		// (get) Token: 0x06012896 RID: 75926 RVA: 0x002B4BCF File Offset: 0x002B2DCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerAccessCasketResponse.Descriptor;
			}
		}

		// Token: 0x06012897 RID: 75927 RVA: 0x002B4BD6 File Offset: 0x002B2DD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerAccessCasketResponse()
		{
		}

		// Token: 0x06012898 RID: 75928 RVA: 0x002B4BDE File Offset: 0x002B2DDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerAccessCasketResponse(PlayerAccessCasketResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.casketEntityIncId_ = other.casketEntityIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012899 RID: 75929 RVA: 0x002B4C0F File Offset: 0x002B2E0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerAccessCasketResponse Clone()
		{
			return new PlayerAccessCasketResponse(this);
		}

		// Token: 0x17003D74 RID: 15732
		// (get) Token: 0x0601289A RID: 75930 RVA: 0x002B4C17 File Offset: 0x002B2E17
		// (set) Token: 0x0601289B RID: 75931 RVA: 0x002B4C1F File Offset: 0x002B2E1F
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

		// Token: 0x17003D75 RID: 15733
		// (get) Token: 0x0601289C RID: 75932 RVA: 0x002B4C28 File Offset: 0x002B2E28
		// (set) Token: 0x0601289D RID: 75933 RVA: 0x002B4C30 File Offset: 0x002B2E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CasketEntityIncId
		{
			get
			{
				return this.casketEntityIncId_;
			}
			set
			{
				this.casketEntityIncId_ = value;
			}
		}

		// Token: 0x0601289E RID: 75934 RVA: 0x002B4C39 File Offset: 0x002B2E39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerAccessCasketResponse);
		}

		// Token: 0x0601289F RID: 75935 RVA: 0x002B4C47 File Offset: 0x002B2E47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerAccessCasketResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.CasketEntityIncId == other.CasketEntityIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060128A0 RID: 75936 RVA: 0x002B4C88 File Offset: 0x002B2E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.CasketEntityIncId != 0L)
			{
				num ^= this.CasketEntityIncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060128A1 RID: 75937 RVA: 0x002B4CE6 File Offset: 0x002B2EE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060128A2 RID: 75938 RVA: 0x002B4CF3 File Offset: 0x002B2EF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060128A3 RID: 75939 RVA: 0x002B4CFC File Offset: 0x002B2EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.CasketEntityIncId != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.CasketEntityIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060128A4 RID: 75940 RVA: 0x002B4D54 File Offset: 0x002B2F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.CasketEntityIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CasketEntityIncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060128A5 RID: 75941 RVA: 0x002B4DAC File Offset: 0x002B2FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerAccessCasketResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.CasketEntityIncId != 0L)
			{
				this.CasketEntityIncId = other.CasketEntityIncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060128A6 RID: 75942 RVA: 0x002B4DFC File Offset: 0x002B2FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060128A7 RID: 75943 RVA: 0x002B4E08 File Offset: 0x002B3008
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
				if (num != 8U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.CasketEntityIncId = input.ReadInt64();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007389 RID: 29577
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400738A RID: 29578
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x0400738B RID: 29579
		private ErrorCode errorCode_;

		// Token: 0x0400738C RID: 29580
		public const int CasketEntityIncIdFieldNumber = 11;

		// Token: 0x0400738D RID: 29581
		private long casketEntityIncId_;
	}
}
