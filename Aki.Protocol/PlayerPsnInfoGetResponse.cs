using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D93 RID: 3475
	[NetMessage(EMessageId.PlayerPsnInfoGetResponse)]
	public sealed class PlayerPsnInfoGetResponse : IMessage<PlayerPsnInfoGetResponse>, IMessage, IEquatable<PlayerPsnInfoGetResponse>, IDeepCloneable<PlayerPsnInfoGetResponse>, IBufferMessage
	{
		// Token: 0x06012BFC RID: 76796 RVA: 0x002BC8C5 File Offset: 0x002BAAC5
		[NullableContext(1)]
		public static PlayerPsnInfoGetResponse Create()
		{
			return new PlayerPsnInfoGetResponse();
		}

		// Token: 0x17003E32 RID: 15922
		// (get) Token: 0x06012BFD RID: 76797 RVA: 0x002BC8CC File Offset: 0x002BAACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E33 RID: 15923
		// (get) Token: 0x06012BFE RID: 76798 RVA: 0x002BC8CF File Offset: 0x002BAACF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerPsnInfoGetResponse.Descriptor;
			}
		}

		// Token: 0x06012BFF RID: 76799 RVA: 0x002BC8D6 File Offset: 0x002BAAD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerPsnInfoGetResponse()
		{
		}

		// Token: 0x06012C00 RID: 76800 RVA: 0x002BC8E0 File Offset: 0x002BAAE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerPsnInfoGetResponse(PlayerPsnInfoGetResponse other) : this()
		{
			this.info_ = ((other.info_ != null) ? other.info_.Clone() : null);
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012C01 RID: 76801 RVA: 0x002BC92C File Offset: 0x002BAB2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerPsnInfoGetResponse Clone()
		{
			return new PlayerPsnInfoGetResponse(this);
		}

		// Token: 0x17003E34 RID: 15924
		// (get) Token: 0x06012C02 RID: 76802 RVA: 0x002BC934 File Offset: 0x002BAB34
		// (set) Token: 0x06012C03 RID: 76803 RVA: 0x002BC93C File Offset: 0x002BAB3C
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

		// Token: 0x17003E35 RID: 15925
		// (get) Token: 0x06012C04 RID: 76804 RVA: 0x002BC945 File Offset: 0x002BAB45
		// (set) Token: 0x06012C05 RID: 76805 RVA: 0x002BC94D File Offset: 0x002BAB4D
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

		// Token: 0x06012C06 RID: 76806 RVA: 0x002BC956 File Offset: 0x002BAB56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerPsnInfoGetResponse);
		}

		// Token: 0x06012C07 RID: 76807 RVA: 0x002BC964 File Offset: 0x002BAB64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerPsnInfoGetResponse other)
		{
			return other != null && (other == this || (object.Equals(this.Info, other.Info) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012C08 RID: 76808 RVA: 0x002BC9B4 File Offset: 0x002BABB4
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

		// Token: 0x06012C09 RID: 76809 RVA: 0x002BCA0F File Offset: 0x002BAC0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012C0A RID: 76810 RVA: 0x002BCA1C File Offset: 0x002BAC1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012C0B RID: 76811 RVA: 0x002BCA28 File Offset: 0x002BAC28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.info_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.Info);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012C0C RID: 76812 RVA: 0x002BCA84 File Offset: 0x002BAC84
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

		// Token: 0x06012C0D RID: 76813 RVA: 0x002BCADC File Offset: 0x002BACDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerPsnInfoGetResponse other)
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

		// Token: 0x06012C0E RID: 76814 RVA: 0x002BCB44 File Offset: 0x002BAD44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012C0F RID: 76815 RVA: 0x002BCB50 File Offset: 0x002BAD50
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
				if (num != 80U)
				{
					if (num != 106U)
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

		// Token: 0x0400748E RID: 29838
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400748F RID: 29839
		public const int InfoFieldNumber = 13;

		// Token: 0x04007490 RID: 29840
		private PlayerDetails info_;

		// Token: 0x04007491 RID: 29841
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04007492 RID: 29842
		private ErrorCode errorCode_;
	}
}
