using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000660 RID: 1632
	[NetMessage(EMessageId.FuncOpenConfirmNotify)]
	public sealed class FuncOpenConfirmNotify : IMessage<FuncOpenConfirmNotify>, IMessage, IEquatable<FuncOpenConfirmNotify>, IDeepCloneable<FuncOpenConfirmNotify>, IBufferMessage
	{
		// Token: 0x06009627 RID: 38439 RVA: 0x0016AD0E File Offset: 0x00168F0E
		[NullableContext(1)]
		public static FuncOpenConfirmNotify Create()
		{
			return new FuncOpenConfirmNotify();
		}

		// Token: 0x17001DE6 RID: 7654
		// (get) Token: 0x06009628 RID: 38440 RVA: 0x0016AD15 File Offset: 0x00168F15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001DE7 RID: 7655
		// (get) Token: 0x06009629 RID: 38441 RVA: 0x0016AD18 File Offset: 0x00168F18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FuncOpenConfirmNotify.Descriptor;
			}
		}

		// Token: 0x0600962A RID: 38442 RVA: 0x0016AD1F File Offset: 0x00168F1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FuncOpenConfirmNotify()
		{
		}

		// Token: 0x0600962B RID: 38443 RVA: 0x0016AD32 File Offset: 0x00168F32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FuncOpenConfirmNotify(FuncOpenConfirmNotify other) : this()
		{
			this.funcInfo_ = other.funcInfo_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600962C RID: 38444 RVA: 0x0016AD57 File Offset: 0x00168F57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FuncOpenConfirmNotify Clone()
		{
			return new FuncOpenConfirmNotify(this);
		}

		// Token: 0x17001DE8 RID: 7656
		// (get) Token: 0x0600962D RID: 38445 RVA: 0x0016AD5F File Offset: 0x00168F5F
		// (set) Token: 0x0600962E RID: 38446 RVA: 0x0016AD67 File Offset: 0x00168F67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ByteString FuncInfo
		{
			get
			{
				return this.funcInfo_;
			}
			set
			{
				this.funcInfo_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x0600962F RID: 38447 RVA: 0x0016AD7A File Offset: 0x00168F7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FuncOpenConfirmNotify);
		}

		// Token: 0x06009630 RID: 38448 RVA: 0x0016AD88 File Offset: 0x00168F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FuncOpenConfirmNotify other)
		{
			return other != null && (other == this || (!(this.FuncInfo != other.FuncInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009631 RID: 38449 RVA: 0x0016ADBC File Offset: 0x00168FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FuncInfo.Length != 0)
			{
				num ^= this.FuncInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009632 RID: 38450 RVA: 0x0016ADFD File Offset: 0x00168FFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009633 RID: 38451 RVA: 0x0016AE0A File Offset: 0x0016900A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009634 RID: 38452 RVA: 0x0016AE13 File Offset: 0x00169013
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FuncInfo.Length != 0)
			{
				output.WriteRawTag(74);
				output.WriteBytes(this.FuncInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009635 RID: 38453 RVA: 0x0016AE4C File Offset: 0x0016904C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FuncInfo.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.FuncInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009636 RID: 38454 RVA: 0x0016AE8F File Offset: 0x0016908F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FuncOpenConfirmNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FuncInfo.Length != 0)
			{
				this.FuncInfo = other.FuncInfo;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009637 RID: 38455 RVA: 0x0016AEC5 File Offset: 0x001690C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009638 RID: 38456 RVA: 0x0016AED0 File Offset: 0x001690D0
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
				if (num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.FuncInfo = input.ReadBytes();
				}
			}
		}

		// Token: 0x040047FE RID: 18430
		private UnknownFieldSet _unknownFields;

		// Token: 0x040047FF RID: 18431
		public const int FuncInfoFieldNumber = 9;

		// Token: 0x04004800 RID: 18432
		private ByteString funcInfo_ = ByteString.Empty;
	}
}
