using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007DD RID: 2013
	public sealed class InfrHandInData : IMessage<InfrHandInData>, IMessage, IEquatable<InfrHandInData>, IDeepCloneable<InfrHandInData>, IBufferMessage
	{
		// Token: 0x0600B4C2 RID: 46274 RVA: 0x001B00B4 File Offset: 0x001AE2B4
		[NullableContext(1)]
		public static InfrHandInData Create()
		{
			return new InfrHandInData();
		}

		// Token: 0x17002475 RID: 9333
		// (get) Token: 0x0600B4C3 RID: 46275 RVA: 0x001B00BB File Offset: 0x001AE2BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002476 RID: 9334
		// (get) Token: 0x0600B4C4 RID: 46276 RVA: 0x001B00BE File Offset: 0x001AE2BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrHandInData.Descriptor;
			}
		}

		// Token: 0x0600B4C5 RID: 46277 RVA: 0x001B00C5 File Offset: 0x001AE2C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrHandInData()
		{
		}

		// Token: 0x0600B4C6 RID: 46278 RVA: 0x001B00CD File Offset: 0x001AE2CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrHandInData(InfrHandInData other) : this()
		{
			this.type_ = other.type_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B4C7 RID: 46279 RVA: 0x001B00FE File Offset: 0x001AE2FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrHandInData Clone()
		{
			return new InfrHandInData(this);
		}

		// Token: 0x17002477 RID: 9335
		// (get) Token: 0x0600B4C8 RID: 46280 RVA: 0x001B0106 File Offset: 0x001AE306
		// (set) Token: 0x0600B4C9 RID: 46281 RVA: 0x001B010E File Offset: 0x001AE30E
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

		// Token: 0x17002478 RID: 9336
		// (get) Token: 0x0600B4CA RID: 46282 RVA: 0x001B0117 File Offset: 0x001AE317
		// (set) Token: 0x0600B4CB RID: 46283 RVA: 0x001B011F File Offset: 0x001AE31F
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

		// Token: 0x0600B4CC RID: 46284 RVA: 0x001B0128 File Offset: 0x001AE328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrHandInData);
		}

		// Token: 0x0600B4CD RID: 46285 RVA: 0x001B0136 File Offset: 0x001AE336
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrHandInData other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B4CE RID: 46286 RVA: 0x001B0174 File Offset: 0x001AE374
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

		// Token: 0x0600B4CF RID: 46287 RVA: 0x001B01D2 File Offset: 0x001AE3D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B4D0 RID: 46288 RVA: 0x001B01DF File Offset: 0x001AE3DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B4D1 RID: 46289 RVA: 0x001B01E8 File Offset: 0x001AE3E8
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

		// Token: 0x0600B4D2 RID: 46290 RVA: 0x001B0240 File Offset: 0x001AE440
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

		// Token: 0x0600B4D3 RID: 46291 RVA: 0x001B0298 File Offset: 0x001AE498
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

		// Token: 0x0600B4D4 RID: 46292 RVA: 0x001B02E8 File Offset: 0x001AE4E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B4D5 RID: 46293 RVA: 0x001B02F4 File Offset: 0x001AE4F4
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

		// Token: 0x0400505E RID: 20574
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400505F RID: 20575
		public const int TypeFieldNumber = 1;

		// Token: 0x04005060 RID: 20576
		private ActionInfrastructureItemDeliveryType type_;

		// Token: 0x04005061 RID: 20577
		public const int IdFieldNumber = 2;

		// Token: 0x04005062 RID: 20578
		private int id_;
	}
}
