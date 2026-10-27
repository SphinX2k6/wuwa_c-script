using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007FA RID: 2042
	[NetMessage(EMessageId.InfrV2InfoRequest)]
	public sealed class InfrV2InfoRequest : IMessage<InfrV2InfoRequest>, IMessage, IEquatable<InfrV2InfoRequest>, IDeepCloneable<InfrV2InfoRequest>, IBufferMessage
	{
		// Token: 0x0600B6F6 RID: 46838 RVA: 0x001B4844 File Offset: 0x001B2A44
		[NullableContext(1)]
		public static InfrV2InfoRequest Create()
		{
			return new InfrV2InfoRequest();
		}

		// Token: 0x170024E3 RID: 9443
		// (get) Token: 0x0600B6F7 RID: 46839 RVA: 0x001B484B File Offset: 0x001B2A4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170024E4 RID: 9444
		// (get) Token: 0x0600B6F8 RID: 46840 RVA: 0x001B484E File Offset: 0x001B2A4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrV2InfoRequest.Descriptor;
			}
		}

		// Token: 0x0600B6F9 RID: 46841 RVA: 0x001B4855 File Offset: 0x001B2A55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2InfoRequest()
		{
		}

		// Token: 0x0600B6FA RID: 46842 RVA: 0x001B485D File Offset: 0x001B2A5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2InfoRequest(InfrV2InfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B6FB RID: 46843 RVA: 0x001B4876 File Offset: 0x001B2A76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2InfoRequest Clone()
		{
			return new InfrV2InfoRequest(this);
		}

		// Token: 0x0600B6FC RID: 46844 RVA: 0x001B487E File Offset: 0x001B2A7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrV2InfoRequest);
		}

		// Token: 0x0600B6FD RID: 46845 RVA: 0x001B488C File Offset: 0x001B2A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrV2InfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600B6FE RID: 46846 RVA: 0x001B48AC File Offset: 0x001B2AAC
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

		// Token: 0x0600B6FF RID: 46847 RVA: 0x001B48D2 File Offset: 0x001B2AD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B700 RID: 46848 RVA: 0x001B48DF File Offset: 0x001B2ADF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B701 RID: 46849 RVA: 0x001B48E8 File Offset: 0x001B2AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B702 RID: 46850 RVA: 0x001B4900 File Offset: 0x001B2B00
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

		// Token: 0x0600B703 RID: 46851 RVA: 0x001B4926 File Offset: 0x001B2B26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrV2InfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B704 RID: 46852 RVA: 0x001B4943 File Offset: 0x001B2B43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B705 RID: 46853 RVA: 0x001B494C File Offset: 0x001B2B4C
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

		// Token: 0x040050E9 RID: 20713
		private UnknownFieldSet _unknownFields;
	}
}
