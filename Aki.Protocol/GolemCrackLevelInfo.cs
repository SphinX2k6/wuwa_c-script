using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000703 RID: 1795
	public sealed class GolemCrackLevelInfo : IMessage<GolemCrackLevelInfo>, IMessage, IEquatable<GolemCrackLevelInfo>, IDeepCloneable<GolemCrackLevelInfo>, IBufferMessage
	{
		// Token: 0x0600A35C RID: 41820 RVA: 0x0018A9CD File Offset: 0x00188BCD
		[NullableContext(1)]
		public static GolemCrackLevelInfo Create()
		{
			return new GolemCrackLevelInfo();
		}

		// Token: 0x170020D4 RID: 8404
		// (get) Token: 0x0600A35D RID: 41821 RVA: 0x0018A9D4 File Offset: 0x00188BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GolemCrackLevelInfo> Parser
		{
			get
			{
				return GolemCrackLevelInfo._parser;
			}
		}

		// Token: 0x170020D5 RID: 8405
		// (get) Token: 0x0600A35E RID: 41822 RVA: 0x0018A9DB File Offset: 0x00188BDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170020D6 RID: 8406
		// (get) Token: 0x0600A35F RID: 41823 RVA: 0x0018A9DE File Offset: 0x00188BDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GolemCrackLevelInfo.Descriptor;
			}
		}

		// Token: 0x0600A360 RID: 41824 RVA: 0x0018A9E5 File Offset: 0x00188BE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GolemCrackLevelInfo()
		{
		}

		// Token: 0x0600A361 RID: 41825 RVA: 0x0018A9F0 File Offset: 0x00188BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GolemCrackLevelInfo(GolemCrackLevelInfo other) : this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			this.state_ = other.state_;
			this.unlockTime_ = other.unlockTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A362 RID: 41826 RVA: 0x0018AA44 File Offset: 0x00188C44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GolemCrackLevelInfo Clone()
		{
			return new GolemCrackLevelInfo(this);
		}

		// Token: 0x170020D7 RID: 8407
		// (get) Token: 0x0600A363 RID: 41827 RVA: 0x0018AA4C File Offset: 0x00188C4C
		// (set) Token: 0x0600A364 RID: 41828 RVA: 0x0018AA54 File Offset: 0x00188C54
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

		// Token: 0x170020D8 RID: 8408
		// (get) Token: 0x0600A365 RID: 41829 RVA: 0x0018AA5D File Offset: 0x00188C5D
		// (set) Token: 0x0600A366 RID: 41830 RVA: 0x0018AA75 File Offset: 0x00188C75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GolemCrackState State
		{
			get
			{
				if ((this._hasBits0 & 1) != 0)
				{
					return this.state_;
				}
				return GolemCrackLevelInfo.StateDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.state_ = value;
			}
		}

		// Token: 0x170020D9 RID: 8409
		// (get) Token: 0x0600A367 RID: 41831 RVA: 0x0018AA8C File Offset: 0x00188C8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasState
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600A368 RID: 41832 RVA: 0x0018AA99 File Offset: 0x00188C99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearState()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170020DA RID: 8410
		// (get) Token: 0x0600A369 RID: 41833 RVA: 0x0018AAAA File Offset: 0x00188CAA
		// (set) Token: 0x0600A36A RID: 41834 RVA: 0x0018AAC2 File Offset: 0x00188CC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long UnlockTime
		{
			get
			{
				if ((this._hasBits0 & 2) != 0)
				{
					return this.unlockTime_;
				}
				return GolemCrackLevelInfo.UnlockTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.unlockTime_ = value;
			}
		}

		// Token: 0x170020DB RID: 8411
		// (get) Token: 0x0600A36B RID: 41835 RVA: 0x0018AAD9 File Offset: 0x00188CD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasUnlockTime
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600A36C RID: 41836 RVA: 0x0018AAE6 File Offset: 0x00188CE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearUnlockTime()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x0600A36D RID: 41837 RVA: 0x0018AAF7 File Offset: 0x00188CF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GolemCrackLevelInfo);
		}

		// Token: 0x0600A36E RID: 41838 RVA: 0x0018AB08 File Offset: 0x00188D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GolemCrackLevelInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.State == other.State && this.UnlockTime == other.UnlockTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A36F RID: 41839 RVA: 0x0018AB64 File Offset: 0x00188D64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.HasState)
			{
				num ^= this.State.GetHashCode();
			}
			if (this.HasUnlockTime)
			{
				num ^= this.UnlockTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A370 RID: 41840 RVA: 0x0018ABDB File Offset: 0x00188DDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A371 RID: 41841 RVA: 0x0018ABE8 File Offset: 0x00188DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A372 RID: 41842 RVA: 0x0018ABF4 File Offset: 0x00188DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.HasState)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.State);
			}
			if (this.HasUnlockTime)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.UnlockTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A373 RID: 41843 RVA: 0x0018AC68 File Offset: 0x00188E68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.HasState)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.State);
			}
			if (this.HasUnlockTime)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.UnlockTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A374 RID: 41844 RVA: 0x0018ACD8 File Offset: 0x00188ED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GolemCrackLevelInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.HasState)
			{
				this.State = other.State;
			}
			if (other.HasUnlockTime)
			{
				this.UnlockTime = other.UnlockTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A375 RID: 41845 RVA: 0x0018AD3C File Offset: 0x00188F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A376 RID: 41846 RVA: 0x0018AD48 File Offset: 0x00188F48
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
							this.UnlockTime = input.ReadInt64();
						}
					}
					else
					{
						this.State = (GolemCrackState)input.ReadEnum();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004B80 RID: 19328
		private static readonly MessageParser<GolemCrackLevelInfo> _parser = new MessageParser<GolemCrackLevelInfo>(() => new GolemCrackLevelInfo());

		// Token: 0x04004B81 RID: 19329
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B82 RID: 19330
		private int _hasBits0;

		// Token: 0x04004B83 RID: 19331
		public const int IdFieldNumber = 1;

		// Token: 0x04004B84 RID: 19332
		private int id_;

		// Token: 0x04004B85 RID: 19333
		public const int StateFieldNumber = 2;

		// Token: 0x04004B86 RID: 19334
		private static readonly GolemCrackState StateDefaultValue = GolemCrackState.GolemCrackLocked;

		// Token: 0x04004B87 RID: 19335
		private GolemCrackState state_;

		// Token: 0x04004B88 RID: 19336
		public const int UnlockTimeFieldNumber = 3;

		// Token: 0x04004B89 RID: 19337
		private static readonly long UnlockTimeDefaultValue = 0L;

		// Token: 0x04004B8A RID: 19338
		private long unlockTime_;
	}
}
