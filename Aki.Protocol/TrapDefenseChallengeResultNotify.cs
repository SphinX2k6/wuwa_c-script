using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200148D RID: 5261
	[NetMessage(EMessageId.TrapDefenseChallengeResultNotify)]
	public sealed class TrapDefenseChallengeResultNotify : IMessage<TrapDefenseChallengeResultNotify>, IMessage, IEquatable<TrapDefenseChallengeResultNotify>, IDeepCloneable<TrapDefenseChallengeResultNotify>, IBufferMessage
	{
		// Token: 0x0601BEFB RID: 114427 RVA: 0x0040F049 File Offset: 0x0040D249
		[NullableContext(1)]
		public static TrapDefenseChallengeResultNotify Create()
		{
			return new TrapDefenseChallengeResultNotify();
		}

		// Token: 0x17005E99 RID: 24217
		// (get) Token: 0x0601BEFC RID: 114428 RVA: 0x0040F050 File Offset: 0x0040D250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E9A RID: 24218
		// (get) Token: 0x0601BEFD RID: 114429 RVA: 0x0040F053 File Offset: 0x0040D253
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseChallengeResultNotify.Descriptor;
			}
		}

		// Token: 0x0601BEFE RID: 114430 RVA: 0x0040F05A File Offset: 0x0040D25A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseChallengeResultNotify()
		{
		}

		// Token: 0x0601BEFF RID: 114431 RVA: 0x0040F062 File Offset: 0x0040D262
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseChallengeResultNotify(TrapDefenseChallengeResultNotify other) : this()
		{
			this.result_ = ((other.result_ != null) ? other.result_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BF00 RID: 114432 RVA: 0x0040F097 File Offset: 0x0040D297
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseChallengeResultNotify Clone()
		{
			return new TrapDefenseChallengeResultNotify(this);
		}

		// Token: 0x17005E9B RID: 24219
		// (get) Token: 0x0601BF01 RID: 114433 RVA: 0x0040F09F File Offset: 0x0040D29F
		// (set) Token: 0x0601BF02 RID: 114434 RVA: 0x0040F0A7 File Offset: 0x0040D2A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseResultInfo Result
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

		// Token: 0x0601BF03 RID: 114435 RVA: 0x0040F0B0 File Offset: 0x0040D2B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseChallengeResultNotify);
		}

		// Token: 0x0601BF04 RID: 114436 RVA: 0x0040F0BE File Offset: 0x0040D2BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseChallengeResultNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Result, other.Result) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BF05 RID: 114437 RVA: 0x0040F0F4 File Offset: 0x0040D2F4
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

		// Token: 0x0601BF06 RID: 114438 RVA: 0x0040F130 File Offset: 0x0040D330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BF07 RID: 114439 RVA: 0x0040F13D File Offset: 0x0040D33D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BF08 RID: 114440 RVA: 0x0040F146 File Offset: 0x0040D346
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.result_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.Result);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BF09 RID: 114441 RVA: 0x0040F178 File Offset: 0x0040D378
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

		// Token: 0x0601BF0A RID: 114442 RVA: 0x0040F1B8 File Offset: 0x0040D3B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseChallengeResultNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.result_ != null)
			{
				if (this.result_ == null)
				{
					this.Result = new TrapDefenseResultInfo();
				}
				this.Result.MergeFrom(other.Result);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BF0B RID: 114443 RVA: 0x0040F20C File Offset: 0x0040D40C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BF0C RID: 114444 RVA: 0x0040F218 File Offset: 0x0040D418
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
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.result_ == null)
					{
						this.Result = new TrapDefenseResultInfo();
					}
					input.ReadMessage(this.Result);
				}
			}
		}

		// Token: 0x0400A1FF RID: 41471
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A200 RID: 41472
		public const int ResultFieldNumber = 10;

		// Token: 0x0400A201 RID: 41473
		private TrapDefenseResultInfo result_;
	}
}
