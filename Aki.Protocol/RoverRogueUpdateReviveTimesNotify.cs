using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001133 RID: 4403
	[NetMessage(EMessageId.RoverRogueUpdateReviveTimesNotify)]
	public sealed class RoverRogueUpdateReviveTimesNotify : IMessage<RoverRogueUpdateReviveTimesNotify>, IMessage, IEquatable<RoverRogueUpdateReviveTimesNotify>, IDeepCloneable<RoverRogueUpdateReviveTimesNotify>, IBufferMessage
	{
		// Token: 0x060177C2 RID: 96194 RVA: 0x00369431 File Offset: 0x00367631
		[NullableContext(1)]
		public static RoverRogueUpdateReviveTimesNotify Create()
		{
			return new RoverRogueUpdateReviveTimesNotify();
		}

		// Token: 0x17004ED4 RID: 20180
		// (get) Token: 0x060177C3 RID: 96195 RVA: 0x00369438 File Offset: 0x00367638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004ED5 RID: 20181
		// (get) Token: 0x060177C4 RID: 96196 RVA: 0x0036943B File Offset: 0x0036763B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueUpdateReviveTimesNotify.Descriptor;
			}
		}

		// Token: 0x060177C5 RID: 96197 RVA: 0x00369442 File Offset: 0x00367642
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueUpdateReviveTimesNotify()
		{
		}

		// Token: 0x060177C6 RID: 96198 RVA: 0x0036944A File Offset: 0x0036764A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueUpdateReviveTimesNotify(RoverRogueUpdateReviveTimesNotify other) : this()
		{
			this.reviveTimes_ = other.reviveTimes_;
			this.reviveTimesMax_ = other.reviveTimesMax_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060177C7 RID: 96199 RVA: 0x0036947B File Offset: 0x0036767B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueUpdateReviveTimesNotify Clone()
		{
			return new RoverRogueUpdateReviveTimesNotify(this);
		}

		// Token: 0x17004ED6 RID: 20182
		// (get) Token: 0x060177C8 RID: 96200 RVA: 0x00369483 File Offset: 0x00367683
		// (set) Token: 0x060177C9 RID: 96201 RVA: 0x0036948B File Offset: 0x0036768B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ReviveTimes
		{
			get
			{
				return this.reviveTimes_;
			}
			set
			{
				this.reviveTimes_ = value;
			}
		}

		// Token: 0x17004ED7 RID: 20183
		// (get) Token: 0x060177CA RID: 96202 RVA: 0x00369494 File Offset: 0x00367694
		// (set) Token: 0x060177CB RID: 96203 RVA: 0x0036949C File Offset: 0x0036769C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ReviveTimesMax
		{
			get
			{
				return this.reviveTimesMax_;
			}
			set
			{
				this.reviveTimesMax_ = value;
			}
		}

		// Token: 0x060177CC RID: 96204 RVA: 0x003694A5 File Offset: 0x003676A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueUpdateReviveTimesNotify);
		}

		// Token: 0x060177CD RID: 96205 RVA: 0x003694B3 File Offset: 0x003676B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueUpdateReviveTimesNotify other)
		{
			return other != null && (other == this || (this.ReviveTimes == other.ReviveTimes && this.ReviveTimesMax == other.ReviveTimesMax && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060177CE RID: 96206 RVA: 0x003694F4 File Offset: 0x003676F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ReviveTimes != 0)
			{
				num ^= this.ReviveTimes.GetHashCode();
			}
			if (this.ReviveTimesMax != 0)
			{
				num ^= this.ReviveTimesMax.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060177CF RID: 96207 RVA: 0x0036954C File Offset: 0x0036774C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060177D0 RID: 96208 RVA: 0x00369559 File Offset: 0x00367759
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060177D1 RID: 96209 RVA: 0x00369564 File Offset: 0x00367764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ReviveTimesMax != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ReviveTimesMax);
			}
			if (this.ReviveTimes != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ReviveTimes);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060177D2 RID: 96210 RVA: 0x003695C0 File Offset: 0x003677C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ReviveTimes != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ReviveTimes);
			}
			if (this.ReviveTimesMax != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ReviveTimesMax);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060177D3 RID: 96211 RVA: 0x00369618 File Offset: 0x00367818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueUpdateReviveTimesNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ReviveTimes != 0)
			{
				this.ReviveTimes = other.ReviveTimes;
			}
			if (other.ReviveTimesMax != 0)
			{
				this.ReviveTimesMax = other.ReviveTimesMax;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060177D4 RID: 96212 RVA: 0x00369668 File Offset: 0x00367868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060177D5 RID: 96213 RVA: 0x00369674 File Offset: 0x00367874
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
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ReviveTimes = input.ReadInt32();
					}
				}
				else
				{
					this.ReviveTimesMax = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008B9F RID: 35743
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008BA0 RID: 35744
		public const int ReviveTimesFieldNumber = 13;

		// Token: 0x04008BA1 RID: 35745
		private int reviveTimes_;

		// Token: 0x04008BA2 RID: 35746
		public const int ReviveTimesMaxFieldNumber = 10;

		// Token: 0x04008BA3 RID: 35747
		private int reviveTimesMax_;
	}
}
