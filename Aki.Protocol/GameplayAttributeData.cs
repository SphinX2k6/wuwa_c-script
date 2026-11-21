using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000691 RID: 1681
	public sealed class GameplayAttributeData : IMessage<GameplayAttributeData>, IMessage, IEquatable<GameplayAttributeData>, IDeepCloneable<GameplayAttributeData>, IBufferMessage
	{
		// Token: 0x06009AD8 RID: 39640 RVA: 0x00179C27 File Offset: 0x00177E27
		[NullableContext(1)]
		public static GameplayAttributeData Create()
		{
			return new GameplayAttributeData();
		}

		// Token: 0x17001F21 RID: 7969
		// (get) Token: 0x06009AD9 RID: 39641 RVA: 0x00179C2E File Offset: 0x00177E2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GameplayAttributeData> Parser
		{
			get
			{
				return GameplayAttributeData._parser;
			}
		}

		// Token: 0x17001F22 RID: 7970
		// (get) Token: 0x06009ADA RID: 39642 RVA: 0x00179C35 File Offset: 0x00177E35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F23 RID: 7971
		// (get) Token: 0x06009ADB RID: 39643 RVA: 0x00179C38 File Offset: 0x00177E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameplayAttributeData.Descriptor;
			}
		}

		// Token: 0x06009ADC RID: 39644 RVA: 0x00179C3F File Offset: 0x00177E3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayAttributeData()
		{
		}

		// Token: 0x06009ADD RID: 39645 RVA: 0x00179C47 File Offset: 0x00177E47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayAttributeData(GameplayAttributeData other) : this()
		{
			this.baseValue_ = other.baseValue_;
			this.currentValue_ = other.currentValue_;
			this.attributeType_ = other.attributeType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009ADE RID: 39646 RVA: 0x00179C84 File Offset: 0x00177E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayAttributeData Clone()
		{
			return new GameplayAttributeData(this);
		}

		// Token: 0x17001F24 RID: 7972
		// (get) Token: 0x06009ADF RID: 39647 RVA: 0x00179C8C File Offset: 0x00177E8C
		// (set) Token: 0x06009AE0 RID: 39648 RVA: 0x00179C94 File Offset: 0x00177E94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BaseValue
		{
			get
			{
				return this.baseValue_;
			}
			set
			{
				this.baseValue_ = value;
			}
		}

		// Token: 0x17001F25 RID: 7973
		// (get) Token: 0x06009AE1 RID: 39649 RVA: 0x00179C9D File Offset: 0x00177E9D
		// (set) Token: 0x06009AE2 RID: 39650 RVA: 0x00179CA5 File Offset: 0x00177EA5
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

		// Token: 0x17001F26 RID: 7974
		// (get) Token: 0x06009AE3 RID: 39651 RVA: 0x00179CAE File Offset: 0x00177EAE
		// (set) Token: 0x06009AE4 RID: 39652 RVA: 0x00179CB6 File Offset: 0x00177EB6
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

		// Token: 0x06009AE5 RID: 39653 RVA: 0x00179CBF File Offset: 0x00177EBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameplayAttributeData);
		}

		// Token: 0x06009AE6 RID: 39654 RVA: 0x00179CD0 File Offset: 0x00177ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GameplayAttributeData other)
		{
			return other != null && (other == this || (this.BaseValue == other.BaseValue && this.CurrentValue == other.CurrentValue && this.AttributeType == other.AttributeType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009AE7 RID: 39655 RVA: 0x00179D2C File Offset: 0x00177F2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BaseValue != 0)
			{
				num ^= this.BaseValue.GetHashCode();
			}
			if (this.CurrentValue != 0)
			{
				num ^= this.CurrentValue.GetHashCode();
			}
			if (this.AttributeType != 0)
			{
				num ^= this.AttributeType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009AE8 RID: 39656 RVA: 0x00179D9D File Offset: 0x00177F9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009AE9 RID: 39657 RVA: 0x00179DAA File Offset: 0x00177FAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009AEA RID: 39658 RVA: 0x00179DB4 File Offset: 0x00177FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BaseValue != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.BaseValue);
			}
			if (this.CurrentValue != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CurrentValue);
			}
			if (this.AttributeType != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.AttributeType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009AEB RID: 39659 RVA: 0x00179E28 File Offset: 0x00178028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BaseValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BaseValue);
			}
			if (this.CurrentValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurrentValue);
			}
			if (this.AttributeType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AttributeType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009AEC RID: 39660 RVA: 0x00179E98 File Offset: 0x00178098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GameplayAttributeData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BaseValue != 0)
			{
				this.BaseValue = other.BaseValue;
			}
			if (other.CurrentValue != 0)
			{
				this.CurrentValue = other.CurrentValue;
			}
			if (other.AttributeType != 0)
			{
				this.AttributeType = other.AttributeType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009AED RID: 39661 RVA: 0x00179EFC File Offset: 0x001780FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009AEE RID: 39662 RVA: 0x00179F08 File Offset: 0x00178108
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
							this.AttributeType = input.ReadInt32();
						}
					}
					else
					{
						this.CurrentValue = input.ReadInt32();
					}
				}
				else
				{
					this.BaseValue = input.ReadInt32();
				}
			}
		}

		// Token: 0x040049AE RID: 18862
		private static readonly MessageParser<GameplayAttributeData> _parser = new MessageParser<GameplayAttributeData>(() => new GameplayAttributeData());

		// Token: 0x040049AF RID: 18863
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049B0 RID: 18864
		public const int BaseValueFieldNumber = 1;

		// Token: 0x040049B1 RID: 18865
		private int baseValue_;

		// Token: 0x040049B2 RID: 18866
		public const int CurrentValueFieldNumber = 2;

		// Token: 0x040049B3 RID: 18867
		private int currentValue_;

		// Token: 0x040049B4 RID: 18868
		public const int AttributeTypeFieldNumber = 3;

		// Token: 0x040049B5 RID: 18869
		private int attributeType_;
	}
}
