using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200139C RID: 5020
	[NetMessage(EMessageId.TowerDefenceChallengeQuitResponse)]
	public sealed class TowerDefenceChallengeQuitResponse : IMessage<TowerDefenceChallengeQuitResponse>, IMessage, IEquatable<TowerDefenceChallengeQuitResponse>, IDeepCloneable<TowerDefenceChallengeQuitResponse>, IBufferMessage
	{
		// Token: 0x0601AA2C RID: 109100 RVA: 0x003DD056 File Offset: 0x003DB256
		[NullableContext(1)]
		public static TowerDefenceChallengeQuitResponse Create()
		{
			return new TowerDefenceChallengeQuitResponse();
		}

		// Token: 0x170059CE RID: 22990
		// (get) Token: 0x0601AA2D RID: 109101 RVA: 0x003DD05D File Offset: 0x003DB25D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170059CF RID: 22991
		// (get) Token: 0x0601AA2E RID: 109102 RVA: 0x003DD060 File Offset: 0x003DB260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefenceChallengeQuitResponse.Descriptor;
			}
		}

		// Token: 0x0601AA2F RID: 109103 RVA: 0x003DD067 File Offset: 0x003DB267
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceChallengeQuitResponse()
		{
		}

		// Token: 0x0601AA30 RID: 109104 RVA: 0x003DD06F File Offset: 0x003DB26F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceChallengeQuitResponse(TowerDefenceChallengeQuitResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.score_ = other.score_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AA31 RID: 109105 RVA: 0x003DD0A0 File Offset: 0x003DB2A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceChallengeQuitResponse Clone()
		{
			return new TowerDefenceChallengeQuitResponse(this);
		}

		// Token: 0x170059D0 RID: 22992
		// (get) Token: 0x0601AA32 RID: 109106 RVA: 0x003DD0A8 File Offset: 0x003DB2A8
		// (set) Token: 0x0601AA33 RID: 109107 RVA: 0x003DD0B0 File Offset: 0x003DB2B0
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

		// Token: 0x170059D1 RID: 22993
		// (get) Token: 0x0601AA34 RID: 109108 RVA: 0x003DD0B9 File Offset: 0x003DB2B9
		// (set) Token: 0x0601AA35 RID: 109109 RVA: 0x003DD0C1 File Offset: 0x003DB2C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Score
		{
			get
			{
				return this.score_;
			}
			set
			{
				this.score_ = value;
			}
		}

		// Token: 0x0601AA36 RID: 109110 RVA: 0x003DD0CA File Offset: 0x003DB2CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefenceChallengeQuitResponse);
		}

		// Token: 0x0601AA37 RID: 109111 RVA: 0x003DD0D8 File Offset: 0x003DB2D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefenceChallengeQuitResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.Score == other.Score && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AA38 RID: 109112 RVA: 0x003DD118 File Offset: 0x003DB318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.Score != 0)
			{
				num ^= this.Score.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601AA39 RID: 109113 RVA: 0x003DD176 File Offset: 0x003DB376
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AA3A RID: 109114 RVA: 0x003DD183 File Offset: 0x003DB383
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AA3B RID: 109115 RVA: 0x003DD18C File Offset: 0x003DB38C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.Score != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.Score);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AA3C RID: 109116 RVA: 0x003DD1E8 File Offset: 0x003DB3E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.Score != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Score);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AA3D RID: 109117 RVA: 0x003DD240 File Offset: 0x003DB440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerDefenceChallengeQuitResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.Score != 0)
			{
				this.Score = other.Score;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AA3E RID: 109118 RVA: 0x003DD290 File Offset: 0x003DB490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AA3F RID: 109119 RVA: 0x003DD29C File Offset: 0x003DB49C
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
				if (num != 104U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Score = input.ReadInt32();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009ABE RID: 39614
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009ABF RID: 39615
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04009AC0 RID: 39616
		private ErrorCode errorCode_;

		// Token: 0x04009AC1 RID: 39617
		public const int ScoreFieldNumber = 15;

		// Token: 0x04009AC2 RID: 39618
		private int score_;
	}
}
