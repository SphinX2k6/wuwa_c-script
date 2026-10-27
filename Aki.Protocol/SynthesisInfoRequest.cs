using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200130C RID: 4876
	[NetMessage(EMessageId.SynthesisInfoRequest)]
	public sealed class SynthesisInfoRequest : IMessage<SynthesisInfoRequest>, IMessage, IEquatable<SynthesisInfoRequest>, IDeepCloneable<SynthesisInfoRequest>, IBufferMessage
	{
		// Token: 0x06019EA2 RID: 106146 RVA: 0x003C3D00 File Offset: 0x003C1F00
		[NullableContext(1)]
		public static SynthesisInfoRequest Create()
		{
			return new SynthesisInfoRequest();
		}

		// Token: 0x17005761 RID: 22369
		// (get) Token: 0x06019EA3 RID: 106147 RVA: 0x003C3D07 File Offset: 0x003C1F07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005762 RID: 22370
		// (get) Token: 0x06019EA4 RID: 106148 RVA: 0x003C3D0A File Offset: 0x003C1F0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SynthesisInfoRequest.Descriptor;
			}
		}

		// Token: 0x06019EA5 RID: 106149 RVA: 0x003C3D11 File Offset: 0x003C1F11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisInfoRequest()
		{
		}

		// Token: 0x06019EA6 RID: 106150 RVA: 0x003C3D19 File Offset: 0x003C1F19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisInfoRequest(SynthesisInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019EA7 RID: 106151 RVA: 0x003C3D32 File Offset: 0x003C1F32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisInfoRequest Clone()
		{
			return new SynthesisInfoRequest(this);
		}

		// Token: 0x06019EA8 RID: 106152 RVA: 0x003C3D3A File Offset: 0x003C1F3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SynthesisInfoRequest);
		}

		// Token: 0x06019EA9 RID: 106153 RVA: 0x003C3D48 File Offset: 0x003C1F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SynthesisInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06019EAA RID: 106154 RVA: 0x003C3D68 File Offset: 0x003C1F68
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

		// Token: 0x06019EAB RID: 106155 RVA: 0x003C3D8E File Offset: 0x003C1F8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019EAC RID: 106156 RVA: 0x003C3D9B File Offset: 0x003C1F9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019EAD RID: 106157 RVA: 0x003C3DA4 File Offset: 0x003C1FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019EAE RID: 106158 RVA: 0x003C3DBC File Offset: 0x003C1FBC
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

		// Token: 0x06019EAF RID: 106159 RVA: 0x003C3DE2 File Offset: 0x003C1FE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SynthesisInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019EB0 RID: 106160 RVA: 0x003C3DFF File Offset: 0x003C1FFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019EB1 RID: 106161 RVA: 0x003C3E08 File Offset: 0x003C2008
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

		// Token: 0x04009772 RID: 38770
		private UnknownFieldSet _unknownFields;
	}
}
