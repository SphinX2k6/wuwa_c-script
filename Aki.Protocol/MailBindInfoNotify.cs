using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200096F RID: 2415
	[NetMessage(EMessageId.MailBindInfoNotify)]
	public sealed class MailBindInfoNotify : IMessage<MailBindInfoNotify>, IMessage, IEquatable<MailBindInfoNotify>, IDeepCloneable<MailBindInfoNotify>, IBufferMessage
	{
		// Token: 0x0600D4A4 RID: 54436 RVA: 0x001F4FFA File Offset: 0x001F31FA
		[NullableContext(1)]
		public static MailBindInfoNotify Create()
		{
			return new MailBindInfoNotify();
		}

		// Token: 0x17002B12 RID: 11026
		// (get) Token: 0x0600D4A5 RID: 54437 RVA: 0x001F5001 File Offset: 0x001F3201
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B13 RID: 11027
		// (get) Token: 0x0600D4A6 RID: 54438 RVA: 0x001F5004 File Offset: 0x001F3204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MailBindInfoNotify.Descriptor;
			}
		}

		// Token: 0x0600D4A7 RID: 54439 RVA: 0x001F500B File Offset: 0x001F320B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailBindInfoNotify()
		{
		}

		// Token: 0x0600D4A8 RID: 54440 RVA: 0x001F5013 File Offset: 0x001F3213
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailBindInfoNotify(MailBindInfoNotify other) : this()
		{
			this.mailBindInfo_ = ((other.mailBindInfo_ != null) ? other.mailBindInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D4A9 RID: 54441 RVA: 0x001F5048 File Offset: 0x001F3248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailBindInfoNotify Clone()
		{
			return new MailBindInfoNotify(this);
		}

		// Token: 0x17002B14 RID: 11028
		// (get) Token: 0x0600D4AA RID: 54442 RVA: 0x001F5050 File Offset: 0x001F3250
		// (set) Token: 0x0600D4AB RID: 54443 RVA: 0x001F5058 File Offset: 0x001F3258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailBindInfo MailBindInfo
		{
			get
			{
				return this.mailBindInfo_;
			}
			set
			{
				this.mailBindInfo_ = value;
			}
		}

		// Token: 0x0600D4AC RID: 54444 RVA: 0x001F5061 File Offset: 0x001F3261
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MailBindInfoNotify);
		}

		// Token: 0x0600D4AD RID: 54445 RVA: 0x001F506F File Offset: 0x001F326F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MailBindInfoNotify other)
		{
			return other != null && (other == this || (object.Equals(this.MailBindInfo, other.MailBindInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D4AE RID: 54446 RVA: 0x001F50A4 File Offset: 0x001F32A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.mailBindInfo_ != null)
			{
				num ^= this.MailBindInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D4AF RID: 54447 RVA: 0x001F50E0 File Offset: 0x001F32E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D4B0 RID: 54448 RVA: 0x001F50ED File Offset: 0x001F32ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D4B1 RID: 54449 RVA: 0x001F50F6 File Offset: 0x001F32F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.mailBindInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.MailBindInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D4B2 RID: 54450 RVA: 0x001F5128 File Offset: 0x001F3328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.mailBindInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MailBindInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D4B3 RID: 54451 RVA: 0x001F5168 File Offset: 0x001F3368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MailBindInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.mailBindInfo_ != null)
			{
				if (this.mailBindInfo_ == null)
				{
					this.MailBindInfo = new MailBindInfo();
				}
				this.MailBindInfo.MergeFrom(other.MailBindInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D4B4 RID: 54452 RVA: 0x001F51BC File Offset: 0x001F33BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D4B5 RID: 54453 RVA: 0x001F51C8 File Offset: 0x001F33C8
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
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.mailBindInfo_ == null)
					{
						this.MailBindInfo = new MailBindInfo();
					}
					input.ReadMessage(this.MailBindInfo);
				}
			}
		}

		// Token: 0x04005933 RID: 22835
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005934 RID: 22836
		public const int MailBindInfoFieldNumber = 4;

		// Token: 0x04005935 RID: 22837
		private MailBindInfo mailBindInfo_;
	}
}
