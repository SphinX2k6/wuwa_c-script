using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000170 RID: 368
	[NetMessage(EMessageId.BattlePassPaidNotify)]
	public sealed class BattlePassPaidNotify : IMessage<BattlePassPaidNotify>, IMessage, IEquatable<BattlePassPaidNotify>, IDeepCloneable<BattlePassPaidNotify>, IBufferMessage
	{
		// Token: 0x06002D8F RID: 11663 RVA: 0x0007630D File Offset: 0x0007450D
		[NullableContext(1)]
		public static BattlePassPaidNotify Create()
		{
			return new BattlePassPaidNotify();
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x06002D90 RID: 11664 RVA: 0x00076314 File Offset: 0x00074514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x06002D91 RID: 11665 RVA: 0x00076317 File Offset: 0x00074517
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattlePassPaidNotify.Descriptor;
			}
		}

		// Token: 0x06002D92 RID: 11666 RVA: 0x0007631E File Offset: 0x0007451E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassPaidNotify()
		{
		}

		// Token: 0x06002D93 RID: 11667 RVA: 0x00076326 File Offset: 0x00074526
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassPaidNotify(BattlePassPaidNotify other) : this()
		{
			this.payStatus_ = other.payStatus_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002D94 RID: 11668 RVA: 0x0007634B File Offset: 0x0007454B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassPaidNotify Clone()
		{
			return new BattlePassPaidNotify(this);
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x06002D95 RID: 11669 RVA: 0x00076353 File Offset: 0x00074553
		// (set) Token: 0x06002D96 RID: 11670 RVA: 0x0007635B File Offset: 0x0007455B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassPayStatus PayStatus
		{
			get
			{
				return this.payStatus_;
			}
			set
			{
				this.payStatus_ = value;
			}
		}

		// Token: 0x06002D97 RID: 11671 RVA: 0x00076364 File Offset: 0x00074564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattlePassPaidNotify);
		}

		// Token: 0x06002D98 RID: 11672 RVA: 0x00076372 File Offset: 0x00074572
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattlePassPaidNotify other)
		{
			return other != null && (other == this || (this.PayStatus == other.PayStatus && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002D99 RID: 11673 RVA: 0x000763A0 File Offset: 0x000745A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PayStatus != BattlePassPayStatus.NoPaid)
			{
				num ^= this.PayStatus.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002D9A RID: 11674 RVA: 0x000763E5 File Offset: 0x000745E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002D9B RID: 11675 RVA: 0x000763F2 File Offset: 0x000745F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002D9C RID: 11676 RVA: 0x000763FB File Offset: 0x000745FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PayStatus != BattlePassPayStatus.NoPaid)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.PayStatus);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002D9D RID: 11677 RVA: 0x0007642C File Offset: 0x0007462C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PayStatus != BattlePassPayStatus.NoPaid)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.PayStatus);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002D9E RID: 11678 RVA: 0x0007646A File Offset: 0x0007466A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattlePassPaidNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PayStatus != BattlePassPayStatus.NoPaid)
			{
				this.PayStatus = other.PayStatus;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002D9F RID: 11679 RVA: 0x0007649B File Offset: 0x0007469B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002DA0 RID: 11680 RVA: 0x000764A4 File Offset: 0x000746A4
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.PayStatus = (BattlePassPayStatus)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002897 RID: 10391
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002898 RID: 10392
		public const int PayStatusFieldNumber = 1;

		// Token: 0x04002899 RID: 10393
		private BattlePassPayStatus payStatus_;
	}
}
