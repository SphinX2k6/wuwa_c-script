using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012C1 RID: 4801
	[NetMessage(EMessageId.SolarSchoolSaveRequest)]
	public sealed class SolarSchoolSaveRequest : IMessage<SolarSchoolSaveRequest>, IMessage, IEquatable<SolarSchoolSaveRequest>, IDeepCloneable<SolarSchoolSaveRequest>, IBufferMessage
	{
		// Token: 0x06019A0F RID: 104975 RVA: 0x003BD60F File Offset: 0x003BB80F
		[NullableContext(1)]
		public static SolarSchoolSaveRequest Create()
		{
			return new SolarSchoolSaveRequest();
		}

		// Token: 0x170056C8 RID: 22216
		// (get) Token: 0x06019A10 RID: 104976 RVA: 0x003BD616 File Offset: 0x003BB816
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170056C9 RID: 22217
		// (get) Token: 0x06019A11 RID: 104977 RVA: 0x003BD619 File Offset: 0x003BB819
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SolarSchoolSaveRequest.Descriptor;
			}
		}

		// Token: 0x06019A12 RID: 104978 RVA: 0x003BD620 File Offset: 0x003BB820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolSaveRequest()
		{
		}

		// Token: 0x06019A13 RID: 104979 RVA: 0x003BD628 File Offset: 0x003BB828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolSaveRequest(SolarSchoolSaveRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.savePb_ = ((other.savePb_ != null) ? other.savePb_.Clone() : null);
			this.reason_ = other.reason_;
			this.loadSourceSlotId_ = other.loadSourceSlotId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019A14 RID: 104980 RVA: 0x003BD68C File Offset: 0x003BB88C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolSaveRequest Clone()
		{
			return new SolarSchoolSaveRequest(this);
		}

		// Token: 0x170056CA RID: 22218
		// (get) Token: 0x06019A15 RID: 104981 RVA: 0x003BD694 File Offset: 0x003BB894
		// (set) Token: 0x06019A16 RID: 104982 RVA: 0x003BD69C File Offset: 0x003BB89C
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

		// Token: 0x170056CB RID: 22219
		// (get) Token: 0x06019A17 RID: 104983 RVA: 0x003BD6A5 File Offset: 0x003BB8A5
		// (set) Token: 0x06019A18 RID: 104984 RVA: 0x003BD6AD File Offset: 0x003BB8AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolSavePb SavePb
		{
			get
			{
				return this.savePb_;
			}
			set
			{
				this.savePb_ = value;
			}
		}

		// Token: 0x170056CC RID: 22220
		// (get) Token: 0x06019A19 RID: 104985 RVA: 0x003BD6B6 File Offset: 0x003BB8B6
		// (set) Token: 0x06019A1A RID: 104986 RVA: 0x003BD6BE File Offset: 0x003BB8BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolSaveReason Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		// Token: 0x170056CD RID: 22221
		// (get) Token: 0x06019A1B RID: 104987 RVA: 0x003BD6C7 File Offset: 0x003BB8C7
		// (set) Token: 0x06019A1C RID: 104988 RVA: 0x003BD6CF File Offset: 0x003BB8CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LoadSourceSlotId
		{
			get
			{
				return this.loadSourceSlotId_;
			}
			set
			{
				this.loadSourceSlotId_ = value;
			}
		}

		// Token: 0x06019A1D RID: 104989 RVA: 0x003BD6D8 File Offset: 0x003BB8D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SolarSchoolSaveRequest);
		}

		// Token: 0x06019A1E RID: 104990 RVA: 0x003BD6E8 File Offset: 0x003BB8E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SolarSchoolSaveRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this.SavePb, other.SavePb) && this.Reason == other.Reason && this.LoadSourceSlotId == other.LoadSourceSlotId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019A1F RID: 104991 RVA: 0x003BD758 File Offset: 0x003BB958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.savePb_ != null)
			{
				num ^= this.SavePb.GetHashCode();
			}
			if (this.Reason != SolarSchoolSaveReason.SolarSchoolReasonManual)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this.LoadSourceSlotId != 0)
			{
				num ^= this.LoadSourceSlotId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019A20 RID: 104992 RVA: 0x003BD7E5 File Offset: 0x003BB9E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019A21 RID: 104993 RVA: 0x003BD7F2 File Offset: 0x003BB9F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019A22 RID: 104994 RVA: 0x003BD7FC File Offset: 0x003BB9FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.savePb_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.SavePb);
			}
			if (this.Reason != SolarSchoolSaveReason.SolarSchoolReasonManual)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.Reason);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ActivityId);
			}
			if (this.LoadSourceSlotId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.LoadSourceSlotId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019A23 RID: 104995 RVA: 0x003BD890 File Offset: 0x003BBA90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.savePb_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SavePb);
			}
			if (this.Reason != SolarSchoolSaveReason.SolarSchoolReasonManual)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Reason);
			}
			if (this.LoadSourceSlotId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LoadSourceSlotId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019A24 RID: 104996 RVA: 0x003BD918 File Offset: 0x003BBB18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SolarSchoolSaveRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.savePb_ != null)
			{
				if (this.savePb_ == null)
				{
					this.SavePb = new SolarSchoolSavePb();
				}
				this.SavePb.MergeFrom(other.SavePb);
			}
			if (other.Reason != SolarSchoolSaveReason.SolarSchoolReasonManual)
			{
				this.Reason = other.Reason;
			}
			if (other.LoadSourceSlotId != 0)
			{
				this.LoadSourceSlotId = other.LoadSourceSlotId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019A25 RID: 104997 RVA: 0x003BD9A8 File Offset: 0x003BBBA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019A26 RID: 104998 RVA: 0x003BD9B4 File Offset: 0x003BBBB4
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
				if (num <= 56U)
				{
					if (num == 18U)
					{
						if (this.savePb_ == null)
						{
							this.SavePb = new SolarSchoolSavePb();
						}
						input.ReadMessage(this.SavePb);
						continue;
					}
					if (num == 56U)
					{
						this.Reason = (SolarSchoolSaveReason)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.LoadSourceSlotId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009771 RID: 38769
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009772 RID: 38770
		public const int ActivityIdFieldNumber = 8;

		// Token: 0x04009773 RID: 38771
		private int activityId_;

		// Token: 0x04009774 RID: 38772
		public const int SavePbFieldNumber = 2;

		// Token: 0x04009775 RID: 38773
		private SolarSchoolSavePb savePb_;

		// Token: 0x04009776 RID: 38774
		public const int ReasonFieldNumber = 7;

		// Token: 0x04009777 RID: 38775
		private SolarSchoolSaveReason reason_;

		// Token: 0x04009778 RID: 38776
		public const int LoadSourceSlotIdFieldNumber = 13;

		// Token: 0x04009779 RID: 38777
		private int loadSourceSlotId_;
	}
}
