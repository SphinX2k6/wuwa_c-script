using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B4F RID: 2895
	[NetMessage(EMessageId.NormalItemUpdateNotify)]
	public sealed class NormalItemUpdateNotify : IMessage<NormalItemUpdateNotify>, IMessage, IEquatable<NormalItemUpdateNotify>, IDeepCloneable<NormalItemUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600FB3C RID: 64316 RVA: 0x00249D51 File Offset: 0x00247F51
		[NullableContext(1)]
		public static NormalItemUpdateNotify Create()
		{
			return new NormalItemUpdateNotify();
		}

		// Token: 0x17003332 RID: 13106
		// (get) Token: 0x0600FB3D RID: 64317 RVA: 0x00249D58 File Offset: 0x00247F58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003333 RID: 13107
		// (get) Token: 0x0600FB3E RID: 64318 RVA: 0x00249D5B File Offset: 0x00247F5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NormalItemUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600FB3F RID: 64319 RVA: 0x00249D62 File Offset: 0x00247F62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalItemUpdateNotify()
		{
		}

		// Token: 0x0600FB40 RID: 64320 RVA: 0x00249D75 File Offset: 0x00247F75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalItemUpdateNotify(NormalItemUpdateNotify other) : this()
		{
			this.normalItemList_ = other.normalItemList_.Clone();
			this.noTips_ = other.noTips_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FB41 RID: 64321 RVA: 0x00249DAB File Offset: 0x00247FAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalItemUpdateNotify Clone()
		{
			return new NormalItemUpdateNotify(this);
		}

		// Token: 0x17003334 RID: 13108
		// (get) Token: 0x0600FB42 RID: 64322 RVA: 0x00249DB3 File Offset: 0x00247FB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NormalItem> NormalItemList
		{
			get
			{
				return this.normalItemList_;
			}
		}

		// Token: 0x17003335 RID: 13109
		// (get) Token: 0x0600FB43 RID: 64323 RVA: 0x00249DBB File Offset: 0x00247FBB
		// (set) Token: 0x0600FB44 RID: 64324 RVA: 0x00249DC3 File Offset: 0x00247FC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NoTips
		{
			get
			{
				return this.noTips_;
			}
			set
			{
				this.noTips_ = value;
			}
		}

		// Token: 0x0600FB45 RID: 64325 RVA: 0x00249DCC File Offset: 0x00247FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NormalItemUpdateNotify);
		}

		// Token: 0x0600FB46 RID: 64326 RVA: 0x00249DDC File Offset: 0x00247FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NormalItemUpdateNotify other)
		{
			return other != null && (other == this || (this.normalItemList_.Equals(other.normalItemList_) && this.NoTips == other.NoTips && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FB47 RID: 64327 RVA: 0x00249E2C File Offset: 0x0024802C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.normalItemList_.GetHashCode();
			if (this.NoTips)
			{
				num ^= this.NoTips.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FB48 RID: 64328 RVA: 0x00249E79 File Offset: 0x00248079
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FB49 RID: 64329 RVA: 0x00249E86 File Offset: 0x00248086
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FB4A RID: 64330 RVA: 0x00249E90 File Offset: 0x00248090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NoTips)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.NoTips);
			}
			this.normalItemList_.WriteTo(ref output, NormalItemUpdateNotify._repeated_normalItemList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FB4B RID: 64331 RVA: 0x00249EE0 File Offset: 0x002480E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.normalItemList_.CalculateSize(NormalItemUpdateNotify._repeated_normalItemList_codec);
			if (this.NoTips)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FB4C RID: 64332 RVA: 0x00249F28 File Offset: 0x00248128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NormalItemUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.normalItemList_.Add(other.normalItemList_);
			if (other.NoTips)
			{
				this.NoTips = other.NoTips;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FB4D RID: 64333 RVA: 0x00249F75 File Offset: 0x00248175
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FB4E RID: 64334 RVA: 0x00249F80 File Offset: 0x00248180
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
				if (num != 32U)
				{
					if (num != 66U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.normalItemList_.AddEntriesFrom(ref input, NormalItemUpdateNotify._repeated_normalItemList_codec);
					}
				}
				else
				{
					this.NoTips = input.ReadBool();
				}
			}
		}

		// Token: 0x040064C6 RID: 25798
		private UnknownFieldSet _unknownFields;

		// Token: 0x040064C7 RID: 25799
		public const int NormalItemListFieldNumber = 8;

		// Token: 0x040064C8 RID: 25800
		private static readonly FieldCodec<NormalItem> _repeated_normalItemList_codec = FieldCodec.ForMessage<NormalItem>(66U, NormalItem.Parser);

		// Token: 0x040064C9 RID: 25801
		private readonly RepeatedField<NormalItem> normalItemList_ = new RepeatedField<NormalItem>();

		// Token: 0x040064CA RID: 25802
		public const int NoTipsFieldNumber = 4;

		// Token: 0x040064CB RID: 25803
		private bool noTips_;
	}
}
