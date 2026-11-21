using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Debug
{
	// Token: 0x02001712 RID: 5906
	[NetMessage(EMessageId.DebugFightErrInfoNotify)]
	public sealed class DebugFightErrInfoNotify : IMessage<DebugFightErrInfoNotify>, IMessage, IEquatable<DebugFightErrInfoNotify>, IDeepCloneable<DebugFightErrInfoNotify>, IBufferMessage
	{
		// Token: 0x0601DA84 RID: 121476 RVA: 0x0045A06D File Offset: 0x0045826D
		[NullableContext(1)]
		public static DebugFightErrInfoNotify Create()
		{
			return new DebugFightErrInfoNotify();
		}

		// Token: 0x170064FF RID: 25855
		// (get) Token: 0x0601DA85 RID: 121477 RVA: 0x0045A074 File Offset: 0x00458274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006500 RID: 25856
		// (get) Token: 0x0601DA86 RID: 121478 RVA: 0x0045A077 File Offset: 0x00458277
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DebugFightErrInfoNotify.Descriptor;
			}
		}

		// Token: 0x0601DA87 RID: 121479 RVA: 0x0045A07E File Offset: 0x0045827E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DebugFightErrInfoNotify()
		{
		}

		// Token: 0x0601DA88 RID: 121480 RVA: 0x0045A091 File Offset: 0x00458291
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DebugFightErrInfoNotify(DebugFightErrInfoNotify other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.extraInfo_ = other.extraInfo_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601DA89 RID: 121481 RVA: 0x0045A0C2 File Offset: 0x004582C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DebugFightErrInfoNotify Clone()
		{
			return new DebugFightErrInfoNotify(this);
		}

		// Token: 0x17006501 RID: 25857
		// (get) Token: 0x0601DA8A RID: 121482 RVA: 0x0045A0CA File Offset: 0x004582CA
		// (set) Token: 0x0601DA8B RID: 121483 RVA: 0x0045A0D2 File Offset: 0x004582D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17006502 RID: 25858
		// (get) Token: 0x0601DA8C RID: 121484 RVA: 0x0045A0DB File Offset: 0x004582DB
		// (set) Token: 0x0601DA8D RID: 121485 RVA: 0x0045A0E3 File Offset: 0x004582E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ExtraInfo
		{
			get
			{
				return this.extraInfo_;
			}
			set
			{
				this.extraInfo_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0601DA8E RID: 121486 RVA: 0x0045A0F6 File Offset: 0x004582F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DebugFightErrInfoNotify);
		}

		// Token: 0x0601DA8F RID: 121487 RVA: 0x0045A104 File Offset: 0x00458304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DebugFightErrInfoNotify other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && !(this.ExtraInfo != other.ExtraInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601DA90 RID: 121488 RVA: 0x0045A154 File Offset: 0x00458354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.ExtraInfo.Length != 0)
			{
				num ^= this.ExtraInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601DA91 RID: 121489 RVA: 0x0045A1B4 File Offset: 0x004583B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601DA92 RID: 121490 RVA: 0x0045A1C1 File Offset: 0x004583C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601DA93 RID: 121491 RVA: 0x0045A1CC File Offset: 0x004583CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.ExtraInfo.Length != 0)
			{
				output.WriteRawTag(82);
				output.WriteString(this.ExtraInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601DA94 RID: 121492 RVA: 0x0045A22C File Offset: 0x0045842C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.ExtraInfo.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ExtraInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601DA95 RID: 121493 RVA: 0x0045A288 File Offset: 0x00458488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DebugFightErrInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.ExtraInfo.Length != 0)
			{
				this.ExtraInfo = other.ExtraInfo;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601DA96 RID: 121494 RVA: 0x0045A2DD File Offset: 0x004584DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601DA97 RID: 121495 RVA: 0x0045A2E8 File Offset: 0x004584E8
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
				if (num != 64U)
				{
					if (num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ExtraInfo = input.ReadString();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400C8EF RID: 51439
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C8F0 RID: 51440
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x0400C8F1 RID: 51441
		private ErrorCode errorCode_;

		// Token: 0x0400C8F2 RID: 51442
		public const int ExtraInfoFieldNumber = 10;

		// Token: 0x0400C8F3 RID: 51443
		private string extraInfo_ = "";
	}
}
