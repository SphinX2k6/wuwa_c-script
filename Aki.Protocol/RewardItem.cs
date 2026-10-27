using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F33 RID: 3891
	public sealed class RewardItem : IMessage<RewardItem>, IMessage, IEquatable<RewardItem>, IDeepCloneable<RewardItem>, IBufferMessage
	{
		// Token: 0x06014D24 RID: 85284 RVA: 0x003055A4 File Offset: 0x003037A4
		[NullableContext(1)]
		public static RewardItem Create()
		{
			return new RewardItem();
		}

		// Token: 0x17004537 RID: 17719
		// (get) Token: 0x06014D25 RID: 85285 RVA: 0x003055AB File Offset: 0x003037AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RewardItem> Parser
		{
			get
			{
				return RewardItem._parser;
			}
		}

		// Token: 0x17004538 RID: 17720
		// (get) Token: 0x06014D26 RID: 85286 RVA: 0x003055B2 File Offset: 0x003037B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004539 RID: 17721
		// (get) Token: 0x06014D27 RID: 85287 RVA: 0x003055B5 File Offset: 0x003037B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RewardItem.Descriptor;
			}
		}

		// Token: 0x06014D28 RID: 85288 RVA: 0x003055BC File Offset: 0x003037BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RewardItem()
		{
		}

		// Token: 0x06014D29 RID: 85289 RVA: 0x003055C4 File Offset: 0x003037C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RewardItem(RewardItem other) : this()
		{
			this.id_ = other.id_;
			this.count_ = other.count_;
			this.incrId_ = other.incrId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014D2A RID: 85290 RVA: 0x00305601 File Offset: 0x00303801
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RewardItem Clone()
		{
			return new RewardItem(this);
		}

		// Token: 0x1700453A RID: 17722
		// (get) Token: 0x06014D2B RID: 85291 RVA: 0x00305609 File Offset: 0x00303809
		// (set) Token: 0x06014D2C RID: 85292 RVA: 0x00305611 File Offset: 0x00303811
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

		// Token: 0x1700453B RID: 17723
		// (get) Token: 0x06014D2D RID: 85293 RVA: 0x0030561A File Offset: 0x0030381A
		// (set) Token: 0x06014D2E RID: 85294 RVA: 0x00305622 File Offset: 0x00303822
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

		// Token: 0x1700453C RID: 17724
		// (get) Token: 0x06014D2F RID: 85295 RVA: 0x0030562B File Offset: 0x0030382B
		// (set) Token: 0x06014D30 RID: 85296 RVA: 0x00305633 File Offset: 0x00303833
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

		// Token: 0x06014D31 RID: 85297 RVA: 0x0030563C File Offset: 0x0030383C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RewardItem);
		}

		// Token: 0x06014D32 RID: 85298 RVA: 0x0030564C File Offset: 0x0030384C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RewardItem other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Count == other.Count && this.IncrId == other.IncrId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014D33 RID: 85299 RVA: 0x003056A8 File Offset: 0x003038A8
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

		// Token: 0x06014D34 RID: 85300 RVA: 0x00305719 File Offset: 0x00303919
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014D35 RID: 85301 RVA: 0x00305726 File Offset: 0x00303926
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014D36 RID: 85302 RVA: 0x00305730 File Offset: 0x00303930
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

		// Token: 0x06014D37 RID: 85303 RVA: 0x003057A4 File Offset: 0x003039A4
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

		// Token: 0x06014D38 RID: 85304 RVA: 0x00305814 File Offset: 0x00303A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RewardItem other)
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

		// Token: 0x06014D39 RID: 85305 RVA: 0x00305878 File Offset: 0x00303A78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014D3A RID: 85306 RVA: 0x00305884 File Offset: 0x00303A84
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

		// Token: 0x04007DA7 RID: 32167
		private static readonly MessageParser<RewardItem> _parser = new MessageParser<RewardItem>(() => new RewardItem());

		// Token: 0x04007DA8 RID: 32168
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007DA9 RID: 32169
		public const int IdFieldNumber = 1;

		// Token: 0x04007DAA RID: 32170
		private int id_;

		// Token: 0x04007DAB RID: 32171
		public const int CountFieldNumber = 2;

		// Token: 0x04007DAC RID: 32172
		private int count_;

		// Token: 0x04007DAD RID: 32173
		public const int IncrIdFieldNumber = 3;

		// Token: 0x04007DAE RID: 32174
		private int incrId_;
	}
}
