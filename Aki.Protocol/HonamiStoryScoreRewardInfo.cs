using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200079E RID: 1950
	public sealed class HonamiStoryScoreRewardInfo : IMessage<HonamiStoryScoreRewardInfo>, IMessage, IEquatable<HonamiStoryScoreRewardInfo>, IDeepCloneable<HonamiStoryScoreRewardInfo>, IBufferMessage
	{
		// Token: 0x0600AFD3 RID: 45011 RVA: 0x001A5DC0 File Offset: 0x001A3FC0
		[NullableContext(1)]
		public static HonamiStoryScoreRewardInfo Create()
		{
			return new HonamiStoryScoreRewardInfo();
		}

		// Token: 0x17002377 RID: 9079
		// (get) Token: 0x0600AFD4 RID: 45012 RVA: 0x001A5DC7 File Offset: 0x001A3FC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HonamiStoryScoreRewardInfo> Parser
		{
			get
			{
				return HonamiStoryScoreRewardInfo._parser;
			}
		}

		// Token: 0x17002378 RID: 9080
		// (get) Token: 0x0600AFD5 RID: 45013 RVA: 0x001A5DCE File Offset: 0x001A3FCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002379 RID: 9081
		// (get) Token: 0x0600AFD6 RID: 45014 RVA: 0x001A5DD1 File Offset: 0x001A3FD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryScoreRewardInfo.Descriptor;
			}
		}

		// Token: 0x0600AFD7 RID: 45015 RVA: 0x001A5DD8 File Offset: 0x001A3FD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryScoreRewardInfo()
		{
		}

		// Token: 0x0600AFD8 RID: 45016 RVA: 0x001A5DE0 File Offset: 0x001A3FE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryScoreRewardInfo(HonamiStoryScoreRewardInfo other) : this()
		{
			this.scoreRewardId_ = other.scoreRewardId_;
			this.status_ = other.status_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AFD9 RID: 45017 RVA: 0x001A5E11 File Offset: 0x001A4011
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryScoreRewardInfo Clone()
		{
			return new HonamiStoryScoreRewardInfo(this);
		}

		// Token: 0x1700237A RID: 9082
		// (get) Token: 0x0600AFDA RID: 45018 RVA: 0x001A5E19 File Offset: 0x001A4019
		// (set) Token: 0x0600AFDB RID: 45019 RVA: 0x001A5E21 File Offset: 0x001A4021
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

		// Token: 0x1700237B RID: 9083
		// (get) Token: 0x0600AFDC RID: 45020 RVA: 0x001A5E2A File Offset: 0x001A402A
		// (set) Token: 0x0600AFDD RID: 45021 RVA: 0x001A5E32 File Offset: 0x001A4032
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

		// Token: 0x0600AFDE RID: 45022 RVA: 0x001A5E3B File Offset: 0x001A403B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryScoreRewardInfo);
		}

		// Token: 0x0600AFDF RID: 45023 RVA: 0x001A5E49 File Offset: 0x001A4049
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryScoreRewardInfo other)
		{
			return other != null && (other == this || (this.ScoreRewardId == other.ScoreRewardId && this.Status == other.Status && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AFE0 RID: 45024 RVA: 0x001A5E88 File Offset: 0x001A4088
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

		// Token: 0x0600AFE1 RID: 45025 RVA: 0x001A5EE0 File Offset: 0x001A40E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AFE2 RID: 45026 RVA: 0x001A5EED File Offset: 0x001A40ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AFE3 RID: 45027 RVA: 0x001A5EF8 File Offset: 0x001A40F8
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

		// Token: 0x0600AFE4 RID: 45028 RVA: 0x001A5F50 File Offset: 0x001A4150
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

		// Token: 0x0600AFE5 RID: 45029 RVA: 0x001A5FA8 File Offset: 0x001A41A8
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

		// Token: 0x0600AFE6 RID: 45030 RVA: 0x001A5FF8 File Offset: 0x001A41F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AFE7 RID: 45031 RVA: 0x001A6004 File Offset: 0x001A4204
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

		// Token: 0x04004F13 RID: 20243
		private static readonly MessageParser<HonamiStoryScoreRewardInfo> _parser = new MessageParser<HonamiStoryScoreRewardInfo>(() => new HonamiStoryScoreRewardInfo());

		// Token: 0x04004F14 RID: 20244
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F15 RID: 20245
		public const int ScoreRewardIdFieldNumber = 1;

		// Token: 0x04004F16 RID: 20246
		private int scoreRewardId_;

		// Token: 0x04004F17 RID: 20247
		public const int StatusFieldNumber = 2;

		// Token: 0x04004F18 RID: 20248
		private int status_;
	}
}
