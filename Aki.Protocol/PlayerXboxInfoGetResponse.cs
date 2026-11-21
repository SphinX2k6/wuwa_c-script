using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DB0 RID: 3504
	[NetMessage(EMessageId.PlayerXboxInfoGetResponse)]
	public sealed class PlayerXboxInfoGetResponse : IMessage<PlayerXboxInfoGetResponse>, IMessage, IEquatable<PlayerXboxInfoGetResponse>, IDeepCloneable<PlayerXboxInfoGetResponse>, IBufferMessage
	{
		// Token: 0x06012E57 RID: 77399 RVA: 0x002C1E89 File Offset: 0x002C0089
		[NullableContext(1)]
		public static PlayerXboxInfoGetResponse Create()
		{
			return new PlayerXboxInfoGetResponse();
		}

		// Token: 0x17003EB6 RID: 16054
		// (get) Token: 0x06012E58 RID: 77400 RVA: 0x002C1E90 File Offset: 0x002C0090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003EB7 RID: 16055
		// (get) Token: 0x06012E59 RID: 77401 RVA: 0x002C1E93 File Offset: 0x002C0093
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerXboxInfoGetResponse.Descriptor;
			}
		}

		// Token: 0x06012E5A RID: 77402 RVA: 0x002C1E9A File Offset: 0x002C009A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerXboxInfoGetResponse()
		{
		}

		// Token: 0x06012E5B RID: 77403 RVA: 0x002C1EA4 File Offset: 0x002C00A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerXboxInfoGetResponse(PlayerXboxInfoGetResponse other) : this()
		{
			this.info_ = ((other.info_ != null) ? other.info_.Clone() : null);
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012E5C RID: 77404 RVA: 0x002C1EF0 File Offset: 0x002C00F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerXboxInfoGetResponse Clone()
		{
			return new PlayerXboxInfoGetResponse(this);
		}

		// Token: 0x17003EB8 RID: 16056
		// (get) Token: 0x06012E5D RID: 77405 RVA: 0x002C1EF8 File Offset: 0x002C00F8
		// (set) Token: 0x06012E5E RID: 77406 RVA: 0x002C1F00 File Offset: 0x002C0100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerDetails Info
		{
			get
			{
				return this.info_;
			}
			set
			{
				this.info_ = value;
			}
		}

		// Token: 0x17003EB9 RID: 16057
		// (get) Token: 0x06012E5F RID: 77407 RVA: 0x002C1F09 File Offset: 0x002C0109
		// (set) Token: 0x06012E60 RID: 77408 RVA: 0x002C1F11 File Offset: 0x002C0111
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

		// Token: 0x06012E61 RID: 77409 RVA: 0x002C1F1A File Offset: 0x002C011A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerXboxInfoGetResponse);
		}

		// Token: 0x06012E62 RID: 77410 RVA: 0x002C1F28 File Offset: 0x002C0128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerXboxInfoGetResponse other)
		{
			return other != null && (other == this || (object.Equals(this.Info, other.Info) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012E63 RID: 77411 RVA: 0x002C1F78 File Offset: 0x002C0178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.info_ != null)
			{
				num ^= this.Info.GetHashCode();
			}
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

		// Token: 0x06012E64 RID: 77412 RVA: 0x002C1FD3 File Offset: 0x002C01D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012E65 RID: 77413 RVA: 0x002C1FE0 File Offset: 0x002C01E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012E66 RID: 77414 RVA: 0x002C1FEC File Offset: 0x002C01EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.info_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.Info);
			}
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

		// Token: 0x06012E67 RID: 77415 RVA: 0x002C2048 File Offset: 0x002C0248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.info_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Info);
			}
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

		// Token: 0x06012E68 RID: 77416 RVA: 0x002C20A0 File Offset: 0x002C02A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerXboxInfoGetResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.info_ != null)
			{
				if (this.info_ == null)
				{
					this.Info = new PlayerDetails();
				}
				this.Info.MergeFrom(other.Info);
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012E69 RID: 77417 RVA: 0x002C2108 File Offset: 0x002C0308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012E6A RID: 77418 RVA: 0x002C2114 File Offset: 0x002C0314
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
				if (num != 82U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					if (this.info_ == null)
					{
						this.Info = new PlayerDetails();
					}
					input.ReadMessage(this.Info);
				}
			}
		}

		// Token: 0x0400754D RID: 30029
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400754E RID: 30030
		public const int InfoFieldNumber = 10;

		// Token: 0x0400754F RID: 30031
		private PlayerDetails info_;

		// Token: 0x04007550 RID: 30032
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04007551 RID: 30033
		private ErrorCode errorCode_;
	}
}
