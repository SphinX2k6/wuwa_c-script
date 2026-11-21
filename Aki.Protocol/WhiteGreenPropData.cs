using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001589 RID: 5513
	public sealed class WhiteGreenPropData : IMessage<WhiteGreenPropData>, IMessage, IEquatable<WhiteGreenPropData>, IDeepCloneable<WhiteGreenPropData>, IBufferMessage
	{
		// Token: 0x0601D2F4 RID: 119540 RVA: 0x00439BC5 File Offset: 0x00437DC5
		[NullableContext(1)]
		public static WhiteGreenPropData Create()
		{
			return new WhiteGreenPropData();
		}

		// Token: 0x170062BC RID: 25276
		// (get) Token: 0x0601D2F5 RID: 119541 RVA: 0x00439BCC File Offset: 0x00437DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<WhiteGreenPropData> Parser
		{
			get
			{
				return WhiteGreenPropData._parser;
			}
		}

		// Token: 0x170062BD RID: 25277
		// (get) Token: 0x0601D2F6 RID: 119542 RVA: 0x00439BD3 File Offset: 0x00437DD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170062BE RID: 25278
		// (get) Token: 0x0601D2F7 RID: 119543 RVA: 0x00439BD6 File Offset: 0x00437DD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WhiteGreenPropData.Descriptor;
			}
		}

		// Token: 0x0601D2F8 RID: 119544 RVA: 0x00439BDD File Offset: 0x00437DDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WhiteGreenPropData()
		{
		}

		// Token: 0x0601D2F9 RID: 119545 RVA: 0x00439BE8 File Offset: 0x00437DE8
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

		// Token: 0x0601D2FA RID: 119546 RVA: 0x00439C3C File Offset: 0x00437E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WhiteGreenPropData Clone()
		{
			return new WhiteGreenPropData(this);
		}

		// Token: 0x170062BF RID: 25279
		// (get) Token: 0x0601D2FB RID: 119547 RVA: 0x00439C44 File Offset: 0x00437E44
		// (set) Token: 0x0601D2FC RID: 119548 RVA: 0x00439C4C File Offset: 0x00437E4C
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

		// Token: 0x170062C0 RID: 25280
		// (get) Token: 0x0601D2FD RID: 119549 RVA: 0x00439C55 File Offset: 0x00437E55
		// (set) Token: 0x0601D2FE RID: 119550 RVA: 0x00439C5D File Offset: 0x00437E5D
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

		// Token: 0x170062C1 RID: 25281
		// (get) Token: 0x0601D2FF RID: 119551 RVA: 0x00439C66 File Offset: 0x00437E66
		// (set) Token: 0x0601D300 RID: 119552 RVA: 0x00439C6E File Offset: 0x00437E6E
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

		// Token: 0x170062C2 RID: 25282
		// (get) Token: 0x0601D301 RID: 119553 RVA: 0x00439C77 File Offset: 0x00437E77
		// (set) Token: 0x0601D302 RID: 119554 RVA: 0x00439C7F File Offset: 0x00437E7F
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

		// Token: 0x0601D303 RID: 119555 RVA: 0x00439C88 File Offset: 0x00437E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WhiteGreenPropData);
		}

		// Token: 0x0601D304 RID: 119556 RVA: 0x00439C98 File Offset: 0x00437E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WhiteGreenPropData other)
		{
			return other != null && (other == this || (this.AttributeType == other.AttributeType && this.WhiteValue == other.WhiteValue && this.GreenValue == other.GreenValue && this.CurrentValue == other.CurrentValue && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D305 RID: 119557 RVA: 0x00439D04 File Offset: 0x00437F04
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

		// Token: 0x0601D306 RID: 119558 RVA: 0x00439D8E File Offset: 0x00437F8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D307 RID: 119559 RVA: 0x00439D9B File Offset: 0x00437F9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D308 RID: 119560 RVA: 0x00439DA4 File Offset: 0x00437FA4
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

		// Token: 0x0601D309 RID: 119561 RVA: 0x00439E34 File Offset: 0x00438034
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

		// Token: 0x0601D30A RID: 119562 RVA: 0x00439EBC File Offset: 0x004380BC
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

		// Token: 0x0601D30B RID: 119563 RVA: 0x00439F34 File Offset: 0x00438134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D30C RID: 119564 RVA: 0x00439F40 File Offset: 0x00438140
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

		// Token: 0x0400A778 RID: 42872
		private static readonly MessageParser<WhiteGreenPropData> _parser = new MessageParser<WhiteGreenPropData>(() => new WhiteGreenPropData());

		// Token: 0x0400A779 RID: 42873
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A77A RID: 42874
		public const int AttributeTypeFieldNumber = 1;

		// Token: 0x0400A77B RID: 42875
		private int attributeType_;

		// Token: 0x0400A77C RID: 42876
		public const int WhiteValueFieldNumber = 2;

		// Token: 0x0400A77D RID: 42877
		private int whiteValue_;

		// Token: 0x0400A77E RID: 42878
		public const int GreenValueFieldNumber = 3;

		// Token: 0x0400A77F RID: 42879
		private int greenValue_;

		// Token: 0x0400A780 RID: 42880
		public const int CurrentValueFieldNumber = 4;

		// Token: 0x0400A781 RID: 42881
		private int currentValue_;
	}
}
