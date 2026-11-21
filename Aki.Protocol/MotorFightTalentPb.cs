using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A59 RID: 2649
	public sealed class MotorFightTalentPb : IMessage<MotorFightTalentPb>, IMessage, IEquatable<MotorFightTalentPb>, IDeepCloneable<MotorFightTalentPb>, IBufferMessage
	{
		// Token: 0x0600E772 RID: 59250 RVA: 0x0021D81A File Offset: 0x0021BA1A
		[NullableContext(1)]
		public static MotorFightTalentPb Create()
		{
			return new MotorFightTalentPb();
		}

		// Token: 0x17002EF4 RID: 12020
		// (get) Token: 0x0600E773 RID: 59251 RVA: 0x0021D821 File Offset: 0x0021BA21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MotorFightTalentPb> Parser
		{
			get
			{
				return MotorFightTalentPb._parser;
			}
		}

		// Token: 0x17002EF5 RID: 12021
		// (get) Token: 0x0600E774 RID: 59252 RVA: 0x0021D828 File Offset: 0x0021BA28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002EF6 RID: 12022
		// (get) Token: 0x0600E775 RID: 59253 RVA: 0x0021D82B File Offset: 0x0021BA2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightTalentPb.Descriptor;
			}
		}

		// Token: 0x0600E776 RID: 59254 RVA: 0x0021D832 File Offset: 0x0021BA32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightTalentPb()
		{
		}

		// Token: 0x0600E777 RID: 59255 RVA: 0x0021D83A File Offset: 0x0021BA3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightTalentPb(MotorFightTalentPb other) : this()
		{
			this.id_ = other.id_;
			this.unlock_ = other.unlock_;
			this.inUse_ = other.inUse_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E778 RID: 59256 RVA: 0x0021D877 File Offset: 0x0021BA77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightTalentPb Clone()
		{
			return new MotorFightTalentPb(this);
		}

		// Token: 0x17002EF7 RID: 12023
		// (get) Token: 0x0600E779 RID: 59257 RVA: 0x0021D87F File Offset: 0x0021BA7F
		// (set) Token: 0x0600E77A RID: 59258 RVA: 0x0021D887 File Offset: 0x0021BA87
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

		// Token: 0x17002EF8 RID: 12024
		// (get) Token: 0x0600E77B RID: 59259 RVA: 0x0021D890 File Offset: 0x0021BA90
		// (set) Token: 0x0600E77C RID: 59260 RVA: 0x0021D898 File Offset: 0x0021BA98
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

		// Token: 0x17002EF9 RID: 12025
		// (get) Token: 0x0600E77D RID: 59261 RVA: 0x0021D8A1 File Offset: 0x0021BAA1
		// (set) Token: 0x0600E77E RID: 59262 RVA: 0x0021D8A9 File Offset: 0x0021BAA9
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

		// Token: 0x0600E77F RID: 59263 RVA: 0x0021D8B2 File Offset: 0x0021BAB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightTalentPb);
		}

		// Token: 0x0600E780 RID: 59264 RVA: 0x0021D8C0 File Offset: 0x0021BAC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightTalentPb other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Unlock == other.Unlock && this.InUse == other.InUse && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E781 RID: 59265 RVA: 0x0021D91C File Offset: 0x0021BB1C
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

		// Token: 0x0600E782 RID: 59266 RVA: 0x0021D98D File Offset: 0x0021BB8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E783 RID: 59267 RVA: 0x0021D99A File Offset: 0x0021BB9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E784 RID: 59268 RVA: 0x0021D9A4 File Offset: 0x0021BBA4
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

		// Token: 0x0600E785 RID: 59269 RVA: 0x0021DA18 File Offset: 0x0021BC18
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

		// Token: 0x0600E786 RID: 59270 RVA: 0x0021DA70 File Offset: 0x0021BC70
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

		// Token: 0x0600E787 RID: 59271 RVA: 0x0021DAD4 File Offset: 0x0021BCD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E788 RID: 59272 RVA: 0x0021DAE0 File Offset: 0x0021BCE0
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

		// Token: 0x04005EBA RID: 24250
		private static readonly MessageParser<MotorFightTalentPb> _parser = new MessageParser<MotorFightTalentPb>(() => new MotorFightTalentPb());

		// Token: 0x04005EBB RID: 24251
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005EBC RID: 24252
		public const int IdFieldNumber = 1;

		// Token: 0x04005EBD RID: 24253
		private int id_;

		// Token: 0x04005EBE RID: 24254
		public const int UnlockFieldNumber = 3;

		// Token: 0x04005EBF RID: 24255
		private bool unlock_;

		// Token: 0x04005EC0 RID: 24256
		public const int InUseFieldNumber = 4;

		// Token: 0x04005EC1 RID: 24257
		private bool inUse_;
	}
}
