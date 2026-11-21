using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000929 RID: 2345
	[NetMessage(EMessageId.LoadCalabashSkinInfoRequest)]
	public sealed class LoadCalabashSkinInfoRequest : IMessage<LoadCalabashSkinInfoRequest>, IMessage, IEquatable<LoadCalabashSkinInfoRequest>, IDeepCloneable<LoadCalabashSkinInfoRequest>, IBufferMessage
	{
		// Token: 0x0600CF0E RID: 53006 RVA: 0x001E80A7 File Offset: 0x001E62A7
		[NullableContext(1)]
		public static LoadCalabashSkinInfoRequest Create()
		{
			return new LoadCalabashSkinInfoRequest();
		}

		// Token: 0x170029D0 RID: 10704
		// (get) Token: 0x0600CF0F RID: 53007 RVA: 0x001E80AE File Offset: 0x001E62AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170029D1 RID: 10705
		// (get) Token: 0x0600CF10 RID: 53008 RVA: 0x001E80B1 File Offset: 0x001E62B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LoadCalabashSkinInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600CF11 RID: 53009 RVA: 0x001E80B8 File Offset: 0x001E62B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoadCalabashSkinInfoRequest()
		{
		}

		// Token: 0x0600CF12 RID: 53010 RVA: 0x001E80C0 File Offset: 0x001E62C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoadCalabashSkinInfoRequest(LoadCalabashSkinInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CF13 RID: 53011 RVA: 0x001E80D9 File Offset: 0x001E62D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoadCalabashSkinInfoRequest Clone()
		{
			return new LoadCalabashSkinInfoRequest(this);
		}

		// Token: 0x0600CF14 RID: 53012 RVA: 0x001E80E1 File Offset: 0x001E62E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LoadCalabashSkinInfoRequest);
		}

		// Token: 0x0600CF15 RID: 53013 RVA: 0x001E80EF File Offset: 0x001E62EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LoadCalabashSkinInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600CF16 RID: 53014 RVA: 0x001E8110 File Offset: 0x001E6310
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

		// Token: 0x0600CF17 RID: 53015 RVA: 0x001E8136 File Offset: 0x001E6336
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CF18 RID: 53016 RVA: 0x001E8143 File Offset: 0x001E6343
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CF19 RID: 53017 RVA: 0x001E814C File Offset: 0x001E634C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CF1A RID: 53018 RVA: 0x001E8164 File Offset: 0x001E6364
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

		// Token: 0x0600CF1B RID: 53019 RVA: 0x001E818A File Offset: 0x001E638A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LoadCalabashSkinInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CF1C RID: 53020 RVA: 0x001E81A7 File Offset: 0x001E63A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CF1D RID: 53021 RVA: 0x001E81B0 File Offset: 0x001E63B0
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

		// Token: 0x040057C1 RID: 22465
		private UnknownFieldSet _unknownFields;
	}
}
