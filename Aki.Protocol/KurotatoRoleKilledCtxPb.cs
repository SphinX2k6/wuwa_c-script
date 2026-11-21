using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008A5 RID: 2213
	public sealed class KurotatoRoleKilledCtxPb : IMessage<KurotatoRoleKilledCtxPb>, IMessage, IEquatable<KurotatoRoleKilledCtxPb>, IDeepCloneable<KurotatoRoleKilledCtxPb>, IBufferMessage
	{
		// Token: 0x0600C4C5 RID: 50373 RVA: 0x001D26C4 File Offset: 0x001D08C4
		[NullableContext(1)]
		public static KurotatoRoleKilledCtxPb Create()
		{
			return new KurotatoRoleKilledCtxPb();
		}

		// Token: 0x170027BF RID: 10175
		// (get) Token: 0x0600C4C6 RID: 50374 RVA: 0x001D26CB File Offset: 0x001D08CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170027C0 RID: 10176
		// (get) Token: 0x0600C4C7 RID: 50375 RVA: 0x001D26CE File Offset: 0x001D08CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoRoleKilledCtxPb.Descriptor;
			}
		}

		// Token: 0x0600C4C8 RID: 50376 RVA: 0x001D26D5 File Offset: 0x001D08D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoRoleKilledCtxPb()
		{
		}

		// Token: 0x0600C4C9 RID: 50377 RVA: 0x001D26DD File Offset: 0x001D08DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoRoleKilledCtxPb(KurotatoRoleKilledCtxPb other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C4CA RID: 50378 RVA: 0x001D26F6 File Offset: 0x001D08F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoRoleKilledCtxPb Clone()
		{
			return new KurotatoRoleKilledCtxPb(this);
		}

		// Token: 0x0600C4CB RID: 50379 RVA: 0x001D26FE File Offset: 0x001D08FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoRoleKilledCtxPb);
		}

		// Token: 0x0600C4CC RID: 50380 RVA: 0x001D270C File Offset: 0x001D090C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoRoleKilledCtxPb other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600C4CD RID: 50381 RVA: 0x001D272C File Offset: 0x001D092C
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

		// Token: 0x0600C4CE RID: 50382 RVA: 0x001D2752 File Offset: 0x001D0952
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C4CF RID: 50383 RVA: 0x001D275F File Offset: 0x001D095F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C4D0 RID: 50384 RVA: 0x001D2768 File Offset: 0x001D0968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C4D1 RID: 50385 RVA: 0x001D2780 File Offset: 0x001D0980
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

		// Token: 0x0600C4D2 RID: 50386 RVA: 0x001D27A6 File Offset: 0x001D09A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoRoleKilledCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C4D3 RID: 50387 RVA: 0x001D27C3 File Offset: 0x001D09C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C4D4 RID: 50388 RVA: 0x001D27CC File Offset: 0x001D09CC
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

		// Token: 0x0400551B RID: 21787
		private UnknownFieldSet _unknownFields;
	}
}
