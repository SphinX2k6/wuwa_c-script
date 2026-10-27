using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E66 RID: 3686
	[NetMessage(EMessageId.RacingBetsLegMatchInfoRequest)]
	public sealed class RacingBetsLegMatchInfoRequest : IMessage<RacingBetsLegMatchInfoRequest>, IMessage, IEquatable<RacingBetsLegMatchInfoRequest>, IDeepCloneable<RacingBetsLegMatchInfoRequest>, IBufferMessage
	{
		// Token: 0x06013CDB RID: 81115 RVA: 0x002E24B1 File Offset: 0x002E06B1
		[NullableContext(1)]
		public static RacingBetsLegMatchInfoRequest Create()
		{
			return new RacingBetsLegMatchInfoRequest();
		}

		// Token: 0x170041D7 RID: 16855
		// (get) Token: 0x06013CDC RID: 81116 RVA: 0x002E24B8 File Offset: 0x002E06B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170041D8 RID: 16856
		// (get) Token: 0x06013CDD RID: 81117 RVA: 0x002E24BB File Offset: 0x002E06BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsLegMatchInfoRequest.Descriptor;
			}
		}

		// Token: 0x06013CDE RID: 81118 RVA: 0x002E24C2 File Offset: 0x002E06C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsLegMatchInfoRequest()
		{
		}

		// Token: 0x06013CDF RID: 81119 RVA: 0x002E24CA File Offset: 0x002E06CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsLegMatchInfoRequest(RacingBetsLegMatchInfoRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.legMatchId_ = other.legMatchId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013CE0 RID: 81120 RVA: 0x002E24FB File Offset: 0x002E06FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsLegMatchInfoRequest Clone()
		{
			return new RacingBetsLegMatchInfoRequest(this);
		}

		// Token: 0x170041D9 RID: 16857
		// (get) Token: 0x06013CE1 RID: 81121 RVA: 0x002E2503 File Offset: 0x002E0703
		// (set) Token: 0x06013CE2 RID: 81122 RVA: 0x002E250B File Offset: 0x002E070B
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

		// Token: 0x170041DA RID: 16858
		// (get) Token: 0x06013CE3 RID: 81123 RVA: 0x002E2514 File Offset: 0x002E0714
		// (set) Token: 0x06013CE4 RID: 81124 RVA: 0x002E251C File Offset: 0x002E071C
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

		// Token: 0x06013CE5 RID: 81125 RVA: 0x002E2525 File Offset: 0x002E0725
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsLegMatchInfoRequest);
		}

		// Token: 0x06013CE6 RID: 81126 RVA: 0x002E2533 File Offset: 0x002E0733
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsLegMatchInfoRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.LegMatchId == other.LegMatchId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013CE7 RID: 81127 RVA: 0x002E2574 File Offset: 0x002E0774
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

		// Token: 0x06013CE8 RID: 81128 RVA: 0x002E25CC File Offset: 0x002E07CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013CE9 RID: 81129 RVA: 0x002E25D9 File Offset: 0x002E07D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013CEA RID: 81130 RVA: 0x002E25E4 File Offset: 0x002E07E4
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
				output.WriteRawTag(32);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013CEB RID: 81131 RVA: 0x002E2640 File Offset: 0x002E0840
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

		// Token: 0x06013CEC RID: 81132 RVA: 0x002E2698 File Offset: 0x002E0898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsLegMatchInfoRequest other)
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

		// Token: 0x06013CED RID: 81133 RVA: 0x002E26E8 File Offset: 0x002E08E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013CEE RID: 81134 RVA: 0x002E26F4 File Offset: 0x002E08F4
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
					if (num != 32U)
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

		// Token: 0x0400792C RID: 31020
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400792D RID: 31021
		public const int ActivityIdFieldNumber = 4;

		// Token: 0x0400792E RID: 31022
		private int activityId_;

		// Token: 0x0400792F RID: 31023
		public const int LegMatchIdFieldNumber = 3;

		// Token: 0x04007930 RID: 31024
		private int legMatchId_;
	}
}
