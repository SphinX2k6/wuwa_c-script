using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200078A RID: 1930
	public sealed class HonamiStoryScoreRewardInfo : IMessage<HonamiStoryScoreRewardInfo>, IMessage, IEquatable<HonamiStoryScoreRewardInfo>, IDeepCloneable<HonamiStoryScoreRewardInfo>, IBufferMessage
	{
		// Token: 0x0600AE7D RID: 44669 RVA: 0x001A3393 File Offset: 0x001A1593
		[NullableContext(1)]
		public static HonamiStoryScoreRewardInfo Create()
		{
			return new HonamiStoryScoreRewardInfo();
		}

		// Token: 0x1700232D RID: 9005
		// (get) Token: 0x0600AE7E RID: 44670 RVA: 0x001A339A File Offset: 0x001A159A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HonamiStoryScoreRewardInfo> Parser
		{
			get
			{
				return HonamiStoryScoreRewardInfo._parser;
			}
		}

		// Token: 0x1700232E RID: 9006
		// (get) Token: 0x0600AE7F RID: 44671 RVA: 0x001A33A1 File Offset: 0x001A15A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700232F RID: 9007
		// (get) Token: 0x0600AE80 RID: 44672 RVA: 0x001A33A4 File Offset: 0x001A15A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryScoreRewardInfo.Descriptor;
			}
		}

		// Token: 0x0600AE81 RID: 44673 RVA: 0x001A33AB File Offset: 0x001A15AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryScoreRewardInfo()
		{
		}

		// Token: 0x0600AE82 RID: 44674 RVA: 0x001A33B3 File Offset: 0x001A15B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryScoreRewardInfo(HonamiStoryScoreRewardInfo other) : this()
		{
			this.scoreRewardId_ = other.scoreRewardId_;
			this.status_ = other.status_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AE83 RID: 44675 RVA: 0x001A33E4 File Offset: 0x001A15E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryScoreRewardInfo Clone()
		{
			return new HonamiStoryScoreRewardInfo(this);
		}

		// Token: 0x17002330 RID: 9008
		// (get) Token: 0x0600AE84 RID: 44676 RVA: 0x001A33EC File Offset: 0x001A15EC
		// (set) Token: 0x0600AE85 RID: 44677 RVA: 0x001A33F4 File Offset: 0x001A15F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ScoreRewardId
		{
			get
			{
				return this.scoreRewardId_;
			}
			set
			{
				this.scoreRewardId_ = value;
			}
		}

		// Token: 0x17002331 RID: 9009
		// (get) Token: 0x0600AE86 RID: 44678 RVA: 0x001A33FD File Offset: 0x001A15FD
		// (set) Token: 0x0600AE87 RID: 44679 RVA: 0x001A3405 File Offset: 0x001A1605
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x0600AE88 RID: 44680 RVA: 0x001A340E File Offset: 0x001A160E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryScoreRewardInfo);
		}

		// Token: 0x0600AE89 RID: 44681 RVA: 0x001A341C File Offset: 0x001A161C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryScoreRewardInfo other)
		{
			return other != null && (other == this || (this.ScoreRewardId == other.ScoreRewardId && this.Status == other.Status && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AE8A RID: 44682 RVA: 0x001A345C File Offset: 0x001A165C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ScoreRewardId != 0)
			{
				num ^= this.ScoreRewardId.GetHashCode();
			}
			if (this.Status != 0)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AE8B RID: 44683 RVA: 0x001A34B4 File Offset: 0x001A16B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AE8C RID: 44684 RVA: 0x001A34C1 File Offset: 0x001A16C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AE8D RID: 44685 RVA: 0x001A34CC File Offset: 0x001A16CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ScoreRewardId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ScoreRewardId);
			}
			if (this.Status != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Status);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AE8E RID: 44686 RVA: 0x001A3524 File Offset: 0x001A1724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ScoreRewardId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ScoreRewardId);
			}
			if (this.Status != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Status);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AE8F RID: 44687 RVA: 0x001A357C File Offset: 0x001A177C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryScoreRewardInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ScoreRewardId != 0)
			{
				this.ScoreRewardId = other.ScoreRewardId;
			}
			if (other.Status != 0)
			{
				this.Status = other.Status;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AE90 RID: 44688 RVA: 0x001A35CC File Offset: 0x001A17CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AE91 RID: 44689 RVA: 0x001A35D8 File Offset: 0x001A17D8
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Status = input.ReadInt32();
					}
				}
				else
				{
					this.ScoreRewardId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004F0C RID: 20236
		private static readonly MessageParser<HonamiStoryScoreRewardInfo> _parser = new MessageParser<HonamiStoryScoreRewardInfo>(() => new HonamiStoryScoreRewardInfo());

		// Token: 0x04004F0D RID: 20237
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F0E RID: 20238
		public const int ScoreRewardIdFieldNumber = 1;

		// Token: 0x04004F0F RID: 20239
		private int scoreRewardId_;

		// Token: 0x04004F10 RID: 20240
		public const int StatusFieldNumber = 2;

		// Token: 0x04004F11 RID: 20241
		private int status_;
	}
}
