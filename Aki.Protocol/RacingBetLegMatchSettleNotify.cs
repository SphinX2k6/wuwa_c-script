using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E2B RID: 3627
	[NetMessage(EMessageId.RacingBetLegMatchSettleNotify)]
	public sealed class RacingBetLegMatchSettleNotify : IMessage<RacingBetLegMatchSettleNotify>, IMessage, IEquatable<RacingBetLegMatchSettleNotify>, IDeepCloneable<RacingBetLegMatchSettleNotify>, IBufferMessage
	{
		// Token: 0x06013802 RID: 79874 RVA: 0x002D6054 File Offset: 0x002D4254
		[NullableContext(1)]
		public static RacingBetLegMatchSettleNotify Create()
		{
			return new RacingBetLegMatchSettleNotify();
		}

		// Token: 0x170040AE RID: 16558
		// (get) Token: 0x06013803 RID: 79875 RVA: 0x002D605B File Offset: 0x002D425B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170040AF RID: 16559
		// (get) Token: 0x06013804 RID: 79876 RVA: 0x002D605E File Offset: 0x002D425E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetLegMatchSettleNotify.Descriptor;
			}
		}

		// Token: 0x06013805 RID: 79877 RVA: 0x002D6065 File Offset: 0x002D4265
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetLegMatchSettleNotify()
		{
		}

		// Token: 0x06013806 RID: 79878 RVA: 0x002D606D File Offset: 0x002D426D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetLegMatchSettleNotify(RacingBetLegMatchSettleNotify other) : this()
		{
			this.result_ = ((other.result_ != null) ? other.result_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013807 RID: 79879 RVA: 0x002D60A2 File Offset: 0x002D42A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetLegMatchSettleNotify Clone()
		{
			return new RacingBetLegMatchSettleNotify(this);
		}

		// Token: 0x170040B0 RID: 16560
		// (get) Token: 0x06013808 RID: 79880 RVA: 0x002D60AA File Offset: 0x002D42AA
		// (set) Token: 0x06013809 RID: 79881 RVA: 0x002D60B2 File Offset: 0x002D42B2
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

		// Token: 0x0601380A RID: 79882 RVA: 0x002D60BB File Offset: 0x002D42BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetLegMatchSettleNotify);
		}

		// Token: 0x0601380B RID: 79883 RVA: 0x002D60C9 File Offset: 0x002D42C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetLegMatchSettleNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Result, other.Result) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601380C RID: 79884 RVA: 0x002D60FC File Offset: 0x002D42FC
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

		// Token: 0x0601380D RID: 79885 RVA: 0x002D6138 File Offset: 0x002D4338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601380E RID: 79886 RVA: 0x002D6145 File Offset: 0x002D4345
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601380F RID: 79887 RVA: 0x002D614E File Offset: 0x002D434E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.result_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Result);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013810 RID: 79888 RVA: 0x002D6180 File Offset: 0x002D4380
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

		// Token: 0x06013811 RID: 79889 RVA: 0x002D61C0 File Offset: 0x002D43C0
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

		// Token: 0x06013812 RID: 79890 RVA: 0x002D6214 File Offset: 0x002D4414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013813 RID: 79891 RVA: 0x002D6220 File Offset: 0x002D4420
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
				if (num != 10U)
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

		// Token: 0x040077DC RID: 30684
		private UnknownFieldSet _unknownFields;

		// Token: 0x040077DD RID: 30685
		public const int ResultFieldNumber = 1;

		// Token: 0x040077DE RID: 30686
		private MatchResult result_;
	}
}
