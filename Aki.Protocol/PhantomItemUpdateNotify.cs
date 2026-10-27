using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CE2 RID: 3298
	[NetMessage(EMessageId.PhantomItemUpdateNotify)]
	public sealed class PhantomItemUpdateNotify : IMessage<PhantomItemUpdateNotify>, IMessage, IEquatable<PhantomItemUpdateNotify>, IDeepCloneable<PhantomItemUpdateNotify>, IBufferMessage
	{
		// Token: 0x06011D85 RID: 73093 RVA: 0x0029C6FC File Offset: 0x0029A8FC
		[NullableContext(1)]
		public static PhantomItemUpdateNotify Create()
		{
			return new PhantomItemUpdateNotify();
		}

		// Token: 0x17003B25 RID: 15141
		// (get) Token: 0x06011D86 RID: 73094 RVA: 0x0029C703 File Offset: 0x0029A903
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B26 RID: 15142
		// (get) Token: 0x06011D87 RID: 73095 RVA: 0x0029C706 File Offset: 0x0029A906
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomItemUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06011D88 RID: 73096 RVA: 0x0029C70D File Offset: 0x0029A90D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomItemUpdateNotify()
		{
		}

		// Token: 0x06011D89 RID: 73097 RVA: 0x0029C720 File Offset: 0x0029A920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomItemUpdateNotify(PhantomItemUpdateNotify other) : this()
		{
			this.updateInfo_ = other.updateInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011D8A RID: 73098 RVA: 0x0029C74A File Offset: 0x0029A94A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomItemUpdateNotify Clone()
		{
			return new PhantomItemUpdateNotify(this);
		}

		// Token: 0x17003B27 RID: 15143
		// (get) Token: 0x06011D8B RID: 73099 RVA: 0x0029C752 File Offset: 0x0029A952
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomItem> UpdateInfo
		{
			get
			{
				return this.updateInfo_;
			}
		}

		// Token: 0x06011D8C RID: 73100 RVA: 0x0029C75A File Offset: 0x0029A95A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomItemUpdateNotify);
		}

		// Token: 0x06011D8D RID: 73101 RVA: 0x0029C768 File Offset: 0x0029A968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomItemUpdateNotify other)
		{
			return other != null && (other == this || (this.updateInfo_.Equals(other.updateInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011D8E RID: 73102 RVA: 0x0029C79C File Offset: 0x0029A99C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.updateInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011D8F RID: 73103 RVA: 0x0029C7D0 File Offset: 0x0029A9D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011D90 RID: 73104 RVA: 0x0029C7DD File Offset: 0x0029A9DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011D91 RID: 73105 RVA: 0x0029C7E6 File Offset: 0x0029A9E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.updateInfo_.WriteTo(ref output, PhantomItemUpdateNotify._repeated_updateInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011D92 RID: 73106 RVA: 0x0029C810 File Offset: 0x0029AA10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.updateInfo_.CalculateSize(PhantomItemUpdateNotify._repeated_updateInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011D93 RID: 73107 RVA: 0x0029C849 File Offset: 0x0029AA49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomItemUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.updateInfo_.Add(other.updateInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011D94 RID: 73108 RVA: 0x0029C877 File Offset: 0x0029AA77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011D95 RID: 73109 RVA: 0x0029C880 File Offset: 0x0029AA80
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
					this.updateInfo_.AddEntriesFrom(ref input, PhantomItemUpdateNotify._repeated_updateInfo_codec);
				}
			}
		}

		// Token: 0x04007010 RID: 28688
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007011 RID: 28689
		public const int UpdateInfoFieldNumber = 4;

		// Token: 0x04007012 RID: 28690
		private static readonly FieldCodec<PhantomItem> _repeated_updateInfo_codec = FieldCodec.ForMessage<PhantomItem>(34U, PhantomItem.Parser);

		// Token: 0x04007013 RID: 28691
		private readonly RepeatedField<PhantomItem> updateInfo_ = new RepeatedField<PhantomItem>();
	}
}
