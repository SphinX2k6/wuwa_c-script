using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200040C RID: 1036
	public sealed class EdgeRunnerLordGymCtx : IMessage<EdgeRunnerLordGymCtx>, IMessage, IEquatable<EdgeRunnerLordGymCtx>, IDeepCloneable<EdgeRunnerLordGymCtx>, IBufferMessage
	{
		// Token: 0x0600643B RID: 25659 RVA: 0x000F1E2D File Offset: 0x000F002D
		[NullableContext(1)]
		public static EdgeRunnerLordGymCtx Create()
		{
			return new EdgeRunnerLordGymCtx();
		}

		// Token: 0x170012C5 RID: 4805
		// (get) Token: 0x0600643C RID: 25660 RVA: 0x000F1E34 File Offset: 0x000F0034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170012C6 RID: 4806
		// (get) Token: 0x0600643D RID: 25661 RVA: 0x000F1E37 File Offset: 0x000F0037
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EdgeRunnerLordGymCtx.Descriptor;
			}
		}

		// Token: 0x0600643E RID: 25662 RVA: 0x000F1E3E File Offset: 0x000F003E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerLordGymCtx()
		{
		}

		// Token: 0x0600643F RID: 25663 RVA: 0x000F1E46 File Offset: 0x000F0046
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerLordGymCtx(EdgeRunnerLordGymCtx other) : this()
		{
			this.lordGymId_ = other.lordGymId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006440 RID: 25664 RVA: 0x000F1E6B File Offset: 0x000F006B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerLordGymCtx Clone()
		{
			return new EdgeRunnerLordGymCtx(this);
		}

		// Token: 0x170012C7 RID: 4807
		// (get) Token: 0x06006441 RID: 25665 RVA: 0x000F1E73 File Offset: 0x000F0073
		// (set) Token: 0x06006442 RID: 25666 RVA: 0x000F1E7B File Offset: 0x000F007B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LordGymId
		{
			get
			{
				return this.lordGymId_;
			}
			set
			{
				this.lordGymId_ = value;
			}
		}

		// Token: 0x06006443 RID: 25667 RVA: 0x000F1E84 File Offset: 0x000F0084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EdgeRunnerLordGymCtx);
		}

		// Token: 0x06006444 RID: 25668 RVA: 0x000F1E92 File Offset: 0x000F0092
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EdgeRunnerLordGymCtx other)
		{
			return other != null && (other == this || (this.LordGymId == other.LordGymId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006445 RID: 25669 RVA: 0x000F1EC0 File Offset: 0x000F00C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LordGymId != 0)
			{
				num ^= this.LordGymId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006446 RID: 25670 RVA: 0x000F1EFF File Offset: 0x000F00FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006447 RID: 25671 RVA: 0x000F1F0C File Offset: 0x000F010C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006448 RID: 25672 RVA: 0x000F1F15 File Offset: 0x000F0115
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LordGymId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LordGymId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006449 RID: 25673 RVA: 0x000F1F48 File Offset: 0x000F0148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LordGymId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LordGymId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600644A RID: 25674 RVA: 0x000F1F86 File Offset: 0x000F0186
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EdgeRunnerLordGymCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LordGymId != 0)
			{
				this.LordGymId = other.LordGymId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600644B RID: 25675 RVA: 0x000F1FB7 File Offset: 0x000F01B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600644C RID: 25676 RVA: 0x000F1FC0 File Offset: 0x000F01C0
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
					this.LordGymId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040038E3 RID: 14563
		private UnknownFieldSet _unknownFields;

		// Token: 0x040038E4 RID: 14564
		public const int LordGymIdFieldNumber = 1;

		// Token: 0x040038E5 RID: 14565
		private int lordGymId_;
	}
}
