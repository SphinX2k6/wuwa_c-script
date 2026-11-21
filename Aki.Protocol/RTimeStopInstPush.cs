using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001171 RID: 4465
	[NetMessage(EMessageId.RTimeStopInstPush)]
	public sealed class RTimeStopInstPush : IMessage<RTimeStopInstPush>, IMessage, IEquatable<RTimeStopInstPush>, IDeepCloneable<RTimeStopInstPush>, IBufferMessage
	{
		// Token: 0x06017DB1 RID: 97713 RVA: 0x0037912D File Offset: 0x0037732D
		[NullableContext(1)]
		public static RTimeStopInstPush Create()
		{
			return new RTimeStopInstPush();
		}

		// Token: 0x1700504F RID: 20559
		// (get) Token: 0x06017DB2 RID: 97714 RVA: 0x00379134 File Offset: 0x00377334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005050 RID: 20560
		// (get) Token: 0x06017DB3 RID: 97715 RVA: 0x00379137 File Offset: 0x00377337
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RTimeStopInstPush.Descriptor;
			}
		}

		// Token: 0x06017DB4 RID: 97716 RVA: 0x0037913E File Offset: 0x0037733E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopInstPush()
		{
		}

		// Token: 0x06017DB5 RID: 97717 RVA: 0x00379146 File Offset: 0x00377346
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopInstPush(RTimeStopInstPush other) : this()
		{
			this.flag_ = other.flag_;
			this.duration_ = other.duration_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017DB6 RID: 97718 RVA: 0x00379177 File Offset: 0x00377377
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopInstPush Clone()
		{
			return new RTimeStopInstPush(this);
		}

		// Token: 0x17005051 RID: 20561
		// (get) Token: 0x06017DB7 RID: 97719 RVA: 0x0037917F File Offset: 0x0037737F
		// (set) Token: 0x06017DB8 RID: 97720 RVA: 0x00379187 File Offset: 0x00377387
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Flag
		{
			get
			{
				return this.flag_;
			}
			set
			{
				this.flag_ = value;
			}
		}

		// Token: 0x17005052 RID: 20562
		// (get) Token: 0x06017DB9 RID: 97721 RVA: 0x00379190 File Offset: 0x00377390
		// (set) Token: 0x06017DBA RID: 97722 RVA: 0x00379198 File Offset: 0x00377398
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

		// Token: 0x06017DBB RID: 97723 RVA: 0x003791A1 File Offset: 0x003773A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RTimeStopInstPush);
		}

		// Token: 0x06017DBC RID: 97724 RVA: 0x003791AF File Offset: 0x003773AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RTimeStopInstPush other)
		{
			return other != null && (other == this || (this.Flag == other.Flag && this.Duration == other.Duration && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017DBD RID: 97725 RVA: 0x003791F0 File Offset: 0x003773F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Flag)
			{
				num ^= this.Flag.GetHashCode();
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

		// Token: 0x06017DBE RID: 97726 RVA: 0x00379248 File Offset: 0x00377448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017DBF RID: 97727 RVA: 0x00379255 File Offset: 0x00377455
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017DC0 RID: 97728 RVA: 0x00379260 File Offset: 0x00377460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Duration != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Duration);
			}
			if (this.Flag)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.Flag);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017DC1 RID: 97729 RVA: 0x003792BC File Offset: 0x003774BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Flag)
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

		// Token: 0x06017DC2 RID: 97730 RVA: 0x00379308 File Offset: 0x00377508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RTimeStopInstPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Flag)
			{
				this.Flag = other.Flag;
			}
			if (other.Duration != 0)
			{
				this.Duration = other.Duration;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017DC3 RID: 97731 RVA: 0x00379358 File Offset: 0x00377558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017DC4 RID: 97732 RVA: 0x00379364 File Offset: 0x00377564
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
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Flag = input.ReadBool();
					}
				}
				else
				{
					this.Duration = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008E44 RID: 36420
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E45 RID: 36421
		public const int FlagFieldNumber = 9;

		// Token: 0x04008E46 RID: 36422
		private bool flag_;

		// Token: 0x04008E47 RID: 36423
		public const int DurationFieldNumber = 3;

		// Token: 0x04008E48 RID: 36424
		private int duration_;
	}
}
