using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C07 RID: 3079
	public sealed class PbMailAttachment : IMessage<PbMailAttachment>, IMessage, IEquatable<PbMailAttachment>, IDeepCloneable<PbMailAttachment>, IBufferMessage
	{
		// Token: 0x06010B6B RID: 68459 RVA: 0x00272752 File Offset: 0x00270952
		[NullableContext(1)]
		public static PbMailAttachment Create()
		{
			return new PbMailAttachment();
		}

		// Token: 0x17003720 RID: 14112
		// (get) Token: 0x06010B6C RID: 68460 RVA: 0x00272759 File Offset: 0x00270959
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PbMailAttachment> Parser
		{
			get
			{
				return PbMailAttachment._parser;
			}
		}

		// Token: 0x17003721 RID: 14113
		// (get) Token: 0x06010B6D RID: 68461 RVA: 0x00272760 File Offset: 0x00270960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003722 RID: 14114
		// (get) Token: 0x06010B6E RID: 68462 RVA: 0x00272763 File Offset: 0x00270963
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PbMailAttachment.Descriptor;
			}
		}

		// Token: 0x06010B6F RID: 68463 RVA: 0x0027276A File Offset: 0x0027096A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbMailAttachment()
		{
		}

		// Token: 0x06010B70 RID: 68464 RVA: 0x00272772 File Offset: 0x00270972
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbMailAttachment(PbMailAttachment other) : this()
		{
			this.id_ = other.id_;
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010B71 RID: 68465 RVA: 0x002727A3 File Offset: 0x002709A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbMailAttachment Clone()
		{
			return new PbMailAttachment(this);
		}

		// Token: 0x17003723 RID: 14115
		// (get) Token: 0x06010B72 RID: 68466 RVA: 0x002727AB File Offset: 0x002709AB
		// (set) Token: 0x06010B73 RID: 68467 RVA: 0x002727B3 File Offset: 0x002709B3
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

		// Token: 0x17003724 RID: 14116
		// (get) Token: 0x06010B74 RID: 68468 RVA: 0x002727BC File Offset: 0x002709BC
		// (set) Token: 0x06010B75 RID: 68469 RVA: 0x002727C4 File Offset: 0x002709C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x06010B76 RID: 68470 RVA: 0x002727CD File Offset: 0x002709CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PbMailAttachment);
		}

		// Token: 0x06010B77 RID: 68471 RVA: 0x002727DB File Offset: 0x002709DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PbMailAttachment other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Count == other.Count && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010B78 RID: 68472 RVA: 0x0027281C File Offset: 0x00270A1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010B79 RID: 68473 RVA: 0x00272874 File Offset: 0x00270A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010B7A RID: 68474 RVA: 0x00272881 File Offset: 0x00270A81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010B7B RID: 68475 RVA: 0x0027288C File Offset: 0x00270A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Count);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010B7C RID: 68476 RVA: 0x002728E4 File Offset: 0x00270AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010B7D RID: 68477 RVA: 0x0027293C File Offset: 0x00270B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PbMailAttachment other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010B7E RID: 68478 RVA: 0x0027298C File Offset: 0x00270B8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010B7F RID: 68479 RVA: 0x00272998 File Offset: 0x00270B98
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
						this.Count = input.ReadInt32();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006A33 RID: 27187
		private static readonly MessageParser<PbMailAttachment> _parser = new MessageParser<PbMailAttachment>(() => new PbMailAttachment());

		// Token: 0x04006A34 RID: 27188
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006A35 RID: 27189
		public const int IdFieldNumber = 1;

		// Token: 0x04006A36 RID: 27190
		private int id_;

		// Token: 0x04006A37 RID: 27191
		public const int CountFieldNumber = 2;

		// Token: 0x04006A38 RID: 27192
		private int count_;
	}
}
