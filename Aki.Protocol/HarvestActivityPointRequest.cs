using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000732 RID: 1842
	[NetMessage(EMessageId.HarvestActivityPointRequest)]
	public sealed class HarvestActivityPointRequest : IMessage<HarvestActivityPointRequest>, IMessage, IEquatable<HarvestActivityPointRequest>, IDeepCloneable<HarvestActivityPointRequest>, IBufferMessage
	{
		// Token: 0x0600A750 RID: 42832 RVA: 0x001930A0 File Offset: 0x001912A0
		[NullableContext(1)]
		public static HarvestActivityPointRequest Create()
		{
			return new HarvestActivityPointRequest();
		}

		// Token: 0x1700219F RID: 8607
		// (get) Token: 0x0600A751 RID: 42833 RVA: 0x001930A7 File Offset: 0x001912A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170021A0 RID: 8608
		// (get) Token: 0x0600A752 RID: 42834 RVA: 0x001930AA File Offset: 0x001912AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HarvestActivityPointRequest.Descriptor;
			}
		}

		// Token: 0x0600A753 RID: 42835 RVA: 0x001930B1 File Offset: 0x001912B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityPointRequest()
		{
		}

		// Token: 0x0600A754 RID: 42836 RVA: 0x001930B9 File Offset: 0x001912B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityPointRequest(HarvestActivityPointRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A755 RID: 42837 RVA: 0x001930EA File Offset: 0x001912EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityPointRequest Clone()
		{
			return new HarvestActivityPointRequest(this);
		}

		// Token: 0x170021A1 RID: 8609
		// (get) Token: 0x0600A756 RID: 42838 RVA: 0x001930F2 File Offset: 0x001912F2
		// (set) Token: 0x0600A757 RID: 42839 RVA: 0x001930FA File Offset: 0x001912FA
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

		// Token: 0x170021A2 RID: 8610
		// (get) Token: 0x0600A758 RID: 42840 RVA: 0x00193103 File Offset: 0x00191303
		// (set) Token: 0x0600A759 RID: 42841 RVA: 0x0019310B File Offset: 0x0019130B
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

		// Token: 0x0600A75A RID: 42842 RVA: 0x00193114 File Offset: 0x00191314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HarvestActivityPointRequest);
		}

		// Token: 0x0600A75B RID: 42843 RVA: 0x00193122 File Offset: 0x00191322
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HarvestActivityPointRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A75C RID: 42844 RVA: 0x00193160 File Offset: 0x00191360
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

		// Token: 0x0600A75D RID: 42845 RVA: 0x001931B8 File Offset: 0x001913B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A75E RID: 42846 RVA: 0x001931C5 File Offset: 0x001913C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A75F RID: 42847 RVA: 0x001931D0 File Offset: 0x001913D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Id);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A760 RID: 42848 RVA: 0x0019322C File Offset: 0x0019142C
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

		// Token: 0x0600A761 RID: 42849 RVA: 0x00193284 File Offset: 0x00191484
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

		// Token: 0x0600A762 RID: 42850 RVA: 0x001932D4 File Offset: 0x001914D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A763 RID: 42851 RVA: 0x001932E0 File Offset: 0x001914E0
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
				if (num != 48U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004CDE RID: 19678
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004CDF RID: 19679
		public const int ActivityIdFieldNumber = 9;

		// Token: 0x04004CE0 RID: 19680
		private int activityId_;

		// Token: 0x04004CE1 RID: 19681
		public const int IdFieldNumber = 6;

		// Token: 0x04004CE2 RID: 19682
		private int id_;
	}
}
