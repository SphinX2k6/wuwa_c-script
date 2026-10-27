using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F01 RID: 3841
	[NetMessage(EMessageId.RemoveMarkInfoNotify)]
	public sealed class RemoveMarkInfoNotify : IMessage<RemoveMarkInfoNotify>, IMessage, IEquatable<RemoveMarkInfoNotify>, IDeepCloneable<RemoveMarkInfoNotify>, IBufferMessage
	{
		// Token: 0x06014936 RID: 84278 RVA: 0x002FD1C0 File Offset: 0x002FB3C0
		[NullableContext(1)]
		public static RemoveMarkInfoNotify Create()
		{
			return new RemoveMarkInfoNotify();
		}

		// Token: 0x1700446C RID: 17516
		// (get) Token: 0x06014937 RID: 84279 RVA: 0x002FD1C7 File Offset: 0x002FB3C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700446D RID: 17517
		// (get) Token: 0x06014938 RID: 84280 RVA: 0x002FD1CA File Offset: 0x002FB3CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveMarkInfoNotify.Descriptor;
			}
		}

		// Token: 0x06014939 RID: 84281 RVA: 0x002FD1D1 File Offset: 0x002FB3D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveMarkInfoNotify()
		{
		}

		// Token: 0x0601493A RID: 84282 RVA: 0x002FD1E4 File Offset: 0x002FB3E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveMarkInfoNotify(RemoveMarkInfoNotify other) : this()
		{
			this.markIds_ = other.markIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601493B RID: 84283 RVA: 0x002FD20E File Offset: 0x002FB40E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveMarkInfoNotify Clone()
		{
			return new RemoveMarkInfoNotify(this);
		}

		// Token: 0x1700446E RID: 17518
		// (get) Token: 0x0601493C RID: 84284 RVA: 0x002FD216 File Offset: 0x002FB416
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MarkIds
		{
			get
			{
				return this.markIds_;
			}
		}

		// Token: 0x0601493D RID: 84285 RVA: 0x002FD21E File Offset: 0x002FB41E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveMarkInfoNotify);
		}

		// Token: 0x0601493E RID: 84286 RVA: 0x002FD22C File Offset: 0x002FB42C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveMarkInfoNotify other)
		{
			return other != null && (other == this || (this.markIds_.Equals(other.markIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601493F RID: 84287 RVA: 0x002FD260 File Offset: 0x002FB460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.markIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014940 RID: 84288 RVA: 0x002FD294 File Offset: 0x002FB494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014941 RID: 84289 RVA: 0x002FD2A1 File Offset: 0x002FB4A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014942 RID: 84290 RVA: 0x002FD2AA File Offset: 0x002FB4AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.markIds_.WriteTo(ref output, RemoveMarkInfoNotify._repeated_markIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014943 RID: 84291 RVA: 0x002FD2D4 File Offset: 0x002FB4D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.markIds_.CalculateSize(RemoveMarkInfoNotify._repeated_markIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014944 RID: 84292 RVA: 0x002FD30D File Offset: 0x002FB50D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoveMarkInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.markIds_.Add(other.markIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014945 RID: 84293 RVA: 0x002FD33B File Offset: 0x002FB53B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014946 RID: 84294 RVA: 0x002FD344 File Offset: 0x002FB544
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
				if (num != 48U && num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.markIds_.AddEntriesFrom(ref input, RemoveMarkInfoNotify._repeated_markIds_codec);
				}
			}
		}

		// Token: 0x04007CA3 RID: 31907
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007CA4 RID: 31908
		public const int MarkIdsFieldNumber = 6;

		// Token: 0x04007CA5 RID: 31909
		private static readonly FieldCodec<int> _repeated_markIds_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04007CA6 RID: 31910
		private readonly RepeatedField<int> markIds_ = new RepeatedField<int>();
	}
}
