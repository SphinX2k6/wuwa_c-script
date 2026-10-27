using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D06 RID: 3334
	[NetMessage(EMessageId.PhantomSkinAddNotify)]
	public sealed class PhantomSkinAddNotify : IMessage<PhantomSkinAddNotify>, IMessage, IEquatable<PhantomSkinAddNotify>, IDeepCloneable<PhantomSkinAddNotify>, IBufferMessage
	{
		// Token: 0x0601204B RID: 73803 RVA: 0x002A24B3 File Offset: 0x002A06B3
		[NullableContext(1)]
		public static PhantomSkinAddNotify Create()
		{
			return new PhantomSkinAddNotify();
		}

		// Token: 0x17003BB3 RID: 15283
		// (get) Token: 0x0601204C RID: 73804 RVA: 0x002A24BA File Offset: 0x002A06BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003BB4 RID: 15284
		// (get) Token: 0x0601204D RID: 73805 RVA: 0x002A24BD File Offset: 0x002A06BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomSkinAddNotify.Descriptor;
			}
		}

		// Token: 0x0601204E RID: 73806 RVA: 0x002A24C4 File Offset: 0x002A06C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSkinAddNotify()
		{
		}

		// Token: 0x0601204F RID: 73807 RVA: 0x002A24D7 File Offset: 0x002A06D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSkinAddNotify(PhantomSkinAddNotify other) : this()
		{
			this.skinIds_ = other.skinIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012050 RID: 73808 RVA: 0x002A2501 File Offset: 0x002A0701
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSkinAddNotify Clone()
		{
			return new PhantomSkinAddNotify(this);
		}

		// Token: 0x17003BB5 RID: 15285
		// (get) Token: 0x06012051 RID: 73809 RVA: 0x002A2509 File Offset: 0x002A0709
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SkinIds
		{
			get
			{
				return this.skinIds_;
			}
		}

		// Token: 0x06012052 RID: 73810 RVA: 0x002A2511 File Offset: 0x002A0711
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomSkinAddNotify);
		}

		// Token: 0x06012053 RID: 73811 RVA: 0x002A251F File Offset: 0x002A071F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomSkinAddNotify other)
		{
			return other != null && (other == this || (this.skinIds_.Equals(other.skinIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012054 RID: 73812 RVA: 0x002A2554 File Offset: 0x002A0754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.skinIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012055 RID: 73813 RVA: 0x002A2588 File Offset: 0x002A0788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012056 RID: 73814 RVA: 0x002A2595 File Offset: 0x002A0795
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012057 RID: 73815 RVA: 0x002A259E File Offset: 0x002A079E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.skinIds_.WriteTo(ref output, PhantomSkinAddNotify._repeated_skinIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012058 RID: 73816 RVA: 0x002A25C8 File Offset: 0x002A07C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.skinIds_.CalculateSize(PhantomSkinAddNotify._repeated_skinIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012059 RID: 73817 RVA: 0x002A2601 File Offset: 0x002A0801
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomSkinAddNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.skinIds_.Add(other.skinIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601205A RID: 73818 RVA: 0x002A262F File Offset: 0x002A082F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601205B RID: 73819 RVA: 0x002A2638 File Offset: 0x002A0838
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
				if (num != 120U && num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.skinIds_.AddEntriesFrom(ref input, PhantomSkinAddNotify._repeated_skinIds_codec);
				}
			}
		}

		// Token: 0x040070D8 RID: 28888
		private UnknownFieldSet _unknownFields;

		// Token: 0x040070D9 RID: 28889
		public const int SkinIdsFieldNumber = 15;

		// Token: 0x040070DA RID: 28890
		private static readonly FieldCodec<int> _repeated_skinIds_codec = FieldCodec.ForInt32(122U);

		// Token: 0x040070DB RID: 28891
		private readonly RepeatedField<int> skinIds_ = new RepeatedField<int>();
	}
}
