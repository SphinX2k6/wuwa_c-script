using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000509 RID: 1289
	[NetMessage(EMessageId.FarmGoldLevelDiffRequest)]
	public sealed class FarmGoldLevelDiffRequest : IMessage<FarmGoldLevelDiffRequest>, IMessage, IEquatable<FarmGoldLevelDiffRequest>, IDeepCloneable<FarmGoldLevelDiffRequest>, IBufferMessage
	{
		// Token: 0x06007998 RID: 31128 RVA: 0x00127BA1 File Offset: 0x00125DA1
		[NullableContext(1)]
		public static FarmGoldLevelDiffRequest Create()
		{
			return new FarmGoldLevelDiffRequest();
		}

		// Token: 0x1700178D RID: 6029
		// (get) Token: 0x06007999 RID: 31129 RVA: 0x00127BA8 File Offset: 0x00125DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700178E RID: 6030
		// (get) Token: 0x0600799A RID: 31130 RVA: 0x00127BAB File Offset: 0x00125DAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FarmGoldLevelDiffRequest.Descriptor;
			}
		}

		// Token: 0x0600799B RID: 31131 RVA: 0x00127BB2 File Offset: 0x00125DB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldLevelDiffRequest()
		{
		}

		// Token: 0x0600799C RID: 31132 RVA: 0x00127BBA File Offset: 0x00125DBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldLevelDiffRequest(FarmGoldLevelDiffRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.instId_ = other.instId_;
			this.diff_ = other.diff_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600799D RID: 31133 RVA: 0x00127BF7 File Offset: 0x00125DF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldLevelDiffRequest Clone()
		{
			return new FarmGoldLevelDiffRequest(this);
		}

		// Token: 0x1700178F RID: 6031
		// (get) Token: 0x0600799E RID: 31134 RVA: 0x00127BFF File Offset: 0x00125DFF
		// (set) Token: 0x0600799F RID: 31135 RVA: 0x00127C07 File Offset: 0x00125E07
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

		// Token: 0x17001790 RID: 6032
		// (get) Token: 0x060079A0 RID: 31136 RVA: 0x00127C10 File Offset: 0x00125E10
		// (set) Token: 0x060079A1 RID: 31137 RVA: 0x00127C18 File Offset: 0x00125E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x17001791 RID: 6033
		// (get) Token: 0x060079A2 RID: 31138 RVA: 0x00127C21 File Offset: 0x00125E21
		// (set) Token: 0x060079A3 RID: 31139 RVA: 0x00127C29 File Offset: 0x00125E29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Diff
		{
			get
			{
				return this.diff_;
			}
			set
			{
				this.diff_ = value;
			}
		}

		// Token: 0x060079A4 RID: 31140 RVA: 0x00127C32 File Offset: 0x00125E32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FarmGoldLevelDiffRequest);
		}

		// Token: 0x060079A5 RID: 31141 RVA: 0x00127C40 File Offset: 0x00125E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FarmGoldLevelDiffRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.InstId == other.InstId && this.Diff == other.Diff && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060079A6 RID: 31142 RVA: 0x00127C9C File Offset: 0x00125E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this.Diff != 0)
			{
				num ^= this.Diff.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060079A7 RID: 31143 RVA: 0x00127D0D File Offset: 0x00125F0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060079A8 RID: 31144 RVA: 0x00127D1A File Offset: 0x00125F1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060079A9 RID: 31145 RVA: 0x00127D24 File Offset: 0x00125F24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ActivityId);
			}
			if (this.Diff != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Diff);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.InstId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060079AA RID: 31146 RVA: 0x00127D98 File Offset: 0x00125F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this.Diff != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Diff);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060079AB RID: 31147 RVA: 0x00127E08 File Offset: 0x00126008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FarmGoldLevelDiffRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.Diff != 0)
			{
				this.Diff = other.Diff;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060079AC RID: 31148 RVA: 0x00127E6C File Offset: 0x0012606C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060079AD RID: 31149 RVA: 0x00127E78 File Offset: 0x00126078
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
					if (num != 96U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.InstId = input.ReadInt32();
						}
					}
					else
					{
						this.Diff = input.ReadInt32();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003F03 RID: 16131
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F04 RID: 16132
		public const int ActivityIdFieldNumber = 1;

		// Token: 0x04003F05 RID: 16133
		private int activityId_;

		// Token: 0x04003F06 RID: 16134
		public const int InstIdFieldNumber = 15;

		// Token: 0x04003F07 RID: 16135
		private int instId_;

		// Token: 0x04003F08 RID: 16136
		public const int DiffFieldNumber = 12;

		// Token: 0x04003F09 RID: 16137
		private int diff_;
	}
}
