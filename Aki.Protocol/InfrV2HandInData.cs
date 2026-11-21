using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007E4 RID: 2020
	public sealed class InfrV2HandInData : IMessage<InfrV2HandInData>, IMessage, IEquatable<InfrV2HandInData>, IDeepCloneable<InfrV2HandInData>, IBufferMessage
	{
		// Token: 0x0600B57A RID: 46458 RVA: 0x001B1950 File Offset: 0x001AFB50
		[NullableContext(1)]
		public static InfrV2HandInData Create()
		{
			return new InfrV2HandInData();
		}

		// Token: 0x17002492 RID: 9362
		// (get) Token: 0x0600B57B RID: 46459 RVA: 0x001B1957 File Offset: 0x001AFB57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002493 RID: 9363
		// (get) Token: 0x0600B57C RID: 46460 RVA: 0x001B195A File Offset: 0x001AFB5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrV2HandInData.Descriptor;
			}
		}

		// Token: 0x0600B57D RID: 46461 RVA: 0x001B1961 File Offset: 0x001AFB61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2HandInData()
		{
		}

		// Token: 0x0600B57E RID: 46462 RVA: 0x001B1969 File Offset: 0x001AFB69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2HandInData(InfrV2HandInData other) : this()
		{
			this.type_ = other.type_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B57F RID: 46463 RVA: 0x001B199A File Offset: 0x001AFB9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2HandInData Clone()
		{
			return new InfrV2HandInData(this);
		}

		// Token: 0x17002494 RID: 9364
		// (get) Token: 0x0600B580 RID: 46464 RVA: 0x001B19A2 File Offset: 0x001AFBA2
		// (set) Token: 0x0600B581 RID: 46465 RVA: 0x001B19AA File Offset: 0x001AFBAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionInfrastructureV2ItemDeliveryType Type
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

		// Token: 0x17002495 RID: 9365
		// (get) Token: 0x0600B582 RID: 46466 RVA: 0x001B19B3 File Offset: 0x001AFBB3
		// (set) Token: 0x0600B583 RID: 46467 RVA: 0x001B19BB File Offset: 0x001AFBBB
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

		// Token: 0x0600B584 RID: 46468 RVA: 0x001B19C4 File Offset: 0x001AFBC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrV2HandInData);
		}

		// Token: 0x0600B585 RID: 46469 RVA: 0x001B19D2 File Offset: 0x001AFBD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrV2HandInData other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B586 RID: 46470 RVA: 0x001B1A10 File Offset: 0x001AFC10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != ActionInfrastructureV2ItemDeliveryType.Village)
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

		// Token: 0x0600B587 RID: 46471 RVA: 0x001B1A6E File Offset: 0x001AFC6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B588 RID: 46472 RVA: 0x001B1A7B File Offset: 0x001AFC7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B589 RID: 46473 RVA: 0x001B1A84 File Offset: 0x001AFC84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != ActionInfrastructureV2ItemDeliveryType.Village)
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

		// Token: 0x0600B58A RID: 46474 RVA: 0x001B1ADC File Offset: 0x001AFCDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != ActionInfrastructureV2ItemDeliveryType.Village)
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

		// Token: 0x0600B58B RID: 46475 RVA: 0x001B1B34 File Offset: 0x001AFD34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrV2HandInData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != ActionInfrastructureV2ItemDeliveryType.Village)
			{
				this.Type = other.Type;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B58C RID: 46476 RVA: 0x001B1B84 File Offset: 0x001AFD84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B58D RID: 46477 RVA: 0x001B1B90 File Offset: 0x001AFD90
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
					this.Type = (ActionInfrastructureV2ItemDeliveryType)input.ReadEnum();
				}
			}
		}

		// Token: 0x040050DA RID: 20698
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050DB RID: 20699
		public const int TypeFieldNumber = 1;

		// Token: 0x040050DC RID: 20700
		private ActionInfrastructureV2ItemDeliveryType type_;

		// Token: 0x040050DD RID: 20701
		public const int IdFieldNumber = 2;

		// Token: 0x040050DE RID: 20702
		private int id_;
	}
}
