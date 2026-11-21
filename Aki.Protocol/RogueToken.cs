using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001007 RID: 4103
	public sealed class RogueToken : IMessage<RogueToken>, IMessage, IEquatable<RogueToken>, IDeepCloneable<RogueToken>, IBufferMessage
	{
		// Token: 0x06015F81 RID: 89985 RVA: 0x0033250B File Offset: 0x0033070B
		[NullableContext(1)]
		public static RogueToken Create()
		{
			return new RogueToken();
		}

		// Token: 0x17004978 RID: 18808
		// (get) Token: 0x06015F82 RID: 89986 RVA: 0x00332512 File Offset: 0x00330712
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueToken> Parser
		{
			get
			{
				return RogueToken._parser;
			}
		}

		// Token: 0x17004979 RID: 18809
		// (get) Token: 0x06015F83 RID: 89987 RVA: 0x00332519 File Offset: 0x00330719
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700497A RID: 18810
		// (get) Token: 0x06015F84 RID: 89988 RVA: 0x0033251C File Offset: 0x0033071C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueToken.Descriptor;
			}
		}

		// Token: 0x06015F85 RID: 89989 RVA: 0x00332523 File Offset: 0x00330723
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueToken()
		{
		}

		// Token: 0x06015F86 RID: 89990 RVA: 0x0033252B File Offset: 0x0033072B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueToken(RogueToken other) : this()
		{
			this.id_ = other.id_;
			this.isReceive_ = other.isReceive_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015F87 RID: 89991 RVA: 0x0033255C File Offset: 0x0033075C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueToken Clone()
		{
			return new RogueToken(this);
		}

		// Token: 0x1700497B RID: 18811
		// (get) Token: 0x06015F88 RID: 89992 RVA: 0x00332564 File Offset: 0x00330764
		// (set) Token: 0x06015F89 RID: 89993 RVA: 0x0033256C File Offset: 0x0033076C
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

		// Token: 0x1700497C RID: 18812
		// (get) Token: 0x06015F8A RID: 89994 RVA: 0x00332575 File Offset: 0x00330775
		// (set) Token: 0x06015F8B RID: 89995 RVA: 0x0033257D File Offset: 0x0033077D
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

		// Token: 0x06015F8C RID: 89996 RVA: 0x00332586 File Offset: 0x00330786
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueToken);
		}

		// Token: 0x06015F8D RID: 89997 RVA: 0x00332594 File Offset: 0x00330794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueToken other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.IsReceive == other.IsReceive && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015F8E RID: 89998 RVA: 0x003325D4 File Offset: 0x003307D4
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

		// Token: 0x06015F8F RID: 89999 RVA: 0x0033262C File Offset: 0x0033082C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015F90 RID: 90000 RVA: 0x00332639 File Offset: 0x00330839
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015F91 RID: 90001 RVA: 0x00332644 File Offset: 0x00330844
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

		// Token: 0x06015F92 RID: 90002 RVA: 0x0033269C File Offset: 0x0033089C
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

		// Token: 0x06015F93 RID: 90003 RVA: 0x003326E8 File Offset: 0x003308E8
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

		// Token: 0x06015F94 RID: 90004 RVA: 0x00332738 File Offset: 0x00330938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015F95 RID: 90005 RVA: 0x00332744 File Offset: 0x00330944
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

		// Token: 0x04008446 RID: 33862
		private static readonly MessageParser<RogueToken> _parser = new MessageParser<RogueToken>(() => new RogueToken());

		// Token: 0x04008447 RID: 33863
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008448 RID: 33864
		public const int IdFieldNumber = 1;

		// Token: 0x04008449 RID: 33865
		private int id_;

		// Token: 0x0400844A RID: 33866
		public const int IsReceiveFieldNumber = 2;

		// Token: 0x0400844B RID: 33867
		private bool isReceive_;
	}
}
