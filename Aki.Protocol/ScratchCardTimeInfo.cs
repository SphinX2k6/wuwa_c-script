using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011DD RID: 4573
	public sealed class ScratchCardTimeInfo : IMessage<ScratchCardTimeInfo>, IMessage, IEquatable<ScratchCardTimeInfo>, IDeepCloneable<ScratchCardTimeInfo>, IBufferMessage
	{
		// Token: 0x0601868B RID: 99979 RVA: 0x0038D78D File Offset: 0x0038B98D
		[NullableContext(1)]
		public static ScratchCardTimeInfo Create()
		{
			return new ScratchCardTimeInfo();
		}

		// Token: 0x17005245 RID: 21061
		// (get) Token: 0x0601868C RID: 99980 RVA: 0x0038D794 File Offset: 0x0038B994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ScratchCardTimeInfo> Parser
		{
			get
			{
				return ScratchCardTimeInfo._parser;
			}
		}

		// Token: 0x17005246 RID: 21062
		// (get) Token: 0x0601868D RID: 99981 RVA: 0x0038D79B File Offset: 0x0038B99B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005247 RID: 21063
		// (get) Token: 0x0601868E RID: 99982 RVA: 0x0038D79E File Offset: 0x0038B99E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ScratchCardTimeInfo.Descriptor;
			}
		}

		// Token: 0x0601868F RID: 99983 RVA: 0x0038D7A5 File Offset: 0x0038B9A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScratchCardTimeInfo()
		{
		}

		// Token: 0x06018690 RID: 99984 RVA: 0x0038D7AD File Offset: 0x0038B9AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScratchCardTimeInfo(ScratchCardTimeInfo other) : this()
		{
			this.id_ = other.id_;
			this.progress_ = other.progress_;
			this.finishCount_ = other.finishCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018691 RID: 99985 RVA: 0x0038D7EA File Offset: 0x0038B9EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScratchCardTimeInfo Clone()
		{
			return new ScratchCardTimeInfo(this);
		}

		// Token: 0x17005248 RID: 21064
		// (get) Token: 0x06018692 RID: 99986 RVA: 0x0038D7F2 File Offset: 0x0038B9F2
		// (set) Token: 0x06018693 RID: 99987 RVA: 0x0038D7FA File Offset: 0x0038B9FA
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

		// Token: 0x17005249 RID: 21065
		// (get) Token: 0x06018694 RID: 99988 RVA: 0x0038D803 File Offset: 0x0038BA03
		// (set) Token: 0x06018695 RID: 99989 RVA: 0x0038D80B File Offset: 0x0038BA0B
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

		// Token: 0x1700524A RID: 21066
		// (get) Token: 0x06018696 RID: 99990 RVA: 0x0038D814 File Offset: 0x0038BA14
		// (set) Token: 0x06018697 RID: 99991 RVA: 0x0038D81C File Offset: 0x0038BA1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FinishCount
		{
			get
			{
				return this.finishCount_;
			}
			set
			{
				this.finishCount_ = value;
			}
		}

		// Token: 0x06018698 RID: 99992 RVA: 0x0038D825 File Offset: 0x0038BA25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ScratchCardTimeInfo);
		}

		// Token: 0x06018699 RID: 99993 RVA: 0x0038D834 File Offset: 0x0038BA34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ScratchCardTimeInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Progress == other.Progress && this.FinishCount == other.FinishCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601869A RID: 99994 RVA: 0x0038D890 File Offset: 0x0038BA90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Progress != 0)
			{
				num ^= this.Progress.GetHashCode();
			}
			if (this.FinishCount != 0)
			{
				num ^= this.FinishCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601869B RID: 99995 RVA: 0x0038D901 File Offset: 0x0038BB01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601869C RID: 99996 RVA: 0x0038D90E File Offset: 0x0038BB0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601869D RID: 99997 RVA: 0x0038D918 File Offset: 0x0038BB18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Progress != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Progress);
			}
			if (this.FinishCount != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.FinishCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601869E RID: 99998 RVA: 0x0038D98C File Offset: 0x0038BB8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Progress != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Progress);
			}
			if (this.FinishCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FinishCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601869F RID: 99999 RVA: 0x0038D9FC File Offset: 0x0038BBFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ScratchCardTimeInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Progress != 0)
			{
				this.Progress = other.Progress;
			}
			if (other.FinishCount != 0)
			{
				this.FinishCount = other.FinishCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060186A0 RID: 100000 RVA: 0x0038DA60 File Offset: 0x0038BC60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060186A1 RID: 100001 RVA: 0x0038DA6C File Offset: 0x0038BC6C
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
							this.FinishCount = input.ReadInt32();
						}
					}
					else
					{
						this.Progress = input.ReadInt32();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x040090FF RID: 37119
		private static readonly MessageParser<ScratchCardTimeInfo> _parser = new MessageParser<ScratchCardTimeInfo>(() => new ScratchCardTimeInfo());

		// Token: 0x04009100 RID: 37120
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009101 RID: 37121
		public const int IdFieldNumber = 1;

		// Token: 0x04009102 RID: 37122
		private int id_;

		// Token: 0x04009103 RID: 37123
		public const int ProgressFieldNumber = 2;

		// Token: 0x04009104 RID: 37124
		private int progress_;

		// Token: 0x04009105 RID: 37125
		public const int FinishCountFieldNumber = 3;

		// Token: 0x04009106 RID: 37126
		private int finishCount_;
	}
}
