using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000A0 RID: 160
	public sealed class AddCountItemInfo : IMessage<AddCountItemInfo>, IMessage, IEquatable<AddCountItemInfo>, IDeepCloneable<AddCountItemInfo>, IBufferMessage
	{
		// Token: 0x06001C3F RID: 7231 RVA: 0x0004E70B File Offset: 0x0004C90B
		[NullableContext(1)]
		public static AddCountItemInfo Create()
		{
			return new AddCountItemInfo();
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06001C40 RID: 7232 RVA: 0x0004E712 File Offset: 0x0004C912
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AddCountItemInfo> Parser
		{
			get
			{
				return AddCountItemInfo._parser;
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06001C41 RID: 7233 RVA: 0x0004E719 File Offset: 0x0004C919
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06001C42 RID: 7234 RVA: 0x0004E71C File Offset: 0x0004C91C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddCountItemInfo.Descriptor;
			}
		}

		// Token: 0x06001C43 RID: 7235 RVA: 0x0004E723 File Offset: 0x0004C923
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddCountItemInfo()
		{
		}

		// Token: 0x06001C44 RID: 7236 RVA: 0x0004E72B File Offset: 0x0004C92B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddCountItemInfo(AddCountItemInfo other) : this()
		{
			this.id_ = other.id_;
			this.count_ = other.count_;
			this.incrId_ = other.incrId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001C45 RID: 7237 RVA: 0x0004E768 File Offset: 0x0004C968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddCountItemInfo Clone()
		{
			return new AddCountItemInfo(this);
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06001C46 RID: 7238 RVA: 0x0004E770 File Offset: 0x0004C970
		// (set) Token: 0x06001C47 RID: 7239 RVA: 0x0004E778 File Offset: 0x0004C978
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

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06001C48 RID: 7240 RVA: 0x0004E781 File Offset: 0x0004C981
		// (set) Token: 0x06001C49 RID: 7241 RVA: 0x0004E789 File Offset: 0x0004C989
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

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06001C4A RID: 7242 RVA: 0x0004E792 File Offset: 0x0004C992
		// (set) Token: 0x06001C4B RID: 7243 RVA: 0x0004E79A File Offset: 0x0004C99A
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

		// Token: 0x06001C4C RID: 7244 RVA: 0x0004E7A3 File Offset: 0x0004C9A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddCountItemInfo);
		}

		// Token: 0x06001C4D RID: 7245 RVA: 0x0004E7B4 File Offset: 0x0004C9B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddCountItemInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Count == other.Count && this.IncrId == other.IncrId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001C4E RID: 7246 RVA: 0x0004E810 File Offset: 0x0004CA10
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

		// Token: 0x06001C4F RID: 7247 RVA: 0x0004E881 File Offset: 0x0004CA81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001C50 RID: 7248 RVA: 0x0004E88E File Offset: 0x0004CA8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001C51 RID: 7249 RVA: 0x0004E898 File Offset: 0x0004CA98
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

		// Token: 0x06001C52 RID: 7250 RVA: 0x0004E90C File Offset: 0x0004CB0C
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

		// Token: 0x06001C53 RID: 7251 RVA: 0x0004E97C File Offset: 0x0004CB7C
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

		// Token: 0x06001C54 RID: 7252 RVA: 0x0004E9E0 File Offset: 0x0004CBE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001C55 RID: 7253 RVA: 0x0004E9EC File Offset: 0x0004CBEC
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

		// Token: 0x040022CF RID: 8911
		private static readonly MessageParser<AddCountItemInfo> _parser = new MessageParser<AddCountItemInfo>(() => new AddCountItemInfo());

		// Token: 0x040022D0 RID: 8912
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022D1 RID: 8913
		public const int IdFieldNumber = 1;

		// Token: 0x040022D2 RID: 8914
		private int id_;

		// Token: 0x040022D3 RID: 8915
		public const int CountFieldNumber = 2;

		// Token: 0x040022D4 RID: 8916
		private int count_;

		// Token: 0x040022D5 RID: 8917
		public const int IncrIdFieldNumber = 3;

		// Token: 0x040022D6 RID: 8918
		private int incrId_;
	}
}
