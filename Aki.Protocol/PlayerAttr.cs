using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D6F RID: 3439
	public sealed class PlayerAttr : IMessage<PlayerAttr>, IMessage, IEquatable<PlayerAttr>, IDeepCloneable<PlayerAttr>, IBufferMessage
	{
		// Token: 0x06012900 RID: 76032 RVA: 0x002B5BDC File Offset: 0x002B3DDC
		[NullableContext(1)]
		public static PlayerAttr Create()
		{
			return new PlayerAttr();
		}

		// Token: 0x17003D8A RID: 15754
		// (get) Token: 0x06012901 RID: 76033 RVA: 0x002B5BE3 File Offset: 0x002B3DE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerAttr> Parser
		{
			get
			{
				return PlayerAttr._parser;
			}
		}

		// Token: 0x17003D8B RID: 15755
		// (get) Token: 0x06012902 RID: 76034 RVA: 0x002B5BEA File Offset: 0x002B3DEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D8C RID: 15756
		// (get) Token: 0x06012903 RID: 76035 RVA: 0x002B5BED File Offset: 0x002B3DED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerAttr.Descriptor;
			}
		}

		// Token: 0x06012904 RID: 76036 RVA: 0x002B5BF4 File Offset: 0x002B3DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerAttr()
		{
		}

		// Token: 0x06012905 RID: 76037 RVA: 0x002B5BFC File Offset: 0x002B3DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerAttr(PlayerAttr other) : this()
		{
			this.key_ = other.key_;
			this.valueType_ = other.valueType_;
			PlayerAttr.ValueOneofCase valueCase = other.ValueCase;
			if (valueCase != PlayerAttr.ValueOneofCase.Int32Value)
			{
				if (valueCase == PlayerAttr.ValueOneofCase.StringValue)
				{
					this.StringValue = other.StringValue;
				}
			}
			else
			{
				this.Int32Value = other.Int32Value;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012906 RID: 76038 RVA: 0x002B5C63 File Offset: 0x002B3E63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerAttr Clone()
		{
			return new PlayerAttr(this);
		}

		// Token: 0x17003D8D RID: 15757
		// (get) Token: 0x06012907 RID: 76039 RVA: 0x002B5C6B File Offset: 0x002B3E6B
		// (set) Token: 0x06012908 RID: 76040 RVA: 0x002B5C73 File Offset: 0x002B3E73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerAttrKey Key
		{
			get
			{
				return this.key_;
			}
			set
			{
				this.key_ = value;
			}
		}

		// Token: 0x17003D8E RID: 15758
		// (get) Token: 0x06012909 RID: 76041 RVA: 0x002B5C7C File Offset: 0x002B3E7C
		// (set) Token: 0x0601290A RID: 76042 RVA: 0x002B5C84 File Offset: 0x002B3E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerAttrType ValueType
		{
			get
			{
				return this.valueType_;
			}
			set
			{
				this.valueType_ = value;
			}
		}

		// Token: 0x17003D8F RID: 15759
		// (get) Token: 0x0601290B RID: 76043 RVA: 0x002B5C8D File Offset: 0x002B3E8D
		// (set) Token: 0x0601290C RID: 76044 RVA: 0x002B5CA4 File Offset: 0x002B3EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Int32Value
		{
			get
			{
				if (!this.HasInt32Value)
				{
					return 0;
				}
				return (int)this.value_;
			}
			set
			{
				this.value_ = value;
				this.valueCase_ = PlayerAttr.ValueOneofCase.Int32Value;
			}
		}

		// Token: 0x17003D90 RID: 15760
		// (get) Token: 0x0601290D RID: 76045 RVA: 0x002B5CB9 File Offset: 0x002B3EB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasInt32Value
		{
			get
			{
				return this.valueCase_ == PlayerAttr.ValueOneofCase.Int32Value;
			}
		}

		// Token: 0x0601290E RID: 76046 RVA: 0x002B5CC4 File Offset: 0x002B3EC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearInt32Value()
		{
			if (this.HasInt32Value)
			{
				this.ClearValue();
			}
		}

		// Token: 0x17003D91 RID: 15761
		// (get) Token: 0x0601290F RID: 76047 RVA: 0x002B5CD4 File Offset: 0x002B3ED4
		// (set) Token: 0x06012910 RID: 76048 RVA: 0x002B5CEF File Offset: 0x002B3EEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string StringValue
		{
			get
			{
				if (!this.HasStringValue)
				{
					return "";
				}
				return (string)this.value_;
			}
			set
			{
				this.value_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
				this.valueCase_ = PlayerAttr.ValueOneofCase.StringValue;
			}
		}

		// Token: 0x17003D92 RID: 15762
		// (get) Token: 0x06012911 RID: 76049 RVA: 0x002B5D09 File Offset: 0x002B3F09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasStringValue
		{
			get
			{
				return this.valueCase_ == PlayerAttr.ValueOneofCase.StringValue;
			}
		}

		// Token: 0x06012912 RID: 76050 RVA: 0x002B5D14 File Offset: 0x002B3F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearStringValue()
		{
			if (this.HasStringValue)
			{
				this.ClearValue();
			}
		}

		// Token: 0x17003D93 RID: 15763
		// (get) Token: 0x06012913 RID: 76051 RVA: 0x002B5D24 File Offset: 0x002B3F24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerAttr.ValueOneofCase ValueCase
		{
			get
			{
				return this.valueCase_;
			}
		}

		// Token: 0x06012914 RID: 76052 RVA: 0x002B5D2C File Offset: 0x002B3F2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearValue()
		{
			this.valueCase_ = PlayerAttr.ValueOneofCase.None;
			this.value_ = null;
		}

		// Token: 0x06012915 RID: 76053 RVA: 0x002B5D3C File Offset: 0x002B3F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerAttr);
		}

		// Token: 0x06012916 RID: 76054 RVA: 0x002B5D4C File Offset: 0x002B3F4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerAttr other)
		{
			return other != null && (other == this || (this.Key == other.Key && this.ValueType == other.ValueType && this.Int32Value == other.Int32Value && !(this.StringValue != other.StringValue) && this.ValueCase == other.ValueCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012917 RID: 76055 RVA: 0x002B5DCC File Offset: 0x002B3FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Key != PlayerAttrKey.Level)
			{
				num ^= this.Key.GetHashCode();
			}
			if (this.ValueType != PlayerAttrType.Int32)
			{
				num ^= this.ValueType.GetHashCode();
			}
			if (this.HasInt32Value)
			{
				num ^= this.Int32Value.GetHashCode();
			}
			if (this.HasStringValue)
			{
				num ^= this.StringValue.GetHashCode();
			}
			num ^= (int)this.valueCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012918 RID: 76056 RVA: 0x002B5E68 File Offset: 0x002B4068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012919 RID: 76057 RVA: 0x002B5E75 File Offset: 0x002B4075
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601291A RID: 76058 RVA: 0x002B5E80 File Offset: 0x002B4080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Key != PlayerAttrKey.Level)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Key);
			}
			if (this.ValueType != PlayerAttrType.Int32)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ValueType);
			}
			if (this.HasInt32Value)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Int32Value);
			}
			if (this.HasStringValue)
			{
				output.WriteRawTag(34);
				output.WriteString(this.StringValue);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601291B RID: 76059 RVA: 0x002B5F10 File Offset: 0x002B4110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Key != PlayerAttrKey.Level)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Key);
			}
			if (this.ValueType != PlayerAttrType.Int32)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ValueType);
			}
			if (this.HasInt32Value)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Int32Value);
			}
			if (this.HasStringValue)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.StringValue);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601291C RID: 76060 RVA: 0x002B5F98 File Offset: 0x002B4198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerAttr other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Key != PlayerAttrKey.Level)
			{
				this.Key = other.Key;
			}
			if (other.ValueType != PlayerAttrType.Int32)
			{
				this.ValueType = other.ValueType;
			}
			PlayerAttr.ValueOneofCase valueCase = other.ValueCase;
			if (valueCase != PlayerAttr.ValueOneofCase.Int32Value)
			{
				if (valueCase == PlayerAttr.ValueOneofCase.StringValue)
				{
					this.StringValue = other.StringValue;
				}
			}
			else
			{
				this.Int32Value = other.Int32Value;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601291D RID: 76061 RVA: 0x002B6013 File Offset: 0x002B4213
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601291E RID: 76062 RVA: 0x002B601C File Offset: 0x002B421C
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
						this.Key = (PlayerAttrKey)input.ReadEnum();
						continue;
					}
					if (num == 16U)
					{
						this.ValueType = (PlayerAttrType)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Int32Value = input.ReadInt32();
						continue;
					}
					if (num == 34U)
					{
						this.StringValue = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040073AA RID: 29610
		private static readonly MessageParser<PlayerAttr> _parser = new MessageParser<PlayerAttr>(() => new PlayerAttr());

		// Token: 0x040073AB RID: 29611
		private UnknownFieldSet _unknownFields;

		// Token: 0x040073AC RID: 29612
		public const int KeyFieldNumber = 1;

		// Token: 0x040073AD RID: 29613
		private PlayerAttrKey key_;

		// Token: 0x040073AE RID: 29614
		public const int ValueTypeFieldNumber = 2;

		// Token: 0x040073AF RID: 29615
		private PlayerAttrType valueType_;

		// Token: 0x040073B0 RID: 29616
		public const int Int32ValueFieldNumber = 3;

		// Token: 0x040073B1 RID: 29617
		public const int StringValueFieldNumber = 4;

		// Token: 0x040073B2 RID: 29618
		private object value_;

		// Token: 0x040073B3 RID: 29619
		private PlayerAttr.ValueOneofCase valueCase_;

		// Token: 0x02001953 RID: 6483
		public enum ValueOneofCase
		{
			// Token: 0x0400CE1C RID: 52764
			None,
			// Token: 0x0400CE1D RID: 52765
			Int32Value = 3,
			// Token: 0x0400CE1E RID: 52766
			StringValue
		}
	}
}
