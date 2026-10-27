using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200102E RID: 4142
	public sealed class RogueWeeklyAward : IMessage<RogueWeeklyAward>, IMessage, IEquatable<RogueWeeklyAward>, IDeepCloneable<RogueWeeklyAward>, IBufferMessage
	{
		// Token: 0x06016225 RID: 90661 RVA: 0x0033721D File Offset: 0x0033541D
		[NullableContext(1)]
		public static RogueWeeklyAward Create()
		{
			return new RogueWeeklyAward();
		}

		// Token: 0x170049F8 RID: 18936
		// (get) Token: 0x06016226 RID: 90662 RVA: 0x00337224 File Offset: 0x00335424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueWeeklyAward> Parser
		{
			get
			{
				return RogueWeeklyAward._parser;
			}
		}

		// Token: 0x170049F9 RID: 18937
		// (get) Token: 0x06016227 RID: 90663 RVA: 0x0033722B File Offset: 0x0033542B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170049FA RID: 18938
		// (get) Token: 0x06016228 RID: 90664 RVA: 0x0033722E File Offset: 0x0033542E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyAward.Descriptor;
			}
		}

		// Token: 0x06016229 RID: 90665 RVA: 0x00337235 File Offset: 0x00335435
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyAward()
		{
		}

		// Token: 0x0601622A RID: 90666 RVA: 0x00337240 File Offset: 0x00335440
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

		// Token: 0x0601622B RID: 90667 RVA: 0x00337294 File Offset: 0x00335494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyAward Clone()
		{
			return new RogueWeeklyAward(this);
		}

		// Token: 0x170049FB RID: 18939
		// (get) Token: 0x0601622C RID: 90668 RVA: 0x0033729C File Offset: 0x0033549C
		// (set) Token: 0x0601622D RID: 90669 RVA: 0x003372A4 File Offset: 0x003354A4
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

		// Token: 0x170049FC RID: 18940
		// (get) Token: 0x0601622E RID: 90670 RVA: 0x003372AD File Offset: 0x003354AD
		// (set) Token: 0x0601622F RID: 90671 RVA: 0x003372B5 File Offset: 0x003354B5
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

		// Token: 0x170049FD RID: 18941
		// (get) Token: 0x06016230 RID: 90672 RVA: 0x003372BE File Offset: 0x003354BE
		// (set) Token: 0x06016231 RID: 90673 RVA: 0x003372C6 File Offset: 0x003354C6
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

		// Token: 0x170049FE RID: 18942
		// (get) Token: 0x06016232 RID: 90674 RVA: 0x003372CF File Offset: 0x003354CF
		// (set) Token: 0x06016233 RID: 90675 RVA: 0x003372D7 File Offset: 0x003354D7
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

		// Token: 0x06016234 RID: 90676 RVA: 0x003372E0 File Offset: 0x003354E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyAward);
		}

		// Token: 0x06016235 RID: 90677 RVA: 0x003372F0 File Offset: 0x003354F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyAward other)
		{
			return other != null && (other == this || (this.SignState == other.SignState && this.CurProgress == other.CurProgress && this.MaxProgress == other.MaxProgress && this.ConfigId == other.ConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016236 RID: 90678 RVA: 0x0033735C File Offset: 0x0033555C
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

		// Token: 0x06016237 RID: 90679 RVA: 0x003373EC File Offset: 0x003355EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016238 RID: 90680 RVA: 0x003373F9 File Offset: 0x003355F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016239 RID: 90681 RVA: 0x00337404 File Offset: 0x00335604
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

		// Token: 0x0601623A RID: 90682 RVA: 0x00337494 File Offset: 0x00335694
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

		// Token: 0x0601623B RID: 90683 RVA: 0x0033751C File Offset: 0x0033571C
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

		// Token: 0x0601623C RID: 90684 RVA: 0x00337594 File Offset: 0x00335794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601623D RID: 90685 RVA: 0x003375A0 File Offset: 0x003357A0
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

		// Token: 0x04008482 RID: 33922
		private static readonly MessageParser<RogueWeeklyAward> _parser = new MessageParser<RogueWeeklyAward>(() => new RogueWeeklyAward());

		// Token: 0x04008483 RID: 33923
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008484 RID: 33924
		public const int SignStateFieldNumber = 1;

		// Token: 0x04008485 RID: 33925
		private SignState signState_;

		// Token: 0x04008486 RID: 33926
		public const int CurProgressFieldNumber = 2;

		// Token: 0x04008487 RID: 33927
		private int curProgress_;

		// Token: 0x04008488 RID: 33928
		public const int MaxProgressFieldNumber = 3;

		// Token: 0x04008489 RID: 33929
		private int maxProgress_;

		// Token: 0x0400848A RID: 33930
		public const int ConfigIdFieldNumber = 4;

		// Token: 0x0400848B RID: 33931
		private int configId_;
	}
}
