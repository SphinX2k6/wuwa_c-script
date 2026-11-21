using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D4E RID: 3406
	[NetMessage(EMessageId.PinballSettleNotify)]
	public sealed class PinballSettleNotify : IMessage<PinballSettleNotify>, IMessage, IEquatable<PinballSettleNotify>, IDeepCloneable<PinballSettleNotify>, IBufferMessage
	{
		// Token: 0x06012654 RID: 75348 RVA: 0x002AFB45 File Offset: 0x002ADD45
		[NullableContext(1)]
		public static PinballSettleNotify Create()
		{
			return new PinballSettleNotify();
		}

		// Token: 0x17003CFA RID: 15610
		// (get) Token: 0x06012655 RID: 75349 RVA: 0x002AFB4C File Offset: 0x002ADD4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003CFB RID: 15611
		// (get) Token: 0x06012656 RID: 75350 RVA: 0x002AFB4F File Offset: 0x002ADD4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballSettleNotify.Descriptor;
			}
		}

		// Token: 0x06012657 RID: 75351 RVA: 0x002AFB56 File Offset: 0x002ADD56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballSettleNotify()
		{
		}

		// Token: 0x06012658 RID: 75352 RVA: 0x002AFB60 File Offset: 0x002ADD60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballSettleNotify(PinballSettleNotify other) : this()
		{
			this.win_ = other.win_;
			this.result_ = ((other.result_ != null) ? other.result_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012659 RID: 75353 RVA: 0x002AFBAC File Offset: 0x002ADDAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballSettleNotify Clone()
		{
			return new PinballSettleNotify(this);
		}

		// Token: 0x17003CFC RID: 15612
		// (get) Token: 0x0601265A RID: 75354 RVA: 0x002AFBB4 File Offset: 0x002ADDB4
		// (set) Token: 0x0601265B RID: 75355 RVA: 0x002AFBBC File Offset: 0x002ADDBC
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

		// Token: 0x17003CFD RID: 15613
		// (get) Token: 0x0601265C RID: 75356 RVA: 0x002AFBC5 File Offset: 0x002ADDC5
		// (set) Token: 0x0601265D RID: 75357 RVA: 0x002AFBCD File Offset: 0x002ADDCD
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

		// Token: 0x0601265E RID: 75358 RVA: 0x002AFBD6 File Offset: 0x002ADDD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballSettleNotify);
		}

		// Token: 0x0601265F RID: 75359 RVA: 0x002AFBE4 File Offset: 0x002ADDE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballSettleNotify other)
		{
			return other != null && (other == this || (this.Win == other.Win && object.Equals(this.Result, other.Result) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012660 RID: 75360 RVA: 0x002AFC34 File Offset: 0x002ADE34
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

		// Token: 0x06012661 RID: 75361 RVA: 0x002AFC89 File Offset: 0x002ADE89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012662 RID: 75362 RVA: 0x002AFC96 File Offset: 0x002ADE96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012663 RID: 75363 RVA: 0x002AFCA0 File Offset: 0x002ADEA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Win)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.Win);
			}
			if (this.result_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.Result);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012664 RID: 75364 RVA: 0x002AFCFC File Offset: 0x002ADEFC
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

		// Token: 0x06012665 RID: 75365 RVA: 0x002AFD48 File Offset: 0x002ADF48
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

		// Token: 0x06012666 RID: 75366 RVA: 0x002AFDB0 File Offset: 0x002ADFB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012667 RID: 75367 RVA: 0x002AFDBC File Offset: 0x002ADFBC
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
				if (num != 32U)
				{
					if (num != 98U)
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

		// Token: 0x040072EF RID: 29423
		private UnknownFieldSet _unknownFields;

		// Token: 0x040072F0 RID: 29424
		public const int WinFieldNumber = 4;

		// Token: 0x040072F1 RID: 29425
		private bool win_;

		// Token: 0x040072F2 RID: 29426
		public const int ResultFieldNumber = 12;

		// Token: 0x040072F3 RID: 29427
		private PinballResult result_;
	}
}
