using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001017 RID: 4119
	public sealed class RogueToken : IMessage<RogueToken>, IMessage, IEquatable<RogueToken>, IDeepCloneable<RogueToken>, IBufferMessage
	{
		// Token: 0x06016066 RID: 90214 RVA: 0x00333BC7 File Offset: 0x00331DC7
		[NullableContext(1)]
		public static RogueToken Create()
		{
			return new RogueToken();
		}

		// Token: 0x170049A2 RID: 18850
		// (get) Token: 0x06016067 RID: 90215 RVA: 0x00333BCE File Offset: 0x00331DCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueToken> Parser
		{
			get
			{
				return RogueToken._parser;
			}
		}

		// Token: 0x170049A3 RID: 18851
		// (get) Token: 0x06016068 RID: 90216 RVA: 0x00333BD5 File Offset: 0x00331DD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170049A4 RID: 18852
		// (get) Token: 0x06016069 RID: 90217 RVA: 0x00333BD8 File Offset: 0x00331DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueToken.Descriptor;
			}
		}

		// Token: 0x0601606A RID: 90218 RVA: 0x00333BDF File Offset: 0x00331DDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueToken()
		{
		}

		// Token: 0x0601606B RID: 90219 RVA: 0x00333BE7 File Offset: 0x00331DE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueToken(RogueToken other) : this()
		{
			this.id_ = other.id_;
			this.isReceive_ = other.isReceive_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601606C RID: 90220 RVA: 0x00333C18 File Offset: 0x00331E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueToken Clone()
		{
			return new RogueToken(this);
		}

		// Token: 0x170049A5 RID: 18853
		// (get) Token: 0x0601606D RID: 90221 RVA: 0x00333C20 File Offset: 0x00331E20
		// (set) Token: 0x0601606E RID: 90222 RVA: 0x00333C28 File Offset: 0x00331E28
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

		// Token: 0x170049A6 RID: 18854
		// (get) Token: 0x0601606F RID: 90223 RVA: 0x00333C31 File Offset: 0x00331E31
		// (set) Token: 0x06016070 RID: 90224 RVA: 0x00333C39 File Offset: 0x00331E39
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

		// Token: 0x06016071 RID: 90225 RVA: 0x00333C42 File Offset: 0x00331E42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueToken);
		}

		// Token: 0x06016072 RID: 90226 RVA: 0x00333C50 File Offset: 0x00331E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueToken other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.IsReceive == other.IsReceive && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016073 RID: 90227 RVA: 0x00333C90 File Offset: 0x00331E90
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

		// Token: 0x06016074 RID: 90228 RVA: 0x00333CE8 File Offset: 0x00331EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016075 RID: 90229 RVA: 0x00333CF5 File Offset: 0x00331EF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016076 RID: 90230 RVA: 0x00333D00 File Offset: 0x00331F00
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

		// Token: 0x06016077 RID: 90231 RVA: 0x00333D58 File Offset: 0x00331F58
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

		// Token: 0x06016078 RID: 90232 RVA: 0x00333DA4 File Offset: 0x00331FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueToken other)
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

		// Token: 0x06016079 RID: 90233 RVA: 0x00333DF4 File Offset: 0x00331FF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601607A RID: 90234 RVA: 0x00333E00 File Offset: 0x00332000
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

		// Token: 0x0400841C RID: 33820
		private static readonly MessageParser<RogueToken> _parser = new MessageParser<RogueToken>(() => new RogueToken());

		// Token: 0x0400841D RID: 33821
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400841E RID: 33822
		public const int IdFieldNumber = 1;

		// Token: 0x0400841F RID: 33823
		private int id_;

		// Token: 0x04008420 RID: 33824
		public const int IsReceiveFieldNumber = 2;

		// Token: 0x04008421 RID: 33825
		private bool isReceive_;
	}
}
