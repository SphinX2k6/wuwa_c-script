using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E34 RID: 3636
	[NetMessage(EMessageId.RacingBetMatchRoundRequest)]
	public sealed class RacingBetMatchRoundRequest : IMessage<RacingBetMatchRoundRequest>, IMessage, IEquatable<RacingBetMatchRoundRequest>, IDeepCloneable<RacingBetMatchRoundRequest>, IBufferMessage
	{
		// Token: 0x060138C6 RID: 80070 RVA: 0x002D7E62 File Offset: 0x002D6062
		[NullableContext(1)]
		public static RacingBetMatchRoundRequest Create()
		{
			return new RacingBetMatchRoundRequest();
		}

		// Token: 0x170040DB RID: 16603
		// (get) Token: 0x060138C7 RID: 80071 RVA: 0x002D7E69 File Offset: 0x002D6069
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170040DC RID: 16604
		// (get) Token: 0x060138C8 RID: 80072 RVA: 0x002D7E6C File Offset: 0x002D606C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetMatchRoundRequest.Descriptor;
			}
		}

		// Token: 0x060138C9 RID: 80073 RVA: 0x002D7E73 File Offset: 0x002D6073
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchRoundRequest()
		{
		}

		// Token: 0x060138CA RID: 80074 RVA: 0x002D7E7B File Offset: 0x002D607B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchRoundRequest(RacingBetMatchRoundRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.legMatchId_ = other.legMatchId_;
			this.order_ = other.order_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060138CB RID: 80075 RVA: 0x002D7EB8 File Offset: 0x002D60B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchRoundRequest Clone()
		{
			return new RacingBetMatchRoundRequest(this);
		}

		// Token: 0x170040DD RID: 16605
		// (get) Token: 0x060138CC RID: 80076 RVA: 0x002D7EC0 File Offset: 0x002D60C0
		// (set) Token: 0x060138CD RID: 80077 RVA: 0x002D7EC8 File Offset: 0x002D60C8
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

		// Token: 0x170040DE RID: 16606
		// (get) Token: 0x060138CE RID: 80078 RVA: 0x002D7ED1 File Offset: 0x002D60D1
		// (set) Token: 0x060138CF RID: 80079 RVA: 0x002D7ED9 File Offset: 0x002D60D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LegMatchId
		{
			get
			{
				return this.legMatchId_;
			}
			set
			{
				this.legMatchId_ = value;
			}
		}

		// Token: 0x170040DF RID: 16607
		// (get) Token: 0x060138D0 RID: 80080 RVA: 0x002D7EE2 File Offset: 0x002D60E2
		// (set) Token: 0x060138D1 RID: 80081 RVA: 0x002D7EEA File Offset: 0x002D60EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Order
		{
			get
			{
				return this.order_;
			}
			set
			{
				this.order_ = value;
			}
		}

		// Token: 0x060138D2 RID: 80082 RVA: 0x002D7EF3 File Offset: 0x002D60F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetMatchRoundRequest);
		}

		// Token: 0x060138D3 RID: 80083 RVA: 0x002D7F04 File Offset: 0x002D6104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetMatchRoundRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.LegMatchId == other.LegMatchId && this.Order == other.Order && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060138D4 RID: 80084 RVA: 0x002D7F60 File Offset: 0x002D6160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.LegMatchId != 0)
			{
				num ^= this.LegMatchId.GetHashCode();
			}
			if (this.Order != 0)
			{
				num ^= this.Order.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060138D5 RID: 80085 RVA: 0x002D7FD1 File Offset: 0x002D61D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060138D6 RID: 80086 RVA: 0x002D7FDE File Offset: 0x002D61DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060138D7 RID: 80087 RVA: 0x002D7FE8 File Offset: 0x002D61E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LegMatchId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.LegMatchId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ActivityId);
			}
			if (this.Order != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Order);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060138D8 RID: 80088 RVA: 0x002D8060 File Offset: 0x002D6260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.LegMatchId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LegMatchId);
			}
			if (this.Order != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Order);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060138D9 RID: 80089 RVA: 0x002D80D0 File Offset: 0x002D62D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetMatchRoundRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.LegMatchId != 0)
			{
				this.LegMatchId = other.LegMatchId;
			}
			if (other.Order != 0)
			{
				this.Order = other.Order;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060138DA RID: 80090 RVA: 0x002D8134 File Offset: 0x002D6334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060138DB RID: 80091 RVA: 0x002D8140 File Offset: 0x002D6340
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
					if (num != 72U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Order = input.ReadInt32();
						}
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.LegMatchId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007821 RID: 30753
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007822 RID: 30754
		public const int ActivityIdFieldNumber = 9;

		// Token: 0x04007823 RID: 30755
		private int activityId_;

		// Token: 0x04007824 RID: 30756
		public const int LegMatchIdFieldNumber = 4;

		// Token: 0x04007825 RID: 30757
		private int legMatchId_;

		// Token: 0x04007826 RID: 30758
		public const int OrderFieldNumber = 12;

		// Token: 0x04007827 RID: 30759
		private int order_;
	}
}
