using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001513 RID: 5395
	public sealed class WhiteGreenPropData : IMessage<WhiteGreenPropData>, IMessage, IEquatable<WhiteGreenPropData>, IDeepCloneable<WhiteGreenPropData>, IBufferMessage
	{
		// Token: 0x0601C82D RID: 116781 RVA: 0x0041E105 File Offset: 0x0041C305
		[NullableContext(1)]
		public static WhiteGreenPropData Create()
		{
			return new WhiteGreenPropData();
		}

		// Token: 0x1700601B RID: 24603
		// (get) Token: 0x0601C82E RID: 116782 RVA: 0x0041E10C File Offset: 0x0041C30C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<WhiteGreenPropData> Parser
		{
			get
			{
				return WhiteGreenPropData._parser;
			}
		}

		// Token: 0x1700601C RID: 24604
		// (get) Token: 0x0601C82F RID: 116783 RVA: 0x0041E113 File Offset: 0x0041C313
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700601D RID: 24605
		// (get) Token: 0x0601C830 RID: 116784 RVA: 0x0041E116 File Offset: 0x0041C316
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WhiteGreenPropData.Descriptor;
			}
		}

		// Token: 0x0601C831 RID: 116785 RVA: 0x0041E11D File Offset: 0x0041C31D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WhiteGreenPropData()
		{
		}

		// Token: 0x0601C832 RID: 116786 RVA: 0x0041E128 File Offset: 0x0041C328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WhiteGreenPropData(WhiteGreenPropData other) : this()
		{
			this.attributeType_ = other.attributeType_;
			this.whiteValue_ = other.whiteValue_;
			this.greenValue_ = other.greenValue_;
			this.currentValue_ = other.currentValue_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C833 RID: 116787 RVA: 0x0041E17C File Offset: 0x0041C37C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WhiteGreenPropData Clone()
		{
			return new WhiteGreenPropData(this);
		}

		// Token: 0x1700601E RID: 24606
		// (get) Token: 0x0601C834 RID: 116788 RVA: 0x0041E184 File Offset: 0x0041C384
		// (set) Token: 0x0601C835 RID: 116789 RVA: 0x0041E18C File Offset: 0x0041C38C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AttributeType
		{
			get
			{
				return this.attributeType_;
			}
			set
			{
				this.attributeType_ = value;
			}
		}

		// Token: 0x1700601F RID: 24607
		// (get) Token: 0x0601C836 RID: 116790 RVA: 0x0041E195 File Offset: 0x0041C395
		// (set) Token: 0x0601C837 RID: 116791 RVA: 0x0041E19D File Offset: 0x0041C39D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WhiteValue
		{
			get
			{
				return this.whiteValue_;
			}
			set
			{
				this.whiteValue_ = value;
			}
		}

		// Token: 0x17006020 RID: 24608
		// (get) Token: 0x0601C838 RID: 116792 RVA: 0x0041E1A6 File Offset: 0x0041C3A6
		// (set) Token: 0x0601C839 RID: 116793 RVA: 0x0041E1AE File Offset: 0x0041C3AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GreenValue
		{
			get
			{
				return this.greenValue_;
			}
			set
			{
				this.greenValue_ = value;
			}
		}

		// Token: 0x17006021 RID: 24609
		// (get) Token: 0x0601C83A RID: 116794 RVA: 0x0041E1B7 File Offset: 0x0041C3B7
		// (set) Token: 0x0601C83B RID: 116795 RVA: 0x0041E1BF File Offset: 0x0041C3BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurrentValue
		{
			get
			{
				return this.currentValue_;
			}
			set
			{
				this.currentValue_ = value;
			}
		}

		// Token: 0x0601C83C RID: 116796 RVA: 0x0041E1C8 File Offset: 0x0041C3C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WhiteGreenPropData);
		}

		// Token: 0x0601C83D RID: 116797 RVA: 0x0041E1D8 File Offset: 0x0041C3D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WhiteGreenPropData other)
		{
			return other != null && (other == this || (this.AttributeType == other.AttributeType && this.WhiteValue == other.WhiteValue && this.GreenValue == other.GreenValue && this.CurrentValue == other.CurrentValue && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C83E RID: 116798 RVA: 0x0041E244 File Offset: 0x0041C444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AttributeType != 0)
			{
				num ^= this.AttributeType.GetHashCode();
			}
			if (this.WhiteValue != 0)
			{
				num ^= this.WhiteValue.GetHashCode();
			}
			if (this.GreenValue != 0)
			{
				num ^= this.GreenValue.GetHashCode();
			}
			if (this.CurrentValue != 0)
			{
				num ^= this.CurrentValue.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C83F RID: 116799 RVA: 0x0041E2CE File Offset: 0x0041C4CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C840 RID: 116800 RVA: 0x0041E2DB File Offset: 0x0041C4DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C841 RID: 116801 RVA: 0x0041E2E4 File Offset: 0x0041C4E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AttributeType != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.AttributeType);
			}
			if (this.WhiteValue != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.WhiteValue);
			}
			if (this.GreenValue != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.GreenValue);
			}
			if (this.CurrentValue != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.CurrentValue);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C842 RID: 116802 RVA: 0x0041E374 File Offset: 0x0041C574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AttributeType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AttributeType);
			}
			if (this.WhiteValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WhiteValue);
			}
			if (this.GreenValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GreenValue);
			}
			if (this.CurrentValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurrentValue);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C843 RID: 116803 RVA: 0x0041E3FC File Offset: 0x0041C5FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WhiteGreenPropData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AttributeType != 0)
			{
				this.AttributeType = other.AttributeType;
			}
			if (other.WhiteValue != 0)
			{
				this.WhiteValue = other.WhiteValue;
			}
			if (other.GreenValue != 0)
			{
				this.GreenValue = other.GreenValue;
			}
			if (other.CurrentValue != 0)
			{
				this.CurrentValue = other.CurrentValue;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C844 RID: 116804 RVA: 0x0041E474 File Offset: 0x0041C674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C845 RID: 116805 RVA: 0x0041E480 File Offset: 0x0041C680
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.AttributeType = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.WhiteValue = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.GreenValue = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.CurrentValue = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A31F RID: 41759
		private static readonly MessageParser<WhiteGreenPropData> _parser = new MessageParser<WhiteGreenPropData>(() => new WhiteGreenPropData());

		// Token: 0x0400A320 RID: 41760
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A321 RID: 41761
		public const int AttributeTypeFieldNumber = 1;

		// Token: 0x0400A322 RID: 41762
		private int attributeType_;

		// Token: 0x0400A323 RID: 41763
		public const int WhiteValueFieldNumber = 2;

		// Token: 0x0400A324 RID: 41764
		private int whiteValue_;

		// Token: 0x0400A325 RID: 41765
		public const int GreenValueFieldNumber = 3;

		// Token: 0x0400A326 RID: 41766
		private int greenValue_;

		// Token: 0x0400A327 RID: 41767
		public const int CurrentValueFieldNumber = 4;

		// Token: 0x0400A328 RID: 41768
		private int currentValue_;
	}
}
