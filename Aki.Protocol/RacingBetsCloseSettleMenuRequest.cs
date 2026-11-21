using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E3D RID: 3645
	[NetMessage(EMessageId.RacingBetsCloseSettleMenuRequest)]
	public sealed class RacingBetsCloseSettleMenuRequest : IMessage<RacingBetsCloseSettleMenuRequest>, IMessage, IEquatable<RacingBetsCloseSettleMenuRequest>, IDeepCloneable<RacingBetsCloseSettleMenuRequest>, IBufferMessage
	{
		// Token: 0x0601399F RID: 80287 RVA: 0x002DA35B File Offset: 0x002D855B
		[NullableContext(1)]
		public static RacingBetsCloseSettleMenuRequest Create()
		{
			return new RacingBetsCloseSettleMenuRequest();
		}

		// Token: 0x17004113 RID: 16659
		// (get) Token: 0x060139A0 RID: 80288 RVA: 0x002DA362 File Offset: 0x002D8562
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004114 RID: 16660
		// (get) Token: 0x060139A1 RID: 80289 RVA: 0x002DA365 File Offset: 0x002D8565
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsCloseSettleMenuRequest.Descriptor;
			}
		}

		// Token: 0x060139A2 RID: 80290 RVA: 0x002DA36C File Offset: 0x002D856C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsCloseSettleMenuRequest()
		{
		}

		// Token: 0x060139A3 RID: 80291 RVA: 0x002DA374 File Offset: 0x002D8574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsCloseSettleMenuRequest(RacingBetsCloseSettleMenuRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.legMatchId_ = other.legMatchId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060139A4 RID: 80292 RVA: 0x002DA3A5 File Offset: 0x002D85A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsCloseSettleMenuRequest Clone()
		{
			return new RacingBetsCloseSettleMenuRequest(this);
		}

		// Token: 0x17004115 RID: 16661
		// (get) Token: 0x060139A5 RID: 80293 RVA: 0x002DA3AD File Offset: 0x002D85AD
		// (set) Token: 0x060139A6 RID: 80294 RVA: 0x002DA3B5 File Offset: 0x002D85B5
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

		// Token: 0x17004116 RID: 16662
		// (get) Token: 0x060139A7 RID: 80295 RVA: 0x002DA3BE File Offset: 0x002D85BE
		// (set) Token: 0x060139A8 RID: 80296 RVA: 0x002DA3C6 File Offset: 0x002D85C6
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

		// Token: 0x060139A9 RID: 80297 RVA: 0x002DA3CF File Offset: 0x002D85CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsCloseSettleMenuRequest);
		}

		// Token: 0x060139AA RID: 80298 RVA: 0x002DA3DD File Offset: 0x002D85DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsCloseSettleMenuRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.LegMatchId == other.LegMatchId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060139AB RID: 80299 RVA: 0x002DA41C File Offset: 0x002D861C
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060139AC RID: 80300 RVA: 0x002DA474 File Offset: 0x002D8674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060139AD RID: 80301 RVA: 0x002DA481 File Offset: 0x002D8681
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060139AE RID: 80302 RVA: 0x002DA48C File Offset: 0x002D868C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LegMatchId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.LegMatchId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060139AF RID: 80303 RVA: 0x002DA4E8 File Offset: 0x002D86E8
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060139B0 RID: 80304 RVA: 0x002DA540 File Offset: 0x002D8740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsCloseSettleMenuRequest other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060139B1 RID: 80305 RVA: 0x002DA590 File Offset: 0x002D8790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060139B2 RID: 80306 RVA: 0x002DA59C File Offset: 0x002D879C
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
					if (num != 120U)
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
					this.LegMatchId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400787A RID: 30842
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400787B RID: 30843
		public const int ActivityIdFieldNumber = 15;

		// Token: 0x0400787C RID: 30844
		private int activityId_;

		// Token: 0x0400787D RID: 30845
		public const int LegMatchIdFieldNumber = 3;

		// Token: 0x0400787E RID: 30846
		private int legMatchId_;
	}
}
