using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001303 RID: 4867
	[NetMessage(EMessageId.SwitchNodeNotify)]
	public sealed class SwitchNodeNotify : IMessage<SwitchNodeNotify>, IMessage, IEquatable<SwitchNodeNotify>, IDeepCloneable<SwitchNodeNotify>, IBufferMessage
	{
		// Token: 0x06019DEC RID: 105964 RVA: 0x003C2459 File Offset: 0x003C0659
		[NullableContext(1)]
		public static SwitchNodeNotify Create()
		{
			return new SwitchNodeNotify();
		}

		// Token: 0x1700573C RID: 22332
		// (get) Token: 0x06019DED RID: 105965 RVA: 0x003C2460 File Offset: 0x003C0660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700573D RID: 22333
		// (get) Token: 0x06019DEE RID: 105966 RVA: 0x003C2463 File Offset: 0x003C0663
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwitchNodeNotify.Descriptor;
			}
		}

		// Token: 0x06019DEF RID: 105967 RVA: 0x003C246A File Offset: 0x003C066A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchNodeNotify()
		{
		}

		// Token: 0x06019DF0 RID: 105968 RVA: 0x003C2472 File Offset: 0x003C0672
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchNodeNotify(SwitchNodeNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019DF1 RID: 105969 RVA: 0x003C248B File Offset: 0x003C068B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchNodeNotify Clone()
		{
			return new SwitchNodeNotify(this);
		}

		// Token: 0x06019DF2 RID: 105970 RVA: 0x003C2493 File Offset: 0x003C0693
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwitchNodeNotify);
		}

		// Token: 0x06019DF3 RID: 105971 RVA: 0x003C24A1 File Offset: 0x003C06A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwitchNodeNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06019DF4 RID: 105972 RVA: 0x003C24C0 File Offset: 0x003C06C0
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

		// Token: 0x06019DF5 RID: 105973 RVA: 0x003C24E6 File Offset: 0x003C06E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019DF6 RID: 105974 RVA: 0x003C24F3 File Offset: 0x003C06F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019DF7 RID: 105975 RVA: 0x003C24FC File Offset: 0x003C06FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019DF8 RID: 105976 RVA: 0x003C2514 File Offset: 0x003C0714
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

		// Token: 0x06019DF9 RID: 105977 RVA: 0x003C253A File Offset: 0x003C073A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwitchNodeNotify other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019DFA RID: 105978 RVA: 0x003C2557 File Offset: 0x003C0757
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019DFB RID: 105979 RVA: 0x003C2560 File Offset: 0x003C0760
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

		// Token: 0x04009742 RID: 38722
		private UnknownFieldSet _unknownFields;
	}
}
