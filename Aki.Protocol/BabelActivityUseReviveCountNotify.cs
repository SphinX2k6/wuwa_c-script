using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200014B RID: 331
	[NetMessage(EMessageId.BabelActivityUseReviveCountNotify)]
	public sealed class BabelActivityUseReviveCountNotify : IMessage<BabelActivityUseReviveCountNotify>, IMessage, IEquatable<BabelActivityUseReviveCountNotify>, IDeepCloneable<BabelActivityUseReviveCountNotify>, IBufferMessage
	{
		// Token: 0x06002AAD RID: 10925 RVA: 0x00070201 File Offset: 0x0006E401
		[NullableContext(1)]
		public static BabelActivityUseReviveCountNotify Create()
		{
			return new BabelActivityUseReviveCountNotify();
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06002AAE RID: 10926 RVA: 0x00070208 File Offset: 0x0006E408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06002AAF RID: 10927 RVA: 0x0007020B File Offset: 0x0006E40B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BabelActivityUseReviveCountNotify.Descriptor;
			}
		}

		// Token: 0x06002AB0 RID: 10928 RVA: 0x00070212 File Offset: 0x0006E412
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityUseReviveCountNotify()
		{
		}

		// Token: 0x06002AB1 RID: 10929 RVA: 0x0007021A File Offset: 0x0006E41A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityUseReviveCountNotify(BabelActivityUseReviveCountNotify other) : this()
		{
			this.useReviveCount_ = other.useReviveCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002AB2 RID: 10930 RVA: 0x0007023F File Offset: 0x0006E43F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityUseReviveCountNotify Clone()
		{
			return new BabelActivityUseReviveCountNotify(this);
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x06002AB3 RID: 10931 RVA: 0x00070247 File Offset: 0x0006E447
		// (set) Token: 0x06002AB4 RID: 10932 RVA: 0x0007024F File Offset: 0x0006E44F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UseReviveCount
		{
			get
			{
				return this.useReviveCount_;
			}
			set
			{
				this.useReviveCount_ = value;
			}
		}

		// Token: 0x06002AB5 RID: 10933 RVA: 0x00070258 File Offset: 0x0006E458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BabelActivityUseReviveCountNotify);
		}

		// Token: 0x06002AB6 RID: 10934 RVA: 0x00070266 File Offset: 0x0006E466
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BabelActivityUseReviveCountNotify other)
		{
			return other != null && (other == this || (this.UseReviveCount == other.UseReviveCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002AB7 RID: 10935 RVA: 0x00070294 File Offset: 0x0006E494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.UseReviveCount != 0)
			{
				num ^= this.UseReviveCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002AB8 RID: 10936 RVA: 0x000702D3 File Offset: 0x0006E4D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002AB9 RID: 10937 RVA: 0x000702E0 File Offset: 0x0006E4E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002ABA RID: 10938 RVA: 0x000702E9 File Offset: 0x0006E4E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.UseReviveCount != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.UseReviveCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002ABB RID: 10939 RVA: 0x0007031C File Offset: 0x0006E51C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.UseReviveCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UseReviveCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002ABC RID: 10940 RVA: 0x0007035A File Offset: 0x0006E55A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BabelActivityUseReviveCountNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.UseReviveCount != 0)
			{
				this.UseReviveCount = other.UseReviveCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002ABD RID: 10941 RVA: 0x0007038B File Offset: 0x0006E58B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002ABE RID: 10942 RVA: 0x00070394 File Offset: 0x0006E594
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.UseReviveCount = input.ReadInt32();
				}
			}
		}

		// Token: 0x040027CA RID: 10186
		private UnknownFieldSet _unknownFields;

		// Token: 0x040027CB RID: 10187
		public const int UseReviveCountFieldNumber = 6;

		// Token: 0x040027CC RID: 10188
		private int useReviveCount_;
	}
}
