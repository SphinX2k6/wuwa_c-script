using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007B4 RID: 1972
	[NetMessage(EMessageId.IllustratedReadRequest)]
	public sealed class IllustratedReadRequest : IMessage<IllustratedReadRequest>, IMessage, IEquatable<IllustratedReadRequest>, IDeepCloneable<IllustratedReadRequest>, IBufferMessage
	{
		// Token: 0x0600B1DC RID: 45532 RVA: 0x001AA5A8 File Offset: 0x001A87A8
		[NullableContext(1)]
		public static IllustratedReadRequest Create()
		{
			return new IllustratedReadRequest();
		}

		// Token: 0x170023E1 RID: 9185
		// (get) Token: 0x0600B1DD RID: 45533 RVA: 0x001AA5AF File Offset: 0x001A87AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170023E2 RID: 9186
		// (get) Token: 0x0600B1DE RID: 45534 RVA: 0x001AA5B2 File Offset: 0x001A87B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IllustratedReadRequest.Descriptor;
			}
		}

		// Token: 0x0600B1DF RID: 45535 RVA: 0x001AA5B9 File Offset: 0x001A87B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedReadRequest()
		{
		}

		// Token: 0x0600B1E0 RID: 45536 RVA: 0x001AA5C1 File Offset: 0x001A87C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedReadRequest(IllustratedReadRequest other) : this()
		{
			this.type_ = other.type_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B1E1 RID: 45537 RVA: 0x001AA5F2 File Offset: 0x001A87F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedReadRequest Clone()
		{
			return new IllustratedReadRequest(this);
		}

		// Token: 0x170023E3 RID: 9187
		// (get) Token: 0x0600B1E2 RID: 45538 RVA: 0x001AA5FA File Offset: 0x001A87FA
		// (set) Token: 0x0600B1E3 RID: 45539 RVA: 0x001AA602 File Offset: 0x001A8802
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

		// Token: 0x170023E4 RID: 9188
		// (get) Token: 0x0600B1E4 RID: 45540 RVA: 0x001AA60B File Offset: 0x001A880B
		// (set) Token: 0x0600B1E5 RID: 45541 RVA: 0x001AA613 File Offset: 0x001A8813
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

		// Token: 0x0600B1E6 RID: 45542 RVA: 0x001AA61C File Offset: 0x001A881C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as IllustratedReadRequest);
		}

		// Token: 0x0600B1E7 RID: 45543 RVA: 0x001AA62A File Offset: 0x001A882A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(IllustratedReadRequest other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B1E8 RID: 45544 RVA: 0x001AA668 File Offset: 0x001A8868
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

		// Token: 0x0600B1E9 RID: 45545 RVA: 0x001AA6C6 File Offset: 0x001A88C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B1EA RID: 45546 RVA: 0x001AA6D3 File Offset: 0x001A88D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B1EB RID: 45547 RVA: 0x001AA6DC File Offset: 0x001A88DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Id);
			}
			if (this.Type != IllustratedType.Monster)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B1EC RID: 45548 RVA: 0x001AA738 File Offset: 0x001A8938
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

		// Token: 0x0600B1ED RID: 45549 RVA: 0x001AA790 File Offset: 0x001A8990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(IllustratedReadRequest other)
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

		// Token: 0x0600B1EE RID: 45550 RVA: 0x001AA7E0 File Offset: 0x001A89E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B1EF RID: 45551 RVA: 0x001AA7EC File Offset: 0x001A89EC
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
				if (num != 16U)
				{
					if (num != 112U)
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

		// Token: 0x04004FF9 RID: 20473
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004FFA RID: 20474
		public const int TypeFieldNumber = 14;

		// Token: 0x04004FFB RID: 20475
		private IllustratedType type_;

		// Token: 0x04004FFC RID: 20476
		public const int IdFieldNumber = 2;

		// Token: 0x04004FFD RID: 20477
		private int id_;
	}
}
