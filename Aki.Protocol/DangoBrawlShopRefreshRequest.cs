using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000374 RID: 884
	[NetMessage(EMessageId.DangoBrawlShopRefreshRequest)]
	public sealed class DangoBrawlShopRefreshRequest : IMessage<DangoBrawlShopRefreshRequest>, IMessage, IEquatable<DangoBrawlShopRefreshRequest>, IDeepCloneable<DangoBrawlShopRefreshRequest>, IBufferMessage
	{
		// Token: 0x060057DC RID: 22492 RVA: 0x000D67E5 File Offset: 0x000D49E5
		[NullableContext(1)]
		public static DangoBrawlShopRefreshRequest Create()
		{
			return new DangoBrawlShopRefreshRequest();
		}

		// Token: 0x1700102C RID: 4140
		// (get) Token: 0x060057DD RID: 22493 RVA: 0x000D67EC File Offset: 0x000D49EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700102D RID: 4141
		// (get) Token: 0x060057DE RID: 22494 RVA: 0x000D67EF File Offset: 0x000D49EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlShopRefreshRequest.Descriptor;
			}
		}

		// Token: 0x060057DF RID: 22495 RVA: 0x000D67F6 File Offset: 0x000D49F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopRefreshRequest()
		{
		}

		// Token: 0x060057E0 RID: 22496 RVA: 0x000D67FE File Offset: 0x000D49FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopRefreshRequest(DangoBrawlShopRefreshRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060057E1 RID: 22497 RVA: 0x000D6817 File Offset: 0x000D4A17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopRefreshRequest Clone()
		{
			return new DangoBrawlShopRefreshRequest(this);
		}

		// Token: 0x060057E2 RID: 22498 RVA: 0x000D681F File Offset: 0x000D4A1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlShopRefreshRequest);
		}

		// Token: 0x060057E3 RID: 22499 RVA: 0x000D682D File Offset: 0x000D4A2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlShopRefreshRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060057E4 RID: 22500 RVA: 0x000D684C File Offset: 0x000D4A4C
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

		// Token: 0x060057E5 RID: 22501 RVA: 0x000D6872 File Offset: 0x000D4A72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060057E6 RID: 22502 RVA: 0x000D687F File Offset: 0x000D4A7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060057E7 RID: 22503 RVA: 0x000D6888 File Offset: 0x000D4A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060057E8 RID: 22504 RVA: 0x000D68A0 File Offset: 0x000D4AA0
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

		// Token: 0x060057E9 RID: 22505 RVA: 0x000D68C6 File Offset: 0x000D4AC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlShopRefreshRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060057EA RID: 22506 RVA: 0x000D68E3 File Offset: 0x000D4AE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060057EB RID: 22507 RVA: 0x000D68EC File Offset: 0x000D4AEC
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

		// Token: 0x040034F1 RID: 13553
		private UnknownFieldSet _unknownFields;
	}
}
