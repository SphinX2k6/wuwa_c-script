using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007CD RID: 1997
	[NetMessage(EMessageId.IllustratedUnlockRequest)]
	public sealed class IllustratedUnlockRequest : IMessage<IllustratedUnlockRequest>, IMessage, IEquatable<IllustratedUnlockRequest>, IDeepCloneable<IllustratedUnlockRequest>, IBufferMessage
	{
		// Token: 0x0600B392 RID: 45970 RVA: 0x001ADBEA File Offset: 0x001ABDEA
		[NullableContext(1)]
		public static IllustratedUnlockRequest Create()
		{
			return new IllustratedUnlockRequest();
		}

		// Token: 0x1700243D RID: 9277
		// (get) Token: 0x0600B393 RID: 45971 RVA: 0x001ADBF1 File Offset: 0x001ABDF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700243E RID: 9278
		// (get) Token: 0x0600B394 RID: 45972 RVA: 0x001ADBF4 File Offset: 0x001ABDF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IllustratedUnlockRequest.Descriptor;
			}
		}

		// Token: 0x0600B395 RID: 45973 RVA: 0x001ADBFB File Offset: 0x001ABDFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedUnlockRequest()
		{
		}

		// Token: 0x0600B396 RID: 45974 RVA: 0x001ADC03 File Offset: 0x001ABE03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedUnlockRequest(IllustratedUnlockRequest other) : this()
		{
			this.type_ = other.type_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B397 RID: 45975 RVA: 0x001ADC34 File Offset: 0x001ABE34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedUnlockRequest Clone()
		{
			return new IllustratedUnlockRequest(this);
		}

		// Token: 0x1700243F RID: 9279
		// (get) Token: 0x0600B398 RID: 45976 RVA: 0x001ADC3C File Offset: 0x001ABE3C
		// (set) Token: 0x0600B399 RID: 45977 RVA: 0x001ADC44 File Offset: 0x001ABE44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x17002440 RID: 9280
		// (get) Token: 0x0600B39A RID: 45978 RVA: 0x001ADC4D File Offset: 0x001ABE4D
		// (set) Token: 0x0600B39B RID: 45979 RVA: 0x001ADC55 File Offset: 0x001ABE55
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

		// Token: 0x0600B39C RID: 45980 RVA: 0x001ADC5E File Offset: 0x001ABE5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as IllustratedUnlockRequest);
		}

		// Token: 0x0600B39D RID: 45981 RVA: 0x001ADC6C File Offset: 0x001ABE6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(IllustratedUnlockRequest other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B39E RID: 45982 RVA: 0x001ADCAC File Offset: 0x001ABEAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != IllustratedType.Monster)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B39F RID: 45983 RVA: 0x001ADD0A File Offset: 0x001ABF0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B3A0 RID: 45984 RVA: 0x001ADD17 File Offset: 0x001ABF17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B3A1 RID: 45985 RVA: 0x001ADD20 File Offset: 0x001ABF20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Id);
			}
			if (this.Type != IllustratedType.Monster)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B3A2 RID: 45986 RVA: 0x001ADD7C File Offset: 0x001ABF7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != IllustratedType.Monster)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B3A3 RID: 45987 RVA: 0x001ADDD4 File Offset: 0x001ABFD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(IllustratedUnlockRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != IllustratedType.Monster)
			{
				this.Type = other.Type;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B3A4 RID: 45988 RVA: 0x001ADE24 File Offset: 0x001AC024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B3A5 RID: 45989 RVA: 0x001ADE30 File Offset: 0x001AC030
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
				if (num != 40U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Type = (IllustratedType)input.ReadEnum();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005017 RID: 20503
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005018 RID: 20504
		public const int TypeFieldNumber = 10;

		// Token: 0x04005019 RID: 20505
		private IllustratedType type_;

		// Token: 0x0400501A RID: 20506
		public const int IdFieldNumber = 5;

		// Token: 0x0400501B RID: 20507
		private int id_;
	}
}
