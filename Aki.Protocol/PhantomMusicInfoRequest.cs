using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CE7 RID: 3303
	[NetMessage(EMessageId.PhantomMusicInfoRequest)]
	public sealed class PhantomMusicInfoRequest : IMessage<PhantomMusicInfoRequest>, IMessage, IEquatable<PhantomMusicInfoRequest>, IDeepCloneable<PhantomMusicInfoRequest>, IBufferMessage
	{
		// Token: 0x06011DE9 RID: 73193 RVA: 0x0029D489 File Offset: 0x0029B689
		[NullableContext(1)]
		public static PhantomMusicInfoRequest Create()
		{
			return new PhantomMusicInfoRequest();
		}

		// Token: 0x17003B39 RID: 15161
		// (get) Token: 0x06011DEA RID: 73194 RVA: 0x0029D490 File Offset: 0x0029B690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B3A RID: 15162
		// (get) Token: 0x06011DEB RID: 73195 RVA: 0x0029D493 File Offset: 0x0029B693
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomMusicInfoRequest.Descriptor;
			}
		}

		// Token: 0x06011DEC RID: 73196 RVA: 0x0029D49A File Offset: 0x0029B69A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicInfoRequest()
		{
		}

		// Token: 0x06011DED RID: 73197 RVA: 0x0029D4A2 File Offset: 0x0029B6A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicInfoRequest(PhantomMusicInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011DEE RID: 73198 RVA: 0x0029D4BB File Offset: 0x0029B6BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicInfoRequest Clone()
		{
			return new PhantomMusicInfoRequest(this);
		}

		// Token: 0x06011DEF RID: 73199 RVA: 0x0029D4C3 File Offset: 0x0029B6C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomMusicInfoRequest);
		}

		// Token: 0x06011DF0 RID: 73200 RVA: 0x0029D4D1 File Offset: 0x0029B6D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomMusicInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06011DF1 RID: 73201 RVA: 0x0029D4F0 File Offset: 0x0029B6F0
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

		// Token: 0x06011DF2 RID: 73202 RVA: 0x0029D516 File Offset: 0x0029B716
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011DF3 RID: 73203 RVA: 0x0029D523 File Offset: 0x0029B723
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011DF4 RID: 73204 RVA: 0x0029D52C File Offset: 0x0029B72C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011DF5 RID: 73205 RVA: 0x0029D544 File Offset: 0x0029B744
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

		// Token: 0x06011DF6 RID: 73206 RVA: 0x0029D56A File Offset: 0x0029B76A
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

		// Token: 0x06011DF7 RID: 73207 RVA: 0x0029D587 File Offset: 0x0029B787
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011DF8 RID: 73208 RVA: 0x0029D590 File Offset: 0x0029B790
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

		// Token: 0x0400702D RID: 28717
		private UnknownFieldSet _unknownFields;
	}
}
