using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007C9 RID: 1993
	public sealed class InfrHandInData : IMessage<InfrHandInData>, IMessage, IEquatable<InfrHandInData>, IDeepCloneable<InfrHandInData>, IBufferMessage
	{
		// Token: 0x0600B36C RID: 45932 RVA: 0x001AD680 File Offset: 0x001AB880
		[NullableContext(1)]
		public static InfrHandInData Create()
		{
			return new InfrHandInData();
		}

		// Token: 0x1700242B RID: 9259
		// (get) Token: 0x0600B36D RID: 45933 RVA: 0x001AD687 File Offset: 0x001AB887
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
		// (get) Token: 0x0600B36E RID: 45934 RVA: 0x001AD68A File Offset: 0x001AB88A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrHandInData.Descriptor;
			}
		}

		// Token: 0x0600B36F RID: 45935 RVA: 0x001AD691 File Offset: 0x001AB891
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrHandInData()
		{
		}

		// Token: 0x0600B370 RID: 45936 RVA: 0x001AD699 File Offset: 0x001AB899
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrHandInData(InfrHandInData other) : this()
		{
			this.type_ = other.type_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B371 RID: 45937 RVA: 0x001AD6CA File Offset: 0x001AB8CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrHandInData Clone()
		{
			return new InfrHandInData(this);
		}

		// Token: 0x1700242D RID: 9261
		// (get) Token: 0x0600B372 RID: 45938 RVA: 0x001AD6D2 File Offset: 0x001AB8D2
		// (set) Token: 0x0600B373 RID: 45939 RVA: 0x001AD6DA File Offset: 0x001AB8DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionInfrastructureItemDeliveryType Type
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
		// (get) Token: 0x0600B374 RID: 45940 RVA: 0x001AD6E3 File Offset: 0x001AB8E3
		// (set) Token: 0x0600B375 RID: 45941 RVA: 0x001AD6EB File Offset: 0x001AB8EB
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

		// Token: 0x0600B376 RID: 45942 RVA: 0x001AD6F4 File Offset: 0x001AB8F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrHandInData);
		}

		// Token: 0x0600B377 RID: 45943 RVA: 0x001AD702 File Offset: 0x001AB902
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrHandInData other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B378 RID: 45944 RVA: 0x001AD740 File Offset: 0x001AB940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != ActionInfrastructureItemDeliveryType.Observatory)
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

		// Token: 0x0600B379 RID: 45945 RVA: 0x001AD79E File Offset: 0x001AB99E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B37A RID: 45946 RVA: 0x001AD7AB File Offset: 0x001AB9AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B37B RID: 45947 RVA: 0x001AD7B4 File Offset: 0x001AB9B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != ActionInfrastructureItemDeliveryType.Observatory)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Type);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B37C RID: 45948 RVA: 0x001AD80C File Offset: 0x001ABA0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != ActionInfrastructureItemDeliveryType.Observatory)
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

		// Token: 0x0600B37D RID: 45949 RVA: 0x001AD864 File Offset: 0x001ABA64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrHandInData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != ActionInfrastructureItemDeliveryType.Observatory)
			{
				this.Type = other.Type;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B37E RID: 45950 RVA: 0x001AD8B4 File Offset: 0x001ABAB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B37F RID: 45951 RVA: 0x001AD8C0 File Offset: 0x001ABAC0
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
						this.Id = input.ReadInt32();
					}
				}
				else
				{
					this.Type = (ActionInfrastructureItemDeliveryType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005057 RID: 20567
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005058 RID: 20568
		public const int TypeFieldNumber = 1;

		// Token: 0x04005059 RID: 20569
		private ActionInfrastructureItemDeliveryType type_;

		// Token: 0x0400505A RID: 20570
		public const int IdFieldNumber = 2;

		// Token: 0x0400505B RID: 20571
		private int id_;
	}
}
