using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000A1 RID: 161
	public sealed class AddCountItemInfo : IMessage<AddCountItemInfo>, IMessage, IEquatable<AddCountItemInfo>, IDeepCloneable<AddCountItemInfo>, IBufferMessage
	{
		// Token: 0x06001C86 RID: 7302 RVA: 0x0004F31B File Offset: 0x0004D51B
		[NullableContext(1)]
		public static AddCountItemInfo Create()
		{
			return new AddCountItemInfo();
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06001C87 RID: 7303 RVA: 0x0004F322 File Offset: 0x0004D522
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AddCountItemInfo> Parser
		{
			get
			{
				return AddCountItemInfo._parser;
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06001C88 RID: 7304 RVA: 0x0004F329 File Offset: 0x0004D529
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06001C89 RID: 7305 RVA: 0x0004F32C File Offset: 0x0004D52C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddCountItemInfo.Descriptor;
			}
		}

		// Token: 0x06001C8A RID: 7306 RVA: 0x0004F333 File Offset: 0x0004D533
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddCountItemInfo()
		{
		}

		// Token: 0x06001C8B RID: 7307 RVA: 0x0004F33B File Offset: 0x0004D53B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddCountItemInfo(AddCountItemInfo other) : this()
		{
			this.id_ = other.id_;
			this.count_ = other.count_;
			this.incrId_ = other.incrId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001C8C RID: 7308 RVA: 0x0004F378 File Offset: 0x0004D578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddCountItemInfo Clone()
		{
			return new AddCountItemInfo(this);
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06001C8D RID: 7309 RVA: 0x0004F380 File Offset: 0x0004D580
		// (set) Token: 0x06001C8E RID: 7310 RVA: 0x0004F388 File Offset: 0x0004D588
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

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06001C8F RID: 7311 RVA: 0x0004F391 File Offset: 0x0004D591
		// (set) Token: 0x06001C90 RID: 7312 RVA: 0x0004F399 File Offset: 0x0004D599
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

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06001C91 RID: 7313 RVA: 0x0004F3A2 File Offset: 0x0004D5A2
		// (set) Token: 0x06001C92 RID: 7314 RVA: 0x0004F3AA File Offset: 0x0004D5AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncrId
		{
			get
			{
				return this.incrId_;
			}
			set
			{
				this.incrId_ = value;
			}
		}

		// Token: 0x06001C93 RID: 7315 RVA: 0x0004F3B3 File Offset: 0x0004D5B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddCountItemInfo);
		}

		// Token: 0x06001C94 RID: 7316 RVA: 0x0004F3C4 File Offset: 0x0004D5C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddCountItemInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Count == other.Count && this.IncrId == other.IncrId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001C95 RID: 7317 RVA: 0x0004F420 File Offset: 0x0004D620
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
			if (this.IncrId != 0)
			{
				num ^= this.IncrId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001C96 RID: 7318 RVA: 0x0004F491 File Offset: 0x0004D691
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001C97 RID: 7319 RVA: 0x0004F49E File Offset: 0x0004D69E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001C98 RID: 7320 RVA: 0x0004F4A8 File Offset: 0x0004D6A8
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
			if (this.IncrId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.IncrId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001C99 RID: 7321 RVA: 0x0004F51C File Offset: 0x0004D71C
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
			if (this.IncrId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncrId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001C9A RID: 7322 RVA: 0x0004F58C File Offset: 0x0004D78C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AddCountItemInfo other)
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
			if (other.IncrId != 0)
			{
				this.IncrId = other.IncrId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001C9B RID: 7323 RVA: 0x0004F5F0 File Offset: 0x0004D7F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001C9C RID: 7324 RVA: 0x0004F5FC File Offset: 0x0004D7FC
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IncrId = input.ReadInt32();
						}
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

		// Token: 0x04002330 RID: 9008
		private static readonly MessageParser<AddCountItemInfo> _parser = new MessageParser<AddCountItemInfo>(() => new AddCountItemInfo());

		// Token: 0x04002331 RID: 9009
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002332 RID: 9010
		public const int IdFieldNumber = 1;

		// Token: 0x04002333 RID: 9011
		private int id_;

		// Token: 0x04002334 RID: 9012
		public const int CountFieldNumber = 2;

		// Token: 0x04002335 RID: 9013
		private int count_;

		// Token: 0x04002336 RID: 9014
		public const int IncrIdFieldNumber = 3;

		// Token: 0x04002337 RID: 9015
		private int incrId_;
	}
}
