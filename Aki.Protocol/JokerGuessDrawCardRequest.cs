using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200086A RID: 2154
	[NetMessage(EMessageId.JokerGuessDrawCardRequest)]
	public sealed class JokerGuessDrawCardRequest : IMessage<JokerGuessDrawCardRequest>, IMessage, IEquatable<JokerGuessDrawCardRequest>, IDeepCloneable<JokerGuessDrawCardRequest>, IBufferMessage
	{
		// Token: 0x0600BFDD RID: 49117 RVA: 0x001C79CA File Offset: 0x001C5BCA
		[NullableContext(1)]
		public static JokerGuessDrawCardRequest Create()
		{
			return new JokerGuessDrawCardRequest();
		}

		// Token: 0x170026BF RID: 9919
		// (get) Token: 0x0600BFDE RID: 49118 RVA: 0x001C79D1 File Offset: 0x001C5BD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170026C0 RID: 9920
		// (get) Token: 0x0600BFDF RID: 49119 RVA: 0x001C79D4 File Offset: 0x001C5BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JokerGuessDrawCardRequest.Descriptor;
			}
		}

		// Token: 0x0600BFE0 RID: 49120 RVA: 0x001C79DB File Offset: 0x001C5BDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessDrawCardRequest()
		{
		}

		// Token: 0x0600BFE1 RID: 49121 RVA: 0x001C79E3 File Offset: 0x001C5BE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessDrawCardRequest(JokerGuessDrawCardRequest other) : this()
		{
			this.targetCardId_ = other.targetCardId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BFE2 RID: 49122 RVA: 0x001C7A08 File Offset: 0x001C5C08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessDrawCardRequest Clone()
		{
			return new JokerGuessDrawCardRequest(this);
		}

		// Token: 0x170026C1 RID: 9921
		// (get) Token: 0x0600BFE3 RID: 49123 RVA: 0x001C7A10 File Offset: 0x001C5C10
		// (set) Token: 0x0600BFE4 RID: 49124 RVA: 0x001C7A18 File Offset: 0x001C5C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetCardId
		{
			get
			{
				return this.targetCardId_;
			}
			set
			{
				this.targetCardId_ = value;
			}
		}

		// Token: 0x0600BFE5 RID: 49125 RVA: 0x001C7A21 File Offset: 0x001C5C21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JokerGuessDrawCardRequest);
		}

		// Token: 0x0600BFE6 RID: 49126 RVA: 0x001C7A2F File Offset: 0x001C5C2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JokerGuessDrawCardRequest other)
		{
			return other != null && (other == this || (this.TargetCardId == other.TargetCardId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BFE7 RID: 49127 RVA: 0x001C7A60 File Offset: 0x001C5C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TargetCardId != 0)
			{
				num ^= this.TargetCardId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BFE8 RID: 49128 RVA: 0x001C7A9F File Offset: 0x001C5C9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BFE9 RID: 49129 RVA: 0x001C7AAC File Offset: 0x001C5CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BFEA RID: 49130 RVA: 0x001C7AB5 File Offset: 0x001C5CB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetCardId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.TargetCardId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BFEB RID: 49131 RVA: 0x001C7AE8 File Offset: 0x001C5CE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TargetCardId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetCardId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BFEC RID: 49132 RVA: 0x001C7B26 File Offset: 0x001C5D26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JokerGuessDrawCardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TargetCardId != 0)
			{
				this.TargetCardId = other.TargetCardId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BFED RID: 49133 RVA: 0x001C7B57 File Offset: 0x001C5D57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BFEE RID: 49134 RVA: 0x001C7B60 File Offset: 0x001C5D60
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TargetCardId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005372 RID: 21362
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005373 RID: 21363
		public const int TargetCardIdFieldNumber = 4;

		// Token: 0x04005374 RID: 21364
		private int targetCardId_;
	}
}
