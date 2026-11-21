using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FB3 RID: 4019
	public sealed class RoguelikeToken : IMessage<RoguelikeToken>, IMessage, IEquatable<RoguelikeToken>, IDeepCloneable<RoguelikeToken>, IBufferMessage
	{
		// Token: 0x0601583F RID: 88127 RVA: 0x00320235 File Offset: 0x0031E435
		[NullableContext(1)]
		public static RoguelikeToken Create()
		{
			return new RoguelikeToken();
		}

		// Token: 0x170047C3 RID: 18371
		// (get) Token: 0x06015840 RID: 88128 RVA: 0x0032023C File Offset: 0x0031E43C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoguelikeToken> Parser
		{
			get
			{
				return RoguelikeToken._parser;
			}
		}

		// Token: 0x170047C4 RID: 18372
		// (get) Token: 0x06015841 RID: 88129 RVA: 0x00320243 File Offset: 0x0031E443
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170047C5 RID: 18373
		// (get) Token: 0x06015842 RID: 88130 RVA: 0x00320246 File Offset: 0x0031E446
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeToken.Descriptor;
			}
		}

		// Token: 0x06015843 RID: 88131 RVA: 0x0032024D File Offset: 0x0031E44D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeToken()
		{
		}

		// Token: 0x06015844 RID: 88132 RVA: 0x00320255 File Offset: 0x0031E455
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeToken(RoguelikeToken other) : this()
		{
			this.id_ = other.id_;
			this.isReceive_ = other.isReceive_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015845 RID: 88133 RVA: 0x00320286 File Offset: 0x0031E486
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeToken Clone()
		{
			return new RoguelikeToken(this);
		}

		// Token: 0x170047C6 RID: 18374
		// (get) Token: 0x06015846 RID: 88134 RVA: 0x0032028E File Offset: 0x0031E48E
		// (set) Token: 0x06015847 RID: 88135 RVA: 0x00320296 File Offset: 0x0031E496
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

		// Token: 0x170047C7 RID: 18375
		// (get) Token: 0x06015848 RID: 88136 RVA: 0x0032029F File Offset: 0x0031E49F
		// (set) Token: 0x06015849 RID: 88137 RVA: 0x003202A7 File Offset: 0x0031E4A7
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

		// Token: 0x0601584A RID: 88138 RVA: 0x003202B0 File Offset: 0x0031E4B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeToken);
		}

		// Token: 0x0601584B RID: 88139 RVA: 0x003202BE File Offset: 0x0031E4BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeToken other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.IsReceive == other.IsReceive && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601584C RID: 88140 RVA: 0x003202FC File Offset: 0x0031E4FC
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

		// Token: 0x0601584D RID: 88141 RVA: 0x00320354 File Offset: 0x0031E554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601584E RID: 88142 RVA: 0x00320361 File Offset: 0x0031E561
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601584F RID: 88143 RVA: 0x0032036C File Offset: 0x0031E56C
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

		// Token: 0x06015850 RID: 88144 RVA: 0x003203C4 File Offset: 0x0031E5C4
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

		// Token: 0x06015851 RID: 88145 RVA: 0x00320410 File Offset: 0x0031E610
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

		// Token: 0x06015852 RID: 88146 RVA: 0x00320460 File Offset: 0x0031E660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015853 RID: 88147 RVA: 0x0032046C File Offset: 0x0031E66C
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

		// Token: 0x040081C1 RID: 33217
		private static readonly MessageParser<RoguelikeToken> _parser = new MessageParser<RoguelikeToken>(() => new RoguelikeToken());

		// Token: 0x040081C2 RID: 33218
		private UnknownFieldSet _unknownFields;

		// Token: 0x040081C3 RID: 33219
		public const int IdFieldNumber = 1;

		// Token: 0x040081C4 RID: 33220
		private int id_;

		// Token: 0x040081C5 RID: 33221
		public const int IsReceiveFieldNumber = 2;

		// Token: 0x040081C6 RID: 33222
		private bool isReceive_;
	}
}
