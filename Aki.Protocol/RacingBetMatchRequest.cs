using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E40 RID: 3648
	[NetMessage(EMessageId.RacingBetMatchRequest)]
	public sealed class RacingBetMatchRequest : IMessage<RacingBetMatchRequest>, IMessage, IEquatable<RacingBetMatchRequest>, IDeepCloneable<RacingBetMatchRequest>, IBufferMessage
	{
		// Token: 0x06013950 RID: 80208 RVA: 0x002D865C File Offset: 0x002D685C
		[NullableContext(1)]
		public static RacingBetMatchRequest Create()
		{
			return new RacingBetMatchRequest();
		}

		// Token: 0x170040EF RID: 16623
		// (get) Token: 0x06013951 RID: 80209 RVA: 0x002D8663 File Offset: 0x002D6863
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170040F0 RID: 16624
		// (get) Token: 0x06013952 RID: 80210 RVA: 0x002D8666 File Offset: 0x002D6866
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetMatchRequest.Descriptor;
			}
		}

		// Token: 0x06013953 RID: 80211 RVA: 0x002D866D File Offset: 0x002D686D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchRequest()
		{
		}

		// Token: 0x06013954 RID: 80212 RVA: 0x002D8675 File Offset: 0x002D6875
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchRequest(RacingBetMatchRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.legMatchId_ = other.legMatchId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013955 RID: 80213 RVA: 0x002D86A6 File Offset: 0x002D68A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchRequest Clone()
		{
			return new RacingBetMatchRequest(this);
		}

		// Token: 0x170040F1 RID: 16625
		// (get) Token: 0x06013956 RID: 80214 RVA: 0x002D86AE File Offset: 0x002D68AE
		// (set) Token: 0x06013957 RID: 80215 RVA: 0x002D86B6 File Offset: 0x002D68B6
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

		// Token: 0x170040F2 RID: 16626
		// (get) Token: 0x06013958 RID: 80216 RVA: 0x002D86BF File Offset: 0x002D68BF
		// (set) Token: 0x06013959 RID: 80217 RVA: 0x002D86C7 File Offset: 0x002D68C7
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

		// Token: 0x0601395A RID: 80218 RVA: 0x002D86D0 File Offset: 0x002D68D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetMatchRequest);
		}

		// Token: 0x0601395B RID: 80219 RVA: 0x002D86DE File Offset: 0x002D68DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetMatchRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.LegMatchId == other.LegMatchId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601395C RID: 80220 RVA: 0x002D871C File Offset: 0x002D691C
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

		// Token: 0x0601395D RID: 80221 RVA: 0x002D8774 File Offset: 0x002D6974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601395E RID: 80222 RVA: 0x002D8781 File Offset: 0x002D6981
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601395F RID: 80223 RVA: 0x002D878C File Offset: 0x002D698C
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
				output.WriteRawTag(56);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013960 RID: 80224 RVA: 0x002D87E8 File Offset: 0x002D69E8
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

		// Token: 0x06013961 RID: 80225 RVA: 0x002D8840 File Offset: 0x002D6A40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetMatchRequest other)
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

		// Token: 0x06013962 RID: 80226 RVA: 0x002D8890 File Offset: 0x002D6A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013963 RID: 80227 RVA: 0x002D889C File Offset: 0x002D6A9C
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

		// Token: 0x040077D4 RID: 30676
		private UnknownFieldSet _unknownFields;

		// Token: 0x040077D5 RID: 30677
		public const int ActivityIdFieldNumber = 7;

		// Token: 0x040077D6 RID: 30678
		private int activityId_;

		// Token: 0x040077D7 RID: 30679
		public const int LegMatchIdFieldNumber = 3;

		// Token: 0x040077D8 RID: 30680
		private int legMatchId_;
	}
}
