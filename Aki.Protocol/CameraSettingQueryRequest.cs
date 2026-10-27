using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200022E RID: 558
	[NetMessage(EMessageId.CameraSettingQueryRequest)]
	public sealed class CameraSettingQueryRequest : IMessage<CameraSettingQueryRequest>, IMessage, IEquatable<CameraSettingQueryRequest>, IDeepCloneable<CameraSettingQueryRequest>, IBufferMessage
	{
		// Token: 0x06003C93 RID: 15507 RVA: 0x00096891 File Offset: 0x00094A91
		[NullableContext(1)]
		public static CameraSettingQueryRequest Create()
		{
			return new CameraSettingQueryRequest();
		}

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x06003C94 RID: 15508 RVA: 0x00096898 File Offset: 0x00094A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x06003C95 RID: 15509 RVA: 0x0009689B File Offset: 0x00094A9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CameraSettingQueryRequest.Descriptor;
			}
		}

		// Token: 0x06003C96 RID: 15510 RVA: 0x000968A2 File Offset: 0x00094AA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CameraSettingQueryRequest()
		{
		}

		// Token: 0x06003C97 RID: 15511 RVA: 0x000968AA File Offset: 0x00094AAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CameraSettingQueryRequest(CameraSettingQueryRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003C98 RID: 15512 RVA: 0x000968C3 File Offset: 0x00094AC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CameraSettingQueryRequest Clone()
		{
			return new CameraSettingQueryRequest(this);
		}

		// Token: 0x06003C99 RID: 15513 RVA: 0x000968CB File Offset: 0x00094ACB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CameraSettingQueryRequest);
		}

		// Token: 0x06003C9A RID: 15514 RVA: 0x000968D9 File Offset: 0x00094AD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CameraSettingQueryRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06003C9B RID: 15515 RVA: 0x000968F8 File Offset: 0x00094AF8
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

		// Token: 0x06003C9C RID: 15516 RVA: 0x0009691E File Offset: 0x00094B1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003C9D RID: 15517 RVA: 0x0009692B File Offset: 0x00094B2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003C9E RID: 15518 RVA: 0x00096934 File Offset: 0x00094B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003C9F RID: 15519 RVA: 0x0009694C File Offset: 0x00094B4C
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

		// Token: 0x06003CA0 RID: 15520 RVA: 0x00096972 File Offset: 0x00094B72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CameraSettingQueryRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003CA1 RID: 15521 RVA: 0x0009698F File Offset: 0x00094B8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003CA2 RID: 15522 RVA: 0x00096998 File Offset: 0x00094B98
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

		// Token: 0x04002C7D RID: 11389
		private UnknownFieldSet _unknownFields;
	}
}
