using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200008A RID: 138
	public sealed class ActivityLinkageReward : IMessage<ActivityLinkageReward>, IMessage, IEquatable<ActivityLinkageReward>, IDeepCloneable<ActivityLinkageReward>, IBufferMessage
	{
		// Token: 0x06001ABB RID: 6843 RVA: 0x0004B863 File Offset: 0x00049A63
		[NullableContext(1)]
		public static ActivityLinkageReward Create()
		{
			return new ActivityLinkageReward();
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06001ABC RID: 6844 RVA: 0x0004B86A File Offset: 0x00049A6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ActivityLinkageReward> Parser
		{
			get
			{
				return ActivityLinkageReward._parser;
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06001ABD RID: 6845 RVA: 0x0004B871 File Offset: 0x00049A71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06001ABE RID: 6846 RVA: 0x0004B874 File Offset: 0x00049A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivityLinkageReward.Descriptor;
			}
		}

		// Token: 0x06001ABF RID: 6847 RVA: 0x0004B87B File Offset: 0x00049A7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityLinkageReward()
		{
		}

		// Token: 0x06001AC0 RID: 6848 RVA: 0x0004B883 File Offset: 0x00049A83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityLinkageReward(ActivityLinkageReward other) : this()
		{
			this.itemId_ = other.itemId_;
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001AC1 RID: 6849 RVA: 0x0004B8B4 File Offset: 0x00049AB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityLinkageReward Clone()
		{
			return new ActivityLinkageReward(this);
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06001AC2 RID: 6850 RVA: 0x0004B8BC File Offset: 0x00049ABC
		// (set) Token: 0x06001AC3 RID: 6851 RVA: 0x0004B8C4 File Offset: 0x00049AC4
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

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06001AC4 RID: 6852 RVA: 0x0004B8CD File Offset: 0x00049ACD
		// (set) Token: 0x06001AC5 RID: 6853 RVA: 0x0004B8D5 File Offset: 0x00049AD5
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

		// Token: 0x06001AC6 RID: 6854 RVA: 0x0004B8DE File Offset: 0x00049ADE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivityLinkageReward);
		}

		// Token: 0x06001AC7 RID: 6855 RVA: 0x0004B8EC File Offset: 0x00049AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivityLinkageReward other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.Count == other.Count && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001AC8 RID: 6856 RVA: 0x0004B92C File Offset: 0x00049B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
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

		// Token: 0x06001AC9 RID: 6857 RVA: 0x0004B984 File Offset: 0x00049B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001ACA RID: 6858 RVA: 0x0004B991 File Offset: 0x00049B91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001ACB RID: 6859 RVA: 0x0004B99C File Offset: 0x00049B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemId);
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

		// Token: 0x06001ACC RID: 6860 RVA: 0x0004B9F4 File Offset: 0x00049BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
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

		// Token: 0x06001ACD RID: 6861 RVA: 0x0004BA4C File Offset: 0x00049C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActivityLinkageReward other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001ACE RID: 6862 RVA: 0x0004BA9C File Offset: 0x00049C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001ACF RID: 6863 RVA: 0x0004BAA8 File Offset: 0x00049CA8
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
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040022B7 RID: 8887
		private static readonly MessageParser<ActivityLinkageReward> _parser = new MessageParser<ActivityLinkageReward>(() => new ActivityLinkageReward());

		// Token: 0x040022B8 RID: 8888
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022B9 RID: 8889
		public const int ItemIdFieldNumber = 1;

		// Token: 0x040022BA RID: 8890
		private int itemId_;

		// Token: 0x040022BB RID: 8891
		public const int CountFieldNumber = 2;

		// Token: 0x040022BC RID: 8892
		private int count_;
	}
}
