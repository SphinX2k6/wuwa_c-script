using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009B5 RID: 2485
	public sealed class MatchThreeLevelInfo : IMessage<MatchThreeLevelInfo>, IMessage, IEquatable<MatchThreeLevelInfo>, IDeepCloneable<MatchThreeLevelInfo>, IBufferMessage
	{
		// Token: 0x0600DA67 RID: 55911 RVA: 0x00201A34 File Offset: 0x001FFC34
		[NullableContext(1)]
		public static MatchThreeLevelInfo Create()
		{
			return new MatchThreeLevelInfo();
		}

		// Token: 0x17002C3F RID: 11327
		// (get) Token: 0x0600DA68 RID: 55912 RVA: 0x00201A3B File Offset: 0x001FFC3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MatchThreeLevelInfo> Parser
		{
			get
			{
				return MatchThreeLevelInfo._parser;
			}
		}

		// Token: 0x17002C40 RID: 11328
		// (get) Token: 0x0600DA69 RID: 55913 RVA: 0x00201A42 File Offset: 0x001FFC42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C41 RID: 11329
		// (get) Token: 0x0600DA6A RID: 55914 RVA: 0x00201A45 File Offset: 0x001FFC45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchThreeLevelInfo.Descriptor;
			}
		}

		// Token: 0x0600DA6B RID: 55915 RVA: 0x00201A4C File Offset: 0x001FFC4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeLevelInfo()
		{
		}

		// Token: 0x0600DA6C RID: 55916 RVA: 0x00201A54 File Offset: 0x001FFC54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeLevelInfo(MatchThreeLevelInfo other) : this()
		{
			this.id_ = other.id_;
			this.unlockTime_ = other.unlockTime_;
			this.firstPass_ = other.firstPass_;
			if (other.EndLessCase == MatchThreeLevelInfo.EndLessOneofCase.Score)
			{
				this.Score = other.Score;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DA6D RID: 55917 RVA: 0x00201AB1 File Offset: 0x001FFCB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeLevelInfo Clone()
		{
			return new MatchThreeLevelInfo(this);
		}

		// Token: 0x17002C42 RID: 11330
		// (get) Token: 0x0600DA6E RID: 55918 RVA: 0x00201AB9 File Offset: 0x001FFCB9
		// (set) Token: 0x0600DA6F RID: 55919 RVA: 0x00201AC1 File Offset: 0x001FFCC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17002C43 RID: 11331
		// (get) Token: 0x0600DA70 RID: 55920 RVA: 0x00201ACA File Offset: 0x001FFCCA
		// (set) Token: 0x0600DA71 RID: 55921 RVA: 0x00201AD2 File Offset: 0x001FFCD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long UnlockTime
		{
			get
			{
				return this.unlockTime_;
			}
			set
			{
				this.unlockTime_ = value;
			}
		}

		// Token: 0x17002C44 RID: 11332
		// (get) Token: 0x0600DA72 RID: 55922 RVA: 0x00201ADB File Offset: 0x001FFCDB
		// (set) Token: 0x0600DA73 RID: 55923 RVA: 0x00201AE3 File Offset: 0x001FFCE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool FirstPass
		{
			get
			{
				return this.firstPass_;
			}
			set
			{
				this.firstPass_ = value;
			}
		}

		// Token: 0x17002C45 RID: 11333
		// (get) Token: 0x0600DA74 RID: 55924 RVA: 0x00201AEC File Offset: 0x001FFCEC
		// (set) Token: 0x0600DA75 RID: 55925 RVA: 0x00201B03 File Offset: 0x001FFD03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Score
		{
			get
			{
				if (!this.HasScore)
				{
					return 0;
				}
				return (int)this.endLess_;
			}
			set
			{
				this.endLess_ = value;
				this.endLessCase_ = MatchThreeLevelInfo.EndLessOneofCase.Score;
			}
		}

		// Token: 0x17002C46 RID: 11334
		// (get) Token: 0x0600DA76 RID: 55926 RVA: 0x00201B18 File Offset: 0x001FFD18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasScore
		{
			get
			{
				return this.endLessCase_ == MatchThreeLevelInfo.EndLessOneofCase.Score;
			}
		}

		// Token: 0x0600DA77 RID: 55927 RVA: 0x00201B23 File Offset: 0x001FFD23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearScore()
		{
			if (this.HasScore)
			{
				this.ClearEndLess();
			}
		}

		// Token: 0x17002C47 RID: 11335
		// (get) Token: 0x0600DA78 RID: 55928 RVA: 0x00201B33 File Offset: 0x001FFD33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeLevelInfo.EndLessOneofCase EndLessCase
		{
			get
			{
				return this.endLessCase_;
			}
		}

		// Token: 0x0600DA79 RID: 55929 RVA: 0x00201B3B File Offset: 0x001FFD3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearEndLess()
		{
			this.endLessCase_ = MatchThreeLevelInfo.EndLessOneofCase.None;
			this.endLess_ = null;
		}

		// Token: 0x0600DA7A RID: 55930 RVA: 0x00201B4B File Offset: 0x001FFD4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchThreeLevelInfo);
		}

		// Token: 0x0600DA7B RID: 55931 RVA: 0x00201B5C File Offset: 0x001FFD5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchThreeLevelInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.UnlockTime == other.UnlockTime && this.FirstPass == other.FirstPass && this.Score == other.Score && this.EndLessCase == other.EndLessCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DA7C RID: 55932 RVA: 0x00201BD8 File Offset: 0x001FFDD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.UnlockTime != 0L)
			{
				num ^= this.UnlockTime.GetHashCode();
			}
			if (this.FirstPass)
			{
				num ^= this.FirstPass.GetHashCode();
			}
			if (this.HasScore)
			{
				num ^= this.Score.GetHashCode();
			}
			num ^= (int)this.endLessCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DA7D RID: 55933 RVA: 0x00201C6B File Offset: 0x001FFE6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DA7E RID: 55934 RVA: 0x00201C78 File Offset: 0x001FFE78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DA7F RID: 55935 RVA: 0x00201C84 File Offset: 0x001FFE84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.UnlockTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.UnlockTime);
			}
			if (this.FirstPass)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.FirstPass);
			}
			if (this.HasScore)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Score);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DA80 RID: 55936 RVA: 0x00201D14 File Offset: 0x001FFF14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.UnlockTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.UnlockTime);
			}
			if (this.FirstPass)
			{
				num += 2;
			}
			if (this.HasScore)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Score);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DA81 RID: 55937 RVA: 0x00201D90 File Offset: 0x001FFF90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MatchThreeLevelInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.UnlockTime != 0L)
			{
				this.UnlockTime = other.UnlockTime;
			}
			if (other.FirstPass)
			{
				this.FirstPass = other.FirstPass;
			}
			if (other.EndLessCase == MatchThreeLevelInfo.EndLessOneofCase.Score)
			{
				this.Score = other.Score;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DA82 RID: 55938 RVA: 0x00201E09 File Offset: 0x00200009
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DA83 RID: 55939 RVA: 0x00201E14 File Offset: 0x00200014
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
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.UnlockTime = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.FirstPass = input.ReadBool();
						continue;
					}
					if (num == 32U)
					{
						this.Score = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005B1E RID: 23326
		private static readonly MessageParser<MatchThreeLevelInfo> _parser = new MessageParser<MatchThreeLevelInfo>(() => new MatchThreeLevelInfo());

		// Token: 0x04005B1F RID: 23327
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B20 RID: 23328
		public const int IdFieldNumber = 1;

		// Token: 0x04005B21 RID: 23329
		private int id_;

		// Token: 0x04005B22 RID: 23330
		public const int UnlockTimeFieldNumber = 2;

		// Token: 0x04005B23 RID: 23331
		private long unlockTime_;

		// Token: 0x04005B24 RID: 23332
		public const int FirstPassFieldNumber = 3;

		// Token: 0x04005B25 RID: 23333
		private bool firstPass_;

		// Token: 0x04005B26 RID: 23334
		public const int ScoreFieldNumber = 4;

		// Token: 0x04005B27 RID: 23335
		private object endLess_;

		// Token: 0x04005B28 RID: 23336
		private MatchThreeLevelInfo.EndLessOneofCase endLessCase_;

		// Token: 0x020018AA RID: 6314
		public enum EndLessOneofCase
		{
			// Token: 0x0400CD2E RID: 52526
			None,
			// Token: 0x0400CD2F RID: 52527
			Score = 4
		}
	}
}
