using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B39 RID: 2873
	public sealed class NewTowerMedalInfo : IMessage<NewTowerMedalInfo>, IMessage, IEquatable<NewTowerMedalInfo>, IDeepCloneable<NewTowerMedalInfo>, IBufferMessage
	{
		// Token: 0x0600F950 RID: 63824 RVA: 0x00245BFC File Offset: 0x00243DFC
		[NullableContext(1)]
		public static NewTowerMedalInfo Create()
		{
			return new NewTowerMedalInfo();
		}

		// Token: 0x170032D2 RID: 13010
		// (get) Token: 0x0600F951 RID: 63825 RVA: 0x00245C03 File Offset: 0x00243E03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NewTowerMedalInfo> Parser
		{
			get
			{
				return NewTowerMedalInfo._parser;
			}
		}

		// Token: 0x170032D3 RID: 13011
		// (get) Token: 0x0600F952 RID: 63826 RVA: 0x00245C0A File Offset: 0x00243E0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170032D4 RID: 13012
		// (get) Token: 0x0600F953 RID: 63827 RVA: 0x00245C0D File Offset: 0x00243E0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerMedalInfo.Descriptor;
			}
		}

		// Token: 0x0600F954 RID: 63828 RVA: 0x00245C14 File Offset: 0x00243E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerMedalInfo()
		{
		}

		// Token: 0x0600F955 RID: 63829 RVA: 0x00245C1C File Offset: 0x00243E1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerMedalInfo(NewTowerMedalInfo other) : this()
		{
			this.medalGroupId_ = other.medalGroupId_;
			this.seasonId_ = other.seasonId_;
			this.cycleId_ = other.cycleId_;
			this.progress_ = other.progress_;
			this.completeTime_ = other.completeTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F956 RID: 63830 RVA: 0x00245C7C File Offset: 0x00243E7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerMedalInfo Clone()
		{
			return new NewTowerMedalInfo(this);
		}

		// Token: 0x170032D5 RID: 13013
		// (get) Token: 0x0600F957 RID: 63831 RVA: 0x00245C84 File Offset: 0x00243E84
		// (set) Token: 0x0600F958 RID: 63832 RVA: 0x00245C8C File Offset: 0x00243E8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MedalGroupId
		{
			get
			{
				return this.medalGroupId_;
			}
			set
			{
				this.medalGroupId_ = value;
			}
		}

		// Token: 0x170032D6 RID: 13014
		// (get) Token: 0x0600F959 RID: 63833 RVA: 0x00245C95 File Offset: 0x00243E95
		// (set) Token: 0x0600F95A RID: 63834 RVA: 0x00245C9D File Offset: 0x00243E9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SeasonId
		{
			get
			{
				return this.seasonId_;
			}
			set
			{
				this.seasonId_ = value;
			}
		}

		// Token: 0x170032D7 RID: 13015
		// (get) Token: 0x0600F95B RID: 63835 RVA: 0x00245CA6 File Offset: 0x00243EA6
		// (set) Token: 0x0600F95C RID: 63836 RVA: 0x00245CAE File Offset: 0x00243EAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CycleId
		{
			get
			{
				return this.cycleId_;
			}
			set
			{
				this.cycleId_ = value;
			}
		}

		// Token: 0x170032D8 RID: 13016
		// (get) Token: 0x0600F95D RID: 63837 RVA: 0x00245CB7 File Offset: 0x00243EB7
		// (set) Token: 0x0600F95E RID: 63838 RVA: 0x00245CBF File Offset: 0x00243EBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Progress
		{
			get
			{
				return this.progress_;
			}
			set
			{
				this.progress_ = value;
			}
		}

		// Token: 0x170032D9 RID: 13017
		// (get) Token: 0x0600F95F RID: 63839 RVA: 0x00245CC8 File Offset: 0x00243EC8
		// (set) Token: 0x0600F960 RID: 63840 RVA: 0x00245CD0 File Offset: 0x00243ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CompleteTime
		{
			get
			{
				return this.completeTime_;
			}
			set
			{
				this.completeTime_ = value;
			}
		}

		// Token: 0x0600F961 RID: 63841 RVA: 0x00245CD9 File Offset: 0x00243ED9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerMedalInfo);
		}

		// Token: 0x0600F962 RID: 63842 RVA: 0x00245CE8 File Offset: 0x00243EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerMedalInfo other)
		{
			return other != null && (other == this || (this.MedalGroupId == other.MedalGroupId && this.SeasonId == other.SeasonId && this.CycleId == other.CycleId && this.Progress == other.Progress && this.CompleteTime == other.CompleteTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F963 RID: 63843 RVA: 0x00245D64 File Offset: 0x00243F64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MedalGroupId != 0)
			{
				num ^= this.MedalGroupId.GetHashCode();
			}
			if (this.SeasonId != 0)
			{
				num ^= this.SeasonId.GetHashCode();
			}
			if (this.CycleId != 0)
			{
				num ^= this.CycleId.GetHashCode();
			}
			if (this.Progress != 0)
			{
				num ^= this.Progress.GetHashCode();
			}
			if (this.CompleteTime != 0L)
			{
				num ^= this.CompleteTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F964 RID: 63844 RVA: 0x00245E07 File Offset: 0x00244007
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F965 RID: 63845 RVA: 0x00245E14 File Offset: 0x00244014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F966 RID: 63846 RVA: 0x00245E20 File Offset: 0x00244020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MedalGroupId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.MedalGroupId);
			}
			if (this.SeasonId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SeasonId);
			}
			if (this.CycleId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.CycleId);
			}
			if (this.Progress != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Progress);
			}
			if (this.CompleteTime != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.CompleteTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F967 RID: 63847 RVA: 0x00245ECC File Offset: 0x002440CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MedalGroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MedalGroupId);
			}
			if (this.SeasonId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SeasonId);
			}
			if (this.CycleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CycleId);
			}
			if (this.Progress != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Progress);
			}
			if (this.CompleteTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CompleteTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F968 RID: 63848 RVA: 0x00245F6C File Offset: 0x0024416C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTowerMedalInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MedalGroupId != 0)
			{
				this.MedalGroupId = other.MedalGroupId;
			}
			if (other.SeasonId != 0)
			{
				this.SeasonId = other.SeasonId;
			}
			if (other.CycleId != 0)
			{
				this.CycleId = other.CycleId;
			}
			if (other.Progress != 0)
			{
				this.Progress = other.Progress;
			}
			if (other.CompleteTime != 0L)
			{
				this.CompleteTime = other.CompleteTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F969 RID: 63849 RVA: 0x00245FF8 File Offset: 0x002441F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F96A RID: 63850 RVA: 0x00246004 File Offset: 0x00244204
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.MedalGroupId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.SeasonId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.CycleId = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.Progress = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.CompleteTime = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040063E6 RID: 25574
		private static readonly MessageParser<NewTowerMedalInfo> _parser = new MessageParser<NewTowerMedalInfo>(() => new NewTowerMedalInfo());

		// Token: 0x040063E7 RID: 25575
		private UnknownFieldSet _unknownFields;

		// Token: 0x040063E8 RID: 25576
		public const int MedalGroupIdFieldNumber = 1;

		// Token: 0x040063E9 RID: 25577
		private int medalGroupId_;

		// Token: 0x040063EA RID: 25578
		public const int SeasonIdFieldNumber = 2;

		// Token: 0x040063EB RID: 25579
		private int seasonId_;

		// Token: 0x040063EC RID: 25580
		public const int CycleIdFieldNumber = 3;

		// Token: 0x040063ED RID: 25581
		private int cycleId_;

		// Token: 0x040063EE RID: 25582
		public const int ProgressFieldNumber = 4;

		// Token: 0x040063EF RID: 25583
		private int progress_;

		// Token: 0x040063F0 RID: 25584
		public const int CompleteTimeFieldNumber = 5;

		// Token: 0x040063F1 RID: 25585
		private long completeTime_;
	}
}
