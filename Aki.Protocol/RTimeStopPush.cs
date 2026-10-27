using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200113A RID: 4410
	[NetMessage(EMessageId.RTimeStopPush)]
	public sealed class RTimeStopPush : IMessage<RTimeStopPush>, IMessage, IEquatable<RTimeStopPush>, IDeepCloneable<RTimeStopPush>, IBufferMessage
	{
		// Token: 0x0601784A RID: 96330 RVA: 0x0036A4D9 File Offset: 0x003686D9
		[NullableContext(1)]
		public static RTimeStopPush Create()
		{
			return new RTimeStopPush();
		}

		// Token: 0x17004EEE RID: 20206
		// (get) Token: 0x0601784B RID: 96331 RVA: 0x0036A4E0 File Offset: 0x003686E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004EEF RID: 20207
		// (get) Token: 0x0601784C RID: 96332 RVA: 0x0036A4E3 File Offset: 0x003686E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RTimeStopPush.Descriptor;
			}
		}

		// Token: 0x0601784D RID: 96333 RVA: 0x0036A4EA File Offset: 0x003686EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopPush()
		{
		}

		// Token: 0x0601784E RID: 96334 RVA: 0x0036A4F2 File Offset: 0x003686F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopPush(RTimeStopPush other) : this()
		{
			this.isStopCharacter_ = other.isStopCharacter_;
			this.duration_ = other.duration_;
			this.dilation_ = other.dilation_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601784F RID: 96335 RVA: 0x0036A52F File Offset: 0x0036872F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopPush Clone()
		{
			return new RTimeStopPush(this);
		}

		// Token: 0x17004EF0 RID: 20208
		// (get) Token: 0x06017850 RID: 96336 RVA: 0x0036A537 File Offset: 0x00368737
		// (set) Token: 0x06017851 RID: 96337 RVA: 0x0036A53F File Offset: 0x0036873F
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

		// Token: 0x17004EF1 RID: 20209
		// (get) Token: 0x06017852 RID: 96338 RVA: 0x0036A548 File Offset: 0x00368748
		// (set) Token: 0x06017853 RID: 96339 RVA: 0x0036A550 File Offset: 0x00368750
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

		// Token: 0x17004EF2 RID: 20210
		// (get) Token: 0x06017854 RID: 96340 RVA: 0x0036A559 File Offset: 0x00368759
		// (set) Token: 0x06017855 RID: 96341 RVA: 0x0036A561 File Offset: 0x00368761
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

		// Token: 0x06017856 RID: 96342 RVA: 0x0036A56A File Offset: 0x0036876A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RTimeStopPush);
		}

		// Token: 0x06017857 RID: 96343 RVA: 0x0036A578 File Offset: 0x00368778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RTimeStopPush other)
		{
			return other != null && (other == this || (this.IsStopCharacter == other.IsStopCharacter && this.Duration == other.Duration && this.Dilation == other.Dilation && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017858 RID: 96344 RVA: 0x0036A5D4 File Offset: 0x003687D4
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

		// Token: 0x06017859 RID: 96345 RVA: 0x0036A645 File Offset: 0x00368845
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601785A RID: 96346 RVA: 0x0036A652 File Offset: 0x00368852
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601785B RID: 96347 RVA: 0x0036A65C File Offset: 0x0036885C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Duration != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Duration);
			}
			if (this.IsStopCharacter)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.IsStopCharacter);
			}
			if (this.Dilation != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.Dilation);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601785C RID: 96348 RVA: 0x0036A6D4 File Offset: 0x003688D4
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

		// Token: 0x0601785D RID: 96349 RVA: 0x0036A738 File Offset: 0x00368938
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

		// Token: 0x0601785E RID: 96350 RVA: 0x0036A79C File Offset: 0x0036899C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601785F RID: 96351 RVA: 0x0036A7A8 File Offset: 0x003689A8
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
				if (num != 16U)
				{
					if (num != 112U)
					{
						if (num != 120U)
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

		// Token: 0x04008BBE RID: 35774
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008BBF RID: 35775
		public const int IsStopCharacterFieldNumber = 14;

		// Token: 0x04008BC0 RID: 35776
		private bool isStopCharacter_;

		// Token: 0x04008BC1 RID: 35777
		public const int DurationFieldNumber = 2;

		// Token: 0x04008BC2 RID: 35778
		private int duration_;

		// Token: 0x04008BC3 RID: 35779
		public const int DilationFieldNumber = 15;

		// Token: 0x04008BC4 RID: 35780
		private int dilation_;
	}
}
