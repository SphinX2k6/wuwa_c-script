using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000798 RID: 1944
	[NetMessage(EMessageId.HonamiStoryUnlockSlotResponse)]
	public sealed class HonamiStoryUnlockSlotResponse : IMessage<HonamiStoryUnlockSlotResponse>, IMessage, IEquatable<HonamiStoryUnlockSlotResponse>, IDeepCloneable<HonamiStoryUnlockSlotResponse>, IBufferMessage
	{
		// Token: 0x0600AF9B RID: 44955 RVA: 0x001A5870 File Offset: 0x001A3A70
		[NullableContext(1)]
		public static HonamiStoryUnlockSlotResponse Create()
		{
			return new HonamiStoryUnlockSlotResponse();
		}

		// Token: 0x17002368 RID: 9064
		// (get) Token: 0x0600AF9C RID: 44956 RVA: 0x001A5877 File Offset: 0x001A3A77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002369 RID: 9065
		// (get) Token: 0x0600AF9D RID: 44957 RVA: 0x001A587A File Offset: 0x001A3A7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryUnlockSlotResponse.Descriptor;
			}
		}

		// Token: 0x0600AF9E RID: 44958 RVA: 0x001A5881 File Offset: 0x001A3A81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryUnlockSlotResponse()
		{
		}

		// Token: 0x0600AF9F RID: 44959 RVA: 0x001A5889 File Offset: 0x001A3A89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryUnlockSlotResponse(HonamiStoryUnlockSlotResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.slotId_ = other.slotId_;
			this.rackIndex_ = other.rackIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AFA0 RID: 44960 RVA: 0x001A58C6 File Offset: 0x001A3AC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryUnlockSlotResponse Clone()
		{
			return new HonamiStoryUnlockSlotResponse(this);
		}

		// Token: 0x1700236A RID: 9066
		// (get) Token: 0x0600AFA1 RID: 44961 RVA: 0x001A58CE File Offset: 0x001A3ACE
		// (set) Token: 0x0600AFA2 RID: 44962 RVA: 0x001A58D6 File Offset: 0x001A3AD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x1700236B RID: 9067
		// (get) Token: 0x0600AFA3 RID: 44963 RVA: 0x001A58DF File Offset: 0x001A3ADF
		// (set) Token: 0x0600AFA4 RID: 44964 RVA: 0x001A58E7 File Offset: 0x001A3AE7
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

		// Token: 0x1700236C RID: 9068
		// (get) Token: 0x0600AFA5 RID: 44965 RVA: 0x001A58F0 File Offset: 0x001A3AF0
		// (set) Token: 0x0600AFA6 RID: 44966 RVA: 0x001A58F8 File Offset: 0x001A3AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RackIndex
		{
			get
			{
				return this.rackIndex_;
			}
			set
			{
				this.rackIndex_ = value;
			}
		}

		// Token: 0x0600AFA7 RID: 44967 RVA: 0x001A5901 File Offset: 0x001A3B01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryUnlockSlotResponse);
		}

		// Token: 0x0600AFA8 RID: 44968 RVA: 0x001A5910 File Offset: 0x001A3B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryUnlockSlotResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.SlotId == other.SlotId && this.RackIndex == other.RackIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AFA9 RID: 44969 RVA: 0x001A596C File Offset: 0x001A3B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.SlotId != 0)
			{
				num ^= this.SlotId.GetHashCode();
			}
			if (this.RackIndex != 0)
			{
				num ^= this.RackIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AFAA RID: 44970 RVA: 0x001A59E3 File Offset: 0x001A3BE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AFAB RID: 44971 RVA: 0x001A59F0 File Offset: 0x001A3BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AFAC RID: 44972 RVA: 0x001A59FC File Offset: 0x001A3BFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.RackIndex != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.RackIndex);
			}
			if (this.SlotId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.SlotId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AFAD RID: 44973 RVA: 0x001A5A70 File Offset: 0x001A3C70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.SlotId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SlotId);
			}
			if (this.RackIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RackIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AFAE RID: 44974 RVA: 0x001A5AE0 File Offset: 0x001A3CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryUnlockSlotResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.SlotId != 0)
			{
				this.SlotId = other.SlotId;
			}
			if (other.RackIndex != 0)
			{
				this.RackIndex = other.RackIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AFAF RID: 44975 RVA: 0x001A5B44 File Offset: 0x001A3D44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AFB0 RID: 44976 RVA: 0x001A5B50 File Offset: 0x001A3D50
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
					if (num != 72U)
					{
						if (num != 104U)
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
						this.RackIndex = input.ReadInt32();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004F5C RID: 20316
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F5D RID: 20317
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04004F5E RID: 20318
		private ErrorCode errorCode_;

		// Token: 0x04004F5F RID: 20319
		public const int SlotIdFieldNumber = 13;

		// Token: 0x04004F60 RID: 20320
		private int slotId_;

		// Token: 0x04004F61 RID: 20321
		public const int RackIndexFieldNumber = 9;

		// Token: 0x04004F62 RID: 20322
		private int rackIndex_;
	}
}
