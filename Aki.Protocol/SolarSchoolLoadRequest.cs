using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012B0 RID: 4784
	[NetMessage(EMessageId.SolarSchoolLoadRequest)]
	public sealed class SolarSchoolLoadRequest : IMessage<SolarSchoolLoadRequest>, IMessage, IEquatable<SolarSchoolLoadRequest>, IDeepCloneable<SolarSchoolLoadRequest>, IBufferMessage
	{
		// Token: 0x06019894 RID: 104596 RVA: 0x003B98FE File Offset: 0x003B7AFE
		[NullableContext(1)]
		public static SolarSchoolLoadRequest Create()
		{
			return new SolarSchoolLoadRequest();
		}

		// Token: 0x1700566D RID: 22125
		// (get) Token: 0x06019895 RID: 104597 RVA: 0x003B9905 File Offset: 0x003B7B05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700566E RID: 22126
		// (get) Token: 0x06019896 RID: 104598 RVA: 0x003B9908 File Offset: 0x003B7B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SolarSchoolLoadRequest.Descriptor;
			}
		}

		// Token: 0x06019897 RID: 104599 RVA: 0x003B990F File Offset: 0x003B7B0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolLoadRequest()
		{
		}

		// Token: 0x06019898 RID: 104600 RVA: 0x003B9917 File Offset: 0x003B7B17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolLoadRequest(SolarSchoolLoadRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.slotId_ = other.slotId_;
			this.solarSchoolClientResVersion_ = other.solarSchoolClientResVersion_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019899 RID: 104601 RVA: 0x003B9954 File Offset: 0x003B7B54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolLoadRequest Clone()
		{
			return new SolarSchoolLoadRequest(this);
		}

		// Token: 0x1700566F RID: 22127
		// (get) Token: 0x0601989A RID: 104602 RVA: 0x003B995C File Offset: 0x003B7B5C
		// (set) Token: 0x0601989B RID: 104603 RVA: 0x003B9964 File Offset: 0x003B7B64
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

		// Token: 0x17005670 RID: 22128
		// (get) Token: 0x0601989C RID: 104604 RVA: 0x003B996D File Offset: 0x003B7B6D
		// (set) Token: 0x0601989D RID: 104605 RVA: 0x003B9975 File Offset: 0x003B7B75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SlotId
		{
			get
			{
				return this.slotId_;
			}
			set
			{
				this.slotId_ = value;
			}
		}

		// Token: 0x17005671 RID: 22129
		// (get) Token: 0x0601989E RID: 104606 RVA: 0x003B997E File Offset: 0x003B7B7E
		// (set) Token: 0x0601989F RID: 104607 RVA: 0x003B9986 File Offset: 0x003B7B86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SolarSchoolClientResVersion
		{
			get
			{
				return this.solarSchoolClientResVersion_;
			}
			set
			{
				this.solarSchoolClientResVersion_ = value;
			}
		}

		// Token: 0x060198A0 RID: 104608 RVA: 0x003B998F File Offset: 0x003B7B8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SolarSchoolLoadRequest);
		}

		// Token: 0x060198A1 RID: 104609 RVA: 0x003B99A0 File Offset: 0x003B7BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SolarSchoolLoadRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.SlotId == other.SlotId && this.SolarSchoolClientResVersion == other.SolarSchoolClientResVersion && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060198A2 RID: 104610 RVA: 0x003B99FC File Offset: 0x003B7BFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.SlotId != 0)
			{
				num ^= this.SlotId.GetHashCode();
			}
			if (this.SolarSchoolClientResVersion != 0)
			{
				num ^= this.SolarSchoolClientResVersion.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060198A3 RID: 104611 RVA: 0x003B9A6D File Offset: 0x003B7C6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060198A4 RID: 104612 RVA: 0x003B9A7A File Offset: 0x003B7C7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060198A5 RID: 104613 RVA: 0x003B9A84 File Offset: 0x003B7C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SolarSchoolClientResVersion != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SolarSchoolClientResVersion);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ActivityId);
			}
			if (this.SlotId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.SlotId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060198A6 RID: 104614 RVA: 0x003B9AF8 File Offset: 0x003B7CF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.SlotId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SlotId);
			}
			if (this.SolarSchoolClientResVersion != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SolarSchoolClientResVersion);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060198A7 RID: 104615 RVA: 0x003B9B68 File Offset: 0x003B7D68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SolarSchoolLoadRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.SlotId != 0)
			{
				this.SlotId = other.SlotId;
			}
			if (other.SolarSchoolClientResVersion != 0)
			{
				this.SolarSchoolClientResVersion = other.SolarSchoolClientResVersion;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060198A8 RID: 104616 RVA: 0x003B9BCC File Offset: 0x003B7DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060198A9 RID: 104617 RVA: 0x003B9BD8 File Offset: 0x003B7DD8
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
					if (num != 40U)
					{
						if (num != 56U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.SlotId = input.ReadInt32();
						}
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.SolarSchoolClientResVersion = input.ReadInt32();
				}
			}
		}

		// Token: 0x040096E4 RID: 38628
		private UnknownFieldSet _unknownFields;

		// Token: 0x040096E5 RID: 38629
		public const int ActivityIdFieldNumber = 5;

		// Token: 0x040096E6 RID: 38630
		private int activityId_;

		// Token: 0x040096E7 RID: 38631
		public const int SlotIdFieldNumber = 7;

		// Token: 0x040096E8 RID: 38632
		private int slotId_;

		// Token: 0x040096E9 RID: 38633
		public const int SolarSchoolClientResVersionFieldNumber = 1;

		// Token: 0x040096EA RID: 38634
		private int solarSchoolClientResVersion_;
	}
}
