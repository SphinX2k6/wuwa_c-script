using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007DE RID: 2014
	[NetMessage(EMessageId.InfrInfoRequest)]
	public sealed class InfrInfoRequest : IMessage<InfrInfoRequest>, IMessage, IEquatable<InfrInfoRequest>, IDeepCloneable<InfrInfoRequest>, IBufferMessage
	{
		// Token: 0x0600B4D6 RID: 46294 RVA: 0x001B034B File Offset: 0x001AE54B
		[NullableContext(1)]
		public static InfrInfoRequest Create()
		{
			return new InfrInfoRequest();
		}

		// Token: 0x17002479 RID: 9337
		// (get) Token: 0x0600B4D7 RID: 46295 RVA: 0x001B0352 File Offset: 0x001AE552
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700247A RID: 9338
		// (get) Token: 0x0600B4D8 RID: 46296 RVA: 0x001B0355 File Offset: 0x001AE555
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600B4D9 RID: 46297 RVA: 0x001B035C File Offset: 0x001AE55C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrInfoRequest()
		{
		}

		// Token: 0x0600B4DA RID: 46298 RVA: 0x001B0364 File Offset: 0x001AE564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrInfoRequest(InfrInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B4DB RID: 46299 RVA: 0x001B037D File Offset: 0x001AE57D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrInfoRequest Clone()
		{
			return new InfrInfoRequest(this);
		}

		// Token: 0x0600B4DC RID: 46300 RVA: 0x001B0385 File Offset: 0x001AE585
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrInfoRequest);
		}

		// Token: 0x0600B4DD RID: 46301 RVA: 0x001B0393 File Offset: 0x001AE593
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600B4DE RID: 46302 RVA: 0x001B03B4 File Offset: 0x001AE5B4
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

		// Token: 0x0600B4DF RID: 46303 RVA: 0x001B03DA File Offset: 0x001AE5DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B4E0 RID: 46304 RVA: 0x001B03E7 File Offset: 0x001AE5E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B4E1 RID: 46305 RVA: 0x001B03F0 File Offset: 0x001AE5F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B4E2 RID: 46306 RVA: 0x001B0408 File Offset: 0x001AE608
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

		// Token: 0x0600B4E3 RID: 46307 RVA: 0x001B042E File Offset: 0x001AE62E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B4E4 RID: 46308 RVA: 0x001B044B File Offset: 0x001AE64B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B4E5 RID: 46309 RVA: 0x001B0454 File Offset: 0x001AE654
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

		// Token: 0x04005063 RID: 20579
		private UnknownFieldSet _unknownFields;
	}
}
