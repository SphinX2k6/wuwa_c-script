using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000381 RID: 897
	[NetMessage(EMessageId.DangoBrawlStartFightNotify)]
	public sealed class DangoBrawlStartFightNotify : IMessage<DangoBrawlStartFightNotify>, IMessage, IEquatable<DangoBrawlStartFightNotify>, IDeepCloneable<DangoBrawlStartFightNotify>, IBufferMessage
	{
		// Token: 0x0600592D RID: 22829 RVA: 0x000D9B7A File Offset: 0x000D7D7A
		[NullableContext(1)]
		public static DangoBrawlStartFightNotify Create()
		{
			return new DangoBrawlStartFightNotify();
		}

		// Token: 0x17001071 RID: 4209
		// (get) Token: 0x0600592E RID: 22830 RVA: 0x000D9B81 File Offset: 0x000D7D81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001072 RID: 4210
		// (get) Token: 0x0600592F RID: 22831 RVA: 0x000D9B84 File Offset: 0x000D7D84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlStartFightNotify.Descriptor;
			}
		}

		// Token: 0x06005930 RID: 22832 RVA: 0x000D9B8B File Offset: 0x000D7D8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlStartFightNotify()
		{
		}

		// Token: 0x06005931 RID: 22833 RVA: 0x000D9B9E File Offset: 0x000D7D9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlStartFightNotify(DangoBrawlStartFightNotify other) : this()
		{
			this.fighters_ = other.fighters_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005932 RID: 22834 RVA: 0x000D9BC8 File Offset: 0x000D7DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlStartFightNotify Clone()
		{
			return new DangoBrawlStartFightNotify(this);
		}

		// Token: 0x17001073 RID: 4211
		// (get) Token: 0x06005933 RID: 22835 RVA: 0x000D9BD0 File Offset: 0x000D7DD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DangoBrawlFighterInfo> Fighters
		{
			get
			{
				return this.fighters_;
			}
		}

		// Token: 0x06005934 RID: 22836 RVA: 0x000D9BD8 File Offset: 0x000D7DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlStartFightNotify);
		}

		// Token: 0x06005935 RID: 22837 RVA: 0x000D9BE6 File Offset: 0x000D7DE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlStartFightNotify other)
		{
			return other != null && (other == this || (this.fighters_.Equals(other.fighters_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005936 RID: 22838 RVA: 0x000D9C1C File Offset: 0x000D7E1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.fighters_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005937 RID: 22839 RVA: 0x000D9C50 File Offset: 0x000D7E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005938 RID: 22840 RVA: 0x000D9C5D File Offset: 0x000D7E5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005939 RID: 22841 RVA: 0x000D9C66 File Offset: 0x000D7E66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.fighters_.WriteTo(ref output, DangoBrawlStartFightNotify._repeated_fighters_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600593A RID: 22842 RVA: 0x000D9C90 File Offset: 0x000D7E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.fighters_.CalculateSize(DangoBrawlStartFightNotify._repeated_fighters_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600593B RID: 22843 RVA: 0x000D9CC9 File Offset: 0x000D7EC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlStartFightNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.fighters_.Add(other.fighters_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600593C RID: 22844 RVA: 0x000D9CF7 File Offset: 0x000D7EF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600593D RID: 22845 RVA: 0x000D9D00 File Offset: 0x000D7F00
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
					this.fighters_.AddEntriesFrom(ref input, DangoBrawlStartFightNotify._repeated_fighters_codec);
				}
			}
		}

		// Token: 0x040035A6 RID: 13734
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035A7 RID: 13735
		public const int FightersFieldNumber = 3;

		// Token: 0x040035A8 RID: 13736
		private static readonly FieldCodec<DangoBrawlFighterInfo> _repeated_fighters_codec = FieldCodec.ForMessage<DangoBrawlFighterInfo>(26U, DangoBrawlFighterInfo.Parser);

		// Token: 0x040035A9 RID: 13737
		private readonly RepeatedField<DangoBrawlFighterInfo> fighters_ = new RepeatedField<DangoBrawlFighterInfo>();
	}
}
