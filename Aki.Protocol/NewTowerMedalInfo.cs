using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B28 RID: 2856
	public sealed class NewTowerMedalInfo : IMessage<NewTowerMedalInfo>, IMessage, IEquatable<NewTowerMedalInfo>, IDeepCloneable<NewTowerMedalInfo>, IBufferMessage
	{
		// Token: 0x0600F836 RID: 63542 RVA: 0x002439E0 File Offset: 0x00241BE0
		[NullableContext(1)]
		public static NewTowerMedalInfo Create()
		{
			return new NewTowerMedalInfo();
		}

		// Token: 0x17003294 RID: 12948
		// (get) Token: 0x0600F837 RID: 63543 RVA: 0x002439E7 File Offset: 0x00241BE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NewTowerMedalInfo> Parser
		{
			get
			{
				return NewTowerMedalInfo._parser;
			}
		}

		// Token: 0x17003295 RID: 12949
		// (get) Token: 0x0600F838 RID: 63544 RVA: 0x002439EE File Offset: 0x00241BEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003296 RID: 12950
		// (get) Token: 0x0600F839 RID: 63545 RVA: 0x002439F1 File Offset: 0x00241BF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerMedalInfo.Descriptor;
			}
		}

		// Token: 0x0600F83A RID: 63546 RVA: 0x002439F8 File Offset: 0x00241BF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerMedalInfo()
		{
		}

		// Token: 0x0600F83B RID: 63547 RVA: 0x00243A00 File Offset: 0x00241C00
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

		// Token: 0x0600F83C RID: 63548 RVA: 0x00243A60 File Offset: 0x00241C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerMedalInfo Clone()
		{
			return new NewTowerMedalInfo(this);
		}

		// Token: 0x17003297 RID: 12951
		// (get) Token: 0x0600F83D RID: 63549 RVA: 0x00243A68 File Offset: 0x00241C68
		// (set) Token: 0x0600F83E RID: 63550 RVA: 0x00243A70 File Offset: 0x00241C70
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

		// Token: 0x17003298 RID: 12952
		// (get) Token: 0x0600F83F RID: 63551 RVA: 0x00243A79 File Offset: 0x00241C79
		// (set) Token: 0x0600F840 RID: 63552 RVA: 0x00243A81 File Offset: 0x00241C81
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

		// Token: 0x17003299 RID: 12953
		// (get) Token: 0x0600F841 RID: 63553 RVA: 0x00243A8A File Offset: 0x00241C8A
		// (set) Token: 0x0600F842 RID: 63554 RVA: 0x00243A92 File Offset: 0x00241C92
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

		// Token: 0x1700329A RID: 12954
		// (get) Token: 0x0600F843 RID: 63555 RVA: 0x00243A9B File Offset: 0x00241C9B
		// (set) Token: 0x0600F844 RID: 63556 RVA: 0x00243AA3 File Offset: 0x00241CA3
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

		// Token: 0x1700329B RID: 12955
		// (get) Token: 0x0600F845 RID: 63557 RVA: 0x00243AAC File Offset: 0x00241CAC
		// (set) Token: 0x0600F846 RID: 63558 RVA: 0x00243AB4 File Offset: 0x00241CB4
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

		// Token: 0x0600F847 RID: 63559 RVA: 0x00243ABD File Offset: 0x00241CBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerMedalInfo);
		}

		// Token: 0x0600F848 RID: 63560 RVA: 0x00243ACC File Offset: 0x00241CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerMedalInfo other)
		{
			return other != null && (other == this || (this.MedalGroupId == other.MedalGroupId && this.SeasonId == other.SeasonId && this.CycleId == other.CycleId && this.Progress == other.Progress && this.CompleteTime == other.CompleteTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F849 RID: 63561 RVA: 0x00243B48 File Offset: 0x00241D48
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

		// Token: 0x0600F84A RID: 63562 RVA: 0x00243BEB File Offset: 0x00241DEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F84B RID: 63563 RVA: 0x00243BF8 File Offset: 0x00241DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F84C RID: 63564 RVA: 0x00243C04 File Offset: 0x00241E04
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

		// Token: 0x0600F84D RID: 63565 RVA: 0x00243CB0 File Offset: 0x00241EB0
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

		// Token: 0x0600F84E RID: 63566 RVA: 0x00243D50 File Offset: 0x00241F50
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

		// Token: 0x0600F84F RID: 63567 RVA: 0x00243DDC File Offset: 0x00241FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F850 RID: 63568 RVA: 0x00243DE8 File Offset: 0x00241FE8
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

		// Token: 0x040063EF RID: 25583
		private static readonly MessageParser<NewTowerMedalInfo> _parser = new MessageParser<NewTowerMedalInfo>(() => new NewTowerMedalInfo());

		// Token: 0x040063F0 RID: 25584
		private UnknownFieldSet _unknownFields;

		// Token: 0x040063F1 RID: 25585
		public const int MedalGroupIdFieldNumber = 1;

		// Token: 0x040063F2 RID: 25586
		private int medalGroupId_;

		// Token: 0x040063F3 RID: 25587
		public const int SeasonIdFieldNumber = 2;

		// Token: 0x040063F4 RID: 25588
		private int seasonId_;

		// Token: 0x040063F5 RID: 25589
		public const int CycleIdFieldNumber = 3;

		// Token: 0x040063F6 RID: 25590
		private int cycleId_;

		// Token: 0x040063F7 RID: 25591
		public const int ProgressFieldNumber = 4;

		// Token: 0x040063F8 RID: 25592
		private int progress_;

		// Token: 0x040063F9 RID: 25593
		public const int CompleteTimeFieldNumber = 5;

		// Token: 0x040063FA RID: 25594
		private long completeTime_;
	}
}
