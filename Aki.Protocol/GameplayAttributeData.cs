using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006A5 RID: 1701
	public sealed class GameplayAttributeData : IMessage<GameplayAttributeData>, IMessage, IEquatable<GameplayAttributeData>, IDeepCloneable<GameplayAttributeData>, IBufferMessage
	{
		// Token: 0x06009C2E RID: 39982 RVA: 0x0017C65F File Offset: 0x0017A85F
		[NullableContext(1)]
		public static GameplayAttributeData Create()
		{
			return new GameplayAttributeData();
		}

		// Token: 0x17001F6B RID: 8043
		// (get) Token: 0x06009C2F RID: 39983 RVA: 0x0017C666 File Offset: 0x0017A866
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GameplayAttributeData> Parser
		{
			get
			{
				return GameplayAttributeData._parser;
			}
		}

		// Token: 0x17001F6C RID: 8044
		// (get) Token: 0x06009C30 RID: 39984 RVA: 0x0017C66D File Offset: 0x0017A86D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F6D RID: 8045
		// (get) Token: 0x06009C31 RID: 39985 RVA: 0x0017C670 File Offset: 0x0017A870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameplayAttributeData.Descriptor;
			}
		}

		// Token: 0x06009C32 RID: 39986 RVA: 0x0017C677 File Offset: 0x0017A877
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayAttributeData()
		{
		}

		// Token: 0x06009C33 RID: 39987 RVA: 0x0017C67F File Offset: 0x0017A87F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayAttributeData(GameplayAttributeData other) : this()
		{
			this.baseValue_ = other.baseValue_;
			this.currentValue_ = other.currentValue_;
			this.attributeType_ = other.attributeType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009C34 RID: 39988 RVA: 0x0017C6BC File Offset: 0x0017A8BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayAttributeData Clone()
		{
			return new GameplayAttributeData(this);
		}

		// Token: 0x17001F6E RID: 8046
		// (get) Token: 0x06009C35 RID: 39989 RVA: 0x0017C6C4 File Offset: 0x0017A8C4
		// (set) Token: 0x06009C36 RID: 39990 RVA: 0x0017C6CC File Offset: 0x0017A8CC
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

		// Token: 0x17001F6F RID: 8047
		// (get) Token: 0x06009C37 RID: 39991 RVA: 0x0017C6D5 File Offset: 0x0017A8D5
		// (set) Token: 0x06009C38 RID: 39992 RVA: 0x0017C6DD File Offset: 0x0017A8DD
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

		// Token: 0x17001F70 RID: 8048
		// (get) Token: 0x06009C39 RID: 39993 RVA: 0x0017C6E6 File Offset: 0x0017A8E6
		// (set) Token: 0x06009C3A RID: 39994 RVA: 0x0017C6EE File Offset: 0x0017A8EE
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

		// Token: 0x06009C3B RID: 39995 RVA: 0x0017C6F7 File Offset: 0x0017A8F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameplayAttributeData);
		}

		// Token: 0x06009C3C RID: 39996 RVA: 0x0017C708 File Offset: 0x0017A908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GameplayAttributeData other)
		{
			return other != null && (other == this || (this.BaseValue == other.BaseValue && this.CurrentValue == other.CurrentValue && this.AttributeType == other.AttributeType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009C3D RID: 39997 RVA: 0x0017C764 File Offset: 0x0017A964
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

		// Token: 0x06009C3E RID: 39998 RVA: 0x0017C7D5 File Offset: 0x0017A9D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009C3F RID: 39999 RVA: 0x0017C7E2 File Offset: 0x0017A9E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009C40 RID: 40000 RVA: 0x0017C7EC File Offset: 0x0017A9EC
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

		// Token: 0x06009C41 RID: 40001 RVA: 0x0017C860 File Offset: 0x0017AA60
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

		// Token: 0x06009C42 RID: 40002 RVA: 0x0017C8D0 File Offset: 0x0017AAD0
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

		// Token: 0x06009C43 RID: 40003 RVA: 0x0017C934 File Offset: 0x0017AB34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009C44 RID: 40004 RVA: 0x0017C940 File Offset: 0x0017AB40
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

		// Token: 0x040049B5 RID: 18869
		private static readonly MessageParser<GameplayAttributeData> _parser = new MessageParser<GameplayAttributeData>(() => new GameplayAttributeData());

		// Token: 0x040049B6 RID: 18870
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049B7 RID: 18871
		public const int BaseValueFieldNumber = 1;

		// Token: 0x040049B8 RID: 18872
		private int baseValue_;

		// Token: 0x040049B9 RID: 18873
		public const int CurrentValueFieldNumber = 2;

		// Token: 0x040049BA RID: 18874
		private int currentValue_;

		// Token: 0x040049BB RID: 18875
		public const int AttributeTypeFieldNumber = 3;

		// Token: 0x040049BC RID: 18876
		private int attributeType_;
	}
}
