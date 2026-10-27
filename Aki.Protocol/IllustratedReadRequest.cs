using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007C8 RID: 1992
	[NetMessage(EMessageId.IllustratedReadRequest)]
	public sealed class IllustratedReadRequest : IMessage<IllustratedReadRequest>, IMessage, IEquatable<IllustratedReadRequest>, IDeepCloneable<IllustratedReadRequest>, IBufferMessage
	{
		// Token: 0x0600B332 RID: 45874 RVA: 0x001ACFD8 File Offset: 0x001AB1D8
		[NullableContext(1)]
		public static IllustratedReadRequest Create()
		{
			return new IllustratedReadRequest();
		}

		// Token: 0x1700242B RID: 9259
		// (get) Token: 0x0600B333 RID: 45875 RVA: 0x001ACFDF File Offset: 0x001AB1DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700242C RID: 9260
		// (get) Token: 0x0600B334 RID: 45876 RVA: 0x001ACFE2 File Offset: 0x001AB1E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IllustratedReadRequest.Descriptor;
			}
		}

		// Token: 0x0600B335 RID: 45877 RVA: 0x001ACFE9 File Offset: 0x001AB1E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedReadRequest()
		{
		}

		// Token: 0x0600B336 RID: 45878 RVA: 0x001ACFF1 File Offset: 0x001AB1F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedReadRequest(IllustratedReadRequest other) : this()
		{
			this.type_ = other.type_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B337 RID: 45879 RVA: 0x001AD022 File Offset: 0x001AB222
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedReadRequest Clone()
		{
			return new IllustratedReadRequest(this);
		}

		// Token: 0x1700242D RID: 9261
		// (get) Token: 0x0600B338 RID: 45880 RVA: 0x001AD02A File Offset: 0x001AB22A
		// (set) Token: 0x0600B339 RID: 45881 RVA: 0x001AD032 File Offset: 0x001AB232
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

		// Token: 0x1700242E RID: 9262
		// (get) Token: 0x0600B33A RID: 45882 RVA: 0x001AD03B File Offset: 0x001AB23B
		// (set) Token: 0x0600B33B RID: 45883 RVA: 0x001AD043 File Offset: 0x001AB243
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

		// Token: 0x0600B33C RID: 45884 RVA: 0x001AD04C File Offset: 0x001AB24C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as IllustratedReadRequest);
		}

		// Token: 0x0600B33D RID: 45885 RVA: 0x001AD05A File Offset: 0x001AB25A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(IllustratedReadRequest other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B33E RID: 45886 RVA: 0x001AD098 File Offset: 0x001AB298
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

		// Token: 0x0600B33F RID: 45887 RVA: 0x001AD0F6 File Offset: 0x001AB2F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B340 RID: 45888 RVA: 0x001AD103 File Offset: 0x001AB303
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B341 RID: 45889 RVA: 0x001AD10C File Offset: 0x001AB30C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != IllustratedType.Monster)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.Type);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B342 RID: 45890 RVA: 0x001AD168 File Offset: 0x001AB368
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

		// Token: 0x0600B343 RID: 45891 RVA: 0x001AD1C0 File Offset: 0x001AB3C0
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

		// Token: 0x0600B344 RID: 45892 RVA: 0x001AD210 File Offset: 0x001AB410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B345 RID: 45893 RVA: 0x001AD21C File Offset: 0x001AB41C
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
				if (num != 64U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadInt32();
					}
				}
				else
				{
					this.Type = (IllustratedType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005000 RID: 20480
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005001 RID: 20481
		public const int TypeFieldNumber = 8;

		// Token: 0x04005002 RID: 20482
		private IllustratedType type_;

		// Token: 0x04005003 RID: 20483
		public const int IdFieldNumber = 9;

		// Token: 0x04005004 RID: 20484
		private int id_;
	}
}
