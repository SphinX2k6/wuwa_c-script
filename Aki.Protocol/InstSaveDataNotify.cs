using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200082B RID: 2091
	[NetMessage(EMessageId.InstSaveDataNotify)]
	public sealed class InstSaveDataNotify : IMessage<InstSaveDataNotify>, IMessage, IEquatable<InstSaveDataNotify>, IDeepCloneable<InstSaveDataNotify>, IBufferMessage
	{
		// Token: 0x0600BAF5 RID: 47861 RVA: 0x001BD8BB File Offset: 0x001BBABB
		[NullableContext(1)]
		public static InstSaveDataNotify Create()
		{
			return new InstSaveDataNotify();
		}

		// Token: 0x170025C3 RID: 9667
		// (get) Token: 0x0600BAF6 RID: 47862 RVA: 0x001BD8C2 File Offset: 0x001BBAC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170025C4 RID: 9668
		// (get) Token: 0x0600BAF7 RID: 47863 RVA: 0x001BD8C5 File Offset: 0x001BBAC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InstSaveDataNotify.Descriptor;
			}
		}

		// Token: 0x0600BAF8 RID: 47864 RVA: 0x001BD8CC File Offset: 0x001BBACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstSaveDataNotify()
		{
		}

		// Token: 0x0600BAF9 RID: 47865 RVA: 0x001BD8DF File Offset: 0x001BBADF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstSaveDataNotify(InstSaveDataNotify other) : this()
		{
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BAFA RID: 47866 RVA: 0x001BD909 File Offset: 0x001BBB09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstSaveDataNotify Clone()
		{
			return new InstSaveDataNotify(this);
		}

		// Token: 0x170025C5 RID: 9669
		// (get) Token: 0x0600BAFB RID: 47867 RVA: 0x001BD911 File Offset: 0x001BBB11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x0600BAFC RID: 47868 RVA: 0x001BD919 File Offset: 0x001BBB19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InstSaveDataNotify);
		}

		// Token: 0x0600BAFD RID: 47869 RVA: 0x001BD927 File Offset: 0x001BBB27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InstSaveDataNotify other)
		{
			return other != null && (other == this || (this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BAFE RID: 47870 RVA: 0x001BD95C File Offset: 0x001BBB5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.ids_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BAFF RID: 47871 RVA: 0x001BD990 File Offset: 0x001BBB90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BB00 RID: 47872 RVA: 0x001BD99D File Offset: 0x001BBB9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BB01 RID: 47873 RVA: 0x001BD9A6 File Offset: 0x001BBBA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ids_.WriteTo(ref output, InstSaveDataNotify._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BB02 RID: 47874 RVA: 0x001BD9D0 File Offset: 0x001BBBD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.ids_.CalculateSize(InstSaveDataNotify._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BB03 RID: 47875 RVA: 0x001BDA09 File Offset: 0x001BBC09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InstSaveDataNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.ids_.Add(other.ids_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BB04 RID: 47876 RVA: 0x001BDA37 File Offset: 0x001BBC37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BB05 RID: 47877 RVA: 0x001BDA40 File Offset: 0x001BBC40
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
				if (num != 48U && num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ids_.AddEntriesFrom(ref input, InstSaveDataNotify._repeated_ids_codec);
				}
			}
		}

		// Token: 0x04005227 RID: 21031
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005228 RID: 21032
		public const int IdsFieldNumber = 6;

		// Token: 0x04005229 RID: 21033
		private static readonly FieldCodec<long> _repeated_ids_codec = FieldCodec.ForInt64(50U);

		// Token: 0x0400522A RID: 21034
		private readonly RepeatedField<long> ids_ = new RepeatedField<long>();
	}
}
