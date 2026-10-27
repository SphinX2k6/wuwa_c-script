using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Debug
{
	// Token: 0x0200169C RID: 5788
	[NetMessage(EMessageId.OutputDebugInfoNotify)]
	public sealed class OutputDebugInfoNotify : IMessage<OutputDebugInfoNotify>, IMessage, IEquatable<OutputDebugInfoNotify>, IDeepCloneable<OutputDebugInfoNotify>, IBufferMessage
	{
		// Token: 0x0601D02B RID: 118827 RVA: 0x0043F2C4 File Offset: 0x0043D4C4
		[NullableContext(1)]
		public static OutputDebugInfoNotify Create()
		{
			return new OutputDebugInfoNotify();
		}

		// Token: 0x17006271 RID: 25201
		// (get) Token: 0x0601D02C RID: 118828 RVA: 0x0043F2CB File Offset: 0x0043D4CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006272 RID: 25202
		// (get) Token: 0x0601D02D RID: 118829 RVA: 0x0043F2CE File Offset: 0x0043D4CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OutputDebugInfoNotify.Descriptor;
			}
		}

		// Token: 0x0601D02E RID: 118830 RVA: 0x0043F2D5 File Offset: 0x0043D4D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OutputDebugInfoNotify()
		{
		}

		// Token: 0x0601D02F RID: 118831 RVA: 0x0043F2DD File Offset: 0x0043D4DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OutputDebugInfoNotify(OutputDebugInfoNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D030 RID: 118832 RVA: 0x0043F2F6 File Offset: 0x0043D4F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OutputDebugInfoNotify Clone()
		{
			return new OutputDebugInfoNotify(this);
		}

		// Token: 0x0601D031 RID: 118833 RVA: 0x0043F2FE File Offset: 0x0043D4FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OutputDebugInfoNotify);
		}

		// Token: 0x0601D032 RID: 118834 RVA: 0x0043F30C File Offset: 0x0043D50C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OutputDebugInfoNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601D033 RID: 118835 RVA: 0x0043F32C File Offset: 0x0043D52C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D034 RID: 118836 RVA: 0x0043F352 File Offset: 0x0043D552
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D035 RID: 118837 RVA: 0x0043F35F File Offset: 0x0043D55F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D036 RID: 118838 RVA: 0x0043F368 File Offset: 0x0043D568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D037 RID: 118839 RVA: 0x0043F380 File Offset: 0x0043D580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D038 RID: 118840 RVA: 0x0043F3A6 File Offset: 0x0043D5A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OutputDebugInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D039 RID: 118841 RVA: 0x0043F3C3 File Offset: 0x0043D5C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D03A RID: 118842 RVA: 0x0043F3CC File Offset: 0x0043D5CC
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400C3DD RID: 50141
		private UnknownFieldSet _unknownFields;
	}
}
