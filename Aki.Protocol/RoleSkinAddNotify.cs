using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010A8 RID: 4264
	[NetMessage(EMessageId.RoleSkinAddNotify)]
	public sealed class RoleSkinAddNotify : IMessage<RoleSkinAddNotify>, IMessage, IEquatable<RoleSkinAddNotify>, IDeepCloneable<RoleSkinAddNotify>, IBufferMessage
	{
		// Token: 0x06016CB2 RID: 93362 RVA: 0x003505C3 File Offset: 0x0034E7C3
		[NullableContext(1)]
		public static RoleSkinAddNotify Create()
		{
			return new RoleSkinAddNotify();
		}

		// Token: 0x17004C65 RID: 19557
		// (get) Token: 0x06016CB3 RID: 93363 RVA: 0x003505CA File Offset: 0x0034E7CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C66 RID: 19558
		// (get) Token: 0x06016CB4 RID: 93364 RVA: 0x003505CD File Offset: 0x0034E7CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleSkinAddNotify.Descriptor;
			}
		}

		// Token: 0x06016CB5 RID: 93365 RVA: 0x003505D4 File Offset: 0x0034E7D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinAddNotify()
		{
		}

		// Token: 0x06016CB6 RID: 93366 RVA: 0x003505E7 File Offset: 0x0034E7E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinAddNotify(RoleSkinAddNotify other) : this()
		{
			this.skinIds_ = other.skinIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016CB7 RID: 93367 RVA: 0x00350611 File Offset: 0x0034E811
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinAddNotify Clone()
		{
			return new RoleSkinAddNotify(this);
		}

		// Token: 0x17004C67 RID: 19559
		// (get) Token: 0x06016CB8 RID: 93368 RVA: 0x00350619 File Offset: 0x0034E819
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SkinIds
		{
			get
			{
				return this.skinIds_;
			}
		}

		// Token: 0x06016CB9 RID: 93369 RVA: 0x00350621 File Offset: 0x0034E821
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleSkinAddNotify);
		}

		// Token: 0x06016CBA RID: 93370 RVA: 0x0035062F File Offset: 0x0034E82F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleSkinAddNotify other)
		{
			return other != null && (other == this || (this.skinIds_.Equals(other.skinIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016CBB RID: 93371 RVA: 0x00350664 File Offset: 0x0034E864
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

		// Token: 0x06016CBC RID: 93372 RVA: 0x00350698 File Offset: 0x0034E898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016CBD RID: 93373 RVA: 0x003506A5 File Offset: 0x0034E8A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016CBE RID: 93374 RVA: 0x003506AE File Offset: 0x0034E8AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.skinIds_.WriteTo(ref output, RoleSkinAddNotify._repeated_skinIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016CBF RID: 93375 RVA: 0x003506D8 File Offset: 0x0034E8D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.skinIds_.CalculateSize(RoleSkinAddNotify._repeated_skinIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016CC0 RID: 93376 RVA: 0x00350711 File Offset: 0x0034E911
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleSkinAddNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.skinIds_.Add(other.skinIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016CC1 RID: 93377 RVA: 0x0035073F File Offset: 0x0034E93F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016CC2 RID: 93378 RVA: 0x00350748 File Offset: 0x0034E948
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
				if (num != 24U && num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.skinIds_.AddEntriesFrom(ref input, RoleSkinAddNotify._repeated_skinIds_codec);
				}
			}
		}

		// Token: 0x0400887D RID: 34941
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400887E RID: 34942
		public const int SkinIdsFieldNumber = 3;

		// Token: 0x0400887F RID: 34943
		private static readonly FieldCodec<int> _repeated_skinIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04008880 RID: 34944
		private readonly RepeatedField<int> skinIds_ = new RepeatedField<int>();
	}
}
