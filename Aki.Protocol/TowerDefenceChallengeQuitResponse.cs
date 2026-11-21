using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200140F RID: 5135
	[NetMessage(EMessageId.TowerDefenceChallengeQuitResponse)]
	public sealed class TowerDefenceChallengeQuitResponse : IMessage<TowerDefenceChallengeQuitResponse>, IMessage, IEquatable<TowerDefenceChallengeQuitResponse>, IDeepCloneable<TowerDefenceChallengeQuitResponse>, IBufferMessage
	{
		// Token: 0x0601B4B7 RID: 111799 RVA: 0x003F831E File Offset: 0x003F651E
		[NullableContext(1)]
		public static TowerDefenceChallengeQuitResponse Create()
		{
			return new TowerDefenceChallengeQuitResponse();
		}

		// Token: 0x17005C63 RID: 23651
		// (get) Token: 0x0601B4B8 RID: 111800 RVA: 0x003F8325 File Offset: 0x003F6525
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C64 RID: 23652
		// (get) Token: 0x0601B4B9 RID: 111801 RVA: 0x003F8328 File Offset: 0x003F6528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefenceChallengeQuitResponse.Descriptor;
			}
		}

		// Token: 0x0601B4BA RID: 111802 RVA: 0x003F832F File Offset: 0x003F652F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceChallengeQuitResponse()
		{
		}

		// Token: 0x0601B4BB RID: 111803 RVA: 0x003F8337 File Offset: 0x003F6537
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceChallengeQuitResponse(TowerDefenceChallengeQuitResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.score_ = other.score_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B4BC RID: 111804 RVA: 0x003F8368 File Offset: 0x003F6568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceChallengeQuitResponse Clone()
		{
			return new TowerDefenceChallengeQuitResponse(this);
		}

		// Token: 0x17005C65 RID: 23653
		// (get) Token: 0x0601B4BD RID: 111805 RVA: 0x003F8370 File Offset: 0x003F6570
		// (set) Token: 0x0601B4BE RID: 111806 RVA: 0x003F8378 File Offset: 0x003F6578
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

		// Token: 0x17005C66 RID: 23654
		// (get) Token: 0x0601B4BF RID: 111807 RVA: 0x003F8381 File Offset: 0x003F6581
		// (set) Token: 0x0601B4C0 RID: 111808 RVA: 0x003F8389 File Offset: 0x003F6589
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

		// Token: 0x0601B4C1 RID: 111809 RVA: 0x003F8392 File Offset: 0x003F6592
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefenceChallengeQuitResponse);
		}

		// Token: 0x0601B4C2 RID: 111810 RVA: 0x003F83A0 File Offset: 0x003F65A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefenceChallengeQuitResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.Score == other.Score && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B4C3 RID: 111811 RVA: 0x003F83E0 File Offset: 0x003F65E0
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

		// Token: 0x0601B4C4 RID: 111812 RVA: 0x003F843E File Offset: 0x003F663E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B4C5 RID: 111813 RVA: 0x003F844B File Offset: 0x003F664B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B4C6 RID: 111814 RVA: 0x003F8454 File Offset: 0x003F6654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.Score != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.Score);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B4C7 RID: 111815 RVA: 0x003F84B0 File Offset: 0x003F66B0
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

		// Token: 0x0601B4C8 RID: 111816 RVA: 0x003F8508 File Offset: 0x003F6708
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

		// Token: 0x0601B4C9 RID: 111817 RVA: 0x003F8558 File Offset: 0x003F6758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B4CA RID: 111818 RVA: 0x003F8564 File Offset: 0x003F6764
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
				if (num != 56U)
				{
					if (num != 112U)
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

		// Token: 0x04009F05 RID: 40709
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009F06 RID: 40710
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04009F07 RID: 40711
		private ErrorCode errorCode_;

		// Token: 0x04009F08 RID: 40712
		public const int ScoreFieldNumber = 14;

		// Token: 0x04009F09 RID: 40713
		private int score_;
	}
}
