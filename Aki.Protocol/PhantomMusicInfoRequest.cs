using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CD7 RID: 3287
	[NetMessage(EMessageId.PhantomMusicInfoRequest)]
	public sealed class PhantomMusicInfoRequest : IMessage<PhantomMusicInfoRequest>, IMessage, IEquatable<PhantomMusicInfoRequest>, IDeepCloneable<PhantomMusicInfoRequest>, IBufferMessage
	{
		// Token: 0x06011CED RID: 72941 RVA: 0x0029B875 File Offset: 0x00299A75
		[NullableContext(1)]
		public static PhantomMusicInfoRequest Create()
		{
			return new PhantomMusicInfoRequest();
		}

		// Token: 0x17003B04 RID: 15108
		// (get) Token: 0x06011CEE RID: 72942 RVA: 0x0029B87C File Offset: 0x00299A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B05 RID: 15109
		// (get) Token: 0x06011CEF RID: 72943 RVA: 0x0029B87F File Offset: 0x00299A7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomMusicInfoRequest.Descriptor;
			}
		}

		// Token: 0x06011CF0 RID: 72944 RVA: 0x0029B886 File Offset: 0x00299A86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicInfoRequest()
		{
		}

		// Token: 0x06011CF1 RID: 72945 RVA: 0x0029B88E File Offset: 0x00299A8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicInfoRequest(PhantomMusicInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011CF2 RID: 72946 RVA: 0x0029B8A7 File Offset: 0x00299AA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicInfoRequest Clone()
		{
			return new PhantomMusicInfoRequest(this);
		}

		// Token: 0x06011CF3 RID: 72947 RVA: 0x0029B8AF File Offset: 0x00299AAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomMusicInfoRequest);
		}

		// Token: 0x06011CF4 RID: 72948 RVA: 0x0029B8BD File Offset: 0x00299ABD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomMusicInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06011CF5 RID: 72949 RVA: 0x0029B8DC File Offset: 0x00299ADC
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

		// Token: 0x06011CF6 RID: 72950 RVA: 0x0029B902 File Offset: 0x00299B02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011CF7 RID: 72951 RVA: 0x0029B90F File Offset: 0x00299B0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011CF8 RID: 72952 RVA: 0x0029B918 File Offset: 0x00299B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011CF9 RID: 72953 RVA: 0x0029B930 File Offset: 0x00299B30
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

		// Token: 0x06011CFA RID: 72954 RVA: 0x0029B956 File Offset: 0x00299B56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomMusicInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011CFB RID: 72955 RVA: 0x0029B973 File Offset: 0x00299B73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011CFC RID: 72956 RVA: 0x0029B97C File Offset: 0x00299B7C
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

		// Token: 0x04007045 RID: 28741
		private UnknownFieldSet _unknownFields;
	}
}
