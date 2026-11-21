using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E6F RID: 3695
	[NetMessage(EMessageId.RacingBetsUpdateOddsRequest)]
	public sealed class RacingBetsUpdateOddsRequest : IMessage<RacingBetsUpdateOddsRequest>, IMessage, IEquatable<RacingBetsUpdateOddsRequest>, IDeepCloneable<RacingBetsUpdateOddsRequest>, IBufferMessage
	{
		// Token: 0x06013DFA RID: 81402 RVA: 0x002E550E File Offset: 0x002E370E
		[NullableContext(1)]
		public static RacingBetsUpdateOddsRequest Create()
		{
			return new RacingBetsUpdateOddsRequest();
		}

		// Token: 0x1700421B RID: 16923
		// (get) Token: 0x06013DFB RID: 81403 RVA: 0x002E5515 File Offset: 0x002E3715
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700421C RID: 16924
		// (get) Token: 0x06013DFC RID: 81404 RVA: 0x002E5518 File Offset: 0x002E3718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsUpdateOddsRequest.Descriptor;
			}
		}

		// Token: 0x06013DFD RID: 81405 RVA: 0x002E551F File Offset: 0x002E371F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsUpdateOddsRequest()
		{
		}

		// Token: 0x06013DFE RID: 81406 RVA: 0x002E5527 File Offset: 0x002E3727
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsUpdateOddsRequest(RacingBetsUpdateOddsRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.legMatchId_ = other.legMatchId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013DFF RID: 81407 RVA: 0x002E5558 File Offset: 0x002E3758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsUpdateOddsRequest Clone()
		{
			return new RacingBetsUpdateOddsRequest(this);
		}

		// Token: 0x1700421D RID: 16925
		// (get) Token: 0x06013E00 RID: 81408 RVA: 0x002E5560 File Offset: 0x002E3760
		// (set) Token: 0x06013E01 RID: 81409 RVA: 0x002E5568 File Offset: 0x002E3768
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

		// Token: 0x1700421E RID: 16926
		// (get) Token: 0x06013E02 RID: 81410 RVA: 0x002E5571 File Offset: 0x002E3771
		// (set) Token: 0x06013E03 RID: 81411 RVA: 0x002E5579 File Offset: 0x002E3779
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

		// Token: 0x06013E04 RID: 81412 RVA: 0x002E5582 File Offset: 0x002E3782
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsUpdateOddsRequest);
		}

		// Token: 0x06013E05 RID: 81413 RVA: 0x002E5590 File Offset: 0x002E3790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsUpdateOddsRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.LegMatchId == other.LegMatchId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013E06 RID: 81414 RVA: 0x002E55D0 File Offset: 0x002E37D0
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

		// Token: 0x06013E07 RID: 81415 RVA: 0x002E5628 File Offset: 0x002E3828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013E08 RID: 81416 RVA: 0x002E5635 File Offset: 0x002E3835
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013E09 RID: 81417 RVA: 0x002E5640 File Offset: 0x002E3840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LegMatchId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.LegMatchId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013E0A RID: 81418 RVA: 0x002E569C File Offset: 0x002E389C
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

		// Token: 0x06013E0B RID: 81419 RVA: 0x002E56F4 File Offset: 0x002E38F4
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

		// Token: 0x06013E0C RID: 81420 RVA: 0x002E5744 File Offset: 0x002E3944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013E0D RID: 81421 RVA: 0x002E5750 File Offset: 0x002E3950
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
				if (num != 16U)
				{
					if (num != 56U)
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

		// Token: 0x040079ED RID: 31213
		private UnknownFieldSet _unknownFields;

		// Token: 0x040079EE RID: 31214
		public const int ActivityIdFieldNumber = 7;

		// Token: 0x040079EF RID: 31215
		private int activityId_;

		// Token: 0x040079F0 RID: 31216
		public const int LegMatchIdFieldNumber = 2;

		// Token: 0x040079F1 RID: 31217
		private int legMatchId_;
	}
}
