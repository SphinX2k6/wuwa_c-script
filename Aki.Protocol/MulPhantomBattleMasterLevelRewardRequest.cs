using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AE4 RID: 2788
	[NetMessage(EMessageId.MulPhantomBattleMasterLevelRewardRequest)]
	public sealed class MulPhantomBattleMasterLevelRewardRequest : IMessage<MulPhantomBattleMasterLevelRewardRequest>, IMessage, IEquatable<MulPhantomBattleMasterLevelRewardRequest>, IDeepCloneable<MulPhantomBattleMasterLevelRewardRequest>, IBufferMessage
	{
		// Token: 0x0600F27D RID: 62077 RVA: 0x00236653 File Offset: 0x00234853
		[NullableContext(1)]
		public static MulPhantomBattleMasterLevelRewardRequest Create()
		{
			return new MulPhantomBattleMasterLevelRewardRequest();
		}

		// Token: 0x1700315E RID: 12638
		// (get) Token: 0x0600F27E RID: 62078 RVA: 0x0023665A File Offset: 0x0023485A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700315F RID: 12639
		// (get) Token: 0x0600F27F RID: 62079 RVA: 0x0023665D File Offset: 0x0023485D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MulPhantomBattleMasterLevelRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600F280 RID: 62080 RVA: 0x00236664 File Offset: 0x00234864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulPhantomBattleMasterLevelRewardRequest()
		{
		}

		// Token: 0x0600F281 RID: 62081 RVA: 0x00236677 File Offset: 0x00234877
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulPhantomBattleMasterLevelRewardRequest(MulPhantomBattleMasterLevelRewardRequest other) : this()
		{
			this.phantomBattleMasterLevelId_ = other.phantomBattleMasterLevelId_.Clone();
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F282 RID: 62082 RVA: 0x002366AD File Offset: 0x002348AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulPhantomBattleMasterLevelRewardRequest Clone()
		{
			return new MulPhantomBattleMasterLevelRewardRequest(this);
		}

		// Token: 0x17003160 RID: 12640
		// (get) Token: 0x0600F283 RID: 62083 RVA: 0x002366B5 File Offset: 0x002348B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PhantomBattleMasterLevelId
		{
			get
			{
				return this.phantomBattleMasterLevelId_;
			}
		}

		// Token: 0x17003161 RID: 12641
		// (get) Token: 0x0600F284 RID: 62084 RVA: 0x002366BD File Offset: 0x002348BD
		// (set) Token: 0x0600F285 RID: 62085 RVA: 0x002366C5 File Offset: 0x002348C5
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

		// Token: 0x0600F286 RID: 62086 RVA: 0x002366CE File Offset: 0x002348CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MulPhantomBattleMasterLevelRewardRequest);
		}

		// Token: 0x0600F287 RID: 62087 RVA: 0x002366DC File Offset: 0x002348DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MulPhantomBattleMasterLevelRewardRequest other)
		{
			return other != null && (other == this || (this.phantomBattleMasterLevelId_.Equals(other.phantomBattleMasterLevelId_) && this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F288 RID: 62088 RVA: 0x0023672C File Offset: 0x0023492C
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

		// Token: 0x0600F289 RID: 62089 RVA: 0x00236779 File Offset: 0x00234979
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F28A RID: 62090 RVA: 0x00236786 File Offset: 0x00234986
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F28B RID: 62091 RVA: 0x00236790 File Offset: 0x00234990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ActivityId);
			}
			this.phantomBattleMasterLevelId_.WriteTo(ref output, MulPhantomBattleMasterLevelRewardRequest._repeated_phantomBattleMasterLevelId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F28C RID: 62092 RVA: 0x002367E0 File Offset: 0x002349E0
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

		// Token: 0x0600F28D RID: 62093 RVA: 0x00236834 File Offset: 0x00234A34
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

		// Token: 0x0600F28E RID: 62094 RVA: 0x00236881 File Offset: 0x00234A81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F28F RID: 62095 RVA: 0x0023688C File Offset: 0x00234A8C
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
				if (num != 96U)
				{
					if (num != 104U && num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.phantomBattleMasterLevelId_.AddEntriesFrom(ref input, MulPhantomBattleMasterLevelRewardRequest._repeated_phantomBattleMasterLevelId_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040061D0 RID: 25040
		private UnknownFieldSet _unknownFields;

		// Token: 0x040061D1 RID: 25041
		public const int PhantomBattleMasterLevelIdFieldNumber = 13;

		// Token: 0x040061D2 RID: 25042
		private static readonly FieldCodec<int> _repeated_phantomBattleMasterLevelId_codec = FieldCodec.ForInt32(106U);

		// Token: 0x040061D3 RID: 25043
		private readonly RepeatedField<int> phantomBattleMasterLevelId_ = new RepeatedField<int>();

		// Token: 0x040061D4 RID: 25044
		public const int ActivityIdFieldNumber = 12;

		// Token: 0x040061D5 RID: 25045
		private int activityId_;
	}
}
