using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AD3 RID: 2771
	[NetMessage(EMessageId.MulPhantomBattleMasterLevelRewardRequest)]
	public sealed class MulPhantomBattleMasterLevelRewardRequest : IMessage<MulPhantomBattleMasterLevelRewardRequest>, IMessage, IEquatable<MulPhantomBattleMasterLevelRewardRequest>, IDeepCloneable<MulPhantomBattleMasterLevelRewardRequest>, IBufferMessage
	{
		// Token: 0x0600F163 RID: 61795 RVA: 0x00234448 File Offset: 0x00232648
		[NullableContext(1)]
		public static MulPhantomBattleMasterLevelRewardRequest Create()
		{
			return new MulPhantomBattleMasterLevelRewardRequest();
		}

		// Token: 0x17003120 RID: 12576
		// (get) Token: 0x0600F164 RID: 61796 RVA: 0x0023444F File Offset: 0x0023264F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003121 RID: 12577
		// (get) Token: 0x0600F165 RID: 61797 RVA: 0x00234452 File Offset: 0x00232652
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MulPhantomBattleMasterLevelRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600F166 RID: 61798 RVA: 0x00234459 File Offset: 0x00232659
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulPhantomBattleMasterLevelRewardRequest()
		{
		}

		// Token: 0x0600F167 RID: 61799 RVA: 0x0023446C File Offset: 0x0023266C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulPhantomBattleMasterLevelRewardRequest(MulPhantomBattleMasterLevelRewardRequest other) : this()
		{
			this.phantomBattleMasterLevelId_ = other.phantomBattleMasterLevelId_.Clone();
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F168 RID: 61800 RVA: 0x002344A2 File Offset: 0x002326A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulPhantomBattleMasterLevelRewardRequest Clone()
		{
			return new MulPhantomBattleMasterLevelRewardRequest(this);
		}

		// Token: 0x17003122 RID: 12578
		// (get) Token: 0x0600F169 RID: 61801 RVA: 0x002344AA File Offset: 0x002326AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PhantomBattleMasterLevelId
		{
			get
			{
				return this.phantomBattleMasterLevelId_;
			}
		}

		// Token: 0x17003123 RID: 12579
		// (get) Token: 0x0600F16A RID: 61802 RVA: 0x002344B2 File Offset: 0x002326B2
		// (set) Token: 0x0600F16B RID: 61803 RVA: 0x002344BA File Offset: 0x002326BA
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

		// Token: 0x0600F16C RID: 61804 RVA: 0x002344C3 File Offset: 0x002326C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MulPhantomBattleMasterLevelRewardRequest);
		}

		// Token: 0x0600F16D RID: 61805 RVA: 0x002344D4 File Offset: 0x002326D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MulPhantomBattleMasterLevelRewardRequest other)
		{
			return other != null && (other == this || (this.phantomBattleMasterLevelId_.Equals(other.phantomBattleMasterLevelId_) && this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F16E RID: 61806 RVA: 0x00234524 File Offset: 0x00232724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.phantomBattleMasterLevelId_.GetHashCode();
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

		// Token: 0x0600F16F RID: 61807 RVA: 0x00234571 File Offset: 0x00232771
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F170 RID: 61808 RVA: 0x0023457E File Offset: 0x0023277E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F171 RID: 61809 RVA: 0x00234588 File Offset: 0x00232788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phantomBattleMasterLevelId_.WriteTo(ref output, MulPhantomBattleMasterLevelRewardRequest._repeated_phantomBattleMasterLevelId_codec);
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

		// Token: 0x0600F172 RID: 61810 RVA: 0x002345D8 File Offset: 0x002327D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.phantomBattleMasterLevelId_.CalculateSize(MulPhantomBattleMasterLevelRewardRequest._repeated_phantomBattleMasterLevelId_codec);
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

		// Token: 0x0600F173 RID: 61811 RVA: 0x0023462C File Offset: 0x0023282C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MulPhantomBattleMasterLevelRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.phantomBattleMasterLevelId_.Add(other.phantomBattleMasterLevelId_);
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F174 RID: 61812 RVA: 0x00234679 File Offset: 0x00232879
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F175 RID: 61813 RVA: 0x00234684 File Offset: 0x00232884
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
				if (num != 8U && num != 10U)
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
					this.phantomBattleMasterLevelId_.AddEntriesFrom(ref input, MulPhantomBattleMasterLevelRewardRequest._repeated_phantomBattleMasterLevelId_codec);
				}
			}
		}

		// Token: 0x040061D9 RID: 25049
		private UnknownFieldSet _unknownFields;

		// Token: 0x040061DA RID: 25050
		public const int PhantomBattleMasterLevelIdFieldNumber = 1;

		// Token: 0x040061DB RID: 25051
		private static readonly FieldCodec<int> _repeated_phantomBattleMasterLevelId_codec = FieldCodec.ForInt32(10U);

		// Token: 0x040061DC RID: 25052
		private readonly RepeatedField<int> phantomBattleMasterLevelId_ = new RepeatedField<int>();

		// Token: 0x040061DD RID: 25053
		public const int ActivityIdFieldNumber = 7;

		// Token: 0x040061DE RID: 25054
		private int activityId_;
	}
}
