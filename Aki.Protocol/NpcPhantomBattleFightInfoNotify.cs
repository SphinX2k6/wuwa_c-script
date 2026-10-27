using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B74 RID: 2932
	[NetMessage(EMessageId.NpcPhantomBattleFightInfoNotify)]
	public sealed class NpcPhantomBattleFightInfoNotify : IMessage<NpcPhantomBattleFightInfoNotify>, IMessage, IEquatable<NpcPhantomBattleFightInfoNotify>, IDeepCloneable<NpcPhantomBattleFightInfoNotify>, IBufferMessage
	{
		// Token: 0x0600FE2E RID: 65070 RVA: 0x0025147B File Offset: 0x0024F67B
		[NullableContext(1)]
		public static NpcPhantomBattleFightInfoNotify Create()
		{
			return new NpcPhantomBattleFightInfoNotify();
		}

		// Token: 0x170033E4 RID: 13284
		// (get) Token: 0x0600FE2F RID: 65071 RVA: 0x00251482 File Offset: 0x0024F682
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170033E5 RID: 13285
		// (get) Token: 0x0600FE30 RID: 65072 RVA: 0x00251485 File Offset: 0x0024F685
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcPhantomBattleFightInfoNotify.Descriptor;
			}
		}

		// Token: 0x0600FE31 RID: 65073 RVA: 0x0025148C File Offset: 0x0024F68C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleFightInfoNotify()
		{
		}

		// Token: 0x0600FE32 RID: 65074 RVA: 0x0025149F File Offset: 0x0024F69F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleFightInfoNotify(NpcPhantomBattleFightInfoNotify other) : this()
		{
			this.phantomBattleFightInfos_ = other.phantomBattleFightInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FE33 RID: 65075 RVA: 0x002514C9 File Offset: 0x0024F6C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleFightInfoNotify Clone()
		{
			return new NpcPhantomBattleFightInfoNotify(this);
		}

		// Token: 0x170033E6 RID: 13286
		// (get) Token: 0x0600FE34 RID: 65076 RVA: 0x002514D1 File Offset: 0x0024F6D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NpcPhantomBattleFightInfo> PhantomBattleFightInfos
		{
			get
			{
				return this.phantomBattleFightInfos_;
			}
		}

		// Token: 0x0600FE35 RID: 65077 RVA: 0x002514D9 File Offset: 0x0024F6D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcPhantomBattleFightInfoNotify);
		}

		// Token: 0x0600FE36 RID: 65078 RVA: 0x002514E7 File Offset: 0x0024F6E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcPhantomBattleFightInfoNotify other)
		{
			return other != null && (other == this || (this.phantomBattleFightInfos_.Equals(other.phantomBattleFightInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FE37 RID: 65079 RVA: 0x0025151C File Offset: 0x0024F71C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.phantomBattleFightInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FE38 RID: 65080 RVA: 0x00251550 File Offset: 0x0024F750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FE39 RID: 65081 RVA: 0x0025155D File Offset: 0x0024F75D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FE3A RID: 65082 RVA: 0x00251566 File Offset: 0x0024F766
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phantomBattleFightInfos_.WriteTo(ref output, NpcPhantomBattleFightInfoNotify._repeated_phantomBattleFightInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FE3B RID: 65083 RVA: 0x00251590 File Offset: 0x0024F790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.phantomBattleFightInfos_.CalculateSize(NpcPhantomBattleFightInfoNotify._repeated_phantomBattleFightInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FE3C RID: 65084 RVA: 0x002515C9 File Offset: 0x0024F7C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NpcPhantomBattleFightInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.phantomBattleFightInfos_.Add(other.phantomBattleFightInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FE3D RID: 65085 RVA: 0x002515F7 File Offset: 0x0024F7F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FE3E RID: 65086 RVA: 0x00251600 File Offset: 0x0024F800
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
					this.phantomBattleFightInfos_.AddEntriesFrom(ref input, NpcPhantomBattleFightInfoNotify._repeated_phantomBattleFightInfos_codec);
				}
			}
		}

		// Token: 0x0400655C RID: 25948
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400655D RID: 25949
		public const int PhantomBattleFightInfosFieldNumber = 1;

		// Token: 0x0400655E RID: 25950
		private static readonly FieldCodec<NpcPhantomBattleFightInfo> _repeated_phantomBattleFightInfos_codec = FieldCodec.ForMessage<NpcPhantomBattleFightInfo>(10U, NpcPhantomBattleFightInfo.Parser);

		// Token: 0x0400655F RID: 25951
		private readonly RepeatedField<NpcPhantomBattleFightInfo> phantomBattleFightInfos_ = new RepeatedField<NpcPhantomBattleFightInfo>();
	}
}
