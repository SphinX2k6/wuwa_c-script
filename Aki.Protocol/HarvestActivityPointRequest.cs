using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000746 RID: 1862
	[NetMessage(EMessageId.HarvestActivityPointRequest)]
	public sealed class HarvestActivityPointRequest : IMessage<HarvestActivityPointRequest>, IMessage, IEquatable<HarvestActivityPointRequest>, IDeepCloneable<HarvestActivityPointRequest>, IBufferMessage
	{
		// Token: 0x0600A8A6 RID: 43174 RVA: 0x00195ACB File Offset: 0x00193CCB
		[NullableContext(1)]
		public static HarvestActivityPointRequest Create()
		{
			return new HarvestActivityPointRequest();
		}

		// Token: 0x170021E9 RID: 8681
		// (get) Token: 0x0600A8A7 RID: 43175 RVA: 0x00195AD2 File Offset: 0x00193CD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170021EA RID: 8682
		// (get) Token: 0x0600A8A8 RID: 43176 RVA: 0x00195AD5 File Offset: 0x00193CD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HarvestActivityPointRequest.Descriptor;
			}
		}

		// Token: 0x0600A8A9 RID: 43177 RVA: 0x00195ADC File Offset: 0x00193CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityPointRequest()
		{
		}

		// Token: 0x0600A8AA RID: 43178 RVA: 0x00195AE4 File Offset: 0x00193CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityPointRequest(HarvestActivityPointRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A8AB RID: 43179 RVA: 0x00195B15 File Offset: 0x00193D15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityPointRequest Clone()
		{
			return new HarvestActivityPointRequest(this);
		}

		// Token: 0x170021EB RID: 8683
		// (get) Token: 0x0600A8AC RID: 43180 RVA: 0x00195B1D File Offset: 0x00193D1D
		// (set) Token: 0x0600A8AD RID: 43181 RVA: 0x00195B25 File Offset: 0x00193D25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x170021EC RID: 8684
		// (get) Token: 0x0600A8AE RID: 43182 RVA: 0x00195B2E File Offset: 0x00193D2E
		// (set) Token: 0x0600A8AF RID: 43183 RVA: 0x00195B36 File Offset: 0x00193D36
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

		// Token: 0x0600A8B0 RID: 43184 RVA: 0x00195B3F File Offset: 0x00193D3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HarvestActivityPointRequest);
		}

		// Token: 0x0600A8B1 RID: 43185 RVA: 0x00195B4D File Offset: 0x00193D4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HarvestActivityPointRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A8B2 RID: 43186 RVA: 0x00195B8C File Offset: 0x00193D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
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

		// Token: 0x0600A8B3 RID: 43187 RVA: 0x00195BE4 File Offset: 0x00193DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A8B4 RID: 43188 RVA: 0x00195BF1 File Offset: 0x00193DF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A8B5 RID: 43189 RVA: 0x00195BFC File Offset: 0x00193DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ActivityId);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A8B6 RID: 43190 RVA: 0x00195C58 File Offset: 0x00193E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
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

		// Token: 0x0600A8B7 RID: 43191 RVA: 0x00195CB0 File Offset: 0x00193EB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HarvestActivityPointRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A8B8 RID: 43192 RVA: 0x00195D00 File Offset: 0x00193F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A8B9 RID: 43193 RVA: 0x00195D0C File Offset: 0x00193F0C
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
				if (num != 32U)
				{
					if (num != 112U)
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
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004CE5 RID: 19685
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004CE6 RID: 19686
		public const int ActivityIdFieldNumber = 4;

		// Token: 0x04004CE7 RID: 19687
		private int activityId_;

		// Token: 0x04004CE8 RID: 19688
		public const int IdFieldNumber = 14;

		// Token: 0x04004CE9 RID: 19689
		private int id_;
	}
}
