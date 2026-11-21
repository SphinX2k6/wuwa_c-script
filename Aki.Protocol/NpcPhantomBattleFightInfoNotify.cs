using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B64 RID: 2916
	[NetMessage(EMessageId.NpcPhantomBattleFightInfoNotify)]
	public sealed class NpcPhantomBattleFightInfoNotify : IMessage<NpcPhantomBattleFightInfoNotify>, IMessage, IEquatable<NpcPhantomBattleFightInfoNotify>, IDeepCloneable<NpcPhantomBattleFightInfoNotify>, IBufferMessage
	{
		// Token: 0x0600FD2A RID: 64810 RVA: 0x0024F5AB File Offset: 0x0024D7AB
		[NullableContext(1)]
		public static NpcPhantomBattleFightInfoNotify Create()
		{
			return new NpcPhantomBattleFightInfoNotify();
		}

		// Token: 0x170033AB RID: 13227
		// (get) Token: 0x0600FD2B RID: 64811 RVA: 0x0024F5B2 File Offset: 0x0024D7B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170033AC RID: 13228
		// (get) Token: 0x0600FD2C RID: 64812 RVA: 0x0024F5B5 File Offset: 0x0024D7B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcPhantomBattleFightInfoNotify.Descriptor;
			}
		}

		// Token: 0x0600FD2D RID: 64813 RVA: 0x0024F5BC File Offset: 0x0024D7BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleFightInfoNotify()
		{
		}

		// Token: 0x0600FD2E RID: 64814 RVA: 0x0024F5CF File Offset: 0x0024D7CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleFightInfoNotify(NpcPhantomBattleFightInfoNotify other) : this()
		{
			this.phantomBattleFightInfos_ = other.phantomBattleFightInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FD2F RID: 64815 RVA: 0x0024F5F9 File Offset: 0x0024D7F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleFightInfoNotify Clone()
		{
			return new NpcPhantomBattleFightInfoNotify(this);
		}

		// Token: 0x170033AD RID: 13229
		// (get) Token: 0x0600FD30 RID: 64816 RVA: 0x0024F601 File Offset: 0x0024D801
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NpcPhantomBattleFightInfo> PhantomBattleFightInfos
		{
			get
			{
				return this.phantomBattleFightInfos_;
			}
		}

		// Token: 0x0600FD31 RID: 64817 RVA: 0x0024F609 File Offset: 0x0024D809
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcPhantomBattleFightInfoNotify);
		}

		// Token: 0x0600FD32 RID: 64818 RVA: 0x0024F617 File Offset: 0x0024D817
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcPhantomBattleFightInfoNotify other)
		{
			return other != null && (other == this || (this.phantomBattleFightInfos_.Equals(other.phantomBattleFightInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FD33 RID: 64819 RVA: 0x0024F64C File Offset: 0x0024D84C
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

		// Token: 0x0600FD34 RID: 64820 RVA: 0x0024F680 File Offset: 0x0024D880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FD35 RID: 64821 RVA: 0x0024F68D File Offset: 0x0024D88D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FD36 RID: 64822 RVA: 0x0024F696 File Offset: 0x0024D896
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

		// Token: 0x0600FD37 RID: 64823 RVA: 0x0024F6C0 File Offset: 0x0024D8C0
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

		// Token: 0x0600FD38 RID: 64824 RVA: 0x0024F6F9 File Offset: 0x0024D8F9
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

		// Token: 0x0600FD39 RID: 64825 RVA: 0x0024F727 File Offset: 0x0024D927
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FD3A RID: 64826 RVA: 0x0024F730 File Offset: 0x0024D930
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

		// Token: 0x0400656C RID: 25964
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400656D RID: 25965
		public const int PhantomBattleFightInfosFieldNumber = 1;

		// Token: 0x0400656E RID: 25966
		private static readonly FieldCodec<NpcPhantomBattleFightInfo> _repeated_phantomBattleFightInfos_codec = FieldCodec.ForMessage<NpcPhantomBattleFightInfo>(10U, NpcPhantomBattleFightInfo.Parser);

		// Token: 0x0400656F RID: 25967
		private readonly RepeatedField<NpcPhantomBattleFightInfo> phantomBattleFightInfos_ = new RepeatedField<NpcPhantomBattleFightInfo>();
	}
}
