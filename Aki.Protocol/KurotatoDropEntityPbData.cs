using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200087F RID: 2175
	public sealed class KurotatoDropEntityPbData : IMessage<KurotatoDropEntityPbData>, IMessage, IEquatable<KurotatoDropEntityPbData>, IDeepCloneable<KurotatoDropEntityPbData>, IBufferMessage
	{
		// Token: 0x0600C1D3 RID: 49619 RVA: 0x001CC85E File Offset: 0x001CAA5E
		[NullableContext(1)]
		public static KurotatoDropEntityPbData Create()
		{
			return new KurotatoDropEntityPbData();
		}

		// Token: 0x17002729 RID: 10025
		// (get) Token: 0x0600C1D4 RID: 49620 RVA: 0x001CC865 File Offset: 0x001CAA65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700272A RID: 10026
		// (get) Token: 0x0600C1D5 RID: 49621 RVA: 0x001CC868 File Offset: 0x001CAA68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoDropEntityPbData.Descriptor;
			}
		}

		// Token: 0x0600C1D6 RID: 49622 RVA: 0x001CC86F File Offset: 0x001CAA6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoDropEntityPbData()
		{
		}

		// Token: 0x0600C1D7 RID: 49623 RVA: 0x001CC877 File Offset: 0x001CAA77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoDropEntityPbData(KurotatoDropEntityPbData other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C1D8 RID: 49624 RVA: 0x001CC890 File Offset: 0x001CAA90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoDropEntityPbData Clone()
		{
			return new KurotatoDropEntityPbData(this);
		}

		// Token: 0x0600C1D9 RID: 49625 RVA: 0x001CC898 File Offset: 0x001CAA98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoDropEntityPbData);
		}

		// Token: 0x0600C1DA RID: 49626 RVA: 0x001CC8A6 File Offset: 0x001CAAA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoDropEntityPbData other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600C1DB RID: 49627 RVA: 0x001CC8C4 File Offset: 0x001CAAC4
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

		// Token: 0x0600C1DC RID: 49628 RVA: 0x001CC8EA File Offset: 0x001CAAEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C1DD RID: 49629 RVA: 0x001CC8F7 File Offset: 0x001CAAF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C1DE RID: 49630 RVA: 0x001CC900 File Offset: 0x001CAB00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C1DF RID: 49631 RVA: 0x001CC918 File Offset: 0x001CAB18
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

		// Token: 0x0600C1E0 RID: 49632 RVA: 0x001CC93E File Offset: 0x001CAB3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoDropEntityPbData other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C1E1 RID: 49633 RVA: 0x001CC95B File Offset: 0x001CAB5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C1E2 RID: 49634 RVA: 0x001CC964 File Offset: 0x001CAB64
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

		// Token: 0x0400545A RID: 21594
		private UnknownFieldSet _unknownFields;
	}
}
