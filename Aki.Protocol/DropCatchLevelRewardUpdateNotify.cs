using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003F7 RID: 1015
	[NetMessage(EMessageId.DropCatchLevelRewardUpdateNotify)]
	public sealed class DropCatchLevelRewardUpdateNotify : IMessage<DropCatchLevelRewardUpdateNotify>, IMessage, IEquatable<DropCatchLevelRewardUpdateNotify>, IDeepCloneable<DropCatchLevelRewardUpdateNotify>, IBufferMessage
	{
		// Token: 0x06006272 RID: 25202 RVA: 0x000ED3A8 File Offset: 0x000EB5A8
		[NullableContext(1)]
		public static DropCatchLevelRewardUpdateNotify Create()
		{
			return new DropCatchLevelRewardUpdateNotify();
		}

		// Token: 0x17001257 RID: 4695
		// (get) Token: 0x06006273 RID: 25203 RVA: 0x000ED3AF File Offset: 0x000EB5AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001258 RID: 4696
		// (get) Token: 0x06006274 RID: 25204 RVA: 0x000ED3B2 File Offset: 0x000EB5B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DropCatchLevelRewardUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06006275 RID: 25205 RVA: 0x000ED3B9 File Offset: 0x000EB5B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropCatchLevelRewardUpdateNotify()
		{
		}

		// Token: 0x06006276 RID: 25206 RVA: 0x000ED3CC File Offset: 0x000EB5CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropCatchLevelRewardUpdateNotify(DropCatchLevelRewardUpdateNotify other) : this()
		{
			this.dropCatchLevelInfos_ = other.dropCatchLevelInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006277 RID: 25207 RVA: 0x000ED3F6 File Offset: 0x000EB5F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropCatchLevelRewardUpdateNotify Clone()
		{
			return new DropCatchLevelRewardUpdateNotify(this);
		}

		// Token: 0x17001259 RID: 4697
		// (get) Token: 0x06006278 RID: 25208 RVA: 0x000ED3FE File Offset: 0x000EB5FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DropCatchLevelInfo> DropCatchLevelInfos
		{
			get
			{
				return this.dropCatchLevelInfos_;
			}
		}

		// Token: 0x06006279 RID: 25209 RVA: 0x000ED406 File Offset: 0x000EB606
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DropCatchLevelRewardUpdateNotify);
		}

		// Token: 0x0600627A RID: 25210 RVA: 0x000ED414 File Offset: 0x000EB614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DropCatchLevelRewardUpdateNotify other)
		{
			return other != null && (other == this || (this.dropCatchLevelInfos_.Equals(other.dropCatchLevelInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600627B RID: 25211 RVA: 0x000ED448 File Offset: 0x000EB648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.dropCatchLevelInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600627C RID: 25212 RVA: 0x000ED47C File Offset: 0x000EB67C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600627D RID: 25213 RVA: 0x000ED489 File Offset: 0x000EB689
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600627E RID: 25214 RVA: 0x000ED492 File Offset: 0x000EB692
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.dropCatchLevelInfos_.WriteTo(ref output, DropCatchLevelRewardUpdateNotify._repeated_dropCatchLevelInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600627F RID: 25215 RVA: 0x000ED4BC File Offset: 0x000EB6BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.dropCatchLevelInfos_.CalculateSize(DropCatchLevelRewardUpdateNotify._repeated_dropCatchLevelInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006280 RID: 25216 RVA: 0x000ED4F5 File Offset: 0x000EB6F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DropCatchLevelRewardUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.dropCatchLevelInfos_.Add(other.dropCatchLevelInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006281 RID: 25217 RVA: 0x000ED523 File Offset: 0x000EB723
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006282 RID: 25218 RVA: 0x000ED52C File Offset: 0x000EB72C
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
				if (num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.dropCatchLevelInfos_.AddEntriesFrom(ref input, DropCatchLevelRewardUpdateNotify._repeated_dropCatchLevelInfos_codec);
				}
			}
		}

		// Token: 0x04003837 RID: 14391
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003838 RID: 14392
		public const int DropCatchLevelInfosFieldNumber = 11;

		// Token: 0x04003839 RID: 14393
		private static readonly FieldCodec<DropCatchLevelInfo> _repeated_dropCatchLevelInfos_codec = FieldCodec.ForMessage<DropCatchLevelInfo>(90U, DropCatchLevelInfo.Parser);

		// Token: 0x0400383A RID: 14394
		private readonly RepeatedField<DropCatchLevelInfo> dropCatchLevelInfos_ = new RepeatedField<DropCatchLevelInfo>();
	}
}
