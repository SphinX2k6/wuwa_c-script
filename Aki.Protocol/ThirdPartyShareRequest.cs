using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200135F RID: 4959
	[NetMessage(EMessageId.ThirdPartyShareRequest)]
	public sealed class ThirdPartyShareRequest : IMessage<ThirdPartyShareRequest>, IMessage, IEquatable<ThirdPartyShareRequest>, IDeepCloneable<ThirdPartyShareRequest>, IBufferMessage
	{
		// Token: 0x0601A575 RID: 107893 RVA: 0x003D376D File Offset: 0x003D196D
		[NullableContext(1)]
		public static ThirdPartyShareRequest Create()
		{
			return new ThirdPartyShareRequest();
		}

		// Token: 0x170058DE RID: 22750
		// (get) Token: 0x0601A576 RID: 107894 RVA: 0x003D3774 File Offset: 0x003D1974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170058DF RID: 22751
		// (get) Token: 0x0601A577 RID: 107895 RVA: 0x003D3777 File Offset: 0x003D1977
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ThirdPartyShareRequest.Descriptor;
			}
		}

		// Token: 0x0601A578 RID: 107896 RVA: 0x003D377E File Offset: 0x003D197E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThirdPartyShareRequest()
		{
		}

		// Token: 0x0601A579 RID: 107897 RVA: 0x003D3786 File Offset: 0x003D1986
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThirdPartyShareRequest(ThirdPartyShareRequest other) : this()
		{
			this.sharedId_ = other.sharedId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A57A RID: 107898 RVA: 0x003D37AB File Offset: 0x003D19AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThirdPartyShareRequest Clone()
		{
			return new ThirdPartyShareRequest(this);
		}

		// Token: 0x170058E0 RID: 22752
		// (get) Token: 0x0601A57B RID: 107899 RVA: 0x003D37B3 File Offset: 0x003D19B3
		// (set) Token: 0x0601A57C RID: 107900 RVA: 0x003D37BB File Offset: 0x003D19BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SharedId
		{
			get
			{
				return this.sharedId_;
			}
			set
			{
				this.sharedId_ = value;
			}
		}

		// Token: 0x0601A57D RID: 107901 RVA: 0x003D37C4 File Offset: 0x003D19C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ThirdPartyShareRequest);
		}

		// Token: 0x0601A57E RID: 107902 RVA: 0x003D37D2 File Offset: 0x003D19D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ThirdPartyShareRequest other)
		{
			return other != null && (other == this || (this.SharedId == other.SharedId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A57F RID: 107903 RVA: 0x003D3800 File Offset: 0x003D1A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SharedId != 0)
			{
				num ^= this.SharedId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A580 RID: 107904 RVA: 0x003D383F File Offset: 0x003D1A3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A581 RID: 107905 RVA: 0x003D384C File Offset: 0x003D1A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A582 RID: 107906 RVA: 0x003D3855 File Offset: 0x003D1A55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SharedId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.SharedId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A583 RID: 107907 RVA: 0x003D3888 File Offset: 0x003D1A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SharedId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SharedId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A584 RID: 107908 RVA: 0x003D38C6 File Offset: 0x003D1AC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ThirdPartyShareRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SharedId != 0)
			{
				this.SharedId = other.SharedId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A585 RID: 107909 RVA: 0x003D38F7 File Offset: 0x003D1AF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A586 RID: 107910 RVA: 0x003D3900 File Offset: 0x003D1B00
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SharedId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009989 RID: 39305
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400998A RID: 39306
		public const int SharedIdFieldNumber = 10;

		// Token: 0x0400998B RID: 39307
		private int sharedId_;
	}
}
