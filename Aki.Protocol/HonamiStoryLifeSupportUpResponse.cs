using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000786 RID: 1926
	[NetMessage(EMessageId.HonamiStoryLifeSupportUpResponse)]
	public sealed class HonamiStoryLifeSupportUpResponse : IMessage<HonamiStoryLifeSupportUpResponse>, IMessage, IEquatable<HonamiStoryLifeSupportUpResponse>, IDeepCloneable<HonamiStoryLifeSupportUpResponse>, IBufferMessage
	{
		// Token: 0x0600ADFD RID: 44541 RVA: 0x001A22BD File Offset: 0x001A04BD
		[NullableContext(1)]
		public static HonamiStoryLifeSupportUpResponse Create()
		{
			return new HonamiStoryLifeSupportUpResponse();
		}

		// Token: 0x1700231B RID: 8987
		// (get) Token: 0x0600ADFE RID: 44542 RVA: 0x001A22C4 File Offset: 0x001A04C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700231C RID: 8988
		// (get) Token: 0x0600ADFF RID: 44543 RVA: 0x001A22C7 File Offset: 0x001A04C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryLifeSupportUpResponse.Descriptor;
			}
		}

		// Token: 0x0600AE00 RID: 44544 RVA: 0x001A22CE File Offset: 0x001A04CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryLifeSupportUpResponse()
		{
		}

		// Token: 0x0600AE01 RID: 44545 RVA: 0x001A22D6 File Offset: 0x001A04D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryLifeSupportUpResponse(HonamiStoryLifeSupportUpResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.activityId_ = other.activityId_;
			this.lifeSupportLevel_ = other.lifeSupportLevel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AE02 RID: 44546 RVA: 0x001A2313 File Offset: 0x001A0513
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryLifeSupportUpResponse Clone()
		{
			return new HonamiStoryLifeSupportUpResponse(this);
		}

		// Token: 0x1700231D RID: 8989
		// (get) Token: 0x0600AE03 RID: 44547 RVA: 0x001A231B File Offset: 0x001A051B
		// (set) Token: 0x0600AE04 RID: 44548 RVA: 0x001A2323 File Offset: 0x001A0523
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

		// Token: 0x1700231E RID: 8990
		// (get) Token: 0x0600AE05 RID: 44549 RVA: 0x001A232C File Offset: 0x001A052C
		// (set) Token: 0x0600AE06 RID: 44550 RVA: 0x001A2334 File Offset: 0x001A0534
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

		// Token: 0x1700231F RID: 8991
		// (get) Token: 0x0600AE07 RID: 44551 RVA: 0x001A233D File Offset: 0x001A053D
		// (set) Token: 0x0600AE08 RID: 44552 RVA: 0x001A2345 File Offset: 0x001A0545
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LifeSupportLevel
		{
			get
			{
				return this.lifeSupportLevel_;
			}
			set
			{
				this.lifeSupportLevel_ = value;
			}
		}

		// Token: 0x0600AE09 RID: 44553 RVA: 0x001A234E File Offset: 0x001A054E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryLifeSupportUpResponse);
		}

		// Token: 0x0600AE0A RID: 44554 RVA: 0x001A235C File Offset: 0x001A055C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryLifeSupportUpResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ActivityId == other.ActivityId && this.LifeSupportLevel == other.LifeSupportLevel && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AE0B RID: 44555 RVA: 0x001A23B8 File Offset: 0x001A05B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.LifeSupportLevel != 0)
			{
				num ^= this.LifeSupportLevel.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AE0C RID: 44556 RVA: 0x001A242F File Offset: 0x001A062F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AE0D RID: 44557 RVA: 0x001A243C File Offset: 0x001A063C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AE0E RID: 44558 RVA: 0x001A2448 File Offset: 0x001A0648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ActivityId);
			}
			if (this.LifeSupportLevel != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.LifeSupportLevel);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AE0F RID: 44559 RVA: 0x001A24C0 File Offset: 0x001A06C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.LifeSupportLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LifeSupportLevel);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AE10 RID: 44560 RVA: 0x001A2530 File Offset: 0x001A0730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryLifeSupportUpResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.LifeSupportLevel != 0)
			{
				this.LifeSupportLevel = other.LifeSupportLevel;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AE11 RID: 44561 RVA: 0x001A2594 File Offset: 0x001A0794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AE12 RID: 44562 RVA: 0x001A25A0 File Offset: 0x001A07A0
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
				if (num != 80U)
				{
					if (num != 88U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ErrorCode = (ErrorCode)input.ReadEnum();
						}
					}
					else
					{
						this.LifeSupportLevel = input.ReadInt32();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004E9C RID: 20124
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E9D RID: 20125
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04004E9E RID: 20126
		private ErrorCode errorCode_;

		// Token: 0x04004E9F RID: 20127
		public const int ActivityIdFieldNumber = 10;

		// Token: 0x04004EA0 RID: 20128
		private int activityId_;

		// Token: 0x04004EA1 RID: 20129
		public const int LifeSupportLevelFieldNumber = 11;

		// Token: 0x04004EA2 RID: 20130
		private int lifeSupportLevel_;
	}
}
