using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E44 RID: 3652
	[NetMessage(EMessageId.RacingBetMatchRoundRequest)]
	public sealed class RacingBetMatchRoundRequest : IMessage<RacingBetMatchRoundRequest>, IMessage, IEquatable<RacingBetMatchRoundRequest>, IDeepCloneable<RacingBetMatchRoundRequest>, IBufferMessage
	{
		// Token: 0x060139AB RID: 80299 RVA: 0x002D951E File Offset: 0x002D771E
		[NullableContext(1)]
		public static RacingBetMatchRoundRequest Create()
		{
			return new RacingBetMatchRoundRequest();
		}

		// Token: 0x17004105 RID: 16645
		// (get) Token: 0x060139AC RID: 80300 RVA: 0x002D9525 File Offset: 0x002D7725
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004106 RID: 16646
		// (get) Token: 0x060139AD RID: 80301 RVA: 0x002D9528 File Offset: 0x002D7728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetMatchRoundRequest.Descriptor;
			}
		}

		// Token: 0x060139AE RID: 80302 RVA: 0x002D952F File Offset: 0x002D772F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchRoundRequest()
		{
		}

		// Token: 0x060139AF RID: 80303 RVA: 0x002D9537 File Offset: 0x002D7737
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchRoundRequest(RacingBetMatchRoundRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.legMatchId_ = other.legMatchId_;
			this.order_ = other.order_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060139B0 RID: 80304 RVA: 0x002D9574 File Offset: 0x002D7774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchRoundRequest Clone()
		{
			return new RacingBetMatchRoundRequest(this);
		}

		// Token: 0x17004107 RID: 16647
		// (get) Token: 0x060139B1 RID: 80305 RVA: 0x002D957C File Offset: 0x002D777C
		// (set) Token: 0x060139B2 RID: 80306 RVA: 0x002D9584 File Offset: 0x002D7784
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

		// Token: 0x17004108 RID: 16648
		// (get) Token: 0x060139B3 RID: 80307 RVA: 0x002D958D File Offset: 0x002D778D
		// (set) Token: 0x060139B4 RID: 80308 RVA: 0x002D9595 File Offset: 0x002D7795
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

		// Token: 0x17004109 RID: 16649
		// (get) Token: 0x060139B5 RID: 80309 RVA: 0x002D959E File Offset: 0x002D779E
		// (set) Token: 0x060139B6 RID: 80310 RVA: 0x002D95A6 File Offset: 0x002D77A6
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

		// Token: 0x060139B7 RID: 80311 RVA: 0x002D95AF File Offset: 0x002D77AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetMatchRoundRequest);
		}

		// Token: 0x060139B8 RID: 80312 RVA: 0x002D95C0 File Offset: 0x002D77C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetMatchRoundRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.LegMatchId == other.LegMatchId && this.Order == other.Order && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060139B9 RID: 80313 RVA: 0x002D961C File Offset: 0x002D781C
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

		// Token: 0x060139BA RID: 80314 RVA: 0x002D968D File Offset: 0x002D788D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060139BB RID: 80315 RVA: 0x002D969A File Offset: 0x002D789A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060139BC RID: 80316 RVA: 0x002D96A4 File Offset: 0x002D78A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Order != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Order);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ActivityId);
			}
			if (this.LegMatchId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.LegMatchId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060139BD RID: 80317 RVA: 0x002D971C File Offset: 0x002D791C
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

		// Token: 0x060139BE RID: 80318 RVA: 0x002D978C File Offset: 0x002D798C
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

		// Token: 0x060139BF RID: 80319 RVA: 0x002D97F0 File Offset: 0x002D79F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060139C0 RID: 80320 RVA: 0x002D97FC File Offset: 0x002D79FC
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
				if (num != 24U)
				{
					if (num != 40U)
					{
						if (num != 72U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.LegMatchId = input.ReadInt32();
						}
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.Order = input.ReadInt32();
				}
			}
		}

		// Token: 0x040077F7 RID: 30711
		private UnknownFieldSet _unknownFields;

		// Token: 0x040077F8 RID: 30712
		public const int ActivityIdFieldNumber = 5;

		// Token: 0x040077F9 RID: 30713
		private int activityId_;

		// Token: 0x040077FA RID: 30714
		public const int LegMatchIdFieldNumber = 9;

		// Token: 0x040077FB RID: 30715
		private int legMatchId_;

		// Token: 0x040077FC RID: 30716
		public const int OrderFieldNumber = 3;

		// Token: 0x040077FD RID: 30717
		private int order_;
	}
}
