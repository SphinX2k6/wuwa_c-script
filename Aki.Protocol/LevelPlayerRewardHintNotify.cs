using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008F7 RID: 2295
	[NetMessage(EMessageId.LevelPlayerRewardHintNotify)]
	public sealed class LevelPlayerRewardHintNotify : IMessage<LevelPlayerRewardHintNotify>, IMessage, IEquatable<LevelPlayerRewardHintNotify>, IDeepCloneable<LevelPlayerRewardHintNotify>, IBufferMessage
	{
		// Token: 0x0600CAD2 RID: 51922 RVA: 0x001DEDDC File Offset: 0x001DCFDC
		[NullableContext(1)]
		public static LevelPlayerRewardHintNotify Create()
		{
			return new LevelPlayerRewardHintNotify();
		}

		// Token: 0x170028F3 RID: 10483
		// (get) Token: 0x0600CAD3 RID: 51923 RVA: 0x001DEDE3 File Offset: 0x001DCFE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170028F4 RID: 10484
		// (get) Token: 0x0600CAD4 RID: 51924 RVA: 0x001DEDE6 File Offset: 0x001DCFE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayerRewardHintNotify.Descriptor;
			}
		}

		// Token: 0x0600CAD5 RID: 51925 RVA: 0x001DEDED File Offset: 0x001DCFED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayerRewardHintNotify()
		{
		}

		// Token: 0x0600CAD6 RID: 51926 RVA: 0x001DEDF5 File Offset: 0x001DCFF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayerRewardHintNotify(LevelPlayerRewardHintNotify other) : this()
		{
			this.id_ = other.id_;
			this.resetTime_ = other.resetTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CAD7 RID: 51927 RVA: 0x001DEE26 File Offset: 0x001DD026
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayerRewardHintNotify Clone()
		{
			return new LevelPlayerRewardHintNotify(this);
		}

		// Token: 0x170028F5 RID: 10485
		// (get) Token: 0x0600CAD8 RID: 51928 RVA: 0x001DEE2E File Offset: 0x001DD02E
		// (set) Token: 0x0600CAD9 RID: 51929 RVA: 0x001DEE36 File Offset: 0x001DD036
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

		// Token: 0x170028F6 RID: 10486
		// (get) Token: 0x0600CADA RID: 51930 RVA: 0x001DEE3F File Offset: 0x001DD03F
		// (set) Token: 0x0600CADB RID: 51931 RVA: 0x001DEE47 File Offset: 0x001DD047
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ResetTime
		{
			get
			{
				return this.resetTime_;
			}
			set
			{
				this.resetTime_ = value;
			}
		}

		// Token: 0x0600CADC RID: 51932 RVA: 0x001DEE50 File Offset: 0x001DD050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayerRewardHintNotify);
		}

		// Token: 0x0600CADD RID: 51933 RVA: 0x001DEE5E File Offset: 0x001DD05E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayerRewardHintNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.ResetTime == other.ResetTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CADE RID: 51934 RVA: 0x001DEE9C File Offset: 0x001DD09C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.ResetTime != 0L)
			{
				num ^= this.ResetTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CADF RID: 51935 RVA: 0x001DEEF4 File Offset: 0x001DD0F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CAE0 RID: 51936 RVA: 0x001DEF01 File Offset: 0x001DD101
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CAE1 RID: 51937 RVA: 0x001DEF0C File Offset: 0x001DD10C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ResetTime != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.ResetTime);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CAE2 RID: 51938 RVA: 0x001DEF68 File Offset: 0x001DD168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.ResetTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ResetTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CAE3 RID: 51939 RVA: 0x001DEFC0 File Offset: 0x001DD1C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LevelPlayerRewardHintNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.ResetTime != 0L)
			{
				this.ResetTime = other.ResetTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CAE4 RID: 51940 RVA: 0x001DF010 File Offset: 0x001DD210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CAE5 RID: 51941 RVA: 0x001DF01C File Offset: 0x001DD21C
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
				if (num != 40U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadInt32();
					}
				}
				else
				{
					this.ResetTime = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400563D RID: 22077
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400563E RID: 22078
		public const int IdFieldNumber = 9;

		// Token: 0x0400563F RID: 22079
		private int id_;

		// Token: 0x04005640 RID: 22080
		public const int ResetTimeFieldNumber = 5;

		// Token: 0x04005641 RID: 22081
		private long resetTime_;
	}
}
