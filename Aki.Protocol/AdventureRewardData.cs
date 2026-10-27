using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000C1 RID: 193
	public sealed class AdventureRewardData : IMessage<AdventureRewardData>, IMessage, IEquatable<AdventureRewardData>, IDeepCloneable<AdventureRewardData>, IBufferMessage
	{
		// Token: 0x06001EDC RID: 7900 RVA: 0x000544B2 File Offset: 0x000526B2
		[NullableContext(1)]
		public static AdventureRewardData Create()
		{
			return new AdventureRewardData();
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06001EDD RID: 7901 RVA: 0x000544B9 File Offset: 0x000526B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AdventureRewardData> Parser
		{
			get
			{
				return AdventureRewardData._parser;
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06001EDE RID: 7902 RVA: 0x000544C0 File Offset: 0x000526C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06001EDF RID: 7903 RVA: 0x000544C3 File Offset: 0x000526C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdventureRewardData.Descriptor;
			}
		}

		// Token: 0x06001EE0 RID: 7904 RVA: 0x000544CA File Offset: 0x000526CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureRewardData()
		{
		}

		// Token: 0x06001EE1 RID: 7905 RVA: 0x000544DD File Offset: 0x000526DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureRewardData(AdventureRewardData other) : this()
		{
			this.dropId_ = other.dropId_;
			this.items_ = other.items_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001EE2 RID: 7906 RVA: 0x00054513 File Offset: 0x00052713
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureRewardData Clone()
		{
			return new AdventureRewardData(this);
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06001EE3 RID: 7907 RVA: 0x0005451B File Offset: 0x0005271B
		// (set) Token: 0x06001EE4 RID: 7908 RVA: 0x00054523 File Offset: 0x00052723
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DropId
		{
			get
			{
				return this.dropId_;
			}
			set
			{
				this.dropId_ = value;
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06001EE5 RID: 7909 RVA: 0x0005452C File Offset: 0x0005272C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AdventureItemData> Items
		{
			get
			{
				return this.items_;
			}
		}

		// Token: 0x06001EE6 RID: 7910 RVA: 0x00054534 File Offset: 0x00052734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdventureRewardData);
		}

		// Token: 0x06001EE7 RID: 7911 RVA: 0x00054544 File Offset: 0x00052744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdventureRewardData other)
		{
			return other != null && (other == this || (this.DropId == other.DropId && this.items_.Equals(other.items_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001EE8 RID: 7912 RVA: 0x00054594 File Offset: 0x00052794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DropId != 0)
			{
				num ^= this.DropId.GetHashCode();
			}
			num ^= this.items_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001EE9 RID: 7913 RVA: 0x000545E1 File Offset: 0x000527E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001EEA RID: 7914 RVA: 0x000545EE File Offset: 0x000527EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001EEB RID: 7915 RVA: 0x000545F8 File Offset: 0x000527F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DropId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.DropId);
			}
			this.items_.WriteTo(ref output, AdventureRewardData._repeated_items_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001EEC RID: 7916 RVA: 0x00054648 File Offset: 0x00052848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DropId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DropId);
			}
			num += this.items_.CalculateSize(AdventureRewardData._repeated_items_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001EED RID: 7917 RVA: 0x0005469C File Offset: 0x0005289C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AdventureRewardData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DropId != 0)
			{
				this.DropId = other.DropId;
			}
			this.items_.Add(other.items_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001EEE RID: 7918 RVA: 0x000546E9 File Offset: 0x000528E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001EEF RID: 7919 RVA: 0x000546F4 File Offset: 0x000528F4
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.items_.AddEntriesFrom(ref input, AdventureRewardData._repeated_items_codec);
					}
				}
				else
				{
					this.DropId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002393 RID: 9107
		private static readonly MessageParser<AdventureRewardData> _parser = new MessageParser<AdventureRewardData>(() => new AdventureRewardData());

		// Token: 0x04002394 RID: 9108
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002395 RID: 9109
		public const int DropIdFieldNumber = 1;

		// Token: 0x04002396 RID: 9110
		private int dropId_;

		// Token: 0x04002397 RID: 9111
		public const int ItemsFieldNumber = 2;

		// Token: 0x04002398 RID: 9112
		private static readonly FieldCodec<AdventureItemData> _repeated_items_codec = FieldCodec.ForMessage<AdventureItemData>(18U, AdventureItemData.Parser);

		// Token: 0x04002399 RID: 9113
		private readonly RepeatedField<AdventureItemData> items_ = new RepeatedField<AdventureItemData>();
	}
}
