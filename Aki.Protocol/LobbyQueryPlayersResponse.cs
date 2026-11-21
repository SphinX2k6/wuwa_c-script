using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000933 RID: 2355
	[NetMessage(EMessageId.LobbyQueryPlayersResponse)]
	public sealed class LobbyQueryPlayersResponse : IMessage<LobbyQueryPlayersResponse>, IMessage, IEquatable<LobbyQueryPlayersResponse>, IDeepCloneable<LobbyQueryPlayersResponse>, IBufferMessage
	{
		// Token: 0x0600CFCA RID: 53194 RVA: 0x001E960D File Offset: 0x001E780D
		[NullableContext(1)]
		public static LobbyQueryPlayersResponse Create()
		{
			return new LobbyQueryPlayersResponse();
		}

		// Token: 0x170029F2 RID: 10738
		// (get) Token: 0x0600CFCB RID: 53195 RVA: 0x001E9614 File Offset: 0x001E7814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170029F3 RID: 10739
		// (get) Token: 0x0600CFCC RID: 53196 RVA: 0x001E9617 File Offset: 0x001E7817
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LobbyQueryPlayersResponse.Descriptor;
			}
		}

		// Token: 0x0600CFCD RID: 53197 RVA: 0x001E961E File Offset: 0x001E781E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyQueryPlayersResponse()
		{
		}

		// Token: 0x0600CFCE RID: 53198 RVA: 0x001E9628 File Offset: 0x001E7828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyQueryPlayersResponse(LobbyQueryPlayersResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.item_ = ((other.item_ != null) ? other.item_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CFCF RID: 53199 RVA: 0x001E9674 File Offset: 0x001E7874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyQueryPlayersResponse Clone()
		{
			return new LobbyQueryPlayersResponse(this);
		}

		// Token: 0x170029F4 RID: 10740
		// (get) Token: 0x0600CFD0 RID: 53200 RVA: 0x001E967C File Offset: 0x001E787C
		// (set) Token: 0x0600CFD1 RID: 53201 RVA: 0x001E9684 File Offset: 0x001E7884
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

		// Token: 0x170029F5 RID: 10741
		// (get) Token: 0x0600CFD2 RID: 53202 RVA: 0x001E968D File Offset: 0x001E788D
		// (set) Token: 0x0600CFD3 RID: 53203 RVA: 0x001E9695 File Offset: 0x001E7895
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

		// Token: 0x0600CFD4 RID: 53204 RVA: 0x001E969E File Offset: 0x001E789E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LobbyQueryPlayersResponse);
		}

		// Token: 0x0600CFD5 RID: 53205 RVA: 0x001E96AC File Offset: 0x001E78AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LobbyQueryPlayersResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.Item, other.Item) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CFD6 RID: 53206 RVA: 0x001E96FC File Offset: 0x001E78FC
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

		// Token: 0x0600CFD7 RID: 53207 RVA: 0x001E9757 File Offset: 0x001E7957
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CFD8 RID: 53208 RVA: 0x001E9764 File Offset: 0x001E7964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CFD9 RID: 53209 RVA: 0x001E9770 File Offset: 0x001E7970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.item_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.Item);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CFDA RID: 53210 RVA: 0x001E97CC File Offset: 0x001E79CC
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

		// Token: 0x0600CFDB RID: 53211 RVA: 0x001E9824 File Offset: 0x001E7A24
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

		// Token: 0x0600CFDC RID: 53212 RVA: 0x001E988C File Offset: 0x001E7A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CFDD RID: 53213 RVA: 0x001E9898 File Offset: 0x001E7A98
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
				if (num != 114U)
				{
					if (num != 120U)
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
					if (this.item_ == null)
					{
						this.Item = new PlayerDetails();
					}
					input.ReadMessage(this.Item);
				}
			}
		}

		// Token: 0x040057EA RID: 22506
		private UnknownFieldSet _unknownFields;

		// Token: 0x040057EB RID: 22507
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x040057EC RID: 22508
		private ErrorCode errorCode_;

		// Token: 0x040057ED RID: 22509
		public const int ItemFieldNumber = 14;

		// Token: 0x040057EE RID: 22510
		private PlayerDetails item_;
	}
}
