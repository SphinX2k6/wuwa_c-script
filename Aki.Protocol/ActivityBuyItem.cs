using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000082 RID: 130
	public sealed class ActivityBuyItem : IMessage<ActivityBuyItem>, IMessage, IEquatable<ActivityBuyItem>, IDeepCloneable<ActivityBuyItem>, IBufferMessage
	{
		// Token: 0x06001912 RID: 6418 RVA: 0x000415D3 File Offset: 0x0003F7D3
		[NullableContext(1)]
		public static ActivityBuyItem Create()
		{
			return new ActivityBuyItem();
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06001913 RID: 6419 RVA: 0x000415DA File Offset: 0x0003F7DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ActivityBuyItem> Parser
		{
			get
			{
				return ActivityBuyItem._parser;
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06001914 RID: 6420 RVA: 0x000415E1 File Offset: 0x0003F7E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06001915 RID: 6421 RVA: 0x000415E4 File Offset: 0x0003F7E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivityBuyItem.Descriptor;
			}
		}

		// Token: 0x06001916 RID: 6422 RVA: 0x000415EB File Offset: 0x0003F7EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityBuyItem()
		{
		}

		// Token: 0x06001917 RID: 6423 RVA: 0x000415F3 File Offset: 0x0003F7F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityBuyItem(ActivityBuyItem other) : this()
		{
			this.id_ = other.id_;
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001918 RID: 6424 RVA: 0x00041624 File Offset: 0x0003F824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityBuyItem Clone()
		{
			return new ActivityBuyItem(this);
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06001919 RID: 6425 RVA: 0x0004162C File Offset: 0x0003F82C
		// (set) Token: 0x0600191A RID: 6426 RVA: 0x00041634 File Offset: 0x0003F834
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

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x0600191B RID: 6427 RVA: 0x0004163D File Offset: 0x0003F83D
		// (set) Token: 0x0600191C RID: 6428 RVA: 0x00041645 File Offset: 0x0003F845
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

		// Token: 0x0600191D RID: 6429 RVA: 0x0004164E File Offset: 0x0003F84E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivityBuyItem);
		}

		// Token: 0x0600191E RID: 6430 RVA: 0x0004165C File Offset: 0x0003F85C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivityBuyItem other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Count == other.Count && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600191F RID: 6431 RVA: 0x0004169C File Offset: 0x0003F89C
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

		// Token: 0x06001920 RID: 6432 RVA: 0x000416F4 File Offset: 0x0003F8F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001921 RID: 6433 RVA: 0x00041701 File Offset: 0x0003F901
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001922 RID: 6434 RVA: 0x0004170C File Offset: 0x0003F90C
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

		// Token: 0x06001923 RID: 6435 RVA: 0x00041764 File Offset: 0x0003F964
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

		// Token: 0x06001924 RID: 6436 RVA: 0x000417BC File Offset: 0x0003F9BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActivityBuyItem other)
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

		// Token: 0x06001925 RID: 6437 RVA: 0x0004180C File Offset: 0x0003FA0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001926 RID: 6438 RVA: 0x00041818 File Offset: 0x0003FA18
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

		// Token: 0x040021F5 RID: 8693
		private static readonly MessageParser<ActivityBuyItem> _parser = new MessageParser<ActivityBuyItem>(() => new ActivityBuyItem());

		// Token: 0x040021F6 RID: 8694
		private UnknownFieldSet _unknownFields;

		// Token: 0x040021F7 RID: 8695
		public const int IdFieldNumber = 1;

		// Token: 0x040021F8 RID: 8696
		private int id_;

		// Token: 0x040021F9 RID: 8697
		public const int CountFieldNumber = 2;

		// Token: 0x040021FA RID: 8698
		private int count_;
	}
}
