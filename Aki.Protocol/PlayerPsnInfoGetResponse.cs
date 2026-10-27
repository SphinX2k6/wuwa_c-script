using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DA3 RID: 3491
	[NetMessage(EMessageId.PlayerPsnInfoGetResponse)]
	public sealed class PlayerPsnInfoGetResponse : IMessage<PlayerPsnInfoGetResponse>, IMessage, IEquatable<PlayerPsnInfoGetResponse>, IDeepCloneable<PlayerPsnInfoGetResponse>, IBufferMessage
	{
		// Token: 0x06012CF8 RID: 77048 RVA: 0x002BE4E9 File Offset: 0x002BC6E9
		[NullableContext(1)]
		public static PlayerPsnInfoGetResponse Create()
		{
			return new PlayerPsnInfoGetResponse();
		}

		// Token: 0x17003E67 RID: 15975
		// (get) Token: 0x06012CF9 RID: 77049 RVA: 0x002BE4F0 File Offset: 0x002BC6F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E68 RID: 15976
		// (get) Token: 0x06012CFA RID: 77050 RVA: 0x002BE4F3 File Offset: 0x002BC6F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerPsnInfoGetResponse.Descriptor;
			}
		}

		// Token: 0x06012CFB RID: 77051 RVA: 0x002BE4FA File Offset: 0x002BC6FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerPsnInfoGetResponse()
		{
		}

		// Token: 0x06012CFC RID: 77052 RVA: 0x002BE504 File Offset: 0x002BC704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerPsnInfoGetResponse(PlayerPsnInfoGetResponse other) : this()
		{
			this.info_ = ((other.info_ != null) ? other.info_.Clone() : null);
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012CFD RID: 77053 RVA: 0x002BE550 File Offset: 0x002BC750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerPsnInfoGetResponse Clone()
		{
			return new PlayerPsnInfoGetResponse(this);
		}

		// Token: 0x17003E69 RID: 15977
		// (get) Token: 0x06012CFE RID: 77054 RVA: 0x002BE558 File Offset: 0x002BC758
		// (set) Token: 0x06012CFF RID: 77055 RVA: 0x002BE560 File Offset: 0x002BC760
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

		// Token: 0x17003E6A RID: 15978
		// (get) Token: 0x06012D00 RID: 77056 RVA: 0x002BE569 File Offset: 0x002BC769
		// (set) Token: 0x06012D01 RID: 77057 RVA: 0x002BE571 File Offset: 0x002BC771
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

		// Token: 0x06012D02 RID: 77058 RVA: 0x002BE57A File Offset: 0x002BC77A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerPsnInfoGetResponse);
		}

		// Token: 0x06012D03 RID: 77059 RVA: 0x002BE588 File Offset: 0x002BC788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerPsnInfoGetResponse other)
		{
			return other != null && (other == this || (object.Equals(this.Info, other.Info) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012D04 RID: 77060 RVA: 0x002BE5D8 File Offset: 0x002BC7D8
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

		// Token: 0x06012D05 RID: 77061 RVA: 0x002BE633 File Offset: 0x002BC833
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012D06 RID: 77062 RVA: 0x002BE640 File Offset: 0x002BC840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012D07 RID: 77063 RVA: 0x002BE64C File Offset: 0x002BC84C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
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

		// Token: 0x06012D08 RID: 77064 RVA: 0x002BE6A8 File Offset: 0x002BC8A8
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

		// Token: 0x06012D09 RID: 77065 RVA: 0x002BE700 File Offset: 0x002BC900
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

		// Token: 0x06012D0A RID: 77066 RVA: 0x002BE768 File Offset: 0x002BC968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012D0B RID: 77067 RVA: 0x002BE774 File Offset: 0x002BC974
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
				if (num != 64U)
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

		// Token: 0x04007476 RID: 29814
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007477 RID: 29815
		public const int InfoFieldNumber = 13;

		// Token: 0x04007478 RID: 29816
		private PlayerDetails info_;

		// Token: 0x04007479 RID: 29817
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x0400747A RID: 29818
		private ErrorCode errorCode_;
	}
}
