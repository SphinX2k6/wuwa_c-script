using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FC3 RID: 4035
	public sealed class RoguelikeToken : IMessage<RoguelikeToken>, IMessage, IEquatable<RoguelikeToken>, IDeepCloneable<RoguelikeToken>, IBufferMessage
	{
		// Token: 0x06015924 RID: 88356 RVA: 0x003218E9 File Offset: 0x0031FAE9
		[NullableContext(1)]
		public static RoguelikeToken Create()
		{
			return new RoguelikeToken();
		}

		// Token: 0x170047ED RID: 18413
		// (get) Token: 0x06015925 RID: 88357 RVA: 0x003218F0 File Offset: 0x0031FAF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoguelikeToken> Parser
		{
			get
			{
				return RoguelikeToken._parser;
			}
		}

		// Token: 0x170047EE RID: 18414
		// (get) Token: 0x06015926 RID: 88358 RVA: 0x003218F7 File Offset: 0x0031FAF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170047EF RID: 18415
		// (get) Token: 0x06015927 RID: 88359 RVA: 0x003218FA File Offset: 0x0031FAFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeToken.Descriptor;
			}
		}

		// Token: 0x06015928 RID: 88360 RVA: 0x00321901 File Offset: 0x0031FB01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeToken()
		{
		}

		// Token: 0x06015929 RID: 88361 RVA: 0x00321909 File Offset: 0x0031FB09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeToken(RoguelikeToken other) : this()
		{
			this.id_ = other.id_;
			this.isReceive_ = other.isReceive_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601592A RID: 88362 RVA: 0x0032193A File Offset: 0x0031FB3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeToken Clone()
		{
			return new RoguelikeToken(this);
		}

		// Token: 0x170047F0 RID: 18416
		// (get) Token: 0x0601592B RID: 88363 RVA: 0x00321942 File Offset: 0x0031FB42
		// (set) Token: 0x0601592C RID: 88364 RVA: 0x0032194A File Offset: 0x0031FB4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170047F1 RID: 18417
		// (get) Token: 0x0601592D RID: 88365 RVA: 0x00321953 File Offset: 0x0031FB53
		// (set) Token: 0x0601592E RID: 88366 RVA: 0x0032195B File Offset: 0x0031FB5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsReceive
		{
			get
			{
				return this.isReceive_;
			}
			set
			{
				this.isReceive_ = value;
			}
		}

		// Token: 0x0601592F RID: 88367 RVA: 0x00321964 File Offset: 0x0031FB64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeToken);
		}

		// Token: 0x06015930 RID: 88368 RVA: 0x00321972 File Offset: 0x0031FB72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeToken other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.IsReceive == other.IsReceive && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015931 RID: 88369 RVA: 0x003219B0 File Offset: 0x0031FBB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.IsReceive)
			{
				num ^= this.IsReceive.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015932 RID: 88370 RVA: 0x00321A08 File Offset: 0x0031FC08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015933 RID: 88371 RVA: 0x00321A15 File Offset: 0x0031FC15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015934 RID: 88372 RVA: 0x00321A20 File Offset: 0x0031FC20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.IsReceive)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsReceive);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015935 RID: 88373 RVA: 0x00321A78 File Offset: 0x0031FC78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.IsReceive)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015936 RID: 88374 RVA: 0x00321AC4 File Offset: 0x0031FCC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeToken other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.IsReceive)
			{
				this.IsReceive = other.IsReceive;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015937 RID: 88375 RVA: 0x00321B14 File Offset: 0x0031FD14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015938 RID: 88376 RVA: 0x00321B20 File Offset: 0x0031FD20
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsReceive = input.ReadBool();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008197 RID: 33175
		private static readonly MessageParser<RoguelikeToken> _parser = new MessageParser<RoguelikeToken>(() => new RoguelikeToken());

		// Token: 0x04008198 RID: 33176
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008199 RID: 33177
		public const int IdFieldNumber = 1;

		// Token: 0x0400819A RID: 33178
		private int id_;

		// Token: 0x0400819B RID: 33179
		public const int IsReceiveFieldNumber = 2;

		// Token: 0x0400819C RID: 33180
		private bool isReceive_;
	}
}
