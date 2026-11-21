using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E62 RID: 3682
	[NetMessage(EMessageId.RacingBetsRankRequest)]
	public sealed class RacingBetsRankRequest : IMessage<RacingBetsRankRequest>, IMessage, IEquatable<RacingBetsRankRequest>, IDeepCloneable<RacingBetsRankRequest>, IBufferMessage
	{
		// Token: 0x06013CF6 RID: 81142 RVA: 0x002E33F7 File Offset: 0x002E15F7
		[NullableContext(1)]
		public static RacingBetsRankRequest Create()
		{
			return new RacingBetsRankRequest();
		}

		// Token: 0x170041E7 RID: 16871
		// (get) Token: 0x06013CF7 RID: 81143 RVA: 0x002E33FE File Offset: 0x002E15FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170041E8 RID: 16872
		// (get) Token: 0x06013CF8 RID: 81144 RVA: 0x002E3401 File Offset: 0x002E1601
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsRankRequest.Descriptor;
			}
		}

		// Token: 0x06013CF9 RID: 81145 RVA: 0x002E3408 File Offset: 0x002E1608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsRankRequest()
		{
		}

		// Token: 0x06013CFA RID: 81146 RVA: 0x002E3410 File Offset: 0x002E1610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsRankRequest(RacingBetsRankRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013CFB RID: 81147 RVA: 0x002E3435 File Offset: 0x002E1635
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsRankRequest Clone()
		{
			return new RacingBetsRankRequest(this);
		}

		// Token: 0x170041E9 RID: 16873
		// (get) Token: 0x06013CFC RID: 81148 RVA: 0x002E343D File Offset: 0x002E163D
		// (set) Token: 0x06013CFD RID: 81149 RVA: 0x002E3445 File Offset: 0x002E1645
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

		// Token: 0x06013CFE RID: 81150 RVA: 0x002E344E File Offset: 0x002E164E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsRankRequest);
		}

		// Token: 0x06013CFF RID: 81151 RVA: 0x002E345C File Offset: 0x002E165C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsRankRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013D00 RID: 81152 RVA: 0x002E348C File Offset: 0x002E168C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013D01 RID: 81153 RVA: 0x002E34CB File Offset: 0x002E16CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013D02 RID: 81154 RVA: 0x002E34D8 File Offset: 0x002E16D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013D03 RID: 81155 RVA: 0x002E34E1 File Offset: 0x002E16E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013D04 RID: 81156 RVA: 0x002E3514 File Offset: 0x002E1714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013D05 RID: 81157 RVA: 0x002E3552 File Offset: 0x002E1752
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsRankRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013D06 RID: 81158 RVA: 0x002E3583 File Offset: 0x002E1783
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013D07 RID: 81159 RVA: 0x002E358C File Offset: 0x002E178C
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040079A9 RID: 31145
		private UnknownFieldSet _unknownFields;

		// Token: 0x040079AA RID: 31146
		public const int ActivityIdFieldNumber = 11;

		// Token: 0x040079AB RID: 31147
		private int activityId_;
	}
}
