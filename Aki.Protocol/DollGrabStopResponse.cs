using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003E1 RID: 993
	[NetMessage(EMessageId.DollGrabStopResponse)]
	public sealed class DollGrabStopResponse : IMessage<DollGrabStopResponse>, IMessage, IEquatable<DollGrabStopResponse>, IDeepCloneable<DollGrabStopResponse>, IBufferMessage
	{
		// Token: 0x060060B3 RID: 24755 RVA: 0x000E98D9 File Offset: 0x000E7AD9
		[NullableContext(1)]
		public static DollGrabStopResponse Create()
		{
			return new DollGrabStopResponse();
		}

		// Token: 0x170011FA RID: 4602
		// (get) Token: 0x060060B4 RID: 24756 RVA: 0x000E98E0 File Offset: 0x000E7AE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170011FB RID: 4603
		// (get) Token: 0x060060B5 RID: 24757 RVA: 0x000E98E3 File Offset: 0x000E7AE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DollGrabStopResponse.Descriptor;
			}
		}

		// Token: 0x060060B6 RID: 24758 RVA: 0x000E98EA File Offset: 0x000E7AEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabStopResponse()
		{
		}

		// Token: 0x060060B7 RID: 24759 RVA: 0x000E98F4 File Offset: 0x000E7AF4
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

		// Token: 0x060060B8 RID: 24760 RVA: 0x000E9948 File Offset: 0x000E7B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabStopResponse Clone()
		{
			return new DollGrabStopResponse(this);
		}

		// Token: 0x170011FC RID: 4604
		// (get) Token: 0x060060B9 RID: 24761 RVA: 0x000E9950 File Offset: 0x000E7B50
		// (set) Token: 0x060060BA RID: 24762 RVA: 0x000E9958 File Offset: 0x000E7B58
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

		// Token: 0x170011FD RID: 4605
		// (get) Token: 0x060060BB RID: 24763 RVA: 0x000E9961 File Offset: 0x000E7B61
		// (set) Token: 0x060060BC RID: 24764 RVA: 0x000E9969 File Offset: 0x000E7B69
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

		// Token: 0x170011FE RID: 4606
		// (get) Token: 0x060060BD RID: 24765 RVA: 0x000E9972 File Offset: 0x000E7B72
		// (set) Token: 0x060060BE RID: 24766 RVA: 0x000E997A File Offset: 0x000E7B7A
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

		// Token: 0x170011FF RID: 4607
		// (get) Token: 0x060060BF RID: 24767 RVA: 0x000E9983 File Offset: 0x000E7B83
		// (set) Token: 0x060060C0 RID: 24768 RVA: 0x000E998B File Offset: 0x000E7B8B
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

		// Token: 0x060060C1 RID: 24769 RVA: 0x000E9994 File Offset: 0x000E7B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DollGrabStopResponse);
		}

		// Token: 0x060060C2 RID: 24770 RVA: 0x000E99A4 File Offset: 0x000E7BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DollGrabStopResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.SessionScore == other.SessionScore && this.HighScore == other.HighScore && this.AccumulatedScore == other.AccumulatedScore && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060060C3 RID: 24771 RVA: 0x000E9A10 File Offset: 0x000E7C10
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

		// Token: 0x060060C4 RID: 24772 RVA: 0x000E9AA0 File Offset: 0x000E7CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060060C5 RID: 24773 RVA: 0x000E9AAD File Offset: 0x000E7CAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060060C6 RID: 24774 RVA: 0x000E9AB8 File Offset: 0x000E7CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HighScore != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.HighScore);
			}
			if (this.AccumulatedScore != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.AccumulatedScore);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.SessionScore != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.SessionScore);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060060C7 RID: 24775 RVA: 0x000E9B4C File Offset: 0x000E7D4C
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

		// Token: 0x060060C8 RID: 24776 RVA: 0x000E9BD4 File Offset: 0x000E7DD4
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

		// Token: 0x060060C9 RID: 24777 RVA: 0x000E9C4C File Offset: 0x000E7E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060060CA RID: 24778 RVA: 0x000E9C58 File Offset: 0x000E7E58
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
					if (num == 16U)
					{
						this.HighScore = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.AccumulatedScore = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 104U)
					{
						this.SessionScore = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040037B9 RID: 14265
		private UnknownFieldSet _unknownFields;

		// Token: 0x040037BA RID: 14266
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x040037BB RID: 14267
		private ErrorCode errorCode_;

		// Token: 0x040037BC RID: 14268
		public const int SessionScoreFieldNumber = 13;

		// Token: 0x040037BD RID: 14269
		private int sessionScore_;

		// Token: 0x040037BE RID: 14270
		public const int HighScoreFieldNumber = 2;

		// Token: 0x040037BF RID: 14271
		private int highScore_;

		// Token: 0x040037C0 RID: 14272
		public const int AccumulatedScoreFieldNumber = 5;

		// Token: 0x040037C1 RID: 14273
		private int accumulatedScore_;
	}
}
