using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008B6 RID: 2230
	public sealed class KurotatoRoleKilledCtxPb : IMessage<KurotatoRoleKilledCtxPb>, IMessage, IEquatable<KurotatoRoleKilledCtxPb>, IDeepCloneable<KurotatoRoleKilledCtxPb>, IBufferMessage
	{
		// Token: 0x0600C5E1 RID: 50657 RVA: 0x001D49AC File Offset: 0x001D2BAC
		[NullableContext(1)]
		public static KurotatoRoleKilledCtxPb Create()
		{
			return new KurotatoRoleKilledCtxPb();
		}

		// Token: 0x170027FE RID: 10238
		// (get) Token: 0x0600C5E2 RID: 50658 RVA: 0x001D49B3 File Offset: 0x001D2BB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170027FF RID: 10239
		// (get) Token: 0x0600C5E3 RID: 50659 RVA: 0x001D49B6 File Offset: 0x001D2BB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoRoleKilledCtxPb.Descriptor;
			}
		}

		// Token: 0x0600C5E4 RID: 50660 RVA: 0x001D49BD File Offset: 0x001D2BBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoRoleKilledCtxPb()
		{
		}

		// Token: 0x0600C5E5 RID: 50661 RVA: 0x001D49C5 File Offset: 0x001D2BC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoRoleKilledCtxPb(KurotatoRoleKilledCtxPb other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C5E6 RID: 50662 RVA: 0x001D49DE File Offset: 0x001D2BDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoRoleKilledCtxPb Clone()
		{
			return new KurotatoRoleKilledCtxPb(this);
		}

		// Token: 0x0600C5E7 RID: 50663 RVA: 0x001D49E6 File Offset: 0x001D2BE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoRoleKilledCtxPb);
		}

		// Token: 0x0600C5E8 RID: 50664 RVA: 0x001D49F4 File Offset: 0x001D2BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoRoleKilledCtxPb other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600C5E9 RID: 50665 RVA: 0x001D4A14 File Offset: 0x001D2C14
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

		// Token: 0x0600C5EA RID: 50666 RVA: 0x001D4A3A File Offset: 0x001D2C3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C5EB RID: 50667 RVA: 0x001D4A47 File Offset: 0x001D2C47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C5EC RID: 50668 RVA: 0x001D4A50 File Offset: 0x001D2C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C5ED RID: 50669 RVA: 0x001D4A68 File Offset: 0x001D2C68
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

		// Token: 0x0600C5EE RID: 50670 RVA: 0x001D4A8E File Offset: 0x001D2C8E
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

		// Token: 0x0600C5EF RID: 50671 RVA: 0x001D4AAB File Offset: 0x001D2CAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C5F0 RID: 50672 RVA: 0x001D4AB4 File Offset: 0x001D2CB4
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

		// Token: 0x04005514 RID: 21780
		private UnknownFieldSet _unknownFields;
	}
}
