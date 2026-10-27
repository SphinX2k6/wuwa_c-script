using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E7F RID: 3711
	[NetMessage(EMessageId.RacingBetsUpdateOddsRequest)]
	public sealed class RacingBetsUpdateOddsRequest : IMessage<RacingBetsUpdateOddsRequest>, IMessage, IEquatable<RacingBetsUpdateOddsRequest>, IDeepCloneable<RacingBetsUpdateOddsRequest>, IBufferMessage
	{
		// Token: 0x06013EDF RID: 81631 RVA: 0x002E6BCE File Offset: 0x002E4DCE
		[NullableContext(1)]
		public static RacingBetsUpdateOddsRequest Create()
		{
			return new RacingBetsUpdateOddsRequest();
		}

		// Token: 0x17004245 RID: 16965
		// (get) Token: 0x06013EE0 RID: 81632 RVA: 0x002E6BD5 File Offset: 0x002E4DD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004246 RID: 16966
		// (get) Token: 0x06013EE1 RID: 81633 RVA: 0x002E6BD8 File Offset: 0x002E4DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsUpdateOddsRequest.Descriptor;
			}
		}

		// Token: 0x06013EE2 RID: 81634 RVA: 0x002E6BDF File Offset: 0x002E4DDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsUpdateOddsRequest()
		{
		}

		// Token: 0x06013EE3 RID: 81635 RVA: 0x002E6BE7 File Offset: 0x002E4DE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsUpdateOddsRequest(RacingBetsUpdateOddsRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.legMatchId_ = other.legMatchId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013EE4 RID: 81636 RVA: 0x002E6C18 File Offset: 0x002E4E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsUpdateOddsRequest Clone()
		{
			return new RacingBetsUpdateOddsRequest(this);
		}

		// Token: 0x17004247 RID: 16967
		// (get) Token: 0x06013EE5 RID: 81637 RVA: 0x002E6C20 File Offset: 0x002E4E20
		// (set) Token: 0x06013EE6 RID: 81638 RVA: 0x002E6C28 File Offset: 0x002E4E28
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

		// Token: 0x17004248 RID: 16968
		// (get) Token: 0x06013EE7 RID: 81639 RVA: 0x002E6C31 File Offset: 0x002E4E31
		// (set) Token: 0x06013EE8 RID: 81640 RVA: 0x002E6C39 File Offset: 0x002E4E39
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

		// Token: 0x06013EE9 RID: 81641 RVA: 0x002E6C42 File Offset: 0x002E4E42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsUpdateOddsRequest);
		}

		// Token: 0x06013EEA RID: 81642 RVA: 0x002E6C50 File Offset: 0x002E4E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsUpdateOddsRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.LegMatchId == other.LegMatchId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013EEB RID: 81643 RVA: 0x002E6C90 File Offset: 0x002E4E90
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

		// Token: 0x06013EEC RID: 81644 RVA: 0x002E6CE8 File Offset: 0x002E4EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013EED RID: 81645 RVA: 0x002E6CF5 File Offset: 0x002E4EF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013EEE RID: 81646 RVA: 0x002E6D00 File Offset: 0x002E4F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LegMatchId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LegMatchId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013EEF RID: 81647 RVA: 0x002E6D58 File Offset: 0x002E4F58
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

		// Token: 0x06013EF0 RID: 81648 RVA: 0x002E6DB0 File Offset: 0x002E4FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsUpdateOddsRequest other)
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

		// Token: 0x06013EF1 RID: 81649 RVA: 0x002E6E00 File Offset: 0x002E5000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013EF2 RID: 81650 RVA: 0x002E6E0C File Offset: 0x002E500C
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
					if (num != 24U)
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

		// Token: 0x040079C3 RID: 31171
		private UnknownFieldSet _unknownFields;

		// Token: 0x040079C4 RID: 31172
		public const int ActivityIdFieldNumber = 3;

		// Token: 0x040079C5 RID: 31173
		private int activityId_;

		// Token: 0x040079C6 RID: 31174
		public const int LegMatchIdFieldNumber = 1;

		// Token: 0x040079C7 RID: 31175
		private int legMatchId_;
	}
}
