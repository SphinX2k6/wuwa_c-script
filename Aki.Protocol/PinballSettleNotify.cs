using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D5E RID: 3422
	[NetMessage(EMessageId.PinballSettleNotify)]
	public sealed class PinballSettleNotify : IMessage<PinballSettleNotify>, IMessage, IEquatable<PinballSettleNotify>, IDeepCloneable<PinballSettleNotify>, IBufferMessage
	{
		// Token: 0x06012750 RID: 75600 RVA: 0x002B1769 File Offset: 0x002AF969
		[NullableContext(1)]
		public static PinballSettleNotify Create()
		{
			return new PinballSettleNotify();
		}

		// Token: 0x17003D2F RID: 15663
		// (get) Token: 0x06012751 RID: 75601 RVA: 0x002B1770 File Offset: 0x002AF970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D30 RID: 15664
		// (get) Token: 0x06012752 RID: 75602 RVA: 0x002B1773 File Offset: 0x002AF973
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballSettleNotify.Descriptor;
			}
		}

		// Token: 0x06012753 RID: 75603 RVA: 0x002B177A File Offset: 0x002AF97A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballSettleNotify()
		{
		}

		// Token: 0x06012754 RID: 75604 RVA: 0x002B1784 File Offset: 0x002AF984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballSettleNotify(PinballSettleNotify other) : this()
		{
			this.win_ = other.win_;
			this.result_ = ((other.result_ != null) ? other.result_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012755 RID: 75605 RVA: 0x002B17D0 File Offset: 0x002AF9D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballSettleNotify Clone()
		{
			return new PinballSettleNotify(this);
		}

		// Token: 0x17003D31 RID: 15665
		// (get) Token: 0x06012756 RID: 75606 RVA: 0x002B17D8 File Offset: 0x002AF9D8
		// (set) Token: 0x06012757 RID: 75607 RVA: 0x002B17E0 File Offset: 0x002AF9E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Win
		{
			get
			{
				return this.win_;
			}
			set
			{
				this.win_ = value;
			}
		}

		// Token: 0x17003D32 RID: 15666
		// (get) Token: 0x06012758 RID: 75608 RVA: 0x002B17E9 File Offset: 0x002AF9E9
		// (set) Token: 0x06012759 RID: 75609 RVA: 0x002B17F1 File Offset: 0x002AF9F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballResult Result
		{
			get
			{
				return this.result_;
			}
			set
			{
				this.result_ = value;
			}
		}

		// Token: 0x0601275A RID: 75610 RVA: 0x002B17FA File Offset: 0x002AF9FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballSettleNotify);
		}

		// Token: 0x0601275B RID: 75611 RVA: 0x002B1808 File Offset: 0x002AFA08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballSettleNotify other)
		{
			return other != null && (other == this || (this.Win == other.Win && object.Equals(this.Result, other.Result) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601275C RID: 75612 RVA: 0x002B1858 File Offset: 0x002AFA58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Win)
			{
				num ^= this.Win.GetHashCode();
			}
			if (this.result_ != null)
			{
				num ^= this.Result.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601275D RID: 75613 RVA: 0x002B18AD File Offset: 0x002AFAAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601275E RID: 75614 RVA: 0x002B18BA File Offset: 0x002AFABA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601275F RID: 75615 RVA: 0x002B18C4 File Offset: 0x002AFAC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Win)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.Win);
			}
			if (this.result_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.Result);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012760 RID: 75616 RVA: 0x002B1920 File Offset: 0x002AFB20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Win)
			{
				num += 2;
			}
			if (this.result_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Result);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012761 RID: 75617 RVA: 0x002B196C File Offset: 0x002AFB6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballSettleNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Win)
			{
				this.Win = other.Win;
			}
			if (other.result_ != null)
			{
				if (this.result_ == null)
				{
					this.Result = new PinballResult();
				}
				this.Result.MergeFrom(other.Result);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012762 RID: 75618 RVA: 0x002B19D4 File Offset: 0x002AFBD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012763 RID: 75619 RVA: 0x002B19E0 File Offset: 0x002AFBE0
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
					if (num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.result_ == null)
						{
							this.Result = new PinballResult();
						}
						input.ReadMessage(this.Result);
					}
				}
				else
				{
					this.Win = input.ReadBool();
				}
			}
		}

		// Token: 0x040072D7 RID: 29399
		private UnknownFieldSet _unknownFields;

		// Token: 0x040072D8 RID: 29400
		public const int WinFieldNumber = 6;

		// Token: 0x040072D9 RID: 29401
		private bool win_;

		// Token: 0x040072DA RID: 29402
		public const int ResultFieldNumber = 9;

		// Token: 0x040072DB RID: 29403
		private PinballResult result_;
	}
}
