using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000738 RID: 1848
	public sealed class HarvestPointReward : IMessage<HarvestPointReward>, IMessage, IEquatable<HarvestPointReward>, IDeepCloneable<HarvestPointReward>, IBufferMessage
	{
		// Token: 0x0600A7CE RID: 42958 RVA: 0x001941B8 File Offset: 0x001923B8
		[NullableContext(1)]
		public static HarvestPointReward Create()
		{
			return new HarvestPointReward();
		}

		// Token: 0x170021BA RID: 8634
		// (get) Token: 0x0600A7CF RID: 42959 RVA: 0x001941BF File Offset: 0x001923BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HarvestPointReward> Parser
		{
			get
			{
				return HarvestPointReward._parser;
			}
		}

		// Token: 0x170021BB RID: 8635
		// (get) Token: 0x0600A7D0 RID: 42960 RVA: 0x001941C6 File Offset: 0x001923C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170021BC RID: 8636
		// (get) Token: 0x0600A7D1 RID: 42961 RVA: 0x001941C9 File Offset: 0x001923C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HarvestPointReward.Descriptor;
			}
		}

		// Token: 0x0600A7D2 RID: 42962 RVA: 0x001941D0 File Offset: 0x001923D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestPointReward()
		{
		}

		// Token: 0x0600A7D3 RID: 42963 RVA: 0x001941D8 File Offset: 0x001923D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestPointReward(HarvestPointReward other) : this()
		{
			this.id_ = other.id_;
			this.state_ = other.state_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A7D4 RID: 42964 RVA: 0x00194209 File Offset: 0x00192409
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestPointReward Clone()
		{
			return new HarvestPointReward(this);
		}

		// Token: 0x170021BD RID: 8637
		// (get) Token: 0x0600A7D5 RID: 42965 RVA: 0x00194211 File Offset: 0x00192411
		// (set) Token: 0x0600A7D6 RID: 42966 RVA: 0x00194219 File Offset: 0x00192419
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

		// Token: 0x170021BE RID: 8638
		// (get) Token: 0x0600A7D7 RID: 42967 RVA: 0x00194222 File Offset: 0x00192422
		// (set) Token: 0x0600A7D8 RID: 42968 RVA: 0x0019422A File Offset: 0x0019242A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignState State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x0600A7D9 RID: 42969 RVA: 0x00194233 File Offset: 0x00192433
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HarvestPointReward);
		}

		// Token: 0x0600A7DA RID: 42970 RVA: 0x00194241 File Offset: 0x00192441
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HarvestPointReward other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.State == other.State && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A7DB RID: 42971 RVA: 0x00194280 File Offset: 0x00192480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.State != SignState.Lock)
			{
				num ^= this.State.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A7DC RID: 42972 RVA: 0x001942DE File Offset: 0x001924DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A7DD RID: 42973 RVA: 0x001942EB File Offset: 0x001924EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A7DE RID: 42974 RVA: 0x001942F4 File Offset: 0x001924F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.State != SignState.Lock)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.State);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A7DF RID: 42975 RVA: 0x0019434C File Offset: 0x0019254C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.State != SignState.Lock)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.State);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A7E0 RID: 42976 RVA: 0x001943A4 File Offset: 0x001925A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HarvestPointReward other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.State != SignState.Lock)
			{
				this.State = other.State;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A7E1 RID: 42977 RVA: 0x001943F4 File Offset: 0x001925F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A7E2 RID: 42978 RVA: 0x00194400 File Offset: 0x00192600
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
						this.State = (SignState)input.ReadEnum();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004D02 RID: 19714
		private static readonly MessageParser<HarvestPointReward> _parser = new MessageParser<HarvestPointReward>(() => new HarvestPointReward());

		// Token: 0x04004D03 RID: 19715
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D04 RID: 19716
		public const int IdFieldNumber = 1;

		// Token: 0x04004D05 RID: 19717
		private int id_;

		// Token: 0x04004D06 RID: 19718
		public const int StateFieldNumber = 2;

		// Token: 0x04004D07 RID: 19719
		private SignState state_;
	}
}
