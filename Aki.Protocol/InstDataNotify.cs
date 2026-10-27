using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200081E RID: 2078
	[NetMessage(EMessageId.InstDataNotify)]
	public sealed class InstDataNotify : IMessage<InstDataNotify>, IMessage, IEquatable<InstDataNotify>, IDeepCloneable<InstDataNotify>, IBufferMessage
	{
		// Token: 0x0600B9AC RID: 47532 RVA: 0x001B9E97 File Offset: 0x001B8097
		[NullableContext(1)]
		public static InstDataNotify Create()
		{
			return new InstDataNotify();
		}

		// Token: 0x17002568 RID: 9576
		// (get) Token: 0x0600B9AD RID: 47533 RVA: 0x001B9E9E File Offset: 0x001B809E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002569 RID: 9577
		// (get) Token: 0x0600B9AE RID: 47534 RVA: 0x001B9EA1 File Offset: 0x001B80A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InstDataNotify.Descriptor;
			}
		}

		// Token: 0x0600B9AF RID: 47535 RVA: 0x001B9EA8 File Offset: 0x001B80A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstDataNotify()
		{
		}

		// Token: 0x0600B9B0 RID: 47536 RVA: 0x001B9EBB File Offset: 0x001B80BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstDataNotify(InstDataNotify other) : this()
		{
			this.enterInfos_ = other.enterInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B9B1 RID: 47537 RVA: 0x001B9EE5 File Offset: 0x001B80E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstDataNotify Clone()
		{
			return new InstDataNotify(this);
		}

		// Token: 0x1700256A RID: 9578
		// (get) Token: 0x0600B9B2 RID: 47538 RVA: 0x001B9EED File Offset: 0x001B80ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<InstEnterInfoPb> EnterInfos
		{
			get
			{
				return this.enterInfos_;
			}
		}

		// Token: 0x0600B9B3 RID: 47539 RVA: 0x001B9EF5 File Offset: 0x001B80F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InstDataNotify);
		}

		// Token: 0x0600B9B4 RID: 47540 RVA: 0x001B9F03 File Offset: 0x001B8103
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InstDataNotify other)
		{
			return other != null && (other == this || (this.enterInfos_.Equals(other.enterInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B9B5 RID: 47541 RVA: 0x001B9F38 File Offset: 0x001B8138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.enterInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B9B6 RID: 47542 RVA: 0x001B9F6C File Offset: 0x001B816C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B9B7 RID: 47543 RVA: 0x001B9F79 File Offset: 0x001B8179
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B9B8 RID: 47544 RVA: 0x001B9F82 File Offset: 0x001B8182
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.enterInfos_.WriteTo(ref output, InstDataNotify._repeated_enterInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B9B9 RID: 47545 RVA: 0x001B9FAC File Offset: 0x001B81AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.enterInfos_.CalculateSize(InstDataNotify._repeated_enterInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B9BA RID: 47546 RVA: 0x001B9FE5 File Offset: 0x001B81E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InstDataNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.enterInfos_.Add(other.enterInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B9BB RID: 47547 RVA: 0x001BA013 File Offset: 0x001B8213
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B9BC RID: 47548 RVA: 0x001BA01C File Offset: 0x001B821C
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
				if (num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.enterInfos_.AddEntriesFrom(ref input, InstDataNotify._repeated_enterInfos_codec);
				}
			}
		}

		// Token: 0x04005190 RID: 20880
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005191 RID: 20881
		public const int EnterInfosFieldNumber = 3;

		// Token: 0x04005192 RID: 20882
		private static readonly FieldCodec<InstEnterInfoPb> _repeated_enterInfos_codec = FieldCodec.ForMessage<InstEnterInfoPb>(26U, InstEnterInfoPb.Parser);

		// Token: 0x04005193 RID: 20883
		private readonly RepeatedField<InstEnterInfoPb> enterInfos_ = new RepeatedField<InstEnterInfoPb>();
	}
}
