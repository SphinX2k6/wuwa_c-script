using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003FB RID: 1019
	[NetMessage(EMessageId.DollSmallMapInfoRequest)]
	public sealed class DollSmallMapInfoRequest : IMessage<DollSmallMapInfoRequest>, IMessage, IEquatable<DollSmallMapInfoRequest>, IDeepCloneable<DollSmallMapInfoRequest>, IBufferMessage
	{
		// Token: 0x06006283 RID: 25219 RVA: 0x000ED3A4 File Offset: 0x000EB5A4
		[NullableContext(1)]
		public static DollSmallMapInfoRequest Create()
		{
			return new DollSmallMapInfoRequest();
		}

		// Token: 0x1700125D RID: 4701
		// (get) Token: 0x06006284 RID: 25220 RVA: 0x000ED3AB File Offset: 0x000EB5AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700125E RID: 4702
		// (get) Token: 0x06006285 RID: 25221 RVA: 0x000ED3AE File Offset: 0x000EB5AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DollSmallMapInfoRequest.Descriptor;
			}
		}

		// Token: 0x06006286 RID: 25222 RVA: 0x000ED3B5 File Offset: 0x000EB5B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollSmallMapInfoRequest()
		{
		}

		// Token: 0x06006287 RID: 25223 RVA: 0x000ED3BD File Offset: 0x000EB5BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollSmallMapInfoRequest(DollSmallMapInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006288 RID: 25224 RVA: 0x000ED3D6 File Offset: 0x000EB5D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollSmallMapInfoRequest Clone()
		{
			return new DollSmallMapInfoRequest(this);
		}

		// Token: 0x06006289 RID: 25225 RVA: 0x000ED3DE File Offset: 0x000EB5DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DollSmallMapInfoRequest);
		}

		// Token: 0x0600628A RID: 25226 RVA: 0x000ED3EC File Offset: 0x000EB5EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DollSmallMapInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600628B RID: 25227 RVA: 0x000ED40C File Offset: 0x000EB60C
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

		// Token: 0x0600628C RID: 25228 RVA: 0x000ED432 File Offset: 0x000EB632
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600628D RID: 25229 RVA: 0x000ED43F File Offset: 0x000EB63F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600628E RID: 25230 RVA: 0x000ED448 File Offset: 0x000EB648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600628F RID: 25231 RVA: 0x000ED460 File Offset: 0x000EB660
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

		// Token: 0x06006290 RID: 25232 RVA: 0x000ED486 File Offset: 0x000EB686
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DollSmallMapInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006291 RID: 25233 RVA: 0x000ED4A3 File Offset: 0x000EB6A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006292 RID: 25234 RVA: 0x000ED4AC File Offset: 0x000EB6AC
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

		// Token: 0x040037E0 RID: 14304
		private UnknownFieldSet _unknownFields;
	}
}
