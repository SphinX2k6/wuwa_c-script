using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003E4 RID: 996
	[NetMessage(EMessageId.DollSmallMapInfoRequest)]
	public sealed class DollSmallMapInfoRequest : IMessage<DollSmallMapInfoRequest>, IMessage, IEquatable<DollSmallMapInfoRequest>, IDeepCloneable<DollSmallMapInfoRequest>, IBufferMessage
	{
		// Token: 0x060060F3 RID: 24819 RVA: 0x000EA22C File Offset: 0x000E842C
		[NullableContext(1)]
		public static DollSmallMapInfoRequest Create()
		{
			return new DollSmallMapInfoRequest();
		}

		// Token: 0x17001208 RID: 4616
		// (get) Token: 0x060060F4 RID: 24820 RVA: 0x000EA233 File Offset: 0x000E8433
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001209 RID: 4617
		// (get) Token: 0x060060F5 RID: 24821 RVA: 0x000EA236 File Offset: 0x000E8436
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DollSmallMapInfoRequest.Descriptor;
			}
		}

		// Token: 0x060060F6 RID: 24822 RVA: 0x000EA23D File Offset: 0x000E843D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollSmallMapInfoRequest()
		{
		}

		// Token: 0x060060F7 RID: 24823 RVA: 0x000EA245 File Offset: 0x000E8445
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollSmallMapInfoRequest(DollSmallMapInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060060F8 RID: 24824 RVA: 0x000EA25E File Offset: 0x000E845E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollSmallMapInfoRequest Clone()
		{
			return new DollSmallMapInfoRequest(this);
		}

		// Token: 0x060060F9 RID: 24825 RVA: 0x000EA266 File Offset: 0x000E8466
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DollSmallMapInfoRequest);
		}

		// Token: 0x060060FA RID: 24826 RVA: 0x000EA274 File Offset: 0x000E8474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DollSmallMapInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060060FB RID: 24827 RVA: 0x000EA294 File Offset: 0x000E8494
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

		// Token: 0x060060FC RID: 24828 RVA: 0x000EA2BA File Offset: 0x000E84BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060060FD RID: 24829 RVA: 0x000EA2C7 File Offset: 0x000E84C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060060FE RID: 24830 RVA: 0x000EA2D0 File Offset: 0x000E84D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060060FF RID: 24831 RVA: 0x000EA2E8 File Offset: 0x000E84E8
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

		// Token: 0x06006100 RID: 24832 RVA: 0x000EA30E File Offset: 0x000E850E
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

		// Token: 0x06006101 RID: 24833 RVA: 0x000EA32B File Offset: 0x000E852B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006102 RID: 24834 RVA: 0x000EA334 File Offset: 0x000E8534
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

		// Token: 0x040037CD RID: 14285
		private UnknownFieldSet _unknownFields;
	}
}
