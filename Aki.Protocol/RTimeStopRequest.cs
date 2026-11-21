using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001175 RID: 4469
	[NetMessage(EMessageId.RTimeStopRequest)]
	public sealed class RTimeStopRequest : IMessage<RTimeStopRequest>, IMessage, IEquatable<RTimeStopRequest>, IDeepCloneable<RTimeStopRequest>, IBufferMessage
	{
		// Token: 0x06017E01 RID: 97793 RVA: 0x00379B5E File Offset: 0x00377D5E
		[NullableContext(1)]
		public static RTimeStopRequest Create()
		{
			return new RTimeStopRequest();
		}

		// Token: 0x1700505F RID: 20575
		// (get) Token: 0x06017E02 RID: 97794 RVA: 0x00379B65 File Offset: 0x00377D65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005060 RID: 20576
		// (get) Token: 0x06017E03 RID: 97795 RVA: 0x00379B68 File Offset: 0x00377D68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RTimeStopRequest.Descriptor;
			}
		}

		// Token: 0x06017E04 RID: 97796 RVA: 0x00379B6F File Offset: 0x00377D6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopRequest()
		{
		}

		// Token: 0x06017E05 RID: 97797 RVA: 0x00379B77 File Offset: 0x00377D77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopRequest(RTimeStopRequest other) : this()
		{
			this.isStopCharacter_ = other.isStopCharacter_;
			this.duration_ = other.duration_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017E06 RID: 97798 RVA: 0x00379BA8 File Offset: 0x00377DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopRequest Clone()
		{
			return new RTimeStopRequest(this);
		}

		// Token: 0x17005061 RID: 20577
		// (get) Token: 0x06017E07 RID: 97799 RVA: 0x00379BB0 File Offset: 0x00377DB0
		// (set) Token: 0x06017E08 RID: 97800 RVA: 0x00379BB8 File Offset: 0x00377DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsStopCharacter
		{
			get
			{
				return this.isStopCharacter_;
			}
			set
			{
				this.isStopCharacter_ = value;
			}
		}

		// Token: 0x17005062 RID: 20578
		// (get) Token: 0x06017E09 RID: 97801 RVA: 0x00379BC1 File Offset: 0x00377DC1
		// (set) Token: 0x06017E0A RID: 97802 RVA: 0x00379BC9 File Offset: 0x00377DC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Duration
		{
			get
			{
				return this.duration_;
			}
			set
			{
				this.duration_ = value;
			}
		}

		// Token: 0x06017E0B RID: 97803 RVA: 0x00379BD2 File Offset: 0x00377DD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RTimeStopRequest);
		}

		// Token: 0x06017E0C RID: 97804 RVA: 0x00379BE0 File Offset: 0x00377DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RTimeStopRequest other)
		{
			return other != null && (other == this || (this.IsStopCharacter == other.IsStopCharacter && this.Duration == other.Duration && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017E0D RID: 97805 RVA: 0x00379C20 File Offset: 0x00377E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsStopCharacter)
			{
				num ^= this.IsStopCharacter.GetHashCode();
			}
			if (this.Duration != 0)
			{
				num ^= this.Duration.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017E0E RID: 97806 RVA: 0x00379C78 File Offset: 0x00377E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017E0F RID: 97807 RVA: 0x00379C85 File Offset: 0x00377E85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017E10 RID: 97808 RVA: 0x00379C90 File Offset: 0x00377E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsStopCharacter)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsStopCharacter);
			}
			if (this.Duration != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Duration);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017E11 RID: 97809 RVA: 0x00379CEC File Offset: 0x00377EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsStopCharacter)
			{
				num += 2;
			}
			if (this.Duration != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Duration);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017E12 RID: 97810 RVA: 0x00379D38 File Offset: 0x00377F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RTimeStopRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsStopCharacter)
			{
				this.IsStopCharacter = other.IsStopCharacter;
			}
			if (other.Duration != 0)
			{
				this.Duration = other.Duration;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017E13 RID: 97811 RVA: 0x00379D88 File Offset: 0x00377F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017E14 RID: 97812 RVA: 0x00379D94 File Offset: 0x00377F94
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
				if (num != 24U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Duration = input.ReadInt32();
					}
				}
				else
				{
					this.IsStopCharacter = input.ReadBool();
				}
			}
		}

		// Token: 0x04008E58 RID: 36440
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E59 RID: 36441
		public const int IsStopCharacterFieldNumber = 3;

		// Token: 0x04008E5A RID: 36442
		private bool isStopCharacter_;

		// Token: 0x04008E5B RID: 36443
		public const int DurationFieldNumber = 12;

		// Token: 0x04008E5C RID: 36444
		private int duration_;
	}
}
