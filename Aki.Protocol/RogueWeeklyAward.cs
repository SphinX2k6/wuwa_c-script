using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200101E RID: 4126
	public sealed class RogueWeeklyAward : IMessage<RogueWeeklyAward>, IMessage, IEquatable<RogueWeeklyAward>, IDeepCloneable<RogueWeeklyAward>, IBufferMessage
	{
		// Token: 0x06016140 RID: 90432 RVA: 0x00335B5D File Offset: 0x00333D5D
		[NullableContext(1)]
		public static RogueWeeklyAward Create()
		{
			return new RogueWeeklyAward();
		}

		// Token: 0x170049CE RID: 18894
		// (get) Token: 0x06016141 RID: 90433 RVA: 0x00335B64 File Offset: 0x00333D64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueWeeklyAward> Parser
		{
			get
			{
				return RogueWeeklyAward._parser;
			}
		}

		// Token: 0x170049CF RID: 18895
		// (get) Token: 0x06016142 RID: 90434 RVA: 0x00335B6B File Offset: 0x00333D6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170049D0 RID: 18896
		// (get) Token: 0x06016143 RID: 90435 RVA: 0x00335B6E File Offset: 0x00333D6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyAward.Descriptor;
			}
		}

		// Token: 0x06016144 RID: 90436 RVA: 0x00335B75 File Offset: 0x00333D75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyAward()
		{
		}

		// Token: 0x06016145 RID: 90437 RVA: 0x00335B80 File Offset: 0x00333D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyAward(RogueWeeklyAward other) : this()
		{
			this.signState_ = other.signState_;
			this.curProgress_ = other.curProgress_;
			this.maxProgress_ = other.maxProgress_;
			this.configId_ = other.configId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016146 RID: 90438 RVA: 0x00335BD4 File Offset: 0x00333DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyAward Clone()
		{
			return new RogueWeeklyAward(this);
		}

		// Token: 0x170049D1 RID: 18897
		// (get) Token: 0x06016147 RID: 90439 RVA: 0x00335BDC File Offset: 0x00333DDC
		// (set) Token: 0x06016148 RID: 90440 RVA: 0x00335BE4 File Offset: 0x00333DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignState SignState
		{
			get
			{
				return this.signState_;
			}
			set
			{
				this.signState_ = value;
			}
		}

		// Token: 0x170049D2 RID: 18898
		// (get) Token: 0x06016149 RID: 90441 RVA: 0x00335BED File Offset: 0x00333DED
		// (set) Token: 0x0601614A RID: 90442 RVA: 0x00335BF5 File Offset: 0x00333DF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurProgress
		{
			get
			{
				return this.curProgress_;
			}
			set
			{
				this.curProgress_ = value;
			}
		}

		// Token: 0x170049D3 RID: 18899
		// (get) Token: 0x0601614B RID: 90443 RVA: 0x00335BFE File Offset: 0x00333DFE
		// (set) Token: 0x0601614C RID: 90444 RVA: 0x00335C06 File Offset: 0x00333E06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxProgress
		{
			get
			{
				return this.maxProgress_;
			}
			set
			{
				this.maxProgress_ = value;
			}
		}

		// Token: 0x170049D4 RID: 18900
		// (get) Token: 0x0601614D RID: 90445 RVA: 0x00335C0F File Offset: 0x00333E0F
		// (set) Token: 0x0601614E RID: 90446 RVA: 0x00335C17 File Offset: 0x00333E17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x0601614F RID: 90447 RVA: 0x00335C20 File Offset: 0x00333E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyAward);
		}

		// Token: 0x06016150 RID: 90448 RVA: 0x00335C30 File Offset: 0x00333E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyAward other)
		{
			return other != null && (other == this || (this.SignState == other.SignState && this.CurProgress == other.CurProgress && this.MaxProgress == other.MaxProgress && this.ConfigId == other.ConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016151 RID: 90449 RVA: 0x00335C9C File Offset: 0x00333E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SignState != SignState.Lock)
			{
				num ^= this.SignState.GetHashCode();
			}
			if (this.CurProgress != 0)
			{
				num ^= this.CurProgress.GetHashCode();
			}
			if (this.MaxProgress != 0)
			{
				num ^= this.MaxProgress.GetHashCode();
			}
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016152 RID: 90450 RVA: 0x00335D2C File Offset: 0x00333F2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016153 RID: 90451 RVA: 0x00335D39 File Offset: 0x00333F39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016154 RID: 90452 RVA: 0x00335D44 File Offset: 0x00333F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SignState != SignState.Lock)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.SignState);
			}
			if (this.CurProgress != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CurProgress);
			}
			if (this.MaxProgress != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.MaxProgress);
			}
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016155 RID: 90453 RVA: 0x00335DD4 File Offset: 0x00333FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SignState != SignState.Lock)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.SignState);
			}
			if (this.CurProgress != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurProgress);
			}
			if (this.MaxProgress != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxProgress);
			}
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016156 RID: 90454 RVA: 0x00335E5C File Offset: 0x0033405C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWeeklyAward other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SignState != SignState.Lock)
			{
				this.SignState = other.SignState;
			}
			if (other.CurProgress != 0)
			{
				this.CurProgress = other.CurProgress;
			}
			if (other.MaxProgress != 0)
			{
				this.MaxProgress = other.MaxProgress;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016157 RID: 90455 RVA: 0x00335ED4 File Offset: 0x003340D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016158 RID: 90456 RVA: 0x00335EE0 File Offset: 0x003340E0
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
						this.SignState = (SignState)input.ReadEnum();
						continue;
					}
					if (num == 16U)
					{
						this.CurProgress = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.MaxProgress = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.ConfigId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040084AC RID: 33964
		private static readonly MessageParser<RogueWeeklyAward> _parser = new MessageParser<RogueWeeklyAward>(() => new RogueWeeklyAward());

		// Token: 0x040084AD RID: 33965
		private UnknownFieldSet _unknownFields;

		// Token: 0x040084AE RID: 33966
		public const int SignStateFieldNumber = 1;

		// Token: 0x040084AF RID: 33967
		private SignState signState_;

		// Token: 0x040084B0 RID: 33968
		public const int CurProgressFieldNumber = 2;

		// Token: 0x040084B1 RID: 33969
		private int curProgress_;

		// Token: 0x040084B2 RID: 33970
		public const int MaxProgressFieldNumber = 3;

		// Token: 0x040084B3 RID: 33971
		private int maxProgress_;

		// Token: 0x040084B4 RID: 33972
		public const int ConfigIdFieldNumber = 4;

		// Token: 0x040084B5 RID: 33973
		private int configId_;
	}
}
