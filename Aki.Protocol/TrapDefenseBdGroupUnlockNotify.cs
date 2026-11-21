using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200147E RID: 5246
	[NetMessage(EMessageId.TrapDefenseBdGroupUnlockNotify)]
	public sealed class TrapDefenseBdGroupUnlockNotify : IMessage<TrapDefenseBdGroupUnlockNotify>, IMessage, IEquatable<TrapDefenseBdGroupUnlockNotify>, IDeepCloneable<TrapDefenseBdGroupUnlockNotify>, IBufferMessage
	{
		// Token: 0x0601BDBA RID: 114106 RVA: 0x0040C4BD File Offset: 0x0040A6BD
		[NullableContext(1)]
		public static TrapDefenseBdGroupUnlockNotify Create()
		{
			return new TrapDefenseBdGroupUnlockNotify();
		}

		// Token: 0x17005E52 RID: 24146
		// (get) Token: 0x0601BDBB RID: 114107 RVA: 0x0040C4C4 File Offset: 0x0040A6C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E53 RID: 24147
		// (get) Token: 0x0601BDBC RID: 114108 RVA: 0x0040C4C7 File Offset: 0x0040A6C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseBdGroupUnlockNotify.Descriptor;
			}
		}

		// Token: 0x0601BDBD RID: 114109 RVA: 0x0040C4CE File Offset: 0x0040A6CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBdGroupUnlockNotify()
		{
		}

		// Token: 0x0601BDBE RID: 114110 RVA: 0x0040C4E1 File Offset: 0x0040A6E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBdGroupUnlockNotify(TrapDefenseBdGroupUnlockNotify other) : this()
		{
			this.unlockBdGroups_ = other.unlockBdGroups_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BDBF RID: 114111 RVA: 0x0040C50B File Offset: 0x0040A70B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBdGroupUnlockNotify Clone()
		{
			return new TrapDefenseBdGroupUnlockNotify(this);
		}

		// Token: 0x17005E54 RID: 24148
		// (get) Token: 0x0601BDC0 RID: 114112 RVA: 0x0040C513 File Offset: 0x0040A713
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockBdGroups
		{
			get
			{
				return this.unlockBdGroups_;
			}
		}

		// Token: 0x0601BDC1 RID: 114113 RVA: 0x0040C51B File Offset: 0x0040A71B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseBdGroupUnlockNotify);
		}

		// Token: 0x0601BDC2 RID: 114114 RVA: 0x0040C529 File Offset: 0x0040A729
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseBdGroupUnlockNotify other)
		{
			return other != null && (other == this || (this.unlockBdGroups_.Equals(other.unlockBdGroups_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BDC3 RID: 114115 RVA: 0x0040C55C File Offset: 0x0040A75C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unlockBdGroups_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BDC4 RID: 114116 RVA: 0x0040C590 File Offset: 0x0040A790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BDC5 RID: 114117 RVA: 0x0040C59D File Offset: 0x0040A79D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BDC6 RID: 114118 RVA: 0x0040C5A6 File Offset: 0x0040A7A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockBdGroups_.WriteTo(ref output, TrapDefenseBdGroupUnlockNotify._repeated_unlockBdGroups_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BDC7 RID: 114119 RVA: 0x0040C5D0 File Offset: 0x0040A7D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unlockBdGroups_.CalculateSize(TrapDefenseBdGroupUnlockNotify._repeated_unlockBdGroups_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BDC8 RID: 114120 RVA: 0x0040C609 File Offset: 0x0040A809
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseBdGroupUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.unlockBdGroups_.Add(other.unlockBdGroups_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BDC9 RID: 114121 RVA: 0x0040C637 File Offset: 0x0040A837
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BDCA RID: 114122 RVA: 0x0040C640 File Offset: 0x0040A840
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
				if (num != 80U && num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.unlockBdGroups_.AddEntriesFrom(ref input, TrapDefenseBdGroupUnlockNotify._repeated_unlockBdGroups_codec);
				}
			}
		}

		// Token: 0x0400A1A3 RID: 41379
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A1A4 RID: 41380
		public const int UnlockBdGroupsFieldNumber = 10;

		// Token: 0x0400A1A5 RID: 41381
		private static readonly FieldCodec<int> _repeated_unlockBdGroups_codec = FieldCodec.ForInt32(82U);

		// Token: 0x0400A1A6 RID: 41382
		private readonly RepeatedField<int> unlockBdGroups_ = new RepeatedField<int>();
	}
}
