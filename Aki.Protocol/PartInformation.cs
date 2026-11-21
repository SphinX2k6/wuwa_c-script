using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BB5 RID: 2997
	public sealed class PartInformation : IMessage<PartInformation>, IMessage, IEquatable<PartInformation>, IDeepCloneable<PartInformation>, IBufferMessage
	{
		// Token: 0x06010427 RID: 66599 RVA: 0x0025FA59 File Offset: 0x0025DC59
		[NullableContext(1)]
		public static PartInformation Create()
		{
			return new PartInformation();
		}

		// Token: 0x1700354D RID: 13645
		// (get) Token: 0x06010428 RID: 66600 RVA: 0x0025FA60 File Offset: 0x0025DC60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PartInformation> Parser
		{
			get
			{
				return PartInformation._parser;
			}
		}

		// Token: 0x1700354E RID: 13646
		// (get) Token: 0x06010429 RID: 66601 RVA: 0x0025FA67 File Offset: 0x0025DC67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700354F RID: 13647
		// (get) Token: 0x0601042A RID: 66602 RVA: 0x0025FA6A File Offset: 0x0025DC6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PartInformation.Descriptor;
			}
		}

		// Token: 0x0601042B RID: 66603 RVA: 0x0025FA71 File Offset: 0x0025DC71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartInformation()
		{
		}

		// Token: 0x0601042C RID: 66604 RVA: 0x0025FA7C File Offset: 0x0025DC7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartInformation(PartInformation other) : this()
		{
			this.partId_ = other.partId_;
			this.lifeValue_ = other.lifeValue_;
			this.lifeMax_ = other.lifeMax_;
			this.activated_ = other.activated_;
			this.partTag_ = other.partTag_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601042D RID: 66605 RVA: 0x0025FADC File Offset: 0x0025DCDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartInformation Clone()
		{
			return new PartInformation(this);
		}

		// Token: 0x17003550 RID: 13648
		// (get) Token: 0x0601042E RID: 66606 RVA: 0x0025FAE4 File Offset: 0x0025DCE4
		// (set) Token: 0x0601042F RID: 66607 RVA: 0x0025FAEC File Offset: 0x0025DCEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PartId
		{
			get
			{
				return this.partId_;
			}
			set
			{
				this.partId_ = value;
			}
		}

		// Token: 0x17003551 RID: 13649
		// (get) Token: 0x06010430 RID: 66608 RVA: 0x0025FAF5 File Offset: 0x0025DCF5
		// (set) Token: 0x06010431 RID: 66609 RVA: 0x0025FAFD File Offset: 0x0025DCFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float LifeValue
		{
			get
			{
				return this.lifeValue_;
			}
			set
			{
				this.lifeValue_ = value;
			}
		}

		// Token: 0x17003552 RID: 13650
		// (get) Token: 0x06010432 RID: 66610 RVA: 0x0025FB06 File Offset: 0x0025DD06
		// (set) Token: 0x06010433 RID: 66611 RVA: 0x0025FB0E File Offset: 0x0025DD0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float LifeMax
		{
			get
			{
				return this.lifeMax_;
			}
			set
			{
				this.lifeMax_ = value;
			}
		}

		// Token: 0x17003553 RID: 13651
		// (get) Token: 0x06010434 RID: 66612 RVA: 0x0025FB17 File Offset: 0x0025DD17
		// (set) Token: 0x06010435 RID: 66613 RVA: 0x0025FB1F File Offset: 0x0025DD1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Activated
		{
			get
			{
				return this.activated_;
			}
			set
			{
				this.activated_ = value;
			}
		}

		// Token: 0x17003554 RID: 13652
		// (get) Token: 0x06010436 RID: 66614 RVA: 0x0025FB28 File Offset: 0x0025DD28
		// (set) Token: 0x06010437 RID: 66615 RVA: 0x0025FB30 File Offset: 0x0025DD30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PartTag
		{
			get
			{
				return this.partTag_;
			}
			set
			{
				this.partTag_ = value;
			}
		}

		// Token: 0x06010438 RID: 66616 RVA: 0x0025FB39 File Offset: 0x0025DD39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PartInformation);
		}

		// Token: 0x06010439 RID: 66617 RVA: 0x0025FB48 File Offset: 0x0025DD48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PartInformation other)
		{
			return other != null && (other == this || (this.PartId == other.PartId && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.LifeValue, other.LifeValue) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.LifeMax, other.LifeMax) && this.Activated == other.Activated && this.PartTag == other.PartTag && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601043A RID: 66618 RVA: 0x0025FBD8 File Offset: 0x0025DDD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PartId != 0)
			{
				num ^= this.PartId.GetHashCode();
			}
			if (this.LifeValue != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.LifeValue);
			}
			if (this.LifeMax != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.LifeMax);
			}
			if (this.Activated)
			{
				num ^= this.Activated.GetHashCode();
			}
			if (this.PartTag != 0)
			{
				num ^= this.PartTag.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601043B RID: 66619 RVA: 0x0025FC89 File Offset: 0x0025DE89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601043C RID: 66620 RVA: 0x0025FC96 File Offset: 0x0025DE96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601043D RID: 66621 RVA: 0x0025FCA0 File Offset: 0x0025DEA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PartId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PartId);
			}
			if (this.LifeValue != 0f)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.LifeValue);
			}
			if (this.LifeMax != 0f)
			{
				output.WriteRawTag(29);
				output.WriteFloat(this.LifeMax);
			}
			if (this.Activated)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.Activated);
			}
			if (this.PartTag != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.PartTag);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601043E RID: 66622 RVA: 0x0025FD58 File Offset: 0x0025DF58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PartId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PartId);
			}
			if (this.LifeValue != 0f)
			{
				num += 5;
			}
			if (this.LifeMax != 0f)
			{
				num += 5;
			}
			if (this.Activated)
			{
				num += 2;
			}
			if (this.PartTag != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PartTag);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601043F RID: 66623 RVA: 0x0025FDDC File Offset: 0x0025DFDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PartInformation other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PartId != 0)
			{
				this.PartId = other.PartId;
			}
			if (other.LifeValue != 0f)
			{
				this.LifeValue = other.LifeValue;
			}
			if (other.LifeMax != 0f)
			{
				this.LifeMax = other.LifeMax;
			}
			if (other.Activated)
			{
				this.Activated = other.Activated;
			}
			if (other.PartTag != 0)
			{
				this.PartTag = other.PartTag;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010440 RID: 66624 RVA: 0x0025FE72 File Offset: 0x0025E072
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010441 RID: 66625 RVA: 0x0025FE7C File Offset: 0x0025E07C
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
				if (num <= 21U)
				{
					if (num == 8U)
					{
						this.PartId = input.ReadInt32();
						continue;
					}
					if (num == 21U)
					{
						this.LifeValue = input.ReadFloat();
						continue;
					}
				}
				else
				{
					if (num == 29U)
					{
						this.LifeMax = input.ReadFloat();
						continue;
					}
					if (num == 32U)
					{
						this.Activated = input.ReadBool();
						continue;
					}
					if (num == 40U)
					{
						this.PartTag = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040067C5 RID: 26565
		private static readonly MessageParser<PartInformation> _parser = new MessageParser<PartInformation>(() => new PartInformation());

		// Token: 0x040067C6 RID: 26566
		private UnknownFieldSet _unknownFields;

		// Token: 0x040067C7 RID: 26567
		public const int PartIdFieldNumber = 1;

		// Token: 0x040067C8 RID: 26568
		private int partId_;

		// Token: 0x040067C9 RID: 26569
		public const int LifeValueFieldNumber = 2;

		// Token: 0x040067CA RID: 26570
		private float lifeValue_;

		// Token: 0x040067CB RID: 26571
		public const int LifeMaxFieldNumber = 3;

		// Token: 0x040067CC RID: 26572
		private float lifeMax_;

		// Token: 0x040067CD RID: 26573
		public const int ActivatedFieldNumber = 4;

		// Token: 0x040067CE RID: 26574
		private bool activated_;

		// Token: 0x040067CF RID: 26575
		public const int PartTagFieldNumber = 5;

		// Token: 0x040067D0 RID: 26576
		private int partTag_;
	}
}
