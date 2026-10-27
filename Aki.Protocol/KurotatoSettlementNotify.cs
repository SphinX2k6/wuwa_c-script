using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008C0 RID: 2240
	[NetMessage(EMessageId.KurotatoSettlementNotify)]
	public sealed class KurotatoSettlementNotify : IMessage<KurotatoSettlementNotify>, IMessage, IEquatable<KurotatoSettlementNotify>, IDeepCloneable<KurotatoSettlementNotify>, IBufferMessage
	{
		// Token: 0x0600C6A6 RID: 50854 RVA: 0x001D6468 File Offset: 0x001D4668
		[NullableContext(1)]
		public static KurotatoSettlementNotify Create()
		{
			return new KurotatoSettlementNotify();
		}

		// Token: 0x17002826 RID: 10278
		// (get) Token: 0x0600C6A7 RID: 50855 RVA: 0x001D646F File Offset: 0x001D466F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002827 RID: 10279
		// (get) Token: 0x0600C6A8 RID: 50856 RVA: 0x001D6472 File Offset: 0x001D4672
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoSettlementNotify.Descriptor;
			}
		}

		// Token: 0x0600C6A9 RID: 50857 RVA: 0x001D6479 File Offset: 0x001D4679
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoSettlementNotify()
		{
		}

		// Token: 0x0600C6AA RID: 50858 RVA: 0x001D6481 File Offset: 0x001D4681
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoSettlementNotify(KurotatoSettlementNotify other) : this()
		{
			this.kurotatoSettlementInfo_ = ((other.kurotatoSettlementInfo_ != null) ? other.kurotatoSettlementInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C6AB RID: 50859 RVA: 0x001D64B6 File Offset: 0x001D46B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoSettlementNotify Clone()
		{
			return new KurotatoSettlementNotify(this);
		}

		// Token: 0x17002828 RID: 10280
		// (get) Token: 0x0600C6AC RID: 50860 RVA: 0x001D64BE File Offset: 0x001D46BE
		// (set) Token: 0x0600C6AD RID: 50861 RVA: 0x001D64C6 File Offset: 0x001D46C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoSettlementInfo KurotatoSettlementInfo
		{
			get
			{
				return this.kurotatoSettlementInfo_;
			}
			set
			{
				this.kurotatoSettlementInfo_ = value;
			}
		}

		// Token: 0x0600C6AE RID: 50862 RVA: 0x001D64CF File Offset: 0x001D46CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoSettlementNotify);
		}

		// Token: 0x0600C6AF RID: 50863 RVA: 0x001D64DD File Offset: 0x001D46DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoSettlementNotify other)
		{
			return other != null && (other == this || (object.Equals(this.KurotatoSettlementInfo, other.KurotatoSettlementInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C6B0 RID: 50864 RVA: 0x001D6510 File Offset: 0x001D4710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.kurotatoSettlementInfo_ != null)
			{
				num ^= this.KurotatoSettlementInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C6B1 RID: 50865 RVA: 0x001D654C File Offset: 0x001D474C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C6B2 RID: 50866 RVA: 0x001D6559 File Offset: 0x001D4759
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C6B3 RID: 50867 RVA: 0x001D6562 File Offset: 0x001D4762
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.kurotatoSettlementInfo_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.KurotatoSettlementInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C6B4 RID: 50868 RVA: 0x001D6594 File Offset: 0x001D4794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.kurotatoSettlementInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.KurotatoSettlementInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C6B5 RID: 50869 RVA: 0x001D65D4 File Offset: 0x001D47D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoSettlementNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.kurotatoSettlementInfo_ != null)
			{
				if (this.kurotatoSettlementInfo_ == null)
				{
					this.KurotatoSettlementInfo = new KurotatoSettlementInfo();
				}
				this.KurotatoSettlementInfo.MergeFrom(other.KurotatoSettlementInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C6B6 RID: 50870 RVA: 0x001D6628 File Offset: 0x001D4828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C6B7 RID: 50871 RVA: 0x001D6634 File Offset: 0x001D4834
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
				if (num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.kurotatoSettlementInfo_ == null)
					{
						this.KurotatoSettlementInfo = new KurotatoSettlementInfo();
					}
					input.ReadMessage(this.KurotatoSettlementInfo);
				}
			}
		}

		// Token: 0x0400554D RID: 21837
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400554E RID: 21838
		public const int KurotatoSettlementInfoFieldNumber = 15;

		// Token: 0x0400554F RID: 21839
		private KurotatoSettlementInfo kurotatoSettlementInfo_;
	}
}
