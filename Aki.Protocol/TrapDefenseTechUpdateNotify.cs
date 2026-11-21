using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014CD RID: 5325
	[NetMessage(EMessageId.TrapDefenseTechUpdateNotify)]
	public sealed class TrapDefenseTechUpdateNotify : IMessage<TrapDefenseTechUpdateNotify>, IMessage, IEquatable<TrapDefenseTechUpdateNotify>, IDeepCloneable<TrapDefenseTechUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601C3F3 RID: 115699 RVA: 0x0041982D File Offset: 0x00417A2D
		[NullableContext(1)]
		public static TrapDefenseTechUpdateNotify Create()
		{
			return new TrapDefenseTechUpdateNotify();
		}

		// Token: 0x17005F9B RID: 24475
		// (get) Token: 0x0601C3F4 RID: 115700 RVA: 0x00419834 File Offset: 0x00417A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F9C RID: 24476
		// (get) Token: 0x0601C3F5 RID: 115701 RVA: 0x00419837 File Offset: 0x00417A37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseTechUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601C3F6 RID: 115702 RVA: 0x0041983E File Offset: 0x00417A3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseTechUpdateNotify()
		{
		}

		// Token: 0x0601C3F7 RID: 115703 RVA: 0x00419851 File Offset: 0x00417A51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseTechUpdateNotify(TrapDefenseTechUpdateNotify other) : this()
		{
			this.unlockTechNodes_ = other.unlockTechNodes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C3F8 RID: 115704 RVA: 0x0041987B File Offset: 0x00417A7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseTechUpdateNotify Clone()
		{
			return new TrapDefenseTechUpdateNotify(this);
		}

		// Token: 0x17005F9D RID: 24477
		// (get) Token: 0x0601C3F9 RID: 115705 RVA: 0x00419883 File Offset: 0x00417A83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockTechNodes
		{
			get
			{
				return this.unlockTechNodes_;
			}
		}

		// Token: 0x0601C3FA RID: 115706 RVA: 0x0041988B File Offset: 0x00417A8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseTechUpdateNotify);
		}

		// Token: 0x0601C3FB RID: 115707 RVA: 0x00419899 File Offset: 0x00417A99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseTechUpdateNotify other)
		{
			return other != null && (other == this || (this.unlockTechNodes_.Equals(other.unlockTechNodes_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C3FC RID: 115708 RVA: 0x004198CC File Offset: 0x00417ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unlockTechNodes_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C3FD RID: 115709 RVA: 0x00419900 File Offset: 0x00417B00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C3FE RID: 115710 RVA: 0x0041990D File Offset: 0x00417B0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C3FF RID: 115711 RVA: 0x00419916 File Offset: 0x00417B16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockTechNodes_.WriteTo(ref output, TrapDefenseTechUpdateNotify._repeated_unlockTechNodes_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C400 RID: 115712 RVA: 0x00419940 File Offset: 0x00417B40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unlockTechNodes_.CalculateSize(TrapDefenseTechUpdateNotify._repeated_unlockTechNodes_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C401 RID: 115713 RVA: 0x00419979 File Offset: 0x00417B79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseTechUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.unlockTechNodes_.Add(other.unlockTechNodes_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C402 RID: 115714 RVA: 0x004199A7 File Offset: 0x00417BA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C403 RID: 115715 RVA: 0x004199B0 File Offset: 0x00417BB0
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
				if (num != 64U && num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.unlockTechNodes_.AddEntriesFrom(ref input, TrapDefenseTechUpdateNotify._repeated_unlockTechNodes_codec);
				}
			}
		}

		// Token: 0x0400A34C RID: 41804
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A34D RID: 41805
		public const int UnlockTechNodesFieldNumber = 8;

		// Token: 0x0400A34E RID: 41806
		private static readonly FieldCodec<int> _repeated_unlockTechNodes_codec = FieldCodec.ForInt32(66U);

		// Token: 0x0400A34F RID: 41807
		private readonly RepeatedField<int> unlockTechNodes_ = new RepeatedField<int>();
	}
}
