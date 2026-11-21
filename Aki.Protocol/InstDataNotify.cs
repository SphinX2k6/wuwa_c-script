using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200080A RID: 2058
	[NetMessage(EMessageId.InstDataNotify)]
	public sealed class InstDataNotify : IMessage<InstDataNotify>, IMessage, IEquatable<InstDataNotify>, IDeepCloneable<InstDataNotify>, IBufferMessage
	{
		// Token: 0x0600B856 RID: 47190 RVA: 0x001B745B File Offset: 0x001B565B
		[NullableContext(1)]
		public static InstDataNotify Create()
		{
			return new InstDataNotify();
		}

		// Token: 0x1700251E RID: 9502
		// (get) Token: 0x0600B857 RID: 47191 RVA: 0x001B7462 File Offset: 0x001B5662
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700251F RID: 9503
		// (get) Token: 0x0600B858 RID: 47192 RVA: 0x001B7465 File Offset: 0x001B5665
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InstDataNotify.Descriptor;
			}
		}

		// Token: 0x0600B859 RID: 47193 RVA: 0x001B746C File Offset: 0x001B566C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstDataNotify()
		{
		}

		// Token: 0x0600B85A RID: 47194 RVA: 0x001B747F File Offset: 0x001B567F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstDataNotify(InstDataNotify other) : this()
		{
			this.enterInfos_ = other.enterInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B85B RID: 47195 RVA: 0x001B74A9 File Offset: 0x001B56A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstDataNotify Clone()
		{
			return new InstDataNotify(this);
		}

		// Token: 0x17002520 RID: 9504
		// (get) Token: 0x0600B85C RID: 47196 RVA: 0x001B74B1 File Offset: 0x001B56B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<InstEnterInfoPb> EnterInfos
		{
			get
			{
				return this.enterInfos_;
			}
		}

		// Token: 0x0600B85D RID: 47197 RVA: 0x001B74B9 File Offset: 0x001B56B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InstDataNotify);
		}

		// Token: 0x0600B85E RID: 47198 RVA: 0x001B74C7 File Offset: 0x001B56C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InstDataNotify other)
		{
			return other != null && (other == this || (this.enterInfos_.Equals(other.enterInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B85F RID: 47199 RVA: 0x001B74FC File Offset: 0x001B56FC
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

		// Token: 0x0600B860 RID: 47200 RVA: 0x001B7530 File Offset: 0x001B5730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B861 RID: 47201 RVA: 0x001B753D File Offset: 0x001B573D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B862 RID: 47202 RVA: 0x001B7546 File Offset: 0x001B5746
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

		// Token: 0x0600B863 RID: 47203 RVA: 0x001B7570 File Offset: 0x001B5770
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

		// Token: 0x0600B864 RID: 47204 RVA: 0x001B75A9 File Offset: 0x001B57A9
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

		// Token: 0x0600B865 RID: 47205 RVA: 0x001B75D7 File Offset: 0x001B57D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B866 RID: 47206 RVA: 0x001B75E0 File Offset: 0x001B57E0
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
					this.enterInfos_.AddEntriesFrom(ref input, InstDataNotify._repeated_enterInfos_codec);
				}
			}
		}

		// Token: 0x04005189 RID: 20873
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400518A RID: 20874
		public const int EnterInfosFieldNumber = 4;

		// Token: 0x0400518B RID: 20875
		private static readonly FieldCodec<InstEnterInfoPb> _repeated_enterInfos_codec = FieldCodec.ForMessage<InstEnterInfoPb>(34U, InstEnterInfoPb.Parser);

		// Token: 0x0400518C RID: 20876
		private readonly RepeatedField<InstEnterInfoPb> enterInfos_ = new RepeatedField<InstEnterInfoPb>();
	}
}
