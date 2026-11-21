using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006EE RID: 1774
	public sealed class GolemCrackActivityInfo : IMessage<GolemCrackActivityInfo>, IMessage, IEquatable<GolemCrackActivityInfo>, IDeepCloneable<GolemCrackActivityInfo>, IBufferMessage
	{
		// Token: 0x0600A1F4 RID: 41460 RVA: 0x00187DB9 File Offset: 0x00185FB9
		[NullableContext(1)]
		public static GolemCrackActivityInfo Create()
		{
			return new GolemCrackActivityInfo();
		}

		// Token: 0x17002087 RID: 8327
		// (get) Token: 0x0600A1F5 RID: 41461 RVA: 0x00187DC0 File Offset: 0x00185FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002088 RID: 8328
		// (get) Token: 0x0600A1F6 RID: 41462 RVA: 0x00187DC3 File Offset: 0x00185FC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GolemCrackActivityInfo.Descriptor;
			}
		}

		// Token: 0x0600A1F7 RID: 41463 RVA: 0x00187DCA File Offset: 0x00185FCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GolemCrackActivityInfo()
		{
		}

		// Token: 0x0600A1F8 RID: 41464 RVA: 0x00187DDD File Offset: 0x00185FDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GolemCrackActivityInfo(GolemCrackActivityInfo other) : this()
		{
			this.golemCrackLevelInfos_ = other.golemCrackLevelInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A1F9 RID: 41465 RVA: 0x00187E07 File Offset: 0x00186007
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GolemCrackActivityInfo Clone()
		{
			return new GolemCrackActivityInfo(this);
		}

		// Token: 0x17002089 RID: 8329
		// (get) Token: 0x0600A1FA RID: 41466 RVA: 0x00187E0F File Offset: 0x0018600F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GolemCrackLevelInfo> GolemCrackLevelInfos
		{
			get
			{
				return this.golemCrackLevelInfos_;
			}
		}

		// Token: 0x0600A1FB RID: 41467 RVA: 0x00187E17 File Offset: 0x00186017
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GolemCrackActivityInfo);
		}

		// Token: 0x0600A1FC RID: 41468 RVA: 0x00187E25 File Offset: 0x00186025
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GolemCrackActivityInfo other)
		{
			return other != null && (other == this || (this.golemCrackLevelInfos_.Equals(other.golemCrackLevelInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A1FD RID: 41469 RVA: 0x00187E58 File Offset: 0x00186058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.golemCrackLevelInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A1FE RID: 41470 RVA: 0x00187E8C File Offset: 0x0018608C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A1FF RID: 41471 RVA: 0x00187E99 File Offset: 0x00186099
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A200 RID: 41472 RVA: 0x00187EA2 File Offset: 0x001860A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.golemCrackLevelInfos_.WriteTo(ref output, GolemCrackActivityInfo._repeated_golemCrackLevelInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A201 RID: 41473 RVA: 0x00187ECC File Offset: 0x001860CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.golemCrackLevelInfos_.CalculateSize(GolemCrackActivityInfo._repeated_golemCrackLevelInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A202 RID: 41474 RVA: 0x00187F05 File Offset: 0x00186105
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GolemCrackActivityInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.golemCrackLevelInfos_.Add(other.golemCrackLevelInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A203 RID: 41475 RVA: 0x00187F33 File Offset: 0x00186133
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A204 RID: 41476 RVA: 0x00187F3C File Offset: 0x0018613C
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
					this.golemCrackLevelInfos_.AddEntriesFrom(ref input, GolemCrackActivityInfo._repeated_golemCrackLevelInfos_codec);
				}
			}
		}

		// Token: 0x04004B75 RID: 19317
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B76 RID: 19318
		public const int GolemCrackLevelInfosFieldNumber = 1;

		// Token: 0x04004B77 RID: 19319
		private static readonly FieldCodec<GolemCrackLevelInfo> _repeated_golemCrackLevelInfos_codec = FieldCodec.ForMessage<GolemCrackLevelInfo>(10U, GolemCrackLevelInfo.Parser);

		// Token: 0x04004B78 RID: 19320
		private readonly RepeatedField<GolemCrackLevelInfo> golemCrackLevelInfos_ = new RepeatedField<GolemCrackLevelInfo>();
	}
}
