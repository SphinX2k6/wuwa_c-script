using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008FB RID: 2299
	[NetMessage(EMessageId.LevelPlayStateNotify)]
	public sealed class LevelPlayStateNotify : IMessage<LevelPlayStateNotify>, IMessage, IEquatable<LevelPlayStateNotify>, IDeepCloneable<LevelPlayStateNotify>, IBufferMessage
	{
		// Token: 0x0600CB62 RID: 52066 RVA: 0x001E0238 File Offset: 0x001DE438
		[NullableContext(1)]
		public static LevelPlayStateNotify Create()
		{
			return new LevelPlayStateNotify();
		}

		// Token: 0x1700290D RID: 10509
		// (get) Token: 0x0600CB63 RID: 52067 RVA: 0x001E023F File Offset: 0x001DE43F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700290E RID: 10510
		// (get) Token: 0x0600CB64 RID: 52068 RVA: 0x001E0242 File Offset: 0x001DE442
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayStateNotify.Descriptor;
			}
		}

		// Token: 0x0600CB65 RID: 52069 RVA: 0x001E0249 File Offset: 0x001DE449
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayStateNotify()
		{
		}

		// Token: 0x0600CB66 RID: 52070 RVA: 0x001E0251 File Offset: 0x001DE451
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayStateNotify(LevelPlayStateNotify other) : this()
		{
			this.id_ = other.id_;
			this.state_ = other.state_;
			this.completeNumber_ = other.completeNumber_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CB67 RID: 52071 RVA: 0x001E028E File Offset: 0x001DE48E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayStateNotify Clone()
		{
			return new LevelPlayStateNotify(this);
		}

		// Token: 0x1700290F RID: 10511
		// (get) Token: 0x0600CB68 RID: 52072 RVA: 0x001E0296 File Offset: 0x001DE496
		// (set) Token: 0x0600CB69 RID: 52073 RVA: 0x001E029E File Offset: 0x001DE49E
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

		// Token: 0x17002910 RID: 10512
		// (get) Token: 0x0600CB6A RID: 52074 RVA: 0x001E02A7 File Offset: 0x001DE4A7
		// (set) Token: 0x0600CB6B RID: 52075 RVA: 0x001E02AF File Offset: 0x001DE4AF
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

		// Token: 0x17002911 RID: 10513
		// (get) Token: 0x0600CB6C RID: 52076 RVA: 0x001E02B8 File Offset: 0x001DE4B8
		// (set) Token: 0x0600CB6D RID: 52077 RVA: 0x001E02C0 File Offset: 0x001DE4C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CompleteNumber
		{
			get
			{
				return this.completeNumber_;
			}
			set
			{
				this.completeNumber_ = value;
			}
		}

		// Token: 0x0600CB6E RID: 52078 RVA: 0x001E02C9 File Offset: 0x001DE4C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayStateNotify);
		}

		// Token: 0x0600CB6F RID: 52079 RVA: 0x001E02D8 File Offset: 0x001DE4D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayStateNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.State == other.State && this.CompleteNumber == other.CompleteNumber && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CB70 RID: 52080 RVA: 0x001E0334 File Offset: 0x001DE534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.State != 0)
			{
				num ^= this.State.GetHashCode();
			}
			if (this.CompleteNumber != 0)
			{
				num ^= this.CompleteNumber.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CB71 RID: 52081 RVA: 0x001E03A5 File Offset: 0x001DE5A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CB72 RID: 52082 RVA: 0x001E03B2 File Offset: 0x001DE5B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CB73 RID: 52083 RVA: 0x001E03BC File Offset: 0x001DE5BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.State != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.State);
			}
			if (this.CompleteNumber != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.CompleteNumber);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CB74 RID: 52084 RVA: 0x001E0434 File Offset: 0x001DE634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.State != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.State);
			}
			if (this.CompleteNumber != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CompleteNumber);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CB75 RID: 52085 RVA: 0x001E04A4 File Offset: 0x001DE6A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LevelPlayStateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.State != 0)
			{
				this.State = other.State;
			}
			if (other.CompleteNumber != 0)
			{
				this.CompleteNumber = other.CompleteNumber;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CB76 RID: 52086 RVA: 0x001E0508 File Offset: 0x001DE708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CB77 RID: 52087 RVA: 0x001E0514 File Offset: 0x001DE714
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
					if (num != 40U)
					{
						if (num != 88U)
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
						this.CompleteNumber = input.ReadInt32();
					}
				}
				else
				{
					this.State = input.ReadInt32();
				}
			}
		}

		// Token: 0x040056BB RID: 22203
		private UnknownFieldSet _unknownFields;

		// Token: 0x040056BC RID: 22204
		public const int IdFieldNumber = 11;

		// Token: 0x040056BD RID: 22205
		private int id_;

		// Token: 0x040056BE RID: 22206
		public const int StateFieldNumber = 2;

		// Token: 0x040056BF RID: 22207
		private int state_;

		// Token: 0x040056C0 RID: 22208
		public const int CompleteNumberFieldNumber = 5;

		// Token: 0x040056C1 RID: 22209
		private int completeNumber_;
	}
}
