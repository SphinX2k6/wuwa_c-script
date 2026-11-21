using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200123E RID: 4670
	[NetMessage(EMessageId.ShortMessageInfoRequest)]
	public sealed class ShortMessageInfoRequest : IMessage<ShortMessageInfoRequest>, IMessage, IEquatable<ShortMessageInfoRequest>, IDeepCloneable<ShortMessageInfoRequest>, IBufferMessage
	{
		// Token: 0x06018F0E RID: 102158 RVA: 0x003A2C76 File Offset: 0x003A0E76
		[NullableContext(1)]
		public static ShortMessageInfoRequest Create()
		{
			return new ShortMessageInfoRequest();
		}

		// Token: 0x17005446 RID: 21574
		// (get) Token: 0x06018F0F RID: 102159 RVA: 0x003A2C7D File Offset: 0x003A0E7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005447 RID: 21575
		// (get) Token: 0x06018F10 RID: 102160 RVA: 0x003A2C80 File Offset: 0x003A0E80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShortMessageInfoRequest.Descriptor;
			}
		}

		// Token: 0x06018F11 RID: 102161 RVA: 0x003A2C87 File Offset: 0x003A0E87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageInfoRequest()
		{
		}

		// Token: 0x06018F12 RID: 102162 RVA: 0x003A2C8F File Offset: 0x003A0E8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageInfoRequest(ShortMessageInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018F13 RID: 102163 RVA: 0x003A2CA8 File Offset: 0x003A0EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageInfoRequest Clone()
		{
			return new ShortMessageInfoRequest(this);
		}

		// Token: 0x06018F14 RID: 102164 RVA: 0x003A2CB0 File Offset: 0x003A0EB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShortMessageInfoRequest);
		}

		// Token: 0x06018F15 RID: 102165 RVA: 0x003A2CBE File Offset: 0x003A0EBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShortMessageInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06018F16 RID: 102166 RVA: 0x003A2CDC File Offset: 0x003A0EDC
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

		// Token: 0x06018F17 RID: 102167 RVA: 0x003A2D02 File Offset: 0x003A0F02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018F18 RID: 102168 RVA: 0x003A2D0F File Offset: 0x003A0F0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018F19 RID: 102169 RVA: 0x003A2D18 File Offset: 0x003A0F18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018F1A RID: 102170 RVA: 0x003A2D30 File Offset: 0x003A0F30
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

		// Token: 0x06018F1B RID: 102171 RVA: 0x003A2D56 File Offset: 0x003A0F56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShortMessageInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018F1C RID: 102172 RVA: 0x003A2D73 File Offset: 0x003A0F73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018F1D RID: 102173 RVA: 0x003A2D7C File Offset: 0x003A0F7C
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

		// Token: 0x040093E8 RID: 37864
		private UnknownFieldSet _unknownFields;
	}
}
