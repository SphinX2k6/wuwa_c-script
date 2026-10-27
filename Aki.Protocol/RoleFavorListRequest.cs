using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001074 RID: 4212
	[NetMessage(EMessageId.RoleFavorListRequest)]
	public sealed class RoleFavorListRequest : IMessage<RoleFavorListRequest>, IMessage, IEquatable<RoleFavorListRequest>, IDeepCloneable<RoleFavorListRequest>, IBufferMessage
	{
		// Token: 0x0601681C RID: 92188 RVA: 0x00345A8C File Offset: 0x00343C8C
		[NullableContext(1)]
		public static RoleFavorListRequest Create()
		{
			return new RoleFavorListRequest();
		}

		// Token: 0x17004B5C RID: 19292
		// (get) Token: 0x0601681D RID: 92189 RVA: 0x00345A93 File Offset: 0x00343C93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B5D RID: 19293
		// (get) Token: 0x0601681E RID: 92190 RVA: 0x00345A96 File Offset: 0x00343C96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleFavorListRequest.Descriptor;
			}
		}

		// Token: 0x0601681F RID: 92191 RVA: 0x00345A9D File Offset: 0x00343C9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorListRequest()
		{
		}

		// Token: 0x06016820 RID: 92192 RVA: 0x00345AA5 File Offset: 0x00343CA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorListRequest(RoleFavorListRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016821 RID: 92193 RVA: 0x00345ABE File Offset: 0x00343CBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorListRequest Clone()
		{
			return new RoleFavorListRequest(this);
		}

		// Token: 0x06016822 RID: 92194 RVA: 0x00345AC6 File Offset: 0x00343CC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleFavorListRequest);
		}

		// Token: 0x06016823 RID: 92195 RVA: 0x00345AD4 File Offset: 0x00343CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleFavorListRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06016824 RID: 92196 RVA: 0x00345AF4 File Offset: 0x00343CF4
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

		// Token: 0x06016825 RID: 92197 RVA: 0x00345B1A File Offset: 0x00343D1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016826 RID: 92198 RVA: 0x00345B27 File Offset: 0x00343D27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016827 RID: 92199 RVA: 0x00345B30 File Offset: 0x00343D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016828 RID: 92200 RVA: 0x00345B48 File Offset: 0x00343D48
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

		// Token: 0x06016829 RID: 92201 RVA: 0x00345B6E File Offset: 0x00343D6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleFavorListRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601682A RID: 92202 RVA: 0x00345B8B File Offset: 0x00343D8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601682B RID: 92203 RVA: 0x00345B94 File Offset: 0x00343D94
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

		// Token: 0x0400869B RID: 34459
		private UnknownFieldSet _unknownFields;
	}
}
