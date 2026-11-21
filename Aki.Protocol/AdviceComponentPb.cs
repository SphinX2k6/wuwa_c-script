using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000C6 RID: 198
	public sealed class AdviceComponentPb : IMessage<AdviceComponentPb>, IMessage, IEquatable<AdviceComponentPb>, IDeepCloneable<AdviceComponentPb>, IBufferMessage
	{
		// Token: 0x06001F72 RID: 8050 RVA: 0x00055A73 File Offset: 0x00053C73
		[NullableContext(1)]
		public static AdviceComponentPb Create()
		{
			return new AdviceComponentPb();
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06001F73 RID: 8051 RVA: 0x00055A7A File Offset: 0x00053C7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06001F74 RID: 8052 RVA: 0x00055A7D File Offset: 0x00053C7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdviceComponentPb.Descriptor;
			}
		}

		// Token: 0x06001F75 RID: 8053 RVA: 0x00055A84 File Offset: 0x00053C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceComponentPb()
		{
		}

		// Token: 0x06001F76 RID: 8054 RVA: 0x00055A98 File Offset: 0x00053C98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceComponentPb(AdviceComponentPb other) : this()
		{
			this.advice_ = ((other.advice_ != null) ? other.advice_.Clone() : null);
			this.playerId_ = other.playerId_;
			this.playerName_ = other.playerName_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001F77 RID: 8055 RVA: 0x00055AF0 File Offset: 0x00053CF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceComponentPb Clone()
		{
			return new AdviceComponentPb(this);
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06001F78 RID: 8056 RVA: 0x00055AF8 File Offset: 0x00053CF8
		// (set) Token: 0x06001F79 RID: 8057 RVA: 0x00055B00 File Offset: 0x00053D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbAdvice Advice
		{
			get
			{
				return this.advice_;
			}
			set
			{
				this.advice_ = value;
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06001F7A RID: 8058 RVA: 0x00055B09 File Offset: 0x00053D09
		// (set) Token: 0x06001F7B RID: 8059 RVA: 0x00055B11 File Offset: 0x00053D11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06001F7C RID: 8060 RVA: 0x00055B1A File Offset: 0x00053D1A
		// (set) Token: 0x06001F7D RID: 8061 RVA: 0x00055B22 File Offset: 0x00053D22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string PlayerName
		{
			get
			{
				return this.playerName_;
			}
			set
			{
				this.playerName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06001F7E RID: 8062 RVA: 0x00055B35 File Offset: 0x00053D35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdviceComponentPb);
		}

		// Token: 0x06001F7F RID: 8063 RVA: 0x00055B44 File Offset: 0x00053D44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdviceComponentPb other)
		{
			return other != null && (other == this || (object.Equals(this.Advice, other.Advice) && this.PlayerId == other.PlayerId && !(this.PlayerName != other.PlayerName) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001F80 RID: 8064 RVA: 0x00055BA8 File Offset: 0x00053DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.advice_ != null)
			{
				num ^= this.Advice.GetHashCode();
			}
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.PlayerName.Length != 0)
			{
				num ^= this.PlayerName.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001F81 RID: 8065 RVA: 0x00055C18 File Offset: 0x00053E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001F82 RID: 8066 RVA: 0x00055C25 File Offset: 0x00053E25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001F83 RID: 8067 RVA: 0x00055C30 File Offset: 0x00053E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.advice_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Advice);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.PlayerId);
			}
			if (this.PlayerName.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(this.PlayerName);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001F84 RID: 8068 RVA: 0x00055CAC File Offset: 0x00053EAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.advice_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Advice);
			}
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.PlayerName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.PlayerName);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001F85 RID: 8069 RVA: 0x00055D20 File Offset: 0x00053F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AdviceComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.advice_ != null)
			{
				if (this.advice_ == null)
				{
					this.Advice = new PbAdvice();
				}
				this.Advice.MergeFrom(other.Advice);
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.PlayerName.Length != 0)
			{
				this.PlayerName = other.PlayerName;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001F86 RID: 8070 RVA: 0x00055DA1 File Offset: 0x00053FA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001F87 RID: 8071 RVA: 0x00055DAC File Offset: 0x00053FAC
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
				if (num != 10U)
				{
					if (num != 16U)
					{
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.PlayerName = input.ReadString();
						}
					}
					else
					{
						this.PlayerId = input.ReadInt32();
					}
				}
				else
				{
					if (this.advice_ == null)
					{
						this.Advice = new PbAdvice();
					}
					input.ReadMessage(this.Advice);
				}
			}
		}

		// Token: 0x04002409 RID: 9225
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400240A RID: 9226
		public const int AdviceFieldNumber = 1;

		// Token: 0x0400240B RID: 9227
		private PbAdvice advice_;

		// Token: 0x0400240C RID: 9228
		public const int PlayerIdFieldNumber = 2;

		// Token: 0x0400240D RID: 9229
		private int playerId_;

		// Token: 0x0400240E RID: 9230
		public const int PlayerNameFieldNumber = 3;

		// Token: 0x0400240F RID: 9231
		private string playerName_ = "";
	}
}
