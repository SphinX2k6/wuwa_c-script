using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001B0 RID: 432
	public sealed class BlackSwordChallengeInfo : IMessage<BlackSwordChallengeInfo>, IMessage, IEquatable<BlackSwordChallengeInfo>, IDeepCloneable<BlackSwordChallengeInfo>, IBufferMessage
	{
		// Token: 0x06003296 RID: 12950 RVA: 0x00080B7F File Offset: 0x0007ED7F
		[NullableContext(1)]
		public static BlackSwordChallengeInfo Create()
		{
			return new BlackSwordChallengeInfo();
		}

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x06003297 RID: 12951 RVA: 0x00080B86 File Offset: 0x0007ED86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BlackSwordChallengeInfo> Parser
		{
			get
			{
				return BlackSwordChallengeInfo._parser;
			}
		}

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x06003298 RID: 12952 RVA: 0x00080B8D File Offset: 0x0007ED8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x06003299 RID: 12953 RVA: 0x00080B90 File Offset: 0x0007ED90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BlackSwordChallengeInfo.Descriptor;
			}
		}

		// Token: 0x0600329A RID: 12954 RVA: 0x00080B97 File Offset: 0x0007ED97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackSwordChallengeInfo()
		{
		}

		// Token: 0x0600329B RID: 12955 RVA: 0x00080B9F File Offset: 0x0007ED9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackSwordChallengeInfo(BlackSwordChallengeInfo other) : this()
		{
			this.levelPlayId_ = other.levelPlayId_;
			this.isUnLocked_ = other.isUnLocked_;
			this.completeNumber_ = other.completeNumber_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600329C RID: 12956 RVA: 0x00080BDC File Offset: 0x0007EDDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackSwordChallengeInfo Clone()
		{
			return new BlackSwordChallengeInfo(this);
		}

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x0600329D RID: 12957 RVA: 0x00080BE4 File Offset: 0x0007EDE4
		// (set) Token: 0x0600329E RID: 12958 RVA: 0x00080BEC File Offset: 0x0007EDEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelPlayId
		{
			get
			{
				return this.levelPlayId_;
			}
			set
			{
				this.levelPlayId_ = value;
			}
		}

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x0600329F RID: 12959 RVA: 0x00080BF5 File Offset: 0x0007EDF5
		// (set) Token: 0x060032A0 RID: 12960 RVA: 0x00080BFD File Offset: 0x0007EDFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsUnLocked
		{
			get
			{
				return this.isUnLocked_;
			}
			set
			{
				this.isUnLocked_ = value;
			}
		}

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x060032A1 RID: 12961 RVA: 0x00080C06 File Offset: 0x0007EE06
		// (set) Token: 0x060032A2 RID: 12962 RVA: 0x00080C0E File Offset: 0x0007EE0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CompleteNumber
		{
			get
			{
				return this.completeNumber_;
			}
			set
			{
				this.completeNumber_ = value;
			}
		}

		// Token: 0x060032A3 RID: 12963 RVA: 0x00080C17 File Offset: 0x0007EE17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BlackSwordChallengeInfo);
		}

		// Token: 0x060032A4 RID: 12964 RVA: 0x00080C28 File Offset: 0x0007EE28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BlackSwordChallengeInfo other)
		{
			return other != null && (other == this || (this.LevelPlayId == other.LevelPlayId && this.IsUnLocked == other.IsUnLocked && this.CompleteNumber == other.CompleteNumber && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060032A5 RID: 12965 RVA: 0x00080C84 File Offset: 0x0007EE84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelPlayId != 0)
			{
				num ^= this.LevelPlayId.GetHashCode();
			}
			if (this.IsUnLocked)
			{
				num ^= this.IsUnLocked.GetHashCode();
			}
			if (this.CompleteNumber != 0)
			{
				num ^= this.CompleteNumber.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060032A6 RID: 12966 RVA: 0x00080CF5 File Offset: 0x0007EEF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060032A7 RID: 12967 RVA: 0x00080D02 File Offset: 0x0007EF02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060032A8 RID: 12968 RVA: 0x00080D0C File Offset: 0x0007EF0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelPlayId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LevelPlayId);
			}
			if (this.IsUnLocked)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsUnLocked);
			}
			if (this.CompleteNumber != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.CompleteNumber);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060032A9 RID: 12969 RVA: 0x00080D80 File Offset: 0x0007EF80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelPlayId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelPlayId);
			}
			if (this.IsUnLocked)
			{
				num += 2;
			}
			if (this.CompleteNumber != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CompleteNumber);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060032AA RID: 12970 RVA: 0x00080DE4 File Offset: 0x0007EFE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BlackSwordChallengeInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelPlayId != 0)
			{
				this.LevelPlayId = other.LevelPlayId;
			}
			if (other.IsUnLocked)
			{
				this.IsUnLocked = other.IsUnLocked;
			}
			if (other.CompleteNumber != 0)
			{
				this.CompleteNumber = other.CompleteNumber;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060032AB RID: 12971 RVA: 0x00080E48 File Offset: 0x0007F048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060032AC RID: 12972 RVA: 0x00080E54 File Offset: 0x0007F054
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
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.CompleteNumber = input.ReadInt32();
						}
					}
					else
					{
						this.IsUnLocked = input.ReadBool();
					}
				}
				else
				{
					this.LevelPlayId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040029D7 RID: 10711
		private static readonly MessageParser<BlackSwordChallengeInfo> _parser = new MessageParser<BlackSwordChallengeInfo>(() => new BlackSwordChallengeInfo());

		// Token: 0x040029D8 RID: 10712
		private UnknownFieldSet _unknownFields;

		// Token: 0x040029D9 RID: 10713
		public const int LevelPlayIdFieldNumber = 1;

		// Token: 0x040029DA RID: 10714
		private int levelPlayId_;

		// Token: 0x040029DB RID: 10715
		public const int IsUnLockedFieldNumber = 2;

		// Token: 0x040029DC RID: 10716
		private bool isUnLocked_;

		// Token: 0x040029DD RID: 10717
		public const int CompleteNumberFieldNumber = 3;

		// Token: 0x040029DE RID: 10718
		private int completeNumber_;
	}
}
