using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010E3 RID: 4323
	[NetMessage(EMessageId.RollBlockResetGamePlayNotify)]
	public sealed class RollBlockResetGamePlayNotify : IMessage<RollBlockResetGamePlayNotify>, IMessage, IEquatable<RollBlockResetGamePlayNotify>, IDeepCloneable<RollBlockResetGamePlayNotify>, IBufferMessage
	{
		// Token: 0x060170F3 RID: 94451 RVA: 0x00358BCC File Offset: 0x00356DCC
		[NullableContext(1)]
		public static RollBlockResetGamePlayNotify Create()
		{
			return new RollBlockResetGamePlayNotify();
		}

		// Token: 0x17004D3E RID: 19774
		// (get) Token: 0x060170F4 RID: 94452 RVA: 0x00358BD3 File Offset: 0x00356DD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D3F RID: 19775
		// (get) Token: 0x060170F5 RID: 94453 RVA: 0x00358BD6 File Offset: 0x00356DD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RollBlockResetGamePlayNotify.Descriptor;
			}
		}

		// Token: 0x060170F6 RID: 94454 RVA: 0x00358BDD File Offset: 0x00356DDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockResetGamePlayNotify()
		{
		}

		// Token: 0x060170F7 RID: 94455 RVA: 0x00358BE5 File Offset: 0x00356DE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockResetGamePlayNotify(RollBlockResetGamePlayNotify other) : this()
		{
			this.info_ = ((other.info_ != null) ? other.info_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060170F8 RID: 94456 RVA: 0x00358C1A File Offset: 0x00356E1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockResetGamePlayNotify Clone()
		{
			return new RollBlockResetGamePlayNotify(this);
		}

		// Token: 0x17004D40 RID: 19776
		// (get) Token: 0x060170F9 RID: 94457 RVA: 0x00358C22 File Offset: 0x00356E22
		// (set) Token: 0x060170FA RID: 94458 RVA: 0x00358C2A File Offset: 0x00356E2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockGamePlayPbInfo Info
		{
			get
			{
				return this.info_;
			}
			set
			{
				this.info_ = value;
			}
		}

		// Token: 0x060170FB RID: 94459 RVA: 0x00358C33 File Offset: 0x00356E33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RollBlockResetGamePlayNotify);
		}

		// Token: 0x060170FC RID: 94460 RVA: 0x00358C41 File Offset: 0x00356E41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RollBlockResetGamePlayNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Info, other.Info) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060170FD RID: 94461 RVA: 0x00358C74 File Offset: 0x00356E74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.info_ != null)
			{
				num ^= this.Info.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060170FE RID: 94462 RVA: 0x00358CB0 File Offset: 0x00356EB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060170FF RID: 94463 RVA: 0x00358CBD File Offset: 0x00356EBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017100 RID: 94464 RVA: 0x00358CC6 File Offset: 0x00356EC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.info_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Info);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017101 RID: 94465 RVA: 0x00358CF8 File Offset: 0x00356EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.info_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Info);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017102 RID: 94466 RVA: 0x00358D38 File Offset: 0x00356F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RollBlockResetGamePlayNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.info_ != null)
			{
				if (this.info_ == null)
				{
					this.Info = new RollBlockGamePlayPbInfo();
				}
				this.Info.MergeFrom(other.Info);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017103 RID: 94467 RVA: 0x00358D8C File Offset: 0x00356F8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017104 RID: 94468 RVA: 0x00358D98 File Offset: 0x00356F98
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
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.info_ == null)
					{
						this.Info = new RollBlockGamePlayPbInfo();
					}
					input.ReadMessage(this.Info);
				}
			}
		}

		// Token: 0x04008937 RID: 35127
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008938 RID: 35128
		public const int InfoFieldNumber = 4;

		// Token: 0x04008939 RID: 35129
		private RollBlockGamePlayPbInfo info_;
	}
}
