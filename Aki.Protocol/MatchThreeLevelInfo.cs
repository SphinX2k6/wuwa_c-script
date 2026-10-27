using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009C6 RID: 2502
	public sealed class MatchThreeLevelInfo : IMessage<MatchThreeLevelInfo>, IMessage, IEquatable<MatchThreeLevelInfo>, IDeepCloneable<MatchThreeLevelInfo>, IBufferMessage
	{
		// Token: 0x0600DB81 RID: 56193 RVA: 0x00203C2C File Offset: 0x00201E2C
		[NullableContext(1)]
		public static MatchThreeLevelInfo Create()
		{
			return new MatchThreeLevelInfo();
		}

		// Token: 0x17002C7D RID: 11389
		// (get) Token: 0x0600DB82 RID: 56194 RVA: 0x00203C33 File Offset: 0x00201E33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MatchThreeLevelInfo> Parser
		{
			get
			{
				return MatchThreeLevelInfo._parser;
			}
		}

		// Token: 0x17002C7E RID: 11390
		// (get) Token: 0x0600DB83 RID: 56195 RVA: 0x00203C3A File Offset: 0x00201E3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C7F RID: 11391
		// (get) Token: 0x0600DB84 RID: 56196 RVA: 0x00203C3D File Offset: 0x00201E3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchThreeLevelInfo.Descriptor;
			}
		}

		// Token: 0x0600DB85 RID: 56197 RVA: 0x00203C44 File Offset: 0x00201E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeLevelInfo()
		{
		}

		// Token: 0x0600DB86 RID: 56198 RVA: 0x00203C4C File Offset: 0x00201E4C
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

		// Token: 0x0600DB87 RID: 56199 RVA: 0x00203CA9 File Offset: 0x00201EA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeLevelInfo Clone()
		{
			return new MatchThreeLevelInfo(this);
		}

		// Token: 0x17002C80 RID: 11392
		// (get) Token: 0x0600DB88 RID: 56200 RVA: 0x00203CB1 File Offset: 0x00201EB1
		// (set) Token: 0x0600DB89 RID: 56201 RVA: 0x00203CB9 File Offset: 0x00201EB9
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

		// Token: 0x17002C81 RID: 11393
		// (get) Token: 0x0600DB8A RID: 56202 RVA: 0x00203CC2 File Offset: 0x00201EC2
		// (set) Token: 0x0600DB8B RID: 56203 RVA: 0x00203CCA File Offset: 0x00201ECA
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

		// Token: 0x17002C82 RID: 11394
		// (get) Token: 0x0600DB8C RID: 56204 RVA: 0x00203CD3 File Offset: 0x00201ED3
		// (set) Token: 0x0600DB8D RID: 56205 RVA: 0x00203CDB File Offset: 0x00201EDB
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

		// Token: 0x17002C83 RID: 11395
		// (get) Token: 0x0600DB8E RID: 56206 RVA: 0x00203CE4 File Offset: 0x00201EE4
		// (set) Token: 0x0600DB8F RID: 56207 RVA: 0x00203CFB File Offset: 0x00201EFB
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

		// Token: 0x17002C84 RID: 11396
		// (get) Token: 0x0600DB90 RID: 56208 RVA: 0x00203D10 File Offset: 0x00201F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasScore
		{
			get
			{
				return this.endLessCase_ == MatchThreeLevelInfo.EndLessOneofCase.Score;
			}
		}

		// Token: 0x0600DB91 RID: 56209 RVA: 0x00203D1B File Offset: 0x00201F1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearScore()
		{
			if (this.HasScore)
			{
				this.ClearEndLess();
			}
		}

		// Token: 0x17002C85 RID: 11397
		// (get) Token: 0x0600DB92 RID: 56210 RVA: 0x00203D2B File Offset: 0x00201F2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeLevelInfo.EndLessOneofCase EndLessCase
		{
			get
			{
				return this.endLessCase_;
			}
		}

		// Token: 0x0600DB93 RID: 56211 RVA: 0x00203D33 File Offset: 0x00201F33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearEndLess()
		{
			this.endLessCase_ = MatchThreeLevelInfo.EndLessOneofCase.None;
			this.endLess_ = null;
		}

		// Token: 0x0600DB94 RID: 56212 RVA: 0x00203D43 File Offset: 0x00201F43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchThreeLevelInfo);
		}

		// Token: 0x0600DB95 RID: 56213 RVA: 0x00203D54 File Offset: 0x00201F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchThreeLevelInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.UnlockTime == other.UnlockTime && this.FirstPass == other.FirstPass && this.Score == other.Score && this.EndLessCase == other.EndLessCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DB96 RID: 56214 RVA: 0x00203DD0 File Offset: 0x00201FD0
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

		// Token: 0x0600DB97 RID: 56215 RVA: 0x00203E63 File Offset: 0x00202063
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DB98 RID: 56216 RVA: 0x00203E70 File Offset: 0x00202070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DB99 RID: 56217 RVA: 0x00203E7C File Offset: 0x0020207C
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

		// Token: 0x0600DB9A RID: 56218 RVA: 0x00203F0C File Offset: 0x0020210C
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

		// Token: 0x0600DB9B RID: 56219 RVA: 0x00203F88 File Offset: 0x00202188
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

		// Token: 0x0600DB9C RID: 56220 RVA: 0x00204001 File Offset: 0x00202201
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DB9D RID: 56221 RVA: 0x0020400C File Offset: 0x0020220C
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

		// Token: 0x04005B15 RID: 23317
		private static readonly MessageParser<MatchThreeLevelInfo> _parser = new MessageParser<MatchThreeLevelInfo>(() => new MatchThreeLevelInfo());

		// Token: 0x04005B16 RID: 23318
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B17 RID: 23319
		public const int IdFieldNumber = 1;

		// Token: 0x04005B18 RID: 23320
		private int id_;

		// Token: 0x04005B19 RID: 23321
		public const int UnlockTimeFieldNumber = 2;

		// Token: 0x04005B1A RID: 23322
		private long unlockTime_;

		// Token: 0x04005B1B RID: 23323
		public const int FirstPassFieldNumber = 3;

		// Token: 0x04005B1C RID: 23324
		private bool firstPass_;

		// Token: 0x04005B1D RID: 23325
		public const int ScoreFieldNumber = 4;

		// Token: 0x04005B1E RID: 23326
		private object endLess_;

		// Token: 0x04005B1F RID: 23327
		private MatchThreeLevelInfo.EndLessOneofCase endLessCase_;

		// Token: 0x02001832 RID: 6194
		public enum EndLessOneofCase
		{
			// Token: 0x0400C803 RID: 51203
			None,
			// Token: 0x0400C804 RID: 51204
			Score = 4
		}
	}
}
