using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000C5 RID: 197
	public sealed class AdviceComponentPb : IMessage<AdviceComponentPb>, IMessage, IEquatable<AdviceComponentPb>, IDeepCloneable<AdviceComponentPb>, IBufferMessage
	{
		// Token: 0x06001F29 RID: 7977 RVA: 0x00054DBF File Offset: 0x00052FBF
		[NullableContext(1)]
		public static AdviceComponentPb Create()
		{
			return new AdviceComponentPb();
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06001F2A RID: 7978 RVA: 0x00054DC6 File Offset: 0x00052FC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06001F2B RID: 7979 RVA: 0x00054DC9 File Offset: 0x00052FC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdviceComponentPb.Descriptor;
			}
		}

		// Token: 0x06001F2C RID: 7980 RVA: 0x00054DD0 File Offset: 0x00052FD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceComponentPb()
		{
		}

		// Token: 0x06001F2D RID: 7981 RVA: 0x00054DE4 File Offset: 0x00052FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceComponentPb(AdviceComponentPb other) : this()
		{
			this.advice_ = ((other.advice_ != null) ? other.advice_.Clone() : null);
			this.playerId_ = other.playerId_;
			this.playerName_ = other.playerName_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001F2E RID: 7982 RVA: 0x00054E3C File Offset: 0x0005303C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceComponentPb Clone()
		{
			return new AdviceComponentPb(this);
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06001F2F RID: 7983 RVA: 0x00054E44 File Offset: 0x00053044
		// (set) Token: 0x06001F30 RID: 7984 RVA: 0x00054E4C File Offset: 0x0005304C
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

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06001F31 RID: 7985 RVA: 0x00054E55 File Offset: 0x00053055
		// (set) Token: 0x06001F32 RID: 7986 RVA: 0x00054E5D File Offset: 0x0005305D
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

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06001F33 RID: 7987 RVA: 0x00054E66 File Offset: 0x00053066
		// (set) Token: 0x06001F34 RID: 7988 RVA: 0x00054E6E File Offset: 0x0005306E
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

		// Token: 0x06001F35 RID: 7989 RVA: 0x00054E81 File Offset: 0x00053081
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdviceComponentPb);
		}

		// Token: 0x06001F36 RID: 7990 RVA: 0x00054E90 File Offset: 0x00053090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdviceComponentPb other)
		{
			return other != null && (other == this || (object.Equals(this.Advice, other.Advice) && this.PlayerId == other.PlayerId && !(this.PlayerName != other.PlayerName) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001F37 RID: 7991 RVA: 0x00054EF4 File Offset: 0x000530F4
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

		// Token: 0x06001F38 RID: 7992 RVA: 0x00054F64 File Offset: 0x00053164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001F39 RID: 7993 RVA: 0x00054F71 File Offset: 0x00053171
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001F3A RID: 7994 RVA: 0x00054F7C File Offset: 0x0005317C
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

		// Token: 0x06001F3B RID: 7995 RVA: 0x00054FF8 File Offset: 0x000531F8
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

		// Token: 0x06001F3C RID: 7996 RVA: 0x0005506C File Offset: 0x0005326C
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

		// Token: 0x06001F3D RID: 7997 RVA: 0x000550ED File Offset: 0x000532ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001F3E RID: 7998 RVA: 0x000550F8 File Offset: 0x000532F8
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

		// Token: 0x040023A6 RID: 9126
		private UnknownFieldSet _unknownFields;

		// Token: 0x040023A7 RID: 9127
		public const int AdviceFieldNumber = 1;

		// Token: 0x040023A8 RID: 9128
		private PbAdvice advice_;

		// Token: 0x040023A9 RID: 9129
		public const int PlayerIdFieldNumber = 2;

		// Token: 0x040023AA RID: 9130
		private int playerId_;

		// Token: 0x040023AB RID: 9131
		public const int PlayerNameFieldNumber = 3;

		// Token: 0x040023AC RID: 9132
		private string playerName_ = "";
	}
}
