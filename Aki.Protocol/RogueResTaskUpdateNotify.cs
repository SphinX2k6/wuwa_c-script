using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FFF RID: 4095
	[NetMessage(EMessageId.RogueResTaskUpdateNotify)]
	public sealed class RogueResTaskUpdateNotify : IMessage<RogueResTaskUpdateNotify>, IMessage, IEquatable<RogueResTaskUpdateNotify>, IDeepCloneable<RogueResTaskUpdateNotify>, IBufferMessage
	{
		// Token: 0x06015ECC RID: 89804 RVA: 0x003309ED File Offset: 0x0032EBED
		[NullableContext(1)]
		public static RogueResTaskUpdateNotify Create()
		{
			return new RogueResTaskUpdateNotify();
		}

		// Token: 0x1700494D RID: 18765
		// (get) Token: 0x06015ECD RID: 89805 RVA: 0x003309F4 File Offset: 0x0032EBF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700494E RID: 18766
		// (get) Token: 0x06015ECE RID: 89806 RVA: 0x003309F7 File Offset: 0x0032EBF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResTaskUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06015ECF RID: 89807 RVA: 0x003309FE File Offset: 0x0032EBFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResTaskUpdateNotify()
		{
		}

		// Token: 0x06015ED0 RID: 89808 RVA: 0x00330A06 File Offset: 0x0032EC06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResTaskUpdateNotify(RogueResTaskUpdateNotify other) : this()
		{
			this.rogueResBranchTaskTheme_ = ((other.rogueResBranchTaskTheme_ != null) ? other.rogueResBranchTaskTheme_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015ED1 RID: 89809 RVA: 0x00330A3B File Offset: 0x0032EC3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResTaskUpdateNotify Clone()
		{
			return new RogueResTaskUpdateNotify(this);
		}

		// Token: 0x1700494F RID: 18767
		// (get) Token: 0x06015ED2 RID: 89810 RVA: 0x00330A43 File Offset: 0x0032EC43
		// (set) Token: 0x06015ED3 RID: 89811 RVA: 0x00330A4B File Offset: 0x0032EC4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResBranchTaskTheme RogueResBranchTaskTheme
		{
			get
			{
				return this.rogueResBranchTaskTheme_;
			}
			set
			{
				this.rogueResBranchTaskTheme_ = value;
			}
		}

		// Token: 0x06015ED4 RID: 89812 RVA: 0x00330A54 File Offset: 0x0032EC54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResTaskUpdateNotify);
		}

		// Token: 0x06015ED5 RID: 89813 RVA: 0x00330A62 File Offset: 0x0032EC62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResTaskUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.RogueResBranchTaskTheme, other.RogueResBranchTaskTheme) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015ED6 RID: 89814 RVA: 0x00330A98 File Offset: 0x0032EC98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rogueResBranchTaskTheme_ != null)
			{
				num ^= this.RogueResBranchTaskTheme.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015ED7 RID: 89815 RVA: 0x00330AD4 File Offset: 0x0032ECD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015ED8 RID: 89816 RVA: 0x00330AE1 File Offset: 0x0032ECE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015ED9 RID: 89817 RVA: 0x00330AEA File Offset: 0x0032ECEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueResBranchTaskTheme_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.RogueResBranchTaskTheme);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015EDA RID: 89818 RVA: 0x00330B1C File Offset: 0x0032ED1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rogueResBranchTaskTheme_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueResBranchTaskTheme);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015EDB RID: 89819 RVA: 0x00330B5C File Offset: 0x0032ED5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResTaskUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rogueResBranchTaskTheme_ != null)
			{
				if (this.rogueResBranchTaskTheme_ == null)
				{
					this.RogueResBranchTaskTheme = new RogueResBranchTaskTheme();
				}
				this.RogueResBranchTaskTheme.MergeFrom(other.RogueResBranchTaskTheme);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015EDC RID: 89820 RVA: 0x00330BB0 File Offset: 0x0032EDB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015EDD RID: 89821 RVA: 0x00330BBC File Offset: 0x0032EDBC
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
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.rogueResBranchTaskTheme_ == null)
					{
						this.RogueResBranchTaskTheme = new RogueResBranchTaskTheme();
					}
					input.ReadMessage(this.RogueResBranchTaskTheme);
				}
			}
		}

		// Token: 0x04008406 RID: 33798
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008407 RID: 33799
		public const int RogueResBranchTaskThemeFieldNumber = 13;

		// Token: 0x04008408 RID: 33800
		private RogueResBranchTaskTheme rogueResBranchTaskTheme_;
	}
}
