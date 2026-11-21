using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D72 RID: 3442
	[NetMessage(EMessageId.PlayerBasicInfoGetResponse)]
	public sealed class PlayerBasicInfoGetResponse : IMessage<PlayerBasicInfoGetResponse>, IMessage, IEquatable<PlayerBasicInfoGetResponse>, IDeepCloneable<PlayerBasicInfoGetResponse>, IBufferMessage
	{
		// Token: 0x06012944 RID: 76100 RVA: 0x002B6475 File Offset: 0x002B4675
		[NullableContext(1)]
		public static PlayerBasicInfoGetResponse Create()
		{
			return new PlayerBasicInfoGetResponse();
		}

		// Token: 0x17003D9A RID: 15770
		// (get) Token: 0x06012945 RID: 76101 RVA: 0x002B647C File Offset: 0x002B467C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D9B RID: 15771
		// (get) Token: 0x06012946 RID: 76102 RVA: 0x002B647F File Offset: 0x002B467F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerBasicInfoGetResponse.Descriptor;
			}
		}

		// Token: 0x06012947 RID: 76103 RVA: 0x002B6486 File Offset: 0x002B4686
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerBasicInfoGetResponse()
		{
		}

		// Token: 0x06012948 RID: 76104 RVA: 0x002B6490 File Offset: 0x002B4690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerBasicInfoGetResponse(PlayerBasicInfoGetResponse other) : this()
		{
			this.info_ = ((other.info_ != null) ? other.info_.Clone() : null);
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012949 RID: 76105 RVA: 0x002B64DC File Offset: 0x002B46DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerBasicInfoGetResponse Clone()
		{
			return new PlayerBasicInfoGetResponse(this);
		}

		// Token: 0x17003D9C RID: 15772
		// (get) Token: 0x0601294A RID: 76106 RVA: 0x002B64E4 File Offset: 0x002B46E4
		// (set) Token: 0x0601294B RID: 76107 RVA: 0x002B64EC File Offset: 0x002B46EC
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

		// Token: 0x17003D9D RID: 15773
		// (get) Token: 0x0601294C RID: 76108 RVA: 0x002B64F5 File Offset: 0x002B46F5
		// (set) Token: 0x0601294D RID: 76109 RVA: 0x002B64FD File Offset: 0x002B46FD
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

		// Token: 0x0601294E RID: 76110 RVA: 0x002B6506 File Offset: 0x002B4706
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerBasicInfoGetResponse);
		}

		// Token: 0x0601294F RID: 76111 RVA: 0x002B6514 File Offset: 0x002B4714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerBasicInfoGetResponse other)
		{
			return other != null && (other == this || (object.Equals(this.Info, other.Info) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012950 RID: 76112 RVA: 0x002B6564 File Offset: 0x002B4764
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

		// Token: 0x06012951 RID: 76113 RVA: 0x002B65BF File Offset: 0x002B47BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012952 RID: 76114 RVA: 0x002B65CC File Offset: 0x002B47CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012953 RID: 76115 RVA: 0x002B65D8 File Offset: 0x002B47D8
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

		// Token: 0x06012954 RID: 76116 RVA: 0x002B6634 File Offset: 0x002B4834
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

		// Token: 0x06012955 RID: 76117 RVA: 0x002B668C File Offset: 0x002B488C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerBasicInfoGetResponse other)
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

		// Token: 0x06012956 RID: 76118 RVA: 0x002B66F4 File Offset: 0x002B48F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012957 RID: 76119 RVA: 0x002B6700 File Offset: 0x002B4900
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

		// Token: 0x040073BB RID: 29627
		private UnknownFieldSet _unknownFields;

		// Token: 0x040073BC RID: 29628
		public const int InfoFieldNumber = 11;

		// Token: 0x040073BD RID: 29629
		private PlayerDetails info_;

		// Token: 0x040073BE RID: 29630
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x040073BF RID: 29631
		private ErrorCode errorCode_;
	}
}
