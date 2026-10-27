using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A93 RID: 2707
	public sealed class MotorParkourCtx : IMessage<MotorParkourCtx>, IMessage, IEquatable<MotorParkourCtx>, IDeepCloneable<MotorParkourCtx>, IBufferMessage
	{
		// Token: 0x0600EBBD RID: 60349 RVA: 0x00226AE5 File Offset: 0x00224CE5
		[NullableContext(1)]
		public static MotorParkourCtx Create()
		{
			return new MotorParkourCtx();
		}

		// Token: 0x17002FDD RID: 12253
		// (get) Token: 0x0600EBBE RID: 60350 RVA: 0x00226AEC File Offset: 0x00224CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002FDE RID: 12254
		// (get) Token: 0x0600EBBF RID: 60351 RVA: 0x00226AEF File Offset: 0x00224CEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorParkourCtx.Descriptor;
			}
		}

		// Token: 0x0600EBC0 RID: 60352 RVA: 0x00226AF6 File Offset: 0x00224CF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorParkourCtx()
		{
		}

		// Token: 0x0600EBC1 RID: 60353 RVA: 0x00226AFE File Offset: 0x00224CFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorParkourCtx(MotorParkourCtx other) : this()
		{
			this.motorParkourId_ = other.motorParkourId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EBC2 RID: 60354 RVA: 0x00226B23 File Offset: 0x00224D23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorParkourCtx Clone()
		{
			return new MotorParkourCtx(this);
		}

		// Token: 0x17002FDF RID: 12255
		// (get) Token: 0x0600EBC3 RID: 60355 RVA: 0x00226B2B File Offset: 0x00224D2B
		// (set) Token: 0x0600EBC4 RID: 60356 RVA: 0x00226B33 File Offset: 0x00224D33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MotorParkourId
		{
			get
			{
				return this.motorParkourId_;
			}
			set
			{
				this.motorParkourId_ = value;
			}
		}

		// Token: 0x0600EBC5 RID: 60357 RVA: 0x00226B3C File Offset: 0x00224D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorParkourCtx);
		}

		// Token: 0x0600EBC6 RID: 60358 RVA: 0x00226B4A File Offset: 0x00224D4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorParkourCtx other)
		{
			return other != null && (other == this || (this.MotorParkourId == other.MotorParkourId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EBC7 RID: 60359 RVA: 0x00226B78 File Offset: 0x00224D78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MotorParkourId != 0)
			{
				num ^= this.MotorParkourId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600EBC8 RID: 60360 RVA: 0x00226BB7 File Offset: 0x00224DB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EBC9 RID: 60361 RVA: 0x00226BC4 File Offset: 0x00224DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EBCA RID: 60362 RVA: 0x00226BCD File Offset: 0x00224DCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MotorParkourId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.MotorParkourId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EBCB RID: 60363 RVA: 0x00226C00 File Offset: 0x00224E00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MotorParkourId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MotorParkourId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600EBCC RID: 60364 RVA: 0x00226C3E File Offset: 0x00224E3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorParkourCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MotorParkourId != 0)
			{
				this.MotorParkourId = other.MotorParkourId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600EBCD RID: 60365 RVA: 0x00226C6F File Offset: 0x00224E6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EBCE RID: 60366 RVA: 0x00226C78 File Offset: 0x00224E78
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.MotorParkourId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005FA4 RID: 24484
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005FA5 RID: 24485
		public const int MotorParkourIdFieldNumber = 1;

		// Token: 0x04005FA6 RID: 24486
		private int motorParkourId_;
	}
}
