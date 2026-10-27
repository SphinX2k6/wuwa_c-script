using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A7C RID: 2684
	[NetMessage(EMessageId.MotorOnlineRankRuleIdsNotify)]
	public sealed class MotorOnlineRankRuleIdsNotify : IMessage<MotorOnlineRankRuleIdsNotify>, IMessage, IEquatable<MotorOnlineRankRuleIdsNotify>, IDeepCloneable<MotorOnlineRankRuleIdsNotify>, IBufferMessage
	{
		// Token: 0x0600E9EC RID: 59884 RVA: 0x002225BF File Offset: 0x002207BF
		[NullableContext(1)]
		public static MotorOnlineRankRuleIdsNotify Create()
		{
			return new MotorOnlineRankRuleIdsNotify();
		}

		// Token: 0x17002F78 RID: 12152
		// (get) Token: 0x0600E9ED RID: 59885 RVA: 0x002225C6 File Offset: 0x002207C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F79 RID: 12153
		// (get) Token: 0x0600E9EE RID: 59886 RVA: 0x002225C9 File Offset: 0x002207C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorOnlineRankRuleIdsNotify.Descriptor;
			}
		}

		// Token: 0x0600E9EF RID: 59887 RVA: 0x002225D0 File Offset: 0x002207D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOnlineRankRuleIdsNotify()
		{
		}

		// Token: 0x0600E9F0 RID: 59888 RVA: 0x002225E3 File Offset: 0x002207E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOnlineRankRuleIdsNotify(MotorOnlineRankRuleIdsNotify other) : this()
		{
			this.instId_ = other.instId_;
			this.motorOnlinePlayerInfoList_ = other.motorOnlinePlayerInfoList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E9F1 RID: 59889 RVA: 0x00222619 File Offset: 0x00220819
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOnlineRankRuleIdsNotify Clone()
		{
			return new MotorOnlineRankRuleIdsNotify(this);
		}

		// Token: 0x17002F7A RID: 12154
		// (get) Token: 0x0600E9F2 RID: 59890 RVA: 0x00222621 File Offset: 0x00220821
		// (set) Token: 0x0600E9F3 RID: 59891 RVA: 0x00222629 File Offset: 0x00220829
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

		// Token: 0x17002F7B RID: 12155
		// (get) Token: 0x0600E9F4 RID: 59892 RVA: 0x00222632 File Offset: 0x00220832
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorOnlineParkPlayerRuleInfo> MotorOnlinePlayerInfoList
		{
			get
			{
				return this.motorOnlinePlayerInfoList_;
			}
		}

		// Token: 0x0600E9F5 RID: 59893 RVA: 0x0022263A File Offset: 0x0022083A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorOnlineRankRuleIdsNotify);
		}

		// Token: 0x0600E9F6 RID: 59894 RVA: 0x00222648 File Offset: 0x00220848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorOnlineRankRuleIdsNotify other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.motorOnlinePlayerInfoList_.Equals(other.motorOnlinePlayerInfoList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E9F7 RID: 59895 RVA: 0x00222698 File Offset: 0x00220898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			num ^= this.motorOnlinePlayerInfoList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E9F8 RID: 59896 RVA: 0x002226E5 File Offset: 0x002208E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E9F9 RID: 59897 RVA: 0x002226F2 File Offset: 0x002208F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E9FA RID: 59898 RVA: 0x002226FC File Offset: 0x002208FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.motorOnlinePlayerInfoList_.WriteTo(ref output, MotorOnlineRankRuleIdsNotify._repeated_motorOnlinePlayerInfoList_codec);
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

		// Token: 0x0600E9FB RID: 59899 RVA: 0x0022274C File Offset: 0x0022094C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			num += this.motorOnlinePlayerInfoList_.CalculateSize(MotorOnlineRankRuleIdsNotify._repeated_motorOnlinePlayerInfoList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E9FC RID: 59900 RVA: 0x002227A0 File Offset: 0x002209A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorOnlineRankRuleIdsNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			this.motorOnlinePlayerInfoList_.Add(other.motorOnlinePlayerInfoList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E9FD RID: 59901 RVA: 0x002227ED File Offset: 0x002209ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E9FE RID: 59902 RVA: 0x002227F8 File Offset: 0x002209F8
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
				if (num != 50U)
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
					this.motorOnlinePlayerInfoList_.AddEntriesFrom(ref input, MotorOnlineRankRuleIdsNotify._repeated_motorOnlinePlayerInfoList_codec);
				}
			}
		}

		// Token: 0x04005F0C RID: 24332
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005F0D RID: 24333
		public const int InstIdFieldNumber = 15;

		// Token: 0x04005F0E RID: 24334
		private int instId_;

		// Token: 0x04005F0F RID: 24335
		public const int MotorOnlinePlayerInfoListFieldNumber = 6;

		// Token: 0x04005F10 RID: 24336
		private static readonly FieldCodec<MotorOnlineParkPlayerRuleInfo> _repeated_motorOnlinePlayerInfoList_codec = FieldCodec.ForMessage<MotorOnlineParkPlayerRuleInfo>(50U, MotorOnlineParkPlayerRuleInfo.Parser);

		// Token: 0x04005F11 RID: 24337
		private readonly RepeatedField<MotorOnlineParkPlayerRuleInfo> motorOnlinePlayerInfoList_ = new RepeatedField<MotorOnlineParkPlayerRuleInfo>();
	}
}
