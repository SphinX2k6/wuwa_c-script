using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Debug
{
	// Token: 0x02001696 RID: 5782
	[NetMessage(EMessageId.DebugFightErrInfoNotify)]
	public sealed class DebugFightErrInfoNotify : IMessage<DebugFightErrInfoNotify>, IMessage, IEquatable<DebugFightErrInfoNotify>, IDeepCloneable<DebugFightErrInfoNotify>, IBufferMessage
	{
		// Token: 0x0601CFB5 RID: 118709 RVA: 0x0043E331 File Offset: 0x0043C531
		[NullableContext(1)]
		public static DebugFightErrInfoNotify Create()
		{
			return new DebugFightErrInfoNotify();
		}

		// Token: 0x1700625A RID: 25178
		// (get) Token: 0x0601CFB6 RID: 118710 RVA: 0x0043E338 File Offset: 0x0043C538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700625B RID: 25179
		// (get) Token: 0x0601CFB7 RID: 118711 RVA: 0x0043E33B File Offset: 0x0043C53B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DebugFightErrInfoNotify.Descriptor;
			}
		}

		// Token: 0x0601CFB8 RID: 118712 RVA: 0x0043E342 File Offset: 0x0043C542
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DebugFightErrInfoNotify()
		{
		}

		// Token: 0x0601CFB9 RID: 118713 RVA: 0x0043E355 File Offset: 0x0043C555
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DebugFightErrInfoNotify(DebugFightErrInfoNotify other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.extraInfo_ = other.extraInfo_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CFBA RID: 118714 RVA: 0x0043E386 File Offset: 0x0043C586
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DebugFightErrInfoNotify Clone()
		{
			return new DebugFightErrInfoNotify(this);
		}

		// Token: 0x1700625C RID: 25180
		// (get) Token: 0x0601CFBB RID: 118715 RVA: 0x0043E38E File Offset: 0x0043C58E
		// (set) Token: 0x0601CFBC RID: 118716 RVA: 0x0043E396 File Offset: 0x0043C596
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

		// Token: 0x1700625D RID: 25181
		// (get) Token: 0x0601CFBD RID: 118717 RVA: 0x0043E39F File Offset: 0x0043C59F
		// (set) Token: 0x0601CFBE RID: 118718 RVA: 0x0043E3A7 File Offset: 0x0043C5A7
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

		// Token: 0x0601CFBF RID: 118719 RVA: 0x0043E3BA File Offset: 0x0043C5BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DebugFightErrInfoNotify);
		}

		// Token: 0x0601CFC0 RID: 118720 RVA: 0x0043E3C8 File Offset: 0x0043C5C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DebugFightErrInfoNotify other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && !(this.ExtraInfo != other.ExtraInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CFC1 RID: 118721 RVA: 0x0043E418 File Offset: 0x0043C618
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

		// Token: 0x0601CFC2 RID: 118722 RVA: 0x0043E478 File Offset: 0x0043C678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CFC3 RID: 118723 RVA: 0x0043E485 File Offset: 0x0043C685
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CFC4 RID: 118724 RVA: 0x0043E490 File Offset: 0x0043C690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ExtraInfo.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.ExtraInfo);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CFC5 RID: 118725 RVA: 0x0043E4F0 File Offset: 0x0043C6F0
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

		// Token: 0x0601CFC6 RID: 118726 RVA: 0x0043E54C File Offset: 0x0043C74C
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

		// Token: 0x0601CFC7 RID: 118727 RVA: 0x0043E5A1 File Offset: 0x0043C7A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CFC8 RID: 118728 RVA: 0x0043E5AC File Offset: 0x0043C7AC
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
				if (num != 10U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.ExtraInfo = input.ReadString();
				}
			}
		}

		// Token: 0x0400C3C0 RID: 50112
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C3C1 RID: 50113
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x0400C3C2 RID: 50114
		private ErrorCode errorCode_;

		// Token: 0x0400C3C3 RID: 50115
		public const int ExtraInfoFieldNumber = 1;

		// Token: 0x0400C3C4 RID: 50116
		private string extraInfo_ = "";
	}
}
