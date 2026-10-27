using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000676 RID: 1654
	[NetMessage(EMessageId.FuncOpenUpdateNotify)]
	public sealed class FuncOpenUpdateNotify : IMessage<FuncOpenUpdateNotify>, IMessage, IEquatable<FuncOpenUpdateNotify>, IDeepCloneable<FuncOpenUpdateNotify>, IBufferMessage
	{
		// Token: 0x060097A1 RID: 38817 RVA: 0x0016DB29 File Offset: 0x0016BD29
		[NullableContext(1)]
		public static FuncOpenUpdateNotify Create()
		{
			return new FuncOpenUpdateNotify();
		}

		// Token: 0x17001E36 RID: 7734
		// (get) Token: 0x060097A2 RID: 38818 RVA: 0x0016DB30 File Offset: 0x0016BD30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E37 RID: 7735
		// (get) Token: 0x060097A3 RID: 38819 RVA: 0x0016DB33 File Offset: 0x0016BD33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FuncOpenUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060097A4 RID: 38820 RVA: 0x0016DB3A File Offset: 0x0016BD3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FuncOpenUpdateNotify()
		{
		}

		// Token: 0x060097A5 RID: 38821 RVA: 0x0016DB4D File Offset: 0x0016BD4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FuncOpenUpdateNotify(FuncOpenUpdateNotify other) : this()
		{
			this.func_ = other.func_.Clone();
			this.silent_ = other.silent_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060097A6 RID: 38822 RVA: 0x0016DB83 File Offset: 0x0016BD83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FuncOpenUpdateNotify Clone()
		{
			return new FuncOpenUpdateNotify(this);
		}

		// Token: 0x17001E38 RID: 7736
		// (get) Token: 0x060097A7 RID: 38823 RVA: 0x0016DB8B File Offset: 0x0016BD8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Function> Func
		{
			get
			{
				return this.func_;
			}
		}

		// Token: 0x17001E39 RID: 7737
		// (get) Token: 0x060097A8 RID: 38824 RVA: 0x0016DB93 File Offset: 0x0016BD93
		// (set) Token: 0x060097A9 RID: 38825 RVA: 0x0016DB9B File Offset: 0x0016BD9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Silent
		{
			get
			{
				return this.silent_;
			}
			set
			{
				this.silent_ = value;
			}
		}

		// Token: 0x060097AA RID: 38826 RVA: 0x0016DBA4 File Offset: 0x0016BDA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FuncOpenUpdateNotify);
		}

		// Token: 0x060097AB RID: 38827 RVA: 0x0016DBB4 File Offset: 0x0016BDB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FuncOpenUpdateNotify other)
		{
			return other != null && (other == this || (this.func_.Equals(other.func_) && this.Silent == other.Silent && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060097AC RID: 38828 RVA: 0x0016DC04 File Offset: 0x0016BE04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.func_.GetHashCode();
			if (this.Silent)
			{
				num ^= this.Silent.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060097AD RID: 38829 RVA: 0x0016DC51 File Offset: 0x0016BE51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060097AE RID: 38830 RVA: 0x0016DC5E File Offset: 0x0016BE5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060097AF RID: 38831 RVA: 0x0016DC68 File Offset: 0x0016BE68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Silent)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.Silent);
			}
			this.func_.WriteTo(ref output, FuncOpenUpdateNotify._repeated_func_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060097B0 RID: 38832 RVA: 0x0016DCB8 File Offset: 0x0016BEB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.func_.CalculateSize(FuncOpenUpdateNotify._repeated_func_codec);
			if (this.Silent)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060097B1 RID: 38833 RVA: 0x0016DD00 File Offset: 0x0016BF00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FuncOpenUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.func_.Add(other.func_);
			if (other.Silent)
			{
				this.Silent = other.Silent;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060097B2 RID: 38834 RVA: 0x0016DD4D File Offset: 0x0016BF4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060097B3 RID: 38835 RVA: 0x0016DD58 File Offset: 0x0016BF58
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
				if (num != 80U)
				{
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.func_.AddEntriesFrom(ref input, FuncOpenUpdateNotify._repeated_func_codec);
					}
				}
				else
				{
					this.Silent = input.ReadBool();
				}
			}
		}

		// Token: 0x0400480C RID: 18444
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400480D RID: 18445
		public const int FuncFieldNumber = 13;

		// Token: 0x0400480E RID: 18446
		private static readonly FieldCodec<Function> _repeated_func_codec = FieldCodec.ForMessage<Function>(106U, Function.Parser);

		// Token: 0x0400480F RID: 18447
		private readonly RepeatedField<Function> func_ = new RepeatedField<Function>();

		// Token: 0x04004810 RID: 18448
		public const int SilentFieldNumber = 10;

		// Token: 0x04004811 RID: 18449
		private bool silent_;
	}
}
