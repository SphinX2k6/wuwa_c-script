using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000229 RID: 553
	[NetMessage(EMessageId.CalabashSkinUpdateNotify)]
	public sealed class CalabashSkinUpdateNotify : IMessage<CalabashSkinUpdateNotify>, IMessage, IEquatable<CalabashSkinUpdateNotify>, IDeepCloneable<CalabashSkinUpdateNotify>, IBufferMessage
	{
		// Token: 0x06003C1F RID: 15391 RVA: 0x00095574 File Offset: 0x00093774
		[NullableContext(1)]
		public static CalabashSkinUpdateNotify Create()
		{
			return new CalabashSkinUpdateNotify();
		}

		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x06003C20 RID: 15392 RVA: 0x0009557B File Offset: 0x0009377B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x06003C21 RID: 15393 RVA: 0x0009557E File Offset: 0x0009377E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CalabashSkinUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06003C22 RID: 15394 RVA: 0x00095585 File Offset: 0x00093785
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashSkinUpdateNotify()
		{
		}

		// Token: 0x06003C23 RID: 15395 RVA: 0x00095598 File Offset: 0x00093798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashSkinUpdateNotify(CalabashSkinUpdateNotify other) : this()
		{
			this.skinIds_ = other.skinIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003C24 RID: 15396 RVA: 0x000955C2 File Offset: 0x000937C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashSkinUpdateNotify Clone()
		{
			return new CalabashSkinUpdateNotify(this);
		}

		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x06003C25 RID: 15397 RVA: 0x000955CA File Offset: 0x000937CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SkinIds
		{
			get
			{
				return this.skinIds_;
			}
		}

		// Token: 0x06003C26 RID: 15398 RVA: 0x000955D2 File Offset: 0x000937D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CalabashSkinUpdateNotify);
		}

		// Token: 0x06003C27 RID: 15399 RVA: 0x000955E0 File Offset: 0x000937E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CalabashSkinUpdateNotify other)
		{
			return other != null && (other == this || (this.skinIds_.Equals(other.skinIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003C28 RID: 15400 RVA: 0x00095614 File Offset: 0x00093814
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

		// Token: 0x06003C29 RID: 15401 RVA: 0x00095648 File Offset: 0x00093848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003C2A RID: 15402 RVA: 0x00095655 File Offset: 0x00093855
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003C2B RID: 15403 RVA: 0x0009565E File Offset: 0x0009385E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.skinIds_.WriteTo(ref output, CalabashSkinUpdateNotify._repeated_skinIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003C2C RID: 15404 RVA: 0x00095688 File Offset: 0x00093888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.skinIds_.CalculateSize(CalabashSkinUpdateNotify._repeated_skinIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003C2D RID: 15405 RVA: 0x000956C1 File Offset: 0x000938C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CalabashSkinUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.skinIds_.Add(other.skinIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003C2E RID: 15406 RVA: 0x000956EF File Offset: 0x000938EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003C2F RID: 15407 RVA: 0x000956F8 File Offset: 0x000938F8
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
				if (num != 112U && num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.skinIds_.AddEntriesFrom(ref input, CalabashSkinUpdateNotify._repeated_skinIds_codec);
				}
			}
		}

		// Token: 0x04002C53 RID: 11347
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C54 RID: 11348
		public const int SkinIdsFieldNumber = 14;

		// Token: 0x04002C55 RID: 11349
		private static readonly FieldCodec<int> _repeated_skinIds_codec = FieldCodec.ForInt32(114U);

		// Token: 0x04002C56 RID: 11350
		private readonly RepeatedField<int> skinIds_ = new RepeatedField<int>();
	}
}
