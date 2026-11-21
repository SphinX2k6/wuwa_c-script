using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000382 RID: 898
	[NetMessage(EMessageId.DangoBrawlStartFightRequest)]
	public sealed class DangoBrawlStartFightRequest : IMessage<DangoBrawlStartFightRequest>, IMessage, IEquatable<DangoBrawlStartFightRequest>, IDeepCloneable<DangoBrawlStartFightRequest>, IBufferMessage
	{
		// Token: 0x0600593F RID: 22847 RVA: 0x000D9D5D File Offset: 0x000D7F5D
		[NullableContext(1)]
		public static DangoBrawlStartFightRequest Create()
		{
			return new DangoBrawlStartFightRequest();
		}

		// Token: 0x17001074 RID: 4212
		// (get) Token: 0x06005940 RID: 22848 RVA: 0x000D9D64 File Offset: 0x000D7F64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001075 RID: 4213
		// (get) Token: 0x06005941 RID: 22849 RVA: 0x000D9D67 File Offset: 0x000D7F67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlStartFightRequest.Descriptor;
			}
		}

		// Token: 0x06005942 RID: 22850 RVA: 0x000D9D6E File Offset: 0x000D7F6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlStartFightRequest()
		{
		}

		// Token: 0x06005943 RID: 22851 RVA: 0x000D9D76 File Offset: 0x000D7F76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlStartFightRequest(DangoBrawlStartFightRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005944 RID: 22852 RVA: 0x000D9D8F File Offset: 0x000D7F8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlStartFightRequest Clone()
		{
			return new DangoBrawlStartFightRequest(this);
		}

		// Token: 0x06005945 RID: 22853 RVA: 0x000D9D97 File Offset: 0x000D7F97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlStartFightRequest);
		}

		// Token: 0x06005946 RID: 22854 RVA: 0x000D9DA5 File Offset: 0x000D7FA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlStartFightRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06005947 RID: 22855 RVA: 0x000D9DC4 File Offset: 0x000D7FC4
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

		// Token: 0x06005948 RID: 22856 RVA: 0x000D9DEA File Offset: 0x000D7FEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005949 RID: 22857 RVA: 0x000D9DF7 File Offset: 0x000D7FF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600594A RID: 22858 RVA: 0x000D9E00 File Offset: 0x000D8000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600594B RID: 22859 RVA: 0x000D9E18 File Offset: 0x000D8018
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

		// Token: 0x0600594C RID: 22860 RVA: 0x000D9E3E File Offset: 0x000D803E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlStartFightRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600594D RID: 22861 RVA: 0x000D9E5B File Offset: 0x000D805B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600594E RID: 22862 RVA: 0x000D9E64 File Offset: 0x000D8064
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

		// Token: 0x040035AA RID: 13738
		private UnknownFieldSet _unknownFields;
	}
}
