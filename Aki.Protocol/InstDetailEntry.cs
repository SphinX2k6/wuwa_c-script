using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200080B RID: 2059
	public sealed class InstDetailEntry : IMessage<InstDetailEntry>, IMessage, IEquatable<InstDetailEntry>, IDeepCloneable<InstDetailEntry>, IBufferMessage
	{
		// Token: 0x0600B868 RID: 47208 RVA: 0x001B763D File Offset: 0x001B583D
		[NullableContext(1)]
		public static InstDetailEntry Create()
		{
			return new InstDetailEntry();
		}

		// Token: 0x17002521 RID: 9505
		// (get) Token: 0x0600B869 RID: 47209 RVA: 0x001B7644 File Offset: 0x001B5844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<InstDetailEntry> Parser
		{
			get
			{
				return InstDetailEntry._parser;
			}
		}

		// Token: 0x17002522 RID: 9506
		// (get) Token: 0x0600B86A RID: 47210 RVA: 0x001B764B File Offset: 0x001B584B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002523 RID: 9507
		// (get) Token: 0x0600B86B RID: 47211 RVA: 0x001B764E File Offset: 0x001B584E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InstDetailEntry.Descriptor;
			}
		}

		// Token: 0x0600B86C RID: 47212 RVA: 0x001B7655 File Offset: 0x001B5855
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstDetailEntry()
		{
		}

		// Token: 0x0600B86D RID: 47213 RVA: 0x001B7660 File Offset: 0x001B5860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstDetailEntry(InstDetailEntry other) : this()
		{
			this.instId_ = other.instId_;
			this.resetTime_ = other.resetTime_;
			this.count_ = other.count_;
			this.archiveType_ = other.archiveType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B86E RID: 47214 RVA: 0x001B76B4 File Offset: 0x001B58B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstDetailEntry Clone()
		{
			return new InstDetailEntry(this);
		}

		// Token: 0x17002524 RID: 9508
		// (get) Token: 0x0600B86F RID: 47215 RVA: 0x001B76BC File Offset: 0x001B58BC
		// (set) Token: 0x0600B870 RID: 47216 RVA: 0x001B76C4 File Offset: 0x001B58C4
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

		// Token: 0x17002525 RID: 9509
		// (get) Token: 0x0600B871 RID: 47217 RVA: 0x001B76CD File Offset: 0x001B58CD
		// (set) Token: 0x0600B872 RID: 47218 RVA: 0x001B76D5 File Offset: 0x001B58D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ResetTime
		{
			get
			{
				return this.resetTime_;
			}
			set
			{
				this.resetTime_ = value;
			}
		}

		// Token: 0x17002526 RID: 9510
		// (get) Token: 0x0600B873 RID: 47219 RVA: 0x001B76DE File Offset: 0x001B58DE
		// (set) Token: 0x0600B874 RID: 47220 RVA: 0x001B76E6 File Offset: 0x001B58E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x17002527 RID: 9511
		// (get) Token: 0x0600B875 RID: 47221 RVA: 0x001B76EF File Offset: 0x001B58EF
		// (set) Token: 0x0600B876 RID: 47222 RVA: 0x001B76F7 File Offset: 0x001B58F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArchiveType ArchiveType
		{
			get
			{
				return this.archiveType_;
			}
			set
			{
				this.archiveType_ = value;
			}
		}

		// Token: 0x0600B877 RID: 47223 RVA: 0x001B7700 File Offset: 0x001B5900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InstDetailEntry);
		}

		// Token: 0x0600B878 RID: 47224 RVA: 0x001B7710 File Offset: 0x001B5910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InstDetailEntry other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.ResetTime == other.ResetTime && this.Count == other.Count && this.ArchiveType == other.ArchiveType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B879 RID: 47225 RVA: 0x001B777C File Offset: 0x001B597C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this.ResetTime != 0L)
			{
				num ^= this.ResetTime.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this.ArchiveType != ArchiveType.NoneArchive)
			{
				num ^= this.ArchiveType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B87A RID: 47226 RVA: 0x001B780C File Offset: 0x001B5A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B87B RID: 47227 RVA: 0x001B7819 File Offset: 0x001B5A19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B87C RID: 47228 RVA: 0x001B7824 File Offset: 0x001B5A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.InstId);
			}
			if (this.ResetTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.ResetTime);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Count);
			}
			if (this.ArchiveType != ArchiveType.NoneArchive)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ArchiveType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B87D RID: 47229 RVA: 0x001B78B4 File Offset: 0x001B5AB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this.ResetTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ResetTime);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this.ArchiveType != ArchiveType.NoneArchive)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ArchiveType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B87E RID: 47230 RVA: 0x001B793C File Offset: 0x001B5B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InstDetailEntry other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.ResetTime != 0L)
			{
				this.ResetTime = other.ResetTime;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			if (other.ArchiveType != ArchiveType.NoneArchive)
			{
				this.ArchiveType = other.ArchiveType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B87F RID: 47231 RVA: 0x001B79B4 File Offset: 0x001B5BB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B880 RID: 47232 RVA: 0x001B79C0 File Offset: 0x001B5BC0
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
						this.InstId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.ResetTime = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Count = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.ArchiveType = (ArchiveType)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400518D RID: 20877
		private static readonly MessageParser<InstDetailEntry> _parser = new MessageParser<InstDetailEntry>(() => new InstDetailEntry());

		// Token: 0x0400518E RID: 20878
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400518F RID: 20879
		public const int InstIdFieldNumber = 1;

		// Token: 0x04005190 RID: 20880
		private int instId_;

		// Token: 0x04005191 RID: 20881
		public const int ResetTimeFieldNumber = 2;

		// Token: 0x04005192 RID: 20882
		private long resetTime_;

		// Token: 0x04005193 RID: 20883
		public const int CountFieldNumber = 3;

		// Token: 0x04005194 RID: 20884
		private int count_;

		// Token: 0x04005195 RID: 20885
		public const int ArchiveTypeFieldNumber = 4;

		// Token: 0x04005196 RID: 20886
		private ArchiveType archiveType_;
	}
}
