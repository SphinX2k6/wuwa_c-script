using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003F8 RID: 1016
	[NetMessage(EMessageId.DollGrabStopResponse)]
	public sealed class DollGrabStopResponse : IMessage<DollGrabStopResponse>, IMessage, IEquatable<DollGrabStopResponse>, IDeepCloneable<DollGrabStopResponse>, IBufferMessage
	{
		// Token: 0x06006243 RID: 25155 RVA: 0x000ECA59 File Offset: 0x000EAC59
		[NullableContext(1)]
		public static DollGrabStopResponse Create()
		{
			return new DollGrabStopResponse();
		}

		// Token: 0x1700124F RID: 4687
		// (get) Token: 0x06006244 RID: 25156 RVA: 0x000ECA60 File Offset: 0x000EAC60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001250 RID: 4688
		// (get) Token: 0x06006245 RID: 25157 RVA: 0x000ECA63 File Offset: 0x000EAC63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DollGrabStopResponse.Descriptor;
			}
		}

		// Token: 0x06006246 RID: 25158 RVA: 0x000ECA6A File Offset: 0x000EAC6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabStopResponse()
		{
		}

		// Token: 0x06006247 RID: 25159 RVA: 0x000ECA74 File Offset: 0x000EAC74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabStopResponse(DollGrabStopResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.sessionScore_ = other.sessionScore_;
			this.highScore_ = other.highScore_;
			this.accumulatedScore_ = other.accumulatedScore_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006248 RID: 25160 RVA: 0x000ECAC8 File Offset: 0x000EACC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabStopResponse Clone()
		{
			return new DollGrabStopResponse(this);
		}

		// Token: 0x17001251 RID: 4689
		// (get) Token: 0x06006249 RID: 25161 RVA: 0x000ECAD0 File Offset: 0x000EACD0
		// (set) Token: 0x0600624A RID: 25162 RVA: 0x000ECAD8 File Offset: 0x000EACD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17001252 RID: 4690
		// (get) Token: 0x0600624B RID: 25163 RVA: 0x000ECAE1 File Offset: 0x000EACE1
		// (set) Token: 0x0600624C RID: 25164 RVA: 0x000ECAE9 File Offset: 0x000EACE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SessionScore
		{
			get
			{
				return this.sessionScore_;
			}
			set
			{
				this.sessionScore_ = value;
			}
		}

		// Token: 0x17001253 RID: 4691
		// (get) Token: 0x0600624D RID: 25165 RVA: 0x000ECAF2 File Offset: 0x000EACF2
		// (set) Token: 0x0600624E RID: 25166 RVA: 0x000ECAFA File Offset: 0x000EACFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HighScore
		{
			get
			{
				return this.highScore_;
			}
			set
			{
				this.highScore_ = value;
			}
		}

		// Token: 0x17001254 RID: 4692
		// (get) Token: 0x0600624F RID: 25167 RVA: 0x000ECB03 File Offset: 0x000EAD03
		// (set) Token: 0x06006250 RID: 25168 RVA: 0x000ECB0B File Offset: 0x000EAD0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AccumulatedScore
		{
			get
			{
				return this.accumulatedScore_;
			}
			set
			{
				this.accumulatedScore_ = value;
			}
		}

		// Token: 0x06006251 RID: 25169 RVA: 0x000ECB14 File Offset: 0x000EAD14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DollGrabStopResponse);
		}

		// Token: 0x06006252 RID: 25170 RVA: 0x000ECB24 File Offset: 0x000EAD24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DollGrabStopResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.SessionScore == other.SessionScore && this.HighScore == other.HighScore && this.AccumulatedScore == other.AccumulatedScore && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006253 RID: 25171 RVA: 0x000ECB90 File Offset: 0x000EAD90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.SessionScore != 0)
			{
				num ^= this.SessionScore.GetHashCode();
			}
			if (this.HighScore != 0)
			{
				num ^= this.HighScore.GetHashCode();
			}
			if (this.AccumulatedScore != 0)
			{
				num ^= this.AccumulatedScore.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006254 RID: 25172 RVA: 0x000ECC20 File Offset: 0x000EAE20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006255 RID: 25173 RVA: 0x000ECC2D File Offset: 0x000EAE2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006256 RID: 25174 RVA: 0x000ECC38 File Offset: 0x000EAE38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HighScore != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.HighScore);
			}
			if (this.SessionScore != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.SessionScore);
			}
			if (this.AccumulatedScore != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.AccumulatedScore);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006257 RID: 25175 RVA: 0x000ECCC8 File Offset: 0x000EAEC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.SessionScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SessionScore);
			}
			if (this.HighScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HighScore);
			}
			if (this.AccumulatedScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AccumulatedScore);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006258 RID: 25176 RVA: 0x000ECD50 File Offset: 0x000EAF50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DollGrabStopResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.SessionScore != 0)
			{
				this.SessionScore = other.SessionScore;
			}
			if (other.HighScore != 0)
			{
				this.HighScore = other.HighScore;
			}
			if (other.AccumulatedScore != 0)
			{
				this.AccumulatedScore = other.AccumulatedScore;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006259 RID: 25177 RVA: 0x000ECDC8 File Offset: 0x000EAFC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600625A RID: 25178 RVA: 0x000ECDD4 File Offset: 0x000EAFD4
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
				if (num <= 40U)
				{
					if (num == 8U)
					{
						this.HighScore = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.SessionScore = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.AccumulatedScore = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040037CC RID: 14284
		private UnknownFieldSet _unknownFields;

		// Token: 0x040037CD RID: 14285
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x040037CE RID: 14286
		private ErrorCode errorCode_;

		// Token: 0x040037CF RID: 14287
		public const int SessionScoreFieldNumber = 5;

		// Token: 0x040037D0 RID: 14288
		private int sessionScore_;

		// Token: 0x040037D1 RID: 14289
		public const int HighScoreFieldNumber = 1;

		// Token: 0x040037D2 RID: 14290
		private int highScore_;

		// Token: 0x040037D3 RID: 14291
		public const int AccumulatedScoreFieldNumber = 9;

		// Token: 0x040037D4 RID: 14292
		private int accumulatedScore_;
	}
}
