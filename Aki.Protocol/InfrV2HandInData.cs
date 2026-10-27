using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007F8 RID: 2040
	public sealed class InfrV2HandInData : IMessage<InfrV2HandInData>, IMessage, IEquatable<InfrV2HandInData>, IDeepCloneable<InfrV2HandInData>, IBufferMessage
	{
		// Token: 0x0600B6D0 RID: 46800 RVA: 0x001B4388 File Offset: 0x001B2588
		[NullableContext(1)]
		public static InfrV2HandInData Create()
		{
			return new InfrV2HandInData();
		}

		// Token: 0x170024DC RID: 9436
		// (get) Token: 0x0600B6D1 RID: 46801 RVA: 0x001B438F File Offset: 0x001B258F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170024DD RID: 9437
		// (get) Token: 0x0600B6D2 RID: 46802 RVA: 0x001B4392 File Offset: 0x001B2592
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrV2HandInData.Descriptor;
			}
		}

		// Token: 0x0600B6D3 RID: 46803 RVA: 0x001B4399 File Offset: 0x001B2599
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2HandInData()
		{
		}

		// Token: 0x0600B6D4 RID: 46804 RVA: 0x001B43A1 File Offset: 0x001B25A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2HandInData(InfrV2HandInData other) : this()
		{
			this.type_ = other.type_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B6D5 RID: 46805 RVA: 0x001B43D2 File Offset: 0x001B25D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2HandInData Clone()
		{
			return new InfrV2HandInData(this);
		}

		// Token: 0x170024DE RID: 9438
		// (get) Token: 0x0600B6D6 RID: 46806 RVA: 0x001B43DA File Offset: 0x001B25DA
		// (set) Token: 0x0600B6D7 RID: 46807 RVA: 0x001B43E2 File Offset: 0x001B25E2
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

		// Token: 0x170024DF RID: 9439
		// (get) Token: 0x0600B6D8 RID: 46808 RVA: 0x001B43EB File Offset: 0x001B25EB
		// (set) Token: 0x0600B6D9 RID: 46809 RVA: 0x001B43F3 File Offset: 0x001B25F3
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

		// Token: 0x0600B6DA RID: 46810 RVA: 0x001B43FC File Offset: 0x001B25FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrV2HandInData);
		}

		// Token: 0x0600B6DB RID: 46811 RVA: 0x001B440A File Offset: 0x001B260A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrV2HandInData other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B6DC RID: 46812 RVA: 0x001B4448 File Offset: 0x001B2648
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

		// Token: 0x0600B6DD RID: 46813 RVA: 0x001B44A6 File Offset: 0x001B26A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B6DE RID: 46814 RVA: 0x001B44B3 File Offset: 0x001B26B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B6DF RID: 46815 RVA: 0x001B44BC File Offset: 0x001B26BC
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

		// Token: 0x0600B6E0 RID: 46816 RVA: 0x001B4514 File Offset: 0x001B2714
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

		// Token: 0x0600B6E1 RID: 46817 RVA: 0x001B456C File Offset: 0x001B276C
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

		// Token: 0x0600B6E2 RID: 46818 RVA: 0x001B45BC File Offset: 0x001B27BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B6E3 RID: 46819 RVA: 0x001B45C8 File Offset: 0x001B27C8
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

		// Token: 0x040050E1 RID: 20705
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050E2 RID: 20706
		public const int TypeFieldNumber = 1;

		// Token: 0x040050E3 RID: 20707
		private ActionInfrastructureV2ItemDeliveryType type_;

		// Token: 0x040050E4 RID: 20708
		public const int IdFieldNumber = 2;

		// Token: 0x040050E5 RID: 20709
		private int id_;
	}
}
