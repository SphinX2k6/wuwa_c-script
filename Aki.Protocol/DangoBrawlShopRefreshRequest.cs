using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200037C RID: 892
	[NetMessage(EMessageId.DangoBrawlShopRefreshRequest)]
	public sealed class DangoBrawlShopRefreshRequest : IMessage<DangoBrawlShopRefreshRequest>, IMessage, IEquatable<DangoBrawlShopRefreshRequest>, IDeepCloneable<DangoBrawlShopRefreshRequest>, IBufferMessage
	{
		// Token: 0x060058C9 RID: 22729 RVA: 0x000D8E6D File Offset: 0x000D706D
		[NullableContext(1)]
		public static DangoBrawlShopRefreshRequest Create()
		{
			return new DangoBrawlShopRefreshRequest();
		}

		// Token: 0x1700105D RID: 4189
		// (get) Token: 0x060058CA RID: 22730 RVA: 0x000D8E74 File Offset: 0x000D7074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700105E RID: 4190
		// (get) Token: 0x060058CB RID: 22731 RVA: 0x000D8E77 File Offset: 0x000D7077
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlShopRefreshRequest.Descriptor;
			}
		}

		// Token: 0x060058CC RID: 22732 RVA: 0x000D8E7E File Offset: 0x000D707E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopRefreshRequest()
		{
		}

		// Token: 0x060058CD RID: 22733 RVA: 0x000D8E86 File Offset: 0x000D7086
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopRefreshRequest(DangoBrawlShopRefreshRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060058CE RID: 22734 RVA: 0x000D8E9F File Offset: 0x000D709F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopRefreshRequest Clone()
		{
			return new DangoBrawlShopRefreshRequest(this);
		}

		// Token: 0x060058CF RID: 22735 RVA: 0x000D8EA7 File Offset: 0x000D70A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlShopRefreshRequest);
		}

		// Token: 0x060058D0 RID: 22736 RVA: 0x000D8EB5 File Offset: 0x000D70B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlShopRefreshRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060058D1 RID: 22737 RVA: 0x000D8ED4 File Offset: 0x000D70D4
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

		// Token: 0x060058D2 RID: 22738 RVA: 0x000D8EFA File Offset: 0x000D70FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060058D3 RID: 22739 RVA: 0x000D8F07 File Offset: 0x000D7107
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060058D4 RID: 22740 RVA: 0x000D8F10 File Offset: 0x000D7110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060058D5 RID: 22741 RVA: 0x000D8F28 File Offset: 0x000D7128
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

		// Token: 0x060058D6 RID: 22742 RVA: 0x000D8F4E File Offset: 0x000D714E
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

		// Token: 0x060058D7 RID: 22743 RVA: 0x000D8F6B File Offset: 0x000D716B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060058D8 RID: 22744 RVA: 0x000D8F74 File Offset: 0x000D7174
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

		// Token: 0x0400358D RID: 13709
		private UnknownFieldSet _unknownFields;
	}
}
