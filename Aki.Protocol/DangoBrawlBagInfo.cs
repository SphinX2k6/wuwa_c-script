using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200033B RID: 827
	public sealed class DangoBrawlBagInfo : IMessage<DangoBrawlBagInfo>, IMessage, IEquatable<DangoBrawlBagInfo>, IDeepCloneable<DangoBrawlBagInfo>, IBufferMessage
	{
		// Token: 0x06005341 RID: 21313 RVA: 0x000CB820 File Offset: 0x000C9A20
		[NullableContext(1)]
		public static DangoBrawlBagInfo Create()
		{
			return new DangoBrawlBagInfo();
		}

		// Token: 0x17000F1C RID: 3868
		// (get) Token: 0x06005342 RID: 21314 RVA: 0x000CB827 File Offset: 0x000C9A27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F1D RID: 3869
		// (get) Token: 0x06005343 RID: 21315 RVA: 0x000CB82A File Offset: 0x000C9A2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlBagInfo.Descriptor;
			}
		}

		// Token: 0x06005344 RID: 21316 RVA: 0x000CB831 File Offset: 0x000C9A31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBagInfo()
		{
		}

		// Token: 0x06005345 RID: 21317 RVA: 0x000CB84F File Offset: 0x000C9A4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBagInfo(DangoBrawlBagInfo other) : this()
		{
			this.normalItems_ = other.normalItems_.Clone();
			this.benchItems_ = other.benchItems_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005346 RID: 21318 RVA: 0x000CB88A File Offset: 0x000C9A8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBagInfo Clone()
		{
			return new DangoBrawlBagInfo(this);
		}

		// Token: 0x17000F1E RID: 3870
		// (get) Token: 0x06005347 RID: 21319 RVA: 0x000CB892 File Offset: 0x000C9A92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DangoBrawlNormalBagItemInfo> NormalItems
		{
			get
			{
				return this.normalItems_;
			}
		}

		// Token: 0x17000F1F RID: 3871
		// (get) Token: 0x06005348 RID: 21320 RVA: 0x000CB89A File Offset: 0x000C9A9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DangoBrawlBenchItemInfo> BenchItems
		{
			get
			{
				return this.benchItems_;
			}
		}

		// Token: 0x06005349 RID: 21321 RVA: 0x000CB8A2 File Offset: 0x000C9AA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlBagInfo);
		}

		// Token: 0x0600534A RID: 21322 RVA: 0x000CB8B0 File Offset: 0x000C9AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlBagInfo other)
		{
			return other != null && (other == this || (this.normalItems_.Equals(other.normalItems_) && this.benchItems_.Equals(other.benchItems_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600534B RID: 21323 RVA: 0x000CB904 File Offset: 0x000C9B04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.normalItems_.GetHashCode();
			num ^= this.benchItems_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600534C RID: 21324 RVA: 0x000CB946 File Offset: 0x000C9B46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600534D RID: 21325 RVA: 0x000CB953 File Offset: 0x000C9B53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600534E RID: 21326 RVA: 0x000CB95C File Offset: 0x000C9B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.normalItems_.WriteTo(ref output, DangoBrawlBagInfo._repeated_normalItems_codec);
			this.benchItems_.WriteTo(ref output, DangoBrawlBagInfo._repeated_benchItems_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600534F RID: 21327 RVA: 0x000CB994 File Offset: 0x000C9B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.normalItems_.CalculateSize(DangoBrawlBagInfo._repeated_normalItems_codec);
			num += this.benchItems_.CalculateSize(DangoBrawlBagInfo._repeated_benchItems_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005350 RID: 21328 RVA: 0x000CB9E0 File Offset: 0x000C9BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlBagInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.normalItems_.Add(other.normalItems_);
			this.benchItems_.Add(other.benchItems_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005351 RID: 21329 RVA: 0x000CBA1F File Offset: 0x000C9C1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005352 RID: 21330 RVA: 0x000CBA28 File Offset: 0x000C9C28
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.benchItems_.AddEntriesFrom(ref input, DangoBrawlBagInfo._repeated_benchItems_codec);
					}
				}
				else
				{
					this.normalItems_.AddEntriesFrom(ref input, DangoBrawlBagInfo._repeated_normalItems_codec);
				}
			}
		}

		// Token: 0x040033C8 RID: 13256
		private UnknownFieldSet _unknownFields;

		// Token: 0x040033C9 RID: 13257
		public const int NormalItemsFieldNumber = 1;

		// Token: 0x040033CA RID: 13258
		private static readonly FieldCodec<DangoBrawlNormalBagItemInfo> _repeated_normalItems_codec = FieldCodec.ForMessage<DangoBrawlNormalBagItemInfo>(10U, DangoBrawlNormalBagItemInfo.Parser);

		// Token: 0x040033CB RID: 13259
		private readonly RepeatedField<DangoBrawlNormalBagItemInfo> normalItems_ = new RepeatedField<DangoBrawlNormalBagItemInfo>();

		// Token: 0x040033CC RID: 13260
		public const int BenchItemsFieldNumber = 2;

		// Token: 0x040033CD RID: 13261
		private static readonly FieldCodec<DangoBrawlBenchItemInfo> _repeated_benchItems_codec = FieldCodec.ForMessage<DangoBrawlBenchItemInfo>(18U, DangoBrawlBenchItemInfo.Parser);

		// Token: 0x040033CE RID: 13262
		private readonly RepeatedField<DangoBrawlBenchItemInfo> benchItems_ = new RepeatedField<DangoBrawlBenchItemInfo>();
	}
}
