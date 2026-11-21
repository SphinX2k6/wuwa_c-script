using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D80 RID: 3456
	[NetMessage(EMessageId.PlayerGameTokenResponse)]
	public sealed class PlayerGameTokenResponse : IMessage<PlayerGameTokenResponse>, IMessage, IEquatable<PlayerGameTokenResponse>, IDeepCloneable<PlayerGameTokenResponse>, IBufferMessage
	{
		// Token: 0x06012A96 RID: 76438 RVA: 0x002B9E42 File Offset: 0x002B8042
		[NullableContext(1)]
		public static PlayerGameTokenResponse Create()
		{
			return new PlayerGameTokenResponse();
		}

		// Token: 0x17003DF1 RID: 15857
		// (get) Token: 0x06012A97 RID: 76439 RVA: 0x002B9E49 File Offset: 0x002B8049
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003DF2 RID: 15858
		// (get) Token: 0x06012A98 RID: 76440 RVA: 0x002B9E4C File Offset: 0x002B804C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerGameTokenResponse.Descriptor;
			}
		}

		// Token: 0x06012A99 RID: 76441 RVA: 0x002B9E53 File Offset: 0x002B8053
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerGameTokenResponse()
		{
		}

		// Token: 0x06012A9A RID: 76442 RVA: 0x002B9E66 File Offset: 0x002B8066
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerGameTokenResponse(PlayerGameTokenResponse other) : this()
		{
			this.gameToken_ = other.gameToken_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012A9B RID: 76443 RVA: 0x002B9E8B File Offset: 0x002B808B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerGameTokenResponse Clone()
		{
			return new PlayerGameTokenResponse(this);
		}

		// Token: 0x17003DF3 RID: 15859
		// (get) Token: 0x06012A9C RID: 76444 RVA: 0x002B9E93 File Offset: 0x002B8093
		// (set) Token: 0x06012A9D RID: 76445 RVA: 0x002B9E9B File Offset: 0x002B809B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string GameToken
		{
			get
			{
				return this.gameToken_;
			}
			set
			{
				this.gameToken_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06012A9E RID: 76446 RVA: 0x002B9EAE File Offset: 0x002B80AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerGameTokenResponse);
		}

		// Token: 0x06012A9F RID: 76447 RVA: 0x002B9EBC File Offset: 0x002B80BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerGameTokenResponse other)
		{
			return other != null && (other == this || (!(this.GameToken != other.GameToken) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012AA0 RID: 76448 RVA: 0x002B9EF0 File Offset: 0x002B80F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GameToken.Length != 0)
			{
				num ^= this.GameToken.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012AA1 RID: 76449 RVA: 0x002B9F31 File Offset: 0x002B8131
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012AA2 RID: 76450 RVA: 0x002B9F3E File Offset: 0x002B813E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012AA3 RID: 76451 RVA: 0x002B9F47 File Offset: 0x002B8147
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GameToken.Length != 0)
			{
				output.WriteRawTag(74);
				output.WriteString(this.GameToken);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012AA4 RID: 76452 RVA: 0x002B9F80 File Offset: 0x002B8180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GameToken.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.GameToken);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012AA5 RID: 76453 RVA: 0x002B9FC3 File Offset: 0x002B81C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerGameTokenResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GameToken.Length != 0)
			{
				this.GameToken = other.GameToken;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012AA6 RID: 76454 RVA: 0x002B9FF9 File Offset: 0x002B81F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012AA7 RID: 76455 RVA: 0x002BA004 File Offset: 0x002B8204
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
				if (num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.GameToken = input.ReadString();
				}
			}
		}

		// Token: 0x04007441 RID: 29761
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007442 RID: 29762
		public const int GameTokenFieldNumber = 9;

		// Token: 0x04007443 RID: 29763
		private string gameToken_ = "";
	}
}
