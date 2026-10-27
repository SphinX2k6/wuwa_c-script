using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000599 RID: 1433
	[NetMessage(EMessageId.FlagChallengePerRoleLevelNotify)]
	public sealed class FlagChallengePerRoleLevelNotify : IMessage<FlagChallengePerRoleLevelNotify>, IMessage, IEquatable<FlagChallengePerRoleLevelNotify>, IDeepCloneable<FlagChallengePerRoleLevelNotify>, IBufferMessage
	{
		// Token: 0x060084B1 RID: 33969 RVA: 0x0013F429 File Offset: 0x0013D629
		[NullableContext(1)]
		public static FlagChallengePerRoleLevelNotify Create()
		{
			return new FlagChallengePerRoleLevelNotify();
		}

		// Token: 0x170019DD RID: 6621
		// (get) Token: 0x060084B2 RID: 33970 RVA: 0x0013F430 File Offset: 0x0013D630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019DE RID: 6622
		// (get) Token: 0x060084B3 RID: 33971 RVA: 0x0013F433 File Offset: 0x0013D633
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlagChallengePerRoleLevelNotify.Descriptor;
			}
		}

		// Token: 0x060084B4 RID: 33972 RVA: 0x0013F43A File Offset: 0x0013D63A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengePerRoleLevelNotify()
		{
		}

		// Token: 0x060084B5 RID: 33973 RVA: 0x0013F444 File Offset: 0x0013D644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengePerRoleLevelNotify(FlagChallengePerRoleLevelNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.flagChallengeRoleLevelInfo_ = ((other.flagChallengeRoleLevelInfo_ != null) ? other.flagChallengeRoleLevelInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060084B6 RID: 33974 RVA: 0x0013F490 File Offset: 0x0013D690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengePerRoleLevelNotify Clone()
		{
			return new FlagChallengePerRoleLevelNotify(this);
		}

		// Token: 0x170019DF RID: 6623
		// (get) Token: 0x060084B7 RID: 33975 RVA: 0x0013F498 File Offset: 0x0013D698
		// (set) Token: 0x060084B8 RID: 33976 RVA: 0x0013F4A0 File Offset: 0x0013D6A0
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

		// Token: 0x170019E0 RID: 6624
		// (get) Token: 0x060084B9 RID: 33977 RVA: 0x0013F4A9 File Offset: 0x0013D6A9
		// (set) Token: 0x060084BA RID: 33978 RVA: 0x0013F4B1 File Offset: 0x0013D6B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeRoleLevelInfo FlagChallengeRoleLevelInfo
		{
			get
			{
				return this.flagChallengeRoleLevelInfo_;
			}
			set
			{
				this.flagChallengeRoleLevelInfo_ = value;
			}
		}

		// Token: 0x060084BB RID: 33979 RVA: 0x0013F4BA File Offset: 0x0013D6BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlagChallengePerRoleLevelNotify);
		}

		// Token: 0x060084BC RID: 33980 RVA: 0x0013F4C8 File Offset: 0x0013D6C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlagChallengePerRoleLevelNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this.FlagChallengeRoleLevelInfo, other.FlagChallengeRoleLevelInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060084BD RID: 33981 RVA: 0x0013F518 File Offset: 0x0013D718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.flagChallengeRoleLevelInfo_ != null)
			{
				num ^= this.FlagChallengeRoleLevelInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060084BE RID: 33982 RVA: 0x0013F56D File Offset: 0x0013D76D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060084BF RID: 33983 RVA: 0x0013F57A File Offset: 0x0013D77A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060084C0 RID: 33984 RVA: 0x0013F584 File Offset: 0x0013D784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.flagChallengeRoleLevelInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.FlagChallengeRoleLevelInfo);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060084C1 RID: 33985 RVA: 0x0013F5E0 File Offset: 0x0013D7E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.flagChallengeRoleLevelInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FlagChallengeRoleLevelInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060084C2 RID: 33986 RVA: 0x0013F638 File Offset: 0x0013D838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlagChallengePerRoleLevelNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.flagChallengeRoleLevelInfo_ != null)
			{
				if (this.flagChallengeRoleLevelInfo_ == null)
				{
					this.FlagChallengeRoleLevelInfo = new FlagChallengeRoleLevelInfo();
				}
				this.FlagChallengeRoleLevelInfo.MergeFrom(other.FlagChallengeRoleLevelInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060084C3 RID: 33987 RVA: 0x0013F6A0 File Offset: 0x0013D8A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060084C4 RID: 33988 RVA: 0x0013F6AC File Offset: 0x0013D8AC
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
				if (num != 82U)
				{
					if (num != 112U)
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
					if (this.flagChallengeRoleLevelInfo_ == null)
					{
						this.FlagChallengeRoleLevelInfo = new FlagChallengeRoleLevelInfo();
					}
					input.ReadMessage(this.FlagChallengeRoleLevelInfo);
				}
			}
		}

		// Token: 0x040041CD RID: 16845
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041CE RID: 16846
		public const int ActivityIdFieldNumber = 14;

		// Token: 0x040041CF RID: 16847
		private int activityId_;

		// Token: 0x040041D0 RID: 16848
		public const int FlagChallengeRoleLevelInfoFieldNumber = 10;

		// Token: 0x040041D1 RID: 16849
		private FlagChallengeRoleLevelInfo flagChallengeRoleLevelInfo_;
	}
}
