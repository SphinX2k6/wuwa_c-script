using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008C1 RID: 2241
	public sealed class KurotatoStructureEntityPbData : IMessage<KurotatoStructureEntityPbData>, IMessage, IEquatable<KurotatoStructureEntityPbData>, IDeepCloneable<KurotatoStructureEntityPbData>, IBufferMessage
	{
		// Token: 0x0600C6F8 RID: 50936 RVA: 0x001D7607 File Offset: 0x001D5807
		[NullableContext(1)]
		public static KurotatoStructureEntityPbData Create()
		{
			return new KurotatoStructureEntityPbData();
		}

		// Token: 0x17002832 RID: 10290
		// (get) Token: 0x0600C6F9 RID: 50937 RVA: 0x001D760E File Offset: 0x001D580E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002833 RID: 10291
		// (get) Token: 0x0600C6FA RID: 50938 RVA: 0x001D7611 File Offset: 0x001D5811
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoStructureEntityPbData.Descriptor;
			}
		}

		// Token: 0x0600C6FB RID: 50939 RVA: 0x001D7618 File Offset: 0x001D5818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoStructureEntityPbData()
		{
		}

		// Token: 0x0600C6FC RID: 50940 RVA: 0x001D7620 File Offset: 0x001D5820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoStructureEntityPbData(KurotatoStructureEntityPbData other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C6FD RID: 50941 RVA: 0x001D7639 File Offset: 0x001D5839
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoStructureEntityPbData Clone()
		{
			return new KurotatoStructureEntityPbData(this);
		}

		// Token: 0x0600C6FE RID: 50942 RVA: 0x001D7641 File Offset: 0x001D5841
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoStructureEntityPbData);
		}

		// Token: 0x0600C6FF RID: 50943 RVA: 0x001D764F File Offset: 0x001D584F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoStructureEntityPbData other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600C700 RID: 50944 RVA: 0x001D7670 File Offset: 0x001D5870
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

		// Token: 0x0600C701 RID: 50945 RVA: 0x001D7696 File Offset: 0x001D5896
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C702 RID: 50946 RVA: 0x001D76A3 File Offset: 0x001D58A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C703 RID: 50947 RVA: 0x001D76AC File Offset: 0x001D58AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C704 RID: 50948 RVA: 0x001D76C4 File Offset: 0x001D58C4
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

		// Token: 0x0600C705 RID: 50949 RVA: 0x001D76EA File Offset: 0x001D58EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoStructureEntityPbData other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C706 RID: 50950 RVA: 0x001D7707 File Offset: 0x001D5907
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C707 RID: 50951 RVA: 0x001D7710 File Offset: 0x001D5910
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

		// Token: 0x040055AA RID: 21930
		private UnknownFieldSet _unknownFields;
	}
}
