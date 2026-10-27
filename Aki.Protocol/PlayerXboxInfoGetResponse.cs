using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DC0 RID: 3520
	[NetMessage(EMessageId.PlayerXboxInfoGetResponse)]
	public sealed class PlayerXboxInfoGetResponse : IMessage<PlayerXboxInfoGetResponse>, IMessage, IEquatable<PlayerXboxInfoGetResponse>, IDeepCloneable<PlayerXboxInfoGetResponse>, IBufferMessage
	{
		// Token: 0x06012F53 RID: 77651 RVA: 0x002C3AAD File Offset: 0x002C1CAD
		[NullableContext(1)]
		public static PlayerXboxInfoGetResponse Create()
		{
			return new PlayerXboxInfoGetResponse();
		}

		// Token: 0x17003EEB RID: 16107
		// (get) Token: 0x06012F54 RID: 77652 RVA: 0x002C3AB4 File Offset: 0x002C1CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003EEC RID: 16108
		// (get) Token: 0x06012F55 RID: 77653 RVA: 0x002C3AB7 File Offset: 0x002C1CB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerXboxInfoGetResponse.Descriptor;
			}
		}

		// Token: 0x06012F56 RID: 77654 RVA: 0x002C3ABE File Offset: 0x002C1CBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerXboxInfoGetResponse()
		{
		}

		// Token: 0x06012F57 RID: 77655 RVA: 0x002C3AC8 File Offset: 0x002C1CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerXboxInfoGetResponse(PlayerXboxInfoGetResponse other) : this()
		{
			this.info_ = ((other.info_ != null) ? other.info_.Clone() : null);
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012F58 RID: 77656 RVA: 0x002C3B14 File Offset: 0x002C1D14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerXboxInfoGetResponse Clone()
		{
			return new PlayerXboxInfoGetResponse(this);
		}

		// Token: 0x17003EED RID: 16109
		// (get) Token: 0x06012F59 RID: 77657 RVA: 0x002C3B1C File Offset: 0x002C1D1C
		// (set) Token: 0x06012F5A RID: 77658 RVA: 0x002C3B24 File Offset: 0x002C1D24
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

		// Token: 0x17003EEE RID: 16110
		// (get) Token: 0x06012F5B RID: 77659 RVA: 0x002C3B2D File Offset: 0x002C1D2D
		// (set) Token: 0x06012F5C RID: 77660 RVA: 0x002C3B35 File Offset: 0x002C1D35
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

		// Token: 0x06012F5D RID: 77661 RVA: 0x002C3B3E File Offset: 0x002C1D3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerXboxInfoGetResponse);
		}

		// Token: 0x06012F5E RID: 77662 RVA: 0x002C3B4C File Offset: 0x002C1D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerXboxInfoGetResponse other)
		{
			return other != null && (other == this || (object.Equals(this.Info, other.Info) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012F5F RID: 77663 RVA: 0x002C3B9C File Offset: 0x002C1D9C
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

		// Token: 0x06012F60 RID: 77664 RVA: 0x002C3BF7 File Offset: 0x002C1DF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012F61 RID: 77665 RVA: 0x002C3C04 File Offset: 0x002C1E04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012F62 RID: 77666 RVA: 0x002C3C10 File Offset: 0x002C1E10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.info_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.Info);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012F63 RID: 77667 RVA: 0x002C3C6C File Offset: 0x002C1E6C
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

		// Token: 0x06012F64 RID: 77668 RVA: 0x002C3CC4 File Offset: 0x002C1EC4
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

		// Token: 0x06012F65 RID: 77669 RVA: 0x002C3D2C File Offset: 0x002C1F2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012F66 RID: 77670 RVA: 0x002C3D38 File Offset: 0x002C1F38
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
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007535 RID: 30005
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007536 RID: 30006
		public const int InfoFieldNumber = 11;

		// Token: 0x04007537 RID: 30007
		private PlayerDetails info_;

		// Token: 0x04007538 RID: 30008
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04007539 RID: 30009
		private ErrorCode errorCode_;
	}
}
