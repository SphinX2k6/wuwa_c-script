using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200068C RID: 1676
	public sealed class GachaReward : IMessage<GachaReward>, IMessage, IEquatable<GachaReward>, IDeepCloneable<GachaReward>, IBufferMessage
	{
		// Token: 0x060099E6 RID: 39398 RVA: 0x00173E99 File Offset: 0x00172099
		[NullableContext(1)]
		public static GachaReward Create()
		{
			return new GachaReward();
		}

		// Token: 0x17001EC6 RID: 7878
		// (get) Token: 0x060099E7 RID: 39399 RVA: 0x00173EA0 File Offset: 0x001720A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GachaReward> Parser
		{
			get
			{
				return GachaReward._parser;
			}
		}

		// Token: 0x17001EC7 RID: 7879
		// (get) Token: 0x060099E8 RID: 39400 RVA: 0x00173EA7 File Offset: 0x001720A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001EC8 RID: 7880
		// (get) Token: 0x060099E9 RID: 39401 RVA: 0x00173EAA File Offset: 0x001720AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaReward.Descriptor;
			}
		}

		// Token: 0x060099EA RID: 39402 RVA: 0x00173EB1 File Offset: 0x001720B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaReward()
		{
		}

		// Token: 0x060099EB RID: 39403 RVA: 0x00173EB9 File Offset: 0x001720B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaReward(GachaReward other) : this()
		{
			this.itemId_ = other.itemId_;
			this.itemCount_ = other.itemCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060099EC RID: 39404 RVA: 0x00173EEA File Offset: 0x001720EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaReward Clone()
		{
			return new GachaReward(this);
		}

		// Token: 0x17001EC9 RID: 7881
		// (get) Token: 0x060099ED RID: 39405 RVA: 0x00173EF2 File Offset: 0x001720F2
		// (set) Token: 0x060099EE RID: 39406 RVA: 0x00173EFA File Offset: 0x001720FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x17001ECA RID: 7882
		// (get) Token: 0x060099EF RID: 39407 RVA: 0x00173F03 File Offset: 0x00172103
		// (set) Token: 0x060099F0 RID: 39408 RVA: 0x00173F0B File Offset: 0x0017210B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemCount
		{
			get
			{
				return this.itemCount_;
			}
			set
			{
				this.itemCount_ = value;
			}
		}

		// Token: 0x060099F1 RID: 39409 RVA: 0x00173F14 File Offset: 0x00172114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaReward);
		}

		// Token: 0x060099F2 RID: 39410 RVA: 0x00173F22 File Offset: 0x00172122
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaReward other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.ItemCount == other.ItemCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060099F3 RID: 39411 RVA: 0x00173F60 File Offset: 0x00172160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.ItemCount != 0)
			{
				num ^= this.ItemCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060099F4 RID: 39412 RVA: 0x00173FB8 File Offset: 0x001721B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060099F5 RID: 39413 RVA: 0x00173FC5 File Offset: 0x001721C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060099F6 RID: 39414 RVA: 0x00173FD0 File Offset: 0x001721D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemId);
			}
			if (this.ItemCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ItemCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060099F7 RID: 39415 RVA: 0x00174028 File Offset: 0x00172228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.ItemCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060099F8 RID: 39416 RVA: 0x00174080 File Offset: 0x00172280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GachaReward other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.ItemCount != 0)
			{
				this.ItemCount = other.ItemCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060099F9 RID: 39417 RVA: 0x001740D0 File Offset: 0x001722D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060099FA RID: 39418 RVA: 0x001740DC File Offset: 0x001722DC
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
						this.ItemCount = input.ReadInt32();
					}
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004950 RID: 18768
		private static readonly MessageParser<GachaReward> _parser = new MessageParser<GachaReward>(() => new GachaReward());

		// Token: 0x04004951 RID: 18769
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004952 RID: 18770
		public const int ItemIdFieldNumber = 1;

		// Token: 0x04004953 RID: 18771
		private int itemId_;

		// Token: 0x04004954 RID: 18772
		public const int ItemCountFieldNumber = 2;

		// Token: 0x04004955 RID: 18773
		private int itemCount_;
	}
}
