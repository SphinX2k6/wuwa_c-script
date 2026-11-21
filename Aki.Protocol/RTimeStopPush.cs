using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001174 RID: 4468
	[NetMessage(EMessageId.RTimeStopPush)]
	public sealed class RTimeStopPush : IMessage<RTimeStopPush>, IMessage, IEquatable<RTimeStopPush>, IDeepCloneable<RTimeStopPush>, IBufferMessage
	{
		// Token: 0x06017DEB RID: 97771 RVA: 0x00379829 File Offset: 0x00377A29
		[NullableContext(1)]
		public static RTimeStopPush Create()
		{
			return new RTimeStopPush();
		}

		// Token: 0x1700505A RID: 20570
		// (get) Token: 0x06017DEC RID: 97772 RVA: 0x00379830 File Offset: 0x00377A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700505B RID: 20571
		// (get) Token: 0x06017DED RID: 97773 RVA: 0x00379833 File Offset: 0x00377A33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RTimeStopPush.Descriptor;
			}
		}

		// Token: 0x06017DEE RID: 97774 RVA: 0x0037983A File Offset: 0x00377A3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopPush()
		{
		}

		// Token: 0x06017DEF RID: 97775 RVA: 0x00379842 File Offset: 0x00377A42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopPush(RTimeStopPush other) : this()
		{
			this.isStopCharacter_ = other.isStopCharacter_;
			this.duration_ = other.duration_;
			this.dilation_ = other.dilation_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017DF0 RID: 97776 RVA: 0x0037987F File Offset: 0x00377A7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopPush Clone()
		{
			return new RTimeStopPush(this);
		}

		// Token: 0x1700505C RID: 20572
		// (get) Token: 0x06017DF1 RID: 97777 RVA: 0x00379887 File Offset: 0x00377A87
		// (set) Token: 0x06017DF2 RID: 97778 RVA: 0x0037988F File Offset: 0x00377A8F
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

		// Token: 0x1700505D RID: 20573
		// (get) Token: 0x06017DF3 RID: 97779 RVA: 0x00379898 File Offset: 0x00377A98
		// (set) Token: 0x06017DF4 RID: 97780 RVA: 0x003798A0 File Offset: 0x00377AA0
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

		// Token: 0x1700505E RID: 20574
		// (get) Token: 0x06017DF5 RID: 97781 RVA: 0x003798A9 File Offset: 0x00377AA9
		// (set) Token: 0x06017DF6 RID: 97782 RVA: 0x003798B1 File Offset: 0x00377AB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Dilation
		{
			get
			{
				return this.dilation_;
			}
			set
			{
				this.dilation_ = value;
			}
		}

		// Token: 0x06017DF7 RID: 97783 RVA: 0x003798BA File Offset: 0x00377ABA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RTimeStopPush);
		}

		// Token: 0x06017DF8 RID: 97784 RVA: 0x003798C8 File Offset: 0x00377AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RTimeStopPush other)
		{
			return other != null && (other == this || (this.IsStopCharacter == other.IsStopCharacter && this.Duration == other.Duration && this.Dilation == other.Dilation && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017DF9 RID: 97785 RVA: 0x00379924 File Offset: 0x00377B24
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
			if (this.Dilation != 0)
			{
				num ^= this.Dilation.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017DFA RID: 97786 RVA: 0x00379995 File Offset: 0x00377B95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017DFB RID: 97787 RVA: 0x003799A2 File Offset: 0x00377BA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017DFC RID: 97788 RVA: 0x003799AC File Offset: 0x00377BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Duration != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Duration);
			}
			if (this.IsStopCharacter)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsStopCharacter);
			}
			if (this.Dilation != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Dilation);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017DFD RID: 97789 RVA: 0x00379A20 File Offset: 0x00377C20
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
			if (this.Dilation != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Dilation);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017DFE RID: 97790 RVA: 0x00379A84 File Offset: 0x00377C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RTimeStopPush other)
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
			if (other.Dilation != 0)
			{
				this.Dilation = other.Dilation;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017DFF RID: 97791 RVA: 0x00379AE8 File Offset: 0x00377CE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017E00 RID: 97792 RVA: 0x00379AF4 File Offset: 0x00377CF4
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
					if (num != 40U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Dilation = input.ReadInt32();
						}
					}
					else
					{
						this.IsStopCharacter = input.ReadBool();
					}
				}
				else
				{
					this.Duration = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008E51 RID: 36433
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E52 RID: 36434
		public const int IsStopCharacterFieldNumber = 5;

		// Token: 0x04008E53 RID: 36435
		private bool isStopCharacter_;

		// Token: 0x04008E54 RID: 36436
		public const int DurationFieldNumber = 1;

		// Token: 0x04008E55 RID: 36437
		private int duration_;

		// Token: 0x04008E56 RID: 36438
		public const int DilationFieldNumber = 12;

		// Token: 0x04008E57 RID: 36439
		private int dilation_;
	}
}
