using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000597 RID: 1431
	public sealed class FlagChallengeLevelInfo : IMessage<FlagChallengeLevelInfo>, IMessage, IEquatable<FlagChallengeLevelInfo>, IDeepCloneable<FlagChallengeLevelInfo>, IBufferMessage
	{
		// Token: 0x06008487 RID: 33927 RVA: 0x0013EEE1 File Offset: 0x0013D0E1
		[NullableContext(1)]
		public static FlagChallengeLevelInfo Create()
		{
			return new FlagChallengeLevelInfo();
		}

		// Token: 0x170019D4 RID: 6612
		// (get) Token: 0x06008488 RID: 33928 RVA: 0x0013EEE8 File Offset: 0x0013D0E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FlagChallengeLevelInfo> Parser
		{
			get
			{
				return FlagChallengeLevelInfo._parser;
			}
		}

		// Token: 0x170019D5 RID: 6613
		// (get) Token: 0x06008489 RID: 33929 RVA: 0x0013EEEF File Offset: 0x0013D0EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019D6 RID: 6614
		// (get) Token: 0x0600848A RID: 33930 RVA: 0x0013EEF2 File Offset: 0x0013D0F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlagChallengeLevelInfo.Descriptor;
			}
		}

		// Token: 0x0600848B RID: 33931 RVA: 0x0013EEF9 File Offset: 0x0013D0F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeLevelInfo()
		{
		}

		// Token: 0x0600848C RID: 33932 RVA: 0x0013EF01 File Offset: 0x0013D101
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeLevelInfo(FlagChallengeLevelInfo other) : this()
		{
			this.id_ = other.id_;
			this.unlockTime_ = other.unlockTime_;
			this.state_ = other.state_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600848D RID: 33933 RVA: 0x0013EF3E File Offset: 0x0013D13E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeLevelInfo Clone()
		{
			return new FlagChallengeLevelInfo(this);
		}

		// Token: 0x170019D7 RID: 6615
		// (get) Token: 0x0600848E RID: 33934 RVA: 0x0013EF46 File Offset: 0x0013D146
		// (set) Token: 0x0600848F RID: 33935 RVA: 0x0013EF4E File Offset: 0x0013D14E
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

		// Token: 0x170019D8 RID: 6616
		// (get) Token: 0x06008490 RID: 33936 RVA: 0x0013EF57 File Offset: 0x0013D157
		// (set) Token: 0x06008491 RID: 33937 RVA: 0x0013EF5F File Offset: 0x0013D15F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long UnlockTime
		{
			get
			{
				return this.unlockTime_;
			}
			set
			{
				this.unlockTime_ = value;
			}
		}

		// Token: 0x170019D9 RID: 6617
		// (get) Token: 0x06008492 RID: 33938 RVA: 0x0013EF68 File Offset: 0x0013D168
		// (set) Token: 0x06008493 RID: 33939 RVA: 0x0013EF70 File Offset: 0x0013D170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x06008494 RID: 33940 RVA: 0x0013EF79 File Offset: 0x0013D179
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlagChallengeLevelInfo);
		}

		// Token: 0x06008495 RID: 33941 RVA: 0x0013EF88 File Offset: 0x0013D188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlagChallengeLevelInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.UnlockTime == other.UnlockTime && this.State == other.State && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008496 RID: 33942 RVA: 0x0013EFE4 File Offset: 0x0013D1E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.UnlockTime != 0L)
			{
				num ^= this.UnlockTime.GetHashCode();
			}
			if (this.State != 0)
			{
				num ^= this.State.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008497 RID: 33943 RVA: 0x0013F055 File Offset: 0x0013D255
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008498 RID: 33944 RVA: 0x0013F062 File Offset: 0x0013D262
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008499 RID: 33945 RVA: 0x0013F06C File Offset: 0x0013D26C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.UnlockTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.UnlockTime);
			}
			if (this.State != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.State);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600849A RID: 33946 RVA: 0x0013F0E0 File Offset: 0x0013D2E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.UnlockTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.UnlockTime);
			}
			if (this.State != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.State);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600849B RID: 33947 RVA: 0x0013F150 File Offset: 0x0013D350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlagChallengeLevelInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.UnlockTime != 0L)
			{
				this.UnlockTime = other.UnlockTime;
			}
			if (other.State != 0)
			{
				this.State = other.State;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600849C RID: 33948 RVA: 0x0013F1B4 File Offset: 0x0013D3B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600849D RID: 33949 RVA: 0x0013F1C0 File Offset: 0x0013D3C0
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.State = input.ReadInt32();
						}
					}
					else
					{
						this.UnlockTime = input.ReadInt64();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x040041C1 RID: 16833
		private static readonly MessageParser<FlagChallengeLevelInfo> _parser = new MessageParser<FlagChallengeLevelInfo>(() => new FlagChallengeLevelInfo());

		// Token: 0x040041C2 RID: 16834
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041C3 RID: 16835
		public const int IdFieldNumber = 1;

		// Token: 0x040041C4 RID: 16836
		private int id_;

		// Token: 0x040041C5 RID: 16837
		public const int UnlockTimeFieldNumber = 2;

		// Token: 0x040041C6 RID: 16838
		private long unlockTime_;

		// Token: 0x040041C7 RID: 16839
		public const int StateFieldNumber = 3;

		// Token: 0x040041C8 RID: 16840
		private int state_;
	}
}
