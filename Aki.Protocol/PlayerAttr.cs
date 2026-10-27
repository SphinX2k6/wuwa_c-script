using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D7F RID: 3455
	public sealed class PlayerAttr : IMessage<PlayerAttr>, IMessage, IEquatable<PlayerAttr>, IDeepCloneable<PlayerAttr>, IBufferMessage
	{
		// Token: 0x060129FC RID: 76284 RVA: 0x002B77FC File Offset: 0x002B59FC
		[NullableContext(1)]
		public static PlayerAttr Create()
		{
			return new PlayerAttr();
		}

		// Token: 0x17003DBF RID: 15807
		// (get) Token: 0x060129FD RID: 76285 RVA: 0x002B7803 File Offset: 0x002B5A03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerAttr> Parser
		{
			get
			{
				return PlayerAttr._parser;
			}
		}

		// Token: 0x17003DC0 RID: 15808
		// (get) Token: 0x060129FE RID: 76286 RVA: 0x002B780A File Offset: 0x002B5A0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003DC1 RID: 15809
		// (get) Token: 0x060129FF RID: 76287 RVA: 0x002B780D File Offset: 0x002B5A0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerAttr.Descriptor;
			}
		}

		// Token: 0x06012A00 RID: 76288 RVA: 0x002B7814 File Offset: 0x002B5A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerAttr()
		{
		}

		// Token: 0x06012A01 RID: 76289 RVA: 0x002B781C File Offset: 0x002B5A1C
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

		// Token: 0x06012A02 RID: 76290 RVA: 0x002B7883 File Offset: 0x002B5A83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerAttr Clone()
		{
			return new PlayerAttr(this);
		}

		// Token: 0x17003DC2 RID: 15810
		// (get) Token: 0x06012A03 RID: 76291 RVA: 0x002B788B File Offset: 0x002B5A8B
		// (set) Token: 0x06012A04 RID: 76292 RVA: 0x002B7893 File Offset: 0x002B5A93
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

		// Token: 0x17003DC3 RID: 15811
		// (get) Token: 0x06012A05 RID: 76293 RVA: 0x002B789C File Offset: 0x002B5A9C
		// (set) Token: 0x06012A06 RID: 76294 RVA: 0x002B78A4 File Offset: 0x002B5AA4
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

		// Token: 0x17003DC4 RID: 15812
		// (get) Token: 0x06012A07 RID: 76295 RVA: 0x002B78AD File Offset: 0x002B5AAD
		// (set) Token: 0x06012A08 RID: 76296 RVA: 0x002B78C4 File Offset: 0x002B5AC4
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

		// Token: 0x17003DC5 RID: 15813
		// (get) Token: 0x06012A09 RID: 76297 RVA: 0x002B78D9 File Offset: 0x002B5AD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasInt32Value
		{
			get
			{
				return this.valueCase_ == PlayerAttr.ValueOneofCase.Int32Value;
			}
		}

		// Token: 0x06012A0A RID: 76298 RVA: 0x002B78E4 File Offset: 0x002B5AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearInt32Value()
		{
			if (this.HasInt32Value)
			{
				this.ClearValue();
			}
		}

		// Token: 0x17003DC6 RID: 15814
		// (get) Token: 0x06012A0B RID: 76299 RVA: 0x002B78F4 File Offset: 0x002B5AF4
		// (set) Token: 0x06012A0C RID: 76300 RVA: 0x002B790F File Offset: 0x002B5B0F
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

		// Token: 0x17003DC7 RID: 15815
		// (get) Token: 0x06012A0D RID: 76301 RVA: 0x002B7929 File Offset: 0x002B5B29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasStringValue
		{
			get
			{
				return this.valueCase_ == PlayerAttr.ValueOneofCase.StringValue;
			}
		}

		// Token: 0x06012A0E RID: 76302 RVA: 0x002B7934 File Offset: 0x002B5B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearStringValue()
		{
			if (this.HasStringValue)
			{
				this.ClearValue();
			}
		}

		// Token: 0x17003DC8 RID: 15816
		// (get) Token: 0x06012A0F RID: 76303 RVA: 0x002B7944 File Offset: 0x002B5B44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerAttr.ValueOneofCase ValueCase
		{
			get
			{
				return this.valueCase_;
			}
		}

		// Token: 0x06012A10 RID: 76304 RVA: 0x002B794C File Offset: 0x002B5B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearValue()
		{
			this.valueCase_ = PlayerAttr.ValueOneofCase.None;
			this.value_ = null;
		}

		// Token: 0x06012A11 RID: 76305 RVA: 0x002B795C File Offset: 0x002B5B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerAttr);
		}

		// Token: 0x06012A12 RID: 76306 RVA: 0x002B796C File Offset: 0x002B5B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerAttr other)
		{
			return other != null && (other == this || (this.Key == other.Key && this.ValueType == other.ValueType && this.Int32Value == other.Int32Value && !(this.StringValue != other.StringValue) && this.ValueCase == other.ValueCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012A13 RID: 76307 RVA: 0x002B79EC File Offset: 0x002B5BEC
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

		// Token: 0x06012A14 RID: 76308 RVA: 0x002B7A88 File Offset: 0x002B5C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012A15 RID: 76309 RVA: 0x002B7A95 File Offset: 0x002B5C95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012A16 RID: 76310 RVA: 0x002B7AA0 File Offset: 0x002B5CA0
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

		// Token: 0x06012A17 RID: 76311 RVA: 0x002B7B30 File Offset: 0x002B5D30
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

		// Token: 0x06012A18 RID: 76312 RVA: 0x002B7BB8 File Offset: 0x002B5DB8
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

		// Token: 0x06012A19 RID: 76313 RVA: 0x002B7C33 File Offset: 0x002B5E33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012A1A RID: 76314 RVA: 0x002B7C3C File Offset: 0x002B5E3C
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

		// Token: 0x04007392 RID: 29586
		private static readonly MessageParser<PlayerAttr> _parser = new MessageParser<PlayerAttr>(() => new PlayerAttr());

		// Token: 0x04007393 RID: 29587
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007394 RID: 29588
		public const int KeyFieldNumber = 1;

		// Token: 0x04007395 RID: 29589
		private PlayerAttrKey key_;

		// Token: 0x04007396 RID: 29590
		public const int ValueTypeFieldNumber = 2;

		// Token: 0x04007397 RID: 29591
		private PlayerAttrType valueType_;

		// Token: 0x04007398 RID: 29592
		public const int Int32ValueFieldNumber = 3;

		// Token: 0x04007399 RID: 29593
		public const int StringValueFieldNumber = 4;

		// Token: 0x0400739A RID: 29594
		private object value_;

		// Token: 0x0400739B RID: 29595
		private PlayerAttr.ValueOneofCase valueCase_;

		// Token: 0x020018DB RID: 6363
		public enum ValueOneofCase
		{
			// Token: 0x0400C8F1 RID: 51441
			None,
			// Token: 0x0400C8F2 RID: 51442
			Int32Value = 3,
			// Token: 0x0400C8F3 RID: 51443
			StringValue
		}
	}
}
