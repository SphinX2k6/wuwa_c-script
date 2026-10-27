using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000944 RID: 2372
	[NetMessage(EMessageId.LobbyQueryPlayersResponse)]
	public sealed class LobbyQueryPlayersResponse : IMessage<LobbyQueryPlayersResponse>, IMessage, IEquatable<LobbyQueryPlayersResponse>, IDeepCloneable<LobbyQueryPlayersResponse>, IBufferMessage
	{
		// Token: 0x0600D0E6 RID: 53478 RVA: 0x001EB8E1 File Offset: 0x001E9AE1
		[NullableContext(1)]
		public static LobbyQueryPlayersResponse Create()
		{
			return new LobbyQueryPlayersResponse();
		}

		// Token: 0x17002A31 RID: 10801
		// (get) Token: 0x0600D0E7 RID: 53479 RVA: 0x001EB8E8 File Offset: 0x001E9AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A32 RID: 10802
		// (get) Token: 0x0600D0E8 RID: 53480 RVA: 0x001EB8EB File Offset: 0x001E9AEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LobbyQueryPlayersResponse.Descriptor;
			}
		}

		// Token: 0x0600D0E9 RID: 53481 RVA: 0x001EB8F2 File Offset: 0x001E9AF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyQueryPlayersResponse()
		{
		}

		// Token: 0x0600D0EA RID: 53482 RVA: 0x001EB8FC File Offset: 0x001E9AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyQueryPlayersResponse(LobbyQueryPlayersResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.item_ = ((other.item_ != null) ? other.item_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D0EB RID: 53483 RVA: 0x001EB948 File Offset: 0x001E9B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyQueryPlayersResponse Clone()
		{
			return new LobbyQueryPlayersResponse(this);
		}

		// Token: 0x17002A33 RID: 10803
		// (get) Token: 0x0600D0EC RID: 53484 RVA: 0x001EB950 File Offset: 0x001E9B50
		// (set) Token: 0x0600D0ED RID: 53485 RVA: 0x001EB958 File Offset: 0x001E9B58
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

		// Token: 0x17002A34 RID: 10804
		// (get) Token: 0x0600D0EE RID: 53486 RVA: 0x001EB961 File Offset: 0x001E9B61
		// (set) Token: 0x0600D0EF RID: 53487 RVA: 0x001EB969 File Offset: 0x001E9B69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerDetails Item
		{
			get
			{
				return this.item_;
			}
			set
			{
				this.item_ = value;
			}
		}

		// Token: 0x0600D0F0 RID: 53488 RVA: 0x001EB972 File Offset: 0x001E9B72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LobbyQueryPlayersResponse);
		}

		// Token: 0x0600D0F1 RID: 53489 RVA: 0x001EB980 File Offset: 0x001E9B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LobbyQueryPlayersResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.Item, other.Item) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D0F2 RID: 53490 RVA: 0x001EB9D0 File Offset: 0x001E9BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.item_ != null)
			{
				num ^= this.Item.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D0F3 RID: 53491 RVA: 0x001EBA2B File Offset: 0x001E9C2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D0F4 RID: 53492 RVA: 0x001EBA38 File Offset: 0x001E9C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D0F5 RID: 53493 RVA: 0x001EBA44 File Offset: 0x001E9C44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.item_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.Item);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D0F6 RID: 53494 RVA: 0x001EBAA0 File Offset: 0x001E9CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.item_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Item);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D0F7 RID: 53495 RVA: 0x001EBAF8 File Offset: 0x001E9CF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LobbyQueryPlayersResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.item_ != null)
			{
				if (this.item_ == null)
				{
					this.Item = new PlayerDetails();
				}
				this.Item.MergeFrom(other.Item);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D0F8 RID: 53496 RVA: 0x001EBB60 File Offset: 0x001E9D60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D0F9 RID: 53497 RVA: 0x001EBB6C File Offset: 0x001E9D6C
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
					if (num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.item_ == null)
						{
							this.Item = new PlayerDetails();
						}
						input.ReadMessage(this.Item);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040057E3 RID: 22499
		private UnknownFieldSet _unknownFields;

		// Token: 0x040057E4 RID: 22500
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x040057E5 RID: 22501
		private ErrorCode errorCode_;

		// Token: 0x040057E6 RID: 22502
		public const int ItemFieldNumber = 10;

		// Token: 0x040057E7 RID: 22503
		private PlayerDetails item_;
	}
}
