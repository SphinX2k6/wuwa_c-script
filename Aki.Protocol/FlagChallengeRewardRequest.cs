using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200059A RID: 1434
	[NetMessage(EMessageId.FlagChallengeRewardRequest)]
	public sealed class FlagChallengeRewardRequest : IMessage<FlagChallengeRewardRequest>, IMessage, IEquatable<FlagChallengeRewardRequest>, IDeepCloneable<FlagChallengeRewardRequest>, IBufferMessage
	{
		// Token: 0x060084C5 RID: 33989 RVA: 0x0013F717 File Offset: 0x0013D917
		[NullableContext(1)]
		public static FlagChallengeRewardRequest Create()
		{
			return new FlagChallengeRewardRequest();
		}

		// Token: 0x170019E1 RID: 6625
		// (get) Token: 0x060084C6 RID: 33990 RVA: 0x0013F71E File Offset: 0x0013D91E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019E2 RID: 6626
		// (get) Token: 0x060084C7 RID: 33991 RVA: 0x0013F721 File Offset: 0x0013D921
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlagChallengeRewardRequest.Descriptor;
			}
		}

		// Token: 0x060084C8 RID: 33992 RVA: 0x0013F728 File Offset: 0x0013D928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeRewardRequest()
		{
		}

		// Token: 0x060084C9 RID: 33993 RVA: 0x0013F73B File Offset: 0x0013D93B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeRewardRequest(FlagChallengeRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.flagChallengeTaskIds_ = other.flagChallengeTaskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060084CA RID: 33994 RVA: 0x0013F771 File Offset: 0x0013D971
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeRewardRequest Clone()
		{
			return new FlagChallengeRewardRequest(this);
		}

		// Token: 0x170019E3 RID: 6627
		// (get) Token: 0x060084CB RID: 33995 RVA: 0x0013F779 File Offset: 0x0013D979
		// (set) Token: 0x060084CC RID: 33996 RVA: 0x0013F781 File Offset: 0x0013D981
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

		// Token: 0x170019E4 RID: 6628
		// (get) Token: 0x060084CD RID: 33997 RVA: 0x0013F78A File Offset: 0x0013D98A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> FlagChallengeTaskIds
		{
			get
			{
				return this.flagChallengeTaskIds_;
			}
		}

		// Token: 0x060084CE RID: 33998 RVA: 0x0013F792 File Offset: 0x0013D992
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlagChallengeRewardRequest);
		}

		// Token: 0x060084CF RID: 33999 RVA: 0x0013F7A0 File Offset: 0x0013D9A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlagChallengeRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.flagChallengeTaskIds_.Equals(other.flagChallengeTaskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060084D0 RID: 34000 RVA: 0x0013F7F0 File Offset: 0x0013D9F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.flagChallengeTaskIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060084D1 RID: 34001 RVA: 0x0013F83D File Offset: 0x0013DA3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060084D2 RID: 34002 RVA: 0x0013F84A File Offset: 0x0013DA4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060084D3 RID: 34003 RVA: 0x0013F854 File Offset: 0x0013DA54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.flagChallengeTaskIds_.WriteTo(ref output, FlagChallengeRewardRequest._repeated_flagChallengeTaskIds_codec);
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

		// Token: 0x060084D4 RID: 34004 RVA: 0x0013F8A4 File Offset: 0x0013DAA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.flagChallengeTaskIds_.CalculateSize(FlagChallengeRewardRequest._repeated_flagChallengeTaskIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060084D5 RID: 34005 RVA: 0x0013F8F8 File Offset: 0x0013DAF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlagChallengeRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.flagChallengeTaskIds_.Add(other.flagChallengeTaskIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060084D6 RID: 34006 RVA: 0x0013F945 File Offset: 0x0013DB45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060084D7 RID: 34007 RVA: 0x0013F950 File Offset: 0x0013DB50
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
				if (num != 56U && num != 58U)
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
					this.flagChallengeTaskIds_.AddEntriesFrom(ref input, FlagChallengeRewardRequest._repeated_flagChallengeTaskIds_codec);
				}
			}
		}

		// Token: 0x040041D2 RID: 16850
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041D3 RID: 16851
		public const int ActivityIdFieldNumber = 15;

		// Token: 0x040041D4 RID: 16852
		private int activityId_;

		// Token: 0x040041D5 RID: 16853
		public const int FlagChallengeTaskIdsFieldNumber = 7;

		// Token: 0x040041D6 RID: 16854
		private static readonly FieldCodec<int> _repeated_flagChallengeTaskIds_codec = FieldCodec.ForInt32(58U);

		// Token: 0x040041D7 RID: 16855
		private readonly RepeatedField<int> flagChallengeTaskIds_ = new RepeatedField<int>();
	}
}
