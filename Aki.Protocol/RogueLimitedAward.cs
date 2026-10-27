using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FCE RID: 4046
	public sealed class RogueLimitedAward : IMessage<RogueLimitedAward>, IMessage, IEquatable<RogueLimitedAward>, IDeepCloneable<RogueLimitedAward>, IBufferMessage
	{
		// Token: 0x06015A06 RID: 88582 RVA: 0x003237B9 File Offset: 0x003219B9
		[NullableContext(1)]
		public static RogueLimitedAward Create()
		{
			return new RogueLimitedAward();
		}

		// Token: 0x1700481D RID: 18461
		// (get) Token: 0x06015A07 RID: 88583 RVA: 0x003237C0 File Offset: 0x003219C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueLimitedAward> Parser
		{
			get
			{
				return RogueLimitedAward._parser;
			}
		}

		// Token: 0x1700481E RID: 18462
		// (get) Token: 0x06015A08 RID: 88584 RVA: 0x003237C7 File Offset: 0x003219C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700481F RID: 18463
		// (get) Token: 0x06015A09 RID: 88585 RVA: 0x003237CA File Offset: 0x003219CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueLimitedAward.Descriptor;
			}
		}

		// Token: 0x06015A0A RID: 88586 RVA: 0x003237D1 File Offset: 0x003219D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueLimitedAward()
		{
		}

		// Token: 0x06015A0B RID: 88587 RVA: 0x003237DC File Offset: 0x003219DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueLimitedAward(RogueLimitedAward other) : this()
		{
			this.signState_ = other.signState_;
			this.curProgress_ = other.curProgress_;
			this.maxProgress_ = other.maxProgress_;
			this.configId_ = other.configId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015A0C RID: 88588 RVA: 0x00323830 File Offset: 0x00321A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueLimitedAward Clone()
		{
			return new RogueLimitedAward(this);
		}

		// Token: 0x17004820 RID: 18464
		// (get) Token: 0x06015A0D RID: 88589 RVA: 0x00323838 File Offset: 0x00321A38
		// (set) Token: 0x06015A0E RID: 88590 RVA: 0x00323840 File Offset: 0x00321A40
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

		// Token: 0x17004821 RID: 18465
		// (get) Token: 0x06015A0F RID: 88591 RVA: 0x00323849 File Offset: 0x00321A49
		// (set) Token: 0x06015A10 RID: 88592 RVA: 0x00323851 File Offset: 0x00321A51
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

		// Token: 0x17004822 RID: 18466
		// (get) Token: 0x06015A11 RID: 88593 RVA: 0x0032385A File Offset: 0x00321A5A
		// (set) Token: 0x06015A12 RID: 88594 RVA: 0x00323862 File Offset: 0x00321A62
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

		// Token: 0x17004823 RID: 18467
		// (get) Token: 0x06015A13 RID: 88595 RVA: 0x0032386B File Offset: 0x00321A6B
		// (set) Token: 0x06015A14 RID: 88596 RVA: 0x00323873 File Offset: 0x00321A73
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

		// Token: 0x06015A15 RID: 88597 RVA: 0x0032387C File Offset: 0x00321A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueLimitedAward);
		}

		// Token: 0x06015A16 RID: 88598 RVA: 0x0032388C File Offset: 0x00321A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueLimitedAward other)
		{
			return other != null && (other == this || (this.SignState == other.SignState && this.CurProgress == other.CurProgress && this.MaxProgress == other.MaxProgress && this.ConfigId == other.ConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015A17 RID: 88599 RVA: 0x003238F8 File Offset: 0x00321AF8
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

		// Token: 0x06015A18 RID: 88600 RVA: 0x00323988 File Offset: 0x00321B88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015A19 RID: 88601 RVA: 0x00323995 File Offset: 0x00321B95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015A1A RID: 88602 RVA: 0x003239A0 File Offset: 0x00321BA0
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

		// Token: 0x06015A1B RID: 88603 RVA: 0x00323A30 File Offset: 0x00321C30
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

		// Token: 0x06015A1C RID: 88604 RVA: 0x00323AB8 File Offset: 0x00321CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueLimitedAward other)
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

		// Token: 0x06015A1D RID: 88605 RVA: 0x00323B30 File Offset: 0x00321D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015A1E RID: 88606 RVA: 0x00323B3C File Offset: 0x00321D3C
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

		// Token: 0x040081DA RID: 33242
		private static readonly MessageParser<RogueLimitedAward> _parser = new MessageParser<RogueLimitedAward>(() => new RogueLimitedAward());

		// Token: 0x040081DB RID: 33243
		private UnknownFieldSet _unknownFields;

		// Token: 0x040081DC RID: 33244
		public const int SignStateFieldNumber = 1;

		// Token: 0x040081DD RID: 33245
		private SignState signState_;

		// Token: 0x040081DE RID: 33246
		public const int CurProgressFieldNumber = 2;

		// Token: 0x040081DF RID: 33247
		private int curProgress_;

		// Token: 0x040081E0 RID: 33248
		public const int MaxProgressFieldNumber = 3;

		// Token: 0x040081E1 RID: 33249
		private int maxProgress_;

		// Token: 0x040081E2 RID: 33250
		public const int ConfigIdFieldNumber = 4;

		// Token: 0x040081E3 RID: 33251
		private int configId_;
	}
}
