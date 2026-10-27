using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A6A RID: 2666
	public sealed class MotorFightTalentPb : IMessage<MotorFightTalentPb>, IMessage, IEquatable<MotorFightTalentPb>, IDeepCloneable<MotorFightTalentPb>, IBufferMessage
	{
		// Token: 0x0600E88C RID: 59532 RVA: 0x0021FA0E File Offset: 0x0021DC0E
		[NullableContext(1)]
		public static MotorFightTalentPb Create()
		{
			return new MotorFightTalentPb();
		}

		// Token: 0x17002F32 RID: 12082
		// (get) Token: 0x0600E88D RID: 59533 RVA: 0x0021FA15 File Offset: 0x0021DC15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MotorFightTalentPb> Parser
		{
			get
			{
				return MotorFightTalentPb._parser;
			}
		}

		// Token: 0x17002F33 RID: 12083
		// (get) Token: 0x0600E88E RID: 59534 RVA: 0x0021FA1C File Offset: 0x0021DC1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F34 RID: 12084
		// (get) Token: 0x0600E88F RID: 59535 RVA: 0x0021FA1F File Offset: 0x0021DC1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightTalentPb.Descriptor;
			}
		}

		// Token: 0x0600E890 RID: 59536 RVA: 0x0021FA26 File Offset: 0x0021DC26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightTalentPb()
		{
		}

		// Token: 0x0600E891 RID: 59537 RVA: 0x0021FA2E File Offset: 0x0021DC2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightTalentPb(MotorFightTalentPb other) : this()
		{
			this.id_ = other.id_;
			this.unlock_ = other.unlock_;
			this.inUse_ = other.inUse_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E892 RID: 59538 RVA: 0x0021FA6B File Offset: 0x0021DC6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightTalentPb Clone()
		{
			return new MotorFightTalentPb(this);
		}

		// Token: 0x17002F35 RID: 12085
		// (get) Token: 0x0600E893 RID: 59539 RVA: 0x0021FA73 File Offset: 0x0021DC73
		// (set) Token: 0x0600E894 RID: 59540 RVA: 0x0021FA7B File Offset: 0x0021DC7B
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

		// Token: 0x17002F36 RID: 12086
		// (get) Token: 0x0600E895 RID: 59541 RVA: 0x0021FA84 File Offset: 0x0021DC84
		// (set) Token: 0x0600E896 RID: 59542 RVA: 0x0021FA8C File Offset: 0x0021DC8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Unlock
		{
			get
			{
				return this.unlock_;
			}
			set
			{
				this.unlock_ = value;
			}
		}

		// Token: 0x17002F37 RID: 12087
		// (get) Token: 0x0600E897 RID: 59543 RVA: 0x0021FA95 File Offset: 0x0021DC95
		// (set) Token: 0x0600E898 RID: 59544 RVA: 0x0021FA9D File Offset: 0x0021DC9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool InUse
		{
			get
			{
				return this.inUse_;
			}
			set
			{
				this.inUse_ = value;
			}
		}

		// Token: 0x0600E899 RID: 59545 RVA: 0x0021FAA6 File Offset: 0x0021DCA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightTalentPb);
		}

		// Token: 0x0600E89A RID: 59546 RVA: 0x0021FAB4 File Offset: 0x0021DCB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightTalentPb other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Unlock == other.Unlock && this.InUse == other.InUse && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E89B RID: 59547 RVA: 0x0021FB10 File Offset: 0x0021DD10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Unlock)
			{
				num ^= this.Unlock.GetHashCode();
			}
			if (this.InUse)
			{
				num ^= this.InUse.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E89C RID: 59548 RVA: 0x0021FB81 File Offset: 0x0021DD81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E89D RID: 59549 RVA: 0x0021FB8E File Offset: 0x0021DD8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E89E RID: 59550 RVA: 0x0021FB98 File Offset: 0x0021DD98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Unlock)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.Unlock);
			}
			if (this.InUse)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.InUse);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E89F RID: 59551 RVA: 0x0021FC0C File Offset: 0x0021DE0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Unlock)
			{
				num += 2;
			}
			if (this.InUse)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E8A0 RID: 59552 RVA: 0x0021FC64 File Offset: 0x0021DE64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightTalentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Unlock)
			{
				this.Unlock = other.Unlock;
			}
			if (other.InUse)
			{
				this.InUse = other.InUse;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E8A1 RID: 59553 RVA: 0x0021FCC8 File Offset: 0x0021DEC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E8A2 RID: 59554 RVA: 0x0021FCD4 File Offset: 0x0021DED4
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
					if (num != 24U)
					{
						if (num != 32U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.InUse = input.ReadBool();
						}
					}
					else
					{
						this.Unlock = input.ReadBool();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005EB1 RID: 24241
		private static readonly MessageParser<MotorFightTalentPb> _parser = new MessageParser<MotorFightTalentPb>(() => new MotorFightTalentPb());

		// Token: 0x04005EB2 RID: 24242
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005EB3 RID: 24243
		public const int IdFieldNumber = 1;

		// Token: 0x04005EB4 RID: 24244
		private int id_;

		// Token: 0x04005EB5 RID: 24245
		public const int UnlockFieldNumber = 3;

		// Token: 0x04005EB6 RID: 24246
		private bool unlock_;

		// Token: 0x04005EB7 RID: 24247
		public const int InUseFieldNumber = 4;

		// Token: 0x04005EB8 RID: 24248
		private bool inUse_;
	}
}
