using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001317 RID: 4887
	[NetMessage(EMessageId.SysErrorNotify)]
	public sealed class SysErrorNotify : IMessage<SysErrorNotify>, IMessage, IEquatable<SysErrorNotify>, IDeepCloneable<SysErrorNotify>, IBufferMessage
	{
		// Token: 0x06019F91 RID: 106385 RVA: 0x003C6126 File Offset: 0x003C4326
		[NullableContext(1)]
		public static SysErrorNotify Create()
		{
			return new SysErrorNotify();
		}

		// Token: 0x17005798 RID: 22424
		// (get) Token: 0x06019F92 RID: 106386 RVA: 0x003C612D File Offset: 0x003C432D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005799 RID: 22425
		// (get) Token: 0x06019F93 RID: 106387 RVA: 0x003C6130 File Offset: 0x003C4330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SysErrorNotify.Descriptor;
			}
		}

		// Token: 0x06019F94 RID: 106388 RVA: 0x003C6137 File Offset: 0x003C4337
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SysErrorNotify()
		{
		}

		// Token: 0x06019F95 RID: 106389 RVA: 0x003C614A File Offset: 0x003C434A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SysErrorNotify(SysErrorNotify other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.errorParams_ = other.errorParams_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019F96 RID: 106390 RVA: 0x003C6180 File Offset: 0x003C4380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SysErrorNotify Clone()
		{
			return new SysErrorNotify(this);
		}

		// Token: 0x1700579A RID: 22426
		// (get) Token: 0x06019F97 RID: 106391 RVA: 0x003C6188 File Offset: 0x003C4388
		// (set) Token: 0x06019F98 RID: 106392 RVA: 0x003C6190 File Offset: 0x003C4390
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

		// Token: 0x1700579B RID: 22427
		// (get) Token: 0x06019F99 RID: 106393 RVA: 0x003C6199 File Offset: 0x003C4399
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> ErrorParams
		{
			get
			{
				return this.errorParams_;
			}
		}

		// Token: 0x06019F9A RID: 106394 RVA: 0x003C61A1 File Offset: 0x003C43A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SysErrorNotify);
		}

		// Token: 0x06019F9B RID: 106395 RVA: 0x003C61B0 File Offset: 0x003C43B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SysErrorNotify other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.errorParams_.Equals(other.errorParams_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019F9C RID: 106396 RVA: 0x003C6200 File Offset: 0x003C4400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.errorParams_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019F9D RID: 106397 RVA: 0x003C6253 File Offset: 0x003C4453
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019F9E RID: 106398 RVA: 0x003C6260 File Offset: 0x003C4460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019F9F RID: 106399 RVA: 0x003C626C File Offset: 0x003C446C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.errorParams_.WriteTo(ref output, SysErrorNotify._repeated_errorParams_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019FA0 RID: 106400 RVA: 0x003C62BC File Offset: 0x003C44BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.errorParams_.CalculateSize(SysErrorNotify._repeated_errorParams_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019FA1 RID: 106401 RVA: 0x003C6310 File Offset: 0x003C4510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SysErrorNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.errorParams_.Add(other.errorParams_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019FA2 RID: 106402 RVA: 0x003C635D File Offset: 0x003C455D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019FA3 RID: 106403 RVA: 0x003C6368 File Offset: 0x003C4568
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
				if (num != 88U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.errorParams_.AddEntriesFrom(ref input, SysErrorNotify._repeated_errorParams_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040097C5 RID: 38853
		private UnknownFieldSet _unknownFields;

		// Token: 0x040097C6 RID: 38854
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x040097C7 RID: 38855
		private ErrorCode errorCode_;

		// Token: 0x040097C8 RID: 38856
		public const int ErrorParamsFieldNumber = 15;

		// Token: 0x040097C9 RID: 38857
		private static readonly FieldCodec<string> _repeated_errorParams_codec = FieldCodec.ForString(122U);

		// Token: 0x040097CA RID: 38858
		private readonly RepeatedField<string> errorParams_ = new RepeatedField<string>();
	}
}
