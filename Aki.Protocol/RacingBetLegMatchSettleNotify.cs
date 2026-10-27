using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E3B RID: 3643
	[NetMessage(EMessageId.RacingBetLegMatchSettleNotify)]
	public sealed class RacingBetLegMatchSettleNotify : IMessage<RacingBetLegMatchSettleNotify>, IMessage, IEquatable<RacingBetLegMatchSettleNotify>, IDeepCloneable<RacingBetLegMatchSettleNotify>, IBufferMessage
	{
		// Token: 0x060138E7 RID: 80103 RVA: 0x002D7714 File Offset: 0x002D5914
		[NullableContext(1)]
		public static RacingBetLegMatchSettleNotify Create()
		{
			return new RacingBetLegMatchSettleNotify();
		}

		// Token: 0x170040D8 RID: 16600
		// (get) Token: 0x060138E8 RID: 80104 RVA: 0x002D771B File Offset: 0x002D591B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170040D9 RID: 16601
		// (get) Token: 0x060138E9 RID: 80105 RVA: 0x002D771E File Offset: 0x002D591E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetLegMatchSettleNotify.Descriptor;
			}
		}

		// Token: 0x060138EA RID: 80106 RVA: 0x002D7725 File Offset: 0x002D5925
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetLegMatchSettleNotify()
		{
		}

		// Token: 0x060138EB RID: 80107 RVA: 0x002D772D File Offset: 0x002D592D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetLegMatchSettleNotify(RacingBetLegMatchSettleNotify other) : this()
		{
			this.result_ = ((other.result_ != null) ? other.result_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060138EC RID: 80108 RVA: 0x002D7762 File Offset: 0x002D5962
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetLegMatchSettleNotify Clone()
		{
			return new RacingBetLegMatchSettleNotify(this);
		}

		// Token: 0x170040DA RID: 16602
		// (get) Token: 0x060138ED RID: 80109 RVA: 0x002D776A File Offset: 0x002D596A
		// (set) Token: 0x060138EE RID: 80110 RVA: 0x002D7772 File Offset: 0x002D5972
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchResult Result
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

		// Token: 0x060138EF RID: 80111 RVA: 0x002D777B File Offset: 0x002D597B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetLegMatchSettleNotify);
		}

		// Token: 0x060138F0 RID: 80112 RVA: 0x002D7789 File Offset: 0x002D5989
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetLegMatchSettleNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Result, other.Result) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060138F1 RID: 80113 RVA: 0x002D77BC File Offset: 0x002D59BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x060138F2 RID: 80114 RVA: 0x002D77F8 File Offset: 0x002D59F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060138F3 RID: 80115 RVA: 0x002D7805 File Offset: 0x002D5A05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060138F4 RID: 80116 RVA: 0x002D780E File Offset: 0x002D5A0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.result_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.Result);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060138F5 RID: 80117 RVA: 0x002D7840 File Offset: 0x002D5A40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x060138F6 RID: 80118 RVA: 0x002D7880 File Offset: 0x002D5A80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetLegMatchSettleNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.result_ != null)
			{
				if (this.result_ == null)
				{
					this.Result = new MatchResult();
				}
				this.Result.MergeFrom(other.Result);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060138F7 RID: 80119 RVA: 0x002D78D4 File Offset: 0x002D5AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060138F8 RID: 80120 RVA: 0x002D78E0 File Offset: 0x002D5AE0
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
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.result_ == null)
					{
						this.Result = new MatchResult();
					}
					input.ReadMessage(this.Result);
				}
			}
		}

		// Token: 0x040077B2 RID: 30642
		private UnknownFieldSet _unknownFields;

		// Token: 0x040077B3 RID: 30643
		public const int ResultFieldNumber = 13;

		// Token: 0x040077B4 RID: 30644
		private MatchResult result_;
	}
}
