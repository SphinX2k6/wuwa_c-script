using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000881 RID: 2177
	[NetMessage(EMessageId.KurotatoEndShopStepRequest)]
	public sealed class KurotatoEndShopStepRequest : IMessage<KurotatoEndShopStepRequest>, IMessage, IEquatable<KurotatoEndShopStepRequest>, IDeepCloneable<KurotatoEndShopStepRequest>, IBufferMessage
	{
		// Token: 0x0600C1F9 RID: 49657 RVA: 0x001CCCF5 File Offset: 0x001CAEF5
		[NullableContext(1)]
		public static KurotatoEndShopStepRequest Create()
		{
			return new KurotatoEndShopStepRequest();
		}

		// Token: 0x17002730 RID: 10032
		// (get) Token: 0x0600C1FA RID: 49658 RVA: 0x001CCCFC File Offset: 0x001CAEFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002731 RID: 10033
		// (get) Token: 0x0600C1FB RID: 49659 RVA: 0x001CCCFF File Offset: 0x001CAEFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoEndShopStepRequest.Descriptor;
			}
		}

		// Token: 0x0600C1FC RID: 49660 RVA: 0x001CCD06 File Offset: 0x001CAF06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoEndShopStepRequest()
		{
		}

		// Token: 0x0600C1FD RID: 49661 RVA: 0x001CCD0E File Offset: 0x001CAF0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoEndShopStepRequest(KurotatoEndShopStepRequest other) : this()
		{
			this.isEndLess_ = other.isEndLess_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C1FE RID: 49662 RVA: 0x001CCD33 File Offset: 0x001CAF33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoEndShopStepRequest Clone()
		{
			return new KurotatoEndShopStepRequest(this);
		}

		// Token: 0x17002732 RID: 10034
		// (get) Token: 0x0600C1FF RID: 49663 RVA: 0x001CCD3B File Offset: 0x001CAF3B
		// (set) Token: 0x0600C200 RID: 49664 RVA: 0x001CCD43 File Offset: 0x001CAF43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsEndLess
		{
			get
			{
				return this.isEndLess_;
			}
			set
			{
				this.isEndLess_ = value;
			}
		}

		// Token: 0x0600C201 RID: 49665 RVA: 0x001CCD4C File Offset: 0x001CAF4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoEndShopStepRequest);
		}

		// Token: 0x0600C202 RID: 49666 RVA: 0x001CCD5A File Offset: 0x001CAF5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoEndShopStepRequest other)
		{
			return other != null && (other == this || (this.IsEndLess == other.IsEndLess && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C203 RID: 49667 RVA: 0x001CCD88 File Offset: 0x001CAF88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsEndLess)
			{
				num ^= this.IsEndLess.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C204 RID: 49668 RVA: 0x001CCDC7 File Offset: 0x001CAFC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C205 RID: 49669 RVA: 0x001CCDD4 File Offset: 0x001CAFD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C206 RID: 49670 RVA: 0x001CCDDD File Offset: 0x001CAFDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsEndLess)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.IsEndLess);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C207 RID: 49671 RVA: 0x001CCE10 File Offset: 0x001CB010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsEndLess)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C208 RID: 49672 RVA: 0x001CCE42 File Offset: 0x001CB042
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoEndShopStepRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsEndLess)
			{
				this.IsEndLess = other.IsEndLess;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C209 RID: 49673 RVA: 0x001CCE73 File Offset: 0x001CB073
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C20A RID: 49674 RVA: 0x001CCE7C File Offset: 0x001CB07C
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.IsEndLess = input.ReadBool();
				}
			}
		}

		// Token: 0x04005463 RID: 21603
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005464 RID: 21604
		public const int IsEndLessFieldNumber = 9;

		// Token: 0x04005465 RID: 21605
		private bool isEndLess_;
	}
}
