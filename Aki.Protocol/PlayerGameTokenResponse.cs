using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D90 RID: 3472
	[NetMessage(EMessageId.PlayerGameTokenResponse)]
	public sealed class PlayerGameTokenResponse : IMessage<PlayerGameTokenResponse>, IMessage, IEquatable<PlayerGameTokenResponse>, IDeepCloneable<PlayerGameTokenResponse>, IBufferMessage
	{
		// Token: 0x06012B92 RID: 76690 RVA: 0x002BBA66 File Offset: 0x002B9C66
		[NullableContext(1)]
		public static PlayerGameTokenResponse Create()
		{
			return new PlayerGameTokenResponse();
		}

		// Token: 0x17003E26 RID: 15910
		// (get) Token: 0x06012B93 RID: 76691 RVA: 0x002BBA6D File Offset: 0x002B9C6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E27 RID: 15911
		// (get) Token: 0x06012B94 RID: 76692 RVA: 0x002BBA70 File Offset: 0x002B9C70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerGameTokenResponse.Descriptor;
			}
		}

		// Token: 0x06012B95 RID: 76693 RVA: 0x002BBA77 File Offset: 0x002B9C77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerGameTokenResponse()
		{
		}

		// Token: 0x06012B96 RID: 76694 RVA: 0x002BBA8A File Offset: 0x002B9C8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerGameTokenResponse(PlayerGameTokenResponse other) : this()
		{
			this.gameToken_ = other.gameToken_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012B97 RID: 76695 RVA: 0x002BBAAF File Offset: 0x002B9CAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerGameTokenResponse Clone()
		{
			return new PlayerGameTokenResponse(this);
		}

		// Token: 0x17003E28 RID: 15912
		// (get) Token: 0x06012B98 RID: 76696 RVA: 0x002BBAB7 File Offset: 0x002B9CB7
		// (set) Token: 0x06012B99 RID: 76697 RVA: 0x002BBABF File Offset: 0x002B9CBF
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

		// Token: 0x06012B9A RID: 76698 RVA: 0x002BBAD2 File Offset: 0x002B9CD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerGameTokenResponse);
		}

		// Token: 0x06012B9B RID: 76699 RVA: 0x002BBAE0 File Offset: 0x002B9CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerGameTokenResponse other)
		{
			return other != null && (other == this || (!(this.GameToken != other.GameToken) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012B9C RID: 76700 RVA: 0x002BBB14 File Offset: 0x002B9D14
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

		// Token: 0x06012B9D RID: 76701 RVA: 0x002BBB55 File Offset: 0x002B9D55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012B9E RID: 76702 RVA: 0x002BBB62 File Offset: 0x002B9D62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012B9F RID: 76703 RVA: 0x002BBB6B File Offset: 0x002B9D6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GameToken.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.GameToken);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012BA0 RID: 76704 RVA: 0x002BBBA4 File Offset: 0x002B9DA4
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

		// Token: 0x06012BA1 RID: 76705 RVA: 0x002BBBE7 File Offset: 0x002B9DE7
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

		// Token: 0x06012BA2 RID: 76706 RVA: 0x002BBC1D File Offset: 0x002B9E1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012BA3 RID: 76707 RVA: 0x002BBC28 File Offset: 0x002B9E28
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
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.GameToken = input.ReadString();
				}
			}
		}

		// Token: 0x04007429 RID: 29737
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400742A RID: 29738
		public const int GameTokenFieldNumber = 2;

		// Token: 0x0400742B RID: 29739
		private string gameToken_ = "";
	}
}
