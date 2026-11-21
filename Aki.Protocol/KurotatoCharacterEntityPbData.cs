using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000876 RID: 2166
	public sealed class KurotatoCharacterEntityPbData : IMessage<KurotatoCharacterEntityPbData>, IMessage, IEquatable<KurotatoCharacterEntityPbData>, IDeepCloneable<KurotatoCharacterEntityPbData>, IBufferMessage
	{
		// Token: 0x0600C12F RID: 49455 RVA: 0x001CB6C4 File Offset: 0x001C98C4
		[NullableContext(1)]
		public static KurotatoCharacterEntityPbData Create()
		{
			return new KurotatoCharacterEntityPbData();
		}

		// Token: 0x1700270D RID: 9997
		// (get) Token: 0x0600C130 RID: 49456 RVA: 0x001CB6CB File Offset: 0x001C98CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700270E RID: 9998
		// (get) Token: 0x0600C131 RID: 49457 RVA: 0x001CB6CE File Offset: 0x001C98CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoCharacterEntityPbData.Descriptor;
			}
		}

		// Token: 0x0600C132 RID: 49458 RVA: 0x001CB6D5 File Offset: 0x001C98D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoCharacterEntityPbData()
		{
		}

		// Token: 0x0600C133 RID: 49459 RVA: 0x001CB6DD File Offset: 0x001C98DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoCharacterEntityPbData(KurotatoCharacterEntityPbData other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C134 RID: 49460 RVA: 0x001CB6F6 File Offset: 0x001C98F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoCharacterEntityPbData Clone()
		{
			return new KurotatoCharacterEntityPbData(this);
		}

		// Token: 0x0600C135 RID: 49461 RVA: 0x001CB6FE File Offset: 0x001C98FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoCharacterEntityPbData);
		}

		// Token: 0x0600C136 RID: 49462 RVA: 0x001CB70C File Offset: 0x001C990C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoCharacterEntityPbData other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600C137 RID: 49463 RVA: 0x001CB72C File Offset: 0x001C992C
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

		// Token: 0x0600C138 RID: 49464 RVA: 0x001CB752 File Offset: 0x001C9952
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C139 RID: 49465 RVA: 0x001CB75F File Offset: 0x001C995F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C13A RID: 49466 RVA: 0x001CB768 File Offset: 0x001C9968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C13B RID: 49467 RVA: 0x001CB780 File Offset: 0x001C9980
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

		// Token: 0x0600C13C RID: 49468 RVA: 0x001CB7A6 File Offset: 0x001C99A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoCharacterEntityPbData other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C13D RID: 49469 RVA: 0x001CB7C3 File Offset: 0x001C99C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C13E RID: 49470 RVA: 0x001CB7CC File Offset: 0x001C99CC
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

		// Token: 0x0400543D RID: 21565
		private UnknownFieldSet _unknownFields;
	}
}
