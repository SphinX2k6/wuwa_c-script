using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008D2 RID: 2258
	public sealed class KurotatoStructureEntityPbData : IMessage<KurotatoStructureEntityPbData>, IMessage, IEquatable<KurotatoStructureEntityPbData>, IDeepCloneable<KurotatoStructureEntityPbData>, IBufferMessage
	{
		// Token: 0x0600C814 RID: 51220 RVA: 0x001D98EB File Offset: 0x001D7AEB
		[NullableContext(1)]
		public static KurotatoStructureEntityPbData Create()
		{
			return new KurotatoStructureEntityPbData();
		}

		// Token: 0x17002871 RID: 10353
		// (get) Token: 0x0600C815 RID: 51221 RVA: 0x001D98F2 File Offset: 0x001D7AF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002872 RID: 10354
		// (get) Token: 0x0600C816 RID: 51222 RVA: 0x001D98F5 File Offset: 0x001D7AF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoStructureEntityPbData.Descriptor;
			}
		}

		// Token: 0x0600C817 RID: 51223 RVA: 0x001D98FC File Offset: 0x001D7AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoStructureEntityPbData()
		{
		}

		// Token: 0x0600C818 RID: 51224 RVA: 0x001D9904 File Offset: 0x001D7B04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoStructureEntityPbData(KurotatoStructureEntityPbData other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C819 RID: 51225 RVA: 0x001D991D File Offset: 0x001D7B1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoStructureEntityPbData Clone()
		{
			return new KurotatoStructureEntityPbData(this);
		}

		// Token: 0x0600C81A RID: 51226 RVA: 0x001D9925 File Offset: 0x001D7B25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoStructureEntityPbData);
		}

		// Token: 0x0600C81B RID: 51227 RVA: 0x001D9933 File Offset: 0x001D7B33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoStructureEntityPbData other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600C81C RID: 51228 RVA: 0x001D9954 File Offset: 0x001D7B54
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

		// Token: 0x0600C81D RID: 51229 RVA: 0x001D997A File Offset: 0x001D7B7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C81E RID: 51230 RVA: 0x001D9987 File Offset: 0x001D7B87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C81F RID: 51231 RVA: 0x001D9990 File Offset: 0x001D7B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C820 RID: 51232 RVA: 0x001D99A8 File Offset: 0x001D7BA8
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

		// Token: 0x0600C821 RID: 51233 RVA: 0x001D99CE File Offset: 0x001D7BCE
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

		// Token: 0x0600C822 RID: 51234 RVA: 0x001D99EB File Offset: 0x001D7BEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C823 RID: 51235 RVA: 0x001D99F4 File Offset: 0x001D7BF4
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

		// Token: 0x040055A3 RID: 21923
		private UnknownFieldSet _unknownFields;
	}
}
