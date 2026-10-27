using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000333 RID: 819
	public sealed class DangoBrawlBagInfo : IMessage<DangoBrawlBagInfo>, IMessage, IEquatable<DangoBrawlBagInfo>, IDeepCloneable<DangoBrawlBagInfo>, IBufferMessage
	{
		// Token: 0x06005254 RID: 21076 RVA: 0x000C919C File Offset: 0x000C739C
		[NullableContext(1)]
		public static DangoBrawlBagInfo Create()
		{
			return new DangoBrawlBagInfo();
		}

		// Token: 0x17000EEB RID: 3819
		// (get) Token: 0x06005255 RID: 21077 RVA: 0x000C91A3 File Offset: 0x000C73A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000EEC RID: 3820
		// (get) Token: 0x06005256 RID: 21078 RVA: 0x000C91A6 File Offset: 0x000C73A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlBagInfo.Descriptor;
			}
		}

		// Token: 0x06005257 RID: 21079 RVA: 0x000C91AD File Offset: 0x000C73AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBagInfo()
		{
		}

		// Token: 0x06005258 RID: 21080 RVA: 0x000C91CB File Offset: 0x000C73CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBagInfo(DangoBrawlBagInfo other) : this()
		{
			this.normalItems_ = other.normalItems_.Clone();
			this.benchItems_ = other.benchItems_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005259 RID: 21081 RVA: 0x000C9206 File Offset: 0x000C7406
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBagInfo Clone()
		{
			return new DangoBrawlBagInfo(this);
		}

		// Token: 0x17000EED RID: 3821
		// (get) Token: 0x0600525A RID: 21082 RVA: 0x000C920E File Offset: 0x000C740E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DangoBrawlNormalBagItemInfo> NormalItems
		{
			get
			{
				return this.normalItems_;
			}
		}

		// Token: 0x17000EEE RID: 3822
		// (get) Token: 0x0600525B RID: 21083 RVA: 0x000C9216 File Offset: 0x000C7416
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DangoBrawlBenchItemInfo> BenchItems
		{
			get
			{
				return this.benchItems_;
			}
		}

		// Token: 0x0600525C RID: 21084 RVA: 0x000C921E File Offset: 0x000C741E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlBagInfo);
		}

		// Token: 0x0600525D RID: 21085 RVA: 0x000C922C File Offset: 0x000C742C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlBagInfo other)
		{
			return other != null && (other == this || (this.normalItems_.Equals(other.normalItems_) && this.benchItems_.Equals(other.benchItems_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600525E RID: 21086 RVA: 0x000C9280 File Offset: 0x000C7480
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

		// Token: 0x0600525F RID: 21087 RVA: 0x000C92C2 File Offset: 0x000C74C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005260 RID: 21088 RVA: 0x000C92CF File Offset: 0x000C74CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005261 RID: 21089 RVA: 0x000C92D8 File Offset: 0x000C74D8
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

		// Token: 0x06005262 RID: 21090 RVA: 0x000C9310 File Offset: 0x000C7510
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

		// Token: 0x06005263 RID: 21091 RVA: 0x000C935C File Offset: 0x000C755C
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

		// Token: 0x06005264 RID: 21092 RVA: 0x000C939B File Offset: 0x000C759B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005265 RID: 21093 RVA: 0x000C93A4 File Offset: 0x000C75A4
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

		// Token: 0x0400332C RID: 13100
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400332D RID: 13101
		public const int NormalItemsFieldNumber = 1;

		// Token: 0x0400332E RID: 13102
		private static readonly FieldCodec<DangoBrawlNormalBagItemInfo> _repeated_normalItems_codec = FieldCodec.ForMessage<DangoBrawlNormalBagItemInfo>(10U, DangoBrawlNormalBagItemInfo.Parser);

		// Token: 0x0400332F RID: 13103
		private readonly RepeatedField<DangoBrawlNormalBagItemInfo> normalItems_ = new RepeatedField<DangoBrawlNormalBagItemInfo>();

		// Token: 0x04003330 RID: 13104
		public const int BenchItemsFieldNumber = 2;

		// Token: 0x04003331 RID: 13105
		private static readonly FieldCodec<DangoBrawlBenchItemInfo> _repeated_benchItems_codec = FieldCodec.ForMessage<DangoBrawlBenchItemInfo>(18U, DangoBrawlBenchItemInfo.Parser);

		// Token: 0x04003332 RID: 13106
		private readonly RepeatedField<DangoBrawlBenchItemInfo> benchItems_ = new RepeatedField<DangoBrawlBenchItemInfo>();
	}
}
