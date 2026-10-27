using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DA4 RID: 3492
	[NetMessage(EMessageId.PlayerPsnSessionNotify)]
	public sealed class PlayerPsnSessionNotify : IMessage<PlayerPsnSessionNotify>, IMessage, IEquatable<PlayerPsnSessionNotify>, IDeepCloneable<PlayerPsnSessionNotify>, IBufferMessage
	{
		// Token: 0x06012D0C RID: 77068 RVA: 0x002BE7DF File Offset: 0x002BC9DF
		[NullableContext(1)]
		public static PlayerPsnSessionNotify Create()
		{
			return new PlayerPsnSessionNotify();
		}

		// Token: 0x17003E6B RID: 15979
		// (get) Token: 0x06012D0D RID: 77069 RVA: 0x002BE7E6 File Offset: 0x002BC9E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E6C RID: 15980
		// (get) Token: 0x06012D0E RID: 77070 RVA: 0x002BE7E9 File Offset: 0x002BC9E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerPsnSessionNotify.Descriptor;
			}
		}

		// Token: 0x06012D0F RID: 77071 RVA: 0x002BE7F0 File Offset: 0x002BC9F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerPsnSessionNotify()
		{
		}

		// Token: 0x06012D10 RID: 77072 RVA: 0x002BE803 File Offset: 0x002BCA03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerPsnSessionNotify(PlayerPsnSessionNotify other) : this()
		{
			this.psnSessionId_ = other.psnSessionId_;
			this.playerId_ = other.playerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012D11 RID: 77073 RVA: 0x002BE834 File Offset: 0x002BCA34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerPsnSessionNotify Clone()
		{
			return new PlayerPsnSessionNotify(this);
		}

		// Token: 0x17003E6D RID: 15981
		// (get) Token: 0x06012D12 RID: 77074 RVA: 0x002BE83C File Offset: 0x002BCA3C
		// (set) Token: 0x06012D13 RID: 77075 RVA: 0x002BE844 File Offset: 0x002BCA44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string PsnSessionId
		{
			get
			{
				return this.psnSessionId_;
			}
			set
			{
				this.psnSessionId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003E6E RID: 15982
		// (get) Token: 0x06012D14 RID: 77076 RVA: 0x002BE857 File Offset: 0x002BCA57
		// (set) Token: 0x06012D15 RID: 77077 RVA: 0x002BE85F File Offset: 0x002BCA5F
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

		// Token: 0x06012D16 RID: 77078 RVA: 0x002BE868 File Offset: 0x002BCA68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerPsnSessionNotify);
		}

		// Token: 0x06012D17 RID: 77079 RVA: 0x002BE878 File Offset: 0x002BCA78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerPsnSessionNotify other)
		{
			return other != null && (other == this || (!(this.PsnSessionId != other.PsnSessionId) && this.PlayerId == other.PlayerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012D18 RID: 77080 RVA: 0x002BE8C8 File Offset: 0x002BCAC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PsnSessionId.Length != 0)
			{
				num ^= this.PsnSessionId.GetHashCode();
			}
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012D19 RID: 77081 RVA: 0x002BE922 File Offset: 0x002BCB22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012D1A RID: 77082 RVA: 0x002BE92F File Offset: 0x002BCB2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012D1B RID: 77083 RVA: 0x002BE938 File Offset: 0x002BCB38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PsnSessionId.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.PsnSessionId);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012D1C RID: 77084 RVA: 0x002BE998 File Offset: 0x002BCB98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PsnSessionId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.PsnSessionId);
			}
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012D1D RID: 77085 RVA: 0x002BE9F4 File Offset: 0x002BCBF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerPsnSessionNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PsnSessionId.Length != 0)
			{
				this.PsnSessionId = other.PsnSessionId;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012D1E RID: 77086 RVA: 0x002BEA49 File Offset: 0x002BCC49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012D1F RID: 77087 RVA: 0x002BEA54 File Offset: 0x002BCC54
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
				if (num != 50U)
				{
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.PlayerId = input.ReadInt32();
					}
				}
				else
				{
					this.PsnSessionId = input.ReadString();
				}
			}
		}

		// Token: 0x0400747B RID: 29819
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400747C RID: 29820
		public const int PsnSessionIdFieldNumber = 6;

		// Token: 0x0400747D RID: 29821
		private string psnSessionId_ = "";

		// Token: 0x0400747E RID: 29822
		public const int PlayerIdFieldNumber = 7;

		// Token: 0x0400747F RID: 29823
		private int playerId_;
	}
}
