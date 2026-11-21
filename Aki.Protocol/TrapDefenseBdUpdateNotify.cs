using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200147F RID: 5247
	[NetMessage(EMessageId.TrapDefenseBdUpdateNotify)]
	public sealed class TrapDefenseBdUpdateNotify : IMessage<TrapDefenseBdUpdateNotify>, IMessage, IEquatable<TrapDefenseBdUpdateNotify>, IDeepCloneable<TrapDefenseBdUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601BDCC RID: 114124 RVA: 0x0040C69D File Offset: 0x0040A89D
		[NullableContext(1)]
		public static TrapDefenseBdUpdateNotify Create()
		{
			return new TrapDefenseBdUpdateNotify();
		}

		// Token: 0x17005E55 RID: 24149
		// (get) Token: 0x0601BDCD RID: 114125 RVA: 0x0040C6A4 File Offset: 0x0040A8A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E56 RID: 24150
		// (get) Token: 0x0601BDCE RID: 114126 RVA: 0x0040C6A7 File Offset: 0x0040A8A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseBdUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601BDCF RID: 114127 RVA: 0x0040C6AE File Offset: 0x0040A8AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBdUpdateNotify()
		{
		}

		// Token: 0x0601BDD0 RID: 114128 RVA: 0x0040C6C1 File Offset: 0x0040A8C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBdUpdateNotify(TrapDefenseBdUpdateNotify other) : this()
		{
			this.unlockBds_ = other.unlockBds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BDD1 RID: 114129 RVA: 0x0040C6EB File Offset: 0x0040A8EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBdUpdateNotify Clone()
		{
			return new TrapDefenseBdUpdateNotify(this);
		}

		// Token: 0x17005E57 RID: 24151
		// (get) Token: 0x0601BDD2 RID: 114130 RVA: 0x0040C6F3 File Offset: 0x0040A8F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockBds
		{
			get
			{
				return this.unlockBds_;
			}
		}

		// Token: 0x0601BDD3 RID: 114131 RVA: 0x0040C6FB File Offset: 0x0040A8FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseBdUpdateNotify);
		}

		// Token: 0x0601BDD4 RID: 114132 RVA: 0x0040C709 File Offset: 0x0040A909
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseBdUpdateNotify other)
		{
			return other != null && (other == this || (this.unlockBds_.Equals(other.unlockBds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BDD5 RID: 114133 RVA: 0x0040C73C File Offset: 0x0040A93C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unlockBds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BDD6 RID: 114134 RVA: 0x0040C770 File Offset: 0x0040A970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BDD7 RID: 114135 RVA: 0x0040C77D File Offset: 0x0040A97D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BDD8 RID: 114136 RVA: 0x0040C786 File Offset: 0x0040A986
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockBds_.WriteTo(ref output, TrapDefenseBdUpdateNotify._repeated_unlockBds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BDD9 RID: 114137 RVA: 0x0040C7B0 File Offset: 0x0040A9B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unlockBds_.CalculateSize(TrapDefenseBdUpdateNotify._repeated_unlockBds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BDDA RID: 114138 RVA: 0x0040C7E9 File Offset: 0x0040A9E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseBdUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.unlockBds_.Add(other.unlockBds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BDDB RID: 114139 RVA: 0x0040C817 File Offset: 0x0040AA17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BDDC RID: 114140 RVA: 0x0040C820 File Offset: 0x0040AA20
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
				if (num != 72U && num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.unlockBds_.AddEntriesFrom(ref input, TrapDefenseBdUpdateNotify._repeated_unlockBds_codec);
				}
			}
		}

		// Token: 0x0400A1A7 RID: 41383
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A1A8 RID: 41384
		public const int UnlockBdsFieldNumber = 9;

		// Token: 0x0400A1A9 RID: 41385
		private static readonly FieldCodec<int> _repeated_unlockBds_codec = FieldCodec.ForInt32(74U);

		// Token: 0x0400A1AA RID: 41386
		private readonly RepeatedField<int> unlockBds_ = new RepeatedField<int>();
	}
}
