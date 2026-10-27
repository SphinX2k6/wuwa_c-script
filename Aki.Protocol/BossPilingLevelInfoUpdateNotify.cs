using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001C6 RID: 454
	[NetMessage(EMessageId.BossPilingLevelInfoUpdateNotify)]
	public sealed class BossPilingLevelInfoUpdateNotify : IMessage<BossPilingLevelInfoUpdateNotify>, IMessage, IEquatable<BossPilingLevelInfoUpdateNotify>, IDeepCloneable<BossPilingLevelInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06003417 RID: 13335 RVA: 0x000839B4 File Offset: 0x00081BB4
		[NullableContext(1)]
		public static BossPilingLevelInfoUpdateNotify Create()
		{
			return new BossPilingLevelInfoUpdateNotify();
		}

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x06003418 RID: 13336 RVA: 0x000839BB File Offset: 0x00081BBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x06003419 RID: 13337 RVA: 0x000839BE File Offset: 0x00081BBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossPilingLevelInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600341A RID: 13338 RVA: 0x000839C5 File Offset: 0x00081BC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingLevelInfoUpdateNotify()
		{
		}

		// Token: 0x0600341B RID: 13339 RVA: 0x000839D8 File Offset: 0x00081BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingLevelInfoUpdateNotify(BossPilingLevelInfoUpdateNotify other) : this()
		{
			this.bossPilingLevelInfo_ = other.bossPilingLevelInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600341C RID: 13340 RVA: 0x00083A02 File Offset: 0x00081C02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingLevelInfoUpdateNotify Clone()
		{
			return new BossPilingLevelInfoUpdateNotify(this);
		}

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x0600341D RID: 13341 RVA: 0x00083A0A File Offset: 0x00081C0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BossPilingLevelInfo> BossPilingLevelInfo
		{
			get
			{
				return this.bossPilingLevelInfo_;
			}
		}

		// Token: 0x0600341E RID: 13342 RVA: 0x00083A12 File Offset: 0x00081C12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossPilingLevelInfoUpdateNotify);
		}

		// Token: 0x0600341F RID: 13343 RVA: 0x00083A20 File Offset: 0x00081C20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossPilingLevelInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.bossPilingLevelInfo_.Equals(other.bossPilingLevelInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003420 RID: 13344 RVA: 0x00083A54 File Offset: 0x00081C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.bossPilingLevelInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003421 RID: 13345 RVA: 0x00083A88 File Offset: 0x00081C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003422 RID: 13346 RVA: 0x00083A95 File Offset: 0x00081C95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003423 RID: 13347 RVA: 0x00083A9E File Offset: 0x00081C9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.bossPilingLevelInfo_.WriteTo(ref output, BossPilingLevelInfoUpdateNotify._repeated_bossPilingLevelInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003424 RID: 13348 RVA: 0x00083AC8 File Offset: 0x00081CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.bossPilingLevelInfo_.CalculateSize(BossPilingLevelInfoUpdateNotify._repeated_bossPilingLevelInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003425 RID: 13349 RVA: 0x00083B01 File Offset: 0x00081D01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossPilingLevelInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.bossPilingLevelInfo_.Add(other.bossPilingLevelInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003426 RID: 13350 RVA: 0x00083B2F File Offset: 0x00081D2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003427 RID: 13351 RVA: 0x00083B38 File Offset: 0x00081D38
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
				if (num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.bossPilingLevelInfo_.AddEntriesFrom(ref input, BossPilingLevelInfoUpdateNotify._repeated_bossPilingLevelInfo_codec);
				}
			}
		}

		// Token: 0x040029F1 RID: 10737
		private UnknownFieldSet _unknownFields;

		// Token: 0x040029F2 RID: 10738
		public const int BossPilingLevelInfoFieldNumber = 8;

		// Token: 0x040029F3 RID: 10739
		private static readonly FieldCodec<BossPilingLevelInfo> _repeated_bossPilingLevelInfo_codec = FieldCodec.ForMessage<BossPilingLevelInfo>(66U, Aki.Protocol.BossPilingLevelInfo.Parser);

		// Token: 0x040029F4 RID: 10740
		private readonly RepeatedField<BossPilingLevelInfo> bossPilingLevelInfo_ = new RepeatedField<BossPilingLevelInfo>();
	}
}
