using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200087E RID: 2174
	public sealed class KurotatoDropAbsorbedCtxPb : IMessage<KurotatoDropAbsorbedCtxPb>, IMessage, IEquatable<KurotatoDropAbsorbedCtxPb>, IDeepCloneable<KurotatoDropAbsorbedCtxPb>, IBufferMessage
	{
		// Token: 0x0600C1C3 RID: 49603 RVA: 0x001CC726 File Offset: 0x001CA926
		[NullableContext(1)]
		public static KurotatoDropAbsorbedCtxPb Create()
		{
			return new KurotatoDropAbsorbedCtxPb();
		}

		// Token: 0x17002727 RID: 10023
		// (get) Token: 0x0600C1C4 RID: 49604 RVA: 0x001CC72D File Offset: 0x001CA92D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002728 RID: 10024
		// (get) Token: 0x0600C1C5 RID: 49605 RVA: 0x001CC730 File Offset: 0x001CA930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoDropAbsorbedCtxPb.Descriptor;
			}
		}

		// Token: 0x0600C1C6 RID: 49606 RVA: 0x001CC737 File Offset: 0x001CA937
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoDropAbsorbedCtxPb()
		{
		}

		// Token: 0x0600C1C7 RID: 49607 RVA: 0x001CC73F File Offset: 0x001CA93F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoDropAbsorbedCtxPb(KurotatoDropAbsorbedCtxPb other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C1C8 RID: 49608 RVA: 0x001CC758 File Offset: 0x001CA958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoDropAbsorbedCtxPb Clone()
		{
			return new KurotatoDropAbsorbedCtxPb(this);
		}

		// Token: 0x0600C1C9 RID: 49609 RVA: 0x001CC760 File Offset: 0x001CA960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoDropAbsorbedCtxPb);
		}

		// Token: 0x0600C1CA RID: 49610 RVA: 0x001CC76E File Offset: 0x001CA96E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoDropAbsorbedCtxPb other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600C1CB RID: 49611 RVA: 0x001CC78C File Offset: 0x001CA98C
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

		// Token: 0x0600C1CC RID: 49612 RVA: 0x001CC7B2 File Offset: 0x001CA9B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C1CD RID: 49613 RVA: 0x001CC7BF File Offset: 0x001CA9BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C1CE RID: 49614 RVA: 0x001CC7C8 File Offset: 0x001CA9C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C1CF RID: 49615 RVA: 0x001CC7E0 File Offset: 0x001CA9E0
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

		// Token: 0x0600C1D0 RID: 49616 RVA: 0x001CC806 File Offset: 0x001CAA06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoDropAbsorbedCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C1D1 RID: 49617 RVA: 0x001CC823 File Offset: 0x001CAA23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C1D2 RID: 49618 RVA: 0x001CC82C File Offset: 0x001CAA2C
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

		// Token: 0x04005459 RID: 21593
		private UnknownFieldSet _unknownFields;
	}
}
